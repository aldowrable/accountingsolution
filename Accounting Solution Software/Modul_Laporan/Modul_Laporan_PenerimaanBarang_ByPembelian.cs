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
    public partial class Modul_Laporan_PenerimaanBarang_ByPembelian : Form
    {
        string NoPembelian = "";
        //private Accounting_Solution_Software.Modul_Laporan.Laporan_PenerimaanBarang_byPembelian laporan_penerimaanbarang_bypembelian = new Accounting_Solution_Software.Modul_Laporan.Laporan_PenerimaanBarang_byPembelian();

        public Modul_Laporan_PenerimaanBarang_ByPembelian(string NoPembelian)
        {
            InitializeComponent();
            this.NoPembelian = NoPembelian;
        }

        private void Modul_Laporan_PenerimaanBarang_ByPembelian_Load(object sender, EventArgs e)
        {

        }

        public void showReport()
        {
            this.Show();
            //setReport(new String[] { "NoPembelian" }, new String[] { this.NoPembelian }, laporan_penerimaanbarang_bypembelian);
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

            crystalReportViewer1.ReportSource = reportSource;
            crystalReportViewer1.Refresh();

        }
    }
}
