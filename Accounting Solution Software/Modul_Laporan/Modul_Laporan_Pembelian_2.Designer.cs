namespace Accounting_Solution_Software
{
    partial class Modul_Laporan_Pembelian
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.noPembelianTxt = new System.Windows.Forms.TextBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.noPoTbTxt = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.kodeStockTxt = new System.Windows.Forms.TextBox();
            this.KodeSupplierCmb = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.supplierTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.SupplierTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.laporanTglTransaksiRBtn = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.laporanKodeStockRBtn = new System.Windows.Forms.RadioButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.splitContainer1.Panel1MinSize = 110;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crv);
            this.splitContainer1.Size = new System.Drawing.Size(952, 705);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb5);
            this.groupBox1.Controls.Add(this.noPembelianTxt);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.cb4);
            this.groupBox1.Controls.Add(this.cb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.noPoTbTxt);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.kodeStockTxt);
            this.groupBox1.Controls.Add(this.KodeSupplierCmb);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 123);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(362, 70);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(101, 17);
            this.cb5.TabIndex = 30;
            this.cb5.Text = "No. Pembelian :";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // noPembelianTxt
            // 
            this.noPembelianTxt.Location = new System.Drawing.Point(535, 70);
            this.noPembelianTxt.Name = "noPembelianTxt";
            this.noPembelianTxt.Size = new System.Drawing.Size(158, 20);
            this.noPembelianTxt.TabIndex = 29;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(17, 70);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(64, 17);
            this.cb2.TabIndex = 28;
            this.cb2.Text = "Supplier";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(17, 43);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(71, 17);
            this.cb1.TabIndex = 27;
            this.cb1.Text = "Tanggal :";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(362, 43);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(167, 17);
            this.cb4.TabIndex = 26;
            this.cb4.Text = "No. PO / No. Terima Barang :";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(17, 97);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(136, 17);
            this.cb3.TabIndex = 25;
            this.cb3.Text = "Kd. Barang / Barcode :";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(155, 19);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(146, 17);
            this.rb2.TabIndex = 24;
            this.rb2.TabStop = true;
            this.rb2.Text = "Laporan Detail Pembelian";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // noPoTbTxt
            // 
            this.noPoTbTxt.Location = new System.Drawing.Point(535, 43);
            this.noPoTbTxt.Name = "noPoTbTxt";
            this.noPoTbTxt.Size = new System.Drawing.Size(158, 20);
            this.noPoTbTxt.TabIndex = 8;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(17, 19);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(116, 17);
            this.rb1.TabIndex = 23;
            this.rb1.TabStop = true;
            this.rb1.Text = "Laporan Pembelian";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "yyyy/MM/dd";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(89, 42);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(107, 20);
            this.dtp1.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(199, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "s/d";
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy/MM/dd";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(228, 42);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(107, 20);
            this.dtp2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(821, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "Buat Laporan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // kodeStockTxt
            // 
            this.kodeStockTxt.Location = new System.Drawing.Point(158, 95);
            this.kodeStockTxt.Name = "kodeStockTxt";
            this.kodeStockTxt.Size = new System.Drawing.Size(173, 20);
            this.kodeStockTxt.TabIndex = 1;
            // 
            // KodeSupplierCmb
            // 
            this.KodeSupplierCmb.DataSource = this.supplierBindingSource;
            this.KodeSupplierCmb.DisplayMember = "NamaSupplier";
            this.KodeSupplierCmb.FormattingEnabled = true;
            this.KodeSupplierCmb.Location = new System.Drawing.Point(89, 68);
            this.KodeSupplierCmb.Name = "KodeSupplierCmb";
            this.KodeSupplierCmb.Size = new System.Drawing.Size(216, 21);
            this.KodeSupplierCmb.TabIndex = 5;
            this.KodeSupplierCmb.ValueMember = "KodeSupplier";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.master_Data;
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.DisplayGroupTree = false;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(0, 0);
            this.crv.Name = "crv";
            this.crv.SelectionFormula = "";
            this.crv.Size = new System.Drawing.Size(952, 572);
            this.crv.TabIndex = 0;
            this.crv.ViewTimeSelectionFormula = "";
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.laporanTglTransaksiRBtn);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 90);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Buat Laporan";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd - MMM - yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // laporanTglTransaksiRBtn
            // 
            this.laporanTglTransaksiRBtn.AutoSize = true;
            this.laporanTglTransaksiRBtn.Checked = true;
            this.laporanTglTransaksiRBtn.Location = new System.Drawing.Point(3, 4);
            this.laporanTglTransaksiRBtn.Name = "laporanTglTransaksiRBtn";
            this.laporanTglTransaksiRBtn.Size = new System.Drawing.Size(152, 17);
            this.laporanTglTransaksiRBtn.TabIndex = 0;
            this.laporanTglTransaksiRBtn.TabStop = true;
            this.laporanTglTransaksiRBtn.Text = "Berdasarkan Tgl Transaksi";
            this.laporanTglTransaksiRBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.laporanKodeStockRBtn);
            this.panel2.Location = new System.Drawing.Point(207, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 90);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buat Laporan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
            // 
            // laporanKodeStockRBtn
            // 
            this.laporanKodeStockRBtn.AutoSize = true;
            this.laporanKodeStockRBtn.Checked = true;
            this.laporanKodeStockRBtn.Location = new System.Drawing.Point(3, 4);
            this.laporanKodeStockRBtn.Name = "laporanKodeStockRBtn";
            this.laporanKodeStockRBtn.Size = new System.Drawing.Size(144, 17);
            this.laporanKodeStockRBtn.TabIndex = 0;
            this.laporanKodeStockRBtn.TabStop = true;
            this.laporanKodeStockRBtn.Text = "Berdasarkan Kode Stock";
            this.laporanKodeStockRBtn.UseVisualStyleBackColor = true;
            // 
            // Modul_Laporan_Pembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 705);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Modul_Laporan_Pembelian";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Pembelian";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Laporan_Pembelian_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton laporanTglTransaksiRBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton laporanKodeStockRBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.TextBox kodeStockTxt;
        private System.Windows.Forms.ComboBox KodeSupplierCmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox noPoTbTxt;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.TextBox noPembelianTxt;
    }
}