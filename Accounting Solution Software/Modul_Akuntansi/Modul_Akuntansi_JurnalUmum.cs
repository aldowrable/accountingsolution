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
    public partial class Modul_Akuntansi_JurnalUmum : Form
    {

        private MainForm mf = null;
        private String prefix = "Jurnal Umum";
        private JurnalUmum obj = new JurnalUmum();
        private DbObject dbo = new DbObject();
        private AllFunc allFunc = new AllFunc();
        private SqlDataReader sdr = null;
        private String noJurnal = "";
        private double debitValue = 0.0;
        private double creditValue = 0.0;

        public Modul_Akuntansi_JurnalUmum()
        {
            InitializeComponent();
        }

        public Modul_Akuntansi_JurnalUmum(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void Modul_Akuntansi_JurnalUmum_Load(object sender, EventArgs e)
        {
            this.accountTableAdapter.Fill(this.master_Data.Account);
            refreshNoBukti();
        }

        private void blankField()
        {
            noJurnalTxtBox.Text = "";
            noRefTxt.Text = "";
            deskRTB.Text = "";
            drLbl.Text = "0";
            crLbl.Text = "0";
            akunItemDTV.Rows.Clear();
            akunItemDTV.Refresh();
            refreshNoBukti();
        }

        private void refreshNoBukti()
        {
            sdr = obj.generateNoBukti();
            while (sdr.Read())
            {
                noJurnal = (string)sdr["result"];
                noJurnalTxtBox.Text = (string)sdr["result"];
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            String v1 = noJurnalTxtBox.Text;
            String v2 = deskRTB.Text;
            String spQuery = "";

            if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (debitValue == creditValue) && (debitValue != 0))
            {
                sdr = obj.InsertRow(tanggalDTP.Value,noRefTxt.Text,deskRTB.Text);
                while (sdr.Read())
                {
                    noJurnal = (string)sdr["result"];
                }

                for (int i = 0; i < akunItemDTV.Rows.Count ; i++ )
                {
                    if(akunItemDTV.Rows[i].Cells[0].Value != DBNull.Value)
                    {
                        String posisiPerkiraanTemp = "DEBIT";
                        double nilaiPerkiraan = 0.0;
                        if(akunItemDTV.Rows[i].Cells[3].Value != null)
                        {
                            if (akunItemDTV.Rows[i].Cells[3].Value.ToString().CompareTo("0") != 0)
                            {
                                posisiPerkiraanTemp = "KREDIT";
                                nilaiPerkiraan = Double.Parse(akunItemDTV.Rows[i].Cells[3].Value.ToString());
                            }
                            else
                            {
                                nilaiPerkiraan = Double.Parse(akunItemDTV.Rows[i].Cells[2].Value.ToString());
                            }
                        }
                        else
                        {
                            nilaiPerkiraan = Double.Parse(akunItemDTV.Rows[i].Cells[2].Value.ToString());
                        }

                        spQuery += "EXEC sp_SubJurnalUmum_Insert '"+noJurnal+"','"+akunItemDTV.Rows[i].Cells[0].Value.ToString()+"','"+akunItemDTV.Rows[i].Cells[1].Value.ToString()+"',"+nilaiPerkiraan+",'"+posisiPerkiraanTemp+"';";
                    }

                }
                dbo.run_query(spQuery);
                MessageBox.Show("Transaksi " + prefix + " Berhasil dilakukan.");
                blankField();
            }
            else
            {
                MessageBox.Show("Nomor Jurnal, Deskripsi, dan Detail "+prefix+" harus teriisi.");
            }
        }

        private void calculate()
        {
            debitValue = 0.0;
            creditValue = 0.0;

            for (int i = 0; i < akunItemDTV.Rows.Count ; i++ )
            {
                if(akunItemDTV.Rows[i].Cells[0].Value != null)
                {
                    if ((akunItemDTV.Rows[i].Cells[2].Value != null))
                    {
                        debitValue += Double.Parse(akunItemDTV.Rows[i].Cells[2].Value.ToString());
                    }
                    if ((akunItemDTV.Rows[i].Cells[3].Value != null))
                    {
                        creditValue += Double.Parse(akunItemDTV.Rows[i].Cells[3].Value.ToString());
                    }
                }
            }
            drLbl.Text = allFunc.digit_separated(debitValue.ToString());
            crLbl.Text = allFunc.digit_separated(creditValue.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            close();
        }

        private void close()
        {
            if (this.mf != null)
            {
                mf.Enabled = true;
            }
            Close();
            Dispose();
        }

        private void akunItemDTV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (akunItemDTV.Rows.Count > 0)
            {
                akunItemDTV.Rows.RemoveAt(akunItemDTV.CurrentRow.Index);
                akunItemDTV.Refresh();
                calculate();
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            Modul_Akuntansi_KodePerkiraan kodePerkiraan = new Modul_Akuntansi_KodePerkiraan(this);
            kodePerkiraan.Show();
        }

        public void addAkunItem(List<String> dataPerkiraan)
        {
            akunItemDTV.Rows.Add(dataPerkiraan.ToArray());
        }
    }
}
