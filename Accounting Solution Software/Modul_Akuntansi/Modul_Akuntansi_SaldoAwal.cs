using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting_Solution_Software
{
    public partial class Modul_Akuntansi_SaldoAwal : Form
    {
        private MainForm mf = null;
        private String prefix = "Saldo Awal";

        public Modul_Akuntansi_SaldoAwal()
        {
            InitializeComponent();
        }

        public Modul_Akuntansi_SaldoAwal(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.master_Data);

            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("Kode Perkiraan "+ prefix +" harus diisi.");
            }

        }

        private void Modul_Akuntansi_SaldoAwal_Load(object sender, EventArgs e)
        {
            this.accountTableAdapter.Fill(this.master_Data.Account);
        }

        private void accountBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.accountBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.master_Data);

            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("Kode Perkiraan "+ prefix +" harus diisi.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            close();
        }

        private void close()
        {
            if (this.mf != null)
            {
                mf.Enabled = true;
            }
            Close();
            Dispose();
        }

        private void accountDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                this.accountBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.master_Data);
            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("Kode Perkiraan " + prefix + " harus diisi.");
            }
        }
    }
}
