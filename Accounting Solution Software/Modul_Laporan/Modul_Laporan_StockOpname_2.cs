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
    public partial class Modul_Laporan_StockOpname : Form
    {
        private DbObject dbo = new DbObject();
        private Accounting_Solution_Software.Modul_Laporan.Stock_Opname.Laporan_StockOpname_All SO_All = new Accounting_Solution_Software.Modul_Laporan.Stock_Opname.Laporan_StockOpname_All();
        private Accounting_Solution_Software.Modul_Laporan.Stock_Opname.Laporan_StockOpname_Sub_All SO_Sub_All = new Accounting_Solution_Software.Modul_Laporan.Stock_Opname.Laporan_StockOpname_Sub_All();
        private Accounting_Solution_Software.Modul_Laporan.Stock_Opname.Laporan_StockOpname_Sub_byKodeStock SO_Sub_ByKS = new Accounting_Solution_Software.Modul_Laporan.Stock_Opname.Laporan_StockOpname_Sub_byKodeStock();
        private Accounting_Solution_Software.Modul_Laporan.Stock_Opname.Laporan_StockOpname_Sub_ByTransaksi SO_Sub_ByKSO = new Accounting_Solution_Software.Modul_Laporan.Stock_Opname.Laporan_StockOpname_Sub_ByTransaksi();


        public Modul_Laporan_StockOpname()
        {
            InitializeComponent();
        }

        public Modul_Laporan_StockOpname(string NoId)
        {
            InitializeComponent();
            rb1.Checked = true;
            setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdStock", "@NoSO" }, new String[] { "s", "", "", "", NoId }, SO_Sub_ByKSO);
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
            if (rb1.Checked) // Parent Table
            {
                if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdStock", "@NoSO" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "", "" }, SO_All);
                }
                else
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdStock", "@NoSO" }, new String[] { "p", "", "", "", "", "", "" }, SO_All);
                }
            }
            else if (rb2.Checked) // Sub Table
            {
                if (cb3.Checked) // No. Stock Opname
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdStock", "@NoSO" }, new String[] { "s", "", "", "", noSOTxt.Text }, SO_Sub_ByKSO);
                }
                else if (cb1.Checked && cb2.Checked) // Tanggal, Stock
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdStock", "@NoSO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), kodeStockTxt.Text, "" }, SO_Sub_ByKS);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdStock", "@NoSO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "" }, SO_Sub_All);
                }
                else if (cb2.Checked) // Stock
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdStock", "@NoSO" }, new String[] { "s", "", "", kodeStockTxt.Text, "" }, SO_Sub_ByKS);
                }
                else if ((!cb1.Checked) && (!cb2.Checked) && (!cb3.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdStock", "@NoSO" }, new String[] { "s", "", "", "", "" }, SO_Sub_All);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            generateReport();
        }
    }
}
