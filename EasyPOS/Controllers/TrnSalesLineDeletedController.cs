using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace EasyPOS.Controllers
{
    class TrnSalesLineDeletedController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // ======================
        // List Delete Sales Line
        // ======================
        public List<Entities.TrnSalesLineDeletedEntity> ListSalesLineDeleted()
        {
            var deletedSalesLines = from d in db.TrnSalesLineDeleteds
                             where d.IsPrinted == false
                             select new Entities.TrnSalesLineDeletedEntity
                             {
                                 Id = d.Id,
                                 SalesId = d.SalesId,
                                 SalesNumber = d.SalesNumber,
                                 ItemId = d.ItemId,
                                 ItemDescription = d.ItemDescription,
                                 ItemKitchen = d.ItemKitchen,
                                 Preparation = d.Preparation,
                                 UnitId = d.UnitId,
                                 Unit = d.Unit,
                                 Price = d.Price,
                                 DiscountId = d.DiscountId,
                                 Discount = d.Discount,
                                 DiscountRate = d.DiscountRate,
                                 DiscountAmount = d.DiscountAmount,
                                 NetPrice = d.NetPrice,
                                 Quantity = d.Quantity,
                                 Amount = d.Amount,
                                 TaxId = d.TaxId,
                                 Tax = d.Tax,
                                 TaxRate = d.TaxRate,
                                 TaxAmount = d.TaxAmount,
                                 UserId = d.UserId,
                                 UserName = d.UserName,
                                 SalesDate = d.SalesDate,
                                 DeletedDate = d.DeletedDate,
                                 IsPrinted = d.IsPrinted,
                                 SalesLineId = d.SalesLineId,
                                 TableId = d.TableId,
                                 TableCode = d.TableCode
                             };

            return deletedSalesLines.OrderByDescending(d => d.Id).ToList();
        }

        // =============================
        // Stored List Delete Sales Line
        // =============================
        public List<Entities.TrnSalesLineDeletedEntity> ListSalesLineDeletedItems(DateTime dateStart, DateTime dateEnd)
        {
            var deletedSalesLines = from d in db.TrnSalesLineDeleteds
                                    where d.SalesDate >= dateStart
                                             && d.SalesDate <= dateEnd
                                             && d.IsPrinted == true
                                    select new Entities.TrnSalesLineDeletedEntity
                                    {
                                        Id = d.Id,
                                        SalesId = d.SalesId,
                                        SalesNumber = d.SalesNumber,
                                        ItemId = d.ItemId,
                                        ItemDescription = d.ItemDescription,
                                        ItemKitchen = d.ItemKitchen,
                                        Preparation = d.Preparation,
                                        UnitId = d.UnitId,
                                        Unit = d.Unit,
                                        Price = d.Price,
                                        DiscountId = d.DiscountId,
                                        Discount = d.Discount,
                                        DiscountRate = d.DiscountRate,
                                        DiscountAmount = d.DiscountAmount,
                                        NetPrice = d.NetPrice,
                                        Quantity = d.Quantity,
                                        Amount = d.Amount,
                                        TaxId = d.TaxId,
                                        Tax = d.Tax,
                                        TaxRate = d.TaxRate,
                                        TaxAmount = d.TaxAmount,
                                        UserId = d.UserId,
                                        UserName = d.UserName,
                                        SalesDate = d.SalesDate,
                                        DeletedDate = d.DeletedDate,
                                        IsPrinted = d.IsPrinted,
                                        SalesLineId = d.SalesLineId,
                                        TableId = d.TableId,
                                        TableCode = d.TableCode
                                    };

            return deletedSalesLines.OrderByDescending(d => d.Id).ToList();
        }
        // ======================
        // Add Deleted Sales Line
        // ======================
        public String[] AddDeletedSalesLine(Entities.TrnSalesLineEntity objSalesLine)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var sales = from d in db.TrnSales
                            where d.Id == objSalesLine.SalesId
                            select d;

                if (sales.Any() == false)
                {
                    return new String[] { "Sales transaction not found.", "0" };
                }

                var item = from d in db.MstItems where d.Id == objSalesLine.ItemId select d;
                if (item.Any() == false)
                {
                    return new String[] { "Item not found.", "0" };
                }

                var discount = from d in db.MstDiscounts where d.Id == objSalesLine.DiscountId select d;
                if (discount.Any() == false)
                {
                    return new String[] { "Discount not found.", "0" };
                }

                var tax = from d in db.MstTaxes where d.Id == objSalesLine.TaxId select d;
                if (tax.Any() == false)
                {
                    return new String[] { "Tax not found.", "0" };
                }

                var user = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (user.Any() == false)
                {
                    return new String[] { "User not found.", "0" };
                }

                Data.TrnSalesLineDeleted newDeletedSaleLine = new Data.TrnSalesLineDeleted
                {
                    SalesId = objSalesLine.SalesId,
                    SalesNumber = sales.FirstOrDefault().SalesNumber,
                    ItemId = objSalesLine.ItemId,
                    ItemDescription = objSalesLine.ItemDescription,
                    ItemKitchen = item.FirstOrDefault().DefaultKitchenReport,
                    Preparation = sales.FirstOrDefault().TrnSalesLines.FirstOrDefault().Preparation,
                    UnitId = item.FirstOrDefault().UnitId,
                    Unit = item.FirstOrDefault().MstUnit.Unit,
                    Price = objSalesLine.Price,
                    DiscountId = objSalesLine.DiscountId,
                    Discount = objSalesLine.Discount,
                    DiscountRate = objSalesLine.DiscountRate,
                    DiscountAmount = objSalesLine.DiscountAmount,
                    NetPrice = objSalesLine.NetPrice,
                    Quantity = objSalesLine.Quantity,
                    Amount = objSalesLine.Amount,
                    TaxId = objSalesLine.TaxId,
                    Tax = objSalesLine.Tax,
                    TaxRate = objSalesLine.TaxRate,
                    TaxAmount = objSalesLine.TaxAmount,
                    UserId = user.FirstOrDefault().Id,
                    UserName = user.FirstOrDefault().UserName,
                    SalesDate = sales.FirstOrDefault().SalesDate,
                    DeletedDate = DateTime.Now,
                    IsPrinted = false,
                    SalesLineId = objSalesLine.Id,
                    TableId = sales.FirstOrDefault().MstTable.Id,
                    TableCode = sales.FirstOrDefault().MstTable.TableCode
                };

                db.TrnSalesLineDeleteds.InsertOnSubmit(newDeletedSaleLine);
                db.SubmitChanges();

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
        // =================
        // Is Printed = True
        // =================
        public String[] IsPrinted(Int32 salesLineId)
        {
            try
            {
                var deletedSalesLines = from d in db.TrnSalesLineDeleteds
                                        where d.SalesLineId == salesLineId
                                        select d;

                if (deletedSalesLines.Any())
                {
                    var deletedSalesLine = deletedSalesLines.FirstOrDefault();
                    deletedSalesLine.IsPrinted = true;
                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Delete Sales Line not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
    }
}