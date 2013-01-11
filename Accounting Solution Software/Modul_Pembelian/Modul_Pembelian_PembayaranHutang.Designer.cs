namespace Accounting_Solution_Software
{
    partial class Modul_Pembelian_PembayaranHutang
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
            System.Windows.Forms.Label fAKTURLabel;
            System.Windows.Forms.Label kodeSupplierLabel;
            System.Windows.Forms.Label nominalLabel;
            System.Windows.Forms.Label tJTLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label tANGGALLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fAKTURTextBox = new System.Windows.Forms.TextBox();
            this.kodeSupplierTextBox = new System.Windows.Forms.TextBox();
            this.namaSupplierTextBox = new System.Windows.Forms.TextBox();
            this.nominalTextBox = new System.Windows.Forms.TextBox();
            this.tJTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KodeStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TglKadaluarsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noBuktiTxt = new System.Windows.Forms.TextBox();
            this.pembayaranTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.keluarBtn = new System.Windows.Forms.Button();
            this.bayarBtn = new System.Windows.Forms.Button();
            this.sisaHutangTxt = new System.Windows.Forms.TextBox();
            this.tANGGALDateTimePicker = new System.Windows.Forms.DateTimePicker();
            fAKTURLabel = new System.Windows.Forms.Label();
            kodeSupplierLabel = new System.Windows.Forms.Label();
            nominalLabel = new System.Windows.Forms.Label();
            tJTLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            tANGGALLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fAKTURLabel
            // 
            fAKTURLabel.AutoSize = true;
            fAKTURLabel.Location = new System.Drawing.Point(18, 45);
            fAKTURLabel.Name = "fAKTURLabel";
            fAKTURLabel.Size = new System.Drawing.Size(43, 13);
            fAKTURLabel.TabIndex = 3;
            fAKTURLabel.Text = "Faktur :";
            // 
            // kodeSupplierLabel
            // 
            kodeSupplierLabel.AutoSize = true;
            kodeSupplierLabel.Location = new System.Drawing.Point(18, 97);
            kodeSupplierLabel.Name = "kodeSupplierLabel";
            kodeSupplierLabel.Size = new System.Drawing.Size(51, 13);
            kodeSupplierLabel.TabIndex = 7;
            kodeSupplierLabel.Text = "Supplier :";
            // 
            // nominalLabel
            // 
            nominalLabel.AutoSize = true;
            nominalLabel.Location = new System.Drawing.Point(18, 151);
            nominalLabel.Name = "nominalLabel";
            nominalLabel.Size = new System.Drawing.Size(89, 13);
            nominalLabel.TabIndex = 13;
            nominalLabel.Text = "Total Pembelian :";
            nominalLabel.Click += new System.EventHandler(this.nominalLabel_Click);
            // 
            // tJTLabel
            // 
            tJTLabel.AutoSize = true;
            tJTLabel.Location = new System.Drawing.Point(18, 124);
            tJTLabel.Name = "tJTLabel";
            tJTLabel.Size = new System.Drawing.Size(67, 13);
            tJTLabel.TabIndex = 15;
            tJTLabel.Text = "Tanggal JT :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 13);
            label1.TabIndex = 3;
            label1.Text = "NO Bukti :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(18, 203);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 13);
            label2.TabIndex = 18;
            label2.Text = "Total Pembayaran :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 13);
            label3.TabIndex = 13;
            label3.Text = "Sisa Hutang :";
            label3.Click += new System.EventHandler(this.nominalLabel_Click);
            // 
            // tANGGALLabel
            // 
            tANGGALLabel.AutoSize = true;
            tANGGALLabel.Location = new System.Drawing.Point(18, 20);
            tANGGALLabel.Name = "tANGGALLabel";
            tANGGALLabel.Size = new System.Drawing.Size(52, 13);
            tANGGALLabel.TabIndex = 1;
            tANGGALLabel.Text = "Tanggal :";
            // 
            // fAKTURTextBox
            // 
            this.fAKTURTextBox.Location = new System.Drawing.Point(129, 42);
            this.fAKTURTextBox.Name = "fAKTURTextBox";
            this.fAKTURTextBox.ReadOnly = true;
            this.fAKTURTextBox.Size = new System.Drawing.Size(354, 20);
            this.fAKTURTextBox.TabIndex = 4;
            // 
            // kodeSupplierTextBox
            // 
            this.kodeSupplierTextBox.Location = new System.Drawing.Point(129, 94);
            this.kodeSupplierTextBox.Name = "kodeSupplierTextBox";
            this.kodeSupplierTextBox.ReadOnly = true;
            this.kodeSupplierTextBox.Size = new System.Drawing.Size(53, 20);
            this.kodeSupplierTextBox.TabIndex = 8;
            // 
            // namaSupplierTextBox
            // 
            this.namaSupplierTextBox.Location = new System.Drawing.Point(188, 94);
            this.namaSupplierTextBox.Name = "namaSupplierTextBox";
            this.namaSupplierTextBox.ReadOnly = true;
            this.namaSupplierTextBox.Size = new System.Drawing.Size(295, 20);
            this.namaSupplierTextBox.TabIndex = 10;
            // 
            // nominalTextBox
            // 
            this.nominalTextBox.Location = new System.Drawing.Point(129, 148);
            this.nominalTextBox.Name = "nominalTextBox";
            this.nominalTextBox.ReadOnly = true;
            this.nominalTextBox.Size = new System.Drawing.Size(287, 20);
            this.nominalTextBox.TabIndex = 14;
            this.nominalTextBox.TextChanged += new System.EventHandler(this.nominalTextBox_TextChanged);
            // 
            // tJTDateTimePicker
            // 
            this.tJTDateTimePicker.Location = new System.Drawing.Point(129, 120);
            this.tJTDateTimePicker.Name = "tJTDateTimePicker";
            this.tJTDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tJTDateTimePicker.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeStock,
            this.NamaStock,
            this.Qty,
            this.Satuan,
            this.TotalJumlah,
            this.TglKadaluarsa});
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(563, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // KodeStock
            // 
            this.KodeStock.HeaderText = "KodeStock";
            this.KodeStock.Name = "KodeStock";
            this.KodeStock.ReadOnly = true;
            // 
            // NamaStock
            // 
            this.NamaStock.HeaderText = "Nama Stock";
            this.NamaStock.Name = "NamaStock";
            this.NamaStock.ReadOnly = true;
            this.NamaStock.Width = 175;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 30;
            // 
            // Satuan
            // 
            this.Satuan.HeaderText = "Satuan";
            this.Satuan.Name = "Satuan";
            this.Satuan.ReadOnly = true;
            this.Satuan.Width = 50;
            // 
            // TotalJumlah
            // 
            this.TotalJumlah.HeaderText = "Total Beli";
            this.TotalJumlah.Name = "TotalJumlah";
            this.TotalJumlah.ReadOnly = true;
            // 
            // TglKadaluarsa
            // 
            this.TglKadaluarsa.DataPropertyName = "TglKadaluarsa";
            this.TglKadaluarsa.HeaderText = "TglKadaluarsa";
            this.TglKadaluarsa.Name = "TglKadaluarsa";
            this.TglKadaluarsa.ReadOnly = true;
            // 
            // noBuktiTxt
            // 
            this.noBuktiTxt.Location = new System.Drawing.Point(129, 68);
            this.noBuktiTxt.Name = "noBuktiTxt";
            this.noBuktiTxt.ReadOnly = true;
            this.noBuktiTxt.Size = new System.Drawing.Size(354, 20);
            this.noBuktiTxt.TabIndex = 4;
            // 
            // pembayaranTxt
            // 
            this.pembayaranTxt.Location = new System.Drawing.Point(129, 200);
            this.pembayaranTxt.Name = "pembayaranTxt";
            this.pembayaranTxt.Size = new System.Drawing.Size(287, 20);
            this.pembayaranTxt.TabIndex = 19;
            this.pembayaranTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pembayaranTxt_KeyDown);
            this.pembayaranTxt.Leave += new System.EventHandler(this.pembayaranTxt_Leave);
            this.pembayaranTxt.Enter += new System.EventHandler(this.pembayaranTxt_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // keluarBtn
            // 
            this.keluarBtn.Location = new System.Drawing.Point(500, 412);
            this.keluarBtn.Name = "keluarBtn";
            this.keluarBtn.Size = new System.Drawing.Size(75, 23);
            this.keluarBtn.TabIndex = 22;
            this.keluarBtn.Text = "Batal";
            this.keluarBtn.UseVisualStyleBackColor = true;
            this.keluarBtn.Click += new System.EventHandler(this.keluarBtn_Click);
            // 
            // bayarBtn
            // 
            this.bayarBtn.Location = new System.Drawing.Point(409, 412);
            this.bayarBtn.Name = "bayarBtn";
            this.bayarBtn.Size = new System.Drawing.Size(75, 23);
            this.bayarBtn.TabIndex = 21;
            this.bayarBtn.Text = "Simpan";
            this.bayarBtn.UseVisualStyleBackColor = true;
            this.bayarBtn.Click += new System.EventHandler(this.bayarBtn_Click);
            // 
            // sisaHutangTxt
            // 
            this.sisaHutangTxt.Location = new System.Drawing.Point(129, 174);
            this.sisaHutangTxt.Name = "sisaHutangTxt";
            this.sisaHutangTxt.ReadOnly = true;
            this.sisaHutangTxt.Size = new System.Drawing.Size(287, 20);
            this.sisaHutangTxt.TabIndex = 14;
            this.sisaHutangTxt.TextChanged += new System.EventHandler(this.nominalTextBox_TextChanged);
            // 
            // tANGGALDateTimePicker
            // 
            this.tANGGALDateTimePicker.Location = new System.Drawing.Point(129, 16);
            this.tANGGALDateTimePicker.Name = "tANGGALDateTimePicker";
            this.tANGGALDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tANGGALDateTimePicker.TabIndex = 2;
            // 
            // Modul_Pembelian_PembayaranHutang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 443);
            this.ControlBox = false;
            this.Controls.Add(this.keluarBtn);
            this.Controls.Add(this.bayarBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(label2);
            this.Controls.Add(this.pembayaranTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(tANGGALLabel);
            this.Controls.Add(this.tANGGALDateTimePicker);
            this.Controls.Add(label1);
            this.Controls.Add(fAKTURLabel);
            this.Controls.Add(this.noBuktiTxt);
            this.Controls.Add(this.fAKTURTextBox);
            this.Controls.Add(kodeSupplierLabel);
            this.Controls.Add(this.kodeSupplierTextBox);
            this.Controls.Add(this.namaSupplierTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(nominalLabel);
            this.Controls.Add(this.sisaHutangTxt);
            this.Controls.Add(this.nominalTextBox);
            this.Controls.Add(tJTLabel);
            this.Controls.Add(this.tJTDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Pembelian_PembayaranHutang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pembayaran Hutang";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fAKTURTextBox;
        private System.Windows.Forms.TextBox kodeSupplierTextBox;
        private System.Windows.Forms.TextBox namaSupplierTextBox;
        private System.Windows.Forms.TextBox nominalTextBox;
        private System.Windows.Forms.DateTimePicker tJTDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox noBuktiTxt;
        private System.Windows.Forms.TextBox pembayaranTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button keluarBtn;
        private System.Windows.Forms.Button bayarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn TglKadaluarsa;
        private System.Windows.Forms.TextBox sisaHutangTxt;
        private System.Windows.Forms.DateTimePicker tANGGALDateTimePicker;
    }
}