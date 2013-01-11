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
    public partial class Modul_Laporan_Transfer_stock : Form
    {
        private Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_Stock S_All = new Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_Stock();
        private Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_Kartu_Stock_All KS_All = new Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_Kartu_Stock_All();
        private Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_Kartu_Stock_byCabang KS_ByCbg = new Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_Kartu_Stock_byCabang();
        private Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_Kartu_Stock_byProduck KS_ByKS = new Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_Kartu_Stock_byProduck();
        private Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_kartu_stock_byProduk_byCabang KS_ByKS_ByCbg = new Accounting_Solution_Software.Modul_Laporan.Stock.Laporan_kartu_stock_byProduk_byCabang();

        private DbObject dbo = new DbObject();

        public Modul_Laporan_Transfer_stock()
        {
            InitializeComponent();
            set_cabang_cmb();
        }

        private void Modul_Laporan_Stock_Load(object sender, EventArgs e)
        {
        }

        private void set_cabang_cmb()
        {
            String[] fields = new String[] { "id", "nama" };
            DataTable dt = dbo.get_all(fields, "gudang", "", "", "", 0, 0);
            var items1 = new BindingList<KeyValuePair<string, string>>();

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {
                items1.Add(new KeyValuePair<string, string>(row["id"].ToString(), row["nama"].ToString()));
            }

            cbgCMB.DataSource = items1;
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

            crv.ReportSource = reportSource;
            crv.Refresh();

        }

        private void generateReport()
        {
            if (rb1.Checked) // Kartu Stock
            {
                if (cb1.Checked && cb2.Checked && cb2.Checked)
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), kodeStockTxt.Text, cbgCMB.SelectedValue.ToString() }, KS_ByKS_ByCbg);
                }
                else if (cb1.Checked && cb2.Checked)// Tanggal , Kode Stock
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), kodeStockTxt.Text,""}, KS_ByKS);
                }
                else if (cb1.Checked && cb3.Checked)// Tanggal , Cabang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", cbgCMB.SelectedValue.ToString() }, KS_ByCbg);
                }
                else if (cb2.Checked && cb3.Checked)// Kode Stock, Cabang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "p", "", "", kodeStockTxt.Text, cbgCMB.SelectedValue.ToString() }, KS_ByKS_ByCbg);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "" }, KS_All);
                }
                else if (cb2.Checked) // Kode Stock
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "p", "", "", kodeStockTxt.Text, "" }, KS_ByKS);
                }
                else if (cb3.Checked) // Cabang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "p", "", "", "", cbgCMB.SelectedValue.ToString() }, KS_ByCbg);
                }
                else if ((!cb1.Checked) && (!cb2.Checked) && (!cb3.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "p", "", "", "", "" }, KS_All);
                }
            }
            else if (rb2.Checked) // Laporan Stock
            {
                if (cb3.Checked) // Cabang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "s", "", "", "", cbgCMB.SelectedValue.ToString() }, S_All);
                }
                else if (!cb1.Checked)
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@kdStck", "@IdCbg" }, new String[] { "s", "", "", "", "" }, S_All);
                }
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            generateReport();
        }

    }
}
