namespace Accounting_Solution_Software
{
    partial class Modul_Pembayaran
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
            this.label1 = new System.Windows.Forms.Label();
            this.tunaiRadioButton = new System.Windows.Forms.RadioButton();
            this.kreditRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kodePelangganTxt = new System.Windows.Forms.TextBox();
            this.namaKodePelangganTxt = new System.Windows.Forms.TextBox();
            this.alamatTxt = new System.Windows.Forms.TextBox();
            this.tglJTdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noResepTxt = new System.Windows.Forms.TextBox();
            this.namaPasienTxt = new System.Windows.Forms.TextBox();
            this.alamatPasienTxt = new System.Windows.Forms.TextBox();
            this.kodeDokterTxt = new System.Windows.Forms.TextBox();
            this.namaDokterTxt = new System.Windows.Forms.TextBox();
            this.kodeDokterBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.kembaliTxt = new System.Windows.Forms.TextBox();
            this.dibayarTxt = new System.Windows.Forms.TextBox();
            this.nettoTxt = new System.Windows.Forms.TextBox();
            this.ppnTxt = new System.Windows.Forms.TextBox();
            this.discountRPTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.batalBtn = new System.Windows.Forms.Button();
            this.kodeGudangTxt = new System.Windows.Forms.ComboBox();
            this.gudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stock_Data = new Accounting_Solution_Software.Data_set.Stock_Data();
            this.gudangTableAdapter = new Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.GudangTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.umurPasienTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pembayaran";
            // 
            // tunaiRadioButton
            // 
            this.tunaiRadioButton.AutoSize = true;
            this.tunaiRadioButton.Checked = true;
            this.tunaiRadioButton.Location = new System.Drawing.Point(131, 11);
            this.tunaiRadioButton.Name = "tunaiRadioButton";
            this.tunaiRadioButton.Size = new System.Drawing.Size(52, 17);
            this.tunaiRadioButton.TabIndex = 1;
            this.tunaiRadioButton.TabStop = true;
            this.tunaiRadioButton.Text = "Tunai";
            this.tunaiRadioButton.UseVisualStyleBackColor = true;
            this.tunaiRadioButton.Click += new System.EventHandler(this.tunaiRadioButton_Click);
            // 
            // kreditRadioButton
            // 
            this.kreditRadioButton.AutoSize = true;
            this.kreditRadioButton.Location = new System.Drawing.Point(201, 11);
            this.kreditRadioButton.Name = "kreditRadioButton";
            this.kreditRadioButton.Size = new System.Drawing.Size(52, 17);
            this.kreditRadioButton.TabIndex = 2;
            this.kreditRadioButton.Text = "Kredit";
            this.kreditRadioButton.UseVisualStyleBackColor = true;
            this.kreditRadioButton.Click += new System.EventHandler(this.kreditRadioButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kode Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kode Gudang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tgl Jatuh Tempo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "No. Resep";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nama Pasien";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Alamat Pasien";
            // 
            // kodePelangganTxt
            // 
            this.kodePelangganTxt.Location = new System.Drawing.Point(131, 38);
            this.kodePelangganTxt.Name = "kodePelangganTxt";
            this.kodePelangganTxt.Size = new System.Drawing.Size(69, 20);
            this.kodePelangganTxt.TabIndex = 3;
            // 
            // namaKodePelangganTxt
            // 
            this.namaKodePelangganTxt.Location = new System.Drawing.Point(206, 38);
            this.namaKodePelangganTxt.Name = "namaKodePelangganTxt";
            this.namaKodePelangganTxt.Size = new System.Drawing.Size(198, 20);
            this.namaKodePelangganTxt.TabIndex = 4;
            // 
            // alamatTxt
            // 
            this.alamatTxt.Location = new System.Drawing.Point(131, 66);
            this.alamatTxt.Name = "alamatTxt";
            this.alamatTxt.Size = new System.Drawing.Size(273, 20);
            this.alamatTxt.TabIndex = 5;
            // 
            // tglJTdateTimePicker
            // 
            this.tglJTdateTimePicker.CustomFormat = "dd - MMM - yyyy";
            this.tglJTdateTimePicker.Enabled = false;
            this.tglJTdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tglJTdateTimePicker.Location = new System.Drawing.Point(131, 118);
            this.tglJTdateTimePicker.Name = "tglJTdateTimePicker";
            this.tglJTdateTimePicker.Size = new System.Drawing.Size(108, 20);
            this.tglJTdateTimePicker.TabIndex = 7;
            // 
            // noResepTxt
            // 
            this.noResepTxt.Location = new System.Drawing.Point(131, 144);
            this.noResepTxt.Name = "noResepTxt";
            this.noResepTxt.Size = new System.Drawing.Size(108, 20);
            this.noResepTxt.TabIndex = 8;
            // 
            // namaPasienTxt
            // 
            this.namaPasienTxt.Location = new System.Drawing.Point(131, 170);
            this.namaPasienTxt.Name = "namaPasienTxt";
            this.namaPasienTxt.Size = new System.Drawing.Size(164, 20);
            this.namaPasienTxt.TabIndex = 9;
            // 
            // alamatPasienTxt
            // 
            this.alamatPasienTxt.Location = new System.Drawing.Point(131, 222);
            this.alamatPasienTxt.Name = "alamatPasienTxt";
            this.alamatPasienTxt.Size = new System.Drawing.Size(273, 20);
            this.alamatPasienTxt.TabIndex = 11;
            // 
            // kodeDokterTxt
            // 
            this.kodeDokterTxt.Location = new System.Drawing.Point(131, 248);
            this.kodeDokterTxt.Name = "kodeDokterTxt";
            this.kodeDokterTxt.Size = new System.Drawing.Size(81, 20);
            this.kodeDokterTxt.TabIndex = 12;
            this.kodeDokterTxt.TextChanged += new System.EventHandler(this.kodeDokterTxt_TextChanged);
            // 
            // namaDokterTxt
            // 
            this.namaDokterTxt.Location = new System.Drawing.Point(259, 248);
            this.namaDokterTxt.Name = "namaDokterTxt";
            this.namaDokterTxt.Size = new System.Drawing.Size(145, 20);
            this.namaDokterTxt.TabIndex = 13;
            this.namaDokterTxt.TextChanged += new System.EventHandler(this.namaDokterTxt_TextChanged);
            // 
            // kodeDokterBtn
            // 
            this.kodeDokterBtn.Location = new System.Drawing.Point(220, 247);
            this.kodeDokterBtn.Name = "kodeDokterBtn";
            this.kodeDokterBtn.Size = new System.Drawing.Size(31, 23);
            this.kodeDokterBtn.TabIndex = 4;
            this.kodeDokterBtn.Text = "...";
            this.kodeDokterBtn.UseVisualStyleBackColor = true;
            this.kodeDokterBtn.Click += new System.EventHandler(this.kodeDokterBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.kembaliTxt);
            this.groupBox1.Controls.Add(this.dibayarTxt);
            this.groupBox1.Controls.Add(this.nettoTxt);
            this.groupBox1.Controls.Add(this.ppnTxt);
            this.groupBox1.Controls.Add(this.discountRPTxt);
            this.groupBox1.Location = new System.Drawing.Point(8, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 251);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nilai Pembayaran";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(44, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 31);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "PPN";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 27);
            this.label14.TabIndex = 0;
            this.label14.Text = "Kembali";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 27);
            this.label16.TabIndex = 0;
            this.label16.Text = "Dibayar";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "Uang Muka";
            this.label15.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "Potongan";
            // 
            // kembaliTxt
            // 
            this.kembaliTxt.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembaliTxt.Location = new System.Drawing.Point(162, 196);
            this.kembaliTxt.Name = "kembaliTxt";
            this.kembaliTxt.ReadOnly = true;
            this.kembaliTxt.Size = new System.Drawing.Size(249, 36);
            this.kembaliTxt.TabIndex = 19;
            this.kembaliTxt.Text = "0";
            this.kembaliTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kembaliTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kembaliTxt_KeyDown);
            // 
            // dibayarTxt
            // 
            this.dibayarTxt.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dibayarTxt.Location = new System.Drawing.Point(162, 154);
            this.dibayarTxt.Name = "dibayarTxt";
            this.dibayarTxt.Size = new System.Drawing.Size(249, 36);
            this.dibayarTxt.TabIndex = 18;
            this.dibayarTxt.Text = "0";
            this.dibayarTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dibayarTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dibayarTxt_KeyDown);
            this.dibayarTxt.Leave += new System.EventHandler(this.dibayarTxt_Leave);
            this.dibayarTxt.Enter += new System.EventHandler(this.dibayarTxt_Enter);
            // 
            // nettoTxt
            // 
            this.nettoTxt.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nettoTxt.Location = new System.Drawing.Point(162, 112);
            this.nettoTxt.Name = "nettoTxt";
            this.nettoTxt.ReadOnly = true;
            this.nettoTxt.Size = new System.Drawing.Size(249, 36);
            this.nettoTxt.TabIndex = 17;
            this.nettoTxt.Text = "0";
            this.nettoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ppnTxt
            // 
            this.ppnTxt.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppnTxt.Location = new System.Drawing.Point(162, 69);
            this.ppnTxt.Name = "ppnTxt";
            this.ppnTxt.ReadOnly = true;
            this.ppnTxt.Size = new System.Drawing.Size(249, 36);
            this.ppnTxt.TabIndex = 16;
            this.ppnTxt.Text = "0";
            this.ppnTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountRPTxt
            // 
            this.discountRPTxt.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountRPTxt.Location = new System.Drawing.Point(162, 27);
            this.discountRPTxt.Name = "discountRPTxt";
            this.discountRPTxt.ReadOnly = true;
            this.discountRPTxt.Size = new System.Drawing.Size(249, 36);
            this.discountRPTxt.TabIndex = 14;
            this.discountRPTxt.Text = "0";
            this.discountRPTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kode Dokter";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(225, 534);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(96, 45);
            this.okBtn.TabIndex = 20;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // batalBtn
            // 
            this.batalBtn.Location = new System.Drawing.Point(327, 534);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(96, 45);
            this.batalBtn.TabIndex = 21;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = true;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // kodeGudangTxt
            // 
            this.kodeGudangTxt.DataSource = this.gudangBindingSource;
            this.kodeGudangTxt.DisplayMember = "nama";
            this.kodeGudangTxt.FormattingEnabled = true;
            this.kodeGudangTxt.Location = new System.Drawing.Point(131, 90);
            this.kodeGudangTxt.Name = "kodeGudangTxt";
            this.kodeGudangTxt.Size = new System.Drawing.Size(108, 21);
            this.kodeGudangTxt.TabIndex = 6;
            this.kodeGudangTxt.ValueMember = "id";
            // 
            // gudangBindingSource
            // 
            this.gudangBindingSource.DataMember = "Gudang";
            this.gudangBindingSource.DataSource = this.stock_Data;
            // 
            // stock_Data
            // 
            this.stock_Data.DataSetName = "Stock_Data";
            this.stock_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gudangTableAdapter
            // 
            this.gudangTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Umur Pasien";
            // 
            // umurPasienTxt
            // 
            this.umurPasienTxt.Location = new System.Drawing.Point(131, 196);
            this.umurPasienTxt.Name = "umurPasienTxt";
            this.umurPasienTxt.Size = new System.Drawing.Size(164, 20);
            this.umurPasienTxt.TabIndex = 10;
            // 
            // Modul_Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(446, 586);
            this.ControlBox = false;
            this.Controls.Add(this.kodeGudangTxt);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kodeDokterBtn);
            this.Controls.Add(this.tglJTdateTimePicker);
            this.Controls.Add(this.alamatTxt);
            this.Controls.Add(this.namaDokterTxt);
            this.Controls.Add(this.namaKodePelangganTxt);
            this.Controls.Add(this.alamatPasienTxt);
            this.Controls.Add(this.umurPasienTxt);
            this.Controls.Add(this.namaPasienTxt);
            this.Controls.Add(this.noResepTxt);
            this.Controls.Add(this.kodeDokterTxt);
            this.Controls.Add(this.kodePelangganTxt);
            this.Controls.Add(this.kreditRadioButton);
            this.Controls.Add(this.tunaiRadioButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Pembayaran";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.Modul_Pembayaran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stock_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton tunaiRadioButton;
        private System.Windows.Forms.RadioButton kreditRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kodePelangganTxt;
        private System.Windows.Forms.TextBox namaKodePelangganTxt;
        private System.Windows.Forms.TextBox alamatTxt;
        private System.Windows.Forms.DateTimePicker tglJTdateTimePicker;
        private System.Windows.Forms.TextBox noResepTxt;
        private System.Windows.Forms.TextBox namaPasienTxt;
        private System.Windows.Forms.TextBox alamatPasienTxt;
        private System.Windows.Forms.TextBox kodeDokterTxt;
        private System.Windows.Forms.TextBox namaDokterTxt;
        private System.Windows.Forms.Button kodeDokterBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dibayarTxt;
        private System.Windows.Forms.TextBox nettoTxt;
        private System.Windows.Forms.TextBox discountRPTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox kembaliTxt;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox kodeGudangTxt;
        private Accounting_Solution_Software.Data_set.Stock_Data stock_Data;
        private System.Windows.Forms.BindingSource gudangBindingSource;
        private Accounting_Solution_Software.Data_set.Stock_DataTableAdapters.GudangTableAdapter gudangTableAdapter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox umurPasienTxt;
        private System.Windows.Forms.TextBox ppnTxt;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}