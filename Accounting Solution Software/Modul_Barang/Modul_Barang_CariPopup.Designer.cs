namespace Accounting_Solution_Software
{
    partial class Modul_Barang_CariPopup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_Data = new Accounting_Solution_Software.Data_set.Stock_Data();
            this.stockTableAdapter = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search_1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaJual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaJual1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaJual2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaJual3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaJual4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(765, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "ESC - Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToDeleteRows = false;
            this.stockDataGridView.AllowUserToResizeRows = false;
            this.stockDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.HargaJual,
            this.HargaJual1,
            this.Qty1,
            this.HargaJual2,
            this.Qty2,
            this.HargaJual3,
            this.Qty3,
            this.HargaJual4,
            this.Qty4,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn18});
            this.stockDataGridView.DataSource = this.stockBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockDataGridView.Location = new System.Drawing.Point(8, 43);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.ReadOnly = true;
            this.stockDataGridView.RowHeadersVisible = false;
            this.stockDataGridView.ShowEditingIcon = false;
            this.stockDataGridView.Size = new System.Drawing.Size(832, 316);
            this.stockDataGridView.TabIndex = 1;
            this.stockDataGridView.TabStop = false;
            this.stockDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDataGridView_CellContentDoubleClick);
            this.stockDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.stockDataGridView_DataError);
            this.stockDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stockDataGridView_KeyDown);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.stock_Data;
            // 
            // stock_Data
            // 
            this.stock_Data.DataSetName = "Stock_Data";
            this.stock_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GudangTableAdapter = null;
            this.tableAdapterManager.KelompokProdukTableAdapter = null;
            this.tableAdapterManager.SatuanTableAdapter = null;
            this.tableAdapterManager.StockGudangTableAdapter = null;
            this.tableAdapterManager.stockMovementTableAdapter = null;
            this.tableAdapterManager.StockOpnameTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.SubStockMovementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cari Stock :";
            // 
            // txt_search_1
            // 
            this.txt_search_1.Location = new System.Drawing.Point(76, 12);
            this.txt_search_1.Name = "txt_search_1";
            this.txt_search_1.Size = new System.Drawing.Size(761, 20);
            this.txt_search_1.TabIndex = 0;
            this.txt_search_1.TextChanged += new System.EventHandler(this.txt_search_1_TextChanged);
            this.txt_search_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_1_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KodeStock";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kd. Produk";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaStock";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nm. Produk";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 230;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Satuan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Satuan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "HargaBeli";
            this.dataGridViewTextBoxColumn8.HeaderText = "Harga Beli";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // HargaJual
            // 
            this.HargaJual.DataPropertyName = "HargaJual";
            this.HargaJual.HeaderText = "Harga Jual";
            this.HargaJual.Name = "HargaJual";
            this.HargaJual.ReadOnly = true;
            // 
            // HargaJual1
            // 
            this.HargaJual1.DataPropertyName = "HargaJual1";
            this.HargaJual1.HeaderText = "Harga Jual 1";
            this.HargaJual1.Name = "HargaJual1";
            this.HargaJual1.ReadOnly = true;
            this.HargaJual1.Width = 110;
            // 
            // Qty1
            // 
            this.Qty1.DataPropertyName = "Qty1";
            this.Qty1.HeaderText = "Qty 1";
            this.Qty1.Name = "Qty1";
            this.Qty1.ReadOnly = true;
            this.Qty1.Width = 75;
            // 
            // HargaJual2
            // 
            this.HargaJual2.DataPropertyName = "HargaJual2";
            this.HargaJual2.HeaderText = "Harga Jual 2";
            this.HargaJual2.Name = "HargaJual2";
            this.HargaJual2.ReadOnly = true;
            this.HargaJual2.Width = 110;
            // 
            // Qty2
            // 
            this.Qty2.DataPropertyName = "Qty2";
            this.Qty2.HeaderText = "Qty 2";
            this.Qty2.Name = "Qty2";
            this.Qty2.ReadOnly = true;
            this.Qty2.Width = 75;
            // 
            // HargaJual3
            // 
            this.HargaJual3.DataPropertyName = "HargaJual3";
            this.HargaJual3.HeaderText = "Harga Jual 3";
            this.HargaJual3.Name = "HargaJual3";
            this.HargaJual3.ReadOnly = true;
            this.HargaJual3.Width = 110;
            // 
            // Qty3
            // 
            this.Qty3.DataPropertyName = "Qty3";
            this.Qty3.HeaderText = "Qty 3";
            this.Qty3.Name = "Qty3";
            this.Qty3.ReadOnly = true;
            this.Qty3.Width = 75;
            // 
            // HargaJual4
            // 
            this.HargaJual4.DataPropertyName = "HargaJual4";
            this.HargaJual4.HeaderText = "Harga Jual 4";
            this.HargaJual4.Name = "HargaJual4";
            this.HargaJual4.ReadOnly = true;
            this.HargaJual4.Width = 110;
            // 
            // Qty4
            // 
            this.Qty4.DataPropertyName = "Qty4";
            this.Qty4.HeaderText = "Qty 4";
            this.Qty4.Name = "Qty4";
            this.Qty4.ReadOnly = true;
            this.Qty4.Width = 75;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "KodeKelompok";
            this.dataGridViewTextBoxColumn13.HeaderText = "Kode Kelompok";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Ukuran";
            this.dataGridViewTextBoxColumn14.HeaderText = "Ukuran";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Isi";
            this.dataGridViewTextBoxColumn16.HeaderText = "Isi";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "KodeBarcode";
            this.dataGridViewTextBoxColumn18.HeaderText = "Kode Barcode";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // Modul_Barang_CariPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(845, 395);
            this.ControlBox = false;
            this.Controls.Add(this.txt_search_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockDataGridView);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Barang_CariPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Stock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Barang_CariPopup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Modul_Barang_CariPopup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private Accounting_Solution_Software.Data_set.Stock_Data stock_Data;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.StockTableAdapter stockTableAdapter;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaJual1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaJual2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaJual3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaJual4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}