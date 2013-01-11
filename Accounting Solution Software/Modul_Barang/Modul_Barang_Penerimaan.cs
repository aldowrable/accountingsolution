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
    public partial class Modul_Barang_Penerimaan : Form
    {
        private MainForm mf = null;
        private TerimaBarang terimaBarang = new TerimaBarang();
        private SubTerimaBarang subTerimaBarang = new SubTerimaBarang();
        private Stock stock = new Stock();
        private SqlDataReader sdr = null;
        private AllFunc allFunc = null;
        private DbObject dbo = new DbObject();
        private string noBuktiTB = "";
        private bool edit = true;
        private DataTable dt = null;

        public Modul_Barang_Penerimaan(MainForm mf)
        {
            InitializeComponent();
            allFunc = new AllFunc("Penerimaan Barang", mf);
            this.mf = mf;
        }

        private void blank_field()
        {
            noBonTextBox.Text = "";
            NomorBuktiPembelianTextBox.Text = "";
            kodeSupplierTextBox.Text = "";
            namaSupplierTextBox.Text = "";
            nomorSJTextBox.Text = "";
            eraseSubTerimaBarangDataGridView();
        }

        private void refreshView_jual_nobonDataGridView()
        {
            this.purchaseOrderTableAdapter.get_delayed_delivery(this.purchase_Order.PurchaseOrder);
            this.view_TerimaBarang_SupplierTableAdapter.FillByLast3Months(this.terima_Barang.view_TerimaBarang_Supplier);
            view_jual_nobonDataGridView.Refresh();
            //this.view_subTerimaBarang_StockTableAdapter.Fill(this.terima_Barang.view_subTerimaBarang_Stock);
            subTerimaBarangDataGridView.Refresh();

        }

        private void Modul_Barang_Penerimaan_Load(object sender, EventArgs e)
        {
            this.purchaseOrderTableAdapter.get_delayed_delivery(this.purchase_Order.PurchaseOrder);
            //this.terimaBarangTableAdapter.Fill(this.terima_Barang.TerimaBarang);
            //this.view_subTerimaBarang_StockTableAdapter.Fill(this.terima_Barang.view_subTerimaBarang_Stock);
            this.view_TerimaBarang_SupplierTableAdapter.FillByLast3Months(this.terima_Barang.view_TerimaBarang_Supplier);
        }

        private void keluarBtn_Click(object sender, EventArgs e)
        {
            if(mf != null)
            {
                mf.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            rebind_all();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void changeFilter()
        {
            this.view_TerimaBarang_SupplierTableAdapter.Fill(this.terima_Barang.view_TerimaBarang_Supplier);

            string recieveAll = "";
            //if(checkBox1.Checked)
            //{
            //    recieveAll = "AND (TotalQtyTerima < TotalQty)";
            //}
            view_TerimaBarang_SupplierBindingSource.Filter = "(NomorBukti LIKE '%" + cariTxt.Text + "%' OR NomorBuktiPembelian LIKE '%" + cariTxt.Text + "%' OR KodeSupplier LIKE '%" + cariTxt.Text + "%' OR NamaSupplier LIKE '%" + cariTxt.Text + "%' OR NomorSJ LIKE '%" + cariTxt.Text + "%') " + recieveAll;

            if ((cariTxt.Text.CompareTo("") == 0) )//&& (!checkBox1.Checked))
            {
                this.view_TerimaBarang_SupplierTableAdapter.FillByLast3Months(this.terima_Barang.view_TerimaBarang_Supplier);
                view_TerimaBarang_SupplierBindingSource.Filter = "";
            }

            view_jual_nobonDataGridView.DataSource = view_TerimaBarang_SupplierBindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                bool err = false;
                string spQuery = null;
                String v1 = noBonTextBox.Text;
                String v2 = NomorBuktiPembelianTextBox.SelectedValue.ToString();
                String v3 = nomorSJTextBox.Text;

                if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (v3.CompareTo("") != 0))
                {
                    string v4 = kodeSupplierTextBox.Text;
                    string v5 = StatusPembelianTextbox.Text;
                    DataGridView dgv = subTerimaBarangDataGridView;
                    double qty = 0;
                    double qtyTerima = 0;
                    string kodeBarang = null;
                    DateTime v6 = Convert.ToDateTime(tanggalDateTimePicker.Text);

                    if (edit) //Kalau Edit
                    {
                        spQuery += "exec [dbo].[TerimaBarang_Update] '" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "','" + v5 + "';";                        
                        spQuery += "exec [dbo].[SubTerimaBarang_DeleteRow_by_IdTB] '" + v1 + "';";
                    }
                    else
                    {
                        spQuery += "exec [dbo].[PurchaseOrder_Terkirim] '" + v2 + "';";
                        spQuery += "exec [dbo].[TerimaBarang_Insert] '" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "','" + v5 + "','" + v6 + "';";
                    }

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        qty = Convert.ToDouble(dgv.Rows[i].Cells[2].Value.ToString());
                        qtyTerima = Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString());
                        kodeBarang = dgv.Rows[i].Cells[0].Value.ToString();
                        spQuery += "exec [dbo].[SubTerimaBarang_Insert] '" + v1 + "'," + qty + "," + qtyTerima + ",'" + kodeBarang + "','" + v6 + "','d';";
                    }

                    dbo.run_query(spQuery);
                    edit = true;

                    if (!err)
                    {
                        MessageBox.Show("Transaksi " + allFunc.Prefix + " berhasil dilakukan.");
                        print_laporan(v1);
                        rebind_all();
                    }

                }
                else
                {
                    MessageBox.Show("NomorBukti Pembelian , Nomor Faktur , Supplier , dan Item harus terisi.");
                }





                //if (nomorSJTextBox.Text.CompareTo("") != 0)
                //{
                //    terimaBarang.UpdateRow(noBonTextBox.Text, nomorBuktiPembelianTextBox.Text, nomorSJTextBox.Text, kodeSupplierTextBox.Text, "");
                //    terimaBarang.UpdateRow(noBonTextBox.Text, "", nomorSJTextBox.Text, kodeSupplierTextBox.Text, "");

                //    string fail = null;
                //    for (int i = 0; i < subTerimaBarangDataGridView.RowCount; i++)
                //    {
                //        double qtyTerima = Convert.ToDouble(subTerimaBarangDataGridView.Rows[i].Cells[4].Value.ToString());
                //        double qty = Convert.ToDouble(subTerimaBarangDataGridView.Rows[i].Cells[2].Value.ToString());
                //        string status = subTerimaBarangDataGridView.Rows[i].Cells[5].Value.ToString();
                //        double qtyTerimaSebelum = 0;
                //        if ((subTerimaBarangDataGridView.Rows[i].Cells[6].Value != DBNull.Value) && (subTerimaBarangDataGridView.Rows[i].Cells[6].Value != null))
                //        {
                //            qtyTerimaSebelum = Convert.ToDouble(subTerimaBarangDataGridView.Rows[i].Cells[6].Value.ToString());
                //        }

                //        if (qtyTerima > qty)
                //        {
                //            MessageBox.Show("Qty Stock Terima tidak boleh lebih besar dari qty pembelian.");
                //        }
                //        else
                //        {
                //            string statusAkhir = "d";
                //            string kodeStock = subTerimaBarangDataGridView.Rows[i].Cells[0].Value.ToString();
                //            if ((qtyTerima <= qty) && (status.ToLower().CompareTo("p") == 0) && (qtyTerima > qtyTerimaSebelum))
                //            {
                //                stock.TambahJumlah(kodeStock, (float)qtyTerima - (float)qtyTerimaSebelum);
                //                if (qtyTerima < qty)
                //                {
                //                    statusAkhir = "p";
                //                }
                //                subTerimaBarang.UpdateRow(0, noBonTextBox.Text, (float)qtyTerima, kodeStock, DateTime.Today, statusAkhir, "t");
                //            }
                //            else if ((qtyTerima == qty) && (status.ToLower().CompareTo("d") == 0))
                //            { }
                //            else
                //            {
                //                fail += kodeStock + " ,";
                //            }

                //        }

                //    }

                //    if (fail == null)
                //    {
                //        MessageBox.Show("Stock telah diterima dan ditambahkan.");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Kode Stock " + fail + " tidak dapat ditambahkan.");
                //    }
                //    refreshView_jual_nobonDataGridView();
                //    tabControl1.SelectedIndex = 0;
                //}
                //else
                //{
                //    MessageBox.Show("Nomor Surat Jalan harus diisi.");
                //}

            }
            catch (FormatException fe_e)
            {
                MessageBox.Show("Silakan input Qty terima barang dengan digit.");
            }
        }

        private void print_laporan(string id)
        {
            if (printChkBox.Checked)
            {
                Modul_Laporan_PenerimaanBarang laporan = new Modul_Laporan_PenerimaanBarang(id);
                laporan.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void subTerimaBarangDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if((e.ColumnIndex == 4)&&(e.RowIndex >=0))
            {
                try
                {

                    double qtyTerima = Convert.ToDouble(subTerimaBarangDataGridView.Rows[subTerimaBarangDataGridView.CurrentCell.RowIndex].Cells[subTerimaBarangDataGridView.CurrentCell.ColumnIndex].Value.ToString());
                    double qty = Convert.ToDouble(subTerimaBarangDataGridView.Rows[subTerimaBarangDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString());

                    if (qtyTerima > qty)
                    {
                        MessageBox.Show("Quantity Terima lebih besar dari Quantity Pemesanan.");
                        //subTerimaBarangDataGridView.Rows[subTerimaBarangDataGridView.CurrentCell.RowIndex].Cells[subTerimaBarangDataGridView.CurrentCell.ColumnIndex].Value = 0;
                    }
                }
                catch(FormatException fe_e)
                {
                    MessageBox.Show("Silakan input Qty terima barang dengan digit.");
                }
            }
        }

        private void edit_item(String noBukti)
        {
            tabControl1.SelectTab(1);
            sdr = dbo.get_single_data(new String[]{"NomorBukti","NomorBuktiPembelian","NomorSJ","KodeSupplier","NamaSupplier","Keterangan","Tanggal"}, "NomorBukti", noBukti, "view_terimabarang_supplier");
            while (sdr.Read())
            {
                noBonTextBox.Text = (string)sdr["NomorBukti"];
                NomorBuktiPembelianTextBox.Text = (string)sdr["NomorBuktiPembelian"];
                kodeSupplierTextBox.Text = (string)sdr["KodeSupplier"];
                namaSupplierTextBox.Text = (string)sdr["NamaSupplier"];
                
                nomorSJTextBox.Text = (string)sdr["NomorSJ"];
                StatusPembelianTextbox.Text = (string)sdr["Keterangan"];
                tanggalDateTimePicker.Value = (DateTime)sdr["Tanggal"];
            }

            //

            String[] fields = new String[] { "KodeBarang AS [Kode Produk]", "NamaStock AS [Nama Produk]", "qty AS Qty", "satuan AS [Satuan]", "QtyTerima As [Qty Terima]" };
            dt = dbo.get_all(fields, "view_subTerimaBarang_Stock", "NomorBukti = '" + noBukti + "'", "", "", 0, 0);

            subTerimaBarangDataGridView.DataSource = dt;

            set_dgv_column_readonly();
            NomorBuktiPembelianTextBox.Enabled = false;
            subTerimaBarangDataGridView.Refresh();

            edit = true;
        }

        private void set_dgv_column_readonly()
        {
            subTerimaBarangDataGridView.Columns[0].ReadOnly = true;
            subTerimaBarangDataGridView.Columns[1].ReadOnly = true;
            subTerimaBarangDataGridView.Columns[2].ReadOnly = true;
            subTerimaBarangDataGridView.Columns[3].ReadOnly = true;
        }

        public void set_dgv_column()
        {
            subTerimaBarangDataGridView.Columns.Add("kodeproduk", "Kode Produk");
            subTerimaBarangDataGridView.Columns.Add("NamaStock", "Nama Produk");
            subTerimaBarangDataGridView.Columns.Add("qty", "Qty");
            subTerimaBarangDataGridView.Columns.Add("satuan", "Satuan");
            subTerimaBarangDataGridView.Columns.Add("qtyterima", "Qty Terima");
            subTerimaBarangDataGridView.Columns["qtyterima"].ValueType = typeof(double);
        }

        private void subTerimaBarangDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Silakan input Qty terima barang dengan digit.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Modul_Laporan_PenerimaanBarang_ByPembelian laporanpenerimaanbarang = new Modul_Laporan_PenerimaanBarang_ByPembelian(nomorBuktiPembelianTextBox.Text);
            //laporanpenerimaanbarang.showReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tanggalDateTimePicker.Enabled = true;
            tambah_terima_barang();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (view_jual_nobonDataGridView.Rows.Count>0)
                {
                    edit_item(view_jual_nobonDataGridView.Rows[view_jual_nobonDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    tambah_terima_barang();
                }
            }
        }

        private void tambah_terima_barang()
        {
            edit = false;
            blank_field();
            refreshNoBukti();
            eraseSubTerimaBarangDataGridView();
            nomor_po_rebind();
            StatusPembelianTextbox.Text = "D";
        }

        private void NomorBuktiPembelianTextBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            set_detail_by_PO(NomorBuktiPembelianTextBox.SelectedValue.ToString());
        }

        private void set_detail_by_PO(string poId)
        {
            sdr = dbo.get_single_data(null, "id", poId, "view_po_supplier");
            while (sdr.Read())
            {
                kodeSupplierTextBox.Text = check_dbnull_string(sdr["KodeSupplier"]);
                namaSupplierTextBox.Text = check_dbnull_string(sdr["NamaSupplier"]);
            }
            String[] fields = new String[] { "KodeProduk AS [Kode Produk]", "NamaStock AS [Nama Produk]", "qty AS Qty", "satuan AS Satuan", "0 AS [Qty Terima]"};
            DataTable dtPO = dbo.get_all(fields, "view_po_subpo_stock", "id = '" + poId + "'", "", "", 0, 0);

            eraseSubTerimaBarangDataGridView();

            subTerimaBarangDataGridView.DataSource = dtPO;
            //foreach (DataRow row in dt.Rows) // Loop over the rows.
            //{
            //    subTerimaBarangDataGridView.Rows.Add(row.ItemArray);
            //}
            subTerimaBarangDataGridView.Refresh();
            set_dgv_column_readonly();
        }

        private string check_dbnull_string(Object obj)
        {
            return (obj is System.DBNull) ? string.Empty : obj.ToString();
        }

        private void eraseSubTerimaBarangDataGridView()
        {
            try
            {
                this.subTerimaBarangDataGridView.DataSource = null;
                this.subTerimaBarangDataGridView.Columns.Clear();
                this.subTerimaBarangDataGridView.Rows.Clear();
                this.subTerimaBarangDataGridView.Refresh();
            }
            catch (ArgumentException ae){}
        }

        public void resetSubTerimaBarangDataGridView()
        {
            //this.subTerimaBarangDataGridView.DataSource = this.viewTerimaBarangSupplierviewsubTerimaBarangStockBindingSource;
            //this.view_subTerimaBarang_StockTableAdapter.Fill(this.terima_Barang.view_subTerimaBarang_Stock);
        }

        private void rebind_all()
        {
            blank_field();
            tabControl1.SelectedIndex = 0;
            refreshView_jual_nobonDataGridView();
            resetSubTerimaBarangDataGridView();
            nomor_po_bind();
        }

        private void nomor_po_rebind()
        {
                this.NomorBuktiPembelianTextBox.DataBindings.Clear();
                this.NomorBuktiPembelianTextBox.Enabled = true;
                this.NomorBuktiPembelianTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.view_TerimaBarang_SupplierBindingSource, "NomorBuktiPembelian", true));
                this.NomorBuktiPembelianTextBox.DataSource = this.purchaseOrderBindingSource;
                this.NomorBuktiPembelianTextBox.DisplayMember = "id";
                this.NomorBuktiPembelianTextBox.ValueMember = "id";

        }

        private void nomor_po_bind()
        {
            this.NomorBuktiPembelianTextBox.DataBindings.Clear();
            this.NomorBuktiPembelianTextBox.DataSource = this.view_TerimaBarang_SupplierBindingSource;
            this.NomorBuktiPembelianTextBox.DisplayMember = "NomorBuktiPembelian";
            this.NomorBuktiPembelianTextBox.Enabled = false;
            this.NomorBuktiPembelianTextBox.Name = "NomorBuktiPembelianTextBox";
            this.NomorBuktiPembelianTextBox.ValueMember = "NomorBuktiPembelian";

        }

        private void refreshNoBukti()
        {
            sdr = terimaBarang.generateNoBukti();
            while (sdr.Read())
            {
                noBuktiTB = (string)sdr["result"];
                noBonTextBox.Text = (string)sdr["result"];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedIndex = 1;
            if (view_jual_nobonDataGridView.RowCount > 0)
            {
                edit_item(view_jual_nobonDataGridView.Rows[view_jual_nobonDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            else
            {
                tambah_terima_barang();
            }
        }

        private void view_jual_nobonDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                edit_item(view_jual_nobonDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modul_Pembelian pembelian = new Modul_Pembelian();
            pembelian.Show();
        }

    }
}
