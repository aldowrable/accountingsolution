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
    public partial class Modul_Laporan_Arus_KasKecil : Form
    {
        private Accounting_Solution_Software.Modul_Laporan.Arus_Kas.Laporan_Arus_KasBesar AKB = new Accounting_Solution_Software.Modul_Laporan.Arus_Kas.Laporan_Arus_KasBesar();
        private Accounting_Solution_Software.Modul_Laporan.Arus_Kas.Laporan_Arus_KasKecil AKK = new Accounting_Solution_Software.Modul_Laporan.Arus_Kas.Laporan_Arus_KasKecil();
        private Accounting_Solution_Software.Modul_Laporan.Arus_Kas.Laporan_Arus_KasKecil_ByTransaksi AKK_NB = new Accounting_Solution_Software.Modul_Laporan.Arus_Kas.Laporan_Arus_KasKecil_ByTransaksi();
        private DbObject dbo = new DbObject();

        public Modul_Laporan_Arus_KasKecil()
        {
            InitializeComponent();
            rb1.Checked = true;
        }

        public Modul_Laporan_Arus_KasKecil(string NoId)
        {
            InitializeComponent();
            rb2.Checked = true;
            setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@NoBukti" }, new String[] { "s", "", "", NoId }, AKK_NB);
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
            if (rb1.Checked) // Arus Kas Besar
            {
                if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@NoBukti" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "" }, AKB);
                }
                else if (!cb1.Checked)
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@NoBukti" }, new String[] { "p", "", "", "" }, AKB);
                }
            }
            else if (rb2.Checked) // Arus Kas Kecil
            {
                if (cb1.Checked && cb2.Checked)
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@NoBukti" }, new String[] { "s", "", "", txtNoBukti.ToString() }, AKK_NB);
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@NoBukti" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "" }, AKK);
                }
                else if (cb2.Checked) // NoBukti
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@NoBukti" }, new String[] { "s", "", "", txtNoBukti.ToString() }, AKK);
                }
                else if ((!cb1.Checked) && (!cb2.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@NoBukti" }, new String[] { "s", "", "", "" }, AKK);
                }
            }
        }

    }
}
