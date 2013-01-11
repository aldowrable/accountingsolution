using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Accounting_Solution_Software
{
    public partial class Modul_Barang_CariPopup : Form
    {
        public Modul_Barang_Pemindahan formBarangPemindahan = null;
        private Modul_Pembelian_InputBarangPopup inputBarangPopup = null;
        private Modul_POS modulPOS = null;
        private Modul_POS_Resep_Dokter modulPOSResepDokter = null;
        private Modul_Pembelian_PurchaseOrder modulPO = null;
        private Modul_Barang_StockOpname modulSO = null;

        public Modul_Barang_CariPopup()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public Modul_Barang_CariPopup(Modul_Pembelian_InputBarangPopup inputBarangPopup)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.inputBarangPopup = inputBarangPopup;
        }

        public Modul_Barang_CariPopup(Modul_Pembelian_PurchaseOrder modulPO)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.modulPO = modulPO;
        }

        public Modul_Barang_CariPopup(Modul_POS modulPOS)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.modulPOS = modulPOS;
        }

        public Modul_Barang_CariPopup(Modul_POS_Resep_Dokter modulPOSResepDokter)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.modulPOSResepDokter = modulPOSResepDokter;
        }

        public Modul_Barang_CariPopup(Modul_Barang_StockOpname modulSO)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.modulSO = modulSO;
        }

        public void setFormBarangPemindahan(Modul_Barang_Pemindahan fbp)
        {
            this.formBarangPemindahan = fbp;
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_Data);

        }

        private void Modul_Barang_CariPopup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_Data.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.stock_Data.Stock);
            if (this.modulPOS != null)
            {
                stockDataGridView.Columns[4].Visible = false;
                stockDataGridView.Columns[5].Visible = false;
                stockDataGridView.Columns[9].Visible = false;
                stockDataGridView.Columns[10].Visible = false;
                stockDataGridView.Columns[11].Visible = false;
                stockDataGridView.Columns[12].Visible = false;
                stockDataGridView.Columns[14].Visible = false;
                stockDataGridView.Columns[15].Visible = false;
                stockDataGridView.Columns[16].Visible = false;
                stockDataGridView.Columns[17].Visible = false;
                stockDataGridView.Columns[18].Visible = false;
                stockDataGridView.Columns[19].Visible = false;
                stockDataGridView.Refresh();
            }
            else if (this.modulPOSResepDokter != null)
            {
                stockDataGridView.Columns[4].Visible = false;
                stockDataGridView.Columns[5].Visible = false;
                stockDataGridView.Columns[9].Visible = false;
                stockDataGridView.Columns[10].Visible = false;
                stockDataGridView.Columns[11].Visible = false;
                stockDataGridView.Columns[12].Visible = false;
                stockDataGridView.Columns[14].Visible = false;
                stockDataGridView.Columns[15].Visible = false;
                stockDataGridView.Columns[16].Visible = false;
                stockDataGridView.Columns[17].Visible = false;
                stockDataGridView.Columns[18].Visible = false;
                stockDataGridView.Columns[19].Visible = false;
                stockDataGridView.Refresh();
            }
            txt_search_1.Focus();
        }

        private void stockDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                stockSelectedHandler();
            }

        }

        private void stockDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stockSelectedHandler();
        }

        private void stockSelectedHandler()
        {
            String kodeStock = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            String namaStock = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
            String satuan = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString();
            //String jmlStockLama = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //String hargaStockLama = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[4].Value.ToString();
            String barcode = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[16].Value.ToString();
            String hargaBeli = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString();
            String jmlStockLama = "";
            String hargaStockLama = "";
            String[] row = new String[] { kodeStock, namaStock, "", satuan,jmlStockLama,hargaStockLama };
            if (formBarangPemindahan != null)
            {
                String[] row1 = new String[] { barcode ,kodeStock, namaStock, "0",satuan };
                this.formBarangPemindahan.mutasiStockdataGridView.Rows.Add(row1);
            }
            else if (inputBarangPopup !=null )
            {
                this.inputBarangPopup.setForm(row);
            }
            else if(modulPO != null)
            {
                row = new String[] { kodeStock, namaStock, satuan, hargaBeli };
                this.modulPO.setItemDataGrid(row);
            }
            else if (modulPOS != null)
            {
                String hargaJual1 = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[6].Value.ToString();
                String hargaJual2 = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[7].Value.ToString();
                String hargaJual3 = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[8].Value.ToString();
                String jumlahStock = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString();
                String[] item = new String[] {kodeStock,namaStock,satuan,hargaJual1,hargaJual2,hargaJual3,jumlahStock};
                modulPOS.setItem(item);
            }
            else if (modulPOSResepDokter != null)
            {
                String hargaJual1 = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[6].Value.ToString();
                String hargaJual2 = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[7].Value.ToString();
                String hargaJual3 = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[8].Value.ToString();
                String jumlahStock = stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString();
                String[] item = new String[] { kodeStock, namaStock, satuan, hargaJual1, hargaJual2, hargaJual3, jumlahStock };
                modulPOSResepDokter.setItem(item);
            }
            else if(modulSO != null)
            {
                DbObject dbo = new DbObject();
                SqlDataReader sdr = dbo.get_single_data(new String[] { "saldo_akhir" }, "KodeStock", kodeStock, "view_saldo_stock_akhir");
                while (sdr.Read())
                {
                    row = new String[] { barcode, kodeStock, namaStock, ((double)sdr["saldo_akhir"]).ToString(),"0", satuan };
                    this.modulSO.setItemDataGrid(row);
                }

            }
            close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close();
        }

        private void close()
        {
            if (formBarangPemindahan != null)
            {
                formBarangPemindahan.Enabled = true;
            }
            else if (inputBarangPopup != null)
            {
                inputBarangPopup.Enabled = true;
            }

            this.Close();
            this.Dispose();
        }

        private void txt_search_1_TextChanged(object sender, EventArgs e)
        {
            stockBindingSource.Filter = "KodeStock LIKE '%" + txt_search_1.Text.ToLower() + "%' OR NamaStock LIKE '%" + txt_search_1.Text.ToLower() + "%'";
            stockDataGridView.DataSource = stockBindingSource;
            stockDataGridView.Refresh();            
        }

        private void Modul_Barang_CariPopup_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    {
                        close();
                        break;
                    }
            }
        }

        private void txt_search_1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    {
                        close();
                        break;
                    }
                case Keys.Enter:
                    {
                        stockSelectedHandler();
                        break;
                    }
            }
        }

        private void stockDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }


    }
}
