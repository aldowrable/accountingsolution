namespace Accounting_Solution_Software
{
    partial class Modul_Pembelian
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label materaiLabel;
            System.Windows.Forms.Label bulatLabel;
            System.Windows.Forms.Label jumlahPembelianLabel;
            System.Windows.Forms.Label totPPnRpLabel;
            System.Windows.Forms.Label totDiscRpLabel;
            System.Windows.Forms.Label subJumlahLabel;
            System.Windows.Forms.Label kodeSupplierLabel;
            System.Windows.Forms.Label tglTransaksiLabel;
            System.Windows.Forms.Label nomorFakturLabel;
            System.Windows.Forms.Label tglJTLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            this.infostatuskirimanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_Order = new Accounting_Solution_Software.Data_set.Purchase_Order();
            this.viewTerimaBarangSupplierViewTBSTBPOProdukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewTerimaBarangSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terima_Barang = new Accounting_Solution_Software.Data_set.Terima_Barang();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager();
            this.info_status_kirimanTableAdapter = new Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.info_status_kirimanTableAdapter();
            this.view_TerimaBarang_SupplierTableAdapter = new Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.view_TerimaBarang_SupplierTableAdapter();
            this.view_TB_STB_PO_ProdukTableAdapter = new Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.View_TB_STB_PO_ProdukTableAdapter();
            this.tableAdapterManager1 = new Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.TableAdapterManager();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.view_TB_STB_PO_ProdukDataGridView = new System.Windows.Forms.DataGridView();
            this.kodeprodukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyTerimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discpercDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discrpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppnpercDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppnrpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pembulatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noPOTxtBox = new System.Windows.Forms.TextBox();
            this.nomorFakturTextBox = new System.Windows.Forms.TextBox();
            this.namaSupplierTextBox = new System.Windows.Forms.TextBox();
            this.kodeSupplierTextBox = new System.Windows.Forms.TextBox();
            this.subJumlahTextBox = new System.Windows.Forms.TextBox();
            this.totDiscRpTextBox = new System.Windows.Forms.TextBox();
            this.totPPnRpTextBox = new System.Windows.Forms.TextBox();
            this.jumlahPembelianTextBox = new System.Windows.Forms.TextBox();
            this.bulatTextBox = new System.Windows.Forms.TextBox();
            this.materaiTextBox = new System.Windows.Forms.TextBox();
            this.noTBCMB = new System.Windows.Forms.ComboBox();
            this.printChkBox = new System.Windows.Forms.CheckBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SimpanBtn = new System.Windows.Forms.Button();
            this.BatalBtn = new System.Windows.Forms.Button();
            this.HapusItemBtn = new System.Windows.Forms.Button();
            this.UbahItemBtn = new System.Windows.Forms.Button();
            this.TambahItemBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jtTextBox = new System.Windows.Forms.TextBox();
            this.TunaiRadioButton = new System.Windows.Forms.RadioButton();
            this.KreditRadioButton = new System.Windows.Forms.RadioButton();
            this.tglJTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tglTransaksiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.view_pembelian_supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.nomorBuktiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorFakturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglPembukuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPembelianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglJTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahPembelianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_pembelian_supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pembelian_2 = new Accounting_Solution_Software.Data_set.Pembelian_2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.statusPembayaranTxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.KeluarBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BaruBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.view_pembelian_supplierTableAdapter = new Accounting_Solution_Software.Data_set.Pembelian_2TableAdapters.view_pembelian_supplierTableAdapter();
            this.tableAdapterManager2 = new Accounting_Solution_Software.Data_set.Pembelian_2TableAdapters.TableAdapterManager();
            materaiLabel = new System.Windows.Forms.Label();
            bulatLabel = new System.Windows.Forms.Label();
            jumlahPembelianLabel = new System.Windows.Forms.Label();
            totPPnRpLabel = new System.Windows.Forms.Label();
            totDiscRpLabel = new System.Windows.Forms.Label();
            subJumlahLabel = new System.Windows.Forms.Label();
            kodeSupplierLabel = new System.Windows.Forms.Label();
            tglTransaksiLabel = new System.Windows.Forms.Label();
            nomorFakturLabel = new System.Windows.Forms.Label();
            tglJTLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infostatuskirimanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTerimaBarangSupplierViewTBSTBPOProdukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTerimaBarangSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terima_Barang)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_TB_STB_PO_ProdukDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_pembelian_supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_pembelian_supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materaiLabel
            // 
            materaiLabel.AutoSize = true;
            materaiLabel.Location = new System.Drawing.Point(584, 466);
            materaiLabel.Name = "materaiLabel";
            materaiLabel.Size = new System.Drawing.Size(48, 13);
            materaiLabel.TabIndex = 30;
            materaiLabel.Text = "Materai :";
            // 
            // bulatLabel
            // 
            bulatLabel.AutoSize = true;
            bulatLabel.Location = new System.Drawing.Point(563, 414);
            bulatLabel.Name = "bulatLabel";
            bulatLabel.Size = new System.Drawing.Size(69, 13);
            bulatLabel.TabIndex = 28;
            bulatLabel.Text = "Pembulatan :";
            // 
            // jumlahPembelianLabel
            // 
            jumlahPembelianLabel.AutoSize = true;
            jumlahPembelianLabel.Location = new System.Drawing.Point(563, 440);
            jumlahPembelianLabel.Name = "jumlahPembelianLabel";
            jumlahPembelianLabel.Size = new System.Drawing.Size(69, 13);
            jumlahPembelianLabel.TabIndex = 24;
            jumlahPembelianLabel.Text = "Grand Total :";
            // 
            // totPPnRpLabel
            // 
            totPPnRpLabel.AutoSize = true;
            totPPnRpLabel.Location = new System.Drawing.Point(381, 466);
            totPPnRpLabel.Name = "totPPnRpLabel";
            totPPnRpLabel.Size = new System.Drawing.Size(32, 13);
            totPPnRpLabel.TabIndex = 22;
            totPPnRpLabel.Text = "Ppn :";
            // 
            // totDiscRpLabel
            // 
            totDiscRpLabel.AutoSize = true;
            totDiscRpLabel.Location = new System.Drawing.Point(358, 440);
            totDiscRpLabel.Name = "totDiscRpLabel";
            totDiscRpLabel.Size = new System.Drawing.Size(55, 13);
            totDiscRpLabel.TabIndex = 20;
            totDiscRpLabel.Text = "Discount :";
            // 
            // subJumlahLabel
            // 
            subJumlahLabel.AutoSize = true;
            subJumlahLabel.Location = new System.Drawing.Point(354, 414);
            subJumlahLabel.Name = "subJumlahLabel";
            subJumlahLabel.Size = new System.Drawing.Size(59, 13);
            subJumlahLabel.TabIndex = 18;
            subJumlahLabel.Text = "Sub Total :";
            // 
            // kodeSupplierLabel
            // 
            kodeSupplierLabel.AutoSize = true;
            kodeSupplierLabel.Location = new System.Drawing.Point(340, 95);
            kodeSupplierLabel.Name = "kodeSupplierLabel";
            kodeSupplierLabel.Size = new System.Drawing.Size(76, 13);
            kodeSupplierLabel.TabIndex = 8;
            kodeSupplierLabel.Text = "Kode Supplier:";
            // 
            // tglTransaksiLabel
            // 
            tglTransaksiLabel.AutoSize = true;
            tglTransaksiLabel.Location = new System.Drawing.Point(14, 42);
            tglTransaksiLabel.Name = "tglTransaksiLabel";
            tglTransaksiLabel.Size = new System.Drawing.Size(74, 13);
            tglTransaksiLabel.TabIndex = 4;
            tglTransaksiLabel.Text = "Tgl Transaksi:";
            // 
            // nomorFakturLabel
            // 
            nomorFakturLabel.AutoSize = true;
            nomorFakturLabel.Location = new System.Drawing.Point(14, 15);
            nomorFakturLabel.Name = "nomorFakturLabel";
            nomorFakturLabel.Size = new System.Drawing.Size(109, 13);
            nomorFakturLabel.TabIndex = 0;
            nomorFakturLabel.Text = "No. Bukti Pembelian :";
            // 
            // tglJTLabel
            // 
            tglJTLabel.AutoSize = true;
            tglJTLabel.Location = new System.Drawing.Point(146, 51);
            tglJTLabel.Name = "tglJTLabel";
            tglJTLabel.Size = new System.Drawing.Size(40, 13);
            tglJTLabel.TabIndex = 14;
            tglJTLabel.Text = "Tgl JT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(146, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 13);
            label1.TabIndex = 14;
            label1.Text = "Jatuh Tempo :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(14, 67);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(102, 13);
            label6.TabIndex = 47;
            label6.Text = "No. Terima Barang :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 13);
            label4.TabIndex = 49;
            label4.Text = "No. PO  :";
            // 
            // infostatuskirimanBindingSource
            // 
            this.infostatuskirimanBindingSource.DataMember = "info_status_kiriman";
            this.infostatuskirimanBindingSource.DataSource = this.purchase_Order;
            // 
            // purchase_Order
            // 
            this.purchase_Order.DataSetName = "Purchase_Order";
            this.purchase_Order.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewTerimaBarangSupplierViewTBSTBPOProdukBindingSource
            // 
            this.viewTerimaBarangSupplierViewTBSTBPOProdukBindingSource.DataMember = "view_TerimaBarang_Supplier_View_TB_STB_PO_Produk";
            this.viewTerimaBarangSupplierViewTBSTBPOProdukBindingSource.DataSource = this.viewTerimaBarangSupplierBindingSource;
            // 
            // viewTerimaBarangSupplierBindingSource
            // 
            this.viewTerimaBarangSupplierBindingSource.DataMember = "view_TerimaBarang_Supplier";
            this.viewTerimaBarangSupplierBindingSource.DataSource = this.terima_Barang;
            // 
            // terima_Barang
            // 
            this.terima_Barang.DataSetName = "Terima_Barang";
            this.terima_Barang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // info_status_kirimanTableAdapter
            // 
            this.info_status_kirimanTableAdapter.ClearBeforeFill = true;
            // 
            // view_TerimaBarang_SupplierTableAdapter
            // 
            this.view_TerimaBarang_SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // view_TB_STB_PO_ProdukTableAdapter
            // 
            this.view_TB_STB_PO_ProdukTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.TerimaBarangTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.view_TB_STB_PO_ProdukDataGridView);
            this.tabPage2.Controls.Add(this.noPOTxtBox);
            this.tabPage2.Controls.Add(this.nomorFakturTextBox);
            this.tabPage2.Controls.Add(this.namaSupplierTextBox);
            this.tabPage2.Controls.Add(this.kodeSupplierTextBox);
            this.tabPage2.Controls.Add(this.subJumlahTextBox);
            this.tabPage2.Controls.Add(this.totDiscRpTextBox);
            this.tabPage2.Controls.Add(this.totPPnRpTextBox);
            this.tabPage2.Controls.Add(this.jumlahPembelianTextBox);
            this.tabPage2.Controls.Add(this.bulatTextBox);
            this.tabPage2.Controls.Add(this.materaiTextBox);
            this.tabPage2.Controls.Add(label4);
            this.tabPage2.Controls.Add(this.noTBCMB);
            this.tabPage2.Controls.Add(label6);
            this.tabPage2.Controls.Add(this.printChkBox);
            this.tabPage2.Controls.Add(this.ResetBtn);
            this.tabPage2.Controls.Add(this.SimpanBtn);
            this.tabPage2.Controls.Add(this.BatalBtn);
            this.tabPage2.Controls.Add(this.HapusItemBtn);
            this.tabPage2.Controls.Add(this.UbahItemBtn);
            this.tabPage2.Controls.Add(this.TambahItemBtn);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(nomorFakturLabel);
            this.tabPage2.Controls.Add(tglTransaksiLabel);
            this.tabPage2.Controls.Add(this.tglTransaksiDateTimePicker);
            this.tabPage2.Controls.Add(kodeSupplierLabel);
            this.tabPage2.Controls.Add(subJumlahLabel);
            this.tabPage2.Controls.Add(totDiscRpLabel);
            this.tabPage2.Controls.Add(totPPnRpLabel);
            this.tabPage2.Controls.Add(jumlahPembelianLabel);
            this.tabPage2.Controls.Add(bulatLabel);
            this.tabPage2.Controls.Add(materaiLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail Pembelian";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // view_TB_STB_PO_ProdukDataGridView
            // 
            this.view_TB_STB_PO_ProdukDataGridView.AllowUserToAddRows = false;
            this.view_TB_STB_PO_ProdukDataGridView.AutoGenerateColumns = false;
            this.view_TB_STB_PO_ProdukDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_TB_STB_PO_ProdukDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeprodukDataGridViewTextBoxColumn,
            this.namaStockDataGridViewTextBoxColumn,
            this.qtyTerimaDataGridViewTextBoxColumn,
            this.satuanDataGridViewTextBoxColumn,
            this.hargabeliDataGridViewTextBoxColumn,
            this.discpercDataGridViewTextBoxColumn,
            this.discrpDataGridViewTextBoxColumn,
            this.ppnpercDataGridViewTextBoxColumn,
            this.ppnrpDataGridViewTextBoxColumn,
            this.pembulatanDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn});
            this.view_TB_STB_PO_ProdukDataGridView.DataSource = this.viewTerimaBarangSupplierViewTBSTBPOProdukBindingSource;
            this.view_TB_STB_PO_ProdukDataGridView.Location = new System.Drawing.Point(17, 129);
            this.view_TB_STB_PO_ProdukDataGridView.Name = "view_TB_STB_PO_ProdukDataGridView";
            this.view_TB_STB_PO_ProdukDataGridView.RowHeadersVisible = false;
            this.view_TB_STB_PO_ProdukDataGridView.Size = new System.Drawing.Size(719, 263);
            this.view_TB_STB_PO_ProdukDataGridView.TabIndex = 50;
            this.view_TB_STB_PO_ProdukDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.view_TB_STB_PO_ProdukDataGridView_RowsAdded);
            this.view_TB_STB_PO_ProdukDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.view_TB_STB_PO_ProdukDataGridView_DataError);
            // 
            // kodeprodukDataGridViewTextBoxColumn
            // 
            this.kodeprodukDataGridViewTextBoxColumn.DataPropertyName = "kodeproduk";
            this.kodeprodukDataGridViewTextBoxColumn.HeaderText = "Kd. Produk";
            this.kodeprodukDataGridViewTextBoxColumn.Name = "kodeprodukDataGridViewTextBoxColumn";
            // 
            // namaStockDataGridViewTextBoxColumn
            // 
            this.namaStockDataGridViewTextBoxColumn.DataPropertyName = "NamaStock";
            this.namaStockDataGridViewTextBoxColumn.HeaderText = "Nm. Produk";
            this.namaStockDataGridViewTextBoxColumn.Name = "namaStockDataGridViewTextBoxColumn";
            // 
            // qtyTerimaDataGridViewTextBoxColumn
            // 
            this.qtyTerimaDataGridViewTextBoxColumn.DataPropertyName = "QtyTerima";
            this.qtyTerimaDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyTerimaDataGridViewTextBoxColumn.Name = "qtyTerimaDataGridViewTextBoxColumn";
            // 
            // satuanDataGridViewTextBoxColumn
            // 
            this.satuanDataGridViewTextBoxColumn.DataPropertyName = "Satuan";
            this.satuanDataGridViewTextBoxColumn.HeaderText = "Satuan";
            this.satuanDataGridViewTextBoxColumn.Name = "satuanDataGridViewTextBoxColumn";
            // 
            // hargabeliDataGridViewTextBoxColumn
            // 
            this.hargabeliDataGridViewTextBoxColumn.DataPropertyName = "hargabeli";
            this.hargabeliDataGridViewTextBoxColumn.HeaderText = "Harga Beli";
            this.hargabeliDataGridViewTextBoxColumn.Name = "hargabeliDataGridViewTextBoxColumn";
            // 
            // discpercDataGridViewTextBoxColumn
            // 
            this.discpercDataGridViewTextBoxColumn.DataPropertyName = "discperc";
            this.discpercDataGridViewTextBoxColumn.HeaderText = "Disc %";
            this.discpercDataGridViewTextBoxColumn.Name = "discpercDataGridViewTextBoxColumn";
            this.discpercDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discrpDataGridViewTextBoxColumn
            // 
            this.discrpDataGridViewTextBoxColumn.DataPropertyName = "discrp";
            this.discrpDataGridViewTextBoxColumn.HeaderText = "Disc Rp";
            this.discrpDataGridViewTextBoxColumn.Name = "discrpDataGridViewTextBoxColumn";
            this.discrpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ppnpercDataGridViewTextBoxColumn
            // 
            this.ppnpercDataGridViewTextBoxColumn.DataPropertyName = "ppnperc";
            this.ppnpercDataGridViewTextBoxColumn.HeaderText = "PPN %";
            this.ppnpercDataGridViewTextBoxColumn.Name = "ppnpercDataGridViewTextBoxColumn";
            this.ppnpercDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ppnrpDataGridViewTextBoxColumn
            // 
            this.ppnrpDataGridViewTextBoxColumn.DataPropertyName = "ppnrp";
            this.ppnrpDataGridViewTextBoxColumn.HeaderText = "PPN Rp";
            this.ppnrpDataGridViewTextBoxColumn.Name = "ppnrpDataGridViewTextBoxColumn";
            this.ppnrpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pembulatanDataGridViewTextBoxColumn
            // 
            this.pembulatanDataGridViewTextBoxColumn.DataPropertyName = "pembulatan";
            this.pembulatanDataGridViewTextBoxColumn.HeaderText = "Pembulatan";
            this.pembulatanDataGridViewTextBoxColumn.Name = "pembulatanDataGridViewTextBoxColumn";
            this.pembulatanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Sub Total";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "expr2";
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr2DataGridViewTextBoxColumn.Visible = false;
            // 
            // expr3DataGridViewTextBoxColumn
            // 
            this.expr3DataGridViewTextBoxColumn.DataPropertyName = "expr3";
            this.expr3DataGridViewTextBoxColumn.HeaderText = "expr3";
            this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
            this.expr3DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr3DataGridViewTextBoxColumn.Visible = false;
            // 
            // noPOTxtBox
            // 
            this.noPOTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewTerimaBarangSupplierBindingSource, "NomorBuktiPembelian", true));
            this.noPOTxtBox.Location = new System.Drawing.Point(124, 91);
            this.noPOTxtBox.Name = "noPOTxtBox";
            this.noPOTxtBox.ReadOnly = true;
            this.noPOTxtBox.Size = new System.Drawing.Size(160, 20);
            this.noPOTxtBox.TabIndex = 50;
            // 
            // nomorFakturTextBox
            // 
            this.nomorFakturTextBox.Location = new System.Drawing.Point(124, 12);
            this.nomorFakturTextBox.Name = "nomorFakturTextBox";
            this.nomorFakturTextBox.ReadOnly = true;
            this.nomorFakturTextBox.Size = new System.Drawing.Size(140, 20);
            this.nomorFakturTextBox.TabIndex = 1;
            // 
            // namaSupplierTextBox
            // 
            this.namaSupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewTerimaBarangSupplierBindingSource, "NamaSupplier", true));
            this.namaSupplierTextBox.Location = new System.Drawing.Point(513, 92);
            this.namaSupplierTextBox.Name = "namaSupplierTextBox";
            this.namaSupplierTextBox.ReadOnly = true;
            this.namaSupplierTextBox.Size = new System.Drawing.Size(155, 20);
            this.namaSupplierTextBox.TabIndex = 9;
            // 
            // kodeSupplierTextBox
            // 
            this.kodeSupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewTerimaBarangSupplierBindingSource, "KodeSupplier", true));
            this.kodeSupplierTextBox.Location = new System.Drawing.Point(431, 91);
            this.kodeSupplierTextBox.Name = "kodeSupplierTextBox";
            this.kodeSupplierTextBox.ReadOnly = true;
            this.kodeSupplierTextBox.Size = new System.Drawing.Size(76, 20);
            this.kodeSupplierTextBox.TabIndex = 9;
            // 
            // subJumlahTextBox
            // 
            this.subJumlahTextBox.Location = new System.Drawing.Point(434, 411);
            this.subJumlahTextBox.Name = "subJumlahTextBox";
            this.subJumlahTextBox.ReadOnly = true;
            this.subJumlahTextBox.Size = new System.Drawing.Size(113, 20);
            this.subJumlahTextBox.TabIndex = 19;
            this.subJumlahTextBox.Text = "0";
            this.subJumlahTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.subJumlahTextBox_KeyDown);
            // 
            // totDiscRpTextBox
            // 
            this.totDiscRpTextBox.Location = new System.Drawing.Point(434, 437);
            this.totDiscRpTextBox.Name = "totDiscRpTextBox";
            this.totDiscRpTextBox.ReadOnly = true;
            this.totDiscRpTextBox.Size = new System.Drawing.Size(113, 20);
            this.totDiscRpTextBox.TabIndex = 21;
            this.totDiscRpTextBox.Text = "0";
            this.totDiscRpTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.totDiscRpTextBox_KeyDown);
            // 
            // totPPnRpTextBox
            // 
            this.totPPnRpTextBox.Location = new System.Drawing.Point(434, 463);
            this.totPPnRpTextBox.Name = "totPPnRpTextBox";
            this.totPPnRpTextBox.ReadOnly = true;
            this.totPPnRpTextBox.Size = new System.Drawing.Size(113, 20);
            this.totPPnRpTextBox.TabIndex = 23;
            this.totPPnRpTextBox.Text = "0";
            this.totPPnRpTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.totPPnRpTextBox_KeyDown);
            // 
            // jumlahPembelianTextBox
            // 
            this.jumlahPembelianTextBox.Location = new System.Drawing.Point(653, 437);
            this.jumlahPembelianTextBox.Name = "jumlahPembelianTextBox";
            this.jumlahPembelianTextBox.ReadOnly = true;
            this.jumlahPembelianTextBox.Size = new System.Drawing.Size(113, 20);
            this.jumlahPembelianTextBox.TabIndex = 25;
            this.jumlahPembelianTextBox.Text = "0";
            this.jumlahPembelianTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jumlahPembelianTextBox_KeyDown);
            // 
            // bulatTextBox
            // 
            this.bulatTextBox.Location = new System.Drawing.Point(653, 411);
            this.bulatTextBox.Name = "bulatTextBox";
            this.bulatTextBox.ReadOnly = true;
            this.bulatTextBox.Size = new System.Drawing.Size(113, 20);
            this.bulatTextBox.TabIndex = 29;
            this.bulatTextBox.Text = "0";
            this.bulatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bulatTextBox_KeyDown);
            // 
            // materaiTextBox
            // 
            this.materaiTextBox.Location = new System.Drawing.Point(653, 463);
            this.materaiTextBox.Name = "materaiTextBox";
            this.materaiTextBox.Size = new System.Drawing.Size(113, 20);
            this.materaiTextBox.TabIndex = 31;
            this.materaiTextBox.Text = "0";
            this.materaiTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.materaiTextBox_KeyDown);
            this.materaiTextBox.Leave += new System.EventHandler(this.materaiTextBox_Leave);
            this.materaiTextBox.Enter += new System.EventHandler(this.materaiTextBox_Enter);
            // 
            // noTBCMB
            // 
            this.noTBCMB.DataSource = this.viewTerimaBarangSupplierBindingSource;
            this.noTBCMB.DisplayMember = "NomorBukti";
            this.noTBCMB.FormattingEnabled = true;
            this.noTBCMB.Location = new System.Drawing.Point(124, 64);
            this.noTBCMB.Name = "noTBCMB";
            this.noTBCMB.Size = new System.Drawing.Size(140, 21);
            this.noTBCMB.TabIndex = 48;
            this.noTBCMB.SelectionChangeCommitted += new System.EventHandler(this.noTBCMB_SelectionChangeCommitted);
            // 
            // printChkBox
            // 
            this.printChkBox.AutoSize = true;
            this.printChkBox.Checked = true;
            this.printChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printChkBox.Location = new System.Drawing.Point(17, 487);
            this.printChkBox.Name = "printChkBox";
            this.printChkBox.Size = new System.Drawing.Size(133, 17);
            this.printChkBox.TabIndex = 45;
            this.printChkBox.Text = "Cetak Bukti Pembelian";
            this.printChkBox.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(17, 402);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(92, 25);
            this.ResetBtn.TabIndex = 44;
            this.ResetBtn.Text = "Reset Form";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SimpanBtn
            // 
            this.SimpanBtn.Location = new System.Drawing.Point(155, 454);
            this.SimpanBtn.Name = "SimpanBtn";
            this.SimpanBtn.Size = new System.Drawing.Size(72, 53);
            this.SimpanBtn.TabIndex = 44;
            this.SimpanBtn.Text = "Simpan";
            this.SimpanBtn.UseVisualStyleBackColor = true;
            this.SimpanBtn.Click += new System.EventHandler(this.SimpanBtn_Click);
            // 
            // BatalBtn
            // 
            this.BatalBtn.Location = new System.Drawing.Point(233, 454);
            this.BatalBtn.Name = "BatalBtn";
            this.BatalBtn.Size = new System.Drawing.Size(72, 53);
            this.BatalBtn.TabIndex = 44;
            this.BatalBtn.Text = "Batal";
            this.BatalBtn.UseVisualStyleBackColor = true;
            this.BatalBtn.Click += new System.EventHandler(this.BatalBtn_Click);
            // 
            // HapusItemBtn
            // 
            this.HapusItemBtn.Location = new System.Drawing.Point(742, 221);
            this.HapusItemBtn.Name = "HapusItemBtn";
            this.HapusItemBtn.Size = new System.Drawing.Size(34, 23);
            this.HapusItemBtn.TabIndex = 44;
            this.HapusItemBtn.Text = "x";
            this.HapusItemBtn.UseVisualStyleBackColor = true;
            this.HapusItemBtn.Click += new System.EventHandler(this.HapusItemBtn_Click);
            // 
            // UbahItemBtn
            // 
            this.UbahItemBtn.Location = new System.Drawing.Point(742, 192);
            this.UbahItemBtn.Name = "UbahItemBtn";
            this.UbahItemBtn.Size = new System.Drawing.Size(34, 23);
            this.UbahItemBtn.TabIndex = 44;
            this.UbahItemBtn.Text = "E";
            this.UbahItemBtn.UseVisualStyleBackColor = true;
            this.UbahItemBtn.Click += new System.EventHandler(this.UbahItemBtn_Click);
            // 
            // TambahItemBtn
            // 
            this.TambahItemBtn.Location = new System.Drawing.Point(742, 161);
            this.TambahItemBtn.Name = "TambahItemBtn";
            this.TambahItemBtn.Size = new System.Drawing.Size(34, 23);
            this.TambahItemBtn.TabIndex = 44;
            this.TambahItemBtn.Text = "+";
            this.TambahItemBtn.UseVisualStyleBackColor = true;
            this.TambahItemBtn.Click += new System.EventHandler(this.TambahItemBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jtTextBox);
            this.groupBox1.Controls.Add(this.TunaiRadioButton);
            this.groupBox1.Controls.Add(this.KreditRadioButton);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(tglJTLabel);
            this.groupBox1.Controls.Add(this.tglJTDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(343, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 78);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status Pembelian";
            // 
            // jtTextBox
            // 
            this.jtTextBox.Location = new System.Drawing.Point(227, 19);
            this.jtTextBox.Name = "jtTextBox";
            this.jtTextBox.Size = new System.Drawing.Size(80, 20);
            this.jtTextBox.TabIndex = 34;
            this.jtTextBox.Text = "0";
            this.jtTextBox.TextChanged += new System.EventHandler(this.jtTextBox_TextChanged);
            this.jtTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jtTextBox_KeyDown);
            // 
            // TunaiRadioButton
            // 
            this.TunaiRadioButton.AutoSize = true;
            this.TunaiRadioButton.Location = new System.Drawing.Point(17, 20);
            this.TunaiRadioButton.Name = "TunaiRadioButton";
            this.TunaiRadioButton.Size = new System.Drawing.Size(52, 17);
            this.TunaiRadioButton.TabIndex = 32;
            this.TunaiRadioButton.TabStop = true;
            this.TunaiRadioButton.Text = "Tunai";
            this.TunaiRadioButton.UseVisualStyleBackColor = true;
            this.TunaiRadioButton.CheckedChanged += new System.EventHandler(this.TunaiRadioButton_CheckedChanged);
            // 
            // KreditRadioButton
            // 
            this.KreditRadioButton.AutoSize = true;
            this.KreditRadioButton.Location = new System.Drawing.Point(88, 20);
            this.KreditRadioButton.Name = "KreditRadioButton";
            this.KreditRadioButton.Size = new System.Drawing.Size(52, 17);
            this.KreditRadioButton.TabIndex = 32;
            this.KreditRadioButton.TabStop = true;
            this.KreditRadioButton.Text = "Kredit";
            this.KreditRadioButton.UseVisualStyleBackColor = true;
            this.KreditRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tglJTDateTimePicker
            // 
            this.tglJTDateTimePicker.Location = new System.Drawing.Point(227, 47);
            this.tglJTDateTimePicker.Name = "tglJTDateTimePicker";
            this.tglJTDateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.tglJTDateTimePicker.TabIndex = 15;
            // 
            // tglTransaksiDateTimePicker
            // 
            this.tglTransaksiDateTimePicker.Location = new System.Drawing.Point(124, 38);
            this.tglTransaksiDateTimePicker.Name = "tglTransaksiDateTimePicker";
            this.tglTransaksiDateTimePicker.Size = new System.Drawing.Size(192, 20);
            this.tglTransaksiDateTimePicker.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.view_pembelian_supplierDataGridView);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.KeluarBtn);
            this.tabPage1.Controls.Add(this.EditBtn);
            this.tabPage1.Controls.Add(this.BaruBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daftar Transaksi Pembelian";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // view_pembelian_supplierDataGridView
            // 
            this.view_pembelian_supplierDataGridView.AllowUserToAddRows = false;
            this.view_pembelian_supplierDataGridView.AutoGenerateColumns = false;
            this.view_pembelian_supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_pembelian_supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorBuktiDataGridViewTextBoxColumn,
            this.nomorFakturDataGridViewTextBoxColumn,
            this.tglTransaksiDataGridViewTextBoxColumn,
            this.tglPembukuanDataGridViewTextBoxColumn,
            this.kodeSupplierDataGridViewTextBoxColumn,
            this.namaSupplierDataGridViewTextBoxColumn,
            this.statusPembelianDataGridViewTextBoxColumn,
            this.tglJTDataGridViewTextBoxColumn,
            this.jumlahPembelianDataGridViewTextBoxColumn});
            this.view_pembelian_supplierDataGridView.DataSource = this.view_pembelian_supplierBindingSource;
            this.view_pembelian_supplierDataGridView.Location = new System.Drawing.Point(15, 115);
            this.view_pembelian_supplierDataGridView.Name = "view_pembelian_supplierDataGridView";
            this.view_pembelian_supplierDataGridView.RowHeadersVisible = false;
            this.view_pembelian_supplierDataGridView.Size = new System.Drawing.Size(751, 359);
            this.view_pembelian_supplierDataGridView.TabIndex = 43;
            this.view_pembelian_supplierDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_pembelian_supplierDataGridView_CellContentDoubleClick);
            this.view_pembelian_supplierDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.view_pembelian_supplierDataGridView_DataError);
            this.view_pembelian_supplierDataGridView.DataSourceChanged += new System.EventHandler(this.view_pembelian_supplierDataGridView_DataSourceChanged);
            // 
            // nomorBuktiDataGridViewTextBoxColumn
            // 
            this.nomorBuktiDataGridViewTextBoxColumn.DataPropertyName = "NomorBukti";
            this.nomorBuktiDataGridViewTextBoxColumn.HeaderText = "No. Pembelian";
            this.nomorBuktiDataGridViewTextBoxColumn.Name = "nomorBuktiDataGridViewTextBoxColumn";
            // 
            // nomorFakturDataGridViewTextBoxColumn
            // 
            this.nomorFakturDataGridViewTextBoxColumn.DataPropertyName = "NomorFaktur";
            this.nomorFakturDataGridViewTextBoxColumn.HeaderText = "No. Faktur";
            this.nomorFakturDataGridViewTextBoxColumn.Name = "nomorFakturDataGridViewTextBoxColumn";
            // 
            // tglTransaksiDataGridViewTextBoxColumn
            // 
            this.tglTransaksiDataGridViewTextBoxColumn.DataPropertyName = "TglTransaksi";
            this.tglTransaksiDataGridViewTextBoxColumn.HeaderText = "Tgl. Transaksi";
            this.tglTransaksiDataGridViewTextBoxColumn.Name = "tglTransaksiDataGridViewTextBoxColumn";
            // 
            // tglPembukuanDataGridViewTextBoxColumn
            // 
            this.tglPembukuanDataGridViewTextBoxColumn.DataPropertyName = "TglPembukuan";
            this.tglPembukuanDataGridViewTextBoxColumn.HeaderText = "Tgl. Pembukuan";
            this.tglPembukuanDataGridViewTextBoxColumn.Name = "tglPembukuanDataGridViewTextBoxColumn";
            // 
            // kodeSupplierDataGridViewTextBoxColumn
            // 
            this.kodeSupplierDataGridViewTextBoxColumn.DataPropertyName = "KodeSupplier";
            this.kodeSupplierDataGridViewTextBoxColumn.HeaderText = "Kd. Supp";
            this.kodeSupplierDataGridViewTextBoxColumn.Name = "kodeSupplierDataGridViewTextBoxColumn";
            // 
            // namaSupplierDataGridViewTextBoxColumn
            // 
            this.namaSupplierDataGridViewTextBoxColumn.DataPropertyName = "NamaSupplier";
            this.namaSupplierDataGridViewTextBoxColumn.HeaderText = "Nm. Supp";
            this.namaSupplierDataGridViewTextBoxColumn.Name = "namaSupplierDataGridViewTextBoxColumn";
            // 
            // statusPembelianDataGridViewTextBoxColumn
            // 
            this.statusPembelianDataGridViewTextBoxColumn.DataPropertyName = "StatusPembelian";
            this.statusPembelianDataGridViewTextBoxColumn.HeaderText = "Status Bayar";
            this.statusPembelianDataGridViewTextBoxColumn.Name = "statusPembelianDataGridViewTextBoxColumn";
            // 
            // tglJTDataGridViewTextBoxColumn
            // 
            this.tglJTDataGridViewTextBoxColumn.DataPropertyName = "TglJT";
            this.tglJTDataGridViewTextBoxColumn.HeaderText = "Tgl. JT";
            this.tglJTDataGridViewTextBoxColumn.Name = "tglJTDataGridViewTextBoxColumn";
            // 
            // jumlahPembelianDataGridViewTextBoxColumn
            // 
            this.jumlahPembelianDataGridViewTextBoxColumn.DataPropertyName = "JumlahPembelian";
            this.jumlahPembelianDataGridViewTextBoxColumn.HeaderText = "Total Bayar";
            this.jumlahPembelianDataGridViewTextBoxColumn.Name = "jumlahPembelianDataGridViewTextBoxColumn";
            // 
            // view_pembelian_supplierBindingSource
            // 
            this.view_pembelian_supplierBindingSource.DataMember = "view_pembelian_supplier";
            this.view_pembelian_supplierBindingSource.DataSource = this.pembelian_2;
            // 
            // pembelian_2
            // 
            this.pembelian_2.DataSetName = "Pembelian_2";
            this.pembelian_2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.cariTxt);
            this.groupBox4.Controls.Add(this.statusPembayaranTxt);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(16, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 100);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(17, 49);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(17, 76);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cariTxt
            // 
            this.cariTxt.Location = new System.Drawing.Point(143, 46);
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Size = new System.Drawing.Size(311, 20);
            this.cariTxt.TabIndex = 5;
            this.cariTxt.TextChanged += new System.EventHandler(this.cariTxt_TextChanged);
            // 
            // statusPembayaranTxt
            // 
            this.statusPembayaranTxt.DataSource = this.infostatuskirimanBindingSource;
            this.statusPembayaranTxt.DisplayMember = "status_pembayaran";
            this.statusPembayaranTxt.FormattingEnabled = true;
            this.statusPembayaranTxt.Location = new System.Drawing.Point(143, 73);
            this.statusPembayaranTxt.Name = "statusPembayaranTxt";
            this.statusPembayaranTxt.Size = new System.Drawing.Size(121, 21);
            this.statusPembayaranTxt.TabIndex = 6;
            this.statusPembayaranTxt.ValueMember = "id_pembayaran";
            this.statusPembayaranTxt.TextChanged += new System.EventHandler(this.statusPembayaranTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cari ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status Pembayaran";
            // 
            // KeluarBtn
            // 
            this.KeluarBtn.Location = new System.Drawing.Point(694, 486);
            this.KeluarBtn.Name = "KeluarBtn";
            this.KeluarBtn.Size = new System.Drawing.Size(75, 23);
            this.KeluarBtn.TabIndex = 40;
            this.KeluarBtn.Text = "Keluar";
            this.KeluarBtn.UseVisualStyleBackColor = true;
            this.KeluarBtn.Click += new System.EventHandler(this.KeluarBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(122, 485);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(108, 23);
            this.EditBtn.TabIndex = 41;
            this.EditBtn.Text = "Ubah Data";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // BaruBtn
            // 
            this.BaruBtn.Location = new System.Drawing.Point(8, 485);
            this.BaruBtn.Name = "BaruBtn";
            this.BaruBtn.Size = new System.Drawing.Size(108, 23);
            this.BaruBtn.TabIndex = 42;
            this.BaruBtn.Text = "Tambah Data";
            this.BaruBtn.UseVisualStyleBackColor = true;
            this.BaruBtn.Click += new System.EventHandler(this.btn_Baru_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 554);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // view_pembelian_supplierTableAdapter
            // 
            this.view_pembelian_supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = Accounting_Solution_Software.Data_set.Pembelian_2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Modul_Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Pembelian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi Pembelian Barang";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Pembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infostatuskirimanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTerimaBarangSupplierViewTBSTBPOProdukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTerimaBarangSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terima_Barang)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_TB_STB_PO_ProdukDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_pembelian_supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_pembelian_supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelian_2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager tableAdapterManager;
        private Accounting_Solution_Software.Data_set.Purchase_Order purchase_Order;
        private System.Windows.Forms.BindingSource infostatuskirimanBindingSource;
        private Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.info_status_kirimanTableAdapter info_status_kirimanTableAdapter;
        private Accounting_Solution_Software.Data_set.Terima_Barang terima_Barang;
        private System.Windows.Forms.BindingSource viewTerimaBarangSupplierBindingSource;
        private Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.view_TerimaBarang_SupplierTableAdapter view_TerimaBarang_SupplierTableAdapter;
        private System.Windows.Forms.BindingSource viewTerimaBarangSupplierViewTBSTBPOProdukBindingSource;
        private Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.View_TB_STB_PO_ProdukTableAdapter view_TB_STB_PO_ProdukTableAdapter;
        private Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView view_TB_STB_PO_ProdukDataGridView;
        private System.Windows.Forms.TextBox noPOTxtBox;
        private System.Windows.Forms.TextBox nomorFakturTextBox;
        private System.Windows.Forms.TextBox namaSupplierTextBox;
        private System.Windows.Forms.TextBox kodeSupplierTextBox;
        private System.Windows.Forms.TextBox subJumlahTextBox;
        private System.Windows.Forms.TextBox totDiscRpTextBox;
        private System.Windows.Forms.TextBox totPPnRpTextBox;
        private System.Windows.Forms.TextBox jumlahPembelianTextBox;
        private System.Windows.Forms.TextBox bulatTextBox;
        private System.Windows.Forms.TextBox materaiTextBox;
        private System.Windows.Forms.ComboBox noTBCMB;
        private System.Windows.Forms.CheckBox printChkBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SimpanBtn;
        private System.Windows.Forms.Button BatalBtn;
        private System.Windows.Forms.Button HapusItemBtn;
        private System.Windows.Forms.Button UbahItemBtn;
        private System.Windows.Forms.Button TambahItemBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox jtTextBox;
        private System.Windows.Forms.RadioButton TunaiRadioButton;
        private System.Windows.Forms.RadioButton KreditRadioButton;
        private System.Windows.Forms.DateTimePicker tglJTDateTimePicker;
        private System.Windows.Forms.DateTimePicker tglTransaksiDateTimePicker;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView view_pembelian_supplierDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.ComboBox statusPembayaranTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KeluarBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BaruBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private Accounting_Solution_Software.Data_set.Pembelian_2 pembelian_2;
        private System.Windows.Forms.BindingSource view_pembelian_supplierBindingSource;
        private Accounting_Solution_Software.Data_set.Pembelian_2TableAdapters.view_pembelian_supplierTableAdapter view_pembelian_supplierTableAdapter;
        private Accounting_Solution_Software.Data_set.Pembelian_2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorBuktiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorFakturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglPembukuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPembelianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglJTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahPembelianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeprodukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyTerimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discpercDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discrpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppnpercDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppnrpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pembulatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
    }
}