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
    public partial class Modul_Laporan_JurnalUmum : Form
    {
        private Accounting_Solution_Software.Modul_Laporan.Laporan_JurnalUmum laporan_jurnalumum = new Accounting_Solution_Software.Modul_Laporan.Laporan_JurnalUmum();

        public Modul_Laporan_JurnalUmum()
        {
            InitializeComponent();
        }

        private void setReport(string[] discretes, string[] values, ReportDocument reportSource)
        {
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

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
            setReport(new String[] { "DateFrom", "DateTo" }, new String[] { dateTimePicker5.Value.ToString(), dateTimePicker6.Value.ToString() }, laporan_jurnalumum);
        }


    }
}
