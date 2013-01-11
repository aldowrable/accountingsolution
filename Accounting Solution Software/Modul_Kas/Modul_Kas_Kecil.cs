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
    public partial class Modul_Kas_Kecil : Form
    {
        private JurnalUmum obj = null;
        private SubJurnalUmum subObj = null;
        private Kas kas = null;
        private DbObject dbo = null;
        private SqlDataReader sdr = null;
        private AllFunc allFunc = null;
        private double saldo = 0.0;

        public Modul_Kas_Kecil()
        {
            InitializeComponent();
            allFunc = new AllFunc("Kas kecil", null);
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
            kas = new Kas();
            dbo = new DbObject();
        }

        public Modul_Kas_Kecil(MainForm mf)
        {
            InitializeComponent();
            allFunc = new AllFunc("Kas kecil", mf);
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
            kas = new Kas();
            dbo = new DbObject();
        }

        private void blank_field()
        {
            refreshNoBukti();
            refreshSaldo();
            noFakturTextBox.Text = "";
            nilaiTextBox.Text = "0";
            keteranganTextBox.Text = "";
            kodePerkiraanTextBox.Text = "";
            namaPerkiraanTextBox.Text = "";
            nilaiTextBox2.Text = "0";
            dariTxt2.Text = "";
            keteranganTextBox2.Text = "";
        }

        private void Modul_Kas_Kecil_Load(object sender, EventArgs e)
        {
            refreshNoBukti();
            refreshSaldo();
        }

        public void setKodePerkiraanTextBox(List<String> acc)
        {
            Array arrAcc = acc.ToArray();
            kodePerkiraanTextBox.Text = arrAcc.GetValue(0).ToString();
            namaPerkiraanTextBox.Text = arrAcc.GetValue(1).ToString();
        }

        private void nilaiTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Nominal");
        }

        private void close()
        {
            if (allFunc.Mf != null)
                allFunc.Mf.Enabled = true;
            this.Close();
            this.Dispose();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void refreshNoBukti()
        {
            nomorBuktiTextBox.Text = "Auto";
            nomorBuktiTextBox2.Text = "Auto";
        }

        private void refreshSaldo()
        {
            sdr = kas.getSaldo("11131");
            while (sdr.Read())
            {
                if (sdr["result"] == DBNull.Value)
                {
                    saldo = 0;
                    saldoTxt.Text = "Rp. 0";
                }
                else
                {
                    saldo = (double)sdr["result"];
                    saldoTxt.Text = "Rp. " + sdr["result"].ToString();
                    textBox1.Text = "Rp. " + sdr["result"].ToString();
                }
            }


            sdr = kas.getSaldoBulanLalu("11131");
            while (sdr.Read())
            {
                if (sdr["result"] == DBNull.Value)
                {
                    saldoLaluTxt.Text = "Rp. 0";
                }
                else
                {
                    saldoLaluTxt.Text = "Rp. " + sdr["result"].ToString();
                }
            }

        }

        private void KasBesarTabControl_Selected(object sender, TabControlEventArgs e)
        {
            refreshNoBukti();
        }

        private void nilaiTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String v1 = nomorBuktiTextBox2.Text;
            String v2 = nilaiTextBox2.Text;
            String v7 = dariTxt2.Text;
            float v4 = (float)Convert.ToDouble(nilaiTextBox2.Text);
            if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (v7.CompareTo("") != 0) && (v4 > 0))
            {
                if (v1.ToLower().CompareTo("auto") == 0)
                {
                    sdr = kas.generateNoBuktiMasuk();
                    while (sdr.Read()) { v1 = (string)sdr["result"]; }
                }
                DateTime v5 = Convert.ToDateTime(tanggalDateTimePicker2.Text);
                String v6 = "";
                sdr = obj.InsertRow(v5, v1, "Pengisian Kas Kecil No. Bukti : " + v1);
                while (sdr.Read()) { v6 = (string)sdr["result"]; }
                subObj.setKreditSystem(v6, "31111", "Pengisian Kas Kecil ", v4);
                subObj.setDebitSystem(v6, "11131", "Pengisian Kas Kecil Oleh " + dariTxt2.Text, v4);
                kas.InsertKasKecilRowDebit(v5, v1, "", keteranganTextBox2.Text, v4);

                MessageBox.Show("Pengisian Kas Kecil berhasil dilakukan.");
                blank_field();
            }
            else
            {
                MessageBox.Show("NomorBukti transaksi , Nominal , Pengisi Kas Kecil harus terisi.");
            }
        }

        private void nilaiTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Nominal");
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            String v1 = nomorBuktiTextBox.Text;
            String v2 = nilaiTextBox.Text;
            String v3 = kodePerkiraanTextBox.Text;
            float v4 = (float)Convert.ToDouble(nilaiTextBox.Text);
            if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (v3.CompareTo("") != 0) && (v4 > 0))
            {
                if (Convert.ToDouble(v2) < saldo)
                {
                    if (v1.ToLower().CompareTo("auto") == 0)
                    {
                        sdr = kas.generateNoBuktiKeluar();
                        while (sdr.Read()) { v1 = (string)sdr["result"]; }
                    }
                    DateTime v5 = Convert.ToDateTime(tanggalDateTimePicker.Text);
                    String v6 = "";
                    sdr = obj.InsertRow(v5, v1, "Pengeluaran Kas Kecil No. Bukti : " + v1);
                    while (sdr.Read()) { v6 = (string)sdr["result"]; }
                    subObj.setKreditSystem(v6, "11131", "Pengeluaran Kas Kecil ", v4);
                    subObj.setDebitUser(v6, v3, namaPerkiraanTextBox.Text, v4);
                    kas.InsertKasKecilRowKredit(v5, v1, noFakturTextBox.Text, keteranganTextBox.Text, v4);

                    MessageBox.Show("Transaksi " + allFunc.Prefix + " berhasil dilakukan.");
                    print_laporan(v1);
                    blank_field();

                }
                else
                {
                    MessageBox.Show("Saldo Kas Kecil tidak mencukupi untuk transaksi ini.");
                    blank_field();
                }
            }
            else
            {
                MessageBox.Show("NomorBukti transaksi , Kode perkiraan , Nominal , Identitas Pembayar harus terisi.");
            }

        }

        private void print_laporan(string id)
        {
            if (printChkBox.Checked)
            {
                Modul_Laporan_Arus_KasKecil laporan = new Modul_Laporan_Arus_KasKecil(id);
                laporan.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Modul_Akuntansi_KodePerkiraan FormkodePerkiraan = new Modul_Akuntansi_KodePerkiraan(this);
            this.Enabled = false;
            FormkodePerkiraan.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void nilaiTextBox_KeyDown_2(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Nominal");
        }

    }
}
