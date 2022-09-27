using EasyPOS.Interfaces.Forms;
using System;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.MstTableGroup
{
    public partial class MstTableDetailForm : Form
    {
        IUpdateListDataSource FormWithUpdate;
        private Modules.SysUserRightsModule sysUserRights;

        Entities.MstTableEntity mstTableEntity;

        public MstTableDetailForm(IUpdateListDataSource formWithUpdate, Entities.MstTableEntity tableEntity)
        {
            InitializeComponent();
            FormWithUpdate = formWithUpdate;
            mstTableEntity = tableEntity;

            sysUserRights = new Modules.SysUserRightsModule("MstRestaurantTableDetail");
            if (sysUserRights.GetUserRights() == null)
            {
                MessageBox.Show("No rights!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (sysUserRights.GetUserRights().CanAdd == false)
                {
                    buttonSave.Enabled = false;
                }

                LoadTable();
                textBoxTableCode.Focus();
            }
        }

        public void LoadTable()
        {
            if (mstTableEntity != null)
            {
                textBoxTableCode.Text = mstTableEntity.TableCode;
                textBoxSortNumber.Text = Convert.ToString(mstTableEntity.SortNumber);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (mstTableEntity.Id == 0)
            {
                Entities.MstTableEntity newTable = new Entities.MstTableEntity()
                {
                    TableCode = textBoxTableCode.Text,
                    SortNumber = Convert.ToInt32(textBoxSortNumber.Text),
                    TableGroupId = mstTableEntity.TableGroupId
                };

                Controllers.MstTableController mstTableController = new Controllers.MstTableController();
                String[] addTable = mstTableController.AddTable(newTable);
                if (addTable[1].Equals("0") == true)
                {
                    MessageBox.Show(addTable[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormWithUpdate.UpdateListDataSource();
                    Close();
                }
            }
            else
            {
                mstTableEntity.TableCode = textBoxTableCode.Text;
                mstTableEntity.SortNumber = Convert.ToInt32(textBoxSortNumber.Text);
                Controllers.MstTableController mstTableController = new Controllers.MstTableController();
                String[] updateTable = mstTableController.UpdateTable(mstTableEntity.Id, mstTableEntity);
                if (updateTable[1].Equals("0") == true)
                {
                    MessageBox.Show(updateTable[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormWithUpdate.UpdateListDataSource();
                    Close();
                }

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}