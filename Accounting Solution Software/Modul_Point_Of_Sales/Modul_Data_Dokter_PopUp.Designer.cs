namespace Accounting_Solution_Software
{
    partial class Modul_Data_Dokter_PopUp
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
            this.dokterDataGridView = new System.Windows.Forms.DataGridView();
            this.KodeDokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.view_dokter_jasadokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view = new Accounting_Solution_Software.Data_set.view();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager();
            this.view_dokter_jasadokterTableAdapter = new Accounting_Solution_Software.Data_set.viewTableAdapters.view_dokter_jasadokterTableAdapter();
            this.jasaDokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jasaDokterTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.JasaDokterTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.dokterTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.DokterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dokterDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_dokter_jasadokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasaDokterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dokterDataGridView
            // 
            this.dokterDataGridView.AllowUserToAddRows = false;
            this.dokterDataGridView.AllowUserToDeleteRows = false;
            this.dokterDataGridView.AllowUserToResizeRows = false;
            this.dokterDataGridView.AutoGenerateColumns = false;
            this.dokterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dokterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeDokter,
            this.dataGridViewTextBoxColumn6});
            this.dokterDataGridView.DataSource = this.dokterBindingSource;
            this.dokterDataGridView.Location = new System.Drawing.Point(12, 41);
            this.dokterDataGridView.Name = "dokterDataGridView";
            this.dokterDataGridView.ReadOnly = true;
            this.dokterDataGridView.RowHeadersVisible = false;
            this.dokterDataGridView.Size = new System.Drawing.Size(276, 220);
            this.dokterDataGridView.TabIndex = 11;
            this.dokterDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_dokter_jasadokterDataGridView_CellContentDoubleClick);
            this.dokterDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.view_dokter_jasadokterDataGridView_KeyDown);
            // 
            // KodeDokter
            // 
            this.KodeDokter.DataPropertyName = "KodeDokter";
            this.KodeDokter.HeaderText = "Kode Dokter";
            this.KodeDokter.Name = "KodeDokter";
            this.KodeDokter.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NamaDokter";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nama Dokter";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dokterBindingSource
            // 
            this.dokterBindingSource.DataMember = "Dokter";
            this.dokterBindingSource.DataSource = this.master_Data;
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_dokter_jasadokterBindingSource
            // 
            this.view_dokter_jasadokterBindingSource.DataMember = "view_dokter_jasadokter";
            this.view_dokter_jasadokterBindingSource.DataSource = this.view;
            // 
            // view
            // 
            this.view.DataSetName = "view";
            this.view.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_dokter_jasadokterTableAdapter
            // 
            this.view_dokter_jasadokterTableAdapter.ClearBeforeFill = true;
            // 
            // jasaDokterBindingSource
            // 
            this.jasaDokterBindingSource.DataMember = "JasaDokter";
            this.jasaDokterBindingSource.DataSource = this.master_Data;
            // 
            // jasaDokterTableAdapter
            // 
            this.jasaDokterTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.JasaDokterTableAdapter = this.jasaDokterTableAdapter;
            this.tableAdapterManager.JualTableAdapter = null;
            this.tableAdapterManager.JurnalUmumTableAdapter = null;
            this.tableAdapterManager.karyawanTableAdapter = null;
            this.tableAdapterManager.KelompokAccountTableAdapter = null;
            this.tableAdapterManager.KotaTableAdapter = null;
            this.tableAdapterManager.PajakTableAdapter = null;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cari Data : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(212, 267);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // dokterTableAdapter
            // 
            this.dokterTableAdapter.ClearBeforeFill = true;
            // 
            // Modul_Data_Dokter_PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 296);
            this.ControlBox = false;
            this.Controls.Add(this.dokterDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Data_Dokter_PopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Dokter";
            this.Load += new System.EventHandler(this.Modul_Data_Dokter_PopUp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Modul_Data_Dokter_PopUp_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dokterDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_dokter_jasadokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasaDokterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dokterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeDokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource view_dokter_jasadokterBindingSource;
        private Accounting_Solution_Software.Data_set.view view;
        private System.Windows.Forms.TextBox textBox1;
        private Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager tableAdapterManager1;
        private Accounting_Solution_Software.Data_set.viewTableAdapters.view_dokter_jasadokterTableAdapter view_dokter_jasadokterTableAdapter;
        private System.Windows.Forms.BindingSource jasaDokterBindingSource;
        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.JasaDokterTableAdapter jasaDokterTableAdapter;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.BindingSource dokterBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.DokterTableAdapter dokterTableAdapter;
    }
}