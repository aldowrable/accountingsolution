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
    public partial class Modul_Pembelian_DaftarHutang : Form
    {
        private MainForm mf = null;
        private DataGridViewRow dgvRow = null;
        private AllFunc allfunc = new AllFunc();
        private DbObject dbo = new DbObject();
        private Utang utang = new Utang();
        private JurnalUmum obj = new JurnalUmum();
        private SubJurnalUmum subObj = new SubJurnalUmum();
        private Kas kas = new Kas();
        private SqlDataReader sdr = null;

        public Modul_Pembelian_DaftarHutang()
        {
            InitializeComponent();
        }
        public Modul_Pembelian_DaftarHutang(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void Modul_Pembelian_DaftarHutang_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);
            //this.view_Utang_allTableAdapter.Fill(this.view.view_Utang_all);
            this.view_Utang_allTableAdapter.FillByLast3Months(this.view.view_Utang_all);
            this.view_Utang_KreditTableAdapter.Fill(this.view.view_Utang_Kredit);
            this.view_Utang_SaldoTableAdapter.Fill(this.view.view_Utang_Saldo);
        }

        public void refreshDataGridView()
        {
            cariTxt.Text = "";
            blmTerbayarChk.Checked = false;
            this.view_Utang_allBindingSource.DataMember = "view_Utang_all";
            this.view_Utang_allBindingSource.DataSource = this.view;
            this.view_Utang_allDataGridView.DataSource = this.view_Utang_allBindingSource;
            this.view_Utang_allTableAdapter.Fill(this.view.view_Utang_all);
            view_Utang_allDataGridView.Refresh();
        }

        private void blank_field()
        {
            tANGGALDateTimePicker.Value = DateTime.Today;
            fAKTURTextBox.Text = "";
            kodeSupplierTextBox.Text = "";
            namaSupplierTextBox.Text = "";
            pembayaranTxt.Text = "0";
            sisaHutangTxt.Text = "";
            tJTDateTimePicker.Value = DateTime.Today;
            noBuktiTxt.Text = "";
            nominalTextBox.Text = "";
            bayarBtn.Enabled = true;
            erase_subDataGridView();
        }

        private void refreshNoBukti()
        {
            sdr = utang.generateNoBukti();
            while (sdr.Read())
            {
                fAKTURTextBox.Text = (string)sdr["result"];
            }
        }

        private void close()
        {
            if(mf != null)
            {
                mf.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }


        private void view_Utang_SaldoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if((e.ColumnIndex>0)&&(e.RowIndex>0))
            {
                bayarUtang(e.RowIndex,e.ColumnIndex);
            }
        }

        private void bayarUtang(int row, int cell)
        {
            Modul_Pembelian_PembayaranHutang bayarHutang = null;
            bayarHutang = new Modul_Pembelian_PembayaranHutang(this,  view_Utang_allDataGridView.Rows[row]);
            bayarHutang.Show();
            this.Enabled = false;
        }


        private void view_Utang_allDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                    bayarUtang(view_Utang_allDataGridView.CurrentCell.RowIndex, view_Utang_allDataGridView.CurrentCell.ColumnIndex);
            }
        }

        private void blmTerbayarChk_CheckedChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void lihatRincianTxt_Click(object sender, EventArgs e)
        {
            if (view_Utang_allDataGridView.RowCount > 0)
            {
                edit_item(view_Utang_allDataGridView.Rows[view_Utang_allDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void view_Utang_allDataGridView_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bayarUtang(view_Utang_allDataGridView.CurrentCell.RowIndex, view_Utang_allDataGridView.CurrentCell.ColumnIndex);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            close();
        }

        private void view_Utang_allDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                edit_item(view_Utang_allDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private void changeFilter()
        {
            string sql = "";
            string subsql = "";
            this.view_Utang_allTableAdapter.Fill(this.view.view_Utang_all);
            
            if (checkBox1.Checked)
            {
                sql = "tglfaktur ='" + dateTimePicker1.Text + "' ";
            }

            if (checkBox2.Checked)
            {
                subsql = "Faktur LIKE '%" + cariTxt.Text + "%' OR NamaSupplier LIKE '%" + cariTxt.Text + "%'";
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
                subsql= "KodeSupplier LIKE'%" + statusPembayaranTxt.SelectedValue.ToString() + "%'";
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

            if (blmTerbayarChk.Checked)
            {
                subsql = "saldo > 0";
                if ((checkBox1.Checked) || (checkBox2.Checked) || (checkBox3.Checked))
                {
                    sql += " AND " + subsql;
                }
                else
                {
                    sql += subsql;
                }
            }

            if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!blmTerbayarChk.Checked))
            {
                this.view_Utang_allTableAdapter.FillByLast3Months(this.view.view_Utang_all);
                sql = "";
            }

            view_Utang_allBindingSource.Filter  = sql;
            view_Utang_allDataGridView.DataSource = view_Utang_allBindingSource;
            view_Utang_allDataGridView.Refresh();

        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void statusPembayaranTxt_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void bayarBtn_Click_1(object sender, EventArgs e)
        {
            if ((pembayaranTxt.Text.CompareTo("0") != 0) && (pembayaranTxt.Text.CompareTo("") != 0))
            {
                if (Convert.ToDouble(pembayaranTxt.Text) > Convert.ToDouble(sisaHutangTxt.Text))
                {
                    MessageBox.Show("Nominal pembayaran lebih besar dari sisa hutang.");
                }
                else
                {
                    string noBuktiBayarUtang = null;
                    string noJurnal = null;
                    SqlDataReader sdr = utang.InsertRowDebit(DateTime.Today, noBuktiTxt.Text, kodeSupplierTextBox.Text, (float)Convert.ToDouble(allfunc.remove_separated(pembayaranTxt.Text)) * -1, 0, tJTDateTimePicker.Value, "", tANGGALDateTimePicker.Value);//Utang
                    float nilaiPembayaran = (float)Convert.ToDouble(allfunc.remove_separated(pembayaranTxt.Text));
                    while (sdr.Read())
                    {
                        noBuktiBayarUtang = (string)sdr["result"];
                    }

                    kas.InsertRowKredit(DateTime.Today, noBuktiBayarUtang, "Bayar Hutang No.Buki :" + noBuktiBayarUtang, nilaiPembayaran);//Kas

                    SqlDataReader sdr1 = obj.InsertRow(DateTime.Today, noBuktiBayarUtang, "Pembayaran Hutang No.Bukti : " + noBuktiBayarUtang);//Jurnal
                    while (sdr1.Read())
                    {
                        noJurnal = (string)sdr1["result"];
                    }
                    subObj.setDebitSystem(noJurnal, "21111", "Bayar Hutang No.Bukti :" + noBuktiBayarUtang, nilaiPembayaran); //subjurnal
                    subObj.setKreditSystem(noJurnal, "11111", "Kas Besar", nilaiPembayaran);//subjurnal

                    MessageBox.Show("Pembayaran utang berhasil dilakukan.");
                    print_laporan();
                    rebind_all();
                    //close();
                }

            }
            else
            {
                MessageBox.Show("Silakan isi nominal pembayaran.");
            }
        }

        private void print_laporan()
        {
            if (printChkBox.Checked)
            {
                Modul_Laporan_Hutang laporan = new Modul_Laporan_Hutang();
                laporan.Show();
            }
        }

        private void rebind_all()
        {
            blank_field();
            tabControl1.SelectedIndex = 0;
            refreshDataGridView();
        }


        private void erase_subDataGridView()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
            catch (ArgumentException ae) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pembayaranTxt.Text = sisaHutangTxt.Text;
        }

        private void edit_item(string no_Bukti)
        {
            try
            {
                tabControl1.SelectTab(1);
                blank_field();
                refreshNoBukti();
                SqlDataReader sdr = dbo.get_single_data(new string[] { "KodeSupplier", "NamaSupplier", "Faktur", "Saldo", "tglfaktur" }, "Faktur", no_Bukti, "view_utang_all");
                while (sdr.Read())
                {
                    tANGGALDateTimePicker.Value = (DateTime)sdr["tglfaktur"];
                    kodeSupplierTextBox.Text = (string)sdr["KodeSupplier"];
                    namaSupplierTextBox.Text = (string)sdr["NamaSupplier"];
                    pembayaranTxt.Text = "0";
                    sisaHutangTxt.Text = allfunc.digit_separated(((double)sdr["Saldo"]).ToString());
                }

                sdr = dbo.get_single_data(new string[] { "NO_Bukti", "TJT" }, "FAKTUR", no_Bukti + "' AND LOWER(posisiperkiraan) = 'kredit", "utang");
                while (sdr.Read())
                {
                    tJTDateTimePicker.Value = (DateTime)sdr["TJT"];
                    noBuktiTxt.Text = (string)sdr["NO_Bukti"];
                }

                sdr = dbo.get_single_data(new string[] { "JumlahPembelian" }, "NomorBukti", noBuktiTxt.Text, "beli");
                while (sdr.Read())
                {
                    nominalTextBox.Text = allfunc.digit_separated(Convert.ToString((double)sdr["JumlahPembelian"]));
                }
                if (sisaHutangTxt.Text.CompareTo("0") == 0)
                {
                    bayarBtn.Enabled = false;
                }

                sdr = dbo.get_single_data(new string[] { "KodeBarang", "NamaStock", "Qty", "Satuan", "Jumlah", "TglKadaluarsa" }, "NomorBukti", noBuktiTxt.Text, "view_SubBeli_Stock");

                if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            dataGridView1.Rows.Add(new string[] { (string)sdr["KodeBarang"], (string)sdr["NamaStock"], Convert.ToString((double)sdr["qty"]), (string)sdr["Satuan"], allfunc.digit_separated(Convert.ToString((double)sdr["jumlah"])), Convert.ToString((DateTime)sdr["TglKadaluarsa"]) });
                        }
                    }
            }
            catch (NullReferenceException null_e)
            {

            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (view_Utang_allDataGridView.Rows.Count > 0)
                {
                    edit_item(view_Utang_allDataGridView.Rows[view_Utang_allDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString());
                }
            }

        }

        private void keluarBtn_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }



    }
}
