namespace Accounting_Solution_Software
{
    partial class Modul_Jasa_Dokter_PopUp
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
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.jasaDokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jasaDokterTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.JasaDokterTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.view = new Accounting_Solution_Software.Data_set.view();
            this.view_dokter_jasadokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_dokter_jasadokterTableAdapter = new Accounting_Solution_Software.Data_set.viewTableAdapters.view_dokter_jasadokterTableAdapter();
            this.tableAdapterManager1 = new Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager();
            this.view_dokter_jasadokterDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeDokter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasaDokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_dokter_jasadokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_dokter_jasadokterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(586, 264);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.button1_Click);
            this.okBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.okBtn_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cari Data : ";
            // 
            // view
            // 
            this.view.DataSetName = "view";
            this.view.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_dokter_jasadokterBindingSource
            // 
            this.view_dokter_jasadokterBindingSource.DataMember = "view_dokter_jasadokter";
            this.view_dokter_jasadokterBindingSource.DataSource = this.view;
            // 
            // view_dokter_jasadokterTableAdapter
            // 
            this.view_dokter_jasadokterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_dokter_jasadokterDataGridView
            // 
            this.view_dokter_jasadokterDataGridView.AllowUserToAddRows = false;
            this.view_dokter_jasadokterDataGridView.AllowUserToDeleteRows = false;
            this.view_dokter_jasadokterDataGridView.AllowUserToResizeRows = false;
            this.view_dokter_jasadokterDataGridView.AutoGenerateColumns = false;
            this.view_dokter_jasadokterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_dokter_jasadokterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.KodeDokter,
            this.dataGridViewTextBoxColumn6});
            this.view_dokter_jasadokterDataGridView.DataSource = this.view_dokter_jasadokterBindingSource;
            this.view_dokter_jasadokterDataGridView.Location = new System.Drawing.Point(12, 38);
            this.view_dokter_jasadokterDataGridView.Name = "view_dokter_jasadokterDataGridView";
            this.view_dokter_jasadokterDataGridView.ReadOnly = true;
            this.view_dokter_jasadokterDataGridView.RowHeadersVisible = false;
            this.view_dokter_jasadokterDataGridView.Size = new System.Drawing.Size(649, 220);
            this.view_dokter_jasadokterDataGridView.TabIndex = 7;
            this.view_dokter_jasadokterDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_dokter_jasadokterDataGridView_CellContentDoubleClick);
            this.view_dokter_jasadokterDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.view_dokter_jasadokterDataGridView_DataError);
            this.view_dokter_jasadokterDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.view_dokter_jasadokterDataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KodeJasa";
            this.dataGridViewTextBoxColumn1.HeaderText = "KodeJasa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaJasa";
            this.dataGridViewTextBoxColumn2.HeaderText = "NamaJasa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Harga";
            this.dataGridViewTextBoxColumn3.HeaderText = "Harga";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Komisi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Komisi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // KodeDokter
            // 
            this.KodeDokter.DataPropertyName = "KodeDokter";
            this.KodeDokter.HeaderText = "Kode Dokter";
            this.KodeDokter.Name = "KodeDokter";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NamaDokter";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nama Dokter";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Modul_Jasa_Dokter_PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 291);
            this.ControlBox = false;
            this.Controls.Add(this.view_dokter_jasadokterDataGridView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Jasa_Dokter_PopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Jasa Dokter";
            this.Load += new System.EventHandler(this.Modul_Jasa_Dokter_PopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasaDokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_dokter_jasadokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_dokter_jasadokterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource jasaDokterBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.JasaDokterTableAdapter jasaDokterTableAdapter;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Accounting_Solution_Software.Data_set.view view;
        private System.Windows.Forms.BindingSource view_dokter_jasadokterBindingSource;
        private Accounting_Solution_Software.Data_set.viewTableAdapters.view_dokter_jasadokterTableAdapter view_dokter_jasadokterTableAdapter;
        private Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView view_dokter_jasadokterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeDokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}