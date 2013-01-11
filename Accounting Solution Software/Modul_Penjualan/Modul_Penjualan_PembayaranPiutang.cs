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
    public partial class Modul_Penjualan_PembayaranPiutang : Form
    {

        private Modul_Penjualan_DaftarPiutang daftarPiutang = null;
        private DataGridViewRow dgvRow = null;
        private AllFunc allfunc = new AllFunc();
        private DbObject dbo = new DbObject();
        private Piutang piutang = new Piutang();
        private JurnalUmum obj = new JurnalUmum();
        private SubJurnalUmum subObj = new SubJurnalUmum();
        private Kas kas = new Kas();

        public Modul_Penjualan_PembayaranPiutang()
        {
            InitializeComponent();
        }

        public Modul_Penjualan_PembayaranPiutang(Modul_Penjualan_DaftarPiutang daftarPiutang, DataGridViewRow dgvRow)
        {

            /*kodesupplier
namasupplier
faktur
tanggal faktur
saldo hutang
*/

            InitializeComponent();
            this.daftarPiutang = daftarPiutang;
            this.dgvRow = dgvRow;
            fakturTxt.Text = dgvRow.Cells[2].Value.ToString();
            kodeCustomerTextBox.Text = dgvRow.Cells[0].Value.ToString();
            namaCustomerTextBox.Text = dgvRow.Cells[1].Value.ToString();
            pembayaranTxt.Text = "0" ;
            sisaPiutangTxt.Text = allfunc.digit_separated(dgvRow.Cells[3].Value.ToString());
            SqlDataReader sdr = dbo.get_single_data(new string[]{"NO_Bukti","TJT"},"FAKTUR",dgvRow.Cells[2].Value.ToString()+"' AND LOWER(posisiperkiraan) = 'debit","piutang");
            while(sdr.Read())
            {
                tJTDateTimePicker.Value = (DateTime)sdr["TJT"];
                noBuktiTxt.Text = (string)sdr["NO_Bukti"];
            }
            DbObject db1 = new DbObject();
            SqlDataReader sdr1 = db1.get_single_data(new string[] { "JumlahPenjualan" }, "nobon", fakturTxt.Text, "jual");
            while (sdr1.Read())
            {
                nominalTextBox.Text = allfunc.digit_separated(Convert.ToString((double)sdr1["JumlahPenjualan"]));
            }
            if(sisaPiutangTxt.Text.CompareTo("0")==0)
            {
                bayarBtn.Enabled = false;
            }
        }


        private void namaSupplierTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bayarBtn_Click(object sender, EventArgs e)
        {
            if ((pembayaranTxt.Text.CompareTo("0") != 0) && (pembayaranTxt.Text.CompareTo("") != 0))
            {
                if (Convert.ToDouble(pembayaranTxt.Text) > Convert.ToDouble(sisaPiutangTxt.Text))
                {
                    MessageBox.Show("Nominal pembayaran lebih besar dari sisa piutang.");
                }
                else
                {
                    string noBuktiBayarPiutang = null;
                    string noJurnal = null;
                    SqlDataReader sdr = piutang.InsertRowKredit(DateTime.Today, fakturTxt.Text, kodeCustomerTextBox.Text, "TOKO", "TOKO", 0, (float)Convert.ToDouble(allfunc.remove_separated(pembayaranTxt.Text)) * -1, tJTDateTimePicker.Value, "", 0);
                    float nilaiPembayaran = (float)Convert.ToDouble(allfunc.remove_separated(pembayaranTxt.Text));
                    while (sdr.Read())
                    {
                        noBuktiBayarPiutang = (string)sdr["result"];
                    }

                    kas.InsertRowDebit(DateTime.Today, noBuktiBayarPiutang, "Piutang dibayar No.Bukti :" + noBuktiBayarPiutang, nilaiPembayaran); //kas
                    SqlDataReader sdr1 = obj.InsertRow(DateTime.Today, noBuktiBayarPiutang, "Piutang dibayar No.Bukti : " + noBuktiBayarPiutang);//Jurnal
                    while (sdr1.Read())
                    {
                        noJurnal = (string)sdr1["result"];
                    }
                    subObj.setKreditSystem(noJurnal, "11211", "Piutang Dibayar No.Bukti :" + noBuktiBayarPiutang, nilaiPembayaran); //subjurnal
                    subObj.setDebitSystem(noJurnal, "11111", "Kas Besar", nilaiPembayaran);//subjurnal

                    MessageBox.Show("Pembayaran piutang berhasil dilakukan.");
                    close();
                }

            }
            else
            {
                MessageBox.Show("Silakan isi nominal pembayaran.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pembayaranTxt.Text = sisaPiutangTxt.Text;
        }

        private void pembayaranTxt_Enter(object sender, EventArgs e)
        {
            pembayaranTxt.Text = allfunc.remove_separated(pembayaranTxt.Text);
        }

        private void pembayaranTxt_Leave(object sender, EventArgs e)
        {
            pembayaranTxt.Text = allfunc.digit_separated(pembayaranTxt.Text);
        }

        private void pembayaranTxt_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Nominal Pembayaran");
        }

        public void close()
        {
            if (daftarPiutang != null)
            {
                daftarPiutang.Enabled = true;
                daftarPiutang.refreshDataGridView();
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
