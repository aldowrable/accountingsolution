namespace Accounting_Solution_Software
{
    partial class Modul_Laporan_PurchaseOrder
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
            this.cbgCMB = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.noPOTxt = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.kodeStockTxt = new System.Windows.Forms.TextBox();
            this.KodeSupplierCmb = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.supplierTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.SupplierTableAdapter();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(944, 678);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbgCMB);
            this.groupBox1.Controls.Add(this.cb4);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.cb5);
            this.groupBox1.Controls.Add(this.cb3);
            this.groupBox1.Controls.Add(this.noPOTxt);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.kodeStockTxt);
            this.groupBox1.Controls.Add(this.KodeSupplierCmb);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 126);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cbgCMB
            // 
            this.cbgCMB.DisplayMember = "NamaSupplier";
            this.cbgCMB.FormattingEnabled = true;
            this.cbgCMB.Location = new System.Drawing.Point(489, 44);
            this.cbgCMB.Name = "cbgCMB";
            this.cbgCMB.Size = new System.Drawing.Size(158, 21);
            this.cbgCMB.TabIndex = 43;
            this.cbgCMB.ValueMember = "KodeSupplier";
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(359, 44);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(124, 17);
            this.cb4.TabIndex = 42;
            this.cb4.Text = "Cabang Pengiriman :";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(15, 71);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(64, 17);
            this.cb2.TabIndex = 40;
            this.cb2.Text = "Supplier";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(15, 44);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(71, 17);
            this.cb1.TabIndex = 39;
            this.cb1.Text = "Tanggal :";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(359, 71);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(67, 17);
            this.cb5.TabIndex = 38;
            this.cb5.Text = "No. PO :";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(15, 98);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(136, 17);
            this.cb3.TabIndex = 37;
            this.cb3.Text = "Kd. Barang / Barcode :";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // noPOTxt
            // 
            this.noPOTxt.Location = new System.Drawing.Point(489, 71);
            this.noPOTxt.Name = "noPOTxt";
            this.noPOTxt.Size = new System.Drawing.Size(158, 20);
            this.noPOTxt.TabIndex = 36;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "yyyy/MM/dd";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(87, 43);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(107, 20);
            this.dtp1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "s/d";
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy/MM/dd";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(226, 43);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(107, 20);
            this.dtp2.TabIndex = 33;
            // 
            // kodeStockTxt
            // 
            this.kodeStockTxt.Location = new System.Drawing.Point(156, 96);
            this.kodeStockTxt.Name = "kodeStockTxt";
            this.kodeStockTxt.Size = new System.Drawing.Size(173, 20);
            this.kodeStockTxt.TabIndex = 32;
            // 
            // KodeSupplierCmb
            // 
            this.KodeSupplierCmb.DataSource = this.supplierBindingSource;
            this.KodeSupplierCmb.DisplayMember = "NamaSupplier";
            this.KodeSupplierCmb.FormattingEnabled = true;
            this.KodeSupplierCmb.Location = new System.Drawing.Point(87, 69);
            this.KodeSupplierCmb.Name = "KodeSupplierCmb";
            this.KodeSupplierCmb.Size = new System.Drawing.Size(216, 21);
            this.KodeSupplierCmb.TabIndex = 35;
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
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(166, 21);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(171, 17);
            this.rb2.TabIndex = 28;
            this.rb2.TabStop = true;
            this.rb2.Text = "Laporan Detail Purchase Order";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(15, 21);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(141, 17);
            this.rb1.TabIndex = 27;
            this.rb1.TabStop = true;
            this.rb1.Text = "Laporan Purchase Order";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(813, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 20);
            this.button5.TabIndex = 2;
            this.button5.Text = "Buat Laporan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.crv.Size = new System.Drawing.Size(944, 542);
            this.crv.TabIndex = 0;
            this.crv.ViewTimeSelectionFormula = "";
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // Modul_Laporan_PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 678);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Modul_Laporan_PurchaseOrder";
            this.ShowIcon = false;
            this.Text = "Laporan Purchase Order";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Laporan_PurchaseOrder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb5;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.TextBox noPOTxt;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.TextBox kodeStockTxt;
        private System.Windows.Forms.ComboBox KodeSupplierCmb;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Button button5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.ComboBox cbgCMB;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.SupplierTableAdapter supplierTableAdapter;
    }
}