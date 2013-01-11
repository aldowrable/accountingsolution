using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Accounting_Solution_Software
{
    public partial class Modul_Pembayaran : Form
    {
        private Modul_POS modulPos = null;
        private Modul_POS_Resep_Dokter modulPosResepDokter = null;
        private AllFunc allfunc = null;
        private DbObject dbo = null;
        private Kas kas = null;
        private JurnalUmum obj = null;
        private SubJurnalUmum subObj = null;
        private Piutang piutang = null;
        private Stock stock = null;
        private StockGudang stockGudang = null;
        private NoBon noBon = null;
        private Jual jual = null;
        private SubJual subjual = null;
        private RetJual returJual = null;
        private RetSubJual returSubJual = null;
        private Racikan racikan = null;
        private Jasa jasa = null;
        private SqlDataReader sdr = null;
        private Login login = null;
        private double jumlahPenjualan = 0.0;
        private double jumlahDiskon = 0.0;
        private double jumlahPenjualanBruto = 0.0;
        private string kasir = "";
        private string nobon = "";
        private string nobarcode = "";
        private string nojurnal = "";
        private double totalDiscRp = 0.0;
        private double totalPPNRp = 0.0;
        private double totalProduk = 0.0;
        private double totalJasa = 0.0;
        private StrukPrint print = new StrukPrint();
        DataGridView dgvItem = null;

        public Modul_Pembayaran()
        {
            InitializeComponent();
            allfunc = new AllFunc();
            dbo = new DbObject();
            kas = new Kas();
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
            piutang = new Piutang();
            stock = new Stock();
            stockGudang = new StockGudang();
            noBon = new NoBon();
            jual = new Jual();
            subjual = new SubJual();
            returJual = new RetJual();
            returSubJual = new RetSubJual();
            racikan = new Racikan();
            jasa = new Jasa();
            label15.Visible = false;
        }

        public Modul_Pembayaran(Modul_POS modulPos,Login login)
        {
            InitializeComponent();
            this.modulPos = modulPos;
            allfunc = new AllFunc();
            string[] custDataArr = modulPos.getCustomer();
            if (custDataArr[0].CompareTo("") == 0)
            {
                kodePelangganTxt.Text = "TUNAI";
                namaKodePelangganTxt.Text = "TUNAI";
                namaPasienTxt.Text = "TUNAI";
                alamatPasienTxt.Text = "";
                alamatTxt.Text = "";
            }
            else
            {
                kodePelangganTxt.Text = custDataArr[0];
                namaKodePelangganTxt.Text = custDataArr[1];
                namaPasienTxt.Text = custDataArr[1];
                alamatPasienTxt.Text = custDataArr[2];
                alamatTxt.Text = custDataArr[2];
            }
            this.jumlahPenjualan = modulPos.jumlahPenjualan;
            this.jumlahDiskon = modulPos.jumlahDiskon;
            this.jumlahPenjualanBruto = modulPos.jumlahPenjualanBruto;
            nettoTxt.Text = allfunc.digit_separated(Convert.ToString(this.jumlahPenjualan));
            discountRPTxt.Text = allfunc.digit_separated(Convert.ToString(modulPos.jumlahDiskon));
            
            dbo = new DbObject();
            kas = new Kas();
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
            piutang = new Piutang();
            stock = new Stock();
            stockGudang = new StockGudang();
            noBon = new NoBon();
            jual = new Jual();
            subjual = new SubJual();
            returJual = new RetJual();
            returSubJual = new RetSubJual();
            racikan = new Racikan();
            jasa = new Jasa();
            this.login = login;
            label15.Visible = false;
            kasir = login.username;
        }

        public Modul_Pembayaran(Modul_POS_Resep_Dokter modulPosResepDokter,Login login)
        {
            InitializeComponent();
            this.modulPosResepDokter = modulPosResepDokter;
            allfunc = new AllFunc();
            string[] custDataArr = modulPosResepDokter.getCustomer();
            string[] custDataArr2 = modulPosResepDokter.getCustomer2();
            string[] custDokterArr = modulPosResepDokter.getDokter();
            kodeDokterTxt.Text = custDokterArr[0];
            namaDokterTxt.Text = custDokterArr[1];
            if (custDataArr[0].CompareTo("") == 0)
            {
                kodePelangganTxt.Text = "TUNAI";
                namaKodePelangganTxt.Text = "TUNAI";
                namaPasienTxt.Text = "TUNAI";
                alamatPasienTxt.Text = "";
                alamatTxt.Text = "";
            }
            else
            {
                kodePelangganTxt.Text = custDataArr[0];
                namaKodePelangganTxt.Text = custDataArr[1];
                namaPasienTxt.Text = custDataArr[1];
                alamatPasienTxt.Text = custDataArr[2];
                alamatTxt.Text = custDataArr[2];
            }
            namaPasienTxt.Text = custDataArr2[0];
            umurPasienTxt.Text = custDataArr2[1];
            alamatPasienTxt.Text = custDataArr2[2];

            noResepTxt.Text = custDokterArr[2];
            this.jumlahPenjualan = modulPosResepDokter.jumlahPenjualan;
            this.jumlahDiskon = modulPosResepDokter.jumlahDiskon;
            this.jumlahPenjualanBruto = modulPosResepDokter.jumlahPenjualanBruto;
            nettoTxt.Text = allfunc.digit_separated(Convert.ToString(modulPosResepDokter.jumlahPenjualan));
            discountRPTxt.Text = allfunc.digit_separated(Convert.ToString(modulPosResepDokter.jumlahDiskon));
            
            dbo = new DbObject();
            kas = new Kas();
            obj = new JurnalUmum();
            subObj = new SubJurnalUmum();
            piutang = new Piutang();
            stock = new Stock();
            stockGudang = new StockGudang();
            noBon = new NoBon();
            jual = new Jual();
            subjual = new SubJual();
            returJual = new RetJual();
            returSubJual = new RetSubJual();
            racikan = new Racikan();
            jasa = new Jasa();
            this.login = login;
            label15.Visible = false;
            kasir = login.username;
        }

        public void setDataDokter(string[] dataDokterArr)
        {
            kodeDokterTxt.Text = dataDokterArr[0];
            namaDokterTxt.Text = dataDokterArr[1];
        }

        private void close()
        {
            if(modulPos!=null)
            {
                modulPos.Enabled = true;
            }
            else if (modulPosResepDokter != null)
            {
                modulPosResepDokter.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            bool sukses = false;
            string tunai_piutang = "K";
            string stockQuery = null;
            string subJurnalUmumQuery = null;
            string subJualQuery = null;
            string racikanQuery = null;
            string jasaQuery = null;

            SqlDataReader sdr = null;

            if (((dibayarTxt.Text.CompareTo("") == 0) || (dibayarTxt.Text.CompareTo("0") == 0))&&(tunaiRadioButton.Checked))
            {
                MessageBox.Show("Silakan input jumlah pembayaran.");
            }
            else
            {
            
            if (modulPos != null)
            {
                this.dgvItem = modulPos.getItemPenjualan();
            }
            else
            {
                this.dgvItem = modulPosResepDokter.getItemPenjualan();
            }

            if (tunaiRadioButton.Checked)
            {
                tunai_piutang = "T";
            }

            //if (tunaiRadioButton.Checked)
            //{

                //JU_SJU_NoBon_Kas_Jual_Piutang(TanggalKasir,KodePelanggan,NamaPelanggan,Tunai_Piutang,TglJT,NoResep,NamaPasien,AlamatPasien,KodeDokter,KasNetto,TotalDiskon,KasBruto,PPN

               double ppn = Convert.ToDouble(allfunc.remove_separated(ppnTxt.Text));
               double kasMsk = jumlahPenjualanBruto - jumlahDiskon + ppn;
               double dibayar = Convert.ToDouble(allfunc.remove_separated(dibayarTxt.Text));
               double kembalian = Convert.ToDouble(allfunc.remove_separated(kembaliTxt.Text));

               sdr = noBon.JU_SJU_NoBon_Kas_Jual_Piutang(DateTime.Today, kasir, kodePelangganTxt.Text, namaKodePelangganTxt.Text, tunai_piutang, tglJTdateTimePicker.Value, noResepTxt.Text, namaPasienTxt.Text, alamatPasienTxt.Text, kodeDokterTxt.Text,namaDokterTxt.Text, kasMsk, jumlahDiskon, jumlahPenjualanBruto,dibayar,kembalian , ppn);
               while (sdr.Read())
               {
                   nobon = (string)sdr[0];
                   nojurnal = (string)sdr[1];
               }


                //sdr = noBon.InsertRow(DateTime.Today, kasir, kodePelangganTxt.Text, namaKodePelangganTxt.Text, 0, 0, 0, 0, 0, "T", 0, tglJTdateTimePicker.Value, "P", 0, 0, "", "", "", "", 0, 0, noResepTxt.Text, namaPasienTxt.Text, alamatPasienTxt.Text, kodeDokterTxt.Text, namaDokterTxt.Text);
                //while (sdr.Read())
                //{
                //    nobon = (string)sdr["result"];
                //    nobarcode = (string)sdr["result2"];
                //}
                //sdr = obj.InsertRow(DateTime.Today, nobon, "Penjualan Tunai no. Faktur : " + nobon);
                //while (sdr.Read())
                //{
                //    nojurnal = (string)sdr["result"];
                //}


                //    double ppn = Convert.ToDouble(allfunc.remove_separated(ppnTxt.Text));
                //    double kasMsk = jumlahPenjualanBruto - jumlahDiskon + ppn;

                //    subObj.setDebitSystem(nojurnal, "11111", "Kas Masuk Penjualan Tunai no. faktur : " + nobon, (float)kasMsk);
                //    subObj.setDebitSystem(nojurnal, "411112", "Potongan Penjualan no. faktur : " + nobon, (float)jumlahDiskon);

                //    subObj.setKreditSystem(nojurnal, "41111", "Penjualan no. Faktur :" + nobon, (float)jumlahPenjualanBruto);
                //    subObj.setKreditSystem(nojurnal, "21141", "PPN Penjualan no. Faktur :" + nobon, (float)ppn);

                //    kas.InsertRowDebit(DateTime.Today, nobon, "Penjualan Tunai no. faktur :" + nobon, (float)kasMsk);

                //    totalProduk = 0.0;
                //    totalJasa = 0.0;
                    for (int i = 0; i < dgvItem.Rows.Count; i++)
                    {

                        string namaStock = dgvItem.Rows[i].Cells[1].Value.ToString();
                        string kodeStock = dgvItem.Rows[i].Cells[0].Value.ToString();
                        double qty = Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString()));
                        string satuan = dgvItem.Rows[i].Cells[3].Value.ToString();
                        double hargaJual = Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[4].Value.ToString()));
                        double discPersen = Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[5].Value.ToString()));
                        double disc = Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[6].Value.ToString()));
                        totalDiscRp += Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[6].Value.ToString()));
                        double subTotal = Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[7].Value.ToString()));
                        string jenisHarga = dgvItem.Rows[i].Cells[8].Value.ToString();

                        if (!namaStock.ToLower().Contains("jasa"))
                        {
                           // double hargaBeli = 0;
                            //sdr = dbo.get_single_data(new String[]{"HargaBeli"}, "kodeStock", dgvItem.Rows[i].Cells[0].Value.ToString() ,"stock");
                            //while (sdr.Read()) { hargaBeli = (double)sdr["HargaBeli"]; }
                            //double hpp = hargaBeli * Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString()));

                            //subObj.setDebitSystem(nojurnal, "61111", "HPP :" + namaStock, (float)hpp);
                            //subObj.setKreditSystem(nojurnal, "11311", "Persediaan Barang Dagang", (float)hpp);
                            subJurnalUmumQuery += "EXEC [dbo].[SubJurnalUmum_Insert_stock_hpp_pbd] '" + nojurnal + "','" + kodeStock + "'," + qty + ",'debit','hpp';";
                            subJurnalUmumQuery += "EXEC [dbo].[SubJurnalUmum_Insert_stock_hpp_pbd] '" + nojurnal + "','" + kodeStock + "'," + qty + ",'kredit','pbd';";

                            if (modulPos != null)
                            {
                                subJualQuery += "EXEC [dbo].[SubJual_Insert] '" + nobon + "','" + kodeStock + "'," + qty + "," + hargaJual + "," + subTotal + "," + disc + "," + discPersen + "," + subTotal + ",'" + jenisHarga + "',0,0,0,0;";
                                
                                    //@NoBon varchar(50) = NULL,
                                    //@KodeStock varchar(25) = NULL,
                                    //@Qty float = NULL,
                                    //@Harga float = NULL,
                                    //@Jumlah float = NULL,
                                    //@Discount float = NULL,
                                    //@DiscountPersent float = NULL,
                                    //@TotalPenjualan float = NULL,
                                    //@JenisHarga varchar(25) = NULL,
                                    //@konsinyasi bit = NULL,
                                    //@Tuslah1 float = NULL,
                                    //@Tuslah2 float = NULL,
                                    //@Embalase float = NULL
                                
                                //subjual.InsertRow(nobon, dgvItem.Rows[i].Cells[0].Value.ToString(), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[4].Value.ToString())), (float)hpp, (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[6].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[5].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[7].Value.ToString())), dgvItem.Rows[i].Cells[8].Value.ToString(), 0, 0, 0, 0);
                            }
                            else
                            {
                                racikanQuery += "EXEC [dbo].[racikan_Insert] '" + nobon + "','" + kodeStock + "','',''," + qty + ",'" + satuan + "'," + subTotal + ",'" + noResepTxt.Text + "','" + kodeDokterTxt.Text + "','','" + namaPasienTxt.Text + "','" + umurPasienTxt.Text + "'," + hargaJual + "," + discPersen + "," + disc + ",'" + kodePelangganTxt.Text + "','"+namaKodePelangganTxt.Text+"';";
                                //racikan.InsertRow(nobon, dgvItem.Rows[i].Cells[0].Value.ToString(), "", "", (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString())), dgvItem.Rows[i].Cells[3].Value.ToString(), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[7].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[6].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[5].Value.ToString())), noResepTxt.Text, kodeDokterTxt.Text, DateTime.Today, namaPasienTxt.Text, umurPasienTxt.Text, (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[4].Value.ToString())), kodePelangganTxt.Text, "");
                            }
                            if (!namaStock.ToLower().Contains("tuslah"))
                            {
                                stockQuery += "EXEC [dbo].[Stock_Update_Jumlah_terjual] '" + kodeStock + "'," + qty + ",'" + kodeGudangTxt.ValueMember + "';"; 
                                //stock.UpdateJumlahTerjual(dgvItem.Rows[i].Cells[0].Value.ToString(), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString())), kodeGudangTxt.ValueMember);
                            }
                            
                            totalProduk += subTotal;
                        }
                        else
                        {
                            jasaQuery += "EXEC [dbo].[Jasa_Insert] '" + nobon + "','" + kodeStock + "'," + qty + "," + hargaJual + ";";
                            //jasa.InsertRow(nobon, dgvItem.Rows[i].Cells[0].Value.ToString(), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[4].Value.ToString())));
                            //totalJasa += Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[7].Value.ToString()));
                            totalJasa += subTotal;
                        }

                    }
                    //noBon.SJU_Stock_SubJual_Racikan(stockQuery,subJurnalUmumQuery,subJualQuery,racikanQuery,jasaQuery);
                    //subJurnalUmumQuery parah
                    dbo.run_query(stockQuery+subJurnalUmumQuery + subJualQuery + racikanQuery + jasaQuery);
                    //jual.InsertRow(nobon, DateTime.Today, (float)jumlahPenjualan, kasir, DateTime.Today, noResepTxt.Text, kodePelangganTxt.Text, namaKodePelangganTxt.Text, 0, DateTime.Today, "", kodeDokterTxt.Text);
                    //sdr = dbo.get_single_data(new string[] { "Nobon", "NamaStock", "satuan", "qty", "Harga", "Jumlah", "totalpenjualan" }, "nobon", nobon, "view_subjual_stock");
                    //DbObject dbo1 = new DbObject();
                    //SqlDataReader sdrjasa = dbo1.get_single_data(new string[] { "nobukti", "NamaJasa", "qty", "Harga" }, "nobukti", nobon, "view_jasa_dokter");                

            //}
            //else
            //{
                //sdr = noBon.InsertRow(DateTime.Today, kasir, kodePelangganTxt.Text, namaKodePelangganTxt.Text, 0, 0, 0, 0, 0, "K", 0, tglJTdateTimePicker.Value, "P", 0, 0, "", "", "", "", 0, 0, noResepTxt.Text, namaPasienTxt.Text, alamatPasienTxt.Text, kodeDokterTxt.Text, namaDokterTxt.Text);
                //while (sdr.Read())
                //{
                //    nobon = (string)sdr["result"];
                //    nobarcode = (string)sdr["result2"];
                //}
                //sdr = obj.InsertRow(DateTime.Today, nobon, "Penjualan Kredit No. Faktur : " + nobon);
                //while (sdr.Read())
                //{
                //    nojurnal = (string)sdr["result"];
                //}

                //    double ppn = Convert.ToDouble(allfunc.remove_separated(ppnTxt.Text));
                //    double kasMsk = jumlahPenjualanBruto - jumlahDiskon + ppn;

                //    subObj.setDebitSystem(nojurnal, "11211", "Piutang Penjualan no. faktur : " + nobon, (float)kasMsk);
                //    subObj.setDebitSystem(nojurnal, "411112", "Potongan Penjualan no. faktur : " + nobon, (float)jumlahDiskon);

                //    subObj.setKreditSystem(nojurnal, "41111", "Penjualan no. Faktur :" + nobon, (float)jumlahPenjualanBruto);
                //    subObj.setKreditSystem(nojurnal, "21141", "PPN Penjualan no. Faktur :" + nobon, (float)ppn);

                //    piutang.InsertRowDebit(DateTime.Today, nobon, kodePelangganTxt.Text, "TOKO", "TOKO", (float)kasMsk, (float)kasMsk, tglJTdateTimePicker.Value, "", 0);

                //    totalProduk = 0.0;
                //    totalJasa = 0.0;

                //    for (int i = 0; i < dgvItem.Rows.Count; i++)
                //    {
                //        string namaStock = dgvItem.Rows[i].Cells[1].Value.ToString();
                //        totalDiscRp += Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[6].Value.ToString()));


                //        if (!namaStock.ToLower().Contains("jasa"))
                //        {
                            //double hargaBeli = 0;
                            //sdr = dbo.get_single_data(new String[] { "HargaBeli" }, "kodeStock", dgvItem.Rows[i].Cells[0].Value.ToString(), "stock");
                            //while (sdr.Read()) { hargaBeli = (double)sdr["HargaBeli"]; }
                            //double hpp = hargaBeli * Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString()));

                            //subObj.setDebitSystem(nojurnal, "61111", "HPP :" + namaStock, (float)hpp);
                            //subObj.setKreditSystem(nojurnal, "11311", "Persediaan Barang Dagang", (float)hpp);

                            //if (modulPos != null)
                            //{
                            //    subjual.InsertRow(nobon, dgvItem.Rows[i].Cells[0].Value.ToString(), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[4].Value.ToString())), (float)hpp, (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[6].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[5].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[7].Value.ToString())), dgvItem.Rows[i].Cells[8].Value.ToString(), 0, 0, 0, 0);
                            //}
                            //else
                            //{
                            //    racikan.InsertRow(nobon, dgvItem.Rows[i].Cells[0].Value.ToString(), "", "", (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString())), dgvItem.Rows[i].Cells[3].Value.ToString(), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[7].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[6].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[5].Value.ToString())), noResepTxt.Text, kodeDokterTxt.Text, DateTime.Today, namaPasienTxt.Text, umurPasienTxt.Text, (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[4].Value.ToString())), kodePelangganTxt.Text, "");
                            //}
                            //if (!namaStock.ToLower().Contains("tuslah"))
                            //{
                            //    stock.UpdateJumlahTerjual(dgvItem.Rows[i].Cells[0].Value.ToString(), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString())), kodeGudangTxt.ValueMember);
                            //}

            //                totalProduk += Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[7].Value.ToString()));
            //            }
            //            else
            //            {
            //                //jasa.InsertRow(nobon, dgvItem.Rows[i].Cells[0].Value.ToString(), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[2].Value.ToString())), (float)Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[4].Value.ToString())));
            //                totalJasa += Convert.ToDouble(allfunc.remove_separated(dgvItem.Rows[i].Cells[7].Value.ToString()));
            //            }

            //        }
            //        jual.InsertRow(nobon, DateTime.Today, (float)jumlahPenjualan, kasir, DateTime.Today, noResepTxt.Text, kodePelangganTxt.Text, namaKodePelangganTxt.Text, 0, DateTime.Today, "", kodeDokterTxt.Text);

            //        //sdr = dbo.get_single_data(new string[] { "Nobon", "NamaStock", "satuan", "qty", "Harga", "Jumlah", "totalpenjualan" }, "nobon", nobon, "view_subjual_stock");
            //        //DbObject dbo1 = new DbObject();
            //        //SqlDataReader sdrjasa = dbo1.get_single_data(new string[] { "nobukti", "NamaJasa", "qty", "Harga" }, "nobukti", nobon, "view_jasa_dokter");

            //}
            printUlangStruk(1);
            }
        }

        private void backToPOS()
        {
            if (modulPos != null)
            {
                modulPos.reset();
            }
            else
            {
                modulPosResepDokter.reset();
            }
            close();
        }

        private void printUlangStruk(int trigger)
        {
            if(trigger == 0)
            {
                if (MessageBox.Show("Apakah Anda ingin mencetak ulang struk ?", "Print Ulang Struk", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    printUlangStruk(1);
                }
                else
                {
                    backToPOS();
                }
            }
            else if(trigger == 1)
            {

                if (modulPos != null)
                {
                    /*Print Struk*/
                    //print.printTransaksiObatBebas(nobarcode, nobon, kasir, namaKodePelangganTxt.Text, alamatPasienTxt.Text, dgvItem, jumlahPenjualanBruto, jumlahDiskon, Convert.ToDouble(allfunc.remove_separated(nettoTxt.Text)), Convert.ToDouble(allfunc.remove_separated(dibayarTxt.Text)), Convert.ToDouble(allfunc.remove_separated(kembaliTxt.Text)));
                    print.printTransaksiObatBebasDirectPrint(nobarcode, nobon, kasir, namaKodePelangganTxt.Text, alamatPasienTxt.Text, this.dgvItem, jumlahPenjualanBruto, jumlahDiskon, Convert.ToDouble(allfunc.remove_separated(nettoTxt.Text)), Convert.ToDouble(allfunc.remove_separated(dibayarTxt.Text)), Convert.ToDouble(allfunc.remove_separated(kembaliTxt.Text)));
                    /*Print Struk End*/
                }
                else
                {
                    /*Struk Print*/
                    //print.printTransaksiResep(nobarcode, nobon, kasir, namaKodePelangganTxt.Text, noResepTxt.Text, namaPasienTxt.Text, alamatPasienTxt.Text, namaDokterTxt.Text, totalJasa, totalProduk, jumlahPenjualanBruto, jumlahDiskon, Convert.ToDouble(allfunc.remove_separated(nettoTxt.Text)), Convert.ToDouble(dibayarTxt.Text), Convert.ToDouble(kembaliTxt.Text));
                    print.printTransaksiResepDirectPrint(nobarcode, nobon, kasir, namaKodePelangganTxt.Text, noResepTxt.Text, namaPasienTxt.Text, alamatPasienTxt.Text, namaDokterTxt.Text, totalJasa, totalProduk, jumlahPenjualanBruto, jumlahDiskon, Convert.ToDouble(allfunc.remove_separated(nettoTxt.Text)), Convert.ToDouble(dibayarTxt.Text), Convert.ToDouble(kembaliTxt.Text));
                    /*End Struk Print*/
                }

                backToPOS();
                //printUlangStruk(0);
            }
        }

        private void kodeDokterBtn_Click(object sender, EventArgs e)
        {
            Modul_Data_Dokter_PopUp dokter = new Modul_Data_Dokter_PopUp(this);
            dokter.Show();
            this.Enabled = false;
        }

        private void kreditRadioButton_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
            label14.Visible = false;
            label16.Visible = false;
            kembaliTxt.Visible = false;
            dibayarTxt.Visible = false;
            tglJTdateTimePicker.Enabled = true;

        }

        private void tunaiRadioButton_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
            label14.Visible = true;
            label16.Visible = true;
            kembaliTxt.Visible = true;
            dibayarTxt.Visible = true;
            tglJTdateTimePicker.Enabled = false;
        }

        private void calculateTax()
        {
            double ppn = 0.0;
            if (checkBox1.Checked)
            {
                ppn = jumlahPenjualan * 0.1;
                ppnTxt.Text = allfunc.digit_separated(Convert.ToString(ppn));
            }
            else
            {
                ppnTxt.Text = "0";
            }
            double netto = jumlahPenjualan + ppn;
            nettoTxt.Text = allfunc.digit_separated(Convert.ToString(netto));
        }

        private void calculate()
        {
            /*double ppn = 0.0;
            if (checkBox1.Checked)
            {
                ppn = jumlahPenjualan * 0.1;
                ppnTxt.Text = allfunc.digit_separated(Convert.ToString(ppn));
            }
            else
            {
                ppnTxt.Text = "0";
            }*/
            double netto = Convert.ToDouble(nettoTxt.Text);
            nettoTxt.Text = allfunc.digit_separated(Convert.ToString(netto));
            if ((Convert.ToDouble(allfunc.remove_separated(dibayarTxt.Text)) != 0) && (Convert.ToDouble(allfunc.remove_separated(dibayarTxt.Text)) >= netto))
            {
                kembaliTxt.Text = allfunc.digit_separated((Convert.ToDouble(allfunc.remove_separated(dibayarTxt.Text)) - netto).ToString());
            }
            else
            {
                MessageBox.Show("Uang Dibayar tidak cukup untuk melakukan transaksi.");
            }
            
        }

        private void dibayarTxt_KeyDown(object sender, KeyEventArgs e)
        {
            allfunc.digit_filter(sender, e, "Uang Dibayar");
            if (e.KeyData == Keys.Enter)
            {
                calculate();
                kembaliTxt.Focus();
            }
        }


        private void dibayarTxt_Enter(object sender, EventArgs e)
        {
            dibayarTxt.Text = allfunc.remove_separated(dibayarTxt.Text);
        }

        private void dibayarTxt_Leave(object sender, EventArgs e)
        {
            dibayarTxt.Text = allfunc.digit_separated(dibayarTxt.Text);
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            close();
        }

        private void Modul_Pembayaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_Data.Gudang' table. You can move, or remove it, as needed.
            this.gudangTableAdapter.Fill(this.stock_Data.Gudang);
            dibayarTxt.Select();
        }

        private void kodeDokterTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void namaDokterTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            calculateTax();
        }

        private void kembaliTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                okBtn.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
