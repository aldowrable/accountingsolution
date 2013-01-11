using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;

namespace Accounting_Solution_Software
{
    public partial class Modul_POS : Form
    {
        Timer Clock;
        private AllFunc allfunc = null;
        private DbObject dbo = null;
        public string[] custDataArr = new string[]{"","",""};
        public double jumlahPenjualan = 0.0;
        public double jumlahDiskon = 0.0;
        public double jumlahPenjualanBruto = 0.0;
        public Login login = null;
        public Modul_POS_Resep_Dokter resepDokter = null;
        private Modul_Barang_CariPopup barangCariPopup = null;
        private Modul_Pembayaran pembayaran = null;

        public Modul_POS()
        {
            InitializeComponent();
            this.KeyPreview = true;
            allfunc = new AllFunc() ;
            dbo = new DbObject();
            Clock = new Timer();
            Clock.Interval = 1000;
            Clock.Start();
            Clock.Tick += new EventHandler(Timer_Tick);
            timeClockLbl.Text = GetTime();
            dateLbl.Text = GetDate();
        }

        public Modul_POS(Login login)
        {
            InitializeComponent();
            this.KeyPreview = true;
            allfunc = new AllFunc();
            dbo = new DbObject();
            Clock = new Timer();
            Clock.Interval = 1000;
            Clock.Start();
            Clock.Tick += new EventHandler(Timer_Tick);
            timeClockLbl.Text = GetTime();
            dateLbl.Text = GetDate();
            this.login = login;
        }

        public void setModulResepDokter(Modul_POS_Resep_Dokter resepDokter)
        {
            this.resepDokter = resepDokter;
        }

        private void blank_field()
        {
            kodePelangganTxt.Text = "";
            namaPelangganTxt.Text = "";
            alamatPelangganTxt.Text = "";
            itemPenjualanDataGridView.Rows.Clear();
            itemPenjualanDataGridView.Refresh();
            harga1RadioBtn.Checked = true;
            kodeBarangTxt.Text = "";
            kodeDokterTxt.Text = "";
            namaDokterTxt.Text = "";
            namaBarangTxt.Text = "";
            hargaJualTxt.Text = "";
            catatanTxt.Text = "";
            qtyTxt.Text = "";
            displayHargaTxt.Text = "0";
            //custDataArr2 = new string[] { "", "", "" };
            custDataArr = new string[] { "", "", "" };
        }

        public void reset()
        {
            blank_field();
        }

        private void form_ready_to_use()
        {
            namaBarangTxt.Text = "";
            kodeBarangTxt.Text = "";
            kodeDokterTxt.Text = "";
            namaDokterTxt.Text = "";
            hargaJualTxt.Text = "0";
            hargaJual1Txt.Text = "0";
            hargaJual2Txt.Text = "0";
            hargaJual3Txt.Text = "0";
            catatanTxt.Text = "0";
            qtyTxt.Text = "0";

        }

        private string GetTime()
        {
            string TimeInString="";
            int hour=DateTime.Now.Hour;
            int min=DateTime.Now.Minute;
            int sec=DateTime.Now.Second;

            TimeInString=(hour < 10)?"0" + hour.ToString() :hour.ToString();
            TimeInString+=":" + ((min<10)?"0" + min.ToString() :min.ToString());
            TimeInString+=":" + ((sec<10)?"0" + sec.ToString() :sec.ToString());
            return TimeInString;
        }

        private string GetDate()
        {
            string DateInString = "";
            string nameDay = DateTime.Now.DayOfWeek.ToString();
            switch (nameDay)
            {
                case "Sunday":
                    {
                        nameDay = "Minggu";
                        break;
                    }
                case "Monday":
                    {
                        nameDay = "Senin";
                        break;
                    }
                case "Tuesday":
                    {
                        nameDay = "Selasa";
                        break;
                    }
                case "Wednesday":
                    {
                        nameDay = "Rabu";
                        break;
                    }
                case "Thursday":
                    {
                        nameDay = "Kamis";
                        break;
                    }
                case "Friday":
                    {
                        nameDay = "Jumat";
                        break;
                    }
                case "Saturday":
                    {
                        nameDay = "Sabtu";
                        break;
                    }
            }

            string date = DateTime.Now.Day.ToString();
            string[] monthNameArr = new string[]{"","Januari","Februari","Maret","April","Mei","Juni","Juli","Agustus","September","Oktober","November","Desember"};
            string month = monthNameArr[DateTime.Now.Month];
            string year = DateTime.Now.Year.ToString();
            DateInString = nameDay + " , "+date+" "+month+" "+year;
            return DateInString;

        }

        private void Timer_Tick(object sender, EventArgs eArgs)
        {
            if(sender == Clock)
            {
                timeClockLbl.Text = GetTime(); 
            }
        }



        public void calculate()
        {
            jumlahPenjualan = 0.0;
            jumlahPenjualanBruto = 0.0;
            jumlahDiskon = 0.0;
            if (itemPenjualanDataGridView.Rows.Count > 0)
            {
                for(int i = 0;i< itemPenjualanDataGridView.Rows.Count ;i++)
                {
                    if (itemPenjualanDataGridView.Rows[i].Cells[7].Value!=null)
                    {
                        if (!itemPenjualanDataGridView.Rows[i].Cells[1].Value.ToString().ToLower().Contains("jasa"))
                        {
                            if (Convert.ToDouble(allfunc.remove_separated(itemPenjualanDataGridView.Rows[i].Cells[2].Value.ToString())) > Convert.ToDouble(allfunc.remove_separated(itemPenjualanDataGridView.Rows[i].Cells[9].Value.ToString())))
                            {
                                MessageBox.Show("Jumlah stock tidak mencukupi");
                                itemPenjualanDataGridView.Rows[i].Cells[2].Value = itemPenjualanDataGridView.Rows[i].Cells[9].Value;
                                qtyTxt.Text = itemPenjualanDataGridView.Rows[i].Cells[9].Value.ToString();
                            }
                            else
                            {
                                double qty = Convert.ToDouble(allfunc.remove_separated(itemPenjualanDataGridView.Rows[i].Cells[2].Value.ToString()));
                                double prc = Convert.ToDouble(allfunc.remove_separated(itemPenjualanDataGridView.Rows[i].Cells[4].Value.ToString()));
                                double gt = qty * prc;
                                jumlahPenjualanBruto += gt;
                                //MessageBox.Show("1 : "+Convert.ToString(jumlahPenjualanBruto
                                double disc = 0;
                                if (itemPenjualanDataGridView.Rows[i].Cells[5].Value != null)
                                {
                                    disc = Convert.ToDouble(allfunc.remove_separated(itemPenjualanDataGridView.Rows[i].Cells[5].Value.ToString()));
                                }
                                double discRp = disc / 100 * gt;
                                gt = gt - discRp;
                                itemPenjualanDataGridView.Rows[i].Cells[6].Value = allfunc.digit_separated(discRp.ToString());
                                itemPenjualanDataGridView.Rows[i].Cells[7].Value = allfunc.digit_separated(gt.ToString());
                                jumlahPenjualan += gt;
                                jumlahDiskon += discRp;
                            }
                        }
                        else
                        {
                            double qty = Convert.ToDouble(allfunc.remove_separated(itemPenjualanDataGridView.Rows[i].Cells[2].Value.ToString()));
                            double prc = Convert.ToDouble(allfunc.remove_separated(itemPenjualanDataGridView.Rows[i].Cells[4].Value.ToString()));
                            double gt = qty * prc;
                            jumlahPenjualanBruto += gt;
                            //MessageBox.Show("2 : " + Convert.ToString(jumlahPenjualanBruto));

                            double disc = 0;
                            if (itemPenjualanDataGridView.Rows[i].Cells[5].Value != null)
                            {
                                disc = Convert.ToDouble(allfunc.remove_separated(itemPenjualanDataGridView.Rows[i].Cells[5].Value.ToString()));
                            }

                            double discRp = disc / 100 * gt;
                            gt = gt - discRp;
                            itemPenjualanDataGridView.Rows[i].Cells[6].Value = allfunc.digit_separated(discRp.ToString());
                            itemPenjualanDataGridView.Rows[i].Cells[7].Value = allfunc.digit_separated(gt.ToString());
                            jumlahPenjualan += gt;
                            jumlahDiskon += discRp;
                        }
                    }
                }
                
            }
            if (jumlahPenjualan != 0.0)
            {
                displayHargaTxt.Text = allfunc.digit_separated(Convert.ToString(jumlahPenjualan));
            }
            else
            {
                displayHargaTxt.Text = "0";
            }

            
        }

        public void changeItemDataGrid(string val)
        {
            try
            {
                if (itemPenjualanDataGridView.Rows.Count > 0)
                {
                    for (int i = 0; i < itemPenjualanDataGridView.Rows.Count; i++)
                    {
                        DataGridViewRow row = itemPenjualanDataGridView.Rows[i];
                        if (row.Cells[0].Value.ToString().CompareTo(kodeBarangTxt.Text) == 0)
                        {
                            if(val.ToLower().CompareTo("hargajual")==0)
                            {
                                itemPenjualanDataGridView.Rows[i].Cells[4].Value = hargaJualTxt.Text;
                                calculate();
                            }
                            else if(val.ToLower().CompareTo("qty")==0)
                            {
                                itemPenjualanDataGridView.Rows[i].Cells[2].Value = qtyTxt.Text;
                                calculate();
                            }
                            else if (val.ToLower().CompareTo("catatan") == 0)
                            {
                                itemPenjualanDataGridView.Rows[i].Cells[8].Value = catatanTxt.Text;
                            }

                        }
                    }
                }
            }
            catch (NullReferenceException null_e)
            {
            }
        }

        public void setCustomer(string[] custDataArr)
        {
            this.custDataArr = custDataArr;
            kodePelangganTxt.Text = custDataArr[0];
            namaPelangganTxt.Text = custDataArr[1];
            alamatPelangganTxt.Text = custDataArr[2];
        }

        public string[] getCustomer()
        {
            return this.custDataArr;
        }

        public void setJasaDokter(string[] jasaDokterDataArr)
        {
            kodeBarangTxt.Text = jasaDokterDataArr[0];
            namaBarangTxt.Text = jasaDokterDataArr[1];
            kodeDokterTxt.Text = jasaDokterDataArr[3];
            namaDokterTxt.Text = jasaDokterDataArr[4];
            hargaJual1Txt.Text = allfunc.digit_separated(jasaDokterDataArr[2]);
            hargaJual2Txt.Text = allfunc.digit_separated(jasaDokterDataArr[2]);
            hargaJual3Txt.Text = allfunc.digit_separated(jasaDokterDataArr[2]);
            hargaJualTxt.Text = allfunc.digit_separated(jasaDokterDataArr[2]);
            qtyTxt.Text = "1";
            double totalPenjualanPerItem = Convert.ToDouble(qtyTxt.Text) * Convert.ToDouble(hargaJualTxt.Text);
            catatanTxt.Text = "Jasa-1";
            string[] itemToDataGrid = new string[] { kodeBarangTxt.Text, namaBarangTxt.Text, qtyTxt.Text, "Kali", hargaJualTxt.Text, "0", "0", allfunc.digit_separated(totalPenjualanPerItem.ToString()), catatanTxt.Text };
            itemPenjualanDataGridView.Rows.Add(itemToDataGrid);
            calculate();
        }

        public void setItem(string[] itemDataArr)
        {
            kodeBarangTxt.Text = itemDataArr[0];
            if (!cariProdukTerpilih(itemDataArr[0]))
            {
                namaBarangTxt.Text = itemDataArr[1];
                hargaJual1Txt.Text = allfunc.digit_separated(itemDataArr[3]);
                hargaJual2Txt.Text = allfunc.digit_separated(itemDataArr[4]);
                hargaJual3Txt.Text = allfunc.digit_separated(itemDataArr[5]);
                qtyTxt.Text = "1";
                if(harga1RadioBtn.Checked)
                {
                    hargaJualTxt.Text = hargaJual1Txt.Text;
                }
                else if(harga2RadioBtn.Checked)
                {
                    hargaJualTxt.Text = hargaJual2Txt.Text;
                }
                else if (harga3RadioBtn.Checked)
                {
                    hargaJualTxt.Text = hargaJual3Txt.Text;
                }
                double totalPenjualanPerItem = Convert.ToDouble(qtyTxt.Text)*Convert.ToDouble(hargaJualTxt.Text);
                catatanTxt.Text = "Harga-1";
                string[] itemToDataGrid = new string[] { kodeBarangTxt.Text, namaBarangTxt.Text, qtyTxt.Text, itemDataArr[2], hargaJualTxt.Text, "0", "0", allfunc.digit_separated(totalPenjualanPerItem.ToString()), catatanTxt.Text, itemDataArr[6]};
                itemPenjualanDataGridView.Rows.Add(itemToDataGrid);
                calculate();

                itemPenjualanDataGridView.ClearSelection();

                int nRowIndex = itemPenjualanDataGridView.Rows.Count - 1;
                int nColumnIndex = 2;

                itemPenjualanDataGridView.CurrentCell =  itemPenjualanDataGridView.Rows[nRowIndex].Cells[nColumnIndex];
                itemPenjualanDataGridView.BeginEdit(true);
            }
            else
            {
                MessageBox.Show("Produk Sudah diinput, Anda dapat lakukan Edit Jumlah/Diskon Produk.");
            }
        }

        public DataGridView getItemPenjualan()
        {
            return itemPenjualanDataGridView;
        }

        private void openDaftarProduk()
        {
            if (barangCariPopup != null)
            {
                barangCariPopup.Close();
                barangCariPopup.Dispose();
            }
            barangCariPopup = new Modul_Barang_CariPopup(this);
            barangCariPopup.Show();
        }

        private void openDaftarJasaDokter()
        {
            Modul_Jasa_Dokter_PopUp jasaDokterPopup = new Modul_Jasa_Dokter_PopUp(this);
            jasaDokterPopup.Show();
            this.Enabled = false;
        }

        private void openModulPembayaran()
        {
            if (itemPenjualanDataGridView.Rows.Count != 0)
            {
                if (pembayaran != null)
                {
                    pembayaran.Close();
                    pembayaran.Dispose();
                }
                pembayaran = new Modul_Pembayaran(this,login);
                pembayaran.Show();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Silakan mengisi Transaksi.");
            }
        }

        private void Modul_POS_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F3:
                    {
                        //MessageBox.Show("View");
                        break;
                    }
                case Keys.F4:
                    {
                        blank_field();
                        break;
                    }
                case Keys.F5:
                    {
                        //MessageBox.Show("Hapus Bon");
                        break;
                    }
                case Keys.F6:
                    {
                        hapusItem();
                        break;
                    }
                case Keys.F7:
                    {
                        openDaftarProduk();
                        break;
                    }
                case Keys.F8:
                    {
                        //MessageBox.Show("Batal");
                        break;
                    }
                case Keys.F9:
                    {
                        openModulPembayaran();
                        break;
                    }
                case Keys.F10:
                    {
                        openDaftarJasaDokter();
                        break;
                    }
                case Keys.F11:
                    {
                        goToResepDokter();
                        break;
                    }

            }

        }

        private void hargaChanged()
        {
            if(harga1RadioBtn.Checked)
            {
                hargaJualTxt.Text = hargaJual1Txt.Text;
                catatanTxt.Text = "Harga-1";
            }
            else if(harga2RadioBtn.Checked)
            {
                hargaJualTxt.Text = hargaJual2Txt.Text;
                catatanTxt.Text = "Harga-2";
            }
            else if(harga3RadioBtn.Checked)
            {
                hargaJualTxt.Text = hargaJual3Txt.Text;
                catatanTxt.Text = "Harga-3";
            }
            changeItemDataGrid("hargajual");
            changeItemDataGrid("catatan");
            
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                SqlDataReader sdr = null;
                sdr = dbo.get_single_data(new string[]{"kodestock","namastock","satuan","jumlahstock","hargajual1","hargajual2","hargajual3"},"kodestock",kodeBarangTxt.Text,"stock");
                while(sdr.Read())
                {
                    String[] item = new String[] { sdr["kodestock"].ToString(), sdr["namaStock"].ToString(), sdr["namaStock"].ToString(), sdr["hargaJual1"].ToString(), sdr["hargaJual2"].ToString(), sdr["hargaJual3"].ToString(), sdr["jumlahStock"].ToString() };
                    setItem(item);
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            blank_field();
        }

        private void hapusItemBtn_Click(object sender, EventArgs e)
        {
            hapusItem();
        }

        private void hapusItem()
        {
            try
            {
                if (itemPenjualanDataGridView.Rows.Count > 0)
                {
                    itemPenjualanDataGridView.Rows.RemoveAt(itemPenjualanDataGridView.CurrentRow.Index);
                    itemPenjualanDataGridView.Refresh();
                    calculate();
                }
                form_ready_to_use();
            }
            catch (NullReferenceException null_e)
            {
            }
        }

        private void itemPenjualanDataGridView_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            calculate();
        }

        private void cariKodePelangganBtn_Click(object sender, EventArgs e)
        {
            Modul_Customer_PopUp custPopup = new Modul_Customer_PopUp(this);
            custPopup.Show();
            this.Enabled = false;
        }

        private void hapusProdukBtn_Click(object sender, EventArgs e)
        {
            openDaftarJasaDokter();
        }

        private void itemPenjualanDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if ((e.ColumnIndex == 2) || (e.ColumnIndex == 4) || (e.ColumnIndex == 5))
            {
                calculate();               
            }

        }

        private void itemPenjualanDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox tb = e.Control as TextBox;
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            }
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != '\b')&&(e.KeyChar.CompareTo('.')!=0 )) //allow the backspace key
                {
                    e.Handled = true;
                }
            }
        }

        private void harga3RadioBtn_Click(object sender, EventArgs e)
        {
            hargaChanged();
        }

        private void harga2RadioBtn_Click(object sender, EventArgs e)
        {
            hargaChanged();
        }

        private void harga1RadioBtn_Click(object sender, EventArgs e)
        {
            hargaChanged();
        }

        private void hargaJualTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                changeItemDataGrid("hargajual");
            }
        }

        private void catatanTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                changeItemDataGrid("catatan");
            }
        }

        private void qtyTxt_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Kuantiti");
            if (e.KeyData == Keys.Enter)
            {
                changeItemDataGrid("qty");
            }
        }

        private void jasaBtn_Click(object sender, EventArgs e)
        {
            openDaftarJasaDokter();
        }

        private void kodeDokterTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                openDaftarJasaDokter();
            }
        }

        private void hargaJualTxt_Enter(object sender, EventArgs e)
        {
            hargaJualTxt.Text = allfunc.remove_separated(hargaJualTxt.Text);
        }

        private void hargaJualTxt_Leave(object sender, EventArgs e)
        {
            hargaJualTxt.Text = allfunc.digit_separated(hargaJualTxt.Text);
        }

        private void qtyTxt_Enter(object sender, EventArgs e)
        {
            qtyTxt.Text = allfunc.remove_separated(qtyTxt.Text);
        }

        private void qtyTxt_Leave(object sender, EventArgs e)
        {
            qtyTxt.Text = allfunc.digit_separated(qtyTxt.Text);
        }

        private void daftarProdukBtn_Click(object sender, EventArgs e)
        {
            openDaftarProduk();
        }

        private void tambahItemBarcodeBtn_Click(object sender, EventArgs e)
        {
            form_ready_to_use();
            kodeBarangTxt.Focus();
        }

        private void bayarBtn_Click(object sender, EventArgs e)
        {
            openModulPembayaran();
        }

        private void kodePelangganTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Modul_Customer_PopUp custPopup = new Modul_Customer_PopUp(this);
                custPopup.Show();
                this.Enabled = false;
            }
        }

        private void itemPenjualanDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.ColumnIndex == 5) || (e.ColumnIndex == 4)) && (e.RowIndex >= 0) && (e.ColumnIndex >= 0))
            {
                itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[4].ReadOnly = true;
                itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[5].ReadOnly = true;

                if (itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[itemPenjualanDataGridView.CurrentCell.ColumnIndex].ReadOnly)
                {
                    if ((itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString().ToLower().Contains("jasa")) && (itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString().ToLower().Contains("lain")) && (itemPenjualanDataGridView.CurrentCell.ColumnIndex == 4))
                    {
                        itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[itemPenjualanDataGridView.CurrentCell.ColumnIndex].ReadOnly = false;
                    }
                    else if (((itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString().ToLower().Contains("jasa")) && (itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString().ToLower().Contains("lain")) || (itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString().ToLower().Contains("jasa")) && (itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString().ToLower().Contains("rawat"))) && (itemPenjualanDataGridView.CurrentCell.ColumnIndex == 4))
                    {
                        itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[4].ReadOnly = false;
                    }
                    else if (((itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString().ToLower().Contains("jasa")) && (!itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString().ToLower().Contains("lain"))) && (itemPenjualanDataGridView.CurrentCell.ColumnIndex == 4))
                    { }
                    else
                    {
                        Login logPermission = new Login(true, itemPenjualanDataGridView);
                        logPermission.Show();
                    }

                }
                else
                {
                    itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[itemPenjualanDataGridView.CurrentCell.ColumnIndex].Value = allfunc.remove_separated(itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[itemPenjualanDataGridView.CurrentCell.ColumnIndex].Value.ToString());
                }
            }
        }

        private void itemPenjualanDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (((e.ColumnIndex == 5) || (e.ColumnIndex == 4)) && (e.RowIndex >= 0) && (e.ColumnIndex >= 0))
                {
                    itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[itemPenjualanDataGridView.CurrentCell.ColumnIndex].ReadOnly = true;
                    itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[itemPenjualanDataGridView.CurrentCell.ColumnIndex].Value = allfunc.digit_separated(itemPenjualanDataGridView.Rows[itemPenjualanDataGridView.CurrentCell.RowIndex].Cells[itemPenjualanDataGridView.CurrentCell.ColumnIndex].Value.ToString());
                }
            }
            catch (NullReferenceException nre_e)
            {

            }
        }

        private bool cariProdukTerpilih(String idStok)
        {
            bool found = false;
            for (int i = 0; i < itemPenjualanDataGridView.Rows.Count; i++)
            {
                if (itemPenjualanDataGridView.Rows[i].Cells[0].Value.ToString().ToLower().Contains(idStok))
                {
                    found = true;
                }
            }
            return found;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Modul_Ganti_Operator_Laporan gantiOperator = new Modul_Ganti_Operator_Laporan(this,null,this.login);
            gantiOperator.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            goToResepDokter();
        }

        private void goToResepDokter()
        {
            this.Visible = false;
            resepDokter.Show();
        }

        private void Modul_POS_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

    }
}
