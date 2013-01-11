namespace Accounting_Solution_Software
{
    partial class Modul_Barang_DataSatuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modul_Barang_DataSatuan));
            this.btn_keluar = new System.Windows.Forms.Button();
            this.stock_Data = new Accounting_Solution_Software.Data_set.Stock_Data();
            this.satuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satuanTableAdapter = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.SatuanTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager();
            this.satuanBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.satuanBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.satuanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satuanBindingNavigator)).BeginInit();
            this.satuanBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satuanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(206, 282);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 41;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // stock_Data
            // 
            this.stock_Data.DataSetName = "Stock_Data";
            this.stock_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satuanBindingSource
            // 
            this.satuanBindingSource.DataMember = "Satuan";
            this.satuanBindingSource.DataSource = this.stock_Data;
            // 
            // satuanTableAdapter
            // 
            this.satuanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GudangTableAdapter = null;
            this.tableAdapterManager.KelompokProdukTableAdapter = null;
            this.tableAdapterManager.SatuanTableAdapter = this.satuanTableAdapter;
            this.tableAdapterManager.StockGudangTableAdapter = null;
            this.tableAdapterManager.stockMovementTableAdapter = null;
            this.tableAdapterManager.StockOpnameTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.SubStockMovementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // satuanBindingNavigator
            // 
            this.satuanBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.satuanBindingNavigator.BindingSource = this.satuanBindingSource;
            this.satuanBindingNavigator.CountItem = null;
            this.satuanBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.satuanBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.satuanBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.satuanBindingNavigatorSaveItem});
            this.satuanBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.satuanBindingNavigator.MoveFirstItem = null;
            this.satuanBindingNavigator.MoveLastItem = null;
            this.satuanBindingNavigator.MoveNextItem = null;
            this.satuanBindingNavigator.MovePreviousItem = null;
            this.satuanBindingNavigator.Name = "satuanBindingNavigator";
            this.satuanBindingNavigator.PositionItem = null;
            this.satuanBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.satuanBindingNavigator.Size = new System.Drawing.Size(292, 25);
            this.satuanBindingNavigator.TabIndex = 42;
            this.satuanBindingNavigator.Text = "bindingNavigator1";
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
            // satuanBindingNavigatorSaveItem
            // 
            this.satuanBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.satuanBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("satuanBindingNavigatorSaveItem.Image")));
            this.satuanBindingNavigatorSaveItem.Name = "satuanBindingNavigatorSaveItem";
            this.satuanBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.satuanBindingNavigatorSaveItem.Text = "Save Data";
            this.satuanBindingNavigatorSaveItem.Click += new System.EventHandler(this.satuanBindingNavigatorSaveItem_Click_1);
            // 
            // satuanDataGridView
            // 
            this.satuanDataGridView.AutoGenerateColumns = false;
            this.satuanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satuanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.satuanDataGridView.DataSource = this.satuanBindingSource;
            this.satuanDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.satuanDataGridView.Location = new System.Drawing.Point(12, 37);
            this.satuanDataGridView.Name = "satuanDataGridView";
            this.satuanDataGridView.RowHeadersVisible = false;
            this.satuanDataGridView.RowHeadersWidth = 20;
            this.satuanDataGridView.Size = new System.Drawing.Size(269, 239);
            this.satuanDataGridView.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NamaSatuan";
            this.dataGridViewTextBoxColumn1.HeaderText = "Satuan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Modul_Barang_DataSatuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 311);
            this.ControlBox = false;
            this.Controls.Add(this.satuanDataGridView);
            this.Controls.Add(this.satuanBindingNavigator);
            this.Controls.Add(this.btn_keluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Barang_DataSatuan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Satuan Stock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Barang_CariStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satuanBindingNavigator)).EndInit();
            this.satuanBindingNavigator.ResumeLayout(false);
            this.satuanBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satuanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_keluar;
        private Accounting_Solution_Software.Data_set.Stock_Data stock_Data;
        private System.Windows.Forms.BindingSource satuanBindingSource;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.SatuanTableAdapter satuanTableAdapter;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator satuanBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton satuanBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView satuanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}