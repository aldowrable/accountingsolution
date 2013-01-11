namespace Accounting_Solution_Software
{
    partial class Modul_Barang_Pemindahan
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
            System.Windows.Forms.Label no_buktiLabel;
            System.Windows.Forms.Label id_gudang_asalLabel1;
            System.Windows.Forms.Label id_gudang_tujuanLabel1;
            System.Windows.Forms.Label label1;
            this.no_buktiTextBox = new System.Windows.Forms.TextBox();
            this.mutasiStockdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.id_gudang_tujuanComboBox = new System.Windows.Forms.ComboBox();
            this.gudangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stock_Data = new Accounting_Solution_Software.Data_set.Stock_Data();
            this.id_gudang_asalComboBox = new System.Windows.Forms.ComboBox();
            this.gudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.KeluarBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BaruBtn = new System.Windows.Forms.Button();
            this.view_stockMovement_GudangDataGridView = new System.Windows.Forms.DataGridView();
            this.noBuktiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaCabangAsalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaCabangTujuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewstockMovementGudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gudangBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.statusPembayaranTxt = new System.Windows.Forms.ComboBox();
            this.gudangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.printChkBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.view_stockMovement_GudangTableAdapter = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.view_stockMovement_GudangTableAdapter();
            this.gudangTableAdapter = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.GudangTableAdapter();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            no_buktiLabel = new System.Windows.Forms.Label();
            id_gudang_asalLabel1 = new System.Windows.Forms.Label();
            id_gudang_tujuanLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mutasiStockdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_stockMovement_GudangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewstockMovementGudangBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // no_buktiLabel
            // 
            no_buktiLabel.AutoSize = true;
            no_buktiLabel.Location = new System.Drawing.Point(12, 24);
            no_buktiLabel.Name = "no_buktiLabel";
            no_buktiLabel.Size = new System.Drawing.Size(54, 13);
            no_buktiLabel.TabIndex = 0;
            no_buktiLabel.Text = "No Bukti :";
            // 
            // id_gudang_asalLabel1
            // 
            id_gudang_asalLabel1.AutoSize = true;
            id_gudang_asalLabel1.Location = new System.Drawing.Point(282, 24);
            id_gudang_asalLabel1.Name = "id_gudang_asalLabel1";
            id_gudang_asalLabel1.Size = new System.Drawing.Size(74, 13);
            id_gudang_asalLabel1.TabIndex = 11;
            id_gudang_asalLabel1.Text = "Gudang Asal :";
            // 
            // id_gudang_tujuanLabel1
            // 
            id_gudang_tujuanLabel1.AutoSize = true;
            id_gudang_tujuanLabel1.Location = new System.Drawing.Point(282, 52);
            id_gudang_tujuanLabel1.Name = "id_gudang_tujuanLabel1";
            id_gudang_tujuanLabel1.Size = new System.Drawing.Size(87, 13);
            id_gudang_tujuanLabel1.TabIndex = 12;
            id_gudang_tujuanLabel1.Text = "Gudang Tujuan :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 15;
            label1.Text = "Tanggal :";
            // 
            // no_buktiTextBox
            // 
            this.no_buktiTextBox.Location = new System.Drawing.Point(72, 21);
            this.no_buktiTextBox.Name = "no_buktiTextBox";
            this.no_buktiTextBox.ReadOnly = true;
            this.no_buktiTextBox.Size = new System.Drawing.Size(170, 20);
            this.no_buktiTextBox.TabIndex = 1;
            this.no_buktiTextBox.Text = "Auto";
            // 
            // mutasiStockdataGridView
            // 
            this.mutasiStockdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mutasiStockdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.kodeStock,
            this.namaStock,
            this.qty,
            this.satuan});
            this.mutasiStockdataGridView.Location = new System.Drawing.Point(12, 111);
            this.mutasiStockdataGridView.Name = "mutasiStockdataGridView";
            this.mutasiStockdataGridView.RowHeadersVisible = false;
            this.mutasiStockdataGridView.Size = new System.Drawing.Size(519, 322);
            this.mutasiStockdataGridView.TabIndex = 10;
            this.mutasiStockdataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.mutasiStockdataGridView_CellValueChanged);
            this.mutasiStockdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mutasiStockdataGridView_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.id_gudang_tujuanComboBox);
            this.groupBox1.Controls.Add(this.id_gudang_asalComboBox);
            this.groupBox1.Controls.Add(id_gudang_tujuanLabel1);
            this.groupBox1.Controls.Add(no_buktiLabel);
            this.groupBox1.Controls.Add(id_gudang_asalLabel1);
            this.groupBox1.Controls.Add(this.no_buktiTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 90);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // id_gudang_tujuanComboBox
            // 
            this.id_gudang_tujuanComboBox.DataSource = this.gudangBindingSource1;
            this.id_gudang_tujuanComboBox.DisplayMember = "nama";
            this.id_gudang_tujuanComboBox.FormattingEnabled = true;
            this.id_gudang_tujuanComboBox.Location = new System.Drawing.Point(375, 48);
            this.id_gudang_tujuanComboBox.Name = "id_gudang_tujuanComboBox";
            this.id_gudang_tujuanComboBox.Size = new System.Drawing.Size(149, 21);
            this.id_gudang_tujuanComboBox.TabIndex = 14;
            this.id_gudang_tujuanComboBox.ValueMember = "id";
            // 
            // gudangBindingSource1
            // 
            this.gudangBindingSource1.DataMember = "Gudang";
            this.gudangBindingSource1.DataSource = this.stock_Data;
            // 
            // stock_Data
            // 
            this.stock_Data.DataSetName = "Stock_Data";
            this.stock_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_gudang_asalComboBox
            // 
            this.id_gudang_asalComboBox.DataSource = this.gudangBindingSource;
            this.id_gudang_asalComboBox.DisplayMember = "nama";
            this.id_gudang_asalComboBox.FormattingEnabled = true;
            this.id_gudang_asalComboBox.Location = new System.Drawing.Point(375, 21);
            this.id_gudang_asalComboBox.Name = "id_gudang_asalComboBox";
            this.id_gudang_asalComboBox.Size = new System.Drawing.Size(149, 21);
            this.id_gudang_asalComboBox.TabIndex = 13;
            this.id_gudang_asalComboBox.ValueMember = "id";
            // 
            // gudangBindingSource
            // 
            this.gudangBindingSource.DataMember = "Gudang";
            this.gudangBindingSource.DataSource = this.stock_Data;
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(496, 449);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 41;
            this.btn_keluar.Text = "Batal";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click_1);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(415, 449);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 39;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(537, 171);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(34, 23);
            this.btn_hapus.TabIndex = 42;
            this.btn_hapus.Text = "x";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 502);
            this.tabControl1.TabIndex = 43;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.KeluarBtn);
            this.tabPage1.Controls.Add(this.EditBtn);
            this.tabPage1.Controls.Add(this.BaruBtn);
            this.tabPage1.Controls.Add(this.view_stockMovement_GudangDataGridView);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daftar Mutasi Stock";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // KeluarBtn
            // 
            this.KeluarBtn.Location = new System.Drawing.Point(496, 449);
            this.KeluarBtn.Name = "KeluarBtn";
            this.KeluarBtn.Size = new System.Drawing.Size(75, 23);
            this.KeluarBtn.TabIndex = 47;
            this.KeluarBtn.Text = "Keluar";
            this.KeluarBtn.UseVisualStyleBackColor = true;
            this.KeluarBtn.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(122, 449);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(108, 23);
            this.EditBtn.TabIndex = 45;
            this.EditBtn.Text = "Ubah Data";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BaruBtn
            // 
            this.BaruBtn.Location = new System.Drawing.Point(8, 449);
            this.BaruBtn.Name = "BaruBtn";
            this.BaruBtn.Size = new System.Drawing.Size(108, 23);
            this.BaruBtn.TabIndex = 46;
            this.BaruBtn.Text = "Tambah Data";
            this.BaruBtn.UseVisualStyleBackColor = true;
            this.BaruBtn.Click += new System.EventHandler(this.BaruBtn_Click);
            // 
            // view_stockMovement_GudangDataGridView
            // 
            this.view_stockMovement_GudangDataGridView.AllowUserToAddRows = false;
            this.view_stockMovement_GudangDataGridView.AllowUserToDeleteRows = false;
            this.view_stockMovement_GudangDataGridView.AutoGenerateColumns = false;
            this.view_stockMovement_GudangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_stockMovement_GudangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noBuktiDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.namaCabangAsalDataGridViewTextBoxColumn,
            this.namaCabangTujuanDataGridViewTextBoxColumn});
            this.view_stockMovement_GudangDataGridView.DataSource = this.viewstockMovementGudangBindingSource;
            this.view_stockMovement_GudangDataGridView.Location = new System.Drawing.Point(8, 122);
            this.view_stockMovement_GudangDataGridView.Name = "view_stockMovement_GudangDataGridView";
            this.view_stockMovement_GudangDataGridView.RowHeadersVisible = false;
            this.view_stockMovement_GudangDataGridView.Size = new System.Drawing.Size(563, 321);
            this.view_stockMovement_GudangDataGridView.TabIndex = 44;
            this.view_stockMovement_GudangDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_stockMovement_GudangDataGridView_CellDoubleClick);
            // 
            // noBuktiDataGridViewTextBoxColumn
            // 
            this.noBuktiDataGridViewTextBoxColumn.DataPropertyName = "noBukti";
            this.noBuktiDataGridViewTextBoxColumn.HeaderText = "No. Mutasi";
            this.noBuktiDataGridViewTextBoxColumn.Name = "noBuktiDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tgl.";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // namaCabangAsalDataGridViewTextBoxColumn
            // 
            this.namaCabangAsalDataGridViewTextBoxColumn.DataPropertyName = "NamaCabangAsal";
            this.namaCabangAsalDataGridViewTextBoxColumn.HeaderText = "Cabang Asal";
            this.namaCabangAsalDataGridViewTextBoxColumn.Name = "namaCabangAsalDataGridViewTextBoxColumn";
            this.namaCabangAsalDataGridViewTextBoxColumn.Width = 175;
            // 
            // namaCabangTujuanDataGridViewTextBoxColumn
            // 
            this.namaCabangTujuanDataGridViewTextBoxColumn.DataPropertyName = "NamaCabangTujuan";
            this.namaCabangTujuanDataGridViewTextBoxColumn.HeaderText = "Cabang Tujuan";
            this.namaCabangTujuanDataGridViewTextBoxColumn.Name = "namaCabangTujuanDataGridViewTextBoxColumn";
            this.namaCabangTujuanDataGridViewTextBoxColumn.Width = 175;
            // 
            // viewstockMovementGudangBindingSource
            // 
            this.viewstockMovementGudangBindingSource.DataMember = "view_stockMovement_Gudang";
            this.viewstockMovementGudangBindingSource.DataSource = this.stock_Data;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.cariTxt);
            this.groupBox4.Controls.Add(this.statusPembayaranTxt);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 109);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.gudangBindingSource3;
            this.comboBox1.DisplayMember = "nama";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(370, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gudangBindingSource3
            // 
            this.gudangBindingSource3.DataMember = "Gudang";
            this.gudangBindingSource3.DataSource = this.stock_Data;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cabang Tujuan :";
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
            this.checkBox4.Location = new System.Drawing.Point(257, 76);
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
            this.statusPembayaranTxt.DataSource = this.gudangBindingSource2;
            this.statusPembayaranTxt.DisplayMember = "nama";
            this.statusPembayaranTxt.FormattingEnabled = true;
            this.statusPembayaranTxt.Location = new System.Drawing.Point(143, 73);
            this.statusPembayaranTxt.Name = "statusPembayaranTxt";
            this.statusPembayaranTxt.Size = new System.Drawing.Size(101, 21);
            this.statusPembayaranTxt.TabIndex = 6;
            this.statusPembayaranTxt.ValueMember = "id";
            this.statusPembayaranTxt.SelectedIndexChanged += new System.EventHandler(this.statusPembayaranTxt_SelectedIndexChanged);
            // 
            // gudangBindingSource2
            // 
            this.gudangBindingSource2.DataMember = "Gudang";
            this.gudangBindingSource2.DataSource = this.stock_Data;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(143, 20);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cabang Asal :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ResetBtn);
            this.tabPage2.Controls.Add(this.printChkBox);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_hapus);
            this.tabPage2.Controls.Add(this.mutasiStockdataGridView);
            this.tabPage2.Controls.Add(this.btn_keluar);
            this.tabPage2.Controls.Add(this.btn_simpan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail Mutasi Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(10, 449);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(72, 23);
            this.ResetBtn.TabIndex = 47;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // printChkBox
            // 
            this.printChkBox.AutoSize = true;
            this.printChkBox.Checked = true;
            this.printChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printChkBox.Location = new System.Drawing.Point(263, 453);
            this.printChkBox.Name = "printChkBox";
            this.printChkBox.Size = new System.Drawing.Size(145, 17);
            this.printChkBox.TabIndex = 46;
            this.printChkBox.Text = "Print Bukti Mutasi Barang";
            this.printChkBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_stockMovement_GudangTableAdapter
            // 
            this.view_stockMovement_GudangTableAdapter.ClearBeforeFill = true;
            // 
            // gudangTableAdapter
            // 
            this.gudangTableAdapter.ClearBeforeFill = true;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            // 
            // kodeStock
            // 
            this.kodeStock.HeaderText = "Kd. Produk";
            this.kodeStock.Name = "kodeStock";
            // 
            // namaStock
            // 
            this.namaStock.HeaderText = "Nm. Produk";
            this.namaStock.Name = "namaStock";
            this.namaStock.ReadOnly = true;
            this.namaStock.Width = 150;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.Width = 50;
            // 
            // satuan
            // 
            this.satuan.HeaderText = "Satuan";
            this.satuan.Name = "satuan";
            this.satuan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Modul_Barang_Pemindahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(585, 502);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Barang_Pemindahan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mutasi Stock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Barang_Pemindahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mutasiStockdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_stockMovement_GudangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewstockMovementGudangBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox no_buktiTextBox;
        public System.Windows.Forms.DataGridView mutasiStockdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.ComboBox id_gudang_tujuanComboBox;
        private System.Windows.Forms.ComboBox id_gudang_asalComboBox;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.ComboBox statusPembayaranTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView view_stockMovement_GudangDataGridView;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BaruBtn;
        private System.Windows.Forms.Button KeluarBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.CheckBox printChkBox;
        private Accounting_Solution_Software.Data_set.Stock_Data stock_Data;
        private System.Windows.Forms.BindingSource viewstockMovementGudangBindingSource;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.view_stockMovement_GudangTableAdapter view_stockMovement_GudangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noBuktiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaCabangAsalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaCabangTujuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gudangBindingSource;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.GudangTableAdapter gudangTableAdapter;
        private System.Windows.Forms.BindingSource gudangBindingSource1;
        private System.Windows.Forms.BindingSource gudangBindingSource3;
        private System.Windows.Forms.BindingSource gudangBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
    }
}