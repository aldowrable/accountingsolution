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
    public partial class Modul_Pembelian_PembayaranHutang : Form
    {
        private Modul_Pembelian_DaftarHutang daftarHutang = null;
        private DataGridViewRow dgvRow = null;
        private AllFunc allfunc = new AllFunc();
        private DbObject dbo = new DbObject();
        private Utang utang = new Utang();
        private JurnalUmum obj = new JurnalUmum();
        private SubJurnalUmum subObj = new SubJurnalUmum();
        private Kas kas = new Kas();
        public Modul_Pembelian_PembayaranHutang()
        {
            InitializeComponent();
        }

        public Modul_Pembelian_PembayaranHutang(Modul_Pembelian_DaftarHutang daftarHutang,DataGridViewRow dgvRow)
        {

            /*kodesupplier
namasupplier
faktur
tanggal faktur
saldo hutang
*/

            InitializeComponent();
            this.daftarHutang = daftarHutang;
            this.dgvRow = dgvRow;
            tANGGALDateTimePicker.Value = Convert.ToDateTime(dgvRow.Cells[3].Value.ToString());
            fAKTURTextBox.Text = dgvRow.Cells[2].Value.ToString();
            kodeSupplierTextBox.Text = dgvRow.Cells[0].Value.ToString();
            namaSupplierTextBox.Text = dgvRow.Cells[1].Value.ToString();
            pembayaranTxt.Text = "0" ;
            sisaHutangTxt.Text = allfunc.digit_separated(dgvRow.Cells[4].Value.ToString());
            SqlDataReader sdr = dbo.get_single_data(new string[]{"NO_Bukti","TJT"},"FAKTUR",dgvRow.Cells[2].Value.ToString()+"' AND LOWER(posisiperkiraan) = 'kredit","utang");
            while(sdr.Read())
            {
                tJTDateTimePicker.Value = (DateTime)sdr["TJT"];
                noBuktiTxt.Text = (string)sdr["NO_Bukti"];
            }
            DbObject db1 = new DbObject();
            SqlDataReader sdr1 = db1.get_single_data(new string[] { "JumlahPembelian" }, "NomorBukti", noBuktiTxt.Text, "beli");
            while (sdr1.Read())
            {
                nominalTextBox.Text = allfunc.digit_separated(Convert.ToString((double)sdr1["JumlahPembelian"]));
            }
            if(sisaHutangTxt.Text.CompareTo("0")==0)
            {
                bayarBtn.Enabled = false;
            }
            setDataGridView(noBuktiTxt.Text);
        }

        private void setDataGridView(string no_Bukti)
        {

            SqlDataReader sdr = dbo.get_single_data(new string[]{"KodeBarang","NamaStock","Qty","Satuan","Jumlah","TglKadaluarsa"},"NomorBukti",no_Bukti ,"view_SubBeli_Stock");
            try
            {
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        dataGridView1.Rows.Add(new string[] { (string)sdr["KodeBarang"], (string)sdr["NamaStock"], Convert.ToString((double)sdr["qty"]), (string)sdr["Satuan"], allfunc.digit_separated(Convert.ToString((double)sdr["jumlah"])), Convert.ToString((DateTime)sdr["TglKadaluarsa"]) });
                    }
                }
            }
            catch(NullReferenceException null_e)
            {

            }
            

        }

        private void nominalLabel_Click(object sender, EventArgs e)
        {

        }

        private void nominalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bayarBtn_Click(object sender, EventArgs e)
        {
            if((pembayaranTxt.Text.CompareTo("0")!=0)&&(pembayaranTxt.Text.CompareTo("")!=0))
            {
                if (Convert.ToDouble(pembayaranTxt.Text) > Convert.ToDouble(sisaHutangTxt.Text))
                {
                    MessageBox.Show("Nominal pembayaran lebih besar dari sisa hutang.");
                }
                else
                {
                    string noBuktiBayarUtang = null;
                    string noJurnal = null;
                    SqlDataReader sdr = utang.InsertRowDebit(DateTime.Today, fAKTURTextBox.Text, kodeSupplierTextBox.Text, (float)Convert.ToDouble(allfunc.remove_separated(pembayaranTxt.Text)) * -1, 0, tJTDateTimePicker.Value, "", tANGGALDateTimePicker.Value);//Utang
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
                    close();
                }

            }
            else{
                MessageBox.Show("Silakan isi nominal pembayaran.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pembayaranTxt.Text = sisaHutangTxt.Text;
        }

        private void pembayaranTxt_Enter(object sender, EventArgs e)
        {
            pembayaranTxt.Text = allfunc.remove_separated(pembayaranTxt.Text);
        }

        private void pembayaranTxt_Leave(object sender, EventArgs e)
        {
           pembayaranTxt.Text =  allfunc.digit_separated(pembayaranTxt.Text);
        }

        private void pembayaranTxt_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Nominal Pembayaran");
        }

        public void close()
        {
            if (daftarHutang != null)
            {
                daftarHutang.Enabled = true;
                daftarHutang.refreshDataGridView();
            }
            this.Close();
            this.Dispose();
        }

        private void keluarBtn_Click(object sender, EventArgs e)
        {
            close();
        }
    }
}
