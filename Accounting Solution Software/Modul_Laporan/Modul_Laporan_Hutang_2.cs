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
    public partial class Modul_Laporan_Hutang : Form
    {
        private DbObject dbo = new DbObject();
        private Accounting_Solution_Software.Modul_Laporan.Utang.Laporan_Hutang_All H_All = new Accounting_Solution_Software.Modul_Laporan.Utang.Laporan_Hutang_All();
        private Accounting_Solution_Software.Modul_Laporan.Utang.Laporan_Hutang_BySupplier H_BySupp = new Accounting_Solution_Software.Modul_Laporan.Utang.Laporan_Hutang_BySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Utang.Laporan_KartuHutang_All KH_All = new Accounting_Solution_Software.Modul_Laporan.Utang.Laporan_KartuHutang_All();

        public Modul_Laporan_Hutang()
        {
            InitializeComponent();
            rb1.Checked = true;
        }

        //public Modul_Laporan_Hutang(string NoId)
        //{
        //    InitializeComponent();
        //    rb2.Checked = true;
        //    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp"}, new String[] { "s", "", "", "", "", "", NoId }, PB_SubByKB);
        //}


        private void Modul_Laporan_Hutang_Load(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            generateReport();
        }
        private void generateReport()
        {
            if (rb1.Checked) // Parent Table
            {
                if (cb1.Checked && cb2.Checked)
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString() }, H_BySupp);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "" }, H_All);
                }
                else if (cb2.Checked) // Supplier
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp"}, new String[] { "p", "", "", KodeSupplierCmb.SelectedValue.ToString()}, H_BySupp);
                }
                else if ((!cb1.Checked) && (!cb2.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { "p", "", "", "" }, H_All);
                }
            }
            else if (rb2.Checked) // Sub Table
            {
                if (cb1.Checked && cb2.Checked)
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString() }, KH_All);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "" }, H_All);
                }
                else if (cb2.Checked) // Supplier
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { "s", "", "", KodeSupplierCmb.SelectedValue.ToString() }, KH_All);
                }
                else if ((!cb1.Checked) && (!cb2.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp" }, new String[] { "s", "", "", "" }, H_All);
                }
            }
        }

        


    }
}
