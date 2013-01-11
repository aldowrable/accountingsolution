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
    public partial class Modul_Laporan_ReturPembelian : Form
    {
        private DbObject dbo = new DbObject();
        private Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_All RB_All = new Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_All();
        private Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_BySupplier RB_All_bySupp = new Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_BySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_Sub_All RB_Sub_All = new Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_Sub_All();
        private Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_Sub_byKodeStock RB_Sub_KS = new Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_Sub_byKodeStock();
        private Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_Sub_bySupplier RB_Sub_KSupp = new Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_Sub_bySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_Sub_ByTransaksi RB_Sub_KR = new Accounting_Solution_Software.Modul_Laporan.Retur_Pembelian.Laporan_ReturPembelian_Sub_ByTransaksi();

        public Modul_Laporan_ReturPembelian()
        {
            InitializeComponent();
            rb1.Checked = true;
        }

        public Modul_Laporan_ReturPembelian(string NoId)
        {
            InitializeComponent();
            rb2.Checked = true;
            setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", "", "", "", "", "", NoId }, RB_Sub_KR);
        }


        private void Modul_Laporan_ReturPembelian_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);
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
                if (cb1.Checked && cb2.Checked)
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, RB_All);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "", "" }, RB_All);
                }
                else if (cb2.Checked) // Supplier
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "p", "", "", KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, RB_All);
                }
                else if ((!cb1.Checked) && (!cb2.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "p", "", "", "", "", "", "" }, RB_All);
                }
            }
            else if (rb2.Checked) // Sub Table
            {
                if (cb5.Checked) // No. Retur Pembelian
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", "", "", "", "", "", noReturBeliTxt.Text }, RB_Sub_KR);
                }
                else if (cb4.Checked) // No. Pembelian
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", "", "", "", "", noBeliTxt.Text, "" }, RB_Sub_KR);
                }
                else if (cb1.Checked && cb2.Checked && cb3.Checked) // Tanggal , Supplier, Kode Stock
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), kodeStockTxt.Text, "", "" }, RB_Sub_KSupp);
                }
                else if (cb1.Checked && cb2.Checked) // Tanggal, Supplier
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, RB_Sub_KSupp);
                }
                else if (cb1.Checked && cb3.Checked) // Tanggal, Barang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", kodeStockTxt.Text, "", "" }, RB_Sub_KS);
                }
                else if (cb2.Checked && cb3.Checked) // Supplier , Barang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", "", "", KodeSupplierCmb.SelectedValue.ToString(), kodeStockTxt.Text, "", "" }, RB_Sub_KSupp);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "", "" }, RB_Sub_All);
                }
                else if (cb2.Checked) // Supplier
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", "", "", KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, RB_Sub_KSupp);
                }
                else if (cb3.Checked) // Barang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", "", "", "", kodeStockTxt.Text, "", "" }, RB_Sub_KS);
                }
                else if ((!cb1.Checked) && (!cb2.Checked) && (!cb3.Checked) && (!cb4.Checked) && (!cb5.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoBeli", "@NoRB" }, new String[] { "s", "", "", "", "", "", "" }, RB_Sub_All);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            generateReport();
        }


     

    }
}
