using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyPOS.Controllers
{
    class MstUserFormController
    {
        // ============
        // Data Context
        // ============
        public Data.easyposdbDataContext db = new Data.easyposdbDataContext(Modules.SysConnectionStringModule.GetConnectionString());

        // ==============
        // List User Form
        // ==============
        public List<Entities.MstUserFormEntity> ListUserForm(Int32 userId)
        {
            var userForms = from d in db.MstUserForms
                            where d.UserId == userId
                            select new Entities.MstUserFormEntity
                            {
                                Id = d.Id,
                                FormId = d.FormId,
                                Form = d.SysForm.FormDescription,
                                UserId = d.UserId,
                                CanDelete = d.CanDelete,
                                CanAdd = d.CanAdd,
                                CanLock = d.CanLock,
                                CanUnlock = d.CanUnlock,
                                CanPrint = d.CanPrint,
                                CanPreview = d.CanPreview,
                                CanEdit = d.CanEdit,
                                CanTender = d.CanTender,
                                CanDiscount = d.CanDiscount,
                                CanView = d.CanView,
                                CanSplit = d.CanSplit,
                                CanCancel = d.CanCancel,
                                CanReturn = d.CanReturn
                            };

            return userForms.OrderByDescending(d => d.Id).ToList();
        }


        // ==========
        // List Users
        // ==========
        public List<Entities.MstUserEntity> ListUser()
        {
            var users = from d in db.MstUsers
                        where d.IsLocked == true
                        select new Entities.MstUserEntity
                        {
                            Id = d.Id,
                            UserName = d.UserName,
                        };

            return users.OrderBy(d => d.Id).ToList();
        }

        public String[] CopyUserRight(Int32 userId, Int32 copyRightFromUserId)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var user = from d in db.MstUsers
                           where d.Id == userId
                           select d;

                if (user.Any() == false)
                {
                    return new String[] { "User transaction not found.", "0" };
                }

                var currentUserFormList = from d in db.MstUserForms
                                          where d.UserId == userId
                                          select d;

                if (currentUserFormList.Any()) {

                    db.MstUserForms.DeleteAllOnSubmit(currentUserFormList);
                    db.SubmitChanges();
                }

                var userForms = from d in db.MstUserForms
                                where d.UserId == copyRightFromUserId
                                select d;

                if (userForms.Any())
                {
                    List<Data.MstUserForm> newForms = new List<Data.MstUserForm>();
                    foreach (var userForm in userForms)
                    {
                        newForms.Add(new Data.MstUserForm()
                        {
                            FormId = userForm.FormId,
                            UserId = userId,
                            CanDelete = userForm.CanDelete,
                            CanAdd = userForm.CanAdd,
                            CanLock = userForm.CanLock,
                            CanUnlock = userForm.CanUnlock,
                            CanPrint = userForm.CanPrint,
                            CanPreview = userForm.CanPreview,
                            CanEdit = userForm.CanEdit,
                            CanTender = userForm.CanTender,
                            CanDiscount = userForm.CanDiscount,
                            CanView = userForm.CanView,
                            CanSplit = userForm.CanSplit,
                            CanCancel = userForm.CanCancel,
                            CanReturn = userForm.CanReturn
                        });
                    }

                    db.MstUserForms.InsertAllOnSubmit(newForms);
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

        // ==================
        // Dropdown List Form
        // ==================
        public List<Entities.SysFormEntity> DropdownListForm()
        {
            var forms = from d in db.SysForms
                        select new Entities.SysFormEntity
                        {
                            Id = d.Id,
                            Form = d.Form,
                            FormDescription = d.FormDescription
                        };

            return forms.OrderBy(d => d.FormDescription).ToList();
        }

        // =============
        // Add User Form
        // =============
        public String[] AddUserForm(Entities.MstUserFormEntity objUserForm)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var user = from d in db.MstUsers
                           where d.Id == objUserForm.UserId
                           select d;

                if (user.Any() == false)
                {
                    return new String[] { "User transaction not found.", "0" };
                }

                var form = from d in db.SysForms
                           where d.Id == objUserForm.FormId
                           select d;

                if (form.Any() == false)
                {
                    return new String[] { "Form not found.", "0" };
                }

                Data.MstUserForm newUserForm = new Data.MstUserForm
                {
                    FormId = objUserForm.FormId,
                    UserId = objUserForm.UserId,
                    CanDelete = objUserForm.CanDelete,
                    CanAdd = objUserForm.CanAdd,
                    CanLock = objUserForm.CanLock,
                    CanUnlock = objUserForm.CanUnlock,
                    CanPrint = objUserForm.CanPrint,
                    CanPreview = objUserForm.CanPreview,
                    CanEdit = objUserForm.CanEdit,
                    CanTender = objUserForm.CanTender,
                    CanDiscount = objUserForm.CanDiscount,
                    CanView = objUserForm.CanView,
                    CanSplit = objUserForm.CanSplit,
                    CanCancel = objUserForm.CanCancel,
                    CanReturn = objUserForm.CanReturn
                };

                db.MstUserForms.InsertOnSubmit(newUserForm);
                db.SubmitChanges();

                String newObject = Modules.SysAuditTrailModule.GetObjectString(newUserForm);

                Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                {
                    UserId = currentUserLogin.FirstOrDefault().Id,
                    AuditDate = DateTime.Now,
                    TableInformation = "MstUserForm",
                    RecordInformation = "",
                    FormInformation = newObject,
                    ActionInformation = "AddUserForm"
                };
                Modules.SysAuditTrailModule.InsertAuditTrail(newAuditTrail);

                return new String[] { "", "1" };
            }
            catch (Exception e)
            {
                return new String[] { e.Message, "0" };
            }
        }

        // ================
        // Update User Form
        // ================
        public String[] UpdateUserForm(Int32 id, Entities.MstUserFormEntity objUserForm)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var userForm = from d in db.MstUserForms
                               where d.Id == id
                               select d;

                if (userForm.Any())
                {
                    var user = from d in db.MstUsers
                               where d.Id == objUserForm.UserId
                               select d;

                    if (user.Any() == false)
                    {
                        return new String[] { "User transaction not found.", "0" };
                    }

                    String oldObject = Modules.SysAuditTrailModule.GetObjectString(userForm.FirstOrDefault());

                    var updateUserForm = userForm.FirstOrDefault();
                    updateUserForm.FormId = objUserForm.FormId;
                    updateUserForm.CanDelete = objUserForm.CanDelete;
                    updateUserForm.CanAdd = objUserForm.CanAdd;
                    updateUserForm.CanLock = objUserForm.CanLock;
                    updateUserForm.CanUnlock = objUserForm.CanUnlock;
                    updateUserForm.CanPrint = objUserForm.CanPrint;
                    updateUserForm.CanPreview = objUserForm.CanPreview;
                    updateUserForm.CanEdit = objUserForm.CanEdit;
                    updateUserForm.CanTender = objUserForm.CanTender;
                    updateUserForm.CanDiscount = objUserForm.CanDiscount;
                    updateUserForm.CanView = objUserForm.CanView;
                    updateUserForm.CanSplit = objUserForm.CanSplit;
                    updateUserForm.CanCancel = objUserForm.CanCancel;
                    updateUserForm.CanReturn = objUserForm.CanReturn;
                    db.SubmitChanges();

                    String newObject = Modules.SysAuditTrailModule.GetObjectString(userForm.FirstOrDefault());

                    Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                    {
                        UserId = currentUserLogin.FirstOrDefault().Id,
                        AuditDate = DateTime.Now,
                        TableInformation = "MstUserForm",
                        RecordInformation = oldObject,
                        FormInformation = newObject,
                        ActionInformation = "UpdateUserForm"
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

        // ================
        // Delete User Form
        // ================
        public String[] DeleteUserForm(Int32 id)
        {
            try
            {
                var currentUserLogin = from d in db.MstUsers where d.Id == Convert.ToInt32(Modules.SysCurrentModule.GetCurrentSettings().CurrentUserId) select d;
                if (currentUserLogin.Any() == false)
                {
                    return new String[] { "Current login user not found.", "0" };
                }

                var userForm = from d in db.MstUserForms
                               where d.Id == id
                               select d;

                if (userForm.Any())
                {
                    var deleteUserForm = userForm.FirstOrDefault();
                    db.MstUserForms.DeleteOnSubmit(deleteUserForm);

                    String oldObject = Modules.SysAuditTrailModule.GetObjectString(userForm.FirstOrDefault());

                    Entities.SysAuditTrailEntity newAuditTrail = new Entities.SysAuditTrailEntity()
                    {
                        UserId = currentUserLogin.FirstOrDefault().Id,
                        AuditDate = DateTime.Now,
                        TableInformation = "MstUserForm",
                        RecordInformation = oldObject,
                        FormInformation = "",
                        ActionInformation = "DeleteUserForm"
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
