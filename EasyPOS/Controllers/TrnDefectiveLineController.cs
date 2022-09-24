using EasyPOS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class TrnDefectiveLineController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // ===================
        // List Defective Line
        // ===================
        public List<Entities.TrnDefectiveLineEntity> ListDefectiveLine(Int32 defectiveId)
        {
            var defectiveLines = from d in db.TrnDefectiveItems

                               select new Entities.TrnDefectiveLineEntity
                               {
                                   Id = d.Id,
                                   DefectiveId = d.DefectiveId,
                                   ItemId = d.ItemId,
                                   ItemDescription = d.MstItem.ItemDescription,
                                   Quantity = d.Quantity,
                                   Amount = d.Amount,
                               };

            return defectiveLines.Where(d => d.DefectiveId == defectiveId).ToList();
        }
        // ==================
        // Add Defective Line
        // ==================
        public String[] AddDefectiveLine(Entities.TrnDefectiveLineEntity objDefectiveLine)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var defective = from d in db.TrnDefectives
                              where d.Id == objDefectiveLine.DefectiveId
                              select d;

                if (defective.Any() == false)
                {
                    return new String[] { "Defective transaction not found.", "0" };
                }

                var item = from d in db.MstItems
                           where d.Id == objDefectiveLine.ItemId
                           && d.IsInventory == true
                           && d.IsLocked == true
                           select d;

                if (item.Any() == false)
                {
                    return new String[] { "Item not found.", "0" };
                }

                Data.TrnDefectiveItem newDefectiveLine = new Data.TrnDefectiveItem
                {
                    DefectiveId = objDefectiveLine.DefectiveId,
                    ItemId = objDefectiveLine.ItemId,
                    Quantity = objDefectiveLine.Quantity,
                    Amount = objDefectiveLine.Amount,
                };

                db.TrnDefectiveItems.InsertOnSubmit(newDefectiveLine);
                db.SubmitChanges();

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // =====================
        // Update Defective Line
        // =====================
        public String[] UpdateDefectiveLine(Int32 id, Entities.TrnDefectiveLineEntity objDefectiveLine)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var defectiveLine = from d in db.TrnStockInLines
                                  where d.Id == id
                                  select d;

                if (defectiveLine.Any())
                {
                    var defective = from d in db.TrnDefectives
                                  where d.Id == objDefectiveLine.DefectiveId
                                  select d;

                    if (defective.Any() == false)
                    {
                        return new String[] { "Defective transaction not found.", "0" };
                    }

                    var updateDefectiveLine = defectiveLine.FirstOrDefault();
                    updateDefectiveLine.ItemId = objDefectiveLine.ItemId;
                    updateDefectiveLine.Quantity = objDefectiveLine.Quantity;
                    updateDefectiveLine.Amount = objDefectiveLine.Amount;
                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Defective line not found.  " + id, "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // =====================
        // Delete Defective Line
        // =====================
        public String[] DeleteDefectiveLine(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var defectiveLine = from d in db.TrnDefectiveItems
                                  where d.Id == id
                                  select d;

                if (defectiveLine.Any())
                {
                    var deleteDefectiveLine = defectiveLine.FirstOrDefault();
                    db.TrnDefectiveItems.DeleteOnSubmit(deleteDefectiveLine);

                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Defective line not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
    }
}
