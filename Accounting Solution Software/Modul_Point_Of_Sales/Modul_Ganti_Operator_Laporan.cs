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
    public partial class Modul_Ganti_Operator_Laporan : Form
    {
        private Login login = null;
        private tb_Login tbLogin = new tb_Login();
        private AllFunc allfunc = new AllFunc();
        private Modul_POS pos = null;
        private Modul_POS_Resep_Dokter resep = null;
        
        public Modul_Ganti_Operator_Laporan(Modul_POS pos,Modul_POS_Resep_Dokter resep, Login login)
        {
            InitializeComponent();

            if (pos!=null)
            {
                this.pos = pos;
            }
            else if(resep !=null)
            {
                this.resep = resep;
            }

            this.login = login;
            DbObject dbo = new DbObject();
            SqlDataReader sdr = null;
            namaOperatorTxt.Text = login.username;
            SqlDataReader sdr0 = dbo.get_single_data(new string[]{"JamMulai"},"Username",login.username,"login");
            while (sdr0.Read())
            {
                DateTime jamMulai = (DateTime)sdr0["JamMulai"];
                jamMulaiDateTimePicker.Value = Convert.ToDateTime(jamMulai.ToString("HH:mm"));
            }

            jamSelesaiDateTimePicker.Value = Convert.ToDateTime(DateTime.Now.ToString("HH:mm"));
            var timeDiff = new TimeSpan(jamSelesaiDateTimePicker.Value.Ticks - jamMulaiDateTimePicker.Value.Ticks);
            lamaBertugasTxt.Text = timeDiff.Hours.ToString();
            sdr = tbLogin.getPendapatanObat(DateTime.Today, login.username);
            if (sdr.HasRows)
            {
                while ( sdr.Read())
                {
                    if (sdr["JumlahOmset"]!=DBNull.Value)
                    {
                        setDataGrid(new string[] { (string)sdr["NamaKelompok"], allfunc.digit_separated(Convert.ToString((double)sdr["JumlahOmset"])) });
                    }
                    else
                    {
                        setDataGrid(new string[] { (string)sdr["NamaKelompok"], "0" });
                    }
                    
                }
            }
            SqlDataReader sdr1 = null;
            sdr1 = tbLogin.getPendapatanJasa(DateTime.Today, login.username);
            if (sdr1.HasRows)
            {
                while (sdr1.Read())
                {
                    if (sdr1["JumlahOmset"] != DBNull.Value)
                    {
                        setDataGrid(new string[] { (string)sdr1["NamaKelompok"], allfunc.digit_separated(Convert.ToString((double)sdr1["JumlahOmset"])) });
                    }
                    else
                    {
                        setDataGrid(new string[] { (string)sdr1["NamaKelompok"], "0" });
                    }

                }
            }
            SqlDataReader sdr2 = null;
            sdr2 = tbLogin.getPendapatanResep(DateTime.Today, login.username);
            if (sdr2.HasRows)
            {
                while (sdr2.Read())
                {
                    if (sdr2["JumlahOmset"] != DBNull.Value)
                    {
                        setDataGrid(new string[] { (string)sdr2["NamaKelompok"], allfunc.digit_separated(Convert.ToString((double)sdr2["JumlahOmset"])) });
                    }
                    else
                    {
                        setDataGrid(new string[] { (string)sdr2["NamaKelompok"], "0" });
                    }

                }
            }

            SqlDataReader sdr3 = null;
            sdr3 = tbLogin.getPendapatanPiutang(DateTime.Today, login.username);
            if (sdr3.HasRows)
            {
                while (sdr3.Read())
                {
                    if (sdr3["JumlahOmset"] != DBNull.Value)
                    {
                        setDataGridPiutang(new string[] { (string)sdr3["NamaPelanggan"], allfunc.digit_separated(Convert.ToString((double)sdr3["JumlahOmset"])) });
                    }
                    else
                    {
                        setDataGridPiutang(new string[] { (string)sdr3["NamaPelanggan"], "0" });
                    }

                }
            }

            SqlDataReader sdr4 = null;
            sdr4 = tbLogin.getPendapatanAll(DateTime.Today, login.username);
            if (sdr4.HasRows)
            {
                while (sdr4.Read())
                {
                    if (sdr4["TotalOmset"] != DBNull.Value)
                    {
                        totalOmsetTxt.Text = allfunc.digit_separated(Convert.ToString((double)sdr4["TotalOmset"]));
                    }
                    else
                    {
                        totalOmsetTxt.Text = "0";
                    }

                }
            }
        }

        private void setDataGrid(string[] arr)
        {
            kelompokOmsetDataGridView.Rows.Add(arr);
        }

        private void setDataGridPiutang(string[] arr)
        {
            piutangDataGridView.Rows.Add(arr);
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            close();
        }

        private void close()
        {
            this.Close();
            this.Dispose();
        }

        private void cetakBtn_Click(object sender, EventArgs e)
        {
                if (jumlahKasTxt.Text.CompareTo("") == 0)
                {
                    double total = Convert.ToDouble(totalOmsetTxt.Text) + Convert.ToDouble(allfunc.remove_separated(kasAwalTxt.Text));
                    jumlahKasTxt.Text = allfunc.digit_separated(Convert.ToString(total));
                }
                DbObject dbo = new DbObject();
                double penjualanTunai = 0.0;
                Jual jual = new Jual();
                try
                {
                    SqlDataReader sdr = jual.getJualTunai(DateTime.Today, login.username);
                    while (sdr.Read())
                    {
                        penjualanTunai = (double)sdr["nominal"];
                    }
                }
                catch (InvalidCastException ice_e)
                {
                    penjualanTunai = 0.0;
                }

                StrukPrint print = new StrukPrint();
                print.printLaporanGantiOperatorDirectPrint("", login.username, jamMulaiDateTimePicker.Value, jamSelesaiDateTimePicker.Value, kelompokOmsetDataGridView, piutangDataGridView, Convert.ToDouble(allfunc.remove_separated(totalOmsetTxt.Text)), Convert.ToDouble(allfunc.remove_separated(kasAwalTxt.Text)), penjualanTunai); 
            //print.printLaporanGantiOperator("",login.username,jamMulaiDateTimePicker.Value,jamSelesaiDateTimePicker.Value,kelompokOmsetDataGridView,piutangDataGridView,Convert.ToDouble(allfunc.remove_separated(totalOmsetTxt.Text)),Convert.ToDouble(allfunc.remove_separated(kasAwalTxt.Text)),penjualanTunai);
                login.logout();
                this.Visible = false;
                if (pos != null)
                {
                    pos.Close();
                }
                else if (resep != null)
                {
                    resep.Close();
                }
            
        }

        private void kasAwalTxt_TextChanged(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(totalOmsetTxt.Text) + Convert.ToDouble(allfunc.remove_separated(kasAwalTxt.Text));
            jumlahKasTxt.Text = allfunc.digit_separated(Convert.ToString(total));
        }

        private void kasAwalTxt_Enter(object sender, EventArgs e)
        {
            kasAwalTxt.Text = allfunc.remove_separated(kasAwalTxt.Text);
        }

        private void kasAwalTxt_Leave(object sender, EventArgs e)
        {
            kasAwalTxt.Text = allfunc.digit_separated(kasAwalTxt.Text);
        }
    }
}
