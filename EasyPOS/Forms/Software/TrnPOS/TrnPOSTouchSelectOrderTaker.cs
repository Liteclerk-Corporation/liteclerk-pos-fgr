using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSTouchSelectOrderTaker : Form
    {
        private List<Entities.MstUserEntity> listTables = new List<Entities.MstUserEntity>();
        private ToolTip tableToolTip = new ToolTip();
        private const int tableNoOfButtons = 30;
        Button[] tableButtons;
        public Entities.TrnSalesEntity trnSalesEntity;
        public TrnPOSTouchActivityForm trnPOSTouchActivityForm;
        public TrnPOSTouchForm trnPOSTouchForm;
        public TrnPOSTouchSelectOrderTaker(TrnPOSTouchForm POSTouchForm,TrnPOSTouchActivityForm POSTouchActivityForm, Entities.TrnSalesEntity salesEntity)
        {
            InitializeComponent();

            trnPOSTouchForm = POSTouchForm;
            trnPOSTouchActivityForm = POSTouchActivityForm;
            trnSalesEntity = salesEntity;

            tableButtons = new Button[] {
                    buttonTable1,
                    buttonTable2,
                    buttonTable3,
                    buttonTable4,
                    buttonTable5,
                    buttonTable6,
                    buttonTable7,
                    buttonTable8,
                    buttonTable9,
                    buttonTable10,
                    buttonTable11,
                    buttonTable12,
                    buttonTable13,
                    buttonTable14,
                    buttonTable15,
                    buttonTable16,
                    buttonTable17,
                    buttonTable18,
                    buttonTable19,
                    buttonTable20,
                    buttonTable21,
                    buttonTable22,
                    buttonTable23,
                    buttonTable24,
                    buttonTable25,
                    buttonTable26,
                    buttonTable27,
                    buttonTable28,
                    buttonTable29,
                    buttonTable30
                };

            for (int i = 0; i < tableNoOfButtons; i++)
            {
                tableButtons[i].Click += new EventHandler(buttonTable_Click);
            }

            FillTable();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            String salesAgent = tableToolTip.GetToolTip(b);

            if (salesAgent.Equals("") == false)
            {
                Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();
                trnSalesController.UpdateOrderTaker(trnSalesEntity.Id, Convert.ToInt32(salesAgent));

                if (trnPOSTouchActivityForm != null)
                {
                    trnPOSTouchForm.UpdateSalesListGridDataSource();
                    trnPOSTouchActivityForm.Close();
                    Close();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Order Taker not found!", "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillTable()
        {
            try
            {
                Controllers.TrnSalesController trnSalesController = new Controllers.TrnSalesController();

                listTables = trnSalesController.ListOrderTaker();

                for (int i = 0; i < tableNoOfButtons; i++)
                {
                    tableToolTip.SetToolTip(tableButtons[i], "");
                    tableButtons[i].Text = "";
                }

                for (int i = 0; i < listTables.Count(); i++)
                {
                    tableToolTip.SetToolTip(tableButtons[i], listTables[i].Id.ToString());
                    tableButtons[i].Text = listTables[i].UserName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
