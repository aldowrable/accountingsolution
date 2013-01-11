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
    public partial class Modul_Laporan_Piutang : Form
    {
        private Accounting_Solution_Software.Modul_Laporan.Laporan_Piutang_All laporan_piutang_all = new Accounting_Solution_Software.Modul_Laporan.Laporan_Piutang_All();
        private Accounting_Solution_Software.Modul_Laporan.Laporan_Piutang_ByCustomer laporan_piutang_bysupplier = new Accounting_Solution_Software.Modul_Laporan.Laporan_Piutang_ByCustomer();


        public Modul_Laporan_Piutang()
        {
            InitializeComponent();
            panel14.Enabled = true;
            panel16.Enabled = false;
        }

        private void Modul_Laporan_Piutang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.master_Data.Customer);

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

        private void button9_Click(object sender, EventArgs e)
        {
            setReport(new String[] { "DateFrom", "DateTo", "KodePelanggan" }, new String[] { dateTimePicker7.Value.ToString(), dateTimePicker8.Value.ToString(), comboBox3.SelectedValue.ToString() }, laporan_piutang_bysupplier);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            setReport(new String[] { "DateFrom", "DateTo" }, new String[] { dateTimePicker5.Value.ToString(), dateTimePicker6.Value.ToString() }, laporan_piutang_all);
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            changeRadioBtn(sender);
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            changeRadioBtn(sender);
        }

        private void changeRadioBtn(Object radioBtn)
        {
            radioButton8.Checked = false;
            panel14.Enabled = false;
            radioButton9.Checked = false;
            panel16.Enabled = false;


            if (radioButton8.Equals(radioBtn))
            {
                panel14.Enabled = true;
                radioButton8.Checked = true;
            }
            else if (radioButton9.Equals(radioBtn))
            {
                panel16.Enabled = true;
                radioButton9.Checked = true;
            }

        }


    }
}
