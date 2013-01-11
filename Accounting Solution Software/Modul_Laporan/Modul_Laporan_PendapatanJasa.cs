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
    public partial class Modul_Laporan_PendapatanJasa : Form
    {
        private Accounting_Solution_Software.Modul_Laporan.Laporan_PendapatanJasa_byDokter laporan_PendapatanJasa_byDokter = new Accounting_Solution_Software.Modul_Laporan.Laporan_PendapatanJasa_byDokter();
        private Accounting_Solution_Software.Modul_Laporan.Laporan_PendapatanJasa_All laporan_PendapatanJasa_All = new Accounting_Solution_Software.Modul_Laporan.Laporan_PendapatanJasa_All();
        
        public Modul_Laporan_PendapatanJasa()
        {
            InitializeComponent();
            panel2.Enabled = true;
            panel4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setReport(new String[] { "DateFrom", "DateTo" }, new String[] { dtp1from.Value.ToString(), dtp1to.Value.ToString() }, laporan_PendapatanJasa_All);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setReport(new String[] { "DateFrom", "DateTo", "KodeDokter" }, new String[] { dtp2from.Value.ToString(), dtp2to.Value.ToString(), comboBox1.SelectedValue.ToString() }, laporan_PendapatanJasa_byDokter);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            changeRadioBtn(sender);
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            changeRadioBtn(sender);
        }

        private void changeRadioBtn(Object radioBtn)
        {
            radioButton3.Checked = false;
            panel2.Enabled = false;
            radioButton4.Checked = false;
            panel4.Enabled = false;

            if (radioButton3.Equals(radioBtn))
            {
                panel2.Enabled = true;
                radioButton3.Checked = true;
            }
            else if (radioButton4.Equals(radioBtn))
            {
                panel4.Enabled = true;
                radioButton4.Checked = true;
            }

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

            crystalReportViewer2.ReportSource = reportSource;
            crystalReportViewer2.Refresh();

        }

        private void Modul_Laporan_PendapatanJasa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Dokter' table. You can move, or remove it, as needed.
            this.dokterTableAdapter.Fill(this.master_Data.Dokter);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
