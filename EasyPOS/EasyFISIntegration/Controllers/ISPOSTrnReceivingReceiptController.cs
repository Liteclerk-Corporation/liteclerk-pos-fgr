﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace EasyPOS.EasyFISIntegration.Controllers
{
    class ISPOSTrnReceivingReceiptController
    {
        // ====
        // Data
        // ====
        private Data.easyposdbDataContext posdb = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        public Forms.Software.SysSettings.SysSettingsForm sysSettingsForm;
        public String activityDate;

        // ===========
        // Constructor
        // ===========
        public ISPOSTrnReceivingReceiptController(Forms.Software.SysSettings.SysSettingsForm form, String actDate)
        {
            sysSettingsForm = form;
            activityDate = actDate;
        }

        // ===================
        // Fill Leading Zeroes
        // ===================
        public String FillLeadingZeroes(Int32 number, Int32 length)
        {
            var result = number.ToString();
            var pad = length - result.Length;
            while (pad > 0)
            {
                result = '0' + result;
                pad--;
            }

            return result;
        }

        // ======================
        // Sync Receiving Receipt
        // ======================
        public async void SyncReceivingReceipt(String apiUrlHost, String branchCode)
        {
            await GetReceivingReceipt(apiUrlHost, branchCode);
        }

        // =====================
        // Get Receiving Receipt
        // =====================
        public Task GetReceivingReceipt(String apiUrlHost, String branchCode)
        {
            try
            {
                DateTime dateTimeToday = DateTime.Now;
                String receivingReceiptDate = Convert.ToDateTime(activityDate).ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);

                // ============
                // Http Request
                // ============
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://" + apiUrlHost + "/api/get/POSIntegration/receivingReceipt/" + receivingReceiptDate + "/" + branchCode);
                httpWebRequest.Method = "GET";
                httpWebRequest.Accept = "application/json";

                // ================
                // Process Response
                // ================
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    List<Entities.ISPOSTrnReceivingReceipt> receivingReceipts = (List<Entities.ISPOSTrnReceivingReceipt>)js.Deserialize(result, typeof(List<Entities.ISPOSTrnReceivingReceipt>));

                    if (receivingReceipts.Any())
                    {
                        foreach (var receivingReceipt in receivingReceipts)
                        {
                            if (receivingReceipt.ListPOSIntegrationTrnReceivingReceiptItem.Any())
                            {
                                var currentStockIn = from d in posdb.TrnStockIns where d.Remarks.Equals("RR-" + receivingReceipt.BranchCode + "-" + receivingReceipt.RRNumber) && d.TrnStockInLines.Count() > 0 && d.IsLocked == true select d;
                                if (!currentStockIn.Any())
                                {
                                    sysSettingsForm.logMessages("Saving Stock In: RR-" + receivingReceipt.BranchCode + "-" + receivingReceipt.RRNumber + "\r\n\n");

                                    var defaultPeriod = from d in posdb.MstPeriods select d;
                                    var defaultSettings = from d in posdb.IntCloudSettings select d;

                                    var lastStockInNumber = from d in posdb.TrnStockIns.OrderByDescending(d => d.Id) select d;
                                    var stockInNumberResult = defaultPeriod.FirstOrDefault().Period + "-000001";

                                    if (lastStockInNumber.Any())
                                    {
                                        var stockInNumberSplitStrings = lastStockInNumber.FirstOrDefault().StockInNumber;
                                        Int32 secondIndex = stockInNumberSplitStrings.IndexOf('-', stockInNumberSplitStrings.IndexOf('-'));
                                        var stockInNumberSplitStringValue = stockInNumberSplitStrings.Substring(secondIndex + 1);
                                        var stockInNumber = Convert.ToInt32(stockInNumberSplitStringValue) + 000001;
                                        stockInNumberResult = defaultPeriod.FirstOrDefault().Period + "-" + FillLeadingZeroes(stockInNumber, 6);
                                    }

                                    Data.TrnStockIn newStockIn = new Data.TrnStockIn
                                    {
                                        PeriodId = defaultPeriod.FirstOrDefault().Id,
                                        StockInDate = Convert.ToDateTime(receivingReceipt.RRDate),
                                        StockInNumber = stockInNumberResult,
                                        SupplierId = defaultSettings.FirstOrDefault().PostSupplierId,
                                        Remarks = "RR-" + receivingReceipt.BranchCode + "-" + receivingReceipt.RRNumber,
                                        IsReturn = false,
                                        PreparedBy = defaultSettings.FirstOrDefault().PostUserId,
                                        CheckedBy = defaultSettings.FirstOrDefault().PostUserId,
                                        ApprovedBy = defaultSettings.FirstOrDefault().PostUserId,
                                        IsLocked = true,
                                        EntryUserId = defaultSettings.FirstOrDefault().PostUserId,
                                        EntryDateTime = DateTime.Now,
                                        UpdateUserId = defaultSettings.FirstOrDefault().PostUserId,
                                        UpdateDateTime = DateTime.Now
                                    };

                                    posdb.TrnStockIns.InsertOnSubmit(newStockIn);
                                    posdb.SubmitChanges();

                                    if (receivingReceipt.ListPOSIntegrationTrnReceivingReceiptItem.Any())
                                    {
                                        foreach (var item in receivingReceipt.ListPOSIntegrationTrnReceivingReceiptItem.ToList())
                                        {
                                            var currentItem = from d in posdb.MstItems where d.BarCode.Equals(item.ItemCode) && d.MstUnit.Unit.Equals(item.Unit) select d;
                                            if (currentItem.Any())
                                            {
                                                Data.TrnStockInLine newStockInLine = new Data.TrnStockInLine
                                                {
                                                    StockInId = newStockIn.Id,
                                                    ItemId = currentItem.FirstOrDefault().Id,
                                                    UnitId = currentItem.FirstOrDefault().UnitId,
                                                    Quantity = item.Quantity,
                                                    Cost = item.Cost,
                                                    Amount = item.Amount,
                                                    ExpiryDate = currentItem.FirstOrDefault().ExpiryDate,
                                                    LotNumber = currentItem.FirstOrDefault().LotNumber,
                                                    AssetAccountId = currentItem.FirstOrDefault().AssetAccountId,
                                                    Price = currentItem.FirstOrDefault().Price
                                                };

                                                posdb.TrnStockInLines.InsertOnSubmit(newStockInLine);

                                                var updateItem = currentItem.FirstOrDefault();
                                                updateItem.OnhandQuantity = currentItem.FirstOrDefault().OnhandQuantity + Convert.ToDecimal(item.Quantity);

                                                posdb.SubmitChanges();

                                                sysSettingsForm.logMessages(" > " + currentItem.FirstOrDefault().ItemDescription + " * " + item.Quantity.ToString("#,##0.00") + "\r\n\n");
                                            }
                                        }
                                    }

                                    sysSettingsForm.logMessages("Save Successful!" + "\r\n\n");
                                    sysSettingsForm.logMessages("Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n");
                                    sysSettingsForm.logMessages("\r\n\n");
                                }
                            }
                        }
                    }
                }

                return Task.FromResult("");
            }
            catch (Exception e)
            {
                sysSettingsForm.logMessages("Receiving Receipt Error: " + e.Message + "\r\n\n");
                sysSettingsForm.logMessages("Time Stamp: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt") + "\r\n\n");
                sysSettingsForm.logMessages("\r\n\n");

                return Task.FromResult("");
            }
        }
    }
}
