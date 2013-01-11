namespace Accounting_Solution_Software
{
    partial class Modul_Laporan_Arus_KasKecil
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.txtNoBukti = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 5);
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.crystalReportViewer3);
            this.splitContainer2.Size = new System.Drawing.Size(952, 705);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.txtNoBukti);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 92);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(9, 66);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(79, 17);
            this.cb2.TabIndex = 40;
            this.cb2.Text = "No. Bukti  :";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(9, 40);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(71, 17);
            this.cb1.TabIndex = 39;
            this.cb1.Text = "Tanggal :";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "yyyy/MM/dd";
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(94, 39);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(107, 20);
            this.dtp1.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(204, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "s/d";
            // 
            // dtp2
            // 
            this.dtp2.CustomFormat = "yyyy/MM/dd";
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(233, 39);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(107, 20);
            this.dtp2.TabIndex = 37;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(147, 17);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(111, 17);
            this.rb2.TabIndex = 35;
            this.rb2.TabStop = true;
            this.rb2.Text = "Laporan Kas Kecil";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(9, 17);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(115, 17);
            this.rb1.TabIndex = 34;
            this.rb1.TabStop = true;
            this.rb1.Text = "Laporan Kas Besar";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // txtNoBukti
            // 
            this.txtNoBukti.Location = new System.Drawing.Point(94, 65);
            this.txtNoBukti.Name = "txtNoBukti";
            this.txtNoBukti.Size = new System.Drawing.Size(188, 20);
            this.txtNoBukti.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(821, 66);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 20);
            this.button8.TabIndex = 6;
            this.button8.Text = "Buat Laporan";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = -1;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.DisplayGroupTree = false;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.SelectionFormula = "";
            this.crystalReportViewer3.Size = new System.Drawing.Size(952, 601);
            this.crystalReportViewer3.TabIndex = 0;
            this.crystalReportViewer3.ViewTimeSelectionFormula = "";
            // 
            // Modul_Laporan_Arus_KasKecil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 705);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Modul_Laporan_Arus_KasKecil";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan Arus Kas";
            this.TopMost = true;
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button8;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNoBukti;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.CheckBox cb2;
    }
}