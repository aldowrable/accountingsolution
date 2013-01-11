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
    public partial class Modul_Laporan_Transfer_Stock_2 : Form
    {
        private DbObject dbo = new DbObject();
        private Accounting_Solution_Software.Modul_Laporan.Perpindahan_Barang.Laporan_PerpindahanBarang_All PB_All = new Accounting_Solution_Software.Modul_Laporan.Perpindahan_Barang.Laporan_PerpindahanBarang_All();
        private Accounting_Solution_Software.Modul_Laporan.Perpindahan_Barang.Laporan_PerpindahanBarang_Sub_All PB_Sub_All = new Accounting_Solution_Software.Modul_Laporan.Perpindahan_Barang.Laporan_PerpindahanBarang_Sub_All();
        private Accounting_Solution_Software.Modul_Laporan.Perpindahan_Barang.Laporan_PerpindahanBarang_Sub_byKodeStock PB_Sub_byKS = new Accounting_Solution_Software.Modul_Laporan.Perpindahan_Barang.Laporan_PerpindahanBarang_Sub_byKodeStock();
        private Accounting_Solution_Software.Modul_Laporan.Perpindahan_Barang.Laporan_PerpindahanBarang_Sub_byTransaksi PB_Sub_byKP = new Accounting_Solution_Software.Modul_Laporan.Perpindahan_Barang.Laporan_PerpindahanBarang_Sub_byTransaksi();


        public Modul_Laporan_Transfer_Stock_2()
        {
            InitializeComponent();
            set_cabang_cmb();
            rb1.Checked = true;
        }

        public Modul_Laporan_Transfer_Stock_2(string NoId)
        {
            InitializeComponent();
            set_cabang_cmb();
            rb2.Checked = true;
            setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom","@CbgTo", "@KdStock", "@NoPB" }, new String[] { "", "", "", "","", NoId}, PB_Sub_byKP);

        }

        private void set_cabang_cmb()
        {
            String[] fields = new String[] { "id", "nama" };
            DataTable dt = dbo.get_all(fields, "gudang", "", "", "", 0, 0);
            var items1 = new BindingList<KeyValuePair<string, string>>();
            var items2 = new BindingList<KeyValuePair<string, string>>();

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {
                items1.Add(new KeyValuePair<string, string>(row["id"].ToString(), row["nama"].ToString()));
                items2.Add(new KeyValuePair<string, string>(row["id"].ToString(), row["nama"].ToString()));
            }

            items1.Add(new KeyValuePair<string, string>("", "Semua Cabang"));
            items2.Add(new KeyValuePair<string, string>("", "Semua Cabang"));

            cbgFrmCMB.DataSource = items1;
            cbgFrmCMB.ValueMember = "Key";
            cbgFrmCMB.DisplayMember = "Value";

            cbgToCMB.DataSource = items2;
            cbgToCMB.ValueMember = "Key";
            cbgToCMB.DisplayMember = "Value";
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
                if (cb1.Checked && cb3.Checked)
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo" }, new String[] { dtp1.Text.ToString(), dtp2.Text.ToString(), cbgFrmCMB.SelectedValue.ToString(), cbgToCMB.SelectedValue.ToString() }, PB_All);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo" }, new String[] { dtp1.Text, dtp2.Text, "", "" }, PB_All);
                }
                else if (cb3.Checked) // Cabang
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo" }, new String[] { "", "", cbgFrmCMB.SelectedValue.ToString(), cbgToCMB.SelectedValue.ToString() }, PB_All);
                }
                else if ((!cb1.Checked) && (!cb3.Checked))
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo" }, new String[] { "", "", "", "" }, PB_All);
                }
            }
            else if (rb2.Checked) // Sub Table
            {
                if (cb4.Checked) // No. Perpindahan Barang
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo", "@KdStock", "@NoPB" }, new String[] { "", "", "", "", "", noPerpindahanTxt.Text }, PB_Sub_byKP);
                }
                else if (cb1.Checked && cb2.Checked && cb3.Checked) // Tanggal , Kode Stock, Cabang
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo", "@KdStock", "@NoPB" }, new String[] { dtp1.Text, dtp2.Text, cbgFrmCMB.SelectedValue.ToString(), cbgToCMB.SelectedValue.ToString(), kodeStockTxt.Text, "" }, PB_Sub_byKS);
                }
                else if (cb1.Checked && cb2.Checked) // Tanggal, Kode Stock
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo", "@KdStock", "@NoPB" }, new String[] { dtp1.Text, dtp2.Text, "", "", kodeStockTxt.Text, "" }, PB_Sub_byKS);
                }
                else if (cb1.Checked && cb3.Checked) // Tanggal , Cabang
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo", "@KdStock", "@NoPB" }, new String[] { dtp1.Text, dtp2.Text, cbgFrmCMB.SelectedValue.ToString(), cbgToCMB.SelectedValue.ToString(), "", "" }, PB_Sub_All);
                }
                else if (cb2.Checked && cb3.Checked) // Kode Stock , Cabang
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo", "@KdStock", "@NoPB" }, new String[] { "", "", cbgFrmCMB.SelectedValue.ToString(), cbgToCMB.SelectedValue.ToString(), kodeStockTxt.Text, "" }, PB_Sub_All);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo", "@KdStock", "@NoPB" }, new String[] { dtp1.Text, dtp2.Text, "", "", "", "" }, PB_Sub_All);
                }
                else if (cb2.Checked) // Kode Stock
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo", "@KdStock", "@NoPB" }, new String[] { "", "", "", "", kodeStockTxt.Text, "" }, PB_Sub_byKS);
                }
                else if (cb3.Checked) // Cabang
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo", "@KdStock", "@NoPB" }, new String[] { "", "", cbgFrmCMB.SelectedValue.ToString(), cbgToCMB.SelectedValue.ToString(), "", "" }, PB_Sub_All);
                }
                else if ((!cb1.Checked) && (!cb2.Checked) && (!cb3.Checked) && (!cb4.Checked))
                {
                    setReport(new String[] { "@Tgl", "@Tgl2", "@CbgFrom", "@CbgTo", "@KdStock", "@NoPB" }, new String[] { "", "", "", "", "", "" }, PB_Sub_All);
                }
            }
        }

        private void kodeStockTxt_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
