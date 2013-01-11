using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounting_Solution_Software.Classes;

namespace Accounting_Solution_Software
{
    public partial class Modul_Data_Bank : Form
    {
        protected MainForm mf;
        protected String prefix = "bank";

        public Modul_Data_Bank(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void bankBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bankBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.master_Data);
            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("id "+ prefix +" harus diisi.");
            }

        }

        private void Modul_Data_Bank_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.master_Data.Account);
            // TODO: This line of code loads data into the 'master_Data.Bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.master_Data.Bank);
            // TODO: This line of code loads data into the 'master_Data.Bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.master_Data.Bank);

        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void bankBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bankBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.master_Data);
            }
            catch (NullReferenceException ee)
            {
            }
            catch (ConstraintException ee)
            {
                MessageBox.Show("Duplikasi ID Bank, silakan input ID Bank yang unik");
            }

        }

        private void bankDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                this.bankBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.master_Data);
            }
            catch (NullReferenceException ee)
            {
            }
            catch (ConstraintException ee)
            {
                MessageBox.Show("Duplikasi ID Bank, silakan input ID Bank yang unik");
            }
        }
    }
}
