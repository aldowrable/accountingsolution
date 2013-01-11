namespace Accounting_Solution_Software
{
    partial class Modul_Barang_StockOpname
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label no_buktiLabel;
            this.stockOpnameDataGridView = new System.Windows.Forms.DataGridView();
            this.stockOpnameTableAdapter = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.StockOpnameTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BaruBtn = new System.Windows.Forms.Button();
            this.view_stockOpnameDataGridView = new System.Windows.Forms.DataGridView();
            this.view_stock_opnameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view = new Accounting_Solution_Software.Data_set.view();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.printChkBox = new System.Windows.Forms.CheckBox();
            this.batalBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tanggalDtp = new System.Windows.Forms.DateTimePicker();
            this.noBuktiTextBox = new System.Windows.Forms.TextBox();
            this.view_stock_opnameTableAdapter = new Accounting_Solution_Software.Data_set.viewTableAdapters.view_stock_opnameTableAdapter();
            this.tableAdapterManager1 = new Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager();
            this.stockOpnameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noBuktiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyAwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyOpnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaproduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            no_buktiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockOpnameDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_stockOpnameDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_opnameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockOpnameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(272, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 19;
            label1.Text = "Tanggal :";
            // 
            // no_buktiLabel
            // 
            no_buktiLabel.AutoSize = true;
            no_buktiLabel.Location = new System.Drawing.Point(15, 26);
            no_buktiLabel.Name = "no_buktiLabel";
            no_buktiLabel.Size = new System.Drawing.Size(54, 13);
            no_buktiLabel.TabIndex = 17;
            no_buktiLabel.Text = "No Bukti :";
            // 
            // stockOpnameDataGridView
            // 
            this.stockOpnameDataGridView.AllowUserToDeleteRows = false;
            this.stockOpnameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOpnameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.dataGridViewTextBoxColumn3,
            this.namaproduk,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.satuan});
            this.stockOpnameDataGridView.Location = new System.Drawing.Point(13, 77);
            this.stockOpnameDataGridView.Name = "stockOpnameDataGridView";
            this.stockOpnameDataGridView.RowHeadersVisible = false;
            this.stockOpnameDataGridView.Size = new System.Drawing.Size(611, 304);
            this.stockOpnameDataGridView.TabIndex = 18;
            this.stockOpnameDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockOpnameDataGridView_CellValueChanged);
            // 
            // stockOpnameTableAdapter
            // 
            this.stockOpnameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GudangTableAdapter = null;
            this.tableAdapterManager.KelompokProdukTableAdapter = null;
            this.tableAdapterManager.SatuanTableAdapter = null;
            this.tableAdapterManager.StockGudangTableAdapter = null;
            this.tableAdapterManager.stockMovementTableAdapter = null;
            this.tableAdapterManager.StockOpnameTableAdapter = this.stockOpnameTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.SubStockMovementTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 451);
            this.tabControl1.TabIndex = 21;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EditBtn);
            this.tabPage1.Controls.Add(this.BaruBtn);
            this.tabPage1.Controls.Add(this.view_stockOpnameDataGridView);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Daftar Stock Opname";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(123, 394);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(108, 23);
            this.EditBtn.TabIndex = 50;
            this.EditBtn.Text = "Ubah Data";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BaruBtn
            // 
            this.BaruBtn.Location = new System.Drawing.Point(9, 394);
            this.BaruBtn.Name = "BaruBtn";
            this.BaruBtn.Size = new System.Drawing.Size(108, 23);
            this.BaruBtn.TabIndex = 49;
            this.BaruBtn.Text = "Tambah Data";
            this.BaruBtn.UseVisualStyleBackColor = true;
            this.BaruBtn.Click += new System.EventHandler(this.BaruBtn_Click);
            // 
            // view_stockOpnameDataGridView
            // 
            this.view_stockOpnameDataGridView.AllowUserToAddRows = false;
            this.view_stockOpnameDataGridView.AllowUserToDeleteRows = false;
            this.view_stockOpnameDataGridView.AutoGenerateColumns = false;
            this.view_stockOpnameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_stockOpnameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noBuktiDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.NamaPIC,
            this.totalProdukDataGridViewTextBoxColumn,
            this.qtyAwalDataGridViewTextBoxColumn,
            this.qtyOpnameDataGridViewTextBoxColumn});
            this.view_stockOpnameDataGridView.DataSource = this.view_stock_opnameBindingSource;
            this.view_stockOpnameDataGridView.Location = new System.Drawing.Point(9, 91);
            this.view_stockOpnameDataGridView.Name = "view_stockOpnameDataGridView";
            this.view_stockOpnameDataGridView.RowHeadersVisible = false;
            this.view_stockOpnameDataGridView.Size = new System.Drawing.Size(660, 296);
            this.view_stockOpnameDataGridView.TabIndex = 48;
            this.view_stockOpnameDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_stockOpnameDataGridView_CellContentDoubleClick);
            // 
            // view_stock_opnameBindingSource
            // 
            this.view_stock_opnameBindingSource.DataMember = "view_stock_opname";
            this.view_stock_opnameBindingSource.DataSource = this.view;
            // 
            // view
            // 
            this.view.DataSetName = "view";
            this.view.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.cariTxt);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 79);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cariTxt
            // 
            this.cariTxt.Location = new System.Drawing.Point(103, 44);
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Size = new System.Drawing.Size(311, 20);
            this.cariTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cari ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(566, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 24);
            this.button4.TabIndex = 21;
            this.button4.Text = "Keluar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ResetBtn);
            this.tabPage2.Controls.Add(this.printChkBox);
            this.tabPage2.Controls.Add(this.batalBtn);
            this.tabPage2.Controls.Add(this.simpanBtn);
            this.tabPage2.Controls.Add(this.plusBtn);
            this.tabPage2.Controls.Add(this.removeBtn);
            this.tabPage2.Controls.Add(this.stockOpnameDataGridView);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail Stock Opname";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(13, 394);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(72, 23);
            this.ResetBtn.TabIndex = 52;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // printChkBox
            // 
            this.printChkBox.AutoSize = true;
            this.printChkBox.Checked = true;
            this.printChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printChkBox.Location = new System.Drawing.Point(348, 398);
            this.printChkBox.Name = "printChkBox";
            this.printChkBox.Size = new System.Drawing.Size(148, 17);
            this.printChkBox.TabIndex = 51;
            this.printChkBox.Text = "Print Bukti Stock Opname";
            this.printChkBox.UseVisualStyleBackColor = true;
            // 
            // batalBtn
            // 
            this.batalBtn.Location = new System.Drawing.Point(594, 394);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(75, 23);
            this.batalBtn.TabIndex = 48;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = true;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.Location = new System.Drawing.Point(513, 394);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(75, 23);
            this.simpanBtn.TabIndex = 47;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(630, 98);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(34, 23);
            this.plusBtn.TabIndex = 45;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(630, 127);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(34, 23);
            this.removeBtn.TabIndex = 44;
            this.removeBtn.Text = "x";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tanggalDtp);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(no_buktiLabel);
            this.groupBox2.Controls.Add(this.noBuktiTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 61);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informasi";
            // 
            // tanggalDtp
            // 
            this.tanggalDtp.Location = new System.Drawing.Point(330, 22);
            this.tanggalDtp.Name = "tanggalDtp";
            this.tanggalDtp.Size = new System.Drawing.Size(191, 20);
            this.tanggalDtp.TabIndex = 20;
            // 
            // noBuktiTextBox
            // 
            this.noBuktiTextBox.Location = new System.Drawing.Point(75, 23);
            this.noBuktiTextBox.Name = "noBuktiTextBox";
            this.noBuktiTextBox.ReadOnly = true;
            this.noBuktiTextBox.Size = new System.Drawing.Size(170, 20);
            this.noBuktiTextBox.TabIndex = 18;
            this.noBuktiTextBox.Text = "Auto";
            // 
            // view_stock_opnameTableAdapter
            // 
            this.view_stock_opnameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockOpnameBindingSource
            // 
            this.stockOpnameBindingSource.DataMember = "StockOpname";
            // 
            // noBuktiDataGridViewTextBoxColumn
            // 
            this.noBuktiDataGridViewTextBoxColumn.DataPropertyName = "NoBukti";
            this.noBuktiDataGridViewTextBoxColumn.HeaderText = "No. Bukti";
            this.noBuktiDataGridViewTextBoxColumn.Name = "noBuktiDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // NamaPIC
            // 
            this.NamaPIC.DataPropertyName = "NamaPIC";
            this.NamaPIC.HeaderText = "Nama PIC";
            this.NamaPIC.Name = "NamaPIC";
            // 
            // totalProdukDataGridViewTextBoxColumn
            // 
            this.totalProdukDataGridViewTextBoxColumn.DataPropertyName = "TotalProduk";
            this.totalProdukDataGridViewTextBoxColumn.HeaderText = "Total Produk";
            this.totalProdukDataGridViewTextBoxColumn.Name = "totalProdukDataGridViewTextBoxColumn";
            this.totalProdukDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyAwalDataGridViewTextBoxColumn
            // 
            this.qtyAwalDataGridViewTextBoxColumn.DataPropertyName = "QtyAwal";
            this.qtyAwalDataGridViewTextBoxColumn.HeaderText = "Qty Awal";
            this.qtyAwalDataGridViewTextBoxColumn.Name = "qtyAwalDataGridViewTextBoxColumn";
            this.qtyAwalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyOpnameDataGridViewTextBoxColumn
            // 
            this.qtyOpnameDataGridViewTextBoxColumn.DataPropertyName = "QtyOpname";
            this.qtyOpnameDataGridViewTextBoxColumn.HeaderText = "Qty Opname";
            this.qtyOpnameDataGridViewTextBoxColumn.Name = "qtyOpnameDataGridViewTextBoxColumn";
            this.qtyOpnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KodeStock";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kd. Produk";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // namaproduk
            // 
            this.namaproduk.HeaderText = "Nm.  Produk";
            this.namaproduk.Name = "namaproduk";
            this.namaproduk.ReadOnly = true;
            this.namaproduk.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StockAwal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StockOpname";
            this.dataGridViewTextBoxColumn5.HeaderText = "Qty Baru";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // satuan
            // 
            this.satuan.HeaderText = "Satuan";
            this.satuan.Name = "satuan";
            this.satuan.ReadOnly = true;
            // 
            // Modul_Barang_StockOpname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(685, 451);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Barang_StockOpname";
            this.Text = "Stock Opname";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Barang_StockOpname_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockOpnameDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view_stockOpnameDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_opnameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockOpnameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.StockOpnameTableAdapter stockOpnameTableAdapter;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView stockOpnameDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BaruBtn;
        private System.Windows.Forms.DataGridView view_stockOpnameDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker tanggalDtp;
        private System.Windows.Forms.TextBox noBuktiTextBox;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.CheckBox printChkBox;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button ResetBtn;
        private Accounting_Solution_Software.Data_set.view view;
        private System.Windows.Forms.BindingSource view_stock_opnameBindingSource;
        private Accounting_Solution_Software.Data_set.viewTableAdapters.view_stock_opnameTableAdapter view_stock_opnameTableAdapter;
        private Accounting_Solution_Software.Data_set.viewTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.BindingSource stockOpnameBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn noBuktiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyAwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyOpnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaproduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
    }
}