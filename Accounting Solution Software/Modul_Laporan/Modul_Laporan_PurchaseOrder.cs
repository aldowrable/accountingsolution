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
    public partial class Modul_Laporan_PurchaseOrder : Form
    {
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_All PO_All = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_All();
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurcahseOrder_ByCabang PO_ByCbg = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurcahseOrder_ByCabang();
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_BySupplier PO_BySupp = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_BySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_All PO_Sub_All = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_All();
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByCabang PO_Sub_ByCbg = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByCabang();
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByKodeStock PO_Sub_ByKS = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByKodeStock();
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByCabang_ByKodeStock PO_Sub_ByCbg_ByKS = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByCabang_ByKodeStock();
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByCabang_BySupplier PO_Sub_ByCbg_BySupp = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByCabang_BySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_BySupplier PO_Sub_BySupp = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_BySupplier();
        private Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByTransaksi PO_Sub_ByPO = new Accounting_Solution_Software.Modul_Laporan.Purchase_Order.Laporan_PurchaseOrder_Sub_ByTransaksi();

        private DbObject dbo = new DbObject();

        public Modul_Laporan_PurchaseOrder()
        {
            InitializeComponent();
            set_cabang_cmb();
            rb1.Checked = true;
        }

        public Modul_Laporan_PurchaseOrder(string NoId)
        {
            InitializeComponent();
            set_cabang_cmb();
            rb2.Checked = true;
            setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", "", "", NoId }, PO_Sub_ByPO);
        }

        private void set_cabang_cmb()
        {
            String[] fields = new String[] { "id", "nama" };
            DataTable dt = dbo.get_all(fields, "gudang", "", "", "", 0, 0);
            var items1 = new BindingList<KeyValuePair<string, string>>();

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {
                items1.Add(new KeyValuePair<string, string>(row["id"].ToString(), row["nama"].ToString()));
            }

            items1.Add(new KeyValuePair<string, string>("", "Semua Cabang"));

            cbgCMB.DataSource = items1;
            cbgCMB.ValueMember = "Key";
            cbgCMB.DisplayMember = "Value";

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

        private void generateReport()
        {
            if (rb1.Checked) // Parent Table
            {
                if(cb1.Checked && cb2.Checked && cb4.Checked)
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), "", cbgCMB.SelectedValue.ToString(), "" }, PO_All);
                }
                else if (cb1.Checked && cb4.Checked) // Tanggal, Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("")==0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "", "" }, PO_All);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", cbgCMB.SelectedValue.ToString(), "" }, PO_ByCbg);
                    }
                }
                else if (cb1.Checked && cb2.Checked) // tanggal , Supplier
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, PO_BySupp);
                }
                else if (cb2.Checked && cb4.Checked) // Supplier, Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", "", "", KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, PO_BySupp);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", "", "", KodeSupplierCmb.SelectedValue.ToString(), "", cbgCMB.SelectedValue.ToString(), "" }, PO_ByCbg);
                    }
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "", "" }, PO_All);
                }
                else if (cb2.Checked) // Supplier
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", "", "", KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, PO_BySupp);
                }
                else if (cb4.Checked) // Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", "", "", "", "", "", "" }, PO_All);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", "", "", "", "", cbgCMB.SelectedValue.ToString(), "" }, PO_ByCbg);
                    }
                }
                else if ((!cb1.Checked) && (!cb2.Checked) && (!cb4.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "p", "", "", "", "", "", "" }, PO_All);
                }
            }
            else if (rb2.Checked) // Sub Table
            {
                if (cb5.Checked) // No. PO
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", "", "", noPOTxt.Text }, PO_Sub_ByPO);
                }
                else if (cb1.Checked && cb2.Checked && cb3.Checked && cb4.Checked) // Tanggal , Supplier, Kode Stock
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", kodeStockTxt.Text, "", "" }, PO_Sub_ByKS);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), kodeStockTxt.Text, cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_BySupp);
                    }
                }
                else if (cb1.Checked && cb2.Checked && cb4.Checked) // Tanggal , Supplier, Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), "", cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg_BySupp);
                    }                        
                }
                else if (cb1.Checked && cb3.Checked && cb4.Checked) // Tanggal , Kode Stock, Cabang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", kodeStockTxt.Text, cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg_ByKS);
                }
                else if (cb2.Checked && cb3.Checked && cb4.Checked) // Supplier, Kode Stock , Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", kodeStockTxt.Text, cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg_ByKS);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", KodeSupplierCmb.SelectedValue.ToString(), kodeStockTxt.Text, cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg_BySupp);
                    }
                                        
                }
                else if (cb1.Checked && cb2.Checked && cb3.Checked) // Tanggal , Supplier, Kode Stock
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", "", cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), kodeStockTxt.Text, "", "" }, PO_Sub_BySupp);
                    }
                                        
                }
                else if (cb1.Checked && cb4.Checked) // Tanggal, Cabang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg);
                }
                else if (cb2.Checked && cb4.Checked) // Supplier , Cabang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", KodeSupplierCmb.SelectedValue.ToString(), "", cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg_BySupp);
                    }
                     
                }
                else if (cb3.Checked && cb4.Checked) // Kode Stock , Cabang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", kodeStockTxt.Text, cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg_ByKS);
                }
                else if (cb1.Checked && cb2.Checked) // Tanggal, Supplier
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "", "" }, PO_Sub_All);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, PO_Sub_BySupp);
                    }
                                        
                }
                else if (cb1.Checked && cb3.Checked) // Tanggal, Barang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", kodeStockTxt.Text, "", "" }, PO_Sub_ByKS);
                }
                else if (cb2.Checked && cb3.Checked) // Supplier , Barang
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", kodeStockTxt.Text, "", "" }, PO_Sub_ByKS);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", KodeSupplierCmb.SelectedValue.ToString(), kodeStockTxt.Text, "", "" }, PO_Sub_BySupp);
                    }
                     
                }
                else if (cb1.Checked) // Tanggal
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", dtp1.Text.ToString(), dtp2.Text.ToString(), "", "", "", "" }, PO_Sub_All);
                }
                else if (cb2.Checked) // Supplier
                {
                    if (cbgCMB.SelectedValue.ToString().CompareTo("") == 0)
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", "", "", "" }, PO_Sub_All);
                    }
                    else
                    {
                        setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", KodeSupplierCmb.SelectedValue.ToString(), "", "", "" }, PO_Sub_BySupp);
                    }                        
                }
                else if (cb3.Checked) // Barang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", kodeStockTxt.Text, "", "" }, PO_Sub_ByKS);
                }
                else if (cb4.Checked) // Cabang
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", "", cbgCMB.SelectedValue.ToString(), "" }, PO_Sub_ByCbg);
                }
                else if ((!cb1.Checked) && (!cb2.Checked) && (!cb3.Checked) && (!cb4.Checked) && (!cb5.Checked))
                {
                    setReport(new String[] { "@flag", "@Tgl", "@Tgl2", "@KdSupp", "@KdStock", "@IdCbg", "@NoPO" }, new String[] { "s", "", "", "", "", "", "" }, PO_Sub_All);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            generateReport();
        }

        private void Modul_Laporan_PurchaseOrder_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);

        }
    }
}
