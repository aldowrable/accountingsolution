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
    public partial class Modul_Penjualan_Daftar : Form
    {
        private MainForm mf;
        private bool edit = true;
        private DataTable dt = new DataTable();
        private AllFunc allFunc = null;
        private DbObject dbo = new DbObject();
        private SqlDataReader sdr = null;

        public Modul_Penjualan_Daftar(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void close()
        {
            if(mf!=null)
            {
                mf.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void Modul_Penjualan_Daftar_Load(object sender, EventArgs e)
        {
            this.gudangTableAdapter.Fill(this.master_Data.Gudang);
            this.view_jual_nobonTableAdapter.Fill(this.penjualan.view_jual_nobon);
            //this.view_jual_nobonTableAdapter.FillByLast3Months(this.penjualan_Data.view_jual_nobon);
            set_bulan_cmb();
            set_tahun_cmb();
            set_cabang_cmb();
            hariangRdBtn.Checked = true;
        }

        private void set_bulan_cmb()
        { 
            var items = new BindingList<KeyValuePair<string, string>>();

            items.Add(new KeyValuePair<string, string>("1", "Januari"));
            items.Add(new KeyValuePair<string, string>("2", "Februari"));
            items.Add(new KeyValuePair<string, string>("3", "Maret"));
            items.Add(new KeyValuePair<string, string>("4", "April"));
            items.Add(new KeyValuePair<string, string>("5", "Mei"));
            items.Add(new KeyValuePair<string, string>("6", "Juni"));
            items.Add(new KeyValuePair<string, string>("7", "Juli"));
            items.Add(new KeyValuePair<string, string>("8", "Agustus"));
            items.Add(new KeyValuePair<string, string>("9", "September"));
            items.Add(new KeyValuePair<string, string>("10", "Oktober"));
            items.Add(new KeyValuePair<string, string>("11", "November"));
            items.Add(new KeyValuePair<string, string>("12", "Desember"));

            bulanCmb.DataSource = items;
            bulanCmb.ValueMember = "Key";
            bulanCmb.DisplayMember = "Value";

        }

        private void set_cabang_cmb()
        {
            String[] fields = new String[] { "id", "nama" };
            DataTable dt = dbo.get_all(fields, "gudang", "", "", "", 0, 0);
            var items3 = new BindingList<KeyValuePair<string, string>>();

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {
                items3.Add(new KeyValuePair<string, string>(row["id"].ToString(), row["nama"].ToString()));
            }

            items3.Add(new KeyValuePair<string, string>("", "Semua Cabang"));

            cabang2Cmb.DataSource = items3;
            cabang2Cmb.ValueMember = "Key";
            cabang2Cmb.DisplayMember = "Value";
        }

        private void set_tahun_cmb()
        {
            var items1 = new BindingList<KeyValuePair<string, string>>();

            for (int i = 2011; i <= DateTime.Now.Year;i++ )
            {
                items1.Add(new KeyValuePair<string, string>(i.ToString(), i.ToString()));
            }

            tahunCmb.DataSource = items1;
            tahunCmb.ValueMember = "Key";
            tahunCmb.DisplayMember = "Value";

            tahun2Cmb.DataSource = items1;
            tahun2Cmb.ValueMember = "Key";
            tahun2Cmb.DisplayMember = "Value";
        }

        private void blank_field()
        {
            noBonTextBox.Text = "";
            kodeCbgTxt.Text = "";
            namaCbgTxt.Text = "";
            kasirTextBox.Text = "";
            counterTxt.Text = "";
            customerTxt.Text = "";
            brutoTxt.Text = "";
            discTotalTextBox.Text = "";
            ppnTxt.Text = "";
            nettoTxt.Text = "";
            statusPembayaranTxt.Text = "";
            eraseSubDGV();
        }

        private void unBindSubDGB()
        {
            this.view_subJual_stockDataGridView.DataSource = null;
        }

        private void eraseSubDGV()
        {
            try
            {
                unBindSubDGB();
                view_subJual_stockDataGridView.Columns.Clear();
                view_subJual_stockDataGridView.Rows.Clear();
                view_subJual_stockDataGridView.Refresh();
            }
            catch (ArgumentException ae) { }
        }

        private void edit_item(string nobon, string cabang)
        {
            try
            {
                tabControl1.SelectTab(1);
                sdr = dbo.get_single_data(null, "noBon = '" + nobon + "' AND kodeCbg", cabang, "view_jual_nobon");
                while (sdr.Read())
                {
                    noBonTextBox.Text = (string)sdr["noBon"];
                    tanggalDateTimePicker.Value = (DateTime)sdr["Tanggal"];
                    kodeCbgTxt.Text = (string)sdr["kodeCbg"];
                    namaCbgTxt.Text = (string)sdr["namaCbg"];
                    kasirTextBox.Text = (string)sdr["kasir"];
                    counterTxt.Text = (string)sdr["Counter"];
                    customerTxt.Text = (string)sdr["Customer"];
                    brutoTxt.Text = (Math.Round((decimal)sdr["Bruto"])).ToString();
                    discTotalTextBox.Text = (Math.Round((decimal)sdr["Diskon"])).ToString();
                    ppnTxt.Text = (Math.Round((decimal)sdr["Ppn"])).ToString();
                    nettoTxt.Text = (Math.Round((decimal)sdr["netto"])).ToString();
                    statusPembayaranTxt.Text = "Tunai";
                    if (sdr["TK"].ToString().CompareTo("K") == 0)
                    {
                        statusPembayaranTxt.Text = "Kredit";
                    }

                }
                String[] fields = new String[] { "kodeBrg AS [Kode Produk]", "namaBrg AS [Nama stock]", "cast(Jumlah as float) AS Qty", "cast(hpp AS float) As [HPP]", "cast(harga as float) As [Harga Jual]", "cast(Total as float )As Subtotal","cast(selisihharga as float) as Laba" };
                dt = dbo.get_all(fields, "view_subJual_stock", "noBon = '" + nobon + "' AND kodeCbg = '" + cabang + "'", "", "", 0, 0);
                view_subJual_stockDataGridView.DataSource = dt;
                set_dgv_column_readonly();
                view_subJual_stockDataGridView.Refresh();
            }
            catch (NullReferenceException nre)
            {
            }
        }

        private void set_dgv_column_readonly()
        {
            view_subJual_stockDataGridView.Columns[0].ReadOnly = true;
            view_subJual_stockDataGridView.Columns[1].ReadOnly = true;
            view_subJual_stockDataGridView.Columns[3].ReadOnly = true;
            view_subJual_stockDataGridView.Columns[4].ReadOnly = true;
            view_subJual_stockDataGridView.Columns[5].ReadOnly = true;
            view_subJual_stockDataGridView.Columns[6].ReadOnly = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (view_jual_nobonDataGridView.RowCount > 0)
            {
                edit_item(view_jual_nobonDataGridView.Rows[view_jual_nobonDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), view_jual_nobonDataGridView.Rows[view_jual_nobonDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                changeFilter();
            }
        }

        private void view_Jasa_DokterDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void view_jual_nobonDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex>=0 && e.RowIndex>=0)
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void view_jual_nobonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            try
            {
                string sql = "";
                string subsql = "";
                this.view_jual_nobonTableAdapter.Fill(this.penjualan.view_jual_nobon);
                
                if (checkBox1.Checked)
                {
                    sql = " (" + String.Format("Tanggal >= '{0:MM/dd/yyyy}' AND Tanggal < '{1:MM/dd/yyyy}'", dateTimePicker1.Value, dateTimePicker1.Value.AddDays(1)) + ")";
                }

                if (checkBox3.Checked)
                {
                    subsql = "kodeCbg = '" + cabangCmb.SelectedValue.ToString() + "'";
                    if (checkBox1.Checked)
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
                    subsql = "NoBon LIKE '%" + cariTxt.Text + "%' OR Kasir LIKE '%" + cariTxt.Text + "%'";
                    if ((checkBox3.Checked) || (checkBox1.Checked))
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
                    this.view_jual_nobonTableAdapter.Fill(this.penjualan.view_jual_nobon);
                    //this.view_pembelian_supplierTableAdapter.FillLast3Month(this.pembelian_2.view_pembelian_supplier);
                    sql = "";
                }

                view_jual_nobonBindingSource.Filter = sql;
                view_jual_nobonDataGridView.DataSource = view_jual_nobonBindingSource;
                view_jual_nobonDataGridView.Refresh();

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
            if(checkBox2.Checked)
            {
                changeFilter();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            close();
        }

        private void cabangCmb_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void view_jual_nobonDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                edit_item(view_jual_nobonDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), view_jual_nobonDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                edit_item(view_jual_nobonDataGridView.Rows[view_jual_nobonDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), view_jual_nobonDataGridView.Rows[view_jual_nobonDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString());
            }

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void change_filter_ringkasan_penjualan()
        {
            dtp1.Enabled = false;
            dtp2.Enabled = false;
            dtp3.Enabled = false;
            bulanCmb.Enabled = false;
            tahunCmb.Enabled = false;
            tahun2Cmb.Enabled = false;

            if(hariangRdBtn.Checked ==true)
            {
                dtp1.Enabled = true;
            }

            if (mingguanRdBtn.Checked == true)
            {
                dtp2.Enabled = true;
                dtp3.Enabled = true;
            }

            if (bulananRdBtn.Checked == true)
            {
                bulanCmb.Enabled = true;
                tahunCmb.Enabled = true;
            }

            if (tahunanRdBtn.Checked == true)
            {
                tahun2Cmb.Enabled = true;
            }


        }

        private void hariangRdBtn_Click(object sender, EventArgs e)
        {
            change_filter_ringkasan_penjualan();
        }

        private void mingguanRdBtn_Click(object sender, EventArgs e)
        {
            change_filter_ringkasan_penjualan();
        }

        private void bulananRdBtn_Click(object sender, EventArgs e)
        {
            change_filter_ringkasan_penjualan();
        }

        private void tahunanRdBtn_Click(object sender, EventArgs e)
        {
            change_filter_ringkasan_penjualan();
        }

        private void lhtHasilBtn_Click(object sender, EventArgs e)
        {
            generate_laporan_ringkasan_penjualan();
        }

        private void generate_laporan_ringkasan_penjualan()
        {

            string spQuery = null;

            if (hariangRdBtn.Checked == true)
            {
                spQuery = "[dbo].[get_penjualan] 'harian','"+cabang2Cmb.SelectedValue.ToString()+"','"+dtp1.Value.ToString()+"','',0,0 ;";
            }

            if (mingguanRdBtn.Checked == true)
            {
                spQuery = "[dbo].[get_penjualan] 'mingguan','"+cabang2Cmb.SelectedValue.ToString()+"','"+dtp2.Value.ToString()+"','"+dtp3.Value.ToString()+"',0,0 ;";
            }

            if (bulananRdBtn.Checked == true)
            {
                spQuery = "[dbo].[get_penjualan] 'bulanan','" + cabang2Cmb.SelectedValue.ToString() + "','',''," + bulanCmb.SelectedValue.ToString() + "," + tahunCmb.Text + " ;";
            }

            if (tahunanRdBtn.Checked == true)
            {
                spQuery = "[dbo].[get_penjualan] 'tahunan','" + cabang2Cmb.SelectedValue.ToString() + "','','',0," + tahun2Cmb.Text + " ;";
            }

            DataTable dt2 = new DataTable();
            dt2 = dbo.run_query_data_table(spQuery);
            ringkasanPenjualanDGV.DataSource = dt2;

            ringkasanPenjualanDGV.Refresh();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Modul_Lapuran_Penjualan laporan = new Modul_Lapuran_Penjualan();
            laporan.Show();
        }

    }
}
