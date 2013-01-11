using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Accounting_Solution_Software
{
    public partial class MainForm : Form
    {
        public Login login = null;
        private Modul_Pembelian pembelian = null;
        private Modul_Pembelian_Retur formPembelianRetur = null;
        private Modul_Pembelian_DaftarHutang bayarHutang = null;
        private Modul_Pembelian_PurchaseOrder purchaseOrder = null;
        private Modul_Barang_Penerimaan penerimaanBarang = null;
        private Modul_Kas_Kecil kasKecil = null;
        private Modul_Kas_Besar kasBesar = null;
        private Modul_Akuntansi_JurnalUmum jurnalUmum = null;
        private Modul_Laporan_BukuBesar laporanBukuBesar = null;
        private Modul_Akuntansi_TutupBuku modulTutupBuku = null;
        private Modul_Akuntansi_KodePerkiraan kodePerkiraan = null;
        private Modul_Data_Supplier supplier = null;
        private Modul_Data_Gudang gudang = null;
        private Modul_Barang_Pemindahan mutasi = null;
        private Modul_Barang_Data dataBarang = null;
        private Modul_Data_Bank bank = null;
        private Modul_Barang_DataKelompok dataKelompokBarang = null;
        private Modul_Penjualan_Daftar formPenjualanDaftar = null;
        private Modul_Barang_StockOpname stockOpname = null;
        private Modul_Barang_DataSatuan satuan = null;
        private Modul_Data_Kota kota = null;
        private Modul_Laporan_Pembelian laporanPembelian = null;
        private Modul_Lapuran_Penjualan laporanPenjualan = null;
        private Modul_Laporan_StockOpname laporanStockOpname = null;
        private Modul_Laporan_LabaRugi laporanLabaRugi = null;
        private Modul_Laporan_Neraca laporanNeraca = null;
        private Modul_Laporan_Transfer_stock laporanStock = null;
        private Modul_Laporan_Hutang laporanHutang = null;
        private Modul_Laporan_Arus_KasKecil laporanArusKasKecil = null;
        private Modul_Data_Karyawan karyawan = null;
        private Modul_Data_Login kewenangan = null;
        private Modul_Akuntansi_SaldoAwal saldoAwal = null;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modul_Data_Customer customer = new Modul_Data_Customer(this);
            customer.Show();
            disable_Main_Form();
        }

        private void importDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "calc.exe";
            p.Start();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stock_Data.view_stock_gudang' table. You can move, or remove it, as needed.
            this.view_stock_gudangTableAdapter.Fill(this.stock_Data.view_stock_gudang);
            // TODO: This line of code loads data into the 'stock_Data.KelompokProduk' table. You can move, or remove it, as needed.            
            this.kelompokProdukTableAdapter.Fill(this.stock_Data.KelompokProduk);
            // TODO: This line of code loads data into the 'stock_Data.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.stock_Data.Stock);

        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_kas_besar();
        }

        private void btn_Pembelian_PO_Click(object sender, EventArgs e)
        {
            open_modul_pembelian();
        }

        private void btn_Pembelian_Retur_Click(object sender, EventArgs e)
        {
            open_modul_pembelian_retur();
        }

        private void disable_Main_Form()
        {
            this.Enabled = false; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            open_modul_master_supplier();
        }

        private void btn_data_group_Click(object sender, EventArgs e)
        {
            Modul_Data_Group group = new Modul_Data_Group(this);
            group.Show();
            disable_Main_Form();
        }

        private void btn_data_customer_Click(object sender, EventArgs e)
        {
            Modul_Data_Customer customer = new Modul_Data_Customer(this);
            customer.Show();
            disable_Main_Form();
        }

        private void btn_data_salesman_Click(object sender, EventArgs e)
        {
            Modul_Data_Salesman salesman = new Modul_Data_Salesman(this);
            salesman.Show();
            disable_Main_Form();
        }

        private void btn_data_dokter_Click(object sender, EventArgs e)
        {
            Modul_Data_Dokter dokter = new Modul_Data_Dokter(this);
            dokter.Show();
            disable_Main_Form();
        }

        private void btn_data_jasa_dokter_Click(object sender, EventArgs e)
        {
            Modul_Data_JasaDokter jasaDokter = new Modul_Data_JasaDokter(this);
            jasaDokter.Show();
            disable_Main_Form();
        }

        private void btn_data_gudang_Click(object sender, EventArgs e)
        {
            open_modul_stock_gudang();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            open_modul_stock_mutasi();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            open_modul_master_satuan();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            open_modul_stock_data();
        }

        private void linklbl_Supplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            open_modul_master_supplier();
        }

        private void linkLbl_Customer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modul_Data_Customer customer = new Modul_Data_Customer(this);
            customer.Show();
            disable_Main_Form();
        }

        private void linkLbl_Salesman_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modul_Data_Karyawan karyawan = new Modul_Data_Karyawan(this);
            karyawan.Show();
            disable_Main_Form();
        }

        private void linkLbl_GroupCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modul_Data_Group group = new Modul_Data_Group(this);
            group.Show();
            disable_Main_Form();
        }

        private void linkLbl_Dokter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modul_Data_Dokter dokter = new Modul_Data_Dokter(this);
            dokter.Show();
            disable_Main_Form();
        }

        private void linkLbl_JasaDokter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modul_Data_JasaDokter jasaDokter = new Modul_Data_JasaDokter(this);
            jasaDokter.Show();
            disable_Main_Form();
        }

        private void linkLbl_SatuanStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            open_modul_master_satuan();
        }

        private void linkLbl_Gudang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            open_modul_stock_gudang();
        }

        private void linkLbl_kota_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            open_modul_master_kota();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            open_modul_master_bank();
        }

        private void linkLbl_Pajak_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Modul_Data_Pajak pajak = new Modul_Data_Pajak(this);
            pajak.Show();
            disable_Main_Form();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stock_Data);

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (login.checkPrevilege(new string[] { "mdb", "stckdef" }))
            {
                if (toolStripButton1.Text.CompareTo("Info Barang") == 0)
                {
                    this.view_stock_gudangTableAdapter.Fill(this.stock_Data.view_stock_gudang);
                    this.kelompokProdukTableAdapter.Fill(this.stock_Data.KelompokProduk);
                    this.stockTableAdapter.Fill(this.stock_Data.Stock);
                    stockDataGridView1.Refresh();
                    toolStripButton1.Text = "Close";
                    splitContainer2.Show();
                }
                else
                {
                    toolStripButton1.Text = "Info Barang";
                    splitContainer2.Hide();
                }
            }  
        }

        private void btn_Kas_Besar_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_kas_besar();
        }

        private void btn_Kas_Kecil_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_kas_kecil();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                stockBindingSource.Filter = "KodeStock LIKE '%" + txtSearch.Text + "%' OR NamaStock LIKE '%" + txtSearch.Text + "%'";

                    stockDataGridView1.DataSource = stockBindingSource;
                    stockDataGridView1.Refresh();

            }
            catch (System.Reflection.TargetInvocationException ti_e)
            {
            }
        }


        public void refreshStockGudangDataGridView()
        {
            try
            {
                IEnumerable<Accounting_Solution_Software.Data_set.Stock_Data.view_stock_gudangRow> query =
                from gudangStockData in this.stock_Data.view_stock_gudang.AsEnumerable()
                where gudangStockData.Field<String>("KodeStock").ToLower().Contains(stockDataGridView1.Rows[stockDataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString().ToLower())
                select gudangStockData;

                //view_stock_gudangBindingSource.DataSource = query.CopyToDataTable();
                //view_stock_gudangDataGridView.DataSource = query.ToList();
                //view_stock_gudangDataGridView.Refresh();

            }
            catch (InvalidOperationException inv_e)
            {
                //view_stock_gudangDataGridView.DataSource = null;
            }

        }

        private void stockDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshStockGudangDataGridView();
        }


        private void stockDataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            refreshStockGudangDataGridView();
        }

        private void linkLbl_KodePerkiraan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            open_modul_akuntansi_kode_perkiraan();
        }

        private void btn_Pembelian_KasKecil_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_kas_kecil();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            open_modul_pembelian();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            open_modul_stock_opname();
        }

        private void btn_Pembelian_DaftarHutang_Click(object sender, EventArgs e)
        {
            open_modul_pembelian_hutang();
        }

        private void btn_Penjualan_DaftarPiutang_Click(object sender, EventArgs e)
        {
            Modul_Penjualan_DaftarPiutang bayarPiutang = new Modul_Penjualan_DaftarPiutang(this);
            bayarPiutang.Show();
            disable_Main_Form();
        }

        private void dataSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_modul_master_supplier();
        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_modul_stock_data();
        }

        private void dataCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modul_Data_Customer customer = new Modul_Data_Customer(this);
            customer.Show();
            disable_Main_Form();
        }

        private void dataSalesmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modul_Data_Salesman salesman = new Modul_Data_Salesman(this);
            salesman.Show();
            disable_Main_Form();
        }

        private void dataJasaDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modul_Data_JasaDokter jasaDokter = new Modul_Data_JasaDokter(this);
            jasaDokter.Show();
            disable_Main_Form();
        }

        private void dataDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modul_Data_Dokter dokter = new Modul_Data_Dokter(this);
            dokter.Show();
            disable_Main_Form();
        }

        private void controlAccontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            open_modul_pembelian_hutang();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Modul_Penjualan_DaftarPiutang bayarPiutang = new Modul_Penjualan_DaftarPiutang(this);
            bayarPiutang.Show();
            disable_Main_Form();
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_kas_kecil();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.logout();
            this.Visible = false;
            login.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            login.Close();
            login.Dispose();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "notepad.exe";
            p.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            open_modul_stock_penerimaan_barang();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            open_modul_pembelian_retur();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Modul_Penjualan_Retur form_penjualan_retur = new Modul_Penjualan_Retur(this);
            form_penjualan_retur.Show();
            disable_Main_Form();
        }

        private void btn_Penjualan_Retur_Click(object sender, EventArgs e)
        {
            Modul_Penjualan_Retur form_penjualan_retur = new Modul_Penjualan_Retur(this);
            form_penjualan_retur.Show();
            disable_Main_Form();
        }

        private void daftarPenjualanBtn_Click(object sender, EventArgs e)
        {
            open_modul_penjualan_laporan();
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.login.Close();
            this.login.Dispose();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            open_modul_laporan_pembelian();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            open_modul_laporan_penjualan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modul_Laporan_PendapatanJasa laporanPendapatanJasa = new Modul_Laporan_PendapatanJasa();
            laporanPendapatanJasa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_jurnal_umum();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_buku_besar();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_laba_rugi();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_neraca_keuangan();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            open_modul_stock_saldo();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            open_modul_pembelian_laporan_hutang();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Modul_Laporan_Piutang laporanPiutang = new Modul_Laporan_Piutang();
            laporanPiutang.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_laporan_kas_besar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_laporan_kas_kecil();
        }

        private void linkLbl_GroupStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            open_modul_master_jenis_barang();
        }

        private void dataUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_modul_data_karyawan();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            open_modul_laporan_stock_Opname();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            open_modul_penjualan_laporan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_tutup_buku();
        }

        private void btn_purchase_order_Click(object sender, EventArgs e)
        {
            open_modul_pembelian_purchase_order();
        }

        private void open_modul_pembelian_purchase_order()
        {
            if (login.checkPrevilege(new string[] { "mopo", "prchsdef" }))
            {
                if (purchaseOrder != null)
                {
                    purchaseOrder.Close();
                    purchaseOrder.Dispose();
                }
                purchaseOrder = new Modul_Pembelian_PurchaseOrder();
                purchaseOrder.Show();
            }
        }

        private void open_modul_pembelian()
        {
            if (login.checkPrevilege(new string[] { "mop", "prchsdef" }))
            {
                if (pembelian != null)
                {
                    pembelian.Close();
                    pembelian.Dispose();
                }
                pembelian = new Modul_Pembelian(this);
                pembelian.Show();
            }
        }

        private void open_modul_pembelian_retur()
        {
            if (login.checkPrevilege(new string[] { "mopr", "prchsdef" }))
            {
                if (formPembelianRetur != null)
                {
                    formPembelianRetur.Close();
                    formPembelianRetur.Dispose();
                }
                formPembelianRetur = new Modul_Pembelian_Retur(this);
                formPembelianRetur.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_pembelian_hutang()
        {
            if (login.checkPrevilege(new string[] { "moph", "prchsdef" }))
            {
                if (bayarHutang != null)
                {
                    bayarHutang.Close();
                    bayarHutang.Dispose();
                }
                bayarHutang = new Modul_Pembelian_DaftarHutang(this);
                bayarHutang.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_stock_penerimaan_barang()
        {
            if (login.checkPrevilege(new string[] { "mospb", "prchsdef" }))
            {
                if (penerimaanBarang != null)
                {
                    penerimaanBarang.Close();
                    penerimaanBarang.Dispose();
                }
                penerimaanBarang = new Modul_Barang_Penerimaan(this);
                penerimaanBarang.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_akuntansi_kas_kecil()
        {
            if (login.checkPrevilege(new string[] { "moakkk", "accdef" }))
            {
                if (kasKecil != null)
                {
                    kasKecil.Close();
                    kasKecil.Dispose();
                }
                kasKecil = new Modul_Kas_Kecil(this);
                kasKecil.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_akuntansi_kas_besar()
        {
            if (login.checkPrevilege(new string[] { "moakkb", "accdef" }))
            {
                if (kasBesar != null)
                {
                    kasBesar.Close();
                    kasBesar.Dispose();
                }
                kasBesar = new Modul_Kas_Besar(this);
                kasBesar.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_akuntansi_jurnal_umum()
        {
            if (login.checkPrevilege(new string[] { "moakju", "accdef" }))
            {
                if (jurnalUmum != null)
                {
                    jurnalUmum.Close();
                    jurnalUmum.Dispose();
                }
                jurnalUmum = new Modul_Akuntansi_JurnalUmum();
                jurnalUmum.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_akuntansi_buku_besar()
        {
            if (login.checkPrevilege(new string[] { "moakbb", "accdef" }))
            {
                if (laporanBukuBesar != null)
                {
                    laporanBukuBesar.Close();
                    laporanBukuBesar.Dispose();
                }
                laporanBukuBesar = new Modul_Laporan_BukuBesar();
                laporanBukuBesar.Show();
            }

        }

        private void open_modul_akuntansi_tutup_buku()
        {
            if (login.checkPrevilege(new string[] { "moaktb", "accdef" }))
            {

                if (modulTutupBuku != null)
                {
                    modulTutupBuku.Close();
                    modulTutupBuku.Dispose();
                }
                modulTutupBuku = new Modul_Akuntansi_TutupBuku(this);
                modulTutupBuku.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_akuntansi_kode_perkiraan()
        {
            if (login.checkPrevilege(new string[] { "moakkp", "accdef" }))
            {
                if (kodePerkiraan != null)
                {
                    kodePerkiraan.Close();
                    kodePerkiraan.Dispose();
                }
                kodePerkiraan = new Modul_Akuntansi_KodePerkiraan(this);
                kodePerkiraan.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_master_supplier()
        {
            if (login.checkPrevilege(new string[] { "mds", "mstrdef" }))
            {
                if (supplier != null)
                {
                    supplier.Close();
                    supplier.Dispose();
                }
                supplier = new Modul_Data_Supplier(this);
                supplier.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_stock_gudang()
        {
            if (login.checkPrevilege(new string[] { "mdc", "mstrdef" }))
            {
                if (gudang != null)
                {
                    gudang.Close();
                    gudang.Dispose();
                }
                gudang = new Modul_Data_Gudang(this);
                gudang.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_stock_mutasi()
        {
            if (login.checkPrevilege(new string[] { "mosts", "stckdef" }))
            {
                if (mutasi != null)
                {
                    mutasi.Close();
                    mutasi.Dispose();
                }
                mutasi = new Modul_Barang_Pemindahan(this);
                mutasi.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_stock_data()
        {
            if (login.checkPrevilege(new string[] { "mdb", "stckdef" }))
            {
                if (dataBarang != null)
                {
                    dataBarang.Close();
                    dataBarang.Dispose();
                }
                dataBarang = new Modul_Barang_Data(this);
                dataBarang.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_master_bank()
        {
            if (bank != null)
            {
                bank.Close();
                bank.Dispose();
            }
            bank = new Modul_Data_Bank(this);
            bank.Show();
            //disable_Main_Form();
        }

        private void open_modul_master_jenis_barang()
        {
            if (login.checkPrevilege(new string[] { "mdjb", "mstrdef" }))
            {
                if (dataKelompokBarang != null)
                {
                    dataKelompokBarang.Close();
                    dataKelompokBarang.Dispose();
                }
                dataKelompokBarang = new Modul_Barang_DataKelompok(this);
                dataKelompokBarang.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_penjualan_laporan()
        {
            if (login.checkPrevilege(new string[] { "mopjl", "slsdef" }))
            {
                if (formPenjualanDaftar != null)
                {
                    formPenjualanDaftar.Close();
                    formPenjualanDaftar.Dispose();
                }
                formPenjualanDaftar = new Modul_Penjualan_Daftar(this);
                formPenjualanDaftar.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_stock_opname()
        {
            if (login.checkPrevilege(new string[] { "mosso", "stckdef" }))
            {
                if (stockOpname != null)
                {
                    stockOpname.Close();
                    stockOpname.Dispose();
                }
                stockOpname = new Modul_Barang_StockOpname(this);
                stockOpname.Show();
                //disable_Main_Form();
            }
        }

        private void open_modul_master_satuan()
        {
            if (satuan != null)
            {
                satuan.Close();
                satuan.Dispose();
            }
            satuan = new Modul_Barang_DataSatuan(this);
            satuan.Show();
            //disable_Main_Form();
        }

        private void open_modul_master_kota()
        {
            if (kota != null)
            {
                kota.Close();
                kota.Dispose();
            }
            kota = new Modul_Data_Kota(this);
            kota.Show();
            //disable_Main_Form();
        }

        private void open_modul_laporan_pembelian()
        {
            if (login.checkPrevilege(new string[] { "mopl", "prchsdef" }))
            {
                if (laporanPembelian != null)
                {
                    laporanPembelian.Close();
                    laporanPembelian.Dispose();
                }
                laporanPembelian = new Modul_Laporan_Pembelian();
                laporanPembelian.Show();
            }
        }

        private void open_modul_laporan_penjualan()
        {
            if (login.checkPrevilege(new string[] { "mopjl", "slsdef" }))
            {
                if (laporanPenjualan != null)
                {
                    laporanPenjualan.Close();
                    laporanPenjualan.Dispose();
                }
                laporanPenjualan = new Modul_Lapuran_Penjualan();
                laporanPenjualan.Show();
            }
        }

        private void open_modul_laporan_stock_Opname()
        {
            if (login.checkPrevilege(new string[] { "moslso", "stckdef" }))
            {
                if (laporanStockOpname != null)
                {
                    laporanStockOpname.Close();
                    laporanStockOpname.Dispose();
                }
                laporanStockOpname = new Modul_Laporan_StockOpname();
                laporanStockOpname.Show();
            }
        }

        private void open_modul_akuntansi_laba_rugi()
        {
            if (login.checkPrevilege(new string[] { "moakll", "accdef" }))
            {
                if (laporanLabaRugi != null)
                {
                    laporanLabaRugi.Close();
                    laporanLabaRugi.Dispose();
                }
                laporanLabaRugi = new Modul_Laporan_LabaRugi();
                laporanLabaRugi.Show();
            }
        }

        private void open_modul_akuntansi_neraca_keuangan()
        {
            if (login.checkPrevilege(new string[] { "moakn", "accdef" }))
            {
                if (laporanNeraca != null)
                {
                    laporanNeraca.Close();
                    laporanNeraca.Dispose();
                }
                laporanNeraca = new Modul_Laporan_Neraca();
                laporanNeraca.Show();
            }
        }

        private void open_modul_stock_saldo()
        {
            if (login.checkPrevilege(new string[] { "mosss", "stckdef" }))
            {
                if (laporanStock != null)
                {
                    laporanStock.Close();
                    laporanStock.Dispose();
                }
                laporanStock = new Modul_Laporan_Transfer_stock();
                laporanStock.Show();
            }
        }

        private void open_modul_pembelian_laporan_hutang()
        {
            if (login.checkPrevilege(new string[] { "moplh", "prchsdef" }))
            {
                if (laporanHutang != null)
                {
                    laporanHutang.Close();
                    laporanHutang.Dispose();
                }
                laporanHutang = new Modul_Laporan_Hutang();
                laporanHutang.Show();
            }
        }

        private void open_modul_akuntansi_laporan_kas_kecil()
        {
            if (login.checkPrevilege(new string[] { "moaklkk", "accdef" }))
            {
                if (laporanArusKasKecil != null)
                {
                    laporanArusKasKecil.Close();
                    laporanArusKasKecil.Dispose();
                }
                laporanArusKasKecil = new Modul_Laporan_Arus_KasKecil();
                laporanArusKasKecil.Show();
            }
        }

        private void open_modul_akuntansi_laporan_kas_besar()
        {

        }
        
        private void open_modul_akuntansi_saldo_awal()
        {
            if (login.checkPrevilege(new string[] { "moaksa", "accdef" }))
            {
                if (saldoAwal != null)
                {
                    saldoAwal.Close();
                    saldoAwal.Dispose();
                }
                saldoAwal = new Modul_Akuntansi_SaldoAwal();
                saldoAwal.Show();
            }
        }

        private void open_modul_data_karyawan()
        {
            if (login.checkPrevilege(new string[] { "mdp", "mstrdef" }))
            {
                if (karyawan != null)
                {
                    karyawan.Close();
                    karyawan.Dispose();
                }
                karyawan = new Modul_Data_Karyawan(this);
                karyawan.Show();
                disable_Main_Form();
            }
        }

        private void open_modul_kewenangan()
        {
            if (login.checkPrevilege(new string[] { "mdp", "mstrdef" }))
            {
                if (kewenangan != null)
                {
                    kewenangan.Close();
                    kewenangan.Dispose();
                }
                kewenangan = new Modul_Data_Login(this);
                kewenangan.Show();
                disable_Main_Form();
            }
        }


        private void SaldoAwalBtn_Click(object sender, EventArgs e)
        {
            open_modul_akuntansi_saldo_awal();
        }

        private void kewenanganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_modul_kewenangan();
        }

    }
}
