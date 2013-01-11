using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Accounting_Solution_Software.Classes;


namespace Accounting_Solution_Software
{
    public partial class Modul_Barang_Data : Form
    {

        protected Stock obj;
        protected MainForm mf;
        protected String prefix = "stock";
        AllFunc allfunc = new AllFunc();
        private bool edit = true;
        private DataTable dt = new DataTable();
        private SqlDataReader sdr = null;
        private DbObject dbo = new DbObject();


        public Modul_Barang_Data(MainForm mf)
        {
            InitializeComponent();
            obj = new Stock();
            this.mf = mf;
        }

        public Modul_Barang_Data()
        {
            InitializeComponent();
            obj = new Stock();
        }

        private void blank_field()
        {
            kodeStockTextBox.Text = "";
            kodeBarcodeTextBox.Text = "";
            namaStockTextBox.Text = "";
            kodeSupplierComboBox.Text = "";
            satuanComboBox.Text = "";
            namaKelompokComboBox.Text = " ";
            namaKelompokComboBox.SelectedValue = " ";
            stockMinimumTextBox.Text = "0";
            hbTxt.Text = "0";
            hargaJualTextBox.Text = "0";
            hj1Txt.Text = "0";
            hj2Txt.Text = "0";
            hj3Txt.Text = "0";
            hj4txt.Text = "0";
            qty1TextBox.Text = "0";
            qty2TextBox.Text = "0";
            qty3TextBox.Text = "0";
            qty4TextBox.Text = "0";
            disc1TextBox.Text = "0";
            disc2TextBox.Text = "0";
            disc3TextBox.Text = "0";
            discRpTextbox.Text = "0";
            ppnTextbox.Text = "0";
        }
        private void refresh_data_grid()
        {
            stockDataGridView.Enabled = true;
            this.view_stock_saldo_lengkapTableAdapter.Fill(this.stock_Data.View_stock_saldo_lengkap);
            stockDataGridView.Refresh();
        }

        public void refresh_all()
        {
            this.satuanTableAdapter.Fill(this.stock_Data.Satuan);
            this.kelompokProdukTableAdapter.Fill(this.stock_Data.KelompokProduk);
            this.satuanTableAdapter.Fill(this.stock_Data.Satuan);
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);
            this.view_stock_saldo_lengkapTableAdapter.Fill(this.stock_Data.View_stock_saldo_lengkap);
            stockDataGridView.Refresh();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if (mf != null) { mf.Enabled = true; }
            this.Close();
            this.Dispose();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silakan klik OK untuk menghapus data ?", "Konfirmasi", MessageBoxButtons.YesNo)
== DialogResult.Yes)
            {
                try
                {
                    //obj.DeleteRow(kodePelangganTextBox.Text);
                    MessageBox.Show("Data " + prefix + " berhasil dihapus.");
                    refresh_data_grid();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }

            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            try
            {
                //obj.UpdateRow(kodeStockTextBox.Text, namaStockTextBox.Text, satuanComboBox.Text, (float)Convert.ToDouble(jumlahStockTextBox.Text),0, 0, 0, (float)Convert.ToDouble(hbTxt.Text), 0, (float)Convert.ToDouble(hj1Txt.Text), (float)Convert.ToDouble(hj2Txt.Text), (float)Convert.ToDouble(hj3Txt.Text), namaKelompokComboBox.SelectedValue.ToString(), ukuranTextBox.Text, (float)Convert.ToDouble(stockMinimumTextBox.Text), 0, satuanIsiTextBox.Text, kodeBarcodeTextBox.Text, 0, 0, 0, kodeSupplierComboBox.SelectedValue.ToString(), 0/*(float)Convert.ToDouble(hargaRataTextBox.Text)*/, 0/*(float)Convert.ToDouble(hargaAwalTextBox.Text)*/, 0, 0, "", "", 0, kegunaanTextBox.Text);
                MessageBox.Show("Data " + prefix + " berhasil dirubah.");
                refresh_data_grid();
            }
            catch (NullReferenceException er)
            {
                MessageBox.Show("Kode " + prefix + " , Nama " + prefix + " , Supplier , dan Kode Kelompok harus terisi.");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void Modul_Barang_Data_Load(object sender, EventArgs e)
        {
            this.view_stock_saldo_lengkapTableAdapter.Fill(this.stock_Data.View_stock_saldo_lengkap);
            this.view_Saldo_Stock_akhir_unpivotTableAdapter.Fill(this.stock_Data.View_Saldo_Stock_akhir_unpivot);
            this.kelompokProdukTableAdapter.Fill(this.stock_Data.KelompokProduk);
            this.satuanTableAdapter.Fill(this.stock_Data.Satuan);
            this.kelompokProdukTableAdapter.Fill(this.stock_Data.KelompokProduk);
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            blank_field();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                    String v1 = kodeStockTextBox.Text;
                    String v2 = namaStockTextBox.Text;
                    String v3 = kodeSupplierComboBox.SelectedValue.ToString();
                    String v4 = namaKelompokComboBox.SelectedValue.ToString();
                    String v5 = kodeBarcodeTextBox.Text;
                    String spQuery = null;

                    if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (v3.CompareTo("") != 0) && (v4.CompareTo("") != 0)&& (v5.CompareTo("") != 0))
                    {

                            //int stRacikVal = 0;
                            //if (stRacikCheckBox.Checked){stRacikVal = 1;}

                        if (edit) //Kalau Edit
                        {
                            spQuery += "EXEC [dbo].[Stock_update] '" + v1 + "','" + v5 + "','" + v2 + "','" + v4 + "','','" + v3 + "','" + satuanComboBox.Text + "'," + hbTxt.Text + "," + hargaJualTextBox.Text + "," + hj1Txt.Text + "," + qty1TextBox.Text + "," + hj2Txt.Text + "," + qty2TextBox.Text + "," + hj3Txt.Text + "," + qty3TextBox.Text + "," + hj4txt.Text + "," + qty4TextBox.Text + ",0," + disc1TextBox.Text + "," + disc2TextBox.Text + "," + disc3TextBox.Text + "," + discRpTextbox.Text + "," + ppnTextbox.Text + "," + stockMinimumTextBox.Text + ";";
                        }
                        else
                        {

                            DataTable dt = dbo.get_all(new String[] { "KodeStock,NamaStock,satuan" }, "stock", "kodestock = '" + v1 + "'", "", "", 0, 0);

                            if (dt.Rows.Count == 0)
                            {
                                spQuery += "EXEC [dbo].[insert_Stock] '" + v1 + "','" + v5 + "','" + v2 + "','" + v4 + "','','" + v3 + "','" + satuanComboBox.Text + "'," + hbTxt.Text + "," + hargaJualTextBox.Text + "," + hj1Txt.Text + "," + qty1TextBox.Text + "," + hj2Txt.Text + "," + qty2TextBox.Text + "," + hj3Txt.Text + "," + qty3TextBox.Text + "," + hj4txt.Text + "," + qty4TextBox.Text + ",0," + disc1TextBox.Text + "," + disc2TextBox.Text + "," + disc3TextBox.Text + "," + discRpTextbox.Text + "," + ppnTextbox.Text + "," + stockMinimumTextBox.Text + ";";
                                //obj.InsertRow(v1, v2, satuanComboBox.Text, 0, 0, 0, 0, (float)Convert.ToDouble(hbTxt.Text), 0, (float)Convert.ToDouble(hj1Txt.Text), (float)Convert.ToDouble(hj2Txt.Text), (float)Convert.ToDouble(hj3Txt.Text), namaKelompokComboBox.SelectedValue.ToString(), ukuranTextBox.Text, (float)Convert.ToDouble(stockMinimumTextBox.Text), 0, satuanIsiTextBox.Text, kodeBarcodeTextBox.Text, 0, 0, 0, kodeSupplierComboBox.SelectedValue.ToString(), 0/*(float)Convert.ToDouble(hargaRataTextBox.Text)*/, 0/*(float)Convert.ToDouble(hargaAwalTextBox.Text)*/, 0, 0, "", "", 0, kegunaanTextBox.Text);
                            }
                            else
                            {
                                MessageBox.Show("Kode " + prefix + " sudah pernah diinput, silakan pakai kode " + prefix + " yang lain.");
                            }
                        }
                        dbo.run_query(spQuery);
                        edit = true;
                        MessageBox.Show("Data " + prefix + " berhasil ditambahkan.");
                        rebind_all();
  
                    }
                    else
                    {
                        MessageBox.Show("Kode " + prefix + " , Nama " + prefix + " , Supplier , Barcode ,dan Kode Kelompok harus terisi.");
                    }
            }
            catch (NullReferenceException er)
            {
                MessageBox.Show("Kode " + prefix + " , Nama " + prefix + " , Supplier , Barcode ,dan Kode Kelompok harus terisi.");
            }
        }

        private void btn_mutasi_stock_Click(object sender, EventArgs e)
        {
            Modul_Barang_Pemindahan mutasi = new Modul_Barang_Pemindahan();
            mutasi.Show();
            this.Enabled = false;
        }

        private void stockMin_indicator_change()
        {
            Color bckColor = Color.White;
            Color foreColor = Color.Black;
            if (checkBox1.Checked)
            {
                //cariTxt.Text = "";
                //refresh_all();
                //stockDataGridView.Refresh();


                for (int i = 0; i < stockDataGridView.Rows.Count; i++)
                {
                    int jmlStock = Convert.ToInt16(stockDataGridView.Rows[i].Cells[2].Value);
                    int minStock = Convert.ToInt16(stockDataGridView.Rows[i].Cells[15].Value);
                    if (jmlStock > minStock * 2)
                    {
                        bckColor = Color.LightSkyBlue;
                        foreColor = Color.Black;
                    }
                    else if ((jmlStock == minStock) && (jmlStock > 0))
                    {
                        bckColor = Color.Orange;
                        foreColor = Color.Black;
                    }
                    else if (jmlStock == 0)
                    {
                        bckColor = Color.Red;
                        foreColor = Color.White;
                    }
                    stockDataGridView.Rows[i].Cells[2].Style.BackColor = bckColor;
                    stockDataGridView.Rows[i].Cells[2].Style.ForeColor = foreColor;
                }

            }
            else
            {
                for (int i = 0; i < stockDataGridView.Rows.Count; i++)
                {
                    stockDataGridView.Rows[i].Cells[2].Style.BackColor = bckColor;
                    stockDataGridView.Rows[i].Cells[2].Style.ForeColor = foreColor;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            stockMin_indicator_change();   
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void btn_stock_opname_Click(object sender, EventArgs e)
        {
            Modul_Barang_StockOpname stockOpname = new Modul_Barang_StockOpname();
            stockOpname.Show();
        }

        private void stockDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void isiTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Isi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void hargaBeliTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Harga Beli");
         }

        private void hargaJual1TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Harga Jual 1");
        }

        private void hargaJual2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Harga Jual 2");
        }

        private void hargaJual3TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Harga Jual 3");
        }

        private void stockMinimumTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Minimum Stock");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin menghapus record ?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(kodeStockTextBox.Text.CompareTo("")!=0)
                {
                    int a = obj.DeleteRow(kodeStockTextBox.Text);
                    if (a == 0)
                    {
                        MessageBox.Show("Stock "+namaStockTextBox.Text+" berhasil dihapus.");
                        rebind_all();
                    }
                    else
                    {
                        MessageBox.Show("Stock " + namaStockTextBox.Text + " gagal dihapus.");
                    }
                }
            }
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            kodeStockTextBox.Enabled = true;
            tambah_item();
        }

        private void ubahBtn_Click(object sender, EventArgs e)
        {
            if (stockDataGridView.RowCount > 0)
            {
                edit_item(stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }

        }

        private void tambah_item()
        {
            edit = false;
            blank_field();
            refreshNoBukti();
            eraseStockItemDTV();
        }

        private void edit_item(string kodeStock)
        {
            tabControl1.SelectTab(1);
            
            sdr = dbo.get_single_data(null, "KodeStock", kodeStock, "stock");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    kodeStockTextBox.Text = check_dbnull_string(sdr["kodestock"]);
                    kodeBarcodeTextBox.Text = check_dbnull_string(sdr["kodebarcode"]);
                    namaStockTextBox.Text = check_dbnull_string(sdr["namastock"]);
                    namaKelompokComboBox.SelectedValue = check_dbnull_string(sdr["kodekelompok"]);
                    kodeSupplierComboBox.SelectedValue = check_dbnull_string(sdr["kodesupplier"]);
                    satuanComboBox.SelectedValue = check_dbnull_string(sdr["satuan"]);
                    stockMinimumTextBox.Text = check_dbnull_double(sdr["stockminimum"]);
                    hbTxt.Text = check_dbnull_double(sdr["hargabeli"]);
                    hargaJualTextBox.Text = check_dbnull_double(sdr["hargajual"]);
                    hj1Txt.Text = check_dbnull_double(sdr["hargajual1"]);
                    hj2Txt.Text = check_dbnull_double(sdr["hargajual2"]);
                    hj3Txt.Text = check_dbnull_double(sdr["hargajual3"]);
                    hj4txt.Text = check_dbnull_double(sdr["hargajual4"]);
                    qty1TextBox.Text = check_dbnull_double(sdr["qty1"]);
                    qty2TextBox.Text = check_dbnull_double(sdr["qty2"]);
                    qty3TextBox.Text = check_dbnull_double(sdr["qty3"]);
                    qty4TextBox.Text = check_dbnull_double(sdr["qty4"]);
                    disc1TextBox.Text = check_dbnull_double(sdr["disc1"]);
                    disc2TextBox.Text = check_dbnull_double(sdr["disc2"]);
                    disc3TextBox.Text = check_dbnull_double(sdr["disc3"]);
                    discRpTextbox.Text = check_dbnull_double(sdr["discrp"]);
                    ppnTextbox.Text = check_dbnull_double(sdr["ppn"]);

                }
                String[] fields = new String[] { "Deskripsi AS [Deskripsi]", "Nilai AS [Nilai]" };
                dt = dbo.get_all(fields, "View_Saldo_Stock_akhir_unpivot", "kodestock = '" + kodeStock + "'", "", "", 0, 0);
                historyStokDGV.DataSource = dt;
                set_dgv_column_readonly();
                historyStokDGV.Refresh();
                edit = true;
            }
            else
            {
                MessageBox.Show("Data stock tidak tersedia");
                tabControl1.SelectTab(0);
            }
        }

        private string check_dbnull_string(Object obj)
        {
            return (obj is System.DBNull) ? string.Empty : obj.ToString();
        }

        private string check_dbnull_double(Object obj)
        {
            return (obj is System.DBNull) ? string.Empty : ((double)obj).ToString();
        }

        private void refreshNoBukti()
        {
            string varNamaKelompok = "1";
            if (namaKelompokComboBox.SelectedValue != null)
            {
                varNamaKelompok = namaKelompokComboBox.SelectedValue.ToString();
            }
            sdr = obj.generateNoBukti(varNamaKelompok);
            while (sdr.Read())
            {
                kodeStockTextBox.Text = (string)sdr["result"];
            }
        }

        private void eraseStockItemDTV()
        {
            try
            {
                unBindSubDGV();
                historyStokDGV.Columns.Clear();
                historyStokDGV.Rows.Clear();
                historyStokDGV.Refresh();
            }
            catch (ArgumentException ae) { }
        }

        private void set_dgv_column_readonly()
        {
            historyStokDGV.Columns[0].ReadOnly = true;
            historyStokDGV.Columns[1].ReadOnly = true;
        }

        public void set_dgv_column()
        {
            historyStokDGV.Columns.Add("keterangan", "Keterangan");
            historyStokDGV.Columns.Add("nilai", "nilai");
        }

        private void unBindSubDGV()
        {
            historyStokDGV.DataSource = null;
        }

        private void eraseSubDGV()
        {
            try
            {
                unBindSubDGV();
                historyStokDGV.Columns.Clear();
                historyStokDGV.Rows.Clear();
                historyStokDGV.Refresh();
            }
            catch (ArgumentException ae) { }
        }

        private void rebind_all()
        {
            blank_field();
            tabControl1.SelectedIndex = 0;
            refresh_all();
            stockMin_indicator_change();   

        }

        private void changeFilter()
        {
            try
            {

                viewstocksaldolengkapBindingSource.Filter = "KodeStock LIKE '%" + cariTxt.Text + "%' OR NamaStock LIKE '%" + cariTxt.Text + "%'";
                stockDataGridView.DataSource = viewstocksaldolengkapBindingSource;
                stockDataGridView.Refresh();
            }
            catch (NullReferenceException nre)
            {
            }
        }

        private void stockDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                edit_item(stockDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                edit_item(stockDataGridView.Rows[stockDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            rebind_all();
        }

        private void hargaJualTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Harga Jual");
        }

        private void qty1TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Qty 1");
        }

        private void qty2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Qty 2");
        }

        private void qty3TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Qty 3");
        }

        private void hj4txt_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Harga Jual 4");
        }

        private void qty4TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Qty 4");
        }

        private void disc1TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Disc 1");
        }

        private void disc2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Disc 2");
        }

        private void disc3TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Disc 3");
        }

        private void discRpTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Disc 4");
        }

        private void ppnTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "ppn");
        }

        private void namaKelompokComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refreshNoBukti();
        }

    }
}
