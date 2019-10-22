﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class MstItemController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

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

        // ==========
        // List Items
        // ==========
        public List<Entities.MstItemEntity> ListItem(String filter)
        {
            var items = from d in db.MstItems
                        where d.ItemCode.Contains(filter)
                        || d.BarCode.Contains(filter)
                        || d.ItemDescription.Contains(filter)
                        || d.GenericName.Contains(filter)
                        select new Entities.MstItemEntity
                        {
                            Id = d.Id,
                            ItemCode = d.ItemCode,
                            BarCode = d.BarCode,
                            ItemDescription = d.ItemDescription,
                            Alias = d.Alias,
                            GenericName = d.GenericName,
                            Category = d.Category,
                            SalesAccountId = d.SalesAccountId,
                            AssetAccountId = d.AssetAccountId,
                            CostAccountId = d.CostAccountId,
                            InTaxId = d.InTaxId,
                            OutTaxId = d.OutTaxId,
                            UnitId = d.UnitId,
                            DefaultSupplierId = d.DefaultSupplierId,
                            Cost = d.Cost,
                            MarkUp = d.MarkUp,
                            Price = d.Price,
                            ImagePath = d.ImagePath,
                            ReorderQuantity = d.ReorderQuantity,
                            OnhandQuantity = d.OnhandQuantity,
                            IsInventory = d.IsInventory,
                            ExpiryDate = d.ExpiryDate.ToString(),
                            LotNumber = d.LotNumber,
                            Remarks = d.Remarks,
                            EntryUserId = d.EntryUserId,
                            EntryDateTime = d.EntryDateTime.ToShortDateString(),
                            UpdateUserId = d.UpdateUserId,
                            UpdateDateTime = d.UpdateDateTime.ToShortDateString(),
                            IsLocked = d.IsLocked,
                            DefaultKitchenReport = d.DefaultKitchenReport,
                            IsPackage = d.IsPackage
                        };

            return items.OrderByDescending(d => d.Id).ToList();
        }

        // ===========
        // Detail Item
        // ===========
        public Entities.MstItemEntity DetailItem(Int32 id)
        {
            var item = from d in db.MstItems
                       where d.Id == id
                       select new Entities.MstItemEntity
                       {
                           Id = d.Id,
                           ItemCode = d.ItemCode,
                           BarCode = d.BarCode,
                           ItemDescription = d.ItemDescription,
                           Alias = d.Alias,
                           GenericName = d.GenericName,
                           Category = d.Category,
                           SalesAccountId = d.SalesAccountId,
                           AssetAccountId = d.AssetAccountId,
                           CostAccountId = d.CostAccountId,
                           InTaxId = d.InTaxId,
                           OutTaxId = d.OutTaxId,
                           UnitId = d.UnitId,
                           DefaultSupplierId = d.DefaultSupplierId,
                           Cost = d.Cost,
                           MarkUp = d.MarkUp,
                           Price = d.Price,
                           ImagePath = d.ImagePath,
                           ReorderQuantity = d.ReorderQuantity,
                           OnhandQuantity = d.OnhandQuantity,
                           IsInventory = d.IsInventory,
                           ExpiryDate = d.ExpiryDate.ToString(),
                           LotNumber = d.LotNumber,
                           Remarks = d.Remarks,
                           EntryUserId = d.EntryUserId,
                           EntryDateTime = d.EntryDateTime.ToShortDateString(),
                           UpdateUserId = d.UpdateUserId,
                           UpdateDateTime = d.UpdateDateTime.ToShortDateString(),
                           IsLocked = d.IsLocked,
                           DefaultKitchenReport = d.DefaultKitchenReport,
                           IsPackage = d.IsPackage
                       };

            return item.FirstOrDefault();
        }

        // ========
        // Add Item
        // ========
        public String[] AddItem()
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                String itemCode = "0000000001";
                var lastItemCode = from d in db.MstItems.OrderByDescending(d => d.Id) select d;
                if (lastItemCode.Any())
                {
                    Int32 newItemCode = Convert.ToInt32(lastItemCode.FirstOrDefault().ItemCode) + 1;
                    itemCode = FillLeadingZeroes(newItemCode, 10);
                }

                var salesAccount = from d in db.MstAccounts where d.Account == "Sales" select d;
                if (salesAccount.Any() == false)
                {
                    return new String[] { "Sales account not found.", "0" };
                }

                var assetsAccount = from d in db.MstAccounts where d.Account == "Inventory" select d;
                if (assetsAccount.Any() == false)
                {
                    return new String[] { "Assets account not found.", "0" };
                }

                var costAccount = from d in db.MstAccounts where d.Account == "Cost of Sales" select d;
                if (costAccount.Any() == false)
                {
                    return new String[] { "Cost account not found.", "0" };
                }

                var tax = from d in db.MstTaxes where d.Tax == "VAT Output" select d;
                if (tax.Any() == false)
                {
                    return new String[] { "Tax not found.", "0" };
                }

                var unit = from d in db.MstUnits select d;
                if (unit.Any() == false)
                {
                    return new String[] { "Unit not found.", "0" };
                }

                var supplier = from d in db.MstSuppliers select d;
                if (supplier.Any() == false)
                {
                    return new String[] { "Supplier not found.", "0" };
                }


                Data.MstItem newItem = new Data.MstItem()
                {
                    ItemCode = itemCode,
                    BarCode = "NA",
                    ItemDescription = "NA",
                    Alias = "NA",
                    GenericName = "NA",
                    Category = "NA",
                    SalesAccountId = salesAccount.FirstOrDefault().Id,
                    AssetAccountId = assetsAccount.FirstOrDefault().Id,
                    CostAccountId = costAccount.FirstOrDefault().Id,
                    InTaxId = tax.FirstOrDefault().Id,
                    OutTaxId = tax.FirstOrDefault().Id,
                    UnitId = unit.FirstOrDefault().Id,
                    DefaultSupplierId = supplier.FirstOrDefault().Id,
                    Cost = 0,
                    MarkUp = 0,
                    Price = 0,
                    ImagePath = "NA",
                    ReorderQuantity = 0,
                    OnhandQuantity = 0,
                    IsInventory = true,
                    ExpiryDate = null,
                    LotNumber = null,
                    Remarks = null,
                    EntryUserId = currentUserLogin.FirstOrDefault().Id,
                    EntryDateTime = DateTime.Today,
                    UpdateUserId = currentUserLogin.FirstOrDefault().Id,
                    UpdateDateTime = DateTime.Today,
                    IsLocked = false,
                    DefaultKitchenReport = "",
                    IsPackage = false
                };

                db.MstItems.InsertOnSubmit(newItem);
                db.SubmitChanges();

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // =========
        // Lock Item
        // =========
        public String[] LockItem(Int32 id, Entities.MstItemEntity objItem)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var item = from d in db.MstItems
                           where d.Id == id
                           select d;

                if (item.Any())
                {
                    var lockItem = item.FirstOrDefault();
                    lockItem.ItemCode = objItem.ItemCode;
                    lockItem.BarCode = objItem.BarCode;
                    lockItem.ItemDescription = objItem.ItemDescription;
                    lockItem.Alias = objItem.Alias;
                    lockItem.GenericName = objItem.GenericName;
                    lockItem.Category = objItem.Category;
                    lockItem.SalesAccountId = objItem.SalesAccountId;
                    lockItem.AssetAccountId = objItem.AssetAccountId;
                    lockItem.CostAccountId = objItem.CostAccountId;
                    lockItem.InTaxId = objItem.InTaxId;
                    lockItem.OutTaxId = objItem.OutTaxId;
                    lockItem.UnitId = objItem.UnitId;
                    lockItem.DefaultSupplierId = objItem.DefaultSupplierId;
                    lockItem.Cost = objItem.Cost;
                    lockItem.MarkUp = objItem.MarkUp;
                    lockItem.Price = objItem.Price;
                    lockItem.ImagePath = objItem.ImagePath;
                    lockItem.ReorderQuantity = objItem.ReorderQuantity;
                    lockItem.OnhandQuantity = objItem.OnhandQuantity;
                    lockItem.IsInventory = objItem.IsInventory;
                    lockItem.ExpiryDate = Convert.ToDateTime(objItem.ExpiryDate);
                    lockItem.LotNumber = objItem.LotNumber;
                    lockItem.Remarks = objItem.Remarks;
                    lockItem.UpdateUserId = currentUserLogin.FirstOrDefault().Id;
                    lockItem.UpdateDateTime = DateTime.Today;
                    lockItem.IsLocked = true;
                    lockItem.DefaultKitchenReport = objItem.DefaultKitchenReport;
                    lockItem.IsPackage = objItem.IsPackage;
                    db.SubmitChanges();

                    return new String[] { "", "" };

                }
                else
                {
                    return new String[] { "Item not found.", "0" };
                }

            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ===========
        // Unlock Item
        // ===========
        public String[] UnlockItem(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var item = from d in db.MstItems
                           where d.Id == id
                           select d;

                if (item.Any())
                {
                    var unLockItem = item.FirstOrDefault();
                    unLockItem.UpdateUserId = currentUserLogin.FirstOrDefault().Id;
                    unLockItem.UpdateDateTime = DateTime.Today;
                    unLockItem.IsLocked = false;
                    db.SubmitChanges();
                }

                return new String[] { "", "" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ===========
        // Delete Item
        // ===========
        public String[] DeleteItem(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var item = from d in db.MstItems
                           where d.Id == id
                           select d;

                if (item.Any())
                {
                    if (item.FirstOrDefault().IsLocked == false)
                    {
                        var deleteItem = item.FirstOrDefault();
                        db.MstItems.DeleteOnSubmit(deleteItem);
                        db.SubmitChanges();

                        return new String[] { "", "" };

                    }
                    else
                    {
                        return new String[] { "Item is Locked", "0" };
                    }
                }
                else
                {
                    return new String[] { "Item is Locked", "0" };
                }

            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
    }
}
