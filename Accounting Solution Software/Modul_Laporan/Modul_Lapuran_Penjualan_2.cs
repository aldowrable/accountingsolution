using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Accounting_Solution_Software
{
    public partial class Modul_Lapuran_Penjualan : Form
    {

        private DbObject dbo = new DbObject();
        private Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_All J_All = new Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_All();
        private Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_ByCabang J_ByCbg = new Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_ByCabang();
        private Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_All J_Sub_All = new Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_All();
        private Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_ByCabang J_Sub_ByCbg = new Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_ByCabang();
        private Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_ByCabang_ByKodeStock J_Sub_ByCbg_ByKdStck = new Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_ByCabang_ByKodeStock();
        private Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_ByStock J_Sub_ByKdStck = new Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_ByStock();
        private Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_ByTransaksi J_Sub_ByTrans = new Accounting_Solution_Software.Modul_Laporan.Jual.Laporan_Penjualan_Sub_ByTransaksi();

        public Modul_Lapuran_Penjualan()
        {
            InitializeComponent();
            rb1.Checked = true;
        }

        public Modul_Lapuran_Penjualan(string NoId)
        {
            InitializeComponent();
            rb2.Checked = true;
            //setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", "", "", "", "", "", NoId }, PB_SubByKB);
        }

        private void Modul_Lapuran_Penjualan_Load(object sender, EventArgs e)
        {
            this.loginTableAdapter.Fill(this.login_Data.Login);
            set_cabang_cmb();
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

            cbgCMB.DataSource = items3;
            cbgCMB.ValueMember = "Key";
            cbgCMB.DisplayMember = "Value";
        }

        private void setReport(string[] discretes, string[] values, ReportDocument reportSource)
        {
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            reportSource.SetDatabaseLogon(dbo.getDatabaseInformationLogon()[2], dbo.getDatabaseInformationLogon()[3], dbo.getDatabaseInformationLogon()[0], dbo.getDatabaseInformationLogon()[1]);

            for (int i = 0; i < discretes.Length; i++)
            {
                crParameterDiscreteValue.Value = values[i];
                crParameterFieldDefinitions = reportSource.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions[discretes[i]];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            }

            crv1.ReportSource = reportSource;
            crv1.Refresh();

        }

        private void generateReport()
        {
            if (rb1.Checked) // Parent Table
            {
                if (cb1.Checked && cb2.Checked) // Tanggal, Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "" }, J_All);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(),cbgCMB.SelectedValue.ToString(),"" , "" }, J_ByCbg);
                    }
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "" }, J_All);
                }
                else if (cb2.Checked) // Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "p", "", "", "", "", "" }, J_All);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "p", "", "", cbgCMB.SelectedValue.ToString(),"" , "" }, J_ByCbg);
                    }
                }
                else if ((!cb1.Checked) && (!cb2.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "p", "", "", "", "", "", "" }, J_All);
                }
            }
            else if (rb2.Checked) // Sub Table
            {
                if (cb4.Checked) // No. Nota
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", "", "", "", "", txtNoNota.Text}, J_Sub_ByTrans);
                }
                else if (cb1.Checked && cb2.Checked && cb3.Checked) // Tanggal , Kode Stock, Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", TxtKodeStock.Text, "" }, J_Sub_ByKdStck);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(),cbgCMB.SelectedValue.ToString(), TxtKodeStock.Text, "" }, J_Sub_ByCbg_ByKdStck);
                    }
                }
                else if (cb1.Checked && cb2.Checked) // Tanggal, Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "" }, J_Sub_All);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(),cbgCMB.SelectedValue.ToString(), "", "" }, J_Sub_ByCbg);
                    }
                }
                else if (cb2.Checked && cb3.Checked) // Kode Stock , Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", "", "", "", TxtKodeStock.Text, "" }, J_Sub_ByKdStck);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", "", "", cbgCMB.SelectedValue.ToString(), TxtKodeStock.Text, "" }, J_Sub_ByCbg_ByKdStck);
                    }
                }
                else if (cb1.Checked && cb3.Checked) // Tanggal, Kode Stock
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", TxtKodeStock.Text, "" }, J_Sub_ByKdStck);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "" }, J_Sub_All);
                }
                else if (cb2.Checked) // Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", "", "", "", "", "" }, J_Sub_All);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", "", "", cbgCMB.SelectedValue.ToString(), "", "" }, J_Sub_ByCbg);
                    }
                }
                else if (cb3.Checked) // Kode Stock
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", "", "", "", TxtKodeStock.Text, "" }, J_Sub_ByKdStck);
                }
                else if ((!cb1.Checked) && (!cb2.Checked) && (!cb3.Checked) && (!cb4.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@IdCbg", "@KdStock", "@NoBon" }, new String[] { "s", "", "", "", "", "" }, J_Sub_All);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            generateReport();
        }


    }
}
