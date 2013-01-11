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
    public partial class Modul_Akuntansi_TutupBuku : Form
    {
        //private bool bulananTrigger = true;
        MainForm mf = null;
        private DbObject dbo = null;
        private JurnalUmum obj = null;
        private SubJurnalUmum subObj = null;

        public Modul_Akuntansi_TutupBuku()
        {
            InitializeComponent();
            dbo = new DbObject();
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
        }

        public Modul_Akuntansi_TutupBuku(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            dbo = new DbObject();
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
        }

        //private void Modul_Akuntansi_TutupBuku_Load(object sender, EventArgs e)
        //{
            //bulananRadBtn.Checked = true;
            //tahunanRadBtn.Checked = false;
            //bulananDTP.Enabled = true;
            //tahunanDTP.Enabled = false;
        //}

        private void close()
        {
            if(mf != null)
            {
                mf.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void save()
        {
            //if (bulananTrigger)
            //{ // bulanan
                //int month = Convert.ToInt16(bulananDTP.Value.ToString("MM"));
                //int year = Convert.ToInt16(bulananDTP.Value.ToString("yyyy"));

                //get pendapatan di bulan dan tahun bersangkutan
                //get beban di bulan dan tahun bersangkutan

                //DateTime firstDayOfTheMonth = new DateTime(year, month, 1);
                //DateTime lastDayOfTheMonth =  firstDayOfTheMonth.AddMonths(1).AddDays(-1);

                //insert ikhtisar laba rugi di akhir bulan bersangkutan
                //insert ke modal dari laba dan rugi
            //}
            //else
            //{
                String noJurnal = null;
                SqlDataReader sdrJurnalUmum = null;
                double count41 = 0;
                double count51 = 0;
                double count61 = 0;
                double countPrive = 0;
                double total = 0;

                /*Tutup Account 41*/
                DataTable dtTableTutupBuku = dbo.get_all(new String[] { "KodePerkiraan", "NamaPerkiraan", "DEBIT", "KREDIT", "YEAR" }, "view_saldo_41", "SALDO != 0 AND YEAR = '" + tahunanDTP.Value.Year.ToString() + "'", "", "", 0, 0);
                if (dtTableTutupBuku != null)
                {
                    if (dtTableTutupBuku.Rows.Count > 0)
                    {
                        sdrJurnalUmum = obj.InsertRow(DateTime.Today, "", "Tutup Buku");
                        while (sdrJurnalUmum.Read())
                        {
                            noJurnal = (string)sdrJurnalUmum["result"];
                        }

                        foreach (DataRow row in dtTableTutupBuku.Rows)
                        {
                            subObj.setDebitUser_double(noJurnal, row["KodePerkiraan"].ToString(), "Tutup Buku " + row["NamaPerkiraan"].ToString(), Convert.ToDouble(row["KREDIT"]));
                            count41 += Convert.ToDouble(row["KREDIT"]);
                        }
                        subObj.setKreditSystem_double(noJurnal, "61121", "Ikhtisar Laba Rugi", count41);
                    }
                }


                /*Tutup Account 51*/
                dtTableTutupBuku = dbo.get_all(new String[] { "KodePerkiraan", "NamaPerkiraan", "DEBIT", "KREDIT", "YEAR" }, "view_saldo_51", "SALDO != 0 AND YEAR = '" + tahunanDTP.Value.Year.ToString() + "'", "", "", 0, 0);
                if (dtTableTutupBuku != null)
                {
                    if (dtTableTutupBuku.Rows.Count > 0)
                    {
                        sdrJurnalUmum = obj.InsertRow(DateTime.Today, "", "Tutup Buku");
                        while (sdrJurnalUmum.Read())
                        {
                            noJurnal = (string)sdrJurnalUmum["result"];
                        }

                        foreach (DataRow row in dtTableTutupBuku.Rows)
                        {
                            subObj.setKreditUser_double(noJurnal, row["KodePerkiraan"].ToString(), "Tutup Buku " + row["NamaPerkiraan"], Convert.ToDouble(row["DEBIT"]));
                            count51 += Convert.ToDouble(row["DEBIT"]);
                        }
                        subObj.setDebitSystem_double(noJurnal, "61121", "Ikhtisar Laba Rugi", count51);
                    }
                }
                

                /*Tutup Account 61*/
                dtTableTutupBuku = dbo.get_all(new String[] { "KodePerkiraan", "NamaPerkiraan", "DEBIT", "KREDIT", "YEAR" }, "view_saldo_61", "SALDO != 0 AND YEAR = '" + tahunanDTP.Value.Year.ToString() + "'", "", "", 0, 0);
                if (dtTableTutupBuku != null)
                {
                    if (dtTableTutupBuku.Rows.Count > 0)
                    {
                        sdrJurnalUmum = obj.InsertRow(DateTime.Today, "", "Tutup Buku");
                        while (sdrJurnalUmum.Read())
                        {
                            noJurnal = (string)sdrJurnalUmum["result"];
                        }

                        foreach (DataRow row in dtTableTutupBuku.Rows)
                        {
                            subObj.setKreditUser_double(noJurnal, row["KodePerkiraan"].ToString(), "Tutup Buku " + row["NamaPerkiraan"], Convert.ToDouble(row["DEBIT"]));
                            count61 += Convert.ToDouble(row["DEBIT"]);
                        }
                        subObj.setDebitSystem_double(noJurnal, "61121", "Ikhtisar Laba Rugi", count61);
                    }
                }
                


                /*Akumulasi ke Modal*/
                if ((count41 != 0) || (count51 != 0) || (count61 != 0))
                {
                    sdrJurnalUmum = obj.InsertRow(DateTime.Today, "", "Tutup Buku");
                    while (sdrJurnalUmum.Read())
                    {
                        noJurnal = (string)sdrJurnalUmum["result"];
                    }
                    total = count41 - count51 - count61;
                    if (total > 0)
                    {
                        subObj.setDebitSystem_double(noJurnal, "61121", "Ikhtisar Laba Rugi", total);
                        subObj.setKreditSystem_double(noJurnal, "31111", "Modal", total);
                    }
                    else
                    {
                        subObj.setDebitSystem_double(noJurnal, "31111", "Modal", total);
                        subObj.setKreditSystem_double(noJurnal, "61121", "Ikhtisar Laba Rugi", total);
                    }
                }
                
                /*Prive Dari Modal*/
                dtTableTutupBuku = dbo.get_all(new String[] { "KodePerkiraan", "NamaPerkiraan", "DEBIT", "KREDIT", "YEAR" }, "view_saldo_prive", "SALDO != 0 AND YEAR = '" + tahunanDTP.Value.Year.ToString() + "'", "", "", 0, 0);
                if (dtTableTutupBuku != null)
                {
                    if (dtTableTutupBuku.Rows.Count > 0)
                    {
                        sdrJurnalUmum = obj.InsertRow(DateTime.Today, "", "Tutup Buku");
                        while (sdrJurnalUmum.Read())
                        {
                            noJurnal = (string)sdrJurnalUmum["result"];
                        }
                        foreach (DataRow row in dtTableTutupBuku.Rows)
                        {
                            subObj.setKreditUser_double(noJurnal, row["KodePerkiraan"].ToString(), "Tutup Buku " + row["NamaPerkiraan"], Convert.ToDouble(row["DEBIT"]));
                            countPrive += Convert.ToDouble(row["DEBIT"]);
                        }

                        subObj.setDebitSystem_double(noJurnal, "31111", "Modal", countPrive);
                        subObj.setKreditSystem_double(noJurnal, "31121", "Prive", countPrive);
                    }
                }

                string spQuery = "";
            /*Proses Penambahan ke saldo awal*/
                SqlDataReader sdr = obj.getSaldoPerkiraan(tahunanDTP.Value.Year);
                while(sdr.Read())
                {
                    spQuery += "EXEC [dbo].[Account_Saldo_Update] '" + (string)sdr["KodePerkiraan"] + "'," + tahunanDTP.Value.Year + "," + (double)sdr["DEBIT"] + "," + (double)sdr["KREDIT"] + "; ";
                }
                
                dbo.run_query(spQuery);
            //}
        }

        private void changeSelector(RadioButton rb)
        {
            /*if(rb.Name.CompareTo("bulananRadBtn")==0)
            {
                bulananTrigger = true;
                bulananDTP.Enabled = true;
                tahunanDTP.Enabled = false;
            }
            else{
                bulananTrigger = false;
                bulananDTP.Enabled = false;
                tahunanDTP.Enabled = true;
            }*/
        }

        private void bulananRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            changeSelector((RadioButton)sender);
        }

        private void tahunanRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            changeSelector((RadioButton)sender);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close();
        }

        private void tahunanDTP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
