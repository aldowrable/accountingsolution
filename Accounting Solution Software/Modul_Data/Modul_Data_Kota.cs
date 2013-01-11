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
    public partial class Modul_Data_Kota : Form
    {
        protected String prefix = "kota";
        protected MainForm mf;
        public Modul_Data_Kota(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void kotaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kotaBindingSource.EndEdit();
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

        private void Modul_Data_Kota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.master_Data.Kota);

        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void kotaDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                this.kotaBindingSource.EndEdit();
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
