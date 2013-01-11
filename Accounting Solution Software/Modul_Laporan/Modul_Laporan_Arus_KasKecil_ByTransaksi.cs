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
    public partial class Modul_Laporan_Arus_KasKecil_ByTransaksi : Form
    {
        string noBukti = "";
        string saldo = "";
       // private Accounting_Solution_Software.Modul_Laporan.Laporan_Arus_KasKecil_ByTransaksi laporan_arus_kaskecil_bytransaksi = new Accounting_Solution_Software.Modul_Laporan.Laporan_Arus_KasKecil_ByTransaksi();

        public Modul_Laporan_Arus_KasKecil_ByTransaksi(string saldo,string noBukti)
        {
            InitializeComponent();
            this.noBukti = noBukti;
            this.saldo = saldo;
        }

        private void Modul_Laporan_Arus_KasKecil_ByTransaksi_Load(object sender, EventArgs e)
        {

        }

        public void showReport()
        {
            this.Show();
            //setReport(new String[] { "Saldo","@NoBukti" }, new String[] {this.saldo ,this.noBukti }, laporan_arus_kaskecil_bytransaksi);
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

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }



    }
}
