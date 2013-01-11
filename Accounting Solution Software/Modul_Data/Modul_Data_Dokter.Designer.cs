namespace Accounting_Solution_Software
{
    partial class Modul_Data_Dokter
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
            System.Windows.Forms.Label kodeDokterLabel;
            System.Windows.Forms.Label namaDokterLabel;
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label teleponLabel;
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.dokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dokterTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.DokterTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager();
            this.dokterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeDokterTextBox = new System.Windows.Forms.TextBox();
            this.namaDokterTextBox = new System.Windows.Forms.TextBox();
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.teleponTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            kodeDokterLabel = new System.Windows.Forms.Label();
            namaDokterLabel = new System.Windows.Forms.Label();
            alamatLabel = new System.Windows.Forms.Label();
            teleponLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kodeDokterLabel
            // 
            kodeDokterLabel.AutoSize = true;
            kodeDokterLabel.Location = new System.Drawing.Point(31, 34);
            kodeDokterLabel.Name = "kodeDokterLabel";
            kodeDokterLabel.Size = new System.Drawing.Size(70, 13);
            kodeDokterLabel.TabIndex = 1;
            kodeDokterLabel.Text = "Kode Dokter:";
            // 
            // namaDokterLabel
            // 
            namaDokterLabel.AutoSize = true;
            namaDokterLabel.Location = new System.Drawing.Point(31, 60);
            namaDokterLabel.Name = "namaDokterLabel";
            namaDokterLabel.Size = new System.Drawing.Size(73, 13);
            namaDokterLabel.TabIndex = 3;
            namaDokterLabel.Text = "Nama Dokter:";
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(31, 86);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(42, 13);
            alamatLabel.TabIndex = 5;
            alamatLabel.Text = "Alamat:";
            // 
            // teleponLabel
            // 
            teleponLabel.AutoSize = true;
            teleponLabel.Location = new System.Drawing.Point(31, 112);
            teleponLabel.Name = "teleponLabel";
            teleponLabel.Size = new System.Drawing.Size(49, 13);
            teleponLabel.TabIndex = 7;
            teleponLabel.Text = "Telepon:";
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dokterBindingSource
            // 
            this.dokterBindingSource.DataMember = "Dokter";
            this.dokterBindingSource.DataSource = this.master_Data;
            // 
            // dokterTableAdapter
            // 
            this.dokterTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DokterTableAdapter = this.dokterTableAdapter;
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
            this.tableAdapterManager.KotaTableAdapter = null;
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
            // dokterDataGridView
            // 
            this.dokterDataGridView.AutoGenerateColumns = false;
            this.dokterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dokterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dokterDataGridView.DataSource = this.dokterBindingSource;
            this.dokterDataGridView.Location = new System.Drawing.Point(431, 12);
            this.dokterDataGridView.Name = "dokterDataGridView";
            this.dokterDataGridView.RowHeadersVisible = false;
            this.dokterDataGridView.Size = new System.Drawing.Size(386, 171);
            this.dokterDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KodeDokter";
            this.dataGridViewTextBoxColumn1.HeaderText = "KodeDokter";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaDokter";
            this.dataGridViewTextBoxColumn2.HeaderText = "NamaDokter";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telepon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telepon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // kodeDokterTextBox
            // 
            this.kodeDokterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokterBindingSource, "KodeDokter", true));
            this.kodeDokterTextBox.Location = new System.Drawing.Point(110, 31);
            this.kodeDokterTextBox.Name = "kodeDokterTextBox";
            this.kodeDokterTextBox.ReadOnly = true;
            this.kodeDokterTextBox.Size = new System.Drawing.Size(163, 20);
            this.kodeDokterTextBox.TabIndex = 1;
            // 
            // namaDokterTextBox
            // 
            this.namaDokterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokterBindingSource, "NamaDokter", true));
            this.namaDokterTextBox.Location = new System.Drawing.Point(110, 57);
            this.namaDokterTextBox.Name = "namaDokterTextBox";
            this.namaDokterTextBox.Size = new System.Drawing.Size(261, 20);
            this.namaDokterTextBox.TabIndex = 2;
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokterBindingSource, "Alamat", true));
            this.alamatTextBox.Location = new System.Drawing.Point(110, 83);
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(261, 20);
            this.alamatTextBox.TabIndex = 3;
            // 
            // teleponTextBox
            // 
            this.teleponTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dokterBindingSource, "Telepon", true));
            this.teleponTextBox.Location = new System.Drawing.Point(110, 109);
            this.teleponTextBox.Name = "teleponTextBox";
            this.teleponTextBox.Size = new System.Drawing.Size(199, 20);
            this.teleponTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 174);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Dokter";
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(341, 145);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 41;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(259, 145);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 42;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(178, 145);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 40;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Location = new System.Drawing.Point(99, 146);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(75, 23);
            this.btn_ubah.TabIndex = 38;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Enabled = false;
            this.btn_simpan.Location = new System.Drawing.Point(19, 145);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 39;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // Modul_Data_Dokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(828, 194);
            this.ControlBox = false;
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(kodeDokterLabel);
            this.Controls.Add(this.kodeDokterTextBox);
            this.Controls.Add(namaDokterLabel);
            this.Controls.Add(this.namaDokterTextBox);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(this.alamatTextBox);
            this.Controls.Add(teleponLabel);
            this.Controls.Add(this.teleponTextBox);
            this.Controls.Add(this.dokterDataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Data_Dokter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Dokter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Data_Dokter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource dokterBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.DokterTableAdapter dokterTableAdapter;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dokterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox kodeDokterTextBox;
        private System.Windows.Forms.TextBox namaDokterTextBox;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.TextBox teleponTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_simpan;

    }
}