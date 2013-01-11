namespace Accounting_Solution_Software
{
    partial class Modul_Penjualan_PembayaranPiutang
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label fAKTURLabel;
            System.Windows.Forms.Label kodeSupplierLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label nominalLabel;
            System.Windows.Forms.Label tJTLabel;
            this.keluarBtn = new System.Windows.Forms.Button();
            this.bayarBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pembayaranTxt = new System.Windows.Forms.TextBox();
            this.noBuktiTxt = new System.Windows.Forms.TextBox();
            this.fakturTxt = new System.Windows.Forms.TextBox();
            this.kodeCustomerTextBox = new System.Windows.Forms.TextBox();
            this.namaCustomerTextBox = new System.Windows.Forms.TextBox();
            this.sisaPiutangTxt = new System.Windows.Forms.TextBox();
            this.nominalTextBox = new System.Windows.Forms.TextBox();
            this.tJTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            fAKTURLabel = new System.Windows.Forms.Label();
            kodeSupplierLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nominalLabel = new System.Windows.Forms.Label();
            tJTLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 176);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 13);
            label2.TabIndex = 39;
            label2.Text = "Total Pembayaran :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 13);
            label1.TabIndex = 25;
            label1.Text = "NO Bukti :";
            // 
            // fAKTURLabel
            // 
            fAKTURLabel.AutoSize = true;
            fAKTURLabel.Location = new System.Drawing.Point(18, 18);
            fAKTURLabel.Name = "fAKTURLabel";
            fAKTURLabel.Size = new System.Drawing.Size(43, 13);
            fAKTURLabel.TabIndex = 26;
            fAKTURLabel.Text = "Faktur :";
            // 
            // kodeSupplierLabel
            // 
            kodeSupplierLabel.AutoSize = true;
            kodeSupplierLabel.Location = new System.Drawing.Point(18, 70);
            kodeSupplierLabel.Name = "kodeSupplierLabel";
            kodeSupplierLabel.Size = new System.Drawing.Size(57, 13);
            kodeSupplierLabel.TabIndex = 29;
            kodeSupplierLabel.Text = "Customer :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 150);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 13);
            label3.TabIndex = 32;
            label3.Text = "Sisa Piutang :";
            // 
            // nominalLabel
            // 
            nominalLabel.AutoSize = true;
            nominalLabel.Location = new System.Drawing.Point(18, 124);
            nominalLabel.Name = "nominalLabel";
            nominalLabel.Size = new System.Drawing.Size(87, 13);
            nominalLabel.TabIndex = 33;
            nominalLabel.Text = "Total Penjualan :";
            // 
            // tJTLabel
            // 
            tJTLabel.AutoSize = true;
            tJTLabel.Location = new System.Drawing.Point(18, 97);
            tJTLabel.Name = "tJTLabel";
            tJTLabel.Size = new System.Drawing.Size(67, 13);
            tJTLabel.TabIndex = 36;
            tJTLabel.Text = "Tanggal JT :";
            // 
            // keluarBtn
            // 
            this.keluarBtn.Location = new System.Drawing.Point(498, 213);
            this.keluarBtn.Name = "keluarBtn";
            this.keluarBtn.Size = new System.Drawing.Size(75, 23);
            this.keluarBtn.TabIndex = 43;
            this.keluarBtn.Text = "Batal";
            this.keluarBtn.UseVisualStyleBackColor = true;
            this.keluarBtn.Click += new System.EventHandler(this.keluarBtn_Click);
            // 
            // bayarBtn
            // 
            this.bayarBtn.Location = new System.Drawing.Point(407, 213);
            this.bayarBtn.Name = "bayarBtn";
            this.bayarBtn.Size = new System.Drawing.Size(75, 23);
            this.bayarBtn.TabIndex = 42;
            this.bayarBtn.Text = "Simpan";
            this.bayarBtn.UseVisualStyleBackColor = true;
            this.bayarBtn.Click += new System.EventHandler(this.bayarBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pembayaranTxt
            // 
            this.pembayaranTxt.Location = new System.Drawing.Point(129, 173);
            this.pembayaranTxt.Name = "pembayaranTxt";
            this.pembayaranTxt.Size = new System.Drawing.Size(287, 20);
            this.pembayaranTxt.TabIndex = 40;
            this.pembayaranTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pembayaranTxt_KeyDown);
            this.pembayaranTxt.Leave += new System.EventHandler(this.pembayaranTxt_Leave);
            this.pembayaranTxt.Enter += new System.EventHandler(this.pembayaranTxt_Enter);
            // 
            // noBuktiTxt
            // 
            this.noBuktiTxt.Location = new System.Drawing.Point(129, 41);
            this.noBuktiTxt.Name = "noBuktiTxt";
            this.noBuktiTxt.ReadOnly = true;
            this.noBuktiTxt.Size = new System.Drawing.Size(354, 20);
            this.noBuktiTxt.TabIndex = 27;
            // 
            // fakturTxt
            // 
            this.fakturTxt.Location = new System.Drawing.Point(129, 15);
            this.fakturTxt.Name = "fakturTxt";
            this.fakturTxt.ReadOnly = true;
            this.fakturTxt.Size = new System.Drawing.Size(354, 20);
            this.fakturTxt.TabIndex = 28;
            // 
            // kodeCustomerTextBox
            // 
            this.kodeCustomerTextBox.Location = new System.Drawing.Point(129, 67);
            this.kodeCustomerTextBox.Name = "kodeCustomerTextBox";
            this.kodeCustomerTextBox.ReadOnly = true;
            this.kodeCustomerTextBox.Size = new System.Drawing.Size(53, 20);
            this.kodeCustomerTextBox.TabIndex = 30;
            // 
            // namaCustomerTextBox
            // 
            this.namaCustomerTextBox.Location = new System.Drawing.Point(188, 67);
            this.namaCustomerTextBox.Name = "namaCustomerTextBox";
            this.namaCustomerTextBox.ReadOnly = true;
            this.namaCustomerTextBox.Size = new System.Drawing.Size(295, 20);
            this.namaCustomerTextBox.TabIndex = 31;
            this.namaCustomerTextBox.TextChanged += new System.EventHandler(this.namaSupplierTextBox_TextChanged);
            // 
            // sisaPiutangTxt
            // 
            this.sisaPiutangTxt.Location = new System.Drawing.Point(129, 147);
            this.sisaPiutangTxt.Name = "sisaPiutangTxt";
            this.sisaPiutangTxt.ReadOnly = true;
            this.sisaPiutangTxt.Size = new System.Drawing.Size(287, 20);
            this.sisaPiutangTxt.TabIndex = 35;
            // 
            // nominalTextBox
            // 
            this.nominalTextBox.Location = new System.Drawing.Point(129, 121);
            this.nominalTextBox.Name = "nominalTextBox";
            this.nominalTextBox.ReadOnly = true;
            this.nominalTextBox.Size = new System.Drawing.Size(287, 20);
            this.nominalTextBox.TabIndex = 34;
            // 
            // tJTDateTimePicker
            // 
            this.tJTDateTimePicker.Location = new System.Drawing.Point(129, 93);
            this.tJTDateTimePicker.Name = "tJTDateTimePicker";
            this.tJTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tJTDateTimePicker.TabIndex = 37;
            // 
            // Modul_Penjualan_PembayaranPiutang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 243);
            this.ControlBox = false;
            this.Controls.Add(this.keluarBtn);
            this.Controls.Add(this.bayarBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(label2);
            this.Controls.Add(this.pembayaranTxt);
            this.Controls.Add(label1);
            this.Controls.Add(fAKTURLabel);
            this.Controls.Add(this.noBuktiTxt);
            this.Controls.Add(this.fakturTxt);
            this.Controls.Add(kodeSupplierLabel);
            this.Controls.Add(this.kodeCustomerTextBox);
            this.Controls.Add(this.namaCustomerTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(nominalLabel);
            this.Controls.Add(this.sisaPiutangTxt);
            this.Controls.Add(this.nominalTextBox);
            this.Controls.Add(tJTLabel);
            this.Controls.Add(this.tJTDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Penjualan_PembayaranPiutang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran Piutang";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button keluarBtn;
        private System.Windows.Forms.Button bayarBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pembayaranTxt;
        private System.Windows.Forms.TextBox noBuktiTxt;
        private System.Windows.Forms.TextBox fakturTxt;
        private System.Windows.Forms.TextBox kodeCustomerTextBox;
        private System.Windows.Forms.TextBox namaCustomerTextBox;
        private System.Windows.Forms.TextBox sisaPiutangTxt;
        private System.Windows.Forms.TextBox nominalTextBox;
        private System.Windows.Forms.DateTimePicker tJTDateTimePicker;
    }
}