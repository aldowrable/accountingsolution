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
    public partial class Modul_Laporan_Supplier : Form
    {

        private Accounting_Solution_Software.Modul_Laporan.Laporan_supplier supplier = new Accounting_Solution_Software.Modul_Laporan.Laporan_supplier();
        private DbObject dbo = new DbObject();

        public Modul_Laporan_Supplier()
        {
            InitializeComponent();
            rb1.Checked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                setReport(new String[] { "@KodeSupplier" }, new String[] { "" }, supplier);
            }
            else if(rb2.Checked)
            {
                setReport(new String[] { "@KodeSupplier" }, new String[] { namaSupplierComboBox.SelectedValue.ToString() }, supplier);
            }        
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

        private void Modul_Laporan_Supplier_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);
        }
    }
}
