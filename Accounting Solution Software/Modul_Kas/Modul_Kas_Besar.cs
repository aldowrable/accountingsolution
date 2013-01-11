using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounting_Solution_Software.Classes;
using System.Data.SqlClient;

namespace Accounting_Solution_Software
{
    public partial class Modul_Kas_Besar : Form
    {
        private JurnalUmum obj = null;
        private SubJurnalUmum subObj = null;
        private Kas kas = null;
        private SqlDataReader sdr = null;
        private AllFunc allFunc = null;
        private DbObject dbo = null;
        private double saldo = 0.0;

        public Modul_Kas_Besar()
        {
            InitializeComponent();
            allFunc = new AllFunc("Kas besar", null);
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
            kas = new Kas();
            dbo = new DbObject();
        }

        public Modul_Kas_Besar(MainForm mf)
        {
            InitializeComponent();
            allFunc = new AllFunc("Kas besar", mf);
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
            kas = new Kas();
            dbo = new DbObject();
        }

        private void blank_field()
        {
            refreshNoBukti();
            refreshSaldo();
            noFakturTextBox1.Text = "";
            noFakturTextBox3.Text = "";
            nilaiTextBox.Text = "0";
            nilaiTextBox1.Text = "0";
            nilaiTextBox2.Text = "0";
            nilaiTextBox3.Text = "0";
            keteranganTextBox.Text = "";
            keteranganTextBox1.Text ="";
            keteranganTextBox2.Text = "";
            keteranganTextBox3.Text = "";
            kodePerkiraanTextBox.Text = "";
            kodePerkiraanTextBox1.Text = "";
            namaPerkiraanTextBox.Text = "";
            namaPerkiraanTextBox1.Text = "";
            dariTxt.Text = "";
            dariTxt1.Text = "";
            dariTxt2.Text = "";
            dariTxt3.Text = "";
        }

        private void close()
        {
            if (allFunc.Mf != null)
                allFunc.Mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void refreshNoBukti()
        {
            nomorBuktiTextBox.Text = "Auto";
            nomorBuktiTextBox1.Text = "Auto";
            nomorBuktiTextBox2.Text = "Auto";
            nomorBuktiTextBox3.Text = "Auto";
        }

        private void refreshSaldo()
        {
            sdr = kas.getSaldo("11131");
            while (sdr.Read())
            {
                if (Convert.ToDouble(sdr["result"]) == 0)
                {
                    saldo = 0;
                    saldoTxt.Text = "Rp. 0";
                }
                else
                {
                    saldo = (double)sdr["result"];
                    saldoTxt.Text = "Rp. " + sdr["result"].ToString();
                }
            }
        }

        public void setKodePerkiraanTextBox(List<String> acc)
        {
            Array arrAcc = acc.ToArray();
            if (KasBesarTabControl.SelectedIndex == 0)
            {
                kodePerkiraanTextBox.Text = arrAcc.GetValue(0).ToString();
                namaPerkiraanTextBox.Text = arrAcc.GetValue(1).ToString();
            }
            else if (KasBesarTabControl.SelectedIndex == 1)
            {
                kodePerkiraanTextBox1.Text = arrAcc.GetValue(0).ToString();
                namaPerkiraanTextBox1.Text = arrAcc.GetValue(1).ToString();
            }
        }

        private void Modul_Kas_Besar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.master_Data.Bank);
            // TODO: This line of code loads data into the 'master_Data.view_kelompok_account_lengkap' table. You can move, or remove it, as needed.
            this.view_kelompok_account_lengkapTableAdapter.Fill(this.master_Data.view_kelompok_account_lengkap);
            refreshNoBukti();
            refreshSaldo();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            blank_field();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            close();
        }

        private void btn_cetak_Click(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (KasBesarTabControl.SelectedIndex == 0)
            {
                String v1 = nomorBuktiTextBox.Text;
                String v2 = nilaiTextBox.Text;
                String v3 = kodePerkiraanTextBox.Text;
                String v7 = dariTxt.Text;
                float v4 = (float)Convert.ToDouble(nilaiTextBox.Text);
                if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (v3.CompareTo("") != 0) && (v7.CompareTo("") != 0) && (v4 > 0))
                {
                    if (v1.ToLower().CompareTo("auto") == 0)
                    {
                        sdr = kas.generateNoBuktiMasuk();
                        while (sdr.Read()){v1 = (string)sdr["result"];}
                    }

                    DateTime v5 = Convert.ToDateTime(tanggalDateTimePicker.Text);
                    String v6 = "";
                    sdr = obj.InsertRow(v5, v1, "Penerimaan Kas No. Bukti : " + v1);
                    while (sdr.Read()) { v6 = (string)sdr["result"]; }
                    subObj.setDebitSystem(v6, "11111", "Penerimaan Kas Besar Dari " + dariTxt.Text, v4);
                    subObj.setKreditUser(v6, v3, namaPerkiraanTextBox.Text, v4);
                    kas.InsertRowDebit(v5, v1, "", keteranganTextBox.Text, v4);

                    MessageBox.Show("Transaksi " + allFunc.Prefix + " berhasil dilakukan.");
                    blank_field();
                }
                else
                {
                    MessageBox.Show("NomorBukti transaksi , Kode perkiraan , Nominal , Pemberi kas harus terisi.");
                }
            }
            else if (KasBesarTabControl.SelectedIndex == 1)
            {
                String v1 = nomorBuktiTextBox1.Text;
                String v2 = nilaiTextBox1.Text;
                String v3 = kodePerkiraanTextBox1.Text;
                String v7 = dariTxt1.Text;
                float v4 = (float)Convert.ToDouble(nilaiTextBox1.Text);
                if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (v3.CompareTo("") != 0) && (v7.CompareTo("") != 0) && (v4 > 0))
                {
                    if (v1.ToLower().CompareTo("auto") == 0)
                    {
                        sdr = kas.generateNoBuktiKeluar();
                        while (sdr.Read()) { v1 = (string)sdr["result"]; }
                    }
                    DateTime v5 = Convert.ToDateTime(tanggalDateTimePicker1.Text);
                    String v6 = "";
                    sdr = obj.InsertRow(v5, v1, "Pengeluaran Kas No. Bukti : " + v1);
                    while (sdr.Read()) { v6 = (string)sdr["result"]; }
                    subObj.setKreditSystem(v6, "11111", "Pengeluaran Kas Besar Kepada " + dariTxt1.Text, v4);
                    subObj.setDebitUser(v6, v3, namaPerkiraanTextBox1.Text, v4);
                    kas.InsertRowKredit(v5, v1, noFakturTextBox1.Text, keteranganTextBox1.Text, v4);

                    MessageBox.Show("Transaksi " + allFunc.Prefix + " berhasil dilakukan.");
                    blank_field();
                }
                else
                {
                    MessageBox.Show("NomorBukti transaksi , Kode perkiraan , Nominal , dan Penerima kas harus terisi.");
                }
            }
            else if (KasBesarTabControl.SelectedIndex == 2)
            {
                String v1 = nomorBuktiTextBox2.Text;
                String v2 = nilaiTextBox2.Text;
                String v7 = dariTxt2.Text;
                float v4 = (float)Convert.ToDouble(nilaiTextBox2.Text);
                if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (v7.CompareTo("") != 0) && (v4 > 0))
                {
                    if (v1.ToLower().CompareTo("auto") == 0)
                    {
                        sdr = kas.generateNoBuktiKeluar();
                        while (sdr.Read()) { v1 = (string)sdr["result"]; }
                    }
                    DateTime v5 = Convert.ToDateTime(tanggalDateTimePicker2.Text);
                    String v6 = "";
                    sdr = obj.InsertRow(v5, v1, "Pengeluaran Kas No. Bukti : " + v1);
                    while (sdr.Read()) { v6 = (string)sdr["result"]; }
                    subObj.setKreditSystem(v6, "11111", "Pengeluaran Kas Besar Oleh  " + dariTxt2.Text, v4);
                    subObj.setDebitSystem(v6, "11131","Pengisian Kas Kecil",v4);
                    kas.InsertRowKredit(v5, v1, "", keteranganTextBox2.Text, v4);
                    kas.InsertKasKecilRowDebit(v5, v1, "", keteranganTextBox2.Text, v4);

                    MessageBox.Show("Transaksi " + allFunc.Prefix + " berhasil dilakukan.");
                    blank_field();
                }
                else
                {
                    MessageBox.Show("NomorBukti transaksi , Nominal , Pengisi Kas Kecil harus terisi.");
                }
            }
            else if (KasBesarTabControl.SelectedIndex == 3)
            {
                String v1 = nomorBuktiTextBox3.Text;
                String v2 = nilaiTextBox3.Text;
                String v3 = noFakturTextBox3.Text;
                String v7 = dariTxt3.Text;
                String v8 = kodePerkiraanTextBox3.SelectedValue.ToString();
                float v4 = (float)Convert.ToDouble(nilaiTextBox3.Text);
                if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (v3.CompareTo("") != 0) && (v7.CompareTo("") != 0) && (v8.CompareTo("") != 0) && (v4 > 0))
                {
                    if (v1.ToLower().CompareTo("auto") == 0)
                    {
                        sdr = kas.generateNoBuktiKeluar();
                        while (sdr.Read()) { v1 = (string)sdr["result"]; }
                    }
                    DateTime v5 = Convert.ToDateTime(tanggalDateTimePicker3.Text);
                    String v6 = "";
                    sdr = obj.InsertRow(v5, v1, "Pengeluaran Kas No. Bukti : " + v1);
                    while (sdr.Read()) { v6 = (string)sdr["result"]; }
                    subObj.setKreditSystem(v6, "11111", "Pengeluaran Kas Besar Oleh  " + v7, v4);
                    subObj.setDebitSystem(v6, v8, "Penyetoran ke Bank", v4);
                    kas.InsertRowKredit(v5, v1, v3, keteranganTextBox3.Text, v4);

                    MessageBox.Show("Transaksi " + allFunc.Prefix + " berhasil dilakukan.");
                    blank_field();
                }
                else
                {
                    MessageBox.Show("NomorBukti transaksi , Nominal , No Faktur, Bank, dan Penyetor harus terisi.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modul_Akuntansi_KodePerkiraan FormkodePerkiraan = new Modul_Akuntansi_KodePerkiraan(this);
            this.Enabled = false;
            FormkodePerkiraan.Show();
        }

        


        private void nilaiTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Nominal");
        }


        private void nilaiTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Nominal");
        }

        private void nilaiTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Nominal");
        }

        private void nilaiTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Nominal");
        }

        private void KasBesarTabControl_Selected(object sender, TabControlEventArgs e)
        {
            refreshNoBukti();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modul_Akuntansi_KodePerkiraan FormkodePerkiraan = new Modul_Akuntansi_KodePerkiraan(this);
            this.Enabled = false;
            FormkodePerkiraan.Show();
        }

    }
}
