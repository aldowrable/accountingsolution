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
    public partial class Modul_Barang_DataSatuan : Form
    {
        protected MainForm mf;
        protected String prefix = "satuan";

        public Modul_Barang_DataSatuan()
        {
            InitializeComponent();
        }

        public Modul_Barang_DataSatuan(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void refresh_data_grid()
        {
            satuanDataGridView.Enabled = true;
            this.satuanTableAdapter.Fill(this.stock_Data.Satuan);
            satuanDataGridView.Refresh();
        }

        private void satuanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.satuanBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.stock_Data);
            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("id " + prefix + " harus diisi.");
            }
        }

        private void Modul_Barang_CariStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_Data.Satuan' table. You can move, or remove it, as needed.
            this.satuanTableAdapter.Fill(this.stock_Data.Satuan);
            // TODO: This line of code loads data into the 'stock_Data.Satuan' table. You can move, or remove it, as needed.
            this.satuanTableAdapter.Fill(this.stock_Data.Satuan);

        }


        private void btn_keluar_Click(object sender, EventArgs e)
        {
            mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void satuanBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try{

                this.Validate();
                this.satuanBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.stock_Data);
            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("id "+ prefix +" harus diisi.");
            }
        }
    }
}
