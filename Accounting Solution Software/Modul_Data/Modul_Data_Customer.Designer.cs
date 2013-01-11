namespace Accounting_Solution_Software
{
    partial class Modul_Data_Customer
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
            System.Windows.Forms.Label kodePelangganLabel;
            System.Windows.Forms.Label namaPelangganLabel;
            System.Windows.Forms.Label contactPersonLabel;
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label kotaLabel;
            System.Windows.Forms.Label kodePosLabel;
            System.Windows.Forms.Label telepon1Label;
            System.Windows.Forms.Label telepon2Label;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label piutangAwalLabel;
            System.Windows.Forms.Label acc_NoLabel;
            System.Windows.Forms.Label discTotalLabel;
            System.Windows.Forms.Label totalPointLabel;
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager();
            this.kotaTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.KotaTableAdapter();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.kodePelangganTextBox = new System.Windows.Forms.TextBox();
            this.namaPelangganTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.kotaComboBox = new System.Windows.Forms.ComboBox();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodePosTextBox = new System.Windows.Forms.TextBox();
            this.telepon1TextBox = new System.Windows.Forms.TextBox();
            this.telepon2TextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.piutangAwalTextBox = new System.Windows.Forms.TextBox();
            this.acc_NoTextBox = new System.Windows.Forms.TextBox();
            this.discTotalTextBox = new System.Windows.Forms.TextBox();
            this.totalPointTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            kodePelangganLabel = new System.Windows.Forms.Label();
            namaPelangganLabel = new System.Windows.Forms.Label();
            contactPersonLabel = new System.Windows.Forms.Label();
            alamatLabel = new System.Windows.Forms.Label();
            kotaLabel = new System.Windows.Forms.Label();
            kodePosLabel = new System.Windows.Forms.Label();
            telepon1Label = new System.Windows.Forms.Label();
            telepon2Label = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            piutangAwalLabel = new System.Windows.Forms.Label();
            acc_NoLabel = new System.Windows.Forms.Label();
            discTotalLabel = new System.Windows.Forms.Label();
            totalPointLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kodePelangganLabel
            // 
            kodePelangganLabel.AutoSize = true;
            kodePelangganLabel.Location = new System.Drawing.Point(25, 32);
            kodePelangganLabel.Name = "kodePelangganLabel";
            kodePelangganLabel.Size = new System.Drawing.Size(89, 13);
            kodePelangganLabel.TabIndex = 1;
            kodePelangganLabel.Text = "Kode Pelanggan:";
            // 
            // namaPelangganLabel
            // 
            namaPelangganLabel.AutoSize = true;
            namaPelangganLabel.Location = new System.Drawing.Point(25, 58);
            namaPelangganLabel.Name = "namaPelangganLabel";
            namaPelangganLabel.Size = new System.Drawing.Size(92, 13);
            namaPelangganLabel.TabIndex = 3;
            namaPelangganLabel.Text = "Nama Pelanggan:";
            // 
            // contactPersonLabel
            // 
            contactPersonLabel.AutoSize = true;
            contactPersonLabel.Location = new System.Drawing.Point(25, 84);
            contactPersonLabel.Name = "contactPersonLabel";
            contactPersonLabel.Size = new System.Drawing.Size(83, 13);
            contactPersonLabel.TabIndex = 5;
            contactPersonLabel.Text = "Contact Person:";
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(25, 110);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(42, 13);
            alamatLabel.TabIndex = 7;
            alamatLabel.Text = "Alamat:";
            // 
            // kotaLabel
            // 
            kotaLabel.AutoSize = true;
            kotaLabel.Location = new System.Drawing.Point(25, 136);
            kotaLabel.Name = "kotaLabel";
            kotaLabel.Size = new System.Drawing.Size(32, 13);
            kotaLabel.TabIndex = 9;
            kotaLabel.Text = "Kota:";
            // 
            // kodePosLabel
            // 
            kodePosLabel.AutoSize = true;
            kodePosLabel.Location = new System.Drawing.Point(326, 136);
            kodePosLabel.Name = "kodePosLabel";
            kodePosLabel.Size = new System.Drawing.Size(56, 13);
            kodePosLabel.TabIndex = 11;
            kodePosLabel.Text = "Kode Pos:";
            // 
            // telepon1Label
            // 
            telepon1Label.AutoSize = true;
            telepon1Label.Location = new System.Drawing.Point(25, 165);
            telepon1Label.Name = "telepon1Label";
            telepon1Label.Size = new System.Drawing.Size(55, 13);
            telepon1Label.TabIndex = 13;
            telepon1Label.Text = "Telepon1:";
            // 
            // telepon2Label
            // 
            telepon2Label.AutoSize = true;
            telepon2Label.Location = new System.Drawing.Point(25, 194);
            telepon2Label.Name = "telepon2Label";
            telepon2Label.Size = new System.Drawing.Size(55, 13);
            telepon2Label.TabIndex = 15;
            telepon2Label.Text = "Telepon2:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(326, 165);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(27, 13);
            faxLabel.TabIndex = 17;
            faxLabel.Text = "Fax:";
            // 
            // piutangAwalLabel
            // 
            piutangAwalLabel.AutoSize = true;
            piutangAwalLabel.Location = new System.Drawing.Point(25, 281);
            piutangAwalLabel.Name = "piutangAwalLabel";
            piutangAwalLabel.Size = new System.Drawing.Size(73, 13);
            piutangAwalLabel.TabIndex = 21;
            piutangAwalLabel.Text = "Total Piutang:";
            // 
            // acc_NoLabel
            // 
            acc_NoLabel.AutoSize = true;
            acc_NoLabel.Location = new System.Drawing.Point(25, 223);
            acc_NoLabel.Name = "acc_NoLabel";
            acc_NoLabel.Size = new System.Drawing.Size(46, 13);
            acc_NoLabel.TabIndex = 23;
            acc_NoLabel.Text = "Acc No:";
            // 
            // discTotalLabel
            // 
            discTotalLabel.AutoSize = true;
            discTotalLabel.Location = new System.Drawing.Point(25, 307);
            discTotalLabel.Name = "discTotalLabel";
            discTotalLabel.Size = new System.Drawing.Size(58, 13);
            discTotalLabel.TabIndex = 27;
            discTotalLabel.Text = "Disc Total:";
            // 
            // totalPointLabel
            // 
            totalPointLabel.AutoSize = true;
            totalPointLabel.Location = new System.Drawing.Point(348, 284);
            totalPointLabel.Name = "totalPointLabel";
            totalPointLabel.Size = new System.Drawing.Size(61, 13);
            totalPointLabel.TabIndex = 29;
            totalPointLabel.Text = "Total Point:";
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.master_Data;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.BeliTableAdapter = null;
            this.tableAdapterManager.BilyetGiroTableAdapter = null;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.CekTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.DokterTableAdapter = null;
            this.tableAdapterManager.GiroTableAdapter = null;
            this.tableAdapterManager.GroupCustomerTableAdapter = null;
            this.tableAdapterManager.GudangTableAdapter = null;
            this.tableAdapterManager.HistoriSubJurnalUmumTableAdapter = null;
            this.tableAdapterManager.IdentityTableAdapter = null;
            this.tableAdapterManager.JasaDokterTableAdapter = null;
            this.tableAdapterManager.JasaTableAdapter = null;
            this.tableAdapterManager.JualTableAdapter = null;
            this.tableAdapterManager.JurnalUmumTableAdapter = null;
            this.tableAdapterManager.karyawanTableAdapter = null;
            this.tableAdapterManager.KelompokAccountTableAdapter = null;
            this.tableAdapterManager.KotaTableAdapter = this.kotaTableAdapter;
            this.tableAdapterManager.PajakTableAdapter = null;
            this.tableAdapterManager.RacikanTableAdapter = null;
            this.tableAdapterManager.RekonsiliasiTableAdapter = null;
            this.tableAdapterManager.RetBeliTableAdapter = null;
            this.tableAdapterManager.RetJualTableAdapter = null;
            this.tableAdapterManager.RetSubBeliTableAdapter = null;
            this.tableAdapterManager.RetSubJualTableAdapter = null;
            this.tableAdapterManager.SalesmanTableAdapter = null;
            this.tableAdapterManager.SavingTableAdapter = null;
            this.tableAdapterManager.SettingTableAdapter = null;
            this.tableAdapterManager.SistemTableAdapter = null;
            this.tableAdapterManager.StockGudangTableAdapter = null;
            this.tableAdapterManager.stockMovementTableAdapter = null;
            this.tableAdapterManager.StockOpnameTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.SubBeliTableAdapter = null;
            this.tableAdapterManager.SubJualTableAdapter = null;
            this.tableAdapterManager.SubTerimaBarangTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.TerimaBarangTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtangTableAdapter = null;
            // 
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(12, 380);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.Size = new System.Drawing.Size(656, 181);
            this.customerDataGridView.TabIndex = 1;
            // 
            // kodePelangganTextBox
            // 
            this.kodePelangganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "KodePelanggan", true));
            this.kodePelangganTextBox.Location = new System.Drawing.Point(123, 29);
            this.kodePelangganTextBox.Name = "kodePelangganTextBox";
            this.kodePelangganTextBox.ReadOnly = true;
            this.kodePelangganTextBox.Size = new System.Drawing.Size(315, 20);
            this.kodePelangganTextBox.TabIndex = 1;
            // 
            // namaPelangganTextBox
            // 
            this.namaPelangganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "NamaPelanggan", true));
            this.namaPelangganTextBox.Location = new System.Drawing.Point(123, 55);
            this.namaPelangganTextBox.Name = "namaPelangganTextBox";
            this.namaPelangganTextBox.Size = new System.Drawing.Size(491, 20);
            this.namaPelangganTextBox.TabIndex = 2;
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "ContactPerson", true));
            this.contactPersonTextBox.Location = new System.Drawing.Point(123, 81);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(491, 20);
            this.contactPersonTextBox.TabIndex = 3;
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Alamat", true));
            this.alamatTextBox.Location = new System.Drawing.Point(123, 107);
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(491, 20);
            this.alamatTextBox.TabIndex = 4;
            // 
            // kotaComboBox
            // 
            this.kotaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Kota", true));
            this.kotaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "Kota", true));
            this.kotaComboBox.DataSource = this.kotaBindingSource;
            this.kotaComboBox.DisplayMember = "nama";
            this.kotaComboBox.FormattingEnabled = true;
            this.kotaComboBox.Location = new System.Drawing.Point(123, 133);
            this.kotaComboBox.Name = "kotaComboBox";
            this.kotaComboBox.Size = new System.Drawing.Size(188, 21);
            this.kotaComboBox.TabIndex = 5;
            this.kotaComboBox.ValueMember = "nama";
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "Kota";
            this.kotaBindingSource.DataSource = this.master_Data;
            // 
            // kodePosTextBox
            // 
            this.kodePosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "KodePos", true));
            this.kodePosTextBox.Location = new System.Drawing.Point(387, 133);
            this.kodePosTextBox.Name = "kodePosTextBox";
            this.kodePosTextBox.Size = new System.Drawing.Size(121, 20);
            this.kodePosTextBox.TabIndex = 6;
            this.kodePosTextBox.TextChanged += new System.EventHandler(this.kodePosTextBox_TextChanged);
            // 
            // telepon1TextBox
            // 
            this.telepon1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Telepon1", true));
            this.telepon1TextBox.Location = new System.Drawing.Point(123, 162);
            this.telepon1TextBox.Name = "telepon1TextBox";
            this.telepon1TextBox.Size = new System.Drawing.Size(188, 20);
            this.telepon1TextBox.TabIndex = 7;
            // 
            // telepon2TextBox
            // 
            this.telepon2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Telepon2", true));
            this.telepon2TextBox.Location = new System.Drawing.Point(123, 191);
            this.telepon2TextBox.Name = "telepon2TextBox";
            this.telepon2TextBox.Size = new System.Drawing.Size(188, 20);
            this.telepon2TextBox.TabIndex = 9;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(387, 165);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(160, 20);
            this.faxTextBox.TabIndex = 8;
            // 
            // piutangAwalTextBox
            // 
            this.piutangAwalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PiutangAwal", true));
            this.piutangAwalTextBox.Location = new System.Drawing.Point(123, 278);
            this.piutangAwalTextBox.Name = "piutangAwalTextBox";
            this.piutangAwalTextBox.ReadOnly = true;
            this.piutangAwalTextBox.Size = new System.Drawing.Size(209, 20);
            this.piutangAwalTextBox.TabIndex = 22;
            // 
            // acc_NoTextBox
            // 
            this.acc_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Acc_No", true));
            this.acc_NoTextBox.Location = new System.Drawing.Point(123, 220);
            this.acc_NoTextBox.Name = "acc_NoTextBox";
            this.acc_NoTextBox.Size = new System.Drawing.Size(277, 20);
            this.acc_NoTextBox.TabIndex = 10;
            // 
            // discTotalTextBox
            // 
            this.discTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "DiscTotal", true));
            this.discTotalTextBox.Location = new System.Drawing.Point(123, 304);
            this.discTotalTextBox.Name = "discTotalTextBox";
            this.discTotalTextBox.ReadOnly = true;
            this.discTotalTextBox.Size = new System.Drawing.Size(209, 20);
            this.discTotalTextBox.TabIndex = 28;
            // 
            // totalPointTextBox
            // 
            this.totalPointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "TotalPoint", true));
            this.totalPointTextBox.Location = new System.Drawing.Point(426, 281);
            this.totalPointTextBox.Name = "totalPointTextBox";
            this.totalPointTextBox.ReadOnly = true;
            this.totalPointTextBox.Size = new System.Drawing.Size(173, 20);
            this.totalPointTextBox.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 82);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Lainnya";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 242);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informasi Customer";
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(589, 348);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 36;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(507, 348);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 37;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(426, 348);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 35;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Location = new System.Drawing.Point(347, 349);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(75, 23);
            this.btn_ubah.TabIndex = 33;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Enabled = false;
            this.btn_simpan.Location = new System.Drawing.Point(267, 348);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 34;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KodePelanggan";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kd. Cust.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaPelanggan";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nm. Cust.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ContactPerson";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ctc. Person";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Alamat";
            this.dataGridViewTextBoxColumn4.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Kota";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kota";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KodePos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Kode Pos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telepon1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tlp. 1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telepon2";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tlp. 2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Fax";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fax";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "KodeArea";
            this.dataGridViewTextBoxColumn10.HeaderText = "Kode Area";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PiutangAwal";
            this.dataGridViewTextBoxColumn11.HeaderText = "PiutangAwal";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Acc_No";
            this.dataGridViewTextBoxColumn12.HeaderText = "Acc_No";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "JmlHari";
            this.dataGridViewTextBoxColumn13.HeaderText = "JmlHari";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DiscTotal";
            this.dataGridViewTextBoxColumn14.HeaderText = "DiscTotal";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TotalPoint";
            this.dataGridViewTextBoxColumn15.HeaderText = "TotalPoint";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "KodeGroup";
            this.dataGridViewTextBoxColumn16.HeaderText = "KodeGroup";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // Modul_Data_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(680, 571);
            this.ControlBox = false;
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(kodePelangganLabel);
            this.Controls.Add(this.kodePelangganTextBox);
            this.Controls.Add(namaPelangganLabel);
            this.Controls.Add(this.namaPelangganTextBox);
            this.Controls.Add(contactPersonLabel);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(this.alamatTextBox);
            this.Controls.Add(kotaLabel);
            this.Controls.Add(this.kotaComboBox);
            this.Controls.Add(kodePosLabel);
            this.Controls.Add(this.kodePosTextBox);
            this.Controls.Add(telepon1Label);
            this.Controls.Add(this.telepon1TextBox);
            this.Controls.Add(telepon2Label);
            this.Controls.Add(this.telepon2TextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(piutangAwalLabel);
            this.Controls.Add(this.piutangAwalTextBox);
            this.Controls.Add(acc_NoLabel);
            this.Controls.Add(this.acc_NoTextBox);
            this.Controls.Add(discTotalLabel);
            this.Controls.Add(this.discTotalTextBox);
            this.Controls.Add(totalPointLabel);
            this.Controls.Add(this.totalPointTextBox);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modul_Data_Customer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Pelanggan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Data_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.CustomerTableAdapter customerTableAdapter;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox kodePelangganTextBox;
        private System.Windows.Forms.TextBox namaPelangganTextBox;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.ComboBox kotaComboBox;
        private System.Windows.Forms.TextBox kodePosTextBox;
        private System.Windows.Forms.TextBox telepon1TextBox;
        private System.Windows.Forms.TextBox telepon2TextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox piutangAwalTextBox;
        private System.Windows.Forms.TextBox acc_NoTextBox;
        private System.Windows.Forms.TextBox discTotalTextBox;
        private System.Windows.Forms.TextBox totalPointTextBox;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.KotaTableAdapter kotaTableAdapter;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

    }
}