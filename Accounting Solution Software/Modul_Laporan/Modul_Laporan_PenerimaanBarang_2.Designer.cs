namespace Accounting_Solution_Software
{
    partial class Modul_Laporan_PenerimaanBarang
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.NoTerimaBarangTxt = new System.Windows.Forms.TextBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.NoPOTxt = new System.Windows.Forms.TextBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.kodeSupplierCmb = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.label21 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.button8 = new System.Windows.Forms.Button();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.supplierTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.SupplierTableAdapter();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.crv);
            this.splitContainer2.Size = new System.Drawing.Size(952, 705);
            this.splitContainer2.SplitterDistance = 112;
            this.splitContainer2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.NoTerimaBarangTxt);
            this.groupBox1.Controls.Add(this.cb4);
            this.groupBox1.Controls.Add(this.NoPOTxt);
            this.groupBox1.Controls.Add(this.cb3);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.kodeSupplierCmb);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 106);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(157, 20);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(166, 17);
            this.rb2.TabIndex = 14;
            this.rb2.TabStop = true;
            this.rb2.Text = "Laporan Detail Terima Barang";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(15, 19);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(136, 17);
            this.rb1.TabIndex = 13;
            this.rb1.TabStop = true;
            this.rb1.Text = "Laporan Terima Barang";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // NoTerimaBarangTxt
            // 
            this.NoTerimaBarangTxt.Location = new System.Drawing.Point(484, 74);
            this.NoTerimaBarangTxt.Name = "NoTerimaBarangTxt";
            this.NoTerimaBarangTxt.Size = new System.Drawing.Size(167, 20);
            this.NoTerimaBarangTxt.TabIndex = 12;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(363, 76);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(115, 17);
            this.cb4.TabIndex = 11;
            this.cb4.Text = "No. Terima Barang";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // NoPOTxt
            // 
            this.NoPOTxt.Location = new System.Drawing.Point(484, 48);
            this.NoPOTxt.Name = "NoPOTxt";
            this.NoPOTxt.Size = new System.Drawing.Size(167, 20);
            this.NoPOTxt.TabIndex = 10;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(363, 48);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(61, 17);
            this.cb3.TabIndex = 9;
            this.cb3.Text = "No. PO";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(15, 76);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(64, 17);
            this.cb2.TabIndex = 8;
            this.cb2.Text = "Supplier";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(15, 48);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(71, 17);
            this.cb1.TabIndex = 7;
            this.cb1.Text = "Tanggal :";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // kodeSupplierCmb
            // 
            this.kodeSupplierCmb.DataSource = this.supplierBindingSource;
            this.kodeSupplierCmb.DisplayMember = "NamaSupplier";
            this.kodeSupplierCmb.FormattingEnabled = true;
            this.kodeSupplierCmb.Location = new System.Drawing.Point(93, 74);
            this.kodeSupplierCmb.Name = "kodeSupplierCmb";
            this.kodeSupplierCmb.Size = new System.Drawing.Size(184, 21);
            this.kodeSupplierCmb.TabIndex = 6;
            this.kodeSupplierCmb.ValueMember = "KodeSupplier";
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
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(205, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "s/d";
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "yyyy/MM/dd";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(92, 45);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(107, 20);
            this.dtp1.TabIndex = 1;
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy/MM/dd";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(234, 45);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(107, 20);
            this.dtp2.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(821, 77);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 20);
            this.button8.TabIndex = 2;
            this.button8.Text = "Buat Laporan";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
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
            this.crv.Size = new System.Drawing.Size(952, 589);
            this.crv.TabIndex = 0;
            this.crv.ViewTimeSelectionFormula = "";
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // Modul_Laporan_PenerimaanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 705);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Modul_Laporan_PenerimaanBarang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Penerimaan Barang";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Laporan_PenerimaanBarang_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.ComboBox kodeSupplierCmb;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.TextBox NoTerimaBarangTxt;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.TextBox NoPOTxt;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
    }
}