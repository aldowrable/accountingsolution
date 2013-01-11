namespace Accounting_Solution_Software
{
    partial class Modul_Data_Salesman
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
            System.Windows.Forms.Label kodeSalesmanLabel;
            System.Windows.Forms.Label namaSalesmanLabel;
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label kotaLabel;
            System.Windows.Forms.Label kodePosLabel;
            System.Windows.Forms.Label telepon1Label;
            System.Windows.Forms.Label telepon2Label;
            System.Windows.Forms.Label komisiLabel;
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.salesmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesmanTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.SalesmanTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager();
            this.kotaTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.KotaTableAdapter();
            this.salesmanDataGridView = new System.Windows.Forms.DataGridView();
            this.kodeSalesmanTextBox = new System.Windows.Forms.TextBox();
            this.namaSalesmanTextBox = new System.Windows.Forms.TextBox();
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.kodePosTextBox = new System.Windows.Forms.TextBox();
            this.telepon1TextBox = new System.Windows.Forms.TextBox();
            this.telepon2TextBox = new System.Windows.Forms.TextBox();
            this.komisiTextBox = new System.Windows.Forms.TextBox();
            this.kotaComboBox = new System.Windows.Forms.ComboBox();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            kodeSalesmanLabel = new System.Windows.Forms.Label();
            namaSalesmanLabel = new System.Windows.Forms.Label();
            alamatLabel = new System.Windows.Forms.Label();
            kotaLabel = new System.Windows.Forms.Label();
            kodePosLabel = new System.Windows.Forms.Label();
            telepon1Label = new System.Windows.Forms.Label();
            telepon2Label = new System.Windows.Forms.Label();
            komisiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kodeSalesmanLabel
            // 
            kodeSalesmanLabel.AutoSize = true;
            kodeSalesmanLabel.Location = new System.Drawing.Point(30, 38);
            kodeSalesmanLabel.Name = "kodeSalesmanLabel";
            kodeSalesmanLabel.Size = new System.Drawing.Size(84, 13);
            kodeSalesmanLabel.TabIndex = 2;
            kodeSalesmanLabel.Text = "Kode Salesman:";
            // 
            // namaSalesmanLabel
            // 
            namaSalesmanLabel.AutoSize = true;
            namaSalesmanLabel.Location = new System.Drawing.Point(30, 64);
            namaSalesmanLabel.Name = "namaSalesmanLabel";
            namaSalesmanLabel.Size = new System.Drawing.Size(87, 13);
            namaSalesmanLabel.TabIndex = 4;
            namaSalesmanLabel.Text = "Nama Salesman:";
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(30, 90);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(42, 13);
            alamatLabel.TabIndex = 6;
            alamatLabel.Text = "Alamat:";
            // 
            // kotaLabel
            // 
            kotaLabel.AutoSize = true;
            kotaLabel.Location = new System.Drawing.Point(30, 116);
            kotaLabel.Name = "kotaLabel";
            kotaLabel.Size = new System.Drawing.Size(32, 13);
            kotaLabel.TabIndex = 8;
            kotaLabel.Text = "Kota:";
            // 
            // kodePosLabel
            // 
            kodePosLabel.AutoSize = true;
            kodePosLabel.Location = new System.Drawing.Point(283, 116);
            kodePosLabel.Name = "kodePosLabel";
            kodePosLabel.Size = new System.Drawing.Size(56, 13);
            kodePosLabel.TabIndex = 10;
            kodePosLabel.Text = "Kode Pos:";
            kodePosLabel.Click += new System.EventHandler(this.kodePosLabel_Click);
            // 
            // telepon1Label
            // 
            telepon1Label.AutoSize = true;
            telepon1Label.Location = new System.Drawing.Point(30, 150);
            telepon1Label.Name = "telepon1Label";
            telepon1Label.Size = new System.Drawing.Size(55, 13);
            telepon1Label.TabIndex = 12;
            telepon1Label.Text = "Telepon1:";
            // 
            // telepon2Label
            // 
            telepon2Label.AutoSize = true;
            telepon2Label.Location = new System.Drawing.Point(284, 150);
            telepon2Label.Name = "telepon2Label";
            telepon2Label.Size = new System.Drawing.Size(55, 13);
            telepon2Label.TabIndex = 14;
            telepon2Label.Text = "Telepon2:";
            // 
            // komisiLabel
            // 
            komisiLabel.AutoSize = true;
            komisiLabel.Location = new System.Drawing.Point(30, 178);
            komisiLabel.Name = "komisiLabel";
            komisiLabel.Size = new System.Drawing.Size(40, 13);
            komisiLabel.TabIndex = 18;
            komisiLabel.Text = "Komisi:";
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesmanBindingSource
            // 
            this.salesmanBindingSource.DataMember = "Salesman";
            this.salesmanBindingSource.DataSource = this.master_Data;
            // 
            // salesmanTableAdapter
            // 
            this.salesmanTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.CustomerTableAdapter = null;
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
            this.tableAdapterManager.SalesmanTableAdapter = this.salesmanTableAdapter;
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
            // salesmanDataGridView
            // 
            this.salesmanDataGridView.AutoGenerateColumns = false;
            this.salesmanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesmanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.salesmanDataGridView.DataSource = this.salesmanBindingSource;
            this.salesmanDataGridView.Location = new System.Drawing.Point(12, 259);
            this.salesmanDataGridView.Name = "salesmanDataGridView";
            this.salesmanDataGridView.RowHeadersVisible = false;
            this.salesmanDataGridView.Size = new System.Drawing.Size(501, 220);
            this.salesmanDataGridView.TabIndex = 1;
            // 
            // kodeSalesmanTextBox
            // 
            this.kodeSalesmanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanBindingSource, "KodeSalesman", true));
            this.kodeSalesmanTextBox.Location = new System.Drawing.Point(123, 35);
            this.kodeSalesmanTextBox.Name = "kodeSalesmanTextBox";
            this.kodeSalesmanTextBox.ReadOnly = true;
            this.kodeSalesmanTextBox.Size = new System.Drawing.Size(227, 20);
            this.kodeSalesmanTextBox.TabIndex = 3;
            // 
            // namaSalesmanTextBox
            // 
            this.namaSalesmanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanBindingSource, "NamaSalesman", true));
            this.namaSalesmanTextBox.Location = new System.Drawing.Point(123, 61);
            this.namaSalesmanTextBox.Name = "namaSalesmanTextBox";
            this.namaSalesmanTextBox.Size = new System.Drawing.Size(361, 20);
            this.namaSalesmanTextBox.TabIndex = 5;
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanBindingSource, "Alamat", true));
            this.alamatTextBox.Location = new System.Drawing.Point(123, 87);
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(361, 20);
            this.alamatTextBox.TabIndex = 7;
            // 
            // kodePosTextBox
            // 
            this.kodePosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanBindingSource, "KodePos", true));
            this.kodePosTextBox.Location = new System.Drawing.Point(345, 116);
            this.kodePosTextBox.Name = "kodePosTextBox";
            this.kodePosTextBox.Size = new System.Drawing.Size(100, 20);
            this.kodePosTextBox.TabIndex = 11;
            this.kodePosTextBox.TextChanged += new System.EventHandler(this.kodePosTextBox_TextChanged);
            // 
            // telepon1TextBox
            // 
            this.telepon1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanBindingSource, "Telepon1", true));
            this.telepon1TextBox.Location = new System.Drawing.Point(123, 147);
            this.telepon1TextBox.Name = "telepon1TextBox";
            this.telepon1TextBox.Size = new System.Drawing.Size(145, 20);
            this.telepon1TextBox.TabIndex = 13;
            // 
            // telepon2TextBox
            // 
            this.telepon2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanBindingSource, "Telepon2", true));
            this.telepon2TextBox.Location = new System.Drawing.Point(345, 147);
            this.telepon2TextBox.Name = "telepon2TextBox";
            this.telepon2TextBox.Size = new System.Drawing.Size(139, 20);
            this.telepon2TextBox.TabIndex = 15;
            // 
            // komisiTextBox
            // 
            this.komisiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanBindingSource, "Komisi", true));
            this.komisiTextBox.Location = new System.Drawing.Point(123, 175);
            this.komisiTextBox.Name = "komisiTextBox";
            this.komisiTextBox.Size = new System.Drawing.Size(173, 20);
            this.komisiTextBox.TabIndex = 19;
            this.komisiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.komisiTextBox_KeyPress);
            // 
            // kotaComboBox
            // 
            this.kotaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesmanBindingSource, "Kota", true));
            this.kotaComboBox.DataSource = this.kotaBindingSource;
            this.kotaComboBox.DisplayMember = "nama";
            this.kotaComboBox.FormattingEnabled = true;
            this.kotaComboBox.Location = new System.Drawing.Point(123, 116);
            this.kotaComboBox.Name = "kotaComboBox";
            this.kotaComboBox.Size = new System.Drawing.Size(121, 21);
            this.kotaComboBox.TabIndex = 20;
            this.kotaComboBox.ValueMember = "nama";
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "Kota";
            this.kotaBindingSource.DataSource = this.master_Data;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 210);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi";
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(438, 225);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 46;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(356, 225);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 47;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(275, 225);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 45;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Location = new System.Drawing.Point(196, 226);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(75, 23);
            this.btn_ubah.TabIndex = 43;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Enabled = false;
            this.btn_simpan.Location = new System.Drawing.Point(116, 225);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 44;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KodeSalesman";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kd. Salesman";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaSalesman";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nm. Salesman";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Alamat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kota";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kota";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "KodePos";
            this.dataGridViewTextBoxColumn5.HeaderText = "KodePos";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telepon1";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tlp 1";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telepon2";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tlp 2";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "KodeArea";
            this.dataGridViewTextBoxColumn8.HeaderText = "Kode Area";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Komisi";
            this.dataGridViewTextBoxColumn9.HeaderText = "Komisi";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // Modul_Data_Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(526, 496);
            this.ControlBox = false;
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.kotaComboBox);
            this.Controls.Add(kodeSalesmanLabel);
            this.Controls.Add(this.kodeSalesmanTextBox);
            this.Controls.Add(namaSalesmanLabel);
            this.Controls.Add(this.namaSalesmanTextBox);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(this.alamatTextBox);
            this.Controls.Add(kotaLabel);
            this.Controls.Add(kodePosLabel);
            this.Controls.Add(this.kodePosTextBox);
            this.Controls.Add(telepon1Label);
            this.Controls.Add(this.telepon1TextBox);
            this.Controls.Add(telepon2Label);
            this.Controls.Add(this.telepon2TextBox);
            this.Controls.Add(komisiLabel);
            this.Controls.Add(this.komisiTextBox);
            this.Controls.Add(this.salesmanDataGridView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modul_Data_Salesman";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Salesman";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Data_Salesman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource salesmanBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.SalesmanTableAdapter salesmanTableAdapter;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView salesmanDataGridView;
        private System.Windows.Forms.TextBox kodeSalesmanTextBox;
        private System.Windows.Forms.TextBox namaSalesmanTextBox;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.TextBox kodePosTextBox;
        private System.Windows.Forms.TextBox telepon1TextBox;
        private System.Windows.Forms.TextBox telepon2TextBox;
        private System.Windows.Forms.TextBox komisiTextBox;
        private System.Windows.Forms.ComboBox kotaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.KotaTableAdapter kotaTableAdapter;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}