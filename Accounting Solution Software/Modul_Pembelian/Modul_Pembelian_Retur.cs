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
    public partial class Modul_Pembelian_Retur : Form
    {
        private MainForm mf = null;
        private JurnalUmum ju = new JurnalUmum();
        private SubJurnalUmum sju = new SubJurnalUmum();
        private Stock stock = new Stock();
        private Kas kas = new Kas();
        private Utang utang = new Utang();
        private RetBeli retBeli = new RetBeli();
        private RetSubBeli retSubBeli = new RetSubBeli();
        private AllFunc allfunc = new AllFunc();

        public Modul_Pembelian_Retur(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
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

        private void refreshDataGrid()
        {
            this.view_ReturBeli_SupplierTableAdapter.Fill(this.retur.view_ReturBeli_Supplier);
            this.view_ReturSubBeli_StockTableAdapter.Fill(this.retur.view_ReturSubBeli_Stock);
            view_ReturBeli_SupplierDataGridView.Refresh();
            view_ReturSubBeli_StockDataGridView.Refresh();
        }

        private void Modul_Pembelian_Retur_Load(object sender, EventArgs e)
        {
            this.view_ReturSubBeli_StockTableAdapter.Fill(this.retur.view_ReturSubBeli_Stock);
            this.view_ReturBeli_SupplierTableAdapter.Fill(this.retur.view_ReturBeli_Supplier);
            this.view_SubBeli_StockTableAdapter.Fill(this.pembelian_Data.view_SubBeli_Stock);
            //this.view_Beli_SupplierTableAdapter.Fill(this.pembelian_Data.view_Beli_Supplier);
            this.view_Beli_SupplierTableAdapter.FillByLast3Months(this.pembelian_Data.view_Beli_Supplier);
        }

        private void Modul_Pembelian_Retur_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf.Enabled = true;
        }

        private void tanggalFilterDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void changeFilter()
        {

            try
            {
                string sql = "";
                string subsql = "";
                this.view_Beli_SupplierTableAdapter.Fill(this.pembelian_Data.view_Beli_Supplier);

                if (checkBox1.Checked)
                {
                    sql = " (" + String.Format("TglTransaksi >= '{0:MM/dd/yyyy}' AND TglTransaksi < '{1:MM/dd/yyyy}'", dateTimePicker1.Value, dateTimePicker1.Value.AddDays(1)) + ")";
                }

                if (checkBox3.Checked)
                {
                    subsql = "StatusPembelian LIKE'%" + statusPembayaranTxt.Text + "%'";
                    if ((checkBox1.Checked))
                    {
                        sql += " AND " + subsql;
                    }
                    else
                    {
                        sql += subsql;
                    }
                }

                if (checkBox2.Checked)
                {
                    subsql = "NomorBukti LIKE '%" + cariTxt.Text + "%' OR NomorFaktur LIKE '%" + cariTxt.Text + "%' OR KodeSupplier LIKE '%" + cariTxt.Text + "%' OR NamaSupplier LIKE '%" + cariTxt.Text + "%'";

                    if ((checkBox1.Checked) || (checkBox3.Checked))
                    {
                        sql += " AND (" + subsql;
                        sql = sql + ")";
                    }
                    else
                    {
                        sql += subsql;
                    }
                }


                if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked))
                {
                    this.view_Beli_SupplierTableAdapter.FillByLast3Months(this.pembelian_Data.view_Beli_Supplier);
                    sql = "";
                }

                view_Beli_SupplierBindingSource.Filter = sql;
                view_pembelian_supplierDataGridView.DataSource = view_Beli_SupplierBindingSource;
                view_pembelian_supplierDataGridView.Refresh();

            }
            catch (NullReferenceException nre)
            {
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                changeFilter();
            }
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                changeFilter();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                changeFilter();
            }
        }

        private void view_pembelian_supplierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void SimpanBtn_Click(object sender, EventArgs e)
        {
            /* SubObj, kas/Utang */
            string kodeSupplier = kodeSupplierTextBox.Text;
            string noSJ = nomorFakturTextBox.Text;
            SqlDataReader sdr = retBeli.InsertRow(DateTime.Today,kodeSupplier,noSJ,0,0,0,0); //RetBeli
            string noBuktiRetur = "";
            while(sdr.Read())
            {
                noBuktiRetur = (string)sdr["result"];
            }
            SqlDataReader sdr1 = ju.InsertRow(DateTime.Today, noBuktiRetur, "Retur Pembelian No.Bukti : " + noBuktiRetur); //JurnalUmum
            string noBuktiJurnalUmum = "";
            while (sdr1.Read())
            {
                noBuktiJurnalUmum = (string)sdr1["result"];
            }
            double subJurnalUmumGrandTotal = 0.0;
            for (int i = 0; i < itemStockDataGridView.RowCount;i++ )
            {
                string kodeStock = itemStockDataGridView.Rows[i].Cells[0].Value.ToString();
                double qtyRetur = 0;
                if (itemStockDataGridView.Rows[i].Cells[4].Value != null)
                {
                     qtyRetur = Convert.ToDouble(itemStockDataGridView.Rows[i].Cells[4].Value.ToString());
                }
                string satuan = itemStockDataGridView.Rows[i].Cells[3].Value.ToString();
                double hargaBeli = Convert.ToDouble(itemStockDataGridView.Rows[i].Cells[5].Value.ToString());
                double discPers = Convert.ToDouble(itemStockDataGridView.Rows[i].Cells[7].Value.ToString());
                double ppnPers = Convert.ToDouble(itemStockDataGridView.Rows[i].Cells[9].Value.ToString());
                double pembulatan = Convert.ToDouble(itemStockDataGridView.Rows[i].Cells[11].Value.ToString());
                //double  = Convert.ToDouble(itemStockDataGridView.Rows[i].Cells[5].Value.ToString());
                if(qtyRetur > 0)
                {
                    double subTotal = qtyRetur * hargaBeli;
                    double disc =  subTotal * discPers/100;
                    double ppn = (subTotal - disc)*ppnPers/100;
                    double grandTotal = subTotal - disc + ppn;
                    retSubBeli.InsertRow(noBuktiRetur,(float)qtyRetur, satuan, kodeStock, (float)hargaBeli, (float)discPers, (float)disc, (float)subTotal, (float)grandTotal);//retsubbeli
                    //stock.UpdateJumlahTerjual(kodeStock, (float)qtyRetur, "-");//stock
                    subJurnalUmumGrandTotal += grandTotal;
                }
            }

            if (subJurnalUmumGrandTotal == 0)
            {
                retBeli.DeleteRow(noBuktiRetur);
                ju.DeleteRow(noBuktiJurnalUmum);
                MessageBox.Show("Pencatatan Retur Gagal.");
            }
            else
            {
                sju.setKreditSystem(noBuktiJurnalUmum, "11311", "Persediaan Barang Dagang", (float)subJurnalUmumGrandTotal);
                //kas atau piutang
                if (statusPembelianComboBox.Text.ToLower().CompareTo("t") == 0)
                {
                    sju.setDebitSystem(noBuktiJurnalUmum, "11111", "Kas Masuk Retur Pembelian : " + noBuktiRetur, (float)subJurnalUmumGrandTotal);
                    kas.InsertRowDebit(DateTime.Today, noBuktiRetur, "Kas Masuk Retur Pembelian : " + noBuktiRetur, (float)subJurnalUmumGrandTotal);
                }
                else
                {
                    DbObject dbo = new DbObject();
                    SqlDataReader sdr2 = dbo.get_single_data(new string[] { "Saldo" }, "Faktur", noSJ, "View_Utang_all");
                    double saldoUtangFaktur = 0;
                    while (sdr2.Read())
                    {
                        saldoUtangFaktur = (double)sdr2["Saldo"];
                    }
                    if (saldoUtangFaktur == 0)
                    {
                        sju.setDebitSystem(noBuktiJurnalUmum, "11111", "Kas Masuk Retur Pembelian : " + noBuktiRetur, (float)subJurnalUmumGrandTotal);
                        kas.InsertRowDebit(DateTime.Today, noBuktiRetur, "Kas Masuk Retur Pembelian : " + noBuktiRetur, (float)subJurnalUmumGrandTotal);
                    }
                    else
                    {
                        sju.setDebitSystem(noBuktiJurnalUmum, "21111", "Utang Usaha", (float)subJurnalUmumGrandTotal);
                        utang.InsertRowDebit(DateTime.Today, noBuktiRetur, kodeSupplier, (float)(subJurnalUmumGrandTotal * -1), 0, DateTime.Today, "Retur Pembelian", tglTransaksiDateTimePicker.Value);
                    }
                }
                MessageBox.Show("Pencatatan Retur Berhasil.");
                print_laporan(noBuktiRetur);
                refreshDataGrid();
                tabControl1.SelectedIndex = 2;
            }
        }

        private void print_laporan(string id)
        {
            if (printChkBox.Checked)
            {
                Modul_Laporan_ReturPembelian laporan = new Modul_Laporan_ReturPembelian(id);
                laporan.Show();
            }
        }

        private void itemStockDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if((e.ColumnIndex==4)&&(e.RowIndex>=0))
            {
                double qtyRetur = Convert.ToDouble(itemStockDataGridView.Rows[itemStockDataGridView.CurrentCell.RowIndex].Cells[itemStockDataGridView.CurrentCell.ColumnIndex].Value.ToString());
                double qty = Convert.ToDouble(itemStockDataGridView.Rows[itemStockDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString());
                
                if(qtyRetur>qty)
                {
                    MessageBox.Show("Quantity Retur tidak boleh lebih besar dari Quantity Stock.");
                    itemStockDataGridView.Rows[itemStockDataGridView.CurrentCell.RowIndex].Cells[itemStockDataGridView.CurrentCell.ColumnIndex].Value = 0;
                }
            }
        }

        private void BatalBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            close();
        }


    }
}
