namespace Accounting_Solution_Software
{
    partial class Modul_Data_Group
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
            System.Windows.Forms.Label kodeGroupLabel;
            System.Windows.Forms.Label namaGroupLabel;
            System.Windows.Forms.Label prosMarkUpLabel;
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.groupCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupCustomerTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.GroupCustomerTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager();
            this.groupCustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.kodeGroupTextBox = new System.Windows.Forms.TextBox();
            this.namaGroupTextBox = new System.Windows.Forms.TextBox();
            this.prosMarkUpTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            kodeGroupLabel = new System.Windows.Forms.Label();
            namaGroupLabel = new System.Windows.Forms.Label();
            prosMarkUpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomerDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kodeGroupLabel
            // 
            kodeGroupLabel.AutoSize = true;
            kodeGroupLabel.Location = new System.Drawing.Point(16, 26);
            kodeGroupLabel.Name = "kodeGroupLabel";
            kodeGroupLabel.Size = new System.Drawing.Size(67, 13);
            kodeGroupLabel.TabIndex = 1;
            kodeGroupLabel.Text = "Kode Group:";
            // 
            // namaGroupLabel
            // 
            namaGroupLabel.AutoSize = true;
            namaGroupLabel.Location = new System.Drawing.Point(16, 52);
            namaGroupLabel.Name = "namaGroupLabel";
            namaGroupLabel.Size = new System.Drawing.Size(70, 13);
            namaGroupLabel.TabIndex = 3;
            namaGroupLabel.Text = "Nama Group:";
            // 
            // prosMarkUpLabel
            // 
            prosMarkUpLabel.AutoSize = true;
            prosMarkUpLabel.Location = new System.Drawing.Point(16, 78);
            prosMarkUpLabel.Name = "prosMarkUpLabel";
            prosMarkUpLabel.Size = new System.Drawing.Size(75, 13);
            prosMarkUpLabel.TabIndex = 5;
            prosMarkUpLabel.Text = "Pros Mark Up:";
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupCustomerBindingSource
            // 
            this.groupCustomerBindingSource.DataMember = "GroupCustomer";
            this.groupCustomerBindingSource.DataSource = this.master_Data;
            // 
            // groupCustomerTableAdapter
            // 
            this.groupCustomerTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GroupCustomerTableAdapter = this.groupCustomerTableAdapter;
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
            // groupCustomerDataGridView
            // 
            this.groupCustomerDataGridView.AutoGenerateColumns = false;
            this.groupCustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupCustomerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.groupCustomerDataGridView.DataSource = this.groupCustomerBindingSource;
            this.groupCustomerDataGridView.Location = new System.Drawing.Point(319, 12);
            this.groupCustomerDataGridView.Name = "groupCustomerDataGridView";
            this.groupCustomerDataGridView.RowHeadersVisible = false;
            this.groupCustomerDataGridView.Size = new System.Drawing.Size(346, 174);
            this.groupCustomerDataGridView.TabIndex = 1;
            // 
            // kodeGroupTextBox
            // 
            this.kodeGroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupCustomerBindingSource, "KodeGroup", true));
            this.kodeGroupTextBox.Location = new System.Drawing.Point(97, 23);
            this.kodeGroupTextBox.Name = "kodeGroupTextBox";
            this.kodeGroupTextBox.ReadOnly = true;
            this.kodeGroupTextBox.Size = new System.Drawing.Size(100, 20);
            this.kodeGroupTextBox.TabIndex = 1;
            // 
            // namaGroupTextBox
            // 
            this.namaGroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupCustomerBindingSource, "NamaGroup", true));
            this.namaGroupTextBox.Location = new System.Drawing.Point(97, 49);
            this.namaGroupTextBox.Name = "namaGroupTextBox";
            this.namaGroupTextBox.Size = new System.Drawing.Size(169, 20);
            this.namaGroupTextBox.TabIndex = 2;
            // 
            // prosMarkUpTextBox
            // 
            this.prosMarkUpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupCustomerBindingSource, "ProsMarkUp", true));
            this.prosMarkUpTextBox.Location = new System.Drawing.Point(97, 75);
            this.prosMarkUpTextBox.Name = "prosMarkUpTextBox";
            this.prosMarkUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.prosMarkUpTextBox.TabIndex = 3;
            this.prosMarkUpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.markupTextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_keluar);
            this.groupBox1.Controls.Add(kodeGroupLabel);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.kodeGroupTextBox);
            this.groupBox1.Controls.Add(this.btn_simpan);
            this.groupBox1.Controls.Add(this.prosMarkUpTextBox);
            this.groupBox1.Controls.Add(this.btn_ubah);
            this.groupBox1.Controls.Add(this.btn_hapus);
            this.groupBox1.Controls.Add(namaGroupLabel);
            this.groupBox1.Controls.Add(prosMarkUpLabel);
            this.groupBox1.Controls.Add(this.namaGroupTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Group";
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(191, 137);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 56;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(191, 108);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 57;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Enabled = false;
            this.btn_simpan.Location = new System.Drawing.Point(32, 107);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 54;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.Location = new System.Drawing.Point(112, 108);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(75, 23);
            this.btn_ubah.TabIndex = 53;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(112, 137);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(75, 23);
            this.btn_hapus.TabIndex = 55;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KodeGroup";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kd. Group";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaGroup";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nm. Group";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProsMarkUp";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProsMarkUp";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Modul_Data_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(680, 200);
            this.ControlBox = false;
            this.Controls.Add(this.groupCustomerDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modul_Data_Group";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group Customer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Data_Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCustomerDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource groupCustomerBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.GroupCustomerTableAdapter groupCustomerTableAdapter;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView groupCustomerDataGridView;
        private System.Windows.Forms.TextBox kodeGroupTextBox;
        private System.Windows.Forms.TextBox namaGroupTextBox;
        private System.Windows.Forms.TextBox prosMarkUpTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}