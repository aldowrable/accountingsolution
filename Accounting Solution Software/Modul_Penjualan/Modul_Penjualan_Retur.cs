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
    public partial class Modul_Penjualan_Retur : Form
    {
        private MainForm mf = null;
        private JurnalUmum ju = new JurnalUmum();
        private SubJurnalUmum sju = new SubJurnalUmum();
        private Stock stock = new Stock();
        private Kas kas = new Kas();
        private Piutang piutang = new Piutang();
        private RetJual retJual = new RetJual();
        private RetSubJual retSubJual = new RetSubJual();
        private AllFunc allfunc = new AllFunc();

        public Modul_Penjualan_Retur(MainForm mf)
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
            this.view_ReturJual_NoBonTableAdapter.Fill(this.retur.view_ReturJual_NoBon);
            this.view_ReturSubJual_StockTableAdapter.Fill(this.retur.view_ReturSubJual_Stock);
            view_ReturBeli_SupplierDataGridView.Refresh();
            view_ReturSubBeli_StockDataGridView.Refresh();
        }

        private void Modul_Penjualan_Retur_Load(object sender, EventArgs e)
        {
            this.view_ReturSubJual_StockTableAdapter.Fill(this.retur.view_ReturSubJual_Stock);
            this.view_ReturJual_NoBonTableAdapter.Fill(this.retur.view_ReturJual_NoBon);
            //this.view_racikan_stock_dokterTableAdapter.Fill(this.penjualan_Data.view_racikan_stock_dokter);
            //this.view_subJual_stockTableAdapter.Fill(this.penjualan_Data.view_subJual_stock);
            //this.view_jual_nobonTableAdapter.FillByLast3Months(this.penjualan_Data.view_jual_nobon);

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

        private void view_jual_nobonDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex > 0)
            {
                tabControl1.SelectedIndex = 1;
            }
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

        private void changeFilter()
        {
            //this.view_jual_nobonTableAdapter.Fill(this.penjualan_Data.view_jual_nobon);

            if ((checkBox1.Checked) && (checkBox2.Checked) && (checkBox3.Checked))
            {
                view_jual_nobonBindingSource.Filter =
                    "Tanggal ='" + dateTimePicker1.Text + "' AND Pembayaran LIKE'%" + statusPembayaranTxt.Text + "%' AND (NoBon LIKE '%" + cariTxt.Text + "%' OR Kasir LIKE '%" + cariTxt.Text + "%' OR KodePelanggan LIKE '%" + cariTxt.Text + "%' OR NamaPelanggan LIKE '%" + cariTxt.Text + "%')";
            }
            else if ((checkBox2.Checked) && (checkBox3.Checked))
            {
                view_jual_nobonBindingSource.Filter =
                    "Pembayaran LIKE'%" + statusPembayaranTxt.Text + "%' AND (NoBon LIKE '%" + cariTxt.Text + "%' OR Kasir LIKE '%" + cariTxt.Text + "%' OR KodePelanggan LIKE '%" + cariTxt.Text + "%' OR NamaPelanggan LIKE '%" + cariTxt.Text + "%')";
            }
            else if ((checkBox1.Checked) && (checkBox3.Checked))
            {
                view_jual_nobonBindingSource.Filter =
                    "Tanggal ='" + dateTimePicker1.Text + "' AND Pembayaran LIKE'%" + statusPembayaranTxt.Text + "%'";

            }
            else if ((checkBox1.Checked) && (checkBox2.Checked))
            {
                view_jual_nobonBindingSource.Filter =
                    "Tanggal ='" + dateTimePicker1.Text + "' AND (NoBon LIKE '%" + cariTxt.Text + "%' OR Kasir LIKE '%" + cariTxt.Text + "%' OR KodePelanggan LIKE '%" + cariTxt.Text + "%' OR NamaPelanggan LIKE '%" + cariTxt.Text + "%')";
            }
            else if (checkBox3.Checked)
            {
                view_jual_nobonBindingSource.Filter = "Pembayaran LIKE'%" + statusPembayaranTxt.Text + "%'";
            }
            else if (checkBox2.Checked)
            {
                view_jual_nobonBindingSource.Filter = "NoBon LIKE '%" + cariTxt.Text + "%' OR Kasir LIKE '%" + cariTxt.Text + "%' OR KodePelanggan LIKE '%" + cariTxt.Text + "%' OR NamaPelanggan LIKE '%" + cariTxt.Text + "%'";
            }
            else if (checkBox1.Checked)
            {
                view_jual_nobonBindingSource.Filter = "Tanggal ='" + dateTimePicker1.Text + "' ";
            }

            if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked))
            {
                //this.view_jual_nobonTableAdapter.FillByLast3Months(this.penjualan_Data.view_jual_nobon);
                view_jual_nobonBindingSource.Filter = "";
            }

            view_jual_nobonDataGridView.DataSource = view_jual_nobonBindingSource;
            view_jual_nobonDataGridView.Refresh();

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

        private void SimpanBtn_Click(object sender, EventArgs e)
        {
            /* SubObj, kas/Utang */

            string kodePelanggan = kodePelangganTextBox.Text;
            string noBon = noBonTextBox.Text;

            SqlDataReader sdr = retJual.InsertRow(DateTime.Today, "", noBon, "",0, 0, 0, 0,"");//RetJual
            string noBuktiRetur = "";
            while (sdr.Read())
            {
                noBuktiRetur = (string)sdr["result"];
            }
            SqlDataReader sdr1 = ju.InsertRow(DateTime.Today, noBuktiRetur, "Retur Penjualan No.Bukti : " + noBuktiRetur); //JurnalUmum
            string noBuktiJurnalUmum = "";
            while (sdr1.Read())
            {
                noBuktiJurnalUmum = (string)sdr1["result"];
            }
            double subJurnalUmumGrandTotal = 0.0;
            DataGridView dgv = null;
            if (view_subJual_stockDataGridView.RowCount > 0)
            {
                dgv = view_subJual_stockDataGridView;
            }
            else if(view_racikan_stock_dokterDataGridView.RowCount >0)
            {
                dgv = view_racikan_stock_dokterDataGridView;
            }

            for (int i = 0; i < dgv.RowCount; i++)
            {
                string kodeStock = dgv.Rows[i].Cells[0].Value.ToString();
                double qtyRetur = 0;
                if (dgv.Rows[i].Cells[4].Value != null)
                {
                    qtyRetur = Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString());
                }
                string satuan = dgv.Rows[i].Cells[3].Value.ToString();
                double hargaBeli = Convert.ToDouble(dgv.Rows[i].Cells[5].Value.ToString());
                double discPers = Convert.ToDouble(dgv.Rows[i].Cells[6].Value.ToString());

                if (qtyRetur > 0)
                {
                    double subTotal = qtyRetur * hargaBeli;
                    double disc = subTotal * discPers / 100;
                    double ppn = 0;
                    //double ppn = (subTotal - disc) * ppnPers / 100;
                    double grandTotal = subTotal - disc + ppn;
                    retSubJual.InsertRow(noBuktiRetur, (float)qtyRetur, kodeStock, (float)hargaBeli, (float)discPers, (float)disc, (float)subTotal, (float)grandTotal);
                    stock.TambahJumlah(kodeStock, (float)qtyRetur);//stock
                    subJurnalUmumGrandTotal += grandTotal;
                }
            }

            if (subJurnalUmumGrandTotal == 0)
            {
                retJual.DeleteRow(noBuktiRetur);
                ju.DeleteRow(noBuktiJurnalUmum);
                MessageBox.Show("Pencatatan Retur Gagal.");
            }
            else
            {

                sju.setDebitSystem(noBuktiJurnalUmum, "11311", "Persediaan Barang Dagang", (float)subJurnalUmumGrandTotal);
                //kas atau piutang
                if (pembayaranComboBox.Text.ToLower().CompareTo("t") == 0)
                {
                    sju.setKreditSystem(noBuktiJurnalUmum, "11111", "Kas Keluar Retur Penjualan : " + noBuktiRetur, (float)subJurnalUmumGrandTotal);
                    kas.InsertRowKredit(DateTime.Today, noBuktiRetur, "Kas Keluar Retur Penjualan : " + noBuktiRetur, (float)subJurnalUmumGrandTotal);
                }
                else
                {
                    DbObject dbo = new DbObject();
                    SqlDataReader sdr2 = dbo.get_single_data(new string[] { "Saldo" }, "FAKTUR", noBon, "view_piutang_faktur");
                    double saldoPiutangFaktur = 0;
                    while (sdr2.Read())
                    {
                        saldoPiutangFaktur = (double)sdr2["Saldo"];
                    }
                    if (saldoPiutangFaktur == 0)
                    {
                        sju.setKreditSystem(noBuktiJurnalUmum, "11111", "Kas Keluar Retur Penjualan : " + noBuktiRetur, (float)subJurnalUmumGrandTotal);
                        kas.InsertRowKredit(DateTime.Today, noBuktiRetur, "Kas Keluar Retur Penjualan : " + noBuktiRetur, (float)subJurnalUmumGrandTotal);
                    }
                    else
                    {
                        sju.setKreditSystem(noBuktiJurnalUmum, "11211", "Piutang Usaha", (float)subJurnalUmumGrandTotal);
                        piutang.InsertRowKredit(DateTime.Today, noBon, kodePelanggan, "TOKO", "TOKO", 0, (float)(subJurnalUmumGrandTotal * -1), DateTime.Today, "", 0);
                    }
                }
                MessageBox.Show("Pencatatan Retur Berhasil.");
                refreshDataGrid();
                tabControl1.SelectedIndex = 2;
            }

        }

        private void view_subJual_stockDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 4) && (e.RowIndex >= 0))
            {
                cekValueDataGrid(view_subJual_stockDataGridView);
            }

        }

        private void view_racikan_stock_dokterDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 4) && (e.RowIndex >= 0))
            {
                cekValueDataGrid(view_racikan_stock_dokterDataGridView);
            }
        }

        private void cekValueDataGrid(DataGridView dgv)
        {

                double qtyRetur = Convert.ToDouble(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[dgv.CurrentCell.ColumnIndex].Value.ToString());
                double qty = Convert.ToDouble(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[2].Value.ToString());

                if (qtyRetur > qty)
                {
                    MessageBox.Show("Quantity Retur tidak boleh lebih besar dari Quantity Stock.");
                    dgv.Rows[dgv.CurrentCell.RowIndex].Cells[dgv.CurrentCell.ColumnIndex].Value = 0;
                }
            
        }

        private void BatalBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

    }
}
