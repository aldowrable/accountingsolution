using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Accounting_Solution_Software.Classes;
using System.Data.SqlClient;


namespace Accounting_Solution_Software
{
    public partial class Modul_Barang_Pemindahan : Form
    {
        MainForm mf = null;
        Modul_Barang_Data mdb = null;
        private SqlDataReader sdr = null;
        private AllFunc allFunc = null;
        private DbObject dbo = null;
        private bool edit = true;
        private bool succFlag = false;
        protected stockMovement obj = null;
        private string noBuktiMutasi = "";

        public Modul_Barang_Pemindahan()
        {
            InitializeComponent();
            dbo = new DbObject();
            obj = new stockMovement();
        }

        public Modul_Barang_Pemindahan(MainForm mf)
        {
            InitializeComponent();
            dbo = new DbObject();
            obj = new stockMovement();
            this.mf = mf;
        }

        public Modul_Barang_Pemindahan(Modul_Barang_Data mbd)
        {
            InitializeComponent();
            dbo = new DbObject();
            obj = new stockMovement();
            this.mdb = mbd;
        }

        private void blank_field()
        {
            no_buktiTextBox.Text = "";
            erase_mutasiStockdataGridView();
        }

        private void refreshNoBukti()
        {
            sdr = obj.generateNoBukti();
            while (sdr.Read())
            {
                noBuktiMutasi = (string)sdr["result"];
                no_buktiTextBox.Text = (string)sdr["result"];
            }
        }

        private void Modul_Barang_Pemindahan_Load(object sender, EventArgs e)
        {
            this.gudangTableAdapter.Fill(this.stock_Data.Gudang);
            this.view_stockMovement_GudangTableAdapter.Fill(this.stock_Data.view_stockMovement_Gudang);
            this.gudangTableAdapter.Fill(this.stock_Data.Gudang);
        }

        private void view_stockMovement_Gudang_dgv()
        {
            view_stockMovement_GudangTableAdapter.Fill(this.stock_Data.view_stockMovement_Gudang); 
            view_stockMovement_GudangDataGridView.Refresh();
        }
        private void mutasiStockdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void open_Modul_Barang_CariPopup()
        {
            Modul_Barang_CariPopup cariStockForm = new Modul_Barang_CariPopup();
            cariStockForm.setFormBarangPemindahan(this);
            cariStockForm.Show();
        }

        /*private void  mutasiStockdataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    String varKodeStock = mutasiStockdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    
                    DataTable dt = dbo.get_all(new String[] { "KodeStock,NamaStock,satuan" }, "stock", "kodestock = '" + varKodeStock + "'", "", "", 0, 0);
                    if (dt.Rows.Count == 1)
                    {
                        mutasiStockdataGridView.Rows[e.RowIndex].Cells[1].Value = dt.Rows[0]["NamaStock"].ToString();
                        mutasiStockdataGridView.Rows[e.RowIndex].Cells[3].Value = dt.Rows[0]["Satuan"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Stock dengan kode = " + varKodeStock + " tidak ditemukan");
                        mutasiStockdataGridView.Rows[e.RowIndex].Cells[0].Value = "";
                    }
                }
                catch (NullReferenceException null_e)
                {
                    //MessageBox.Show("Isilah KodeStock dengan kode yang terdaftar" + null_e);
                }
            }
        }*/

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            close();
        }

        private void close()
        {

            if (this.mf == null)
            {
                /*mdb.refresh_all();
                mdb.Enabled = true;*/
            }
            else
            {
                    /*if ((mf.splitContainer2.Visible)&&(this.succFlag))
                    {
                        mf.stockBindingSource.DataSource = mf.stock_Data.Stock;
                        mf.view_stock_gudangBindingSource.DataSource = mf.stockBindingSource ;

                        mf.view_stock_gudangDataGridView.DataSource = mf.view_stock_gudangBindingSource;
                        mf.stockDataGridView.DataSource = mf.stockBindingSource;
                        mf.stockDataGridView1.DataSource = mf.stockBindingSource;

                        mf.view_stock_gudangTableAdapter.Fill(mf.stock_Data.view_stock_gudang);
                        mf.stockTableAdapter.Fill(mf.stock_Data.Stock);

                        mf.view_stock_gudangDataGridView.Refresh();
                        mf.stockDataGridView.Refresh();
                        mf.stockDataGridView1.Refresh();
                    }*/
                mf.Enabled = true;
            } 
            this.Close();
            this.Dispose();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            List<String> arrErr = new List<String>();
            List<String> arrSucc = new List<String>();
            string err = "";
            string succ = "";
            int totalRows = 0;
            String varKodeStock = "";
            String varIdGudangAsal = "";
            String varIdGudangTujuan = "";
            int varQty = 0;

            if (id_gudang_asalComboBox.Text != id_gudang_tujuanComboBox.Text)
            {
                    // No. Bukti Auto
                    totalRows = mutasiStockdataGridView.Rows.Count;
                    if (totalRows > 1)
                    {
                        for (int i = 0; i < totalRows - 1; i++)
                        {
                            try //cek apakah Qty berupa angka atau bukan
                            {
                                if (mutasiStockdataGridView.Rows[i].Cells[1].Value != DBNull.Value)
                                {
                                    varKodeStock = mutasiStockdataGridView.Rows[i].Cells[1].Value.ToString();
                                    //varIdGudangAsal = id_gudang_asalComboBox.SelectedValue.ToString();
                                    //varIdGudangTujuan = id_gudang_tujuanComboBox.SelectedValue.ToString();
                                    varQty = Convert.ToInt16(mutasiStockdataGridView.Rows[i].Cells[3].Value);

                                    if (varQty < 0)
                                    //{   
                                        /*DataTable dt = dbo.get_all(new String[] { "jumlah" }, "stockgudang", "kodestock = '" + varKodeStock + "' AND id_gudang ='" + varIdGudangAsal + "'", "", "", 0, 0);
                                        if (varQty > Convert.ToInt16(dt.Rows[0]["jumlah"]))
                                        {
                                            arrErr.Add("Qty mutasi untuk kode stock " + varKodeStock + " maksimal berjumlah " + dt.Rows[0]["jumlah"].ToString() + ".");
                                        }*/
                                    //}
                                    //else
                                    {
                                        arrErr.Add("Kolom Qty untuk kode stock " + varKodeStock + " harus diisi dengan nominal lebih besar dari 0.");
                                    }
                                }
                            }
                            catch (FormatException format_e)
                            {
                                arrErr.Add("Kolom Qty untuk kode stock " + varKodeStock + " harus diisi dengan jumlah nominal stock.");
                            }
                            catch (IndexOutOfRangeException indexoutofrange_e)
                            {
                                arrErr.Add("Stock dengan kode " + varKodeStock + " tidak tersedia di Gudang Asal.");
                            }
                            catch (NullReferenceException nullreference_e)
                            {
                            }
                        }
                    }
                    else
                    {
                        arrErr.Add ("Silakan mengisi tabel dengan stock yang akan di mutasi.");
                    }
            }
            else
            {
                arrErr.Add ("Silakan mengisi gudang asal dengan gudang tujuan yang berbeda");
            }

            if (arrErr.Count > 0) //Error
            {
                foreach (String subErr in arrErr)
                {
                    if (subErr.CompareTo("") != 0)
                    {
                        err += subErr + " \n";
                    }
                }

                MessageBox.Show(err);
            }
            else //Success
            {
                string varNoBukti = no_buktiTextBox.Text;
                DateTime varTanggal = dateTimePicker1.Value;
                varIdGudangAsal = id_gudang_asalComboBox.SelectedValue.ToString();
                varIdGudangTujuan = id_gudang_tujuanComboBox.SelectedValue.ToString();
                string spQuery = null;


                if (edit) //Kalau Edit
                {
                    spQuery = "EXEC [dbo].[stockMovement_Update] '" + varNoBukti + "','" + varTanggal.ToString() + "','" + varIdGudangAsal + "','" + varIdGudangTujuan + "';";
                    spQuery += "exec [dbo].[SubStockMovement_DeleteRow_by_IdSM] '" + varNoBukti + "';";
                }
                else
                {
                    spQuery = "EXEC [dbo].[stockMovement_Insert] '" + varNoBukti + "','" + varTanggal.ToString() + "','" + varIdGudangAsal + "','" + varIdGudangTujuan + "';";
                }

                for (int i = 0; i < totalRows - 1; i++)
                {
                    varKodeStock = mutasiStockdataGridView.Rows[i].Cells[1].Value.ToString();
                    varQty = Convert.ToInt16(mutasiStockdataGridView.Rows[i].Cells[3].Value);
                    String varSatuan = mutasiStockdataGridView.Rows[i].Cells[4].Value.ToString();
                    
                    spQuery += "EXEC [dbo].[subStockMovement_Insert] '"+ varNoBukti +"','"+varKodeStock+"',"+ varQty +",'"+ varSatuan +"';";
                    
                    arrErr.Clear();
                    this.succFlag = true;
                    arrSucc.Add("Data Stock " + varKodeStock + " Berhasil di mutasi.");
                }

                dbo.run_query(spQuery);
                edit = true;

                foreach (String subSucc in arrSucc)
                {
                    if (subSucc.CompareTo("") != 0)
                    {
                        succ += subSucc + " \n";
                    }
                }
                MessageBox.Show(succ);
                print_laporan(varNoBukti);
                rebind_all();
                //close();
            }
        }

        private void print_laporan(string id)
        {
            if(printChkBox.Checked)
            {
                Modul_Laporan_Transfer_Stock_2 laporan = new Modul_Laporan_Transfer_Stock_2(id);
                laporan.Show();
            }
        }

        private void rebind_all()
        {
            blank_field();
            tabControl1.SelectedIndex = 0;
            view_stockMovement_Gudang_dgv();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (mutasiStockdataGridView.Rows.Count > 0)
                {
                    mutasiStockdataGridView.Rows.RemoveAt(mutasiStockdataGridView.CurrentRow.Index);
                    mutasiStockdataGridView.Refresh();
                }
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show("Tidak dapat menghapus baris kosong.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            open_Modul_Barang_CariPopup();
        }

        private void changeFilter()
        {
            try
            {
                string sql = "";
                string subsql = "";
                this.view_stockMovement_GudangTableAdapter.Fill(this.stock_Data.view_stockMovement_Gudang);

                if (checkBox1.Checked)
                {
                    sql = "tanggal ='" + dateTimePicker2.Text + "' ";
                }

                if (checkBox2.Checked)
                {
                    subsql = "noBukti LIKE '%" + cariTxt.Text + "%'";
                    //if ((checkBox1.Checked) || (checkBox3.Checked) || (blmTerbayarChk.Checked))
                    if (checkBox1.Checked)
                    {
                        sql += " AND (" + subsql;
                        sql = sql + ")";
                    }
                    else
                    {
                        sql += subsql;
                    }
                }

                if (checkBox3.Checked)
                {
                    subsql = "idGudangAsal LIKE'%" + statusPembayaranTxt.SelectedValue.ToString() + "%'";
                    //if ((checkBox1.Checked) || (checkBox2.Checked) || (blmTerbayarChk.Checked))
                    if ((checkBox1.Checked) || (checkBox2.Checked))
                    {
                        sql += " AND " + subsql;
                    }
                    else
                    {
                        sql += subsql;
                    }
                }

                if (checkBox4.Checked)
                {
                    subsql = "idGudangTujuan LIKE'%" + comboBox1.SelectedValue.ToString() + "%'";
                    if ((checkBox1.Checked) || (checkBox2.Checked) || (checkBox3.Checked))
                    {
                        sql += " AND " + subsql;
                    }
                    else
                    {
                        sql += subsql;
                    }
                }

                if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked))
                {
                    this.view_stockMovement_GudangTableAdapter.Fill(this.stock_Data.view_stockMovement_Gudang);
                    //this.view_Utang_allTableAdapter.FillByLast3Months(this.view.view_Utang_all);
                    sql = "";
                }
                
                viewstockMovementGudangBindingSource.Filter = sql;
                view_stockMovement_GudangDataGridView.DataSource = viewstockMovementGudangBindingSource;
                view_stockMovement_GudangDataGridView.Refresh();
            }
            catch (NullReferenceException nre)
            {
            }
        }

        private void BaruBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tambah_data();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (view_stockMovement_GudangDataGridView.RowCount > 0)
            {
                edit_item(view_stockMovement_GudangDataGridView.Rows[view_stockMovement_GudangDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            else
            {
                tambah_data();
            }
        }

        private void tambah_data()
        {
            edit = false;
            blank_field();
            refreshNoBukti();
            erase_mutasiStockdataGridView();
            id_gudang_asalComboBox.Text = "";
            id_gudang_tujuanComboBox.Text = "";
        }

        private void edit_item(String noBukti)
        {
            tabControl1.SelectTab(1);
            erase_mutasiStockdataGridView();
            sdr = dbo.get_single_data(new String[] { "noBukti", "Tanggal", "idGudangAsal", "idGudangTujuan" }, "noBukti", noBukti, "view_stockMovement_Gudang");
            while (sdr.Read())
            {
                no_buktiTextBox.Text = (string)sdr["noBukti"];
                dateTimePicker1.Value = (DateTime)sdr["tanggal"];
                id_gudang_asalComboBox.SelectedValue = (string)sdr["idGudangAsal"];
                id_gudang_tujuanComboBox.SelectedValue = (string)sdr["idGudangTujuan"];
            }

            String[] fields = new String[] { "KodeBarcode","KodeStock","NamaStock","qty","satuan" };
            DataTable dt = dbo.get_all(fields, "View_StockMovement_Sub_Stock", "noBukti = '" + noBukti + "'", "", "", 0, 0);
            
            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {
                mutasiStockdataGridView.Rows.Add(row.ItemArray);
            }
            mutasiStockdataGridView.Refresh();

            edit = true;
        }

        private void erase_mutasiStockdataGridView()
        {
            try
            {
                mutasiStockdataGridView.DataSource = null;
                mutasiStockdataGridView.Rows.Clear();
                mutasiStockdataGridView.Refresh();
            }
            catch (ArgumentException ae) { }
        }

        private void bind_mutasiStockBind()
        {
        }

        private void unbind_mutasiStockBind()
        {
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (view_stockMovement_GudangDataGridView.Rows.Count > 0)
                {
                    edit_item(view_stockMovement_GudangDataGridView.Rows[view_stockMovement_GudangDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    tambah_data();
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void statusPembayaranTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void btn_keluar_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void mutasiStockdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if((e.RowIndex>=0)&&(e.ColumnIndex==0))
            {
                get_produk_by_barcode(mutasiStockdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),e.RowIndex);
            }
        }

        private void get_produk_by_barcode(string barcode,int rowIndex)
        {
            sdr = dbo.get_single_data(new String[] {"KodeStock","NamaStock","Satuan" }, "kodebarcode", barcode, "stock");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    mutasiStockdataGridView.Rows[rowIndex].Cells[1].Value = (string)sdr[0];
                    mutasiStockdataGridView.Rows[rowIndex].Cells[2].Value = (string)sdr[1];
                    mutasiStockdataGridView.Rows[rowIndex].Cells[3].Value = "0";
                    mutasiStockdataGridView.Rows[rowIndex].Cells[4].Value = (string)sdr[2];
                }
            }
            else
            {
                MessageBox.Show("Produk dengan barcode "+ barcode +" tidak ditemukan.");
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            blank_field();
        }

        private void view_stockMovement_GudangDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                edit_item(view_stockMovement_GudangDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }


    }
}
