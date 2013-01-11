namespace Accounting_Solution_Software
{
    partial class Modul_Laporan_Transfer_stock
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
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbgCMB = new System.Windows.Forms.ComboBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.button8 = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.kodeStockTxt = new System.Windows.Forms.TextBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.crv.Size = new System.Drawing.Size(952, 591);
            this.crv.TabIndex = 0;
            this.crv.ViewTimeSelectionFormula = "";
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
            this.splitContainer2.Panel1MinSize = 110;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.crv);
            this.splitContainer2.Size = new System.Drawing.Size(952, 705);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb3);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.kodeStockTxt);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.cbgCMB);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 104);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cbgCMB
            // 
            this.cbgCMB.FormattingEnabled = true;
            this.cbgCMB.Location = new System.Drawing.Point(426, 48);
            this.cbgCMB.Name = "cbgCMB";
            this.cbgCMB.Size = new System.Drawing.Size(150, 21);
            this.cbgCMB.TabIndex = 16;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(106, 25);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(95, 17);
            this.rb2.TabIndex = 10;
            this.rb2.Text = "Laporan Stock";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(9, 25);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(81, 17);
            this.rb1.TabIndex = 9;
            this.rb1.TabStop = true;
            this.rb1.Text = "Kartu Stock";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(821, 78);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 20);
            this.button8.TabIndex = 6;
            this.button8.Text = "Buat Laporan";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(9, 48);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(71, 17);
            this.cb1.TabIndex = 43;
            this.cb1.Text = "Tanggal :";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "yyyy/MM/dd";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(81, 47);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(107, 20);
            this.dtp1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "s/d";
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy/MM/dd";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(220, 47);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(107, 20);
            this.dtp2.TabIndex = 41;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(9, 75);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(136, 17);
            this.cb2.TabIndex = 45;
            this.cb2.Text = "Kd. Barang / Barcode :";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // kodeStockTxt
            // 
            this.kodeStockTxt.Location = new System.Drawing.Point(150, 73);
            this.kodeStockTxt.Name = "kodeStockTxt";
            this.kodeStockTxt.Size = new System.Drawing.Size(173, 20);
            this.kodeStockTxt.TabIndex = 44;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(351, 50);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(69, 17);
            this.cb3.TabIndex = 46;
            this.cb3.Text = "Cabang :";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // Modul_Laporan_Transfer_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 705);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Modul_Laporan_Transfer_stock";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Stock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Laporan_Stock_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.ComboBox cbgCMB;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.TextBox kodeStockTxt;
        private System.Windows.Forms.CheckBox cb3;
    }
}