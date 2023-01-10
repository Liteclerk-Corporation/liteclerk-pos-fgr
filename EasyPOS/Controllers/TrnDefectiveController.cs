using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class TrnDefectiveController
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
        // ==============
        // List Defective 
        // ==============
        public List<Entities.TrnDefectiveEntity> ListDefective(DateTime dateFilter, String filter)
        {
            var defectives = from d in db.TrnDefectives
                           where d.DefectiveDate == dateFilter
                           && d.DefectiveNo.Contains(filter)
                           select new Entities.TrnDefectiveEntity
                           {
                               Id = d.Id,
                               DefectiveNo = d.DefectiveNo,
                               DefectiveDate = d.DefectiveDate.ToShortDateString(),
                               InvoiceNo = d.InvoiceNo,
                               PurchasedDate = d.PurchasedDate.ToShortDateString(),
                               VehicleType = d.VehicleType,
                               CustomerName = d.CustomerName,
                               ReplacementDate = d.ReplacementDate.ToShortDateString(),
                               ReplacementInvoiceNo = d.ReplacementInvoiceNo,
                               PreparedById = d.PreparedById,
                               IsLocked = d.IsLocked,
                           };

            return defectives.OrderByDescending(d => d.Id).ToList();
        }
        // =================
        // Detail Defective
        // =================
        public Entities.TrnDefectiveEntity DetailDefective(Int32 id)
        {
            var defectives = from d in db.TrnDefectives
                          where d.Id == id
                          select new Entities.TrnDefectiveEntity
                          {
                              Id = d.Id,
                              DefectiveNo = d.DefectiveNo,
                              DefectiveDate = d.DefectiveDate.ToShortDateString(),
                              InvoiceNo = d.InvoiceNo,
                              PurchasedDate = d.PurchasedDate.ToShortDateString(),
                              VehicleType = d.VehicleType,
                              CustomerName = d.CustomerName,
                              ReplacementDate = d.ReplacementDate.ToShortDateString(),
                              ReplacementInvoiceNo = d.ReplacementInvoiceNo,
                              PreparedById = d.PreparedById,
                              IsLocked = d.IsLocked,
                          };

            return defectives.FirstOrDefault();
        }
        // ====================
        // Dropdown List - User
        // ====================
        public List<Entities.MstUserEntity> DropdownListDefectiveUser()
        {
            var users = from d in db.MstUsers
                        select new Entities.MstUserEntity
                        {
                            Id = d.Id,
                            FullName = d.FullName
                        };

            return users.ToList();
        }

        // =============
        // Add Defective
        // =============
        public String[] AddDefective()
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                DateTime currentDate = DateTime.Today;
                if (Modules.SysCurrentModule.GetCurrentSettings().IsLoginDate == true)
                {
                    currentDate = Convert.ToDateTime(Modules.SysCurrentModule.GetCurrentSettings().CurrentDate);
                }

                String defectiveNumber = "0000000001";
                var lastDefective = from d in db.TrnDefectives.OrderByDescending(d => d.Id) where d.DefectiveNo.Contains("-") == false select d;
                if (lastDefective.Any())
                {
                    Int32 newDefectiveNumber = Convert.ToInt32(lastDefective.FirstOrDefault().DefectiveNo) + 1;
                    defectiveNumber = FillLeadingZeroes(newDefectiveNumber, 10);
                }

                Data.TrnDefective newDefective = new Data.TrnDefective()
                {
                    DefectiveNo = defectiveNumber,
                    DefectiveDate = currentDate,
                    PurchasedDate = currentDate,
                    ReplacementDate = currentDate,
                    InvoiceNo = "NA",
                    ReplacementInvoiceNo = "NA",
                    VehicleType = "Private",
                    CustomerName = "NA",
                    PreparedById = currentUserLogin.FirstOrDefault().Id,
                    IsLocked = false,
                };

                db.TrnDefectives.InsertOnSubmit(newDefective);
                db.SubmitChanges();

                return new String[] { "", newDefective.Id.ToString() };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ==============
        // Lock Defective
        // ==============
        public String[] LockDefective(Int32 id, Entities.TrnDefectiveEntity objDefective)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var defective = from d in db.TrnDefectives
                              where d.Id == id
                              select d;

                if (defective.Any())
                {
                    if (defective.FirstOrDefault().IsLocked)
                    {
                        return new String[] { "Already locked.", "0" };
                    }

                    var lockDefective = defective.FirstOrDefault();
                    lockDefective.DefectiveDate = Convert.ToDateTime(objDefective.DefectiveDate);
                    lockDefective.PurchasedDate = Convert.ToDateTime(objDefective.PurchasedDate);
                    lockDefective.ReplacementDate = Convert.ToDateTime(objDefective.ReplacementDate);
                    lockDefective.InvoiceNo = objDefective.InvoiceNo;
                    lockDefective.ReplacementInvoiceNo = objDefective.ReplacementInvoiceNo;
                    lockDefective.VehicleType = objDefective.VehicleType;
                    lockDefective.CustomerName = objDefective.CustomerName;
                    lockDefective.PreparedById = currentUserLogin.FirstOrDefault().Id;
                    lockDefective.IsLocked = true;
                    db.SubmitChanges();

                    Modules.TrnInventoryModule trnInventoryModule = new Modules.TrnInventoryModule();
                    trnInventoryModule.UpdateDefectiveInventory(defective.FirstOrDefault().Id);

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Defective record not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ================
        // Unlock Defective
        // ================
        public String[] UnlockDefective(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var defective = from d in db.TrnDefectives
                              where d.Id == id
                              select d;

                if (defective.Any())
                {
                    if (defective.FirstOrDefault().IsLocked == false)
                    {
                        return new String[] { "Already unlocked.", "0" };
                    }

                    var unlockDefective = defective.FirstOrDefault();
                    unlockDefective.IsLocked = false;
                    db.SubmitChanges();

                    Modules.TrnInventoryModule trnInventoryModule = new Modules.TrnInventoryModule();
                    trnInventoryModule.UpdateDefectiveInventory(defective.FirstOrDefault().Id);


                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Defective record not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // =================
        // Delete Defective
        // =================
        public String[] DeleteDefective(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var defective = from d in db.TrnDefectives
                              where d.Id == id
                              select d;

                if (defective.Any())
                {
                    if (defective.FirstOrDefault().IsLocked)
                    {
                        return new String[] { "Defective record is locked", "0" };
                    }

                    var deleteDefective= defective.FirstOrDefault();
                    db.TrnDefectives.DeleteOnSubmit(deleteDefective);

                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Defective record not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
    }
}
