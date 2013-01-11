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
    public partial class Modul_Laporan_LabaRugi : Form
    {

        private DbObject dbo = new DbObject();
        private Accounting_Solution_Software.Modul_Laporan.Akuntansi.Laporan_LabaRugi laporan_labarugi = new Accounting_Solution_Software.Modul_Laporan.Akuntansi.Laporan_LabaRugi();

        public Modul_Laporan_LabaRugi()
        {
            InitializeComponent();
        }

        private void Modul_Laporan_LabaRugi_Load(object sender, EventArgs e)
        {
            set_tahun_cmb();
        }

        private void set_tahun_cmb()
        {
            var items3 = new BindingList<KeyValuePair<string, string>>();
            for (int i = 2011; i <= DateTime.Now.Year;i++ )
            {
                items3.Add(new KeyValuePair<string, string>(i.ToString(),i.ToString()));
            }

            tahunCMB.DataSource = items3;
            tahunCMB.ValueMember = "Key";
            tahunCMB.DisplayMember = "Value";
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
            setReport(new String[] { "@tgl"}, new String[] { tahunCMB.SelectedValue.ToString() }, laporan_labarugi);
        }

    }
}
