using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class MstTableController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // ==========
        // List Table
        // ==========
        public List<Entities.MstTableEntity> ListTable(Int32 tableGroupId)
        {
            var tables = from d in db.MstTables
                         where d.TableGroupId == tableGroupId
                         select new Entities.MstTableEntity
                         {
                             Id = d.Id,
                             TableCode = d.TableCode,
                             TableGroupId = d.TableGroupId,
                             TableGroup = d.MstTableGroup.TableGroup,
                             TopLocation = d.TopLocation,
                             LeftLocation = d.LeftLocation,
                             SortNumber = d.SortNumber
                         };

            return tables.OrderByDescending(d => d.Id).ToList();
        }

        // =========
        // Add Table
        // =========
        public String[] AddTable(Entities.MstTableEntity objTable)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var tableGroup = from d in db.MstTableGroups
                                 where d.Id == objTable.TableGroupId
                                 select d;

                if (tableGroup.Any() == false)
                {
                    return new String[] { "Table group not found.", "0" };
                }

                Data.MstTable newTable = new Data.MstTable
                {
                    TableCode = objTable.TableCode,
                    TableGroupId = objTable.TableGroupId,
                    SortNumber = objTable.SortNumber,
                    TopLocation = null,
                    LeftLocation = null
                };

                db.MstTables.InsertOnSubmit(newTable);
                db.SubmitChanges();

                String newObject = Modules.SysAuditTrailModule.GetObjectString(newTable);

                Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                {
                    UserId = currentUserLogin.FirstOrDefault().Id,
                    AuditDate = DateTime.Now,
                    TableInformation = "MstTable",
                    RecordInformation = "",
                    FormInformation = newObject,
                    ActionInformation = "AddTable"
                };

                Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ============
        // Update Table
        // ============
        public String[] UpdateTable(Int32 id, Entities.MstTableEntity objTable)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var table = from d in db.MstTables
                            where d.Id == id
                            select d;

                if (table.Any())
                {
                    var tableGroup = from d in db.MstTableGroups
                                     where d.Id == objTable.TableGroupId
                                     select d;

                    if (tableGroup.Any() == false)
                    {
                        return new String[] { "Table group not found.", "0" };
                    }

                    String oldObject = Modules.SysAuditTrailModule.GetObjectString(table.FirstOrDefault());

                    var updateTable = table.FirstOrDefault();
                    updateTable.TableCode = objTable.TableCode;
                    updateTable.SortNumber = objTable.SortNumber;
                    db.SubmitChanges();

                    String newObject = Modules.SysAuditTrailModule.GetObjectString(table.FirstOrDefault());

                    Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                    {
                        UserId = currentUserLogin.FirstOrDefault().Id,
                        AuditDate = DateTime.Now,
                        TableInformation = "MstTable",
                        RecordInformation = oldObject,
                        FormInformation = newObject,
                        ActionInformation = "UpdateTable"
                    };

                    Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Form not found.  " + id, "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ============
        // Delete Table
        // ============
        public String[] DeleteTable(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var table = from d in db.MstTables
                            where d.Id == id
                            select d;

                if (table.Any())
                {
                    var deleteTable = table.FirstOrDefault();
                    db.MstTables.DeleteOnSubmit(deleteTable);

                    String oldObject = Modules.SysAuditTrailModule.GetObjectString(table.FirstOrDefault());

                    Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                    {
                        UserId = currentUserLogin.FirstOrDefault().Id,
                        AuditDate = DateTime.Now,
                        TableInformation = "MstTable",
                        RecordInformation = oldObject,
                        FormInformation = "",
                        ActionInformation = "DeleteTable"
                    };

                    Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);

                    db.SubmitChanges();

                    return new String[] { "", "1" };
                }
                else
                {
                    return new String[] { "Form not found.", "0" };
                }
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }
    }
}
