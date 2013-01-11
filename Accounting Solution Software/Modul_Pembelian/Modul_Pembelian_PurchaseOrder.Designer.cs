namespace Accounting_Solution_Software
{
    partial class Modul_Pembelian_PurchaseOrder
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
            System.Windows.Forms.Label nomorFakturLabel;
            System.Windows.Forms.Label tglPembukuanLabel;
            System.Windows.Forms.Label kodeSupplierLabel;
            System.Windows.Forms.Label jumlahPembelianLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.view_po_supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.view_po_supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchase_Order = new Accounting_Solution_Software.Data_set.Purchase_Order();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.statusPembayaranTxt = new System.Windows.Forms.ComboBox();
            this.infostatuskirimanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.KeluarBtn = new System.Windows.Forms.Button();
            this.BaruBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusKirimTxtbox = new System.Windows.Forms.TextBox();
            this.alamatpoRTB = new System.Windows.Forms.RichTextBox();
            this.alamatPegirimanCMB = new System.Windows.Forms.ComboBox();
            this.gudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockItemDTV = new System.Windows.Forms.DataGridView();
            this.alamatPengirimanRTB = new System.Windows.Forms.RichTextBox();
            this.kodeSupplierBtn = new System.Windows.Forms.Button();
            this.printChkBox = new System.Windows.Forms.CheckBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SimpanBtn = new System.Windows.Forms.Button();
            this.BatalBtn = new System.Windows.Forms.Button();
            this.HapusItemBtn = new System.Windows.Forms.Button();
            this.TambahItemBtn = new System.Windows.Forms.Button();
            this.nomorPOTextBox = new System.Windows.Forms.TextBox();
            this.tglPODTP = new System.Windows.Forms.DateTimePicker();
            this.namaSupplierTextBox = new System.Windows.Forms.TextBox();
            this.kodeSupplierTextBox = new System.Windows.Forms.TextBox();
            this.jumlahPembelianTextBox = new System.Windows.Forms.TextBox();
            this.view_po_supplierTableAdapter = new Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.view_po_supplierTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.TableAdapterManager();
            this.gudangTableAdapter = new Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.GudangTableAdapter();
            this.info_status_kirimanTableAdapter = new Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.info_status_kirimanTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatpoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaGudangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuskirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomorFakturLabel = new System.Windows.Forms.Label();
            tglPembukuanLabel = new System.Windows.Forms.Label();
            kodeSupplierLabel = new System.Windows.Forms.Label();
            jumlahPembelianLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_po_supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_po_supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Order)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infostatuskirimanBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemDTV)).BeginInit();
            this.SuspendLayout();
            // 
            // nomorFakturLabel
            // 
            nomorFakturLabel.AutoSize = true;
            nomorFakturLabel.Location = new System.Drawing.Point(24, 25);
            nomorFakturLabel.Name = "nomorFakturLabel";
            nomorFakturLabel.Size = new System.Drawing.Size(48, 13);
            nomorFakturLabel.TabIndex = 0;
            nomorFakturLabel.Text = "No. PO :";
            // 
            // tglPembukuanLabel
            // 
            tglPembukuanLabel.AutoSize = true;
            tglPembukuanLabel.Location = new System.Drawing.Point(390, 25);
            tglPembukuanLabel.Name = "tglPembukuanLabel";
            tglPembukuanLabel.Size = new System.Drawing.Size(70, 13);
            tglPembukuanLabel.TabIndex = 6;
            tglPembukuanLabel.Text = "Tanggal PO :";
            // 
            // kodeSupplierLabel
            // 
            kodeSupplierLabel.AutoSize = true;
            kodeSupplierLabel.Location = new System.Drawing.Point(24, 54);
            kodeSupplierLabel.Name = "kodeSupplierLabel";
            kodeSupplierLabel.Size = new System.Drawing.Size(79, 13);
            kodeSupplierLabel.TabIndex = 8;
            kodeSupplierLabel.Text = "Kode Supplier :";
            // 
            // jumlahPembelianLabel
            // 
            jumlahPembelianLabel.AutoSize = true;
            jumlahPembelianLabel.Location = new System.Drawing.Point(504, 416);
            jumlahPembelianLabel.Name = "jumlahPembelianLabel";
            jumlahPembelianLabel.Size = new System.Drawing.Size(69, 13);
            jumlahPembelianLabel.TabIndex = 24;
            jumlahPembelianLabel.Text = "Grand Total :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(390, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 13);
            label1.TabIndex = 47;
            label1.Text = "Barang Dikirim ke :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(24, 156);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(68, 13);
            label6.TabIndex = 52;
            label6.Text = "Status Kirim :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(24, 82);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(80, 13);
            label7.TabIndex = 53;
            label7.Text = "PO Dikirim ke  :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 548);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.view_po_supplierDataGridView);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.KeluarBtn);
            this.tabPage1.Controls.Add(this.BaruBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daftar PO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Ubah Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // view_po_supplierDataGridView
            // 
            this.view_po_supplierDataGridView.AllowUserToAddRows = false;
            this.view_po_supplierDataGridView.AllowUserToDeleteRows = false;
            this.view_po_supplierDataGridView.AllowUserToResizeRows = false;
            this.view_po_supplierDataGridView.AutoGenerateColumns = false;
            this.view_po_supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_po_supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.kodeSupplierDataGridViewTextBoxColumn,
            this.namaSupplierDataGridViewTextBoxColumn,
            this.alamatpoDataGridViewTextBoxColumn,
            this.namaGudangDataGridViewTextBoxColumn,
            this.alamatbarangDataGridViewTextBoxColumn,
            this.statuskirimDataGridViewTextBoxColumn});
            this.view_po_supplierDataGridView.DataSource = this.view_po_supplierBindingSource;
            this.view_po_supplierDataGridView.Location = new System.Drawing.Point(8, 112);
            this.view_po_supplierDataGridView.Name = "view_po_supplierDataGridView";
            this.view_po_supplierDataGridView.RowHeadersVisible = false;
            this.view_po_supplierDataGridView.Size = new System.Drawing.Size(774, 367);
            this.view_po_supplierDataGridView.TabIndex = 44;
            this.view_po_supplierDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_po_supplierDataGridView_CellDoubleClick);
            // 
            // view_po_supplierBindingSource
            // 
            this.view_po_supplierBindingSource.DataMember = "view_po_supplier";
            this.view_po_supplierBindingSource.DataSource = this.purchase_Order;
            // 
            // purchase_Order
            // 
            this.purchase_Order.DataSetName = "Purchase_Order";
            this.purchase_Order.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(261, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Penerimaan Barang";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 100);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 76);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(18, 22);
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
            this.statusPembayaranTxt.DisplayMember = "status_pengiriman_barang";
            this.statusPembayaranTxt.FormattingEnabled = true;
            this.statusPembayaranTxt.Location = new System.Drawing.Point(143, 73);
            this.statusPembayaranTxt.Name = "statusPembayaranTxt";
            this.statusPembayaranTxt.Size = new System.Drawing.Size(121, 21);
            this.statusPembayaranTxt.TabIndex = 6;
            this.statusPembayaranTxt.ValueMember = "id";
            this.statusPembayaranTxt.TextChanged += new System.EventHandler(this.statusPembayaranTxt_TextChanged);
            // 
            // infostatuskirimanBindingSource
            // 
            this.infostatuskirimanBindingSource.DataMember = "info_status_kiriman";
            this.infostatuskirimanBindingSource.DataSource = this.purchase_Order;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 22);
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
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status Pengiriman";
            // 
            // KeluarBtn
            // 
            this.KeluarBtn.Location = new System.Drawing.Point(707, 485);
            this.KeluarBtn.Name = "KeluarBtn";
            this.KeluarBtn.Size = new System.Drawing.Size(75, 23);
            this.KeluarBtn.TabIndex = 40;
            this.KeluarBtn.Text = "Keluar";
            this.KeluarBtn.UseVisualStyleBackColor = true;
            this.KeluarBtn.Click += new System.EventHandler(this.KeluarBtn_Click);
            // 
            // BaruBtn
            // 
            this.BaruBtn.Location = new System.Drawing.Point(8, 485);
            this.BaruBtn.Name = "BaruBtn";
            this.BaruBtn.Size = new System.Drawing.Size(108, 23);
            this.BaruBtn.TabIndex = 42;
            this.BaruBtn.Text = "Tambah Data";
            this.BaruBtn.UseVisualStyleBackColor = true;
            this.BaruBtn.Click += new System.EventHandler(this.BaruBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.StatusKirimTxtbox);
            this.tabPage2.Controls.Add(this.alamatpoRTB);
            this.tabPage2.Controls.Add(label7);
            this.tabPage2.Controls.Add(label6);
            this.tabPage2.Controls.Add(this.alamatPegirimanCMB);
            this.tabPage2.Controls.Add(this.stockItemDTV);
            this.tabPage2.Controls.Add(this.alamatPengirimanRTB);
            this.tabPage2.Controls.Add(label1);
            this.tabPage2.Controls.Add(this.kodeSupplierBtn);
            this.tabPage2.Controls.Add(this.printChkBox);
            this.tabPage2.Controls.Add(this.ResetBtn);
            this.tabPage2.Controls.Add(this.SimpanBtn);
            this.tabPage2.Controls.Add(this.BatalBtn);
            this.tabPage2.Controls.Add(this.HapusItemBtn);
            this.tabPage2.Controls.Add(this.TambahItemBtn);
            this.tabPage2.Controls.Add(nomorFakturLabel);
            this.tabPage2.Controls.Add(this.nomorPOTextBox);
            this.tabPage2.Controls.Add(tglPembukuanLabel);
            this.tabPage2.Controls.Add(this.tglPODTP);
            this.tabPage2.Controls.Add(kodeSupplierLabel);
            this.tabPage2.Controls.Add(this.namaSupplierTextBox);
            this.tabPage2.Controls.Add(this.kodeSupplierTextBox);
            this.tabPage2.Controls.Add(jumlahPembelianLabel);
            this.tabPage2.Controls.Add(this.jumlahPembelianTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail PO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "T = Terkirim , D = Belum Terkirim";
            // 
            // StatusKirimTxtbox
            // 
            this.StatusKirimTxtbox.Enabled = false;
            this.StatusKirimTxtbox.Location = new System.Drawing.Point(134, 154);
            this.StatusKirimTxtbox.Name = "StatusKirimTxtbox";
            this.StatusKirimTxtbox.Size = new System.Drawing.Size(61, 20);
            this.StatusKirimTxtbox.TabIndex = 56;
            // 
            // alamatpoRTB
            // 
            this.alamatpoRTB.Location = new System.Drawing.Point(134, 79);
            this.alamatpoRTB.Name = "alamatpoRTB";
            this.alamatpoRTB.Size = new System.Drawing.Size(242, 70);
            this.alamatpoRTB.TabIndex = 54;
            this.alamatpoRTB.Text = "";
            // 
            // alamatPegirimanCMB
            // 
            this.alamatPegirimanCMB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_po_supplierBindingSource, "NamaGudang", true));
            this.alamatPegirimanCMB.DataSource = this.gudangBindingSource;
            this.alamatPegirimanCMB.DisplayMember = "nama";
            this.alamatPegirimanCMB.FormattingEnabled = true;
            this.alamatPegirimanCMB.Location = new System.Drawing.Point(496, 51);
            this.alamatPegirimanCMB.Name = "alamatPegirimanCMB";
            this.alamatPegirimanCMB.Size = new System.Drawing.Size(203, 21);
            this.alamatPegirimanCMB.TabIndex = 50;
            this.alamatPegirimanCMB.ValueMember = "id";
            this.alamatPegirimanCMB.SelectionChangeCommitted += new System.EventHandler(this.alamatPegirimanCMB_SelectionChangeCommitted);
            // 
            // gudangBindingSource
            // 
            this.gudangBindingSource.DataMember = "Gudang";
            this.gudangBindingSource.DataSource = this.purchase_Order;
            // 
            // stockItemDTV
            // 
            this.stockItemDTV.AllowUserToAddRows = false;
            this.stockItemDTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockItemDTV.Location = new System.Drawing.Point(17, 178);
            this.stockItemDTV.Name = "stockItemDTV";
            this.stockItemDTV.RowHeadersVisible = false;
            this.stockItemDTV.Size = new System.Drawing.Size(727, 217);
            this.stockItemDTV.TabIndex = 49;
            this.stockItemDTV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockItemDTV_CellValueChanged);
            this.stockItemDTV.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockItemDTV_CellLeave);
            this.stockItemDTV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.stockItemDTV_DataError);
            // 
            // alamatPengirimanRTB
            // 
            this.alamatPengirimanRTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_po_supplierBindingSource, "alamatbarang", true));
            this.alamatPengirimanRTB.Location = new System.Drawing.Point(495, 78);
            this.alamatPengirimanRTB.Name = "alamatPengirimanRTB";
            this.alamatPengirimanRTB.Size = new System.Drawing.Size(242, 70);
            this.alamatPengirimanRTB.TabIndex = 48;
            this.alamatPengirimanRTB.Text = "";
            // 
            // kodeSupplierBtn
            // 
            this.kodeSupplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodeSupplierBtn.Location = new System.Drawing.Point(214, 48);
            this.kodeSupplierBtn.Name = "kodeSupplierBtn";
            this.kodeSupplierBtn.Size = new System.Drawing.Size(32, 23);
            this.kodeSupplierBtn.TabIndex = 46;
            this.kodeSupplierBtn.Text = "...";
            this.kodeSupplierBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kodeSupplierBtn.UseVisualStyleBackColor = true;
            this.kodeSupplierBtn.Click += new System.EventHandler(this.kodeSupplierBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(17, 452);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(72, 53);
            this.ResetBtn.TabIndex = 44;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // SimpanBtn
            // 
            this.SimpanBtn.Location = new System.Drawing.Point(616, 452);
            this.SimpanBtn.Name = "SimpanBtn";
            this.SimpanBtn.Size = new System.Drawing.Size(72, 53);
            this.SimpanBtn.TabIndex = 44;
            this.SimpanBtn.Text = "Simpan";
            this.SimpanBtn.UseVisualStyleBackColor = true;
            this.SimpanBtn.Click += new System.EventHandler(this.SimpanBtn_Click);
            // 
            // BatalBtn
            // 
            this.BatalBtn.Location = new System.Drawing.Point(694, 452);
            this.BatalBtn.Name = "BatalBtn";
            this.BatalBtn.Size = new System.Drawing.Size(72, 53);
            this.BatalBtn.TabIndex = 44;
            this.BatalBtn.Text = "Batal";
            this.BatalBtn.UseVisualStyleBackColor = true;
            this.BatalBtn.Click += new System.EventHandler(this.BatalBtn_Click);
            // 
            // HapusItemBtn
            // 
            this.HapusItemBtn.Location = new System.Drawing.Point(750, 240);
            this.HapusItemBtn.Name = "HapusItemBtn";
            this.HapusItemBtn.Size = new System.Drawing.Size(27, 23);
            this.HapusItemBtn.TabIndex = 44;
            this.HapusItemBtn.Text = "x";
            this.HapusItemBtn.UseVisualStyleBackColor = true;
            this.HapusItemBtn.Click += new System.EventHandler(this.HapusItemBtn_Click);
            // 
            // TambahItemBtn
            // 
            this.TambahItemBtn.Location = new System.Drawing.Point(750, 211);
            this.TambahItemBtn.Name = "TambahItemBtn";
            this.TambahItemBtn.Size = new System.Drawing.Size(27, 23);
            this.TambahItemBtn.TabIndex = 44;
            this.TambahItemBtn.Text = "+";
            this.TambahItemBtn.UseVisualStyleBackColor = true;
            this.TambahItemBtn.Click += new System.EventHandler(this.TambahItemBtn_Click);
            // 
            // nomorPOTextBox
            // 
            this.nomorPOTextBox.Location = new System.Drawing.Point(134, 22);
            this.nomorPOTextBox.Name = "nomorPOTextBox";
            this.nomorPOTextBox.Size = new System.Drawing.Size(242, 20);
            this.nomorPOTextBox.TabIndex = 1;
            // 
            // tglPODTP
            // 
            this.tglPODTP.Enabled = false;
            this.tglPODTP.Location = new System.Drawing.Point(495, 22);
            this.tglPODTP.Name = "tglPODTP";
            this.tglPODTP.Size = new System.Drawing.Size(204, 20);
            this.tglPODTP.TabIndex = 7;
            // 
            // namaSupplierTextBox
            // 
            this.namaSupplierTextBox.Location = new System.Drawing.Point(252, 51);
            this.namaSupplierTextBox.Name = "namaSupplierTextBox";
            this.namaSupplierTextBox.ReadOnly = true;
            this.namaSupplierTextBox.Size = new System.Drawing.Size(124, 20);
            this.namaSupplierTextBox.TabIndex = 9;
            // 
            // kodeSupplierTextBox
            // 
            this.kodeSupplierTextBox.Location = new System.Drawing.Point(134, 51);
            this.kodeSupplierTextBox.Name = "kodeSupplierTextBox";
            this.kodeSupplierTextBox.Size = new System.Drawing.Size(76, 20);
            this.kodeSupplierTextBox.TabIndex = 9;
            // 
            // jumlahPembelianTextBox
            // 
            this.jumlahPembelianTextBox.Location = new System.Drawing.Point(591, 413);
            this.jumlahPembelianTextBox.Name = "jumlahPembelianTextBox";
            this.jumlahPembelianTextBox.ReadOnly = true;
            this.jumlahPembelianTextBox.Size = new System.Drawing.Size(175, 20);
            this.jumlahPembelianTextBox.TabIndex = 25;
            this.jumlahPembelianTextBox.Text = "0";
            // 
            // view_po_supplierTableAdapter
            // 
            this.view_po_supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GudangTableAdapter = this.gudangTableAdapter;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.subPurchaseOrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gudangTableAdapter
            // 
            this.gudangTableAdapter.ClearBeforeFill = true;
            // 
            // info_status_kirimanTableAdapter
            // 
            this.info_status_kirimanTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Kd. PO";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tgl. PO";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // kodeSupplierDataGridViewTextBoxColumn
            // 
            this.kodeSupplierDataGridViewTextBoxColumn.DataPropertyName = "KodeSupplier";
            this.kodeSupplierDataGridViewTextBoxColumn.HeaderText = "Kd. Supp.";
            this.kodeSupplierDataGridViewTextBoxColumn.Name = "kodeSupplierDataGridViewTextBoxColumn";
            // 
            // namaSupplierDataGridViewTextBoxColumn
            // 
            this.namaSupplierDataGridViewTextBoxColumn.DataPropertyName = "NamaSupplier";
            this.namaSupplierDataGridViewTextBoxColumn.HeaderText = "Nm. Supp.";
            this.namaSupplierDataGridViewTextBoxColumn.Name = "namaSupplierDataGridViewTextBoxColumn";
            // 
            // alamatpoDataGridViewTextBoxColumn
            // 
            this.alamatpoDataGridViewTextBoxColumn.DataPropertyName = "alamatpo";
            this.alamatpoDataGridViewTextBoxColumn.HeaderText = "Alamat Pengiriman PO";
            this.alamatpoDataGridViewTextBoxColumn.Name = "alamatpoDataGridViewTextBoxColumn";
            // 
            // namaGudangDataGridViewTextBoxColumn
            // 
            this.namaGudangDataGridViewTextBoxColumn.DataPropertyName = "NamaGudang";
            this.namaGudangDataGridViewTextBoxColumn.HeaderText = "Cabang Tujuan";
            this.namaGudangDataGridViewTextBoxColumn.Name = "namaGudangDataGridViewTextBoxColumn";
            // 
            // alamatbarangDataGridViewTextBoxColumn
            // 
            this.alamatbarangDataGridViewTextBoxColumn.DataPropertyName = "alamatbarang";
            this.alamatbarangDataGridViewTextBoxColumn.HeaderText = "Alamat Pengiriman Barang";
            this.alamatbarangDataGridViewTextBoxColumn.Name = "alamatbarangDataGridViewTextBoxColumn";
            // 
            // statuskirimDataGridViewTextBoxColumn
            // 
            this.statuskirimDataGridViewTextBoxColumn.DataPropertyName = "statuskirim";
            this.statuskirimDataGridViewTextBoxColumn.HeaderText = "Status Pengiriman";
            this.statuskirimDataGridViewTextBoxColumn.Name = "statuskirimDataGridViewTextBoxColumn";
            // 
            // Modul_Pembelian_PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 548);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "Modul_Pembelian_PurchaseOrder";
            this.Text = "Purchase Order";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Pembelian_PurchaseOrder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_po_supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_po_supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Order)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infostatuskirimanBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemDTV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button BaruBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button kodeSupplierBtn;
        private System.Windows.Forms.CheckBox printChkBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button SimpanBtn;
        private System.Windows.Forms.Button BatalBtn;
        private System.Windows.Forms.Button HapusItemBtn;
        private System.Windows.Forms.Button TambahItemBtn;
        private System.Windows.Forms.TextBox nomorPOTextBox;
        private System.Windows.Forms.DateTimePicker tglPODTP;
        private System.Windows.Forms.TextBox namaSupplierTextBox;
        private System.Windows.Forms.TextBox kodeSupplierTextBox;
        private System.Windows.Forms.TextBox jumlahPembelianTextBox;
        private System.Windows.Forms.RichTextBox alamatPengirimanRTB;
        private System.Windows.Forms.DataGridView stockItemDTV;
        private System.Windows.Forms.ComboBox alamatPegirimanCMB;
        private System.Windows.Forms.DataGridView view_po_supplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatkirimDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox alamatpoRTB;
        private Accounting_Solution_Software.Data_set.Purchase_Order purchase_Order;
        private System.Windows.Forms.BindingSource view_po_supplierBindingSource;
        private Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.view_po_supplierTableAdapter view_po_supplierTableAdapter;
        private Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.TableAdapterManager tableAdapterManager;
        private Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.GudangTableAdapter gudangTableAdapter;
        private System.Windows.Forms.BindingSource gudangBindingSource;
        private System.Windows.Forms.BindingSource infostatuskirimanBindingSource;
        private Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.info_status_kirimanTableAdapter info_status_kirimanTableAdapter;
        private System.Windows.Forms.TextBox StatusKirimTxtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatpoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaGudangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuskirimDataGridViewTextBoxColumn;
    }
}