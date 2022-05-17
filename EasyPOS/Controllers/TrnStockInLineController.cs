using EasyPOS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class TrnStockInLineController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // ==================
        // List Stock-In Line
        // ==================
        public List<Entities.TrnStockInLineEntity> ListStockInLine(Int32 stockInId)
        {
            var stockInLines = from d in db.TrnStockInLines
                               
                               select new Entities.TrnStockInLineEntity
                               {
                                   Id = d.Id,
                                   StockInId = d.StockInId,
                                   ItemId = d.ItemId,
                                   ItemBarcode = d.MstItem.BarCode,
                                   ItemDescription = d.MstItem.ItemDescription,
                                   UnitId = d.UnitId,
                                   Unit = d.MstUnit.Unit,
                                   Quantity = d.Quantity,
                                   Cost = d.Cost,
                                   Amount = d.Amount,
                                   ExpiryDate = d.ExpiryDate != null ? Convert.ToDateTime(d.ExpiryDate).ToShortDateString() : "",
                                   LotNumber = d.LotNumber ?? "",
                                   AssetAccountId = d.AssetAccountId,
                                   AssetAccount = d.MstAccount.Account,
                                   Price = d.Price
                               };

            //return stockInLines.OrderByDescending(d => d.Id).ToList();
            return stockInLines.Where(d => d.StockInId == stockInId).ToList();
        }

        // ================
        // List Search Item
        // ================
        public List<Entities.MstItemEntity> ListSearchItem(String filter)
        {
            var items = from d in db.MstItems
                        where d.IsInventory == true
                        && (d.BarCode.Contains(filter)
                        || d.ItemDescription.Contains(filter)
                        || d.GenericName.Contains(filter))
                        select new Entities.MstItemEntity
                        {
                            Id = d.Id,
                            BarCode = d.BarCode,
                            ItemDescription = d.ItemDescription,
                            GenericName = d.GenericName,
                            Cost = d.Cost,
                            OutTaxId = d.OutTaxId,
                            OutTax = d.MstTax1.Tax,
                            OutTaxRate = d.MstTax1.Rate,
                            UnitId = d.UnitId,
                            Unit = d.MstUnit.Unit,
                            Price = d.Price,
                            OnhandQuantity = d.OnhandQuantity
                        };

            return items.OrderBy(d => d.ItemDescription).ToList();
        }

        // ===========
        // Detail Item
        // ===========
        public Entities.MstItemEntity DetailSearchItem(String barcode)
        {
            var item = from d in db.MstItems
                       where d.BarCode.Equals(barcode)
                       && d.IsInventory == true
                       select new Entities.MstItemEntity
                       {
                           Id = d.Id,
                           BarCode = d.BarCode,
                           ItemDescription = d.ItemDescription,
                           GenericName = d.GenericName,
                           Cost = d.Cost,
                           OutTaxId = d.OutTaxId,
                           OutTax = d.MstTax1.Tax,
                           OutTaxRate = d.MstTax1.Rate,
                           UnitId = d.UnitId,
                           Unit = d.MstUnit.Unit,
                           Price = d.Price,
                           OnhandQuantity = d.OnhandQuantity
                       };

            return item.FirstOrDefault();
        }

        // =================
        // Add Stock-In Line
        // =================
        public String[] AddStockInLine(Entities.TrnStockInLineEntity objStockInLine)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var stockIn = from d in db.TrnStockIns
                              where d.Id == objStockInLine.StockInId
                              select d;

                if (stockIn.Any() == false)
                {
                    return new String[] { "Stock-In transaction not found.", "0" };
                }

                var item = from d in db.MstItems
                           where d.Id == objStockInLine.ItemId
                           && d.IsInventory == true
                           && d.IsLocked == true
                           select d;

                if (item.Any() == false)
                {
                    return new String[] { "Item not found.", "0" };
                }

                var account = from d in db.MstAccounts
                              where d.Account.Equals("Inventory")
                              && d.IsLocked == true
                              select d;

                if (account.Any() == false)
                {
                    return new String[] { "Account not found.", "0" };
                }

                DateTime? expiryDate = null;
                if (String.IsNullOrEmpty(objStockInLine.ExpiryDate) == false)
                {
                    expiryDate = Convert.ToDateTime(objStockInLine.ExpiryDate);
                }

                Data.TrnStockInLine newStockInLine = new Data.TrnStockInLine
                {
                    StockInId = objStockInLine.StockInId,
                    ItemId = objStockInLine.ItemId,
                    UnitId = item.FirstOrDefault().UnitId,
                    Quantity = objStockInLine.Quantity,
                    Cost = objStockInLine.Cost,
                    Amount = objStockInLine.Amount,
                    ExpiryDate = expiryDate,
                    LotNumber = objStockInLine.LotNumber,
                    AssetAccountId = account.FirstOrDefault().Id,
                    Price = objStockInLine.Price
                };

                db.TrnStockInLines.InsertOnSubmit(newStockInLine);
                db.SubmitChanges();

                String newObject = Modules.SysAuditTrailModule.GetObjectString(newStockInLine);

                Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                {
                    UserId = currentUserLogin.FirstOrDefault().Id,
                    AuditDate = DateTime.Now,
                    TableInformation = "TrnStockInLine",
                    RecordInformation = "",
                    FormInformation = newObject,
                    ActionInformation = "AddStockInLine"
                };
                Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ====================
        // Update Stock-In Line
        // ====================
        public String[] UpdateStockInLine(Int32 id, Entities.TrnStockInLineEntity objStockInLine)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var stockInLine = from d in db.TrnStockInLines
                                  where d.Id == id
                                  select d;

                if (stockInLine.Any())
                {
                    var stockIn = from d in db.TrnStockIns
                                  where d.Id == objStockInLine.StockInId
                                  select d;

                    if (stockIn.Any() == false)
                    {
                        return new String[] { "Stock-In transaction not found.", "0" };
                    }

                    DateTime? expiryDate = null;
                    if (String.IsNullOrEmpty(objStockInLine.ExpiryDate) == false)
                    {
                        expiryDate = Convert.ToDateTime(objStockInLine.ExpiryDate);
                    }

                    String oldObject = Modules.SysAuditTrailModule.GetObjectString(stockInLine.FirstOrDefault());

                    var updateStockInLine = stockInLine.FirstOrDefault();
                    updateStockInLine.Quantity = objStockInLine.Quantity;
                    updateStockInLine.Cost = objStockInLine.Cost;
                    updateStockInLine.Amount = objStockInLine.Amount;
                    updateStockInLine.ExpiryDate = expiryDate;
                    updateStockInLine.LotNumber = objStockInLine.LotNumber;
                    updateStockInLine.Price = objStockInLine.Price;
                    db.SubmitChanges();

                    String newObject = Modules.SysAuditTrailModule.GetObjectString(stockInLine.FirstOrDefault());

                    Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                    {
                        UserId = currentUserLogin.FirstOrDefault().Id,
                        AuditDate = DateTime.Now,
                        TableInformation = "TrnStockInLine",
                        RecordInformation = oldObject,
                        FormInformation = newObject,
                        ActionInformation = "UpdateStockInLine"
                    };
                    Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Stock-In line not found.  " + id, "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ====================
        // Delete Stock-In Line
        // ====================
        public String[] DeleteStockInLine(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var stockInLine = from d in db.TrnStockInLines
                                  where d.Id == id
                                  select d;

                if (stockInLine.Any())
                {
                    var deleteStockInLine = stockInLine.FirstOrDefault();
                    db.TrnStockInLines.DeleteOnSubmit(deleteStockInLine);

                    String oldObject = Modules.SysAuditTrailModule.GetObjectString(stockInLine.FirstOrDefault());

                    Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                    {
                        UserId = currentUserLogin.FirstOrDefault().Id,
                        AuditDate = DateTime.Now,
                        TableInformation = "TrnStockInLine",
                        RecordInformation = oldObject,
                        FormInformation = "",
                        ActionInformation = "DeleteStockInLine"
                    };
                    Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);

                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Stock-In line not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // =====================
        // Barcode Stock-In Line
        // =====================
        public String[] BarcodeStockInLine(Int32 stockInId, String barcode)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var stockIn = from d in db.TrnStockIns
                              where d.Id == stockInId
                              select d;

                if (stockIn.Any() == false)
                {
                    return new String[] { "Stock-In transaction not found.", "0" };
                }

                var item = from d in db.MstItems
                           where d.BarCode.Equals(barcode)
                           && d.IsInventory == true
                           && d.IsLocked == true
                           select d;

                if (item.Any() == false)
                {
                    return new String[] { "Item not found.", "0" };
                }

                var account = from d in db.MstAccounts
                              where d.Account.Equals("Inventory")
                              && d.IsLocked == true
                              select d;

                if (account.Any() == false)
                {
                    return new String[] { "Account not found.", "0" };
                }

                Data.TrnStockInLine newStockInLine = new Data.TrnStockInLine
                {
                    StockInId = stockInId,
                    ItemId = item.FirstOrDefault().Id,
                    UnitId = item.FirstOrDefault().UnitId,
                    Quantity = 1,
                    Cost = item.FirstOrDefault().Cost,
                    Amount = item.FirstOrDefault().Cost,
                    ExpiryDate = null,
                    LotNumber = null,
                    AssetAccountId = account.FirstOrDefault().Id,
                    Price = item.FirstOrDefault().Price
                };

                db.TrnStockInLines.InsertOnSubmit(newStockInLine);
                db.SubmitChanges();

                String newObject = Modules.SysAuditTrailModule.GetObjectString(newStockInLine);

                Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                {
                    UserId = currentUserLogin.FirstOrDefault().Id,
                    AuditDate = DateTime.Now,
                    TableInformation = "TrnStockInLine",
                    RecordInformation = "",
                    FormInformation = newObject,
                    ActionInformation = "AddStockInLine"
                };
                Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ====================
        // Import Stock-In Line
        // ====================
        public String[] ImportStockInLine(List<Entities.TrnStockInLineEntity> objStockInLines)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                if (objStockInLines.Any())
                {
                    foreach (var objStockInLine in objStockInLines)
                    {
                        var stockIn = from d in db.TrnStockIns
                                      where d.Id == objStockInLine.StockInId
                                      select d;

                        if (stockIn.Any() == false)
                        {
                            return new String[] { "Stock-In transaction not found.", "0" };
                        }

                        var item = from d in db.MstItems
                                   where d.BarCode == objStockInLine.ItemBarcode
                                   && d.IsInventory == true
                                   && d.IsLocked == true
                                   select d;

                        if (item.Any() == false)
                        {
                            return new String[] { "Item not found.", "0" };
                        }

                        var account = from d in db.MstAccounts
                                      where d.Account.Equals("Inventory")
                                      && d.IsLocked == true
                                      select d;

                        if (account.Any() == false)
                        {
                            return new String[] { "Account not found.", "0" };
                        }

                        DateTime? expiryDate = null;
                        if (String.IsNullOrEmpty(objStockInLine.ExpiryDate) == false)
                        {
                            expiryDate = Convert.ToDateTime(objStockInLine.ExpiryDate);
                        }

                        Data.TrnStockInLine newStockInLine = new Data.TrnStockInLine
                        {
                            StockInId = objStockInLine.StockInId,
                            ItemId = item.FirstOrDefault().Id,
                            UnitId = item.FirstOrDefault().UnitId,
                            Quantity = objStockInLine.Quantity,
                            Cost = objStockInLine.Cost,
                            Amount = objStockInLine.Amount,
                            ExpiryDate = expiryDate,
                            LotNumber = "NA",
                            AssetAccountId = account.FirstOrDefault().Id,
                            Price = objStockInLine.Price
                        };

                        db.TrnStockInLines.InsertOnSubmit(newStockInLine);
                        db.SubmitChanges();

                        String newObject = Modules.SysAuditTrailModule.GetObjectString(newStockInLine);

                        Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                        {
                            UserId = currentUserLogin.FirstOrDefault().Id,
                            AuditDate = DateTime.Now,
                            TableInformation = "TrnStockInLine",
                            RecordInformation = "",
                            FormInformation = newObject,
                            ActionInformation = "AddStockInLine"
                        };
                        Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);
                    }

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Data source is empty.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

    }
}
