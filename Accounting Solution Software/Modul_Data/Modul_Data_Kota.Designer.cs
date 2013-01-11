namespace Accounting_Solution_Software
{
    partial class Modul_Data_Kota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modul_Data_Kota));
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.kotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kotaTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.KotaTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager();
            this.kotaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kotaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.kotaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingNavigator)).BeginInit();
            this.kotaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kotaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kotaBindingSource
            // 
            this.kotaBindingSource.DataMember = "Kota";
            this.kotaBindingSource.DataSource = this.master_Data;
            // 
            // kotaTableAdapter
            // 
            this.kotaTableAdapter.ClearBeforeFill = true;
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
            // kotaBindingNavigator
            // 
            this.kotaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kotaBindingNavigator.BindingSource = this.kotaBindingSource;
            this.kotaBindingNavigator.CountItem = null;
            this.kotaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kotaBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.kotaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kotaBindingNavigatorSaveItem});
            this.kotaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kotaBindingNavigator.MoveFirstItem = null;
            this.kotaBindingNavigator.MoveLastItem = null;
            this.kotaBindingNavigator.MoveNextItem = null;
            this.kotaBindingNavigator.MovePreviousItem = null;
            this.kotaBindingNavigator.Name = "kotaBindingNavigator";
            this.kotaBindingNavigator.PositionItem = null;
            this.kotaBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.kotaBindingNavigator.Size = new System.Drawing.Size(297, 25);
            this.kotaBindingNavigator.TabIndex = 0;
            this.kotaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // kotaBindingNavigatorSaveItem
            // 
            this.kotaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kotaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kotaBindingNavigatorSaveItem.Image")));
            this.kotaBindingNavigatorSaveItem.Name = "kotaBindingNavigatorSaveItem";
            this.kotaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kotaBindingNavigatorSaveItem.Text = "Save Data";
            this.kotaBindingNavigatorSaveItem.Click += new System.EventHandler(this.kotaBindingNavigatorSaveItem_Click);
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(206, 280);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 57;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // kotaDataGridView
            // 
            this.kotaDataGridView.AutoGenerateColumns = false;
            this.kotaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.kotaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kotaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.kotaDataGridView.DataSource = this.kotaBindingSource;
            this.kotaDataGridView.Location = new System.Drawing.Point(12, 35);
            this.kotaDataGridView.Name = "kotaDataGridView";
            this.kotaDataGridView.RowHeadersVisible = false;
            this.kotaDataGridView.RowHeadersWidth = 20;
            this.kotaDataGridView.Size = new System.Drawing.Size(269, 239);
            this.kotaDataGridView.TabIndex = 58;
            this.kotaDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.kotaDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Kota";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama Kota";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Modul_Data_Kota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(297, 314);
            this.ControlBox = false;
            this.Controls.Add(this.kotaDataGridView);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.kotaBindingNavigator);
            this.Name = "Modul_Data_Kota";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Kota";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Data_Kota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kotaBindingNavigator)).EndInit();
            this.kotaBindingNavigator.ResumeLayout(false);
            this.kotaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kotaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource kotaBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.KotaTableAdapter kotaTableAdapter;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kotaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton kotaBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.DataGridView kotaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}