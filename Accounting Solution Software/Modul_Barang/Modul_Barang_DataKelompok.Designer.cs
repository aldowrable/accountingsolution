namespace Accounting_Solution_Software
{
    partial class Modul_Barang_DataKelompok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modul_Barang_DataKelompok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kelompokProdukBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.kelompokProdukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_Data = new Accounting_Solution_Software.Data_set.Stock_Data();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kelompokProdukBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kelompokProdukDataGridView = new System.Windows.Forms.DataGridView();
            this.dokterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.button1 = new System.Windows.Forms.Button();
            this.kelompokProdukTableAdapter = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.KelompokProdukTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager();
            this.dokterTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.DokterTableAdapter();
            this.kodeKelompokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKelompokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisLaporanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kelompokProdukBindingNavigator)).BeginInit();
            this.kelompokProdukBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelompokProdukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelompokProdukDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // kelompokProdukBindingNavigator
            // 
            this.kelompokProdukBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kelompokProdukBindingNavigator.BindingSource = this.kelompokProdukBindingSource;
            this.kelompokProdukBindingNavigator.CountItem = null;
            this.kelompokProdukBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kelompokProdukBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.kelompokProdukBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kelompokProdukBindingNavigatorSaveItem});
            this.kelompokProdukBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kelompokProdukBindingNavigator.MoveFirstItem = null;
            this.kelompokProdukBindingNavigator.MoveLastItem = null;
            this.kelompokProdukBindingNavigator.MoveNextItem = null;
            this.kelompokProdukBindingNavigator.MovePreviousItem = null;
            this.kelompokProdukBindingNavigator.Name = "kelompokProdukBindingNavigator";
            this.kelompokProdukBindingNavigator.PositionItem = null;
            this.kelompokProdukBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.kelompokProdukBindingNavigator.Size = new System.Drawing.Size(473, 25);
            this.kelompokProdukBindingNavigator.TabIndex = 0;
            this.kelompokProdukBindingNavigator.Text = "bindingNavigator1";
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
            // kelompokProdukBindingSource
            // 
            this.kelompokProdukBindingSource.DataMember = "KelompokProduk";
            this.kelompokProdukBindingSource.DataSource = this.stock_Data;
            // 
            // stock_Data
            // 
            this.stock_Data.DataSetName = "Stock_Data";
            this.stock_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // kelompokProdukBindingNavigatorSaveItem
            // 
            this.kelompokProdukBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kelompokProdukBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kelompokProdukBindingNavigatorSaveItem.Image")));
            this.kelompokProdukBindingNavigatorSaveItem.Name = "kelompokProdukBindingNavigatorSaveItem";
            this.kelompokProdukBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kelompokProdukBindingNavigatorSaveItem.Text = "Save Data";
            this.kelompokProdukBindingNavigatorSaveItem.Click += new System.EventHandler(this.kelompokProdukBindingNavigatorSaveItem_Click_1);
            // 
            // kelompokProdukDataGridView
            // 
            this.kelompokProdukDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kelompokProdukDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.kelompokProdukDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kelompokProdukDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeKelompokDataGridViewTextBoxColumn,
            this.namaKelompokDataGridViewTextBoxColumn,
            this.jenisLaporanDataGridViewTextBoxColumn});
            this.kelompokProdukDataGridView.DataSource = this.kelompokProdukBindingSource;
            this.kelompokProdukDataGridView.Location = new System.Drawing.Point(13, 39);
            this.kelompokProdukDataGridView.Name = "kelompokProdukDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kelompokProdukDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.kelompokProdukDataGridView.RowHeadersVisible = false;
            this.kelompokProdukDataGridView.Size = new System.Drawing.Size(445, 317);
            this.kelompokProdukDataGridView.TabIndex = 1;
            this.kelompokProdukDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.kelompokProdukDataGridView_DataError);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Keluar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kelompokProdukTableAdapter
            // 
            this.kelompokProdukTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GudangTableAdapter = null;
            this.tableAdapterManager.KelompokProdukTableAdapter = this.kelompokProdukTableAdapter;
            this.tableAdapterManager.SatuanTableAdapter = null;
            this.tableAdapterManager.StockGudangTableAdapter = null;
            this.tableAdapterManager.stockMovementTableAdapter = null;
            this.tableAdapterManager.StockOpnameTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.SubStockMovementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dokterTableAdapter
            // 
            this.dokterTableAdapter.ClearBeforeFill = true;
            // 
            // kodeKelompokDataGridViewTextBoxColumn
            // 
            this.kodeKelompokDataGridViewTextBoxColumn.DataPropertyName = "KodeKelompok";
            this.kodeKelompokDataGridViewTextBoxColumn.HeaderText = "Kd. Kelompok";
            this.kodeKelompokDataGridViewTextBoxColumn.Name = "kodeKelompokDataGridViewTextBoxColumn";
            // 
            // namaKelompokDataGridViewTextBoxColumn
            // 
            this.namaKelompokDataGridViewTextBoxColumn.DataPropertyName = "NamaKelompok";
            this.namaKelompokDataGridViewTextBoxColumn.HeaderText = "Nm. Kelompok";
            this.namaKelompokDataGridViewTextBoxColumn.Name = "namaKelompokDataGridViewTextBoxColumn";
            this.namaKelompokDataGridViewTextBoxColumn.Width = 150;
            // 
            // jenisLaporanDataGridViewTextBoxColumn
            // 
            this.jenisLaporanDataGridViewTextBoxColumn.DataPropertyName = "JenisLaporan";
            this.jenisLaporanDataGridViewTextBoxColumn.HeaderText = "Jenis Laporan";
            this.jenisLaporanDataGridViewTextBoxColumn.Name = "jenisLaporanDataGridViewTextBoxColumn";
            this.jenisLaporanDataGridViewTextBoxColumn.Visible = false;
            // 
            // Modul_Barang_DataKelompok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 398);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kelompokProdukDataGridView);
            this.Controls.Add(this.kelompokProdukBindingNavigator);
            this.Name = "Modul_Barang_DataKelompok";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelompok Barang";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Barang_DataKelompok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kelompokProdukBindingNavigator)).EndInit();
            this.kelompokProdukBindingNavigator.ResumeLayout(false);
            this.kelompokProdukBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kelompokProdukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelompokProdukDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Stock_Data stock_Data;
        private System.Windows.Forms.BindingSource kelompokProdukBindingSource;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.KelompokProdukTableAdapter kelompokProdukTableAdapter;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kelompokProdukBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton kelompokProdukBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kelompokProdukDataGridView;
        private System.Windows.Forms.Button button1;
        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource dokterBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.DokterTableAdapter dokterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeKelompokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKelompokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisLaporanDataGridViewTextBoxColumn;

    }
}