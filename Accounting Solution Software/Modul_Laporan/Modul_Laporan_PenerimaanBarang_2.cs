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
    public partial class Modul_Laporan_PenerimaanBarang : Form
    {
        private DbObject dbo = new DbObject();
        private Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_All PB_All = new Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_All();
        private Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_bySupplier PB_BySupp = new Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_bySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_Sub_All PB_Sub_All = new Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_Sub_All();
        private Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_Sub_bySupplier PB_Sub_bySupp = new Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_Sub_bySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_Sub_byPO PB_Sub_byPO = new Accounting_Solution_Software.Modul_Laporan.Penerimaan_Barang.Laporan_PenerimaanBarang_Sub_byPO();
        
        public Modul_Laporan_PenerimaanBarang()
        {
            InitializeComponent();
        }

        public Modul_Laporan_PenerimaanBarang(string NoId)
        {
            InitializeComponent();
            setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp", "@NoPO", "@NoTB" }, new String[] { "", "", "", "", NoId }, PB_Sub_byPO);
        }

        private void Modul_Laporan_PenerimaanBarang_Load(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            generateReport();
        }


        private void generateReport()
        {
            if (rb1.Checked) // Parent Table
            {
                if (cb1.Checked && cb2.Checked)
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { dtp1.Text.ToString(), dtp2.Text.ToString(), kodeSupplierCmb.SelectedValue.ToString() }, PB_All);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { dtp1.Text, dtp2.Text, "" }, PB_All);
                }
                else if(cb2.Checked) // Supplier
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { "","",kodeSupplierCmb.SelectedValue.ToString() }, PB_All);
                }
                else if ((!cb1.Checked)&&(!cb2.Checked))
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { "","","" }, PB_All);
                }
            }
            else if(rb2.Checked) // Sub Table
            {
                if (cb3.Checked) // No. PO
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp", "@NoPO", "@NoTB" }, new String[] { "", "", "", NoPOTxt.Text, "" }, PB_Sub_byPO);
                }
                else if (cb4.Checked) // No. Penerimaan
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp", "@NoPO", "@NoTB" }, new String[] { "", "", "", "", NoTerimaBarangTxt.Text }, PB_Sub_byPO);
                }
                else if (cb1.Checked && cb2.Checked)
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp", "@NoPO", "@NoTB" }, new String[] { dtp1.Text, dtp2.Text, kodeSupplierCmb.SelectedValue.ToString(),"","" }, PB_Sub_bySupp);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp", "@NoPO", "@NoTB" }, new String[] { dtp1.Text, dtp2.Text, "", "", "" }, PB_Sub_All);
                }
                else if (cb2.Checked) // Supplier
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp", "@NoPO", "@NoTB" }, new String[] { "", "", kodeSupplierCmb.SelectedValue.ToString(), "", "" }, PB_Sub_bySupp);
                }
                else if ((!cb1.Checked) && (!cb2.Checked) && (!cb3.Checked) && (!cb4.Checked))
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@KdSupp", "@NoPO", "@NoTB" }, new String[] { "", "", "", "", ""}, PB_Sub_All);
                }
            }
        }

    }
}
