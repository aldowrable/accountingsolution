namespace Accounting_Solution_Software
{
    partial class Modul_Barang_Penerimaan
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
            System.Windows.Forms.Label noBonLabel;
            System.Windows.Forms.Label tanggalLabel;
            System.Windows.Forms.Label jumlahPenjualanLabel;
            System.Windows.Forms.Label kodeSupplierLabel;
            System.Windows.Forms.Label nomorBuktiPembelianLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keluarBtn = new System.Windows.Forms.Button();
            this.view_jual_nobonDataGridView = new System.Windows.Forms.DataGridView();
            this.nomorBuktiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorBuktiPembelianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorSJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQtyTerimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_TerimaBarang_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terima_Barang = new Accounting_Solution_Software.Data_set.Terima_Barang();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusPembelianTextbox = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.printChkBox = new System.Windows.Forms.CheckBox();
            this.NomorBuktiPembelianTextBox = new System.Windows.Forms.ComboBox();
            this.batalBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.subTerimaBarangDataGridView = new System.Windows.Forms.DataGridView();
            this.namaSupplierTextBox = new System.Windows.Forms.TextBox();
            this.kodeSupplierTextBox = new System.Windows.Forms.TextBox();
            this.noBonTextBox = new System.Windows.Forms.TextBox();
            this.tanggalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nomorSJTextBox = new System.Windows.Forms.TextBox();
            this.purchase_Order = new Accounting_Solution_Software.Data_set.Purchase_Order();
            this.purchaseOrderTableAdapter = new Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.PurchaseOrderTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.TableAdapterManager();
            this.view_TerimaBarang_SupplierTableAdapter = new Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.view_TerimaBarang_SupplierTableAdapter();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            noBonLabel = new System.Windows.Forms.Label();
            tanggalLabel = new System.Windows.Forms.Label();
            jumlahPenjualanLabel = new System.Windows.Forms.Label();
            kodeSupplierLabel = new System.Windows.Forms.Label();
            nomorBuktiPembelianLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_jual_nobonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TerimaBarang_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terima_Barang)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subTerimaBarangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noBonLabel
            // 
            noBonLabel.AutoSize = true;
            noBonLabel.Location = new System.Drawing.Point(23, 27);
            noBonLabel.Name = "noBonLabel";
            noBonLabel.Size = new System.Drawing.Size(54, 13);
            noBonLabel.TabIndex = 3;
            noBonLabel.Text = "No Bukti :";
            // 
            // tanggalLabel
            // 
            tanggalLabel.AutoSize = true;
            tanggalLabel.Location = new System.Drawing.Point(363, 27);
            tanggalLabel.Name = "tanggalLabel";
            tanggalLabel.Size = new System.Drawing.Size(87, 13);
            tanggalLabel.TabIndex = 5;
            tanggalLabel.Text = "Tanggal Terima :";
            // 
            // jumlahPenjualanLabel
            // 
            jumlahPenjualanLabel.AutoSize = true;
            jumlahPenjualanLabel.Location = new System.Drawing.Point(363, 52);
            jumlahPenjualanLabel.Name = "jumlahPenjualanLabel";
            jumlahPenjualanLabel.Size = new System.Drawing.Size(86, 13);
            jumlahPenjualanLabel.TabIndex = 7;
            jumlahPenjualanLabel.Text = "No. Surat Jalan :";
            // 
            // kodeSupplierLabel
            // 
            kodeSupplierLabel.AutoSize = true;
            kodeSupplierLabel.Location = new System.Drawing.Point(23, 80);
            kodeSupplierLabel.Name = "kodeSupplierLabel";
            kodeSupplierLabel.Size = new System.Drawing.Size(48, 13);
            kodeSupplierLabel.TabIndex = 29;
            kodeSupplierLabel.Text = "Supplier:";
            // 
            // nomorBuktiPembelianLabel
            // 
            nomorBuktiPembelianLabel.AutoSize = true;
            nomorBuktiPembelianLabel.Location = new System.Drawing.Point(24, 53);
            nomorBuktiPembelianLabel.Name = "nomorBuktiPembelianLabel";
            nomorBuktiPembelianLabel.Size = new System.Drawing.Size(45, 13);
            nomorBuktiPembelianLabel.TabIndex = 33;
            nomorBuktiPembelianLabel.Text = "No PO :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(364, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 13);
            label1.TabIndex = 46;
            label1.Text = "Status Pembelian :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 475);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.keluarBtn);
            this.tabPage1.Controls.Add(this.view_jual_nobonDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daftar Penerimaan Barang";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(115, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 37;
            this.button4.Text = "Ubah Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(247, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Pembelian Barang";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tambah Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cariTxt);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(9, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 57);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // cariTxt
            // 
            this.cariTxt.Location = new System.Drawing.Point(45, 22);
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Size = new System.Drawing.Size(362, 20);
            this.cariTxt.TabIndex = 5;
            this.cariTxt.TextChanged += new System.EventHandler(this.cariTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cari ";
            // 
            // keluarBtn
            // 
            this.keluarBtn.Location = new System.Drawing.Point(606, 409);
            this.keluarBtn.Name = "keluarBtn";
            this.keluarBtn.Size = new System.Drawing.Size(96, 23);
            this.keluarBtn.TabIndex = 2;
            this.keluarBtn.Text = "Keluar";
            this.keluarBtn.UseVisualStyleBackColor = true;
            this.keluarBtn.Click += new System.EventHandler(this.keluarBtn_Click);
            // 
            // view_jual_nobonDataGridView
            // 
            this.view_jual_nobonDataGridView.AllowUserToAddRows = false;
            this.view_jual_nobonDataGridView.AllowUserToDeleteRows = false;
            this.view_jual_nobonDataGridView.AllowUserToResizeRows = false;
            this.view_jual_nobonDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.view_jual_nobonDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.view_jual_nobonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_jual_nobonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomorBuktiDataGridViewTextBoxColumn,
            this.nomorBuktiPembelianDataGridViewTextBoxColumn,
            this.nomorSJDataGridViewTextBoxColumn,
            this.kodeSupplierDataGridViewTextBoxColumn,
            this.namaSupplierDataGridViewTextBoxColumn,
            this.totalQtyDataGridViewTextBoxColumn,
            this.totalQtyTerimaDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.view_jual_nobonDataGridView.DataSource = this.view_TerimaBarang_SupplierBindingSource;
            this.view_jual_nobonDataGridView.Location = new System.Drawing.Point(6, 66);
            this.view_jual_nobonDataGridView.Name = "view_jual_nobonDataGridView";
            this.view_jual_nobonDataGridView.ReadOnly = true;
            this.view_jual_nobonDataGridView.RowHeadersVisible = false;
            this.view_jual_nobonDataGridView.Size = new System.Drawing.Size(696, 330);
            this.view_jual_nobonDataGridView.TabIndex = 0;
            this.view_jual_nobonDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_jual_nobonDataGridView_CellDoubleClick);
            // 
            // nomorBuktiDataGridViewTextBoxColumn
            // 
            this.nomorBuktiDataGridViewTextBoxColumn.DataPropertyName = "NomorBukti";
            this.nomorBuktiDataGridViewTextBoxColumn.HeaderText = "No. Terima Barang";
            this.nomorBuktiDataGridViewTextBoxColumn.Name = "nomorBuktiDataGridViewTextBoxColumn";
            this.nomorBuktiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomorBuktiPembelianDataGridViewTextBoxColumn
            // 
            this.nomorBuktiPembelianDataGridViewTextBoxColumn.DataPropertyName = "NomorBuktiPembelian";
            this.nomorBuktiPembelianDataGridViewTextBoxColumn.HeaderText = "No. PO";
            this.nomorBuktiPembelianDataGridViewTextBoxColumn.Name = "nomorBuktiPembelianDataGridViewTextBoxColumn";
            this.nomorBuktiPembelianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomorSJDataGridViewTextBoxColumn
            // 
            this.nomorSJDataGridViewTextBoxColumn.DataPropertyName = "NomorSJ";
            this.nomorSJDataGridViewTextBoxColumn.HeaderText = "No. Surat Jalan";
            this.nomorSJDataGridViewTextBoxColumn.Name = "nomorSJDataGridViewTextBoxColumn";
            this.nomorSJDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodeSupplierDataGridViewTextBoxColumn
            // 
            this.kodeSupplierDataGridViewTextBoxColumn.DataPropertyName = "KodeSupplier";
            this.kodeSupplierDataGridViewTextBoxColumn.HeaderText = "Kd. Supp.";
            this.kodeSupplierDataGridViewTextBoxColumn.Name = "kodeSupplierDataGridViewTextBoxColumn";
            this.kodeSupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaSupplierDataGridViewTextBoxColumn
            // 
            this.namaSupplierDataGridViewTextBoxColumn.DataPropertyName = "NamaSupplier";
            this.namaSupplierDataGridViewTextBoxColumn.HeaderText = "Nm. Supp.";
            this.namaSupplierDataGridViewTextBoxColumn.Name = "namaSupplierDataGridViewTextBoxColumn";
            this.namaSupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQtyDataGridViewTextBoxColumn
            // 
            this.totalQtyDataGridViewTextBoxColumn.DataPropertyName = "TotalQty";
            this.totalQtyDataGridViewTextBoxColumn.HeaderText = "Ttl. Qty Pesanan";
            this.totalQtyDataGridViewTextBoxColumn.Name = "totalQtyDataGridViewTextBoxColumn";
            this.totalQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQtyTerimaDataGridViewTextBoxColumn
            // 
            this.totalQtyTerimaDataGridViewTextBoxColumn.DataPropertyName = "TotalQtyTerima";
            this.totalQtyTerimaDataGridViewTextBoxColumn.HeaderText = "Ttl. QtyTerima";
            this.totalQtyTerimaDataGridViewTextBoxColumn.Name = "totalQtyTerimaDataGridViewTextBoxColumn";
            this.totalQtyTerimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Pembelian";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // view_TerimaBarang_SupplierBindingSource
            // 
            this.view_TerimaBarang_SupplierBindingSource.DataMember = "view_TerimaBarang_Supplier";
            this.view_TerimaBarang_SupplierBindingSource.DataSource = this.terima_Barang;
            // 
            // terima_Barang
            // 
            this.terima_Barang.DataSetName = "Terima_Barang";
            this.terima_Barang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.StatusPembelianTextbox);
            this.tabPage2.Controls.Add(label1);
            this.tabPage2.Controls.Add(this.ResetBtn);
            this.tabPage2.Controls.Add(this.printChkBox);
            this.tabPage2.Controls.Add(this.NomorBuktiPembelianTextBox);
            this.tabPage2.Controls.Add(nomorBuktiPembelianLabel);
            this.tabPage2.Controls.Add(this.batalBtn);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.subTerimaBarangDataGridView);
            this.tabPage2.Controls.Add(this.namaSupplierTextBox);
            this.tabPage2.Controls.Add(kodeSupplierLabel);
            this.tabPage2.Controls.Add(this.kodeSupplierTextBox);
            this.tabPage2.Controls.Add(noBonLabel);
            this.tabPage2.Controls.Add(this.noBonTextBox);
            this.tabPage2.Controls.Add(tanggalLabel);
            this.tabPage2.Controls.Add(this.tanggalDateTimePicker);
            this.tabPage2.Controls.Add(jumlahPenjualanLabel);
            this.tabPage2.Controls.Add(this.nomorSJTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail Penerimaan Barang";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "T = Terbayar , D = Belum Dibayar";
            // 
            // StatusPembelianTextbox
            // 
            this.StatusPembelianTextbox.Enabled = false;
            this.StatusPembelianTextbox.Location = new System.Drawing.Point(462, 77);
            this.StatusPembelianTextbox.Name = "StatusPembelianTextbox";
            this.StatusPembelianTextbox.Size = new System.Drawing.Size(44, 20);
            this.StatusPembelianTextbox.TabIndex = 47;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(12, 388);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(72, 45);
            this.ResetBtn.TabIndex = 45;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // printChkBox
            // 
            this.printChkBox.AutoSize = true;
            this.printChkBox.Checked = true;
            this.printChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printChkBox.Location = new System.Drawing.Point(349, 416);
            this.printChkBox.Name = "printChkBox";
            this.printChkBox.Size = new System.Drawing.Size(146, 17);
            this.printChkBox.TabIndex = 37;
            this.printChkBox.Text = "Print Bukti Terima Barang";
            this.printChkBox.UseVisualStyleBackColor = true;
            // 
            // NomorBuktiPembelianTextBox
            // 
            this.NomorBuktiPembelianTextBox.DataSource = this.view_TerimaBarang_SupplierBindingSource;
            this.NomorBuktiPembelianTextBox.DisplayMember = "NomorBuktiPembelian";
            this.NomorBuktiPembelianTextBox.Enabled = false;
            this.NomorBuktiPembelianTextBox.FormattingEnabled = true;
            this.NomorBuktiPembelianTextBox.Location = new System.Drawing.Point(97, 50);
            this.NomorBuktiPembelianTextBox.Name = "NomorBuktiPembelianTextBox";
            this.NomorBuktiPembelianTextBox.Size = new System.Drawing.Size(200, 21);
            this.NomorBuktiPembelianTextBox.TabIndex = 36;
            this.NomorBuktiPembelianTextBox.ValueMember = "NomorBuktiPembelian";
            this.NomorBuktiPembelianTextBox.SelectionChangeCommitted += new System.EventHandler(this.NomorBuktiPembelianTextBox_SelectionChangeCommitted);
            // 
            // batalBtn
            // 
            this.batalBtn.Location = new System.Drawing.Point(603, 388);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(96, 45);
            this.batalBtn.TabIndex = 33;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = true;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 45);
            this.button3.TabIndex = 33;
            this.button3.Text = "Simpan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // subTerimaBarangDataGridView
            // 
            this.subTerimaBarangDataGridView.AllowUserToAddRows = false;
            this.subTerimaBarangDataGridView.AllowUserToDeleteRows = false;
            this.subTerimaBarangDataGridView.AllowUserToResizeRows = false;
            this.subTerimaBarangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subTerimaBarangDataGridView.Location = new System.Drawing.Point(12, 112);
            this.subTerimaBarangDataGridView.Name = "subTerimaBarangDataGridView";
            this.subTerimaBarangDataGridView.RowHeadersVisible = false;
            this.subTerimaBarangDataGridView.Size = new System.Drawing.Size(687, 269);
            this.subTerimaBarangDataGridView.TabIndex = 32;
            this.subTerimaBarangDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.subTerimaBarangDataGridView_CellValueChanged);
            this.subTerimaBarangDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.subTerimaBarangDataGridView_DataError);
            // 
            // namaSupplierTextBox
            // 
            this.namaSupplierTextBox.Location = new System.Drawing.Point(158, 77);
            this.namaSupplierTextBox.Name = "namaSupplierTextBox";
            this.namaSupplierTextBox.ReadOnly = true;
            this.namaSupplierTextBox.Size = new System.Drawing.Size(139, 20);
            this.namaSupplierTextBox.TabIndex = 31;
            // 
            // kodeSupplierTextBox
            // 
            this.kodeSupplierTextBox.Location = new System.Drawing.Point(97, 77);
            this.kodeSupplierTextBox.Name = "kodeSupplierTextBox";
            this.kodeSupplierTextBox.ReadOnly = true;
            this.kodeSupplierTextBox.Size = new System.Drawing.Size(55, 20);
            this.kodeSupplierTextBox.TabIndex = 30;
            // 
            // noBonTextBox
            // 
            this.noBonTextBox.Location = new System.Drawing.Point(97, 24);
            this.noBonTextBox.Name = "noBonTextBox";
            this.noBonTextBox.ReadOnly = true;
            this.noBonTextBox.Size = new System.Drawing.Size(200, 20);
            this.noBonTextBox.TabIndex = 4;
            // 
            // tanggalDateTimePicker
            // 
            this.tanggalDateTimePicker.Enabled = false;
            this.tanggalDateTimePicker.Location = new System.Drawing.Point(462, 23);
            this.tanggalDateTimePicker.Name = "tanggalDateTimePicker";
            this.tanggalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tanggalDateTimePicker.TabIndex = 6;
            // 
            // nomorSJTextBox
            // 
            this.nomorSJTextBox.Location = new System.Drawing.Point(462, 49);
            this.nomorSJTextBox.Name = "nomorSJTextBox";
            this.nomorSJTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomorSJTextBox.TabIndex = 8;
            // 
            // purchase_Order
            // 
            this.purchase_Order.DataSetName = "Purchase_Order";
            this.purchase_Order.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseOrderTableAdapter
            // 
            this.purchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TerimaBarangTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_TerimaBarang_SupplierTableAdapter
            // 
            this.view_TerimaBarang_SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataMember = "PurchaseOrder";
            this.purchaseOrderBindingSource.DataSource = this.purchase_Order;
            // 
            // Modul_Barang_Penerimaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 475);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "Modul_Barang_Penerimaan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Penerimaan Barang";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Barang_Penerimaan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_jual_nobonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TerimaBarang_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terima_Barang)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subTerimaBarangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.Button keluarBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox noBonTextBox;
        private System.Windows.Forms.DateTimePicker tanggalDateTimePicker;
        private System.Windows.Forms.TextBox nomorSJTextBox;
        private System.Windows.Forms.DataGridView view_jual_nobonDataGridView;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView subTerimaBarangDataGridView;
        private System.Windows.Forms.TextBox namaSupplierTextBox;
        private System.Windows.Forms.TextBox kodeSupplierTextBox;
        private System.Windows.Forms.ComboBox NomorBuktiPembelianTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox printChkBox;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.BindingSource view_TerimaBarang_SupplierBindingSource;
        private Accounting_Solution_Software.Data_set.Terima_Barang terima_Barang;
        private Accounting_Solution_Software.Data_set.Purchase_OrderTableAdapters.PurchaseOrderTableAdapter purchaseOrderTableAdapter;
        private Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.TableAdapterManager tableAdapterManager;
        private Accounting_Solution_Software.Data_set.Terima_BarangTableAdapters.view_TerimaBarang_SupplierTableAdapter view_TerimaBarang_SupplierTableAdapter;
        private Accounting_Solution_Software.Data_set.Purchase_Order purchase_Order;
        private System.Windows.Forms.BindingSource purchaseOrderBindingSource;
        private System.Windows.Forms.TextBox StatusPembelianTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorBuktiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorBuktiPembelianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorSJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQtyTerimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;

    }
}