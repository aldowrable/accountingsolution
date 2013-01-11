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
    public partial class Modul_Laporan_BukuBesar : Form
    {
        private DbObject dbo = new DbObject();
        private Accounting_Solution_Software.Modul_Laporan.Akuntansi.Laporan_BukuBesar BB = new Accounting_Solution_Software.Modul_Laporan.Akuntansi.Laporan_BukuBesar();

        public Modul_Laporan_BukuBesar()
        {
            InitializeComponent();
        }

        private void Modul_Laporan_BukuBesar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'view.view_kelompok_account_lengkap' table. You can move, or remove it, as needed.
            this.view_kelompok_account_lengkapTableAdapter.Fill(this.view.view_kelompok_account_lengkap);
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

            crystalReportViewer3.ReportSource = reportSource;
            crystalReportViewer3.Refresh();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            setReport(new String[] { "@Tgl", "@Tgl2", "@NoPerkiraan" }, new String[] { dtp1.Text.ToString(), dtp2.Text.ToString(),cmbKodePerkiraan.SelectedValue.ToString() }, BB);
 
        }

    }
}
