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
    public partial class Modul_Laporan_Pembelian : Form
    {
        private DbObject dbo = new DbObject();
        private Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_All PB_All = new Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_All();
        private Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_BySupplier PB_BySupp = new Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_BySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_Sub_All PB_Sub_All = new Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_Sub_All();
        private Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_Sub_ByKodeStock PB_Sub_ByKS = new Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_Sub_ByKodeStock();
        private Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_Sub_BySupplier PB_Sub_BySupp = new Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_Sub_BySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_Sub_byTransaksi PB_SubByKB = new Accounting_Solution_Software.Modul_Laporan.Pembelian.Laporan_Pembelian_Sub_byTransaksi();

        public Modul_Laporan_Pembelian()
        {
            InitializeComponent();
            rb1.Checked = true;
        }

        public Modul_Laporan_Pembelian(string NoId)
        {
            InitializeComponent();
            rb2.Checked = true;
            setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", "", "", "", "", "", NoId }, PB_SubByKB);
        }

        private void Modul_Laporan_Pembelian_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);
        }



        private void setReport(string[] discretes,string[] values,ReportDocument reportSource)
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
                    setReport(new String[] { "@flag","@Tgl", "@Tgl2", "@KdSupp", "@KdStock" , "@NoPOTB", "@NoBeli" }, new String[] { "p",dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), "","","" }, PB_All);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "", "" }, PB_All);
                }
                else if (cb2.Checked) // Cabang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "p", "", "", KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, PB_All);
                }
                else if ((!cb1.Checked) && (!cb2.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "p","","","","","","" }, PB_All);
                }
            }
            else if (rb2.Checked) // Sub Table
            {
                if (cb5.Checked) // No. Pembelian
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", "", "", "", "", "", noPembelianTxt.Text }, PB_SubByKB);
                }
                else if (cb4.Checked) // No. Terima Barang / No. Purchase Order
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", "", "", "", "", noPoTbTxt.Text, "" }, PB_SubByKB);
                }
                else if (cb1.Checked && cb2.Checked && cb3.Checked) // Tanggal , Supplier, Kode Stock
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), kodeStockTxt.Text, "", "" }, PB_Sub_BySupp);
                }
                else if (cb1.Checked && cb2.Checked) // Tanggal, Supplier
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, PB_Sub_BySupp);
                }
                else if (cb1.Checked && cb3.Checked) // Tanggal, Barang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", kodeStockTxt.Text, "", "" }, PB_Sub_ByKS);
                }
                else if (cb2.Checked && cb3.Checked) // Supplier , Barang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", "", "", KodeSupplierCmb.SelectedValue.ToString(), kodeStockTxt.Text, "", "" }, PB_Sub_BySupp);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "", "" }, PB_Sub_All);
                }
                else if (cb2.Checked) // Supplier
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", "", "", KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, PB_Sub_BySupp);
                }
                else if (cb3.Checked) // Barang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", "", "", "", kodeStockTxt.Text, "", "" }, PB_Sub_ByKS);
                }
                else if ((!cb1.Checked) && (!cb2.Checked) && (!cb3.Checked) && (!cb4.Checked) && (!cb5.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@NoPOTB", "@NoBeli" }, new String[] { "s", "", "", "", "", "", "" }, PB_Sub_All);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            generateReport();
        }


    }
}
