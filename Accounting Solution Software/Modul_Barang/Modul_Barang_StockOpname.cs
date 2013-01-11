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
    public partial class Modul_Barang_StockOpname : Form
    {
        private MainForm mf = null;
        private StockOpname stockOpname = null;
        private AllFunc allfunc = new AllFunc();
        private SqlDataReader sdr = null;
        private DbObject dbo = new DbObject();
        private bool edit = true;

        public Modul_Barang_StockOpname()
        {
            InitializeComponent();
            stockOpname = new StockOpname();
        }

        public Modul_Barang_StockOpname(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            stockOpname = new StockOpname();
        }


        private void Modul_Barang_StockOpname_Load(object sender, EventArgs e)
        {
            this.view_stock_opnameTableAdapter.Fill(this.view.view_stock_opname);
        }

        private void refresh_sub_data_grid()
        {
            this.view_stock_opnameTableAdapter.Fill(this.view.view_stock_opname);
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
        }

        public void reset()
        {
            //kodeStockTextBox.Text = "";
            //namaStockTextBox.Text = "";
            //jumlahStockTextBox.Text = "";
            //soTxt.Text = "";
        }


        //public void process(DataGridViewRow dgvr)
        //{
        //    stockOpname.InsertRow("xx", DateTime.Today, dgvr.Cells[0].Value.ToString(), (float)jmlStockLama, (float)jmlStockBaru, (float)jmlStockBaru - (float)jmlStockLama, (float)Convert.ToDouble(dgvr.Cells[4].Value.ToString()), 0, 0, "");
        //    //stockOpname.InsertRow("xx", DateTime.Today, kodeStockTextBox.Text, (float)Convert.ToDouble(jumlahStockTextBox.Text), (float)Convert.ToDouble(soTxt.Text), (float)Convert.ToDouble(soTxt.Text) - (float)Convert.ToDouble(jumlahStockTextBox.Text), (float)Convert.ToDouble(hargaBeliTextBox.Text),0, 0, "");
        //    //reset();
        //    try
        //    {
        //        this.stockTableAdapter.orderByName(this.stock_Data.Stock);
        //        stockBindingSource.DataSource = this.stock_Data.Stock;
        //        stockDataGridView.DataSource = stockBindingSource;
        //        stockDataGridView.Refresh();

        //        this.stockOpnameTableAdapter.Fill(this.stock_Data.StockOpname);
        //        stockOpnameDataGridView.Refresh();

        //        stockOpnameDataGridView.ClearSelection();

        //        int nRowIndex = stockOpnameDataGridView.Rows.Count - 2;
        //        int nColumnIndex = 0;

        //        stockOpnameDataGridView.Rows[nRowIndex].Selected = true;
        //        stockOpnameDataGridView.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

        //        stockOpnameDataGridView.FirstDisplayedScrollingRowIndex = nRowIndex;
        //    }
        //    catch (System.Reflection.TargetInvocationException ti_e)
        //    {
        //    }
        //    catch (ArgumentOutOfRangeException aour_e)
        //    {
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            //if ((soTxt.Text.CompareTo("") != 0) && (soTxt.Text.CompareTo("0") != 0))
            {
                //process();

                stockOpnameDataGridView.ClearSelection();

                int nRowIndex = stockOpnameDataGridView.Rows.Count - 2;
                int nColumnIndex = 0;

                stockOpnameDataGridView.Rows[nRowIndex].Selected = true;
                stockOpnameDataGridView.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                stockOpnameDataGridView.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
        }

        private void jumlahStockTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Jumlah Stock Lama");
        }

        private void soTxt_KeyDown(object sender, KeyEventArgs e)
        {
           // allfunc.digit_filter(sender, e, "Jumlah Stock Baru");
            //if (e.KeyData == Keys.Enter)
            {
            //    process();
            }
        }

        private void close()
        {
            if (mf != null)
            {
                mf.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            close();
        }


        private void stockDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if ((e.ColumnIndex == 3) && (e.RowIndex >= 0))
                //{
                //    jmlStockLama = Convert.ToDouble(stockDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                //}
            }
            catch (FormatException fe_e)
            {
                MessageBox.Show("Isian harus berupa digit.");
            }
        }

        private void stockDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 3) && (e.RowIndex >= 0))
            {
                //jmlStockBaru = Convert.ToDouble(stockDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                //if (jmlStockLama != jmlStockBaru)
                //{
                //    process(stockDataGridView.Rows[e.RowIndex]);
                //}
            }
        }

        private void BaruBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tambah_data();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            close();
        }

        private void tambah_data()
        {
            edit = false;
            blank_field();
            refreshNoBukti();
            erase_stockopnameDataGrid();
        }

        private void erase_stockopnameDataGrid()
        {
            try
            {
                stockOpnameDataGridView.DataSource = null;
                stockOpnameDataGridView.Rows.Clear();
                stockOpnameDataGridView.Refresh();
            }
            catch (ArgumentException ae) { }
        }

        private void refreshNoBukti()
        {
            sdr = stockOpname.generateNoBukti();
            while (sdr.Read())
            {
                noBuktiTextBox.Text = (string)sdr["result"];
            }
        }

        private void open_Modul_Barang_CariPopup()
        {
            Modul_Barang_CariPopup cariStockForm = new Modul_Barang_CariPopup(this);
            cariStockForm.Show();
        }

        private void rebind_all()
        {
            blank_field();
            tabControl1.SelectedIndex = 0;
            refresh_sub_data_grid();
        }

        private void resetDataGrid()
        {

        }
        private void blank_field()
        {
            noBuktiTextBox.Text = "";
            erase_stockopnameDataGrid();
        }

        public void setItemDataGrid(String[] items)
        {
            stockOpnameDataGridView.Rows.Add(items);
        }

        private void edit_item(String noBukti)
        {
            tabControl1.SelectTab(1);
            erase_stockopnameDataGrid();
            sdr = dbo.get_single_data(new String[] { "noBukti", "Tanggal", "NamaPIC" }, "NoBukti", noBukti, "view_stock_opname");
            while (sdr.Read())
            {
                noBuktiTextBox.Text = (string)sdr["noBukti"];
                tanggalDtp.Value = (DateTime)sdr["tanggal"];
            }

            String[] fields = new String[] { "KodeBarcode", "KodeStock", "NamaStock", "StockAwal" , "StockOpname", "Satuan" };
            DataTable dt = dbo.get_all(fields, "View_stock_opname_sub", "noBukti = '" + noBukti + "'", "", "", 0, 0);

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {
                stockOpnameDataGridView.Rows.Add(row.ItemArray);
            }
            stockOpnameDataGridView.Refresh();
            edit = true;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (view_stockOpnameDataGridView.RowCount > 0)
            {
                    edit_item(view_stockOpnameDataGridView.Rows[view_stockOpnameDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            else
            {
                tambah_data();
            }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (stockOpnameDataGridView.Rows.Count > 0)
                {
                    stockOpnameDataGridView.Rows.RemoveAt(stockOpnameDataGridView.CurrentRow.Index);
                    stockOpnameDataGridView.Refresh();
                }
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show("Tidak dapat menghapus baris kosong.");
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            open_Modul_Barang_CariPopup();
        }

        private void changeFilter()
        {
            try
            {
                string sql = "";
                string subsql = "";
                this.view_stock_opnameTableAdapter.Fill(this.view.view_stock_opname);

                if (checkBox1.Checked)
                {
                    sql = "tanggal ='" + dateTimePicker1.Text + "' ";
                }

                if (checkBox2.Checked)
                {
                    subsql = "NoBukti LIKE '%" + cariTxt.Text + "%' OR PIC LIKE '%" + cariTxt.Text + "%' OR NamaPIC LIKE '%" + cariTxt.Text + "%'";
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

                if ((!checkBox1.Checked) && (!checkBox2.Checked))
                {
                    this.view_stock_opnameTableAdapter.Fill(this.view.view_stock_opname);
                    //this.view_Utang_allTableAdapter.FillByLast3Months(this.view.view_Utang_all);
                    sql = "";
                }

                view_stock_opnameBindingSource.Filter = sql;
                view_stockOpnameDataGridView.DataSource = view_stock_opnameBindingSource;
                view_stockOpnameDataGridView.Refresh();
            }
            catch (NullReferenceException nre)
            {
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            blank_field();
        }

        private void view_stockOpnameDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                edit_item(view_stockOpnameDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (view_stockOpnameDataGridView.Rows.Count > 0)
                {
                    edit_item(view_stockOpnameDataGridView.Rows[view_stockOpnameDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    tambah_data();
                }
            }

        }

        private void get_produk_by_barcode(string barcode, int rowIndex)
        {
            sdr = dbo.get_single_data(new String[] { "KodeStock", "NamaStock", "Satuan","JumlahStock" }, "kodebarcode", barcode, "View_stock_saldo_lengkap");
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    stockOpnameDataGridView.Rows[rowIndex].Cells[1].Value = (string)sdr[0];
                    stockOpnameDataGridView.Rows[rowIndex].Cells[2].Value = (string)sdr[1];
                    stockOpnameDataGridView.Rows[rowIndex].Cells[3].Value = ((double)sdr[3]).ToString();
                    stockOpnameDataGridView.Rows[rowIndex].Cells[4].Value = "0";
                    stockOpnameDataGridView.Rows[rowIndex].Cells[5].Value = (string)sdr[2];
                }
            }
            else
            {
                MessageBox.Show("Produk dengan barcode " + barcode + " tidak ditemukan.");
            }
        }



        private void simpanBtn_Click(object sender, EventArgs e)
        {
            List<String> arrErr = new List<String>();
            List<String> arrSucc = new List<String>();
            string err = "";
            string succ = "";
            int totalRows = 0;
            String varKodeStock = "";
            String varIdGudangAsal = "";
            String varIdGudangTujuan = "";
            Double varQtyAsal = 0.0;
            Double varQtyOpname = 0.0;

                // No. Bukti Auto
            totalRows = stockOpnameDataGridView.Rows.Count;
                if (totalRows > 1)
                {
                    for (int i = 0; i < totalRows - 1; i++)
                    {
                        try //cek apakah Qty berupa angka atau bukan
                        {
                            if (stockOpnameDataGridView.Rows[i].Cells[1].Value != DBNull.Value)
                            {
                                varKodeStock = stockOpnameDataGridView.Rows[i].Cells[1].Value.ToString();
                                varQtyOpname = Convert.ToInt16(stockOpnameDataGridView.Rows[i].Cells[4].Value);

                                if (varQtyOpname < 0)
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
                    arrErr.Add("Silakan mengisi tabel dengan stock yang akan di mutasi.");
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
                string varNoBukti = noBuktiTextBox.Text;
                DateTime varTanggal = dateTimePicker1.Value;
                string spQuery = null;

                if (edit) //Kalau Edit
                {
                    //spQuery = "EXEC [dbo].[stockOpname_Update] '" + varNoBukti + "','" + varTanggal.ToString() + "','" + varIdGudangAsal + "','" + varIdGudangTujuan + "';";
                    spQuery += "exec [dbo].[SubStockOpname_DeleteRow_by_IdSO] '" + varNoBukti + "';";
                }
                else
                {
                    spQuery = "EXEC [dbo].[stockOpname_Insert] '" + varNoBukti + "','" + varTanggal.ToString() + "','" + mf.login.username.ToString()+ "';";
                }

                for (int i = 0; i < totalRows - 1; i++)
                {
                    varKodeStock = stockOpnameDataGridView.Rows[i].Cells[1].Value.ToString();
                    varQtyAsal = Double.Parse(stockOpnameDataGridView.Rows[i].Cells[3].Value.ToString());
                    varQtyOpname = Double.Parse(stockOpnameDataGridView.Rows[i].Cells[4].Value.ToString());
                    String varSatuan = stockOpnameDataGridView.Rows[i].Cells[4].Value.ToString();

                    spQuery += "EXEC [dbo].[subStockOpname_Insert] '" + varNoBukti + "','" + varKodeStock + "'," + varQtyAsal + "," + varQtyOpname + ",0 ;";

                    arrErr.Clear();
                    //this.succFlag = true;
                    arrSucc.Add("Data Stock " + varKodeStock + " Berhasil di Opname.");
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
            if (printChkBox.Checked)
            {
                Modul_Laporan_StockOpname laporan = new Modul_Laporan_StockOpname(id);
                laporan.Show();
            }
        }

        private void stockOpnameDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.ColumnIndex == 0))
            {
                get_produk_by_barcode(stockOpnameDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), e.RowIndex);
            }

        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

    }
}
