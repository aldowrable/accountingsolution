namespace Accounting_Solution_Software
{
    partial class Modul_Akuntansi_SaldoAwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modul_Akuntansi_SaldoAwal));
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager();
            this.accountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.accountBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.keluarBtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoAwal02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).BeginInit();
            this.accountBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.master_Data;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
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
            // accountBindingNavigator
            // 
            this.accountBindingNavigator.AddNewItem = null;
            this.accountBindingNavigator.BindingSource = this.accountBindingSource;
            this.accountBindingNavigator.CountItem = null;
            this.accountBindingNavigator.DeleteItem = null;
            this.accountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountBindingNavigatorSaveItem});
            this.accountBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accountBindingNavigator.MoveFirstItem = null;
            this.accountBindingNavigator.MoveLastItem = null;
            this.accountBindingNavigator.MoveNextItem = null;
            this.accountBindingNavigator.MovePreviousItem = null;
            this.accountBindingNavigator.Name = "accountBindingNavigator";
            this.accountBindingNavigator.PositionItem = null;
            this.accountBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.accountBindingNavigator.Size = new System.Drawing.Size(596, 25);
            this.accountBindingNavigator.TabIndex = 0;
            this.accountBindingNavigator.Text = "bindingNavigator1";
            // 
            // accountBindingNavigatorSaveItem
            // 
            this.accountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountBindingNavigatorSaveItem.Image")));
            this.accountBindingNavigatorSaveItem.Name = "accountBindingNavigatorSaveItem";
            this.accountBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.accountBindingNavigatorSaveItem.Text = "Save Data";
            this.accountBindingNavigatorSaveItem.Click += new System.EventHandler(this.accountBindingNavigatorSaveItem_Click_1);
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.AutoGenerateColumns = false;
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.SaldoAwal02});
            this.accountDataGridView.DataSource = this.accountBindingSource;
            this.accountDataGridView.Location = new System.Drawing.Point(12, 41);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.RowHeadersVisible = false;
            this.accountDataGridView.Size = new System.Drawing.Size(571, 432);
            this.accountDataGridView.TabIndex = 1;
            this.accountDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.accountDataGridView_DataError);
            // 
            // keluarBtn
            // 
            this.keluarBtn.Location = new System.Drawing.Point(508, 482);
            this.keluarBtn.Name = "keluarBtn";
            this.keluarBtn.Size = new System.Drawing.Size(75, 23);
            this.keluarBtn.TabIndex = 2;
            this.keluarBtn.Text = "Keluar";
            this.keluarBtn.UseVisualStyleBackColor = true;
            this.keluarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KodePerkiraan";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kd. Perkiraan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NamaPerkiraan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nm. Perkiraan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SaldoAwal01";
            this.dataGridViewTextBoxColumn8.HeaderText = "Debit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // SaldoAwal02
            // 
            this.SaldoAwal02.DataPropertyName = "SaldoAwal02";
            this.SaldoAwal02.HeaderText = "Kredit";
            this.SaldoAwal02.Name = "SaldoAwal02";
            this.SaldoAwal02.Width = 125;
            // 
            // Modul_Akuntansi_SaldoAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 515);
            this.ControlBox = false;
            this.Controls.Add(this.keluarBtn);
            this.Controls.Add(this.accountDataGridView);
            this.Controls.Add(this.accountBindingNavigator);
            this.Name = "Modul_Akuntansi_SaldoAwal";
            this.Text = "Saldo Awal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Akuntansi_SaldoAwal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).EndInit();
            this.accountBindingNavigator.ResumeLayout(false);
            this.accountBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.AccountTableAdapter accountTableAdapter;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator accountBindingNavigator;
        private System.Windows.Forms.ToolStripButton accountBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.Button keluarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoAwal02;

    }
}