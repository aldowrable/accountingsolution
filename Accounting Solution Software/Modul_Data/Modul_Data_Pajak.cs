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
    public partial class Modul_Data_Pajak : Form
    {
        protected MainForm mf;
        protected String prefix = "pajak";

        public Modul_Data_Pajak(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void pajakBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pajakBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.master_Data);
            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("id "+ prefix +" harus diisi.");
            }
            catch (ConstraintException ee)
            {
                MessageBox.Show("Duplikasi id " + prefix + ", silakan input id " + prefix + " yang unik");
            }
        }

        private void Modul_Data_Pajak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Pajak' table. You can move, or remove it, as needed.
            this.pajakTableAdapter.Fill(this.master_Data.Pajak);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void pajakDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                this.pajakBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.master_Data);
            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("id " + prefix + " harus diisi.");
            }
            catch (ConstraintException ee)
            {
                MessageBox.Show("Duplikasi id " + prefix + ", silakan input id " + prefix + " yang unik");
            }
        }
    }
}
