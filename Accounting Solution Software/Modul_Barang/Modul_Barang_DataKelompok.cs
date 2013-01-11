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
    public partial class Modul_Barang_DataKelompok : Form
    {
        private MainForm mf = null;
        public Modul_Barang_DataKelompok(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }



        private void kelompokProdukBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kelompokProdukBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_Data);

        }

        private void Modul_Barang_DataKelompok_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Dokter' table. You can move, or remove it, as needed.
            this.dokterTableAdapter.Fill(this.master_Data.Dokter);
            // TODO: This line of code loads data into the 'stock_Data.KelompokProduk' table. You can move, or remove it, as needed.
            this.kelompokProdukTableAdapter.Fill(this.stock_Data.KelompokProduk);
            // TODO: This line of code loads data into the 'stock_Data.KelompokProduk' table. You can move, or remove it, as needed.
            this.kelompokProdukTableAdapter.Fill(this.stock_Data.KelompokProduk);

        }

        private void kelompokProdukBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kelompokProdukBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.stock_Data);
            }
            catch (NullReferenceException ee)
            {
            }
            catch (ConstraintException ce)
            {
                MessageBox.Show("Duplikasi kode kelompok, silakan input kode kelompok yang unik");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mf != null)
            {
                mf.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void kelompokProdukDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                this.kelompokProdukBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.stock_Data);
            }
            catch (NullReferenceException ee)
            {
            }
            catch (ConstraintException ce)
            {
                MessageBox.Show("Duplikasi kode kelompok, silakan input kode kelompok yang unik");
            }
        }
    }
}
