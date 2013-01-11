using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Accounting_Solution_Software
{
    public partial class Modul_Pembelian : Form
    {
        private MainForm mf = null;
        private JurnalUmum obj = null;
        private SubJurnalUmum subObj = null;
        private Beli beli = null;
        private Kas kas = null;
        private Utang utang = null;
        //private TerimaBarang terimaBarng = null;
        //private SubTerimaBarang subTerimaBarang = null;
        private SubBeli subBeli = null;
        private SqlDataReader sdr = null;
        private AllFunc allFunc = null;
        private DbObject dbo = null;
        //private Stock stock = null;
        private string noBuktiPembelian = "";
        private bool edit = false;
        private bool editTriggier = false;

        public Modul_Pembelian()
        {
            InitializeComponent();
            allFunc = new AllFunc();
            beli = new Beli();
            subBeli = new SubBeli();
            dbo = new DbObject();
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
            kas = new Kas();
            utang = new Utang();
            //stock = new Stock();
            //terimaBarng = new TerimaBarang();
            //subTerimaBarang = new SubTerimaBarang();
        }

        public Modul_Pembelian(MainForm mf)
        {
            InitializeComponent();
            allFunc = new AllFunc("Pembelian",mf);
            beli = new Beli();
            subBeli = new SubBeli();
            dbo = new DbObject();
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
            kas = new Kas();
            utang = new Utang();
            //terimaBarng = new TerimaBarang();
            //subTerimaBarang = new SubTerimaBarang();
            //stock = new Stock();
            this.mf = mf;
        }

        private void blank_field()
        {
            edit = false;
            nomorFakturTextBox.Text = "";
            //nomorSJTextBox.Text = "";
            noTBCMB.Text = "";
            tglTransaksiDateTimePicker.Text = "";
            kodeSupplierTextBox.Text = "";
            namaSupplierTextBox.Text = "";
            jtTextBox.Enabled = false;
            tglJTDateTimePicker.Enabled = false;
            TunaiRadioButton.Select();
            subJumlahTextBox.Text = "";
            totDiscRpTextBox.Text = "";
            totPPnRpTextBox.Text = "";
            bulatTextBox.Text = "";
            materaiTextBox.Text = "";
            jumlahPembelianTextBox.Text = "";
            refreshNoBukti();
            Refresh_Item_Data_Grid();
        }

        private void erase_item_datagrid()
        {
            view_TB_STB_PO_ProdukDataGridView.Rows.Clear();
            view_TB_STB_PO_ProdukDataGridView.Refresh();
        }

        private void unbind_item_datagrid()
        {
            if (view_TB_STB_PO_ProdukDataGridView.DataSource != null)
            {
                this.view_TB_STB_PO_ProdukDataGridView.DataSource = null;
            }
        }

        private void bind_item_datagrid()
        {
            if (view_TB_STB_PO_ProdukDataGridView.DataSource == null)
            {
                this.view_TB_STB_PO_ProdukDataGridView.DataSource = this.viewTerimaBarangSupplierViewTBSTBPOProdukBindingSource;
                view_TB_STB_PO_ProdukDataGridView.Refresh();
            }
        }

        private void close()
        {
            try
            {
                if (allFunc.Mf != null)
                    allFunc.Mf.Enabled = true;
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("dodol");
            }
        }

        private void refreshNoBukti()
        {
            sdr = beli.generateNoBukti();
            while (sdr.Read())
            {
                noBuktiPembelian = (string)sdr["result"];
                nomorFakturTextBox.Text = (string)sdr["result"];
            }
        }

        public void calculate()
        {
            //MessageBox.Show(itemStockDataGridView.Rows.Count.ToString());
            if(view_TB_STB_PO_ProdukDataGridView.Rows.Count >0)
            {
                DataGridView tGrid = view_TB_STB_PO_ProdukDataGridView;
                double subTotal = 0.0;
                double discount = 0.0;
                double ppn = 0.0;
                double pembulatan = 0.0;
                double grandTotal = 0.0;

                for(int i = 0;i< tGrid.Rows.Count ;i++)
                {
                    if (tGrid.Rows[i].Cells[0].Value != null)
                    {
                        subTotal += Convert.ToDouble(allFunc.remove_separated(tGrid.Rows[i].Cells[2].Value.ToString())) * Convert.ToDouble(allFunc.remove_separated(tGrid.Rows[i].Cells[4].Value.ToString()));
                        discount += Convert.ToDouble(allFunc.remove_separated(tGrid.Rows[i].Cells[6].Value.ToString()));
                        ppn += Convert.ToDouble(allFunc.remove_separated(tGrid.Rows[i].Cells[8].Value.ToString()));
                        pembulatan += Convert.ToDouble(allFunc.remove_separated(tGrid.Rows[i].Cells[9].Value.ToString()));
                    }
                }
                grandTotal = subTotal - discount + ppn + pembulatan;

                subJumlahTextBox.Text = allFunc.digit_separated(subTotal.ToString());
                totDiscRpTextBox.Text = allFunc.digit_separated(discount.ToString());
                totPPnRpTextBox.Text = allFunc.digit_separated(ppn.ToString());
                bulatTextBox.Text = allFunc.digit_separated(pembulatan.ToString());
                jumlahPembelianTextBox.Text = allFunc.digit_separated(grandTotal.ToString());
            }
        }

        public void addItemDataGrid(string[] arrItem)
        {
            change_produkDataGridView();
            view_TB_STB_PO_ProdukDataGridView.Rows.Add(arrItem);
        }

        public void addSupplier(string[] arrSupplier)
        {
            kodeSupplierTextBox.Text = arrSupplier[0];
            namaSupplierTextBox.Text = arrSupplier[1];
        }

        public void edit_item_row(DataGridViewRow rowItem)
        {
           // int rowIndex = rowItem.Index;
            //int rowTotal = rowItem.Cells.Count;
            //DataGridViewRow dgv = new DataGridViewRow();

            //MessageBox.Show(view_TB_STB_PO_ProdukDataGridView.DataSource.ToString());
            //String[] rowContent = new String[14];
            //for (int i = 0; i < rowItem.Cells.Count; i++)
            //{
            //    rowContent[i] = rowItem.Cells[i].Value.ToString();
            //}
            //change_produkDataGridView();
            //for (int i = 0; i < rowTotal; i++)
            //{
             //   MessageBox.Show(rowContent[i].ToString());
             //   view_TB_STB_PO_ProdukDataGridView.Rows[rowIndex].Cells[i].Value = rowContent[i];
            //}
            
            view_TB_STB_PO_ProdukDataGridView.Refresh();
        }

        public void edit_Pembelian(String noBukti)
        {
            tabControl1.SelectTab(1);
            //blank_field();
            change_produkDataGridView();
            erase_item_datagrid();
            
            sdr = dbo.get_single_data(null, "NomorBukti", noBukti ,"view_pembelian_supplier");
            while (sdr.Read()) 
            { 
                nomorFakturTextBox.Text = (string)sdr["NomorBukti"]; 
                //nomorSJTextBox.Text = (string)sdr["NomorFaktur"];
                noTBCMB.Text =(string)sdr["NomorFaktur"];
                //tglPembukuanDateTimePicker.Value = (DateTime)sdr["tglPembukuan"];
                tglTransaksiDateTimePicker.Value = (DateTime)sdr["tglTransaksi"];
                kodeSupplierTextBox.Text = (string)sdr["KodeSupplier"];
                namaSupplierTextBox.Text = (string)sdr["NamaSupplier"];
                TunaiRadioButton.Checked = false;
                KreditRadioButton.Checked = false;
                if (sdr["StatusPembelian"].ToString().CompareTo("T") == 0)
                {
                    TunaiRadioButton.Checked = true;
                    KreditRadioButton.Checked = false;
                }
                else
                {
                    TunaiRadioButton.Checked = false;
                    KreditRadioButton.Checked = true;
                    jtTextBox.Text = "0";
                    tglJTDateTimePicker.Value = (DateTime)sdr["TglJT"];
                }
                subJumlahTextBox.Text = ((Double)sdr["SubJumlah"]).ToString();
                totDiscRpTextBox.Text = ((Double)sdr["TotDiscRp"]).ToString();
                totPPnRpTextBox.Text = ((Double)sdr["TotPpnRp"]).ToString();
                bulatTextBox.Text = ((Double)sdr["Bulat"]).ToString();
                jumlahPembelianTextBox.Text = ((Double)sdr["JumlahPembelian"]).ToString() ;
                materaiTextBox.Text = ((Double)sdr["Materai"]).ToString();

                sdr = dbo.get_single_data(null, "NomorBukti", noTBCMB.Text.ToString(), "View_TerimaBarang_Supplier");
                while (sdr.Read())
                { 
                    noPOTxtBox.Text = (string)sdr["NomorBuktiPembelian"];
                }
                
                
            }
            String[] fields = new String[] { "KodeBarang", "NamaStock", "qty", "satuan", "hargabeli", "disc", "discrp", "ppn", "ppnrp", "bulat", "jumlah", "tglkadaluarsa" };
            DataTable dt = dbo.get_all(fields, "view_SubBeli_Stock", "NomorBukti = '" + noBukti + "'", "", "", 0, 0);

            foreach (DataRow row in dt.Rows) // Loop over the rows.
	        {
                view_TB_STB_PO_ProdukDataGridView.Rows.Add(row.ItemArray);
	        }

            calculate();
            noTBCMB.Enabled = false;
            view_TB_STB_PO_ProdukDataGridView.Refresh();
            //tabControl1.SelectTab(1);
            edit = true;

        }

        private void Refresh_Item_Data_Grid()
        {
            this.view_TerimaBarang_SupplierTableAdapter.get_pembelian_delayed(this.terima_Barang.view_TerimaBarang_Supplier);
            this.view_pembelian_supplierTableAdapter.FillLast3Month(this.pembelian_2.view_pembelian_supplier);
        }

        private void Modul_Pembelian_Load(object sender, EventArgs e)
        {
            this.view_TB_STB_PO_ProdukTableAdapter.Fill(this.terima_Barang.View_TB_STB_PO_Produk);
            this.view_pembelian_supplierTableAdapter.FillLast3Month(this.pembelian_2.view_pembelian_supplier);
            this.view_TerimaBarang_SupplierTableAdapter.get_pembelian_delayed(this.terima_Barang.view_TerimaBarang_Supplier);
            this.info_status_kirimanTableAdapter.Fill(this.purchase_Order.info_status_kiriman);
        }

        private void btn_Baru_Click(object sender, EventArgs e)
        {
            //bind_item_datagrid();
            this.tabControl1.SelectedIndex = 1;
            noTBCMB.Enabled = true;
            tambah_pembelian();
        }

        private void tambah_pembelian()
        {
            edit = false;
            blank_field();
            refreshNoBukti();
            erase_item_datagrid();
            bind_item_datagrid();
            noTBCMB.Enabled = true;
            //nomor_po_rebind();
            //StatusPembelianTextbox.Text = "D";
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (view_pembelian_supplierDataGridView.Rows.Count > 0)
            {
                editTriggier = true;
                edit_Pembelian(view_pembelian_supplierDataGridView.Rows[view_pembelian_supplierDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            else
            {
                tambah_pembelian();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (KreditRadioButton.Checked)
            {
                jtTextBox.Enabled = true;
                tglJTDateTimePicker.Enabled = true;
                TunaiRadioButton.Checked = false;
            }
            else
            {
                jtTextBox.Enabled = false;
                tglJTDateTimePicker.Enabled = false;
            }
        }

        private void jtTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Jatuh Tempo");
        }

        private void subJumlahTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Sub Jumlah");
        }

        private void totDiscRpTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Total Discount");
        }

        private void totPPnRpTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai PPN");
        }

        private void bulatTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Pembulatan");
        }

        private void jumlahPembelianTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Jumlah Pembelian");
        }

        private void materaiTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Materai");
        }


        private void materaiTextBox_Leave(object sender, EventArgs e)
        {
            materaiTextBox.Text = allFunc.digit_separated(materaiTextBox.Text); 
        }

        private void materaiTextBox_Enter(object sender, EventArgs e)
        {
            materaiTextBox.Text = allFunc.remove_separated(materaiTextBox.Text);
        }

        private void TambahItemBtn_Click(object sender, EventArgs e)
        {
            Modul_Pembelian_InputBarangPopup inputBarangPopup = new Modul_Pembelian_InputBarangPopup(this);
            this.Enabled = false;
            inputBarangPopup.Show();
        }

        private void change_produkDataGridView()
        {
            DataGridView dgv = new DataGridView();
            if (view_TB_STB_PO_ProdukDataGridView.DataSource != null)
            {
                dgv = CopyDataGridView(view_TB_STB_PO_ProdukDataGridView);
                unbind_item_datagrid();
                //unBindStockItemDTV();
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[0].Value != null)
                    {
                        view_TB_STB_PO_ProdukDataGridView.Rows.Add();
                        for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                        {

                            view_TB_STB_PO_ProdukDataGridView.Rows[i].Cells[j].Value = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }
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

        private void SimpanBtn_Click(object sender, EventArgs e)
        {
            bool err = false;
            String spQuery = null;
            String v1 = nomorFakturTextBox.Text;
            String v2 = noTBCMB.Text;
            String v3 = kodeSupplierTextBox.Text;
            double v4 = Convert.ToDouble(allFunc.remove_separated(jumlahPembelianTextBox.Text));
            if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0) && (v3.CompareTo("") != 0) && (v4 > 0))
            {

                    //DateTime v5 = Convert.ToDateTime(tglPembukuanDateTimePicker.Text);
                    DateTime v5 = DateTime.Now;
                    DateTime v7 = Convert.ToDateTime(tglTransaksiDateTimePicker.Text);
                    String v6 = "";
                    double v8 = Convert.ToDouble(allFunc.remove_separated(subJumlahTextBox.Text));
                    double v9 = Convert.ToDouble(allFunc.remove_separated(totDiscRpTextBox.Text));
                    double v10 = Convert.ToDouble(allFunc.remove_separated(totPPnRpTextBox.Text));
                    double v11 = Convert.ToDouble(allFunc.remove_separated(bulatTextBox.Text));
                    double v12 = Convert.ToDouble(allFunc.remove_separated(materaiTextBox.Text));
                    DataGridView dgv = view_TB_STB_PO_ProdukDataGridView;

                    if (edit) //Kalau Edit
                    {
                        if (KreditRadioButton.Checked)
                        {
                                DateTime v13 = Convert.ToDateTime(tglJTDateTimePicker.Text);
                                sdr = obj.UpdateRow(v5, v1, "Pembelian Barang Dagang No. Bukti : " + v1);
                                while (sdr.Read()) { v6 = (string)sdr["result"]; }
                                //subObj.DeleteRow(v6);
                                //subObj.setDebitSystem(v6, "11311", "Persediaan Barang Dagang", v4);
                                //subObj.setKreditSystem(v6, "21111", "Utang Usaha", v4);

                                spQuery += "EXEC [dbo].[SubJurnalUmum_DeleteRow] '"+v6+"'; ";
                                spQuery += "EXEC [dbo].[SubJurnalUmum_InsertDebit_System] '" +v6+ "','11311','Persediaan Barang Dagang'," +v4+ "; ";
                                spQuery += "EXEC [dbo].[SubJurnalUmum_InsertKredit_System] '" + v6 + "','21111','Utang Usaha'," + v4 + "; ";
          
                                //beli.DeleteRow(v1);//Hapus Pembelian yang pertama
                                //beli.InsertRow(v1, v2, v7, v5, v3, "K", v13, 0, v8, v9, v10, v4, 0, v11, v12);//Pembelian

                                spQuery += "EXEC [dbo].[Beli_DeleteRow] '" + v1 + "';";
                                spQuery += "EXEC [dbo].[Beli_Insert] '"+v1+"','"+v2+"','"+v7+"','"+v5+"','"+v3+"','K','"+v13+"',0,"+v8+","+v9+","+v10+","+v4+",0,"+v11+","+v12+" ;";

                                //kas.DeleteRowByNoFaktur(v1); //Transaksi Tunai (jika Tunai)

                                spQuery += "EXEC [dbo].[Kas_DeleteRow_By_NoFaktur] '" + v1 + "';";

                                //utang.DeleteRow(v1);//Hapus Utang yang pertama
                                //utang.InsertRowKredit(v5, v2, v1, v3, v4, 0, v13, "", v7);//Utang

                                spQuery += "EXEC [dbo].[Utang_DeleteRow] '" + v1 + "';";
                                spQuery += "EXEC [dbo].[Utang_InsertKredit] '" + v5 + "','" + v1 + "','" + v1 + "','" + v3 + "'," + v4 + ",0,'" + v13 + "','','" + v7 + "' ;";                                
    
                                String v14 = "";//No. Bukti Terima Barang
                                //subBeli.DeleteRow(v1);//Hapus Sub Beli Yang Pertama

                                spQuery += "EXEC [dbo].[SubBeli_DeleteRow] '" + v1 + "';";

                                for (int i = 0; i < dgv.Rows.Count; i++)
                                {
                                    if (dgv.Rows[i].Cells[0].Value != null)
                                    {
                                        double qty = Convert.ToDouble(dgv.Rows[i].Cells[2].Value.ToString());
                                        string kodeBarang = dgv.Rows[i].Cells[0].Value.ToString();
                                        double hargaBeli = Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString());
                                        double qtyLama = 0;
                                        if (dgv.Rows[i].Cells[12].Value != null)
                                        {
                                            qtyLama = Convert.ToDouble(dgv.Rows[i].Cells[12].Value.ToString());
                                        }
                                        double hargaLama = 0;
                                        if (dgv.Rows[i].Cells[13].Value != null)
                                        {
                                            hargaLama = Convert.ToDouble(dgv.Rows[i].Cells[13].Value.ToString());
                                        }
                                        //float hargaRata = (qty * hargaBeli + qtyLama * hargaLama) / (qty + qtyLama);
                                        //stock.UpdateRowHargaBeli(kodeBarang, hargaRata);
                                        //stock.UpdateRowHargaBeli(kodeBarang, hargaBeli);
                                        //subTerimaBarang.UpdateRow(0,v14, qty, kodeBarang, v7, "p","e");//SubTerimaBarang
                                        double disc = Convert.ToDouble(dgv.Rows[i].Cells[5].Value.ToString());
                                        double discRp = Convert.ToDouble(dgv.Rows[i].Cells[6].Value.ToString());
                                        double ppn = Convert.ToDouble(dgv.Rows[i].Cells[7].Value.ToString());
                                        double ppnRp = Convert.ToDouble(dgv.Rows[i].Cells[8].Value.ToString());
                                        double pembulatan = Convert.ToDouble(dgv.Rows[i].Cells[9].Value.ToString());
                                        double grandTotal = Convert.ToDouble(dgv.Rows[i].Cells[10].Value.ToString());
                                        //DateTime kadaluarsa = DateTime.Now;
                                        //subBeli.InsertRow(v1, qty, kodeBarang, hargaBeli, disc, discRp, qty * hargaBeli, grandTotal, "", v7, v5, v3, ppn, ppnRp, pembulatan, kadaluarsa);
                                    	spQuery += "EXEC [dbo].[SubBeli_Insert] '" +v1+ "'," +qty+ ",'" +kodeBarang+ "'," +hargaBeli+ "," +disc+ "," +discRp+ "," +qty * hargaBeli+ "," +grandTotal+ ",'','" +v7+ "','" +v5+ "','" +v3+ "'," +ppn+ "," +ppnRp+ "," +pembulatan+ ",'' ;";

                                    }    
                                }

                            edit = false;

                        }
                        else if (TunaiRadioButton.Checked)
                        {

                            sdr = obj.UpdateRow(v5, v1, "Pembelian Barang Dagang No. Bukti : " + v1); //JurnalUmum
                            while (sdr.Read()) { v6 = (string)sdr["result"]; }

                            //subObj.DeleteRow(v6);
                            //subObj.setDebitSystem(v6, "11311", "Persediaan Barang Dagang", v4); //SubJurnalUmum
                            //subObj.setKreditSystem(v6, "11111", "Pengeluaran Kas Besar ", v4); //SubJurnalUmum

                            spQuery += "EXEC [dbo].[SubJurnalUmum_DeleteRow] '" + v6 + "'; ";
                            spQuery += "EXEC [dbo].[SubJurnalUmum_InsertDebit_System] '" + v6 + "','11311','Persediaan Barang Dagang'," + v4 + "; ";
                            spQuery += "EXEC [dbo].[SubJurnalUmum_InsertKredit_System] '" + v6 + "','11111','Pengeluaran Kas Besar'," + v4 + "; ";

                            //beli.DeleteRow(v1);//Hapus Pembelian yang pertama
                            //beli.InsertRow(v1, v2, v7, v5, v3, "T", v5, 0, v8, v9, v10, v4, 0, v11, v12); //Pembelian

                            spQuery += "EXEC [dbo].[Beli_DeleteRow] '" + v1 + "';";
                            spQuery += "EXEC [dbo].[Beli_Insert] '" + v1 + "','" + v2 + "','" + v7 + "','" + v5 + "','" + v3 + "','T','" + v5 + "',0," + v8 + "," + v9 + "," + v10 + "," + v4 + ",0," + v11 + "," + v12 + " ;";

                            //kas.DeleteRowByNoFaktur(v1);

                            spQuery += "EXEC [dbo].[Kas_DeleteRow_By_NoFaktur] '" + v1 + "';";

                            //utang.DeleteRow(v1);//Hapus Utang ( Jika Hutang )
                            //kas.InsertRowKredit(v5, v1, "Pembelian Tunai No. Bukti : " + v1, v4); //Kas

                            spQuery += "EXEC [dbo].[Utang_DeleteRow] '" + v1 + "';";
                            spQuery += "EXEC [dbo].[Kas_InsertKredit_Generate_NoBukti] '" +v5+ "','" +v1+ "','Pembelian Tunai No. Bukti : "+v1+"'," + v4 + " ;";                                

                            String v14 = "";//No. Bukti Terima Barang
                            //subBeli.DeleteRow(v1);//Hapus Sub Beli Yang Pertama

                            spQuery += "EXEC [dbo].[SubBeli_DeleteRow] '" + v1 + "';";

                            for (int i = 0; i < dgv.Rows.Count; i++)
                            {
                                if (dgv.Rows[i].Cells[0].Value != null)
                                {
                                    double qty = Convert.ToDouble(dgv.Rows[i].Cells[2].Value.ToString());
                                    string kodeBarang = dgv.Rows[i].Cells[0].Value.ToString();
                                    double hargaBeli = Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString());
                                    double qtyLama = 0;
                                    if (dgv.Rows[i].Cells[12].Value != null)
                                    {
                                        qtyLama = Convert.ToDouble(dgv.Rows[i].Cells[12].Value.ToString());
                                    }
                                    double hargaLama = 0;
                                    if (dgv.Rows[i].Cells[13].Value != null)
                                    {
                                        hargaLama = Convert.ToDouble(dgv.Rows[i].Cells[13].Value.ToString());
                                    }
                                    //float hargaRata = (qty * hargaBeli + qtyLama * hargaLama) / (qty + qtyLama);
                                    //stock.UpdateRowHargaBeli(kodeBarang, hargaRata);
                                    //stock.UpdateRowHargaBeli(kodeBarang, hargaBeli);
                                    //subTerimaBarang.UpdateRow(0, v14, qty, kodeBarang, v7, "p","e");//SubTerimaBarang
                                    double disc = Convert.ToDouble(dgv.Rows[i].Cells[5].Value.ToString());
                                    double discRp = Convert.ToDouble(dgv.Rows[i].Cells[6].Value.ToString());
                                    double ppn = Convert.ToDouble(dgv.Rows[i].Cells[7].Value.ToString());
                                    double ppnRp = Convert.ToDouble(dgv.Rows[i].Cells[8].Value.ToString());
                                    double pembulatan = Convert.ToDouble(dgv.Rows[i].Cells[9].Value.ToString());
                                    double grandTotal = Convert.ToDouble(dgv.Rows[i].Cells[10].Value.ToString());
                                    //DateTime kadaluarsa = Convert.ToDateTime(dgv.Rows[i].Cells[11].Value.ToString());
                                    //DateTime kadaluarsa = DateTime.Now;
                                    //subBeli.InsertRow(v1, qty, kodeBarang, hargaBeli, disc, discRp, qty * hargaBeli, grandTotal, "", v7, v5, v3, ppn, ppnRp, pembulatan, kadaluarsa);//Sub Pembelian
                                    spQuery += "EXEC [dbo].[SubBeli_Insert] '" + v1 + "'," + qty + ",'" + kodeBarang + "'," + hargaBeli + "," + disc + "," + discRp + "," + qty * hargaBeli + "," + grandTotal + ",'','" + v7 + "','" + v5 + "','" + v3 + "'," + ppn + "," + ppnRp + "," + pembulatan + ",'' ;";
                                }
                            }
                        }



                        edit = false;
                    }
                    else // Kalau Add New
                    {

                        if (KreditRadioButton.Checked)
                        {
                            if ((jtTextBox.Text.CompareTo("") != 0) && (jtTextBox.Text.CompareTo("0") != 0))
                            {
                                DateTime v13 = Convert.ToDateTime(tglJTDateTimePicker.Text);
                                sdr = obj.InsertRow(v5, v1, "Pembelian Barang Dagang No. Bukti : " + v1);
                                while (sdr.Read()) { v6 = (string)sdr["result"]; }

                                //subObj.setDebitSystem(v6, "11311", "Persediaan Barang Dagang", v4);
                                //subObj.setKreditSystem(v6, "21111", "Utang Usaha", v4);
                                //beli.InsertRow(v1, v2, v7, v5, v3, "K", v13, 0, v8, v9, v10, v4, 0, v11, v12);//Pembelian
                                //utang.InsertRowKredit(v5, v2, v1, v3, v4, 0, v13, "", v7);//Utang

                                spQuery += "EXEC [dbo].[SubJurnalUmum_InsertDebit_System] '" + v6 + "','11311','Persediaan Barang Dagang'," + v4 + "; ";
                                spQuery += "EXEC [dbo].[SubJurnalUmum_InsertKredit_System] '" + v6 + "','21111','Utang Usaha'," + v4 + "; ";
                                spQuery += "EXEC [dbo].[Beli_Insert] '" + v1 + "','" + v2 + "','" + v7 + "','" + v5 + "','" + v3 + "','K','" + v13 + "',0," + v8 + "," + v9 + "," + v10 + "," + v4 + ",0," + v11 + "," + v12 + " ;";
                                spQuery += "EXEC [dbo].[Utang_InsertKredit] '" + v5 + "','" + v1 + "','" + v1 + "','" + v3 + "'," + v4 + ",0,'" + v13 + "','','" + v7 + "' ;";                                
    
                                String v14 = "";//No. Bukti Terima Barang
                                //sdr = terimaBarng.InsertRow(v1, "", v3, ""); //TerimaBarang
                                //while (sdr.Read()) { v14 = (string)sdr["result"]; }
                                spQuery += "EXEC [dbo].[TerimaBarang_Terbayar] '"+v2+"';";

                                for (int i = 0; i < dgv.Rows.Count; i++)
                                {
                                    if (dgv.Rows[i].Cells[0].Value != null)
                                    {
                                        double qty = Convert.ToDouble(dgv.Rows[i].Cells[2].Value.ToString());
                                        string kodeBarang = dgv.Rows[i].Cells[0].Value.ToString();
                                        double hargaBeli = Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString());
                                        double qtyLama = Convert.ToDouble(dgv.Rows[i].Cells[12].Value.ToString());
                                        double hargaLama = Convert.ToDouble(dgv.Rows[i].Cells[13].Value.ToString());
                                        //float hargaRata = (qty * hargaBeli + qtyLama * hargaLama) / (qty + qtyLama);
                                        //stock.UpdateRowHargaBeli(kodeBarang, hargaRata);
                                        //stock.UpdateRowHargaBeli(kodeBarang, hargaBeli);
                                        //subTerimaBarang.InsertRow(v14, qty, kodeBarang, v7, "p");//SubTerimaBarang
                                        double disc = Convert.ToDouble(dgv.Rows[i].Cells[5].Value.ToString());
                                        double discRp = Convert.ToDouble(dgv.Rows[i].Cells[6].Value.ToString());
                                        double ppn = Convert.ToDouble(dgv.Rows[i].Cells[7].Value.ToString());
                                        double ppnRp = Convert.ToDouble(dgv.Rows[i].Cells[8].Value.ToString());
                                        double pembulatan = Convert.ToDouble(dgv.Rows[i].Cells[9].Value.ToString());
                                        double grandTotal = Convert.ToDouble(dgv.Rows[i].Cells[10].Value.ToString());
                                        //DateTime kadaluarsa = Convert.ToDateTime(dgv.Rows[i].Cells[11].Value.ToString());
                                        //DateTime kadaluarsa = DateTime.Now;
                                        //subBeli.InsertRow(v1, qty, kodeBarang, hargaBeli, disc, discRp, qty * hargaBeli, grandTotal, "", v7, v5, v3, ppn, ppnRp, pembulatan, kadaluarsa);
                                        spQuery += "EXEC [dbo].[SubBeli_Insert] '" + v1 + "'," + qty + ",'" + kodeBarang + "'," + hargaBeli + "," + disc + "," + discRp + "," + qty * hargaBeli + "," + grandTotal + ",'','" + v7 + "','" + v5 + "','" + v3 + "'," + ppn + "," + ppnRp + "," + pembulatan + ",'' ;";

                                    }
                                                                    
                                }
                            }
                            else
                            {
                                err = true;
                                MessageBox.Show("Jumlah hari jatuh tempo harus terisi.");
                            }

                        }
                        else if (TunaiRadioButton.Checked)
                        {
                            sdr = obj.InsertRow(v5, v1, "Pembelian Barang Dagang No. Bukti : " + v1); //JurnalUmum
                            while (sdr.Read()) { v6 = (string)sdr["result"]; }
                            //subObj.setDebitSystem(v6, "11311", "Persediaan Barang Dagang", v4); //SubJurnalUmum
                            //subObj.setKreditSystem(v6, "11111", "Pengeluaran Kas Besar ", v4); //SubJurnalUmum
                            //beli.InsertRow(v1, v2, v7, v5, v3, "T", v5, 0, v8, v9, v10, v4, 0, v11, v12); //Pembelian
                            //kas.InsertRowKredit(v5, v2, "Pembelian Tunai No. Bukti : " + v1, v4); //Kas

                            spQuery += "EXEC [dbo].[SubJurnalUmum_InsertDebit_System] '" + v6 + "','11311','Persediaan Barang Dagang'," + v4 + "; ";
                            spQuery += "EXEC [dbo].[SubJurnalUmum_InsertKredit_System] '" + v6 + "','11111','Pengeluaran Kas Besar '," + v4 + "; ";
                            spQuery += "EXEC [dbo].[Beli_Insert] '" + v1 + "','" + v2 + "','" + v7 + "','" + v5 + "','" + v3 + "','T','" + v5 + "',0," + v8 + "," + v9 + "," + v10 + "," + v4 + ",0," + v11 + "," + v12 + " ;";
                            spQuery += "EXEC [dbo].[Kas_InsertKredit_Generate_NoBukti] '" + v5 + "','" + v2 + "','Pembelian Tunai No. Bukti : " + v1 + "'," + v4 + " ;";                                
 
                            String v14 = "";//No. Bukti Terima Barang
                            spQuery += "EXEC [dbo].[TerimaBarang_Terbayar] '" + v2 + "';";
                            

                            for (int i = 0; i < dgv.Rows.Count; i++)
                            {
                                if (dgv.Rows[i].Cells[0].Value != null)
                                {
                                    double qty = Convert.ToDouble(dgv.Rows[i].Cells[2].Value.ToString());
                                    string kodeBarang = dgv.Rows[i].Cells[0].Value.ToString();
                                    double hargaBeli = Convert.ToDouble(dgv.Rows[i].Cells[4].Value.ToString());
                                    double qtyLama = Convert.ToDouble(dgv.Rows[i].Cells[12].Value.ToString());
                                    double hargaLama = Convert.ToDouble(dgv.Rows[i].Cells[13].Value.ToString());
                                    double hargaRata = (qty * hargaBeli + qtyLama * hargaLama) / (qty + qtyLama);
                                    //stock.UpdateRowHargaBeli(kodeBarang, hargaRata);
                                    //stock.UpdateRowHargaBeli(kodeBarang, hargaBeli);
                                    //subTerimaBarang.InsertRow(v14, qty, kodeBarang, v7, "p");//SubTerimaBarang
                                    double disc = Convert.ToDouble(dgv.Rows[i].Cells[5].Value.ToString());
                                    double discRp = Convert.ToDouble(dgv.Rows[i].Cells[6].Value.ToString());
                                    double ppn = Convert.ToDouble(dgv.Rows[i].Cells[7].Value.ToString());
                                    double ppnRp = Convert.ToDouble(dgv.Rows[i].Cells[8].Value.ToString());
                                    double pembulatan = Convert.ToDouble(dgv.Rows[i].Cells[9].Value.ToString());
                                    double grandTotal = Convert.ToDouble(dgv.Rows[i].Cells[10].Value.ToString());
                                    //DateTime kadaluarsa = Convert.ToDateTime(dgv.Rows[i].Cells[11].Value.ToString());
                                    //DateTime kadaluarsa = DateTime.Now;
                                    //subBeli.InsertRow(v1, qty, kodeBarang, hargaBeli, disc, discRp, qty * hargaBeli, grandTotal, "", v7, v5, v3, ppn, ppnRp, pembulatan, kadaluarsa);//Sub Pembelian
                                    spQuery += "EXEC [dbo].[SubBeli_Insert] '" + v1 + "'," + qty + ",'" + kodeBarang + "'," + hargaBeli + "," + disc + "," + discRp + "," + qty * hargaBeli + "," + grandTotal + ",'','" + v7 + "','" + v5 + "','" + v3 + "'," + ppn + "," + ppnRp + "," + pembulatan + ",'' ;";                                
                                }
                            }
                        }
                    }

                    dbo.run_query(spQuery);

                    if (!err)
                    {
                        MessageBox.Show("Transaksi " + allFunc.Prefix + " berhasil dilakukan.");
                        print_laporan(v1);
                        tabControl1.SelectedIndex = 0;
                        blank_field();
                        Refresh_Item_Data_Grid();
                    }
  
            }
            else
            {
                MessageBox.Show("NomorBukti Pembelian , Nomor Faktur , Supplier , dan Item harus terisi.");
            }
        }

        private void print_laporan(string id)
        {
            if (printChkBox.Checked)
            {
                Modul_Laporan_Pembelian laporan = new Modul_Laporan_Pembelian(id);
                laporan.Show();
            }
        }

        private void itemStockDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Modul_Pembelian_InputBarangPopup inputBarangPopup = new Modul_Pembelian_InputBarangPopup(this);
            inputBarangPopup.edit_item_row(view_TB_STB_PO_ProdukDataGridView.CurrentRow);
            this.Enabled = false;
            inputBarangPopup.Show();
        }

        private void itemStockDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Modul_Pembelian_InputBarangPopup inputBarangPopup = new Modul_Pembelian_InputBarangPopup(this);
                inputBarangPopup.edit_item_row(view_TB_STB_PO_ProdukDataGridView.CurrentRow);
                this.Enabled = false;
                inputBarangPopup.Show();
            }
        }

        private void UbahItemBtn_Click(object sender, EventArgs e)
        {
            if (view_TB_STB_PO_ProdukDataGridView.Rows.Count > 0)
            {
                Modul_Pembelian_InputBarangPopup inputBarangPopup = new Modul_Pembelian_InputBarangPopup(this);
                if (view_TB_STB_PO_ProdukDataGridView.DataSource != null)
                {
                    int curentRow = view_TB_STB_PO_ProdukDataGridView.CurrentRow.Index;
                    change_produkDataGridView();
                    inputBarangPopup.edit_item_row(view_TB_STB_PO_ProdukDataGridView.Rows[curentRow]);
                }
                else
                {
                    inputBarangPopup.edit_item_row(view_TB_STB_PO_ProdukDataGridView.CurrentRow);
                }
                
                this.Enabled = false;
                inputBarangPopup.Show();
            }
        }

        private void HapusItemBtn_Click(object sender, EventArgs e)
        {
            if (view_TB_STB_PO_ProdukDataGridView.Rows.Count > 0)
            {
                view_TB_STB_PO_ProdukDataGridView.Rows.RemoveAt(view_TB_STB_PO_ProdukDataGridView.CurrentRow.Index);
                view_TB_STB_PO_ProdukDataGridView.Refresh();
                calculate();
            }
        }

        private void jtTextBox_TextChanged(object sender, EventArgs e)
        {
            tglJTDateTimePicker.Value = tglTransaksiDateTimePicker.Value.AddDays(Convert.ToDouble(allFunc.remove_separated(jtTextBox.Text)));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Modul_Data_SupplierPopUp supplierPopup = new Modul_Data_SupplierPopUp(this);
            this.Enabled = false;
            supplierPopup.Show();
        }

        private void TunaiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TunaiRadioButton.Checked)
            {
                KreditRadioButton.Checked = false;
            }

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            blank_field();
        }


        private void changeFilter()
        {
            try
            {
                string sql = "";
                string subsql = "";
                this.view_pembelian_supplierTableAdapter.Fill(this.pembelian_2.view_pembelian_supplier);

                if (checkBox2.Checked)
                {
                    sql = " (" + String.Format("tglPembukuan >= '{0:MM/dd/yyyy}' AND tglPembukuan < '{1:MM/dd/yyyy}'", dateTimePicker1.Value, dateTimePicker1.Value.AddDays(1)) + ")";
                }

                if (checkBox4.Checked)
                {
                    subsql = "StatusPembelian = '" + statusPembayaranTxt.SelectedValue.ToString() + "'";
                    if (checkBox2.Checked)
                    {
                        sql += " AND " + subsql;
                    }
                    else
                    {
                        sql += subsql;
                    }
                }

                if (checkBox3.Checked)
                {
                    subsql = "NomorBukti LIKE '%" + cariTxt.Text + "%' OR NomorFaktur LIKE '%" + cariTxt.Text + "%' OR NamaSupplier LIKE '%" + cariTxt.Text + "%'";
                    if ((checkBox2.Checked)|| (checkBox4.Checked))
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

                    this.view_pembelian_supplierTableAdapter.FillLast3Month(this.pembelian_2.view_pembelian_supplier);
                    sql = "";
                }

                view_pembelian_supplierBindingSource.Filter = sql;
                view_pembelian_supplierDataGridView.DataSource = view_pembelian_supplierBindingSource;
                view_pembelian_supplierDataGridView.Refresh();

            }
            catch (NullReferenceException nre)
            {
            }
        }

        private void BatalBtn_Click(object sender, EventArgs e)
        {
            blank_field();
            bind_item_datagrid();
            tabControl1.SelectedIndex = 0;
        }

        private void KeluarBtn_Click(object sender, EventArgs e)
        {
            close();
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

        private void view_TB_STB_PO_ProdukDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calculate();
        }

        private void view_TB_STB_PO_ProdukDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
            }
            catch(Exception exx)
            {
                MessageBox.Show(exx.ToString());
            }
        }

        private void view_pembelian_supplierDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                //view_pembelian_supplierDataGridView.DataSource = null;
                view_pembelian_supplierBindingSource.DataSource = null;

            }
            catch (IndexOutOfRangeException iore)
            {
                MessageBox.Show(view_pembelian_supplierDataGridView.DataSource.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("dodol");
            }
        }

        private void view_pembelian_supplierDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("test dodol");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 1)
            {
                if (view_pembelian_supplierDataGridView.Rows.Count>0)
                {
                    edit_Pembelian(view_pembelian_supplierDataGridView.Rows[view_pembelian_supplierDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                }
                else
                {
                    tambah_pembelian();
                }
            }
            //if (tabControl1.SelectedIndex == 1)
            //{
            //    if (!editTriggier)
            //    {
            //        bind_item_datagrid();
            //        blank_field();
            //    }
            //    else
            //    {
            //        //editTriggier = true;
            //        //edit_Pembelian(view_pembelian_supplierDataGridView.Rows[view_pembelian_supplierDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            //    }
            //}
            //else
            //{
            //    unbind_item_datagrid();
            //    editTriggier = false;
            //}
        }

        private void view_pembelian_supplierDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                editTriggier = true;
                edit_Pembelian(view_pembelian_supplierDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void noTBCMB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(view_TB_STB_PO_ProdukDataGridView.DataSource==null)
            {
                bind_item_datagrid();
            }
        }

        
    }
}
