using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Accounting_Solution_Software
{
    public partial class Modul_Pembelian_PurchaseOrder : Form
    {
        private MainForm mf = null;
        private SqlDataReader sdr = null;
        private AllFunc allFunc = null;
        private DbObject dbo = null;
        private PurchaseOrder po = new PurchaseOrder();
        private subPurchaseOrder spo = new subPurchaseOrder();
        private string noBuktiPO= "";
        private bool edit = true;
        private DataTable dt = new DataTable();
        DataGridView dgv = new DataGridView();

        public Modul_Pembelian_PurchaseOrder()
        {
            InitializeComponent();
            allFunc = new AllFunc();
            dbo = new DbObject();
        }

        public Modul_Pembelian_PurchaseOrder(MainForm mf)
        {
            InitializeComponent();
            allFunc = new AllFunc("Purchase Order",mf);
            dbo = new DbObject();

            this.mf = mf;
        }

        private void blank_field()
        {
            nomorPOTextBox.Text = "";
            nomorPOTextBox.Enabled = true;
            tglPODTP.Text = "";
            kodeSupplierTextBox.Text = "";
            namaSupplierTextBox.Text = "";
            alamatPengirimanRTB.Text = "";
            alamatpoRTB.Text = "";
            jumlahPembelianTextBox.Text = "";
            eraseStockItemDTV();
        }

        private void refreshView_Purchase_Order()
        {
            this.gudangTableAdapter.Fill(this.purchase_Order.Gudang);
            this.view_po_supplierTableAdapter.Fill(this.purchase_Order.view_po_supplier);
            //this.view_subPo_stockTableAdapter.Fill(this.purchase_Order.view_subPo_stock);
        }

        private void close()
        {
            if (allFunc.Mf != null)
                allFunc.Mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void refreshNoBukti()
        {
            sdr = po.generateNoBukti();
            while (sdr.Read())
            {
                noBuktiPO = (string)sdr["result"];
                nomorPOTextBox.Text = (string)sdr["result"];
            }
        }

        public void calculate()
        {
            //MessageBox.Show(itemStockDataGridView.Rows.Count.ToString());
            if (stockItemDTV.Rows.Count > 0)
            {
                double grandTotal = 0.0;

                for (int i = 0; i < stockItemDTV.Rows.Count; i++)
                {
                    grandTotal += Convert.ToDouble(allFunc.remove_separated(stockItemDTV.Rows[i].Cells[2].Value.ToString())) * Convert.ToDouble(allFunc.remove_separated(stockItemDTV.Rows[i].Cells[4].Value.ToString()));
                }
                jumlahPembelianTextBox.Text = allFunc.digit_separated(grandTotal.ToString());
            }
        }

        public void addItemDataGrid(string[] arrItem)
        {
            stockItemDTV.Rows.Add(arrItem);
        }

        public void addSupplier(string[] arrSupplier)
        {
            kodeSupplierTextBox.Text = arrSupplier[0];
            namaSupplierTextBox.Text = arrSupplier[1];
            sdr = dbo.get_single_data(null, "KodeSupplier", arrSupplier[0], "supplier");
            String[] rtbLines = new string[6];
            while (sdr.Read())
            {
                rtbLines[0] = arrSupplier[1];
                rtbLines[1] = check_dbnull_string(sdr["alamat1"]);
                rtbLines[2] = check_dbnull_string(sdr["kota"]);
                rtbLines[3] = "Telp :";
                rtbLines[4] = check_dbnull_string(sdr["Telepon1"]);
                rtbLines[5] = check_dbnull_string(sdr["Telepon2"]);
                alamatpoRTB.Lines = rtbLines;
            }
        }

        private string check_dbnull_string(Object obj)
        {
            return (obj is System.DBNull) ? string.Empty : obj.ToString();
        }

        public void edit_item_row(DataGridViewRow rowItem)
        {
            for (int i = 0; i < rowItem.Cells.Count; i++)
            {
                stockItemDTV.Rows[rowItem.Index].Cells[i].Value = rowItem.Cells[i].Value;
            }
            stockItemDTV.Refresh();
        }

        public void edit_PO(String noBukti)
        {
            //blank_field();
            tabControl1.SelectTab(1);
            sdr = dbo.get_single_data(null, "id", noBukti, "view_po_supplier");
            while (sdr.Read())
            {
                nomorPOTextBox.Text = (string)sdr["id"];
                tglPODTP.Value = (DateTime)sdr["tanggal"];
                kodeSupplierTextBox.Text = check_dbnull_string(sdr["KodeSupplier"]);
                namaSupplierTextBox.Text = check_dbnull_string(sdr["NamaSupplier"]);
                alamatpoRTB.Text = check_dbnull_string(sdr["alamatpo"]);
                alamatPengirimanRTB.Text = check_dbnull_string(sdr["alamatbarang"]);
                alamatPegirimanCMB.SelectedValue = check_dbnull_string(sdr["gudangkirim"]);
                StatusKirimTxtbox.Text= "D";
                if (sdr["statuskirim"].ToString().CompareTo("T") == 0)
                {
                    StatusKirimTxtbox.Text = "T";
                }

            }
            String[] fields = new String[] { "KodeProduk AS [Kode Produk]", "NamaStock AS [Nama stock]", "qty AS Qty", "satuan AS [Satuan]", "hargabeli As [Harga Beli]", "subtotal As Subtotal" };
            dt = dbo.get_all(fields, "view_po_subpo_stock", "id = '" + noBukti + "'", "", "", 0, 0);
            stockItemDTV.DataSource = dt;

            set_dtv_column_readonly();

            nomorPOTextBox.Enabled = false;
            calculate();
            stockItemDTV.Refresh();

            edit = true;

        }

        private void set_dtv_column_readonly()
        {
            stockItemDTV.Columns[0].ReadOnly = true;
            stockItemDTV.Columns[1].ReadOnly = true;
            stockItemDTV.Columns[3].ReadOnly = true;
            stockItemDTV.Columns[4].ReadOnly = true;
            stockItemDTV.Columns[5].ReadOnly = true;
        }

        public void set_dtv_column()
        {
            stockItemDTV.Columns.Add("kodeproduk", "Kode Produk");
            stockItemDTV.Columns.Add("NamaStock", "Nama Produk");
            stockItemDTV.Columns.Add("qty", "Qty");
            stockItemDTV.Columns["qty"].ValueType = typeof(double);
            stockItemDTV.Columns.Add("satuan", "Satuan");
            stockItemDTV.Columns.Add("hargabeli", "Harga beli");
            stockItemDTV.Columns.Add("subtotal", "Subtotal");
            stockItemDTV.Columns["subtotal"].ValueType = typeof(double);
        }


        private void Refresh_Item_Data_Grid()
        {
            this.view_po_supplierTableAdapter.Fill(this.purchase_Order.view_po_supplier);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modul_Barang_Penerimaan penerimaan_barang = new Modul_Barang_Penerimaan(null);
            penerimaan_barang.Show();
        }

        public void setItemDataGrid(String[] Items)
        {
            if(stockItemDTV.DataSource != null)
            {
                //dgv = CopyDataGridView(stockItemDTV);
                //unBindStockItemDTV();
                
                //for (int i = 0; i < dgv.Rows.Count; i++)
                //{
                    
                //    stockItemDTV.Rows.Add();
                //    for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                //    {
                //        stockItemDTV.Rows[i].Cells[j].Value = dgv.Rows[i].Cells[j].Value.ToString();
                //    }
                //}
                dt.Rows.Add(new String[] { Items[0], Items[1], "0", Items[2], Items[3],"0" });
            }
            else{
                if (stockItemDTV.Columns.Count == 0)
                {
                    set_dtv_column();
                }
                stockItemDTV.Rows.Add(new String[] { Items[0], Items[1], "", Items[2], Items[3],"" });
            }
        }

        private void Modul_Pembelian_PurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purchase_Order.info_status_kiriman' table. You can move, or remove it, as needed.
            this.info_status_kirimanTableAdapter.Fill(this.purchase_Order.info_status_kiriman);
            this.gudangTableAdapter.Fill(this.purchase_Order.Gudang);
            this.view_po_supplierTableAdapter.Fill(this.purchase_Order.view_po_supplier);
            //this.view_subPo_stockTableAdapter.Fill(this.purchase_Order.view_subPo_stock);
        }

        private void KeluarBtn_Click(object sender, EventArgs e)
        {
            close();
        }

        private void BaruBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tambah_PO();
        }

        private void tambah_PO()
        {
            edit = false;
            blank_field();
            refreshNoBukti();
            eraseStockItemDTV();
            StatusKirimTxtbox.Text = "D";
            //nomor_po_rebind();
        }


        private void TambahItemBtn_Click(object sender, EventArgs e)
        {
            Modul_Barang_CariPopup inputBarangPopup = new Modul_Barang_CariPopup(this);
            inputBarangPopup.Show();
        }

        private DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_copy.Rows.Add(row);
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //cf.ShowExceptionErrorMsg("Copy DataGridViw", ex);
            }
            return dgv_copy;
        }


        private void HapusItemBtn_Click(object sender, EventArgs e)
        {
            if (stockItemDTV.Rows.Count > 0)
            {
                //unBindStockItemDTV();
                stockItemDTV.Rows.RemoveAt(stockItemDTV.CurrentRow.Index);
                stockItemDTV.Refresh();
                calculate();
            }
        }

        private void BatalBtn_Click(object sender, EventArgs e)
        {
            rebind_all();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            blank_field();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (view_po_supplierDataGridView.RowCount>0)
            {
               edit_PO(view_po_supplierDataGridView.Rows[view_po_supplierDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            else
            {
                tambah_PO();
            }
        }

        private void SimpanBtn_Click(object sender, EventArgs e)
        {
            try
            {
            bool err = false;
            string spQuery = null;
            String v1 = nomorPOTextBox.Text;
            String v3 = kodeSupplierTextBox.Text;
            DataGridView dgv = stockItemDTV;
            //float v4 = (float)Convert.ToDouble(allFunc.remove_separated(jumlahPembelianTextBox.Text));
            
            if ((v1.CompareTo("") != 0) && (v3.CompareTo("") != 0)&&(dgv.Rows.Count!=0))
            {
                DateTime v5 = Convert.ToDateTime(tglPODTP.Text);
                string v6 = alamatPengirimanRTB.Text;
                string v8 = alamatpoRTB.Text;
                string v9 = alamatPegirimanCMB.SelectedValue.ToString();
                string v7 = StatusKirimTxtbox.Text;
                //string v7 = statuskirimComboBox.SelectedValue.ToString();
                double qty = 0;
                string kodeBarang = null;
                double hargaBeli = 0;
                string satuan = null;
                

                if (edit) //Kalau Edit
                {
                    //po.UpdateRow(v1, v5, v3, v6, v7);
                    spQuery += "exec [dbo].[PurchaseOrder_Update] '" + v1 + "','" + v5 + "','" + v3 + "','" + v8 + "','" + v9 + "','" + v6 + "','" + v7 + "';";
                    spQuery += "exec [dbo].[subPurchaseOrder_DeleteRow_by_IDPO] '"+v1+"';";
                    edit = false;
                }
                else
                {
                    //po.InsertRow(v1, v5, v3, v6, v7);
                    spQuery += "exec [dbo].[PurchaseOrder_Insert] '" + v1 + "','" + v5 + "','" + v3 + "','" + v8 + "','" + v9 + "','" + v6 + "','" + v7 + "';";
                }

                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            qty = Convert.ToDouble(dgv.Rows[i].Cells[2].Value.ToString());
                            kodeBarang = dgv.Rows[i].Cells[0].Value.ToString();
                            hargaBeli = Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString());
                            satuan = dgv.Rows[i].Cells[3].Value.ToString();
                            spQuery += "exec [dbo].[subPurchaseOrder_Insert] '" + v1 + "','" + kodeBarang + "'," + qty + ",'" + satuan + "'," + hargaBeli + ";";
                        }
                        dbo.run_query(spQuery);
                        edit = true;

                if (!err)
                {
                    MessageBox.Show("Transaksi " + allFunc.Prefix + " berhasil dilakukan.");
                    print_laporan(v1);
                    rebind_all();
                }
            }
            else
            {
                MessageBox.Show("Nomor Purchase Order, Supplier , dan Item harus terisi.");
            }


            }
            catch (FormatException fe)
            {
                MessageBox.Show("Input Kolom Qty menggunakan Angka.");
            }
        }

        private void print_laporan(string id)
        {
            if (printChkBox.Checked)
            {
                Modul_Laporan_PurchaseOrder laporan = new Modul_Laporan_PurchaseOrder(id);
                laporan.Show();
            }
        }

        private void kodeSupplierBtn_Click(object sender, EventArgs e)
        {
            Modul_Data_SupplierPopUp supplierPopup = new Modul_Data_SupplierPopUp(this);
            supplierPopup.Show();
        }

        private void alamatPegirimanCMB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sdr = dbo.get_single_data(null, "id", alamatPegirimanCMB.SelectedValue.ToString(), "gudang");
            String[] rtbLines = new string[6];
            while (sdr.Read())
            {
                rtbLines[0] = check_dbnull_string(sdr["nama"]);
                rtbLines[1] = check_dbnull_string(sdr["alamat"]);
                rtbLines[3] = "Telp :";
                rtbLines[4] = check_dbnull_string(sdr["telp1"]);
                rtbLines[5] = check_dbnull_string(sdr["telp2"]);
                alamatPengirimanRTB.Lines = rtbLines;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (view_po_supplierDataGridView.Rows.Count > 0)
                {
                    edit_PO(view_po_supplierDataGridView.Rows[view_po_supplierDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    tambah_PO();
                }
            }
        }

        private void stockItemDTV_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void unBindStockItemDTV()
        {
            this.stockItemDTV.DataSource = null;
        }

        private void eraseStockItemDTV()
        {
            try
            {
                unBindStockItemDTV();
                stockItemDTV.Columns.Clear();
                stockItemDTV.Rows.Clear();
                stockItemDTV.Refresh();
            }
            catch (ArgumentException ae) { }
        }

        public void resetStockItemDTV()
        {
            //this.stockItemDTV.DataSource = this.view_subPo_stockBindingSource;
            eraseStockItemDTV();
            this.view_po_supplierTableAdapter.Fill(this.purchase_Order.view_po_supplier);
            //this.view_subPo_stockTableAdapter.Fill(this.purchase_Order.view_subPo_stock);
        }

        private void rebind_all()
        {
            blank_field();
            tabControl1.SelectedIndex = 0;
            refreshView_Purchase_Order();
            resetStockItemDTV();
        }

        private void stockItemDTV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (stockItemDTV.Rows.Count >0)
                {
                    try
                    {
                        stockItemDTV.Rows[stockItemDTV.CurrentCell.RowIndex].Cells[5].Value = Convert.ToDouble(allFunc.remove_separated(stockItemDTV.Rows[stockItemDTV.CurrentCell.RowIndex].Cells[2].Value.ToString())) * Convert.ToDouble(allFunc.remove_separated(stockItemDTV.Rows[stockItemDTV.CurrentCell.RowIndex].Cells[4].Value.ToString()));
                        calculate();
                    }
                    catch (NullReferenceException nre)
                    {
                    }
                }
            }
        }

        private void changeFilter()
        {
            try
            {
                string sql = "";
                string subsql = "";
                this.view_po_supplierTableAdapter.Fill(this.purchase_Order.view_po_supplier);

                if (checkBox4.Checked)
                {
                    sql = " (" + String.Format("tanggal >= '{0:MM/dd/yyyy}' AND tanggal < '{1:MM/dd/yyyy}'", dateTimePicker1.Value, dateTimePicker1.Value.AddDays(1)) + ")";
                }

                if (checkBox3.Checked)
                {
                    subsql = "statuskirim LIKE'%" + statusPembayaranTxt.SelectedValue.ToString() + "%'";
                    if ((checkBox4.Checked))
                    {
                        sql += " AND " + subsql;
                    }
                    else
                    {
                        sql += subsql;
                    }
                }

                if (checkBox2.Checked)
                {
                    subsql = "id LIKE '%" + cariTxt.Text + "%' OR kodesupplier LIKE '%" + cariTxt.Text + "%' OR NamaSupplier LIKE '%" + cariTxt.Text + "%' OR NamaGudang LIKE '%" + cariTxt.Text + "%'";
                    if ((checkBox4.Checked) || (checkBox3.Checked))
                    {
                        sql += " AND (" + subsql;
                        sql = sql + ")";
                    }
                    else
                    {
                        sql += subsql;
                    }
                }


                if ((!checkBox4.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked))
                {
                    this.view_po_supplierTableAdapter.FillBylast3months(this.purchase_Order.view_po_supplier);
                    sql = "";
                }

                view_po_supplierBindingSource.Filter = sql;
                view_po_supplierDataGridView.DataSource = view_po_supplierBindingSource;
                view_po_supplierDataGridView.Refresh();

            }
            catch (NullReferenceException nre)
            {
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void statusPembayaranTxt_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void view_po_supplierDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                edit_PO(view_po_supplierDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void stockItemDTV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Input Kolom Qty menggunakan Angka.");
            stockItemDTV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
        }

    }
}
