namespace Accounting_Solution_Software
{
    partial class Modul_Akuntansi_JurnalUmum
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
            this.tanggalDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.deskRTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delItem = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.crLbl = new System.Windows.Forms.Label();
            this.drLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.akunItemDTV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.noJurnalTxtBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.AccountTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager();
            this.label8 = new System.Windows.Forms.Label();
            this.noRefTxt = new System.Windows.Forms.TextBox();
            this.kodeperkiraan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaperkiraan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akunItemDTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tanggalDTP
            // 
            this.tanggalDTP.Location = new System.Drawing.Point(85, 40);
            this.tanggalDTP.Name = "tanggalDTP";
            this.tanggalDTP.Size = new System.Drawing.Size(200, 20);
            this.tanggalDTP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tanggal :";
            // 
            // deskRTB
            // 
            this.deskRTB.Location = new System.Drawing.Point(360, 17);
            this.deskRTB.Name = "deskRTB";
            this.deskRTB.Size = new System.Drawing.Size(231, 43);
            this.deskRTB.TabIndex = 2;
            this.deskRTB.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deskripsi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delItem);
            this.groupBox1.Controls.Add(this.addItem);
            this.groupBox1.Controls.Add(this.crLbl);
            this.groupBox1.Controls.Add(this.drLbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.akunItemDTV);
            this.groupBox1.Location = new System.Drawing.Point(16, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 219);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // delItem
            // 
            this.delItem.Location = new System.Drawing.Point(549, 86);
            this.delItem.Name = "delItem";
            this.delItem.Size = new System.Drawing.Size(30, 23);
            this.delItem.TabIndex = 6;
            this.delItem.Text = "x";
            this.delItem.UseVisualStyleBackColor = true;
            this.delItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(548, 57);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(30, 23);
            this.addItem.TabIndex = 5;
            this.addItem.Text = "+";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // crLbl
            // 
            this.crLbl.AutoSize = true;
            this.crLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crLbl.Location = new System.Drawing.Point(327, 192);
            this.crLbl.Name = "crLbl";
            this.crLbl.Size = new System.Drawing.Size(16, 16);
            this.crLbl.TabIndex = 4;
            this.crLbl.Text = "0";
            // 
            // drLbl
            // 
            this.drLbl.AutoSize = true;
            this.drLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drLbl.Location = new System.Drawing.Point(61, 192);
            this.drLbl.Name = "drLbl";
            this.drLbl.Size = new System.Drawing.Size(16, 16);
            this.drLbl.TabIndex = 3;
            this.drLbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kredit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Debit :";
            // 
            // akunItemDTV
            // 
            this.akunItemDTV.AllowUserToAddRows = false;
            this.akunItemDTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.akunItemDTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeperkiraan,
            this.namaperkiraan,
            this.debit,
            this.kredit});
            this.akunItemDTV.Location = new System.Drawing.Point(17, 23);
            this.akunItemDTV.Name = "akunItemDTV";
            this.akunItemDTV.RowHeadersVisible = false;
            this.akunItemDTV.RowHeadersWidth = 10;
            this.akunItemDTV.Size = new System.Drawing.Size(525, 162);
            this.akunItemDTV.TabIndex = 0;
            this.akunItemDTV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.akunItemDTV_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nomor :";
            // 
            // noJurnalTxtBox
            // 
            this.noJurnalTxtBox.Location = new System.Drawing.Point(85, 14);
            this.noJurnalTxtBox.Name = "noJurnalTxtBox";
            this.noJurnalTxtBox.Size = new System.Drawing.Size(200, 20);
            this.noJurnalTxtBox.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Keluar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(445, 331);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 41;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.master_Data;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankTableAdapter = null;
            this.tableAdapterManager.BeliTableAdapter = null;
            this.tableAdapterManager.BilyetGiroTableAdapter = null;
            this.tableAdapterManager.BudgetTableAdapter = null;
            this.tableAdapterManager.CekTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.DokterTableAdapter = null;
            this.tableAdapterManager.GiroTableAdapter = null;
            this.tableAdapterManager.GroupCustomerTableAdapter = null;
            this.tableAdapterManager.GudangTableAdapter = null;
            this.tableAdapterManager.HistoriSubJurnalUmumTableAdapter = null;
            this.tableAdapterManager.IdentityTableAdapter = null;
            this.tableAdapterManager.JasaDokterTableAdapter = null;
            this.tableAdapterManager.JasaTableAdapter = null;
            this.tableAdapterManager.JualTableAdapter = null;
            this.tableAdapterManager.JurnalUmumTableAdapter = null;
            this.tableAdapterManager.karyawanTableAdapter = null;
            this.tableAdapterManager.KelompokAccountTableAdapter = null;
            this.tableAdapterManager.KotaTableAdapter = null;
            this.tableAdapterManager.PajakTableAdapter = null;
            this.tableAdapterManager.RacikanTableAdapter = null;
            this.tableAdapterManager.RekonsiliasiTableAdapter = null;
            this.tableAdapterManager.RetBeliTableAdapter = null;
            this.tableAdapterManager.RetJualTableAdapter = null;
            this.tableAdapterManager.RetSubBeliTableAdapter = null;
            this.tableAdapterManager.RetSubJualTableAdapter = null;
            this.tableAdapterManager.SalesmanTableAdapter = null;
            this.tableAdapterManager.SavingTableAdapter = null;
            this.tableAdapterManager.SettingTableAdapter = null;
            this.tableAdapterManager.SistemTableAdapter = null;
            this.tableAdapterManager.StockGudangTableAdapter = null;
            this.tableAdapterManager.stockMovementTableAdapter = null;
            this.tableAdapterManager.StockOpnameTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.SubBeliTableAdapter = null;
            this.tableAdapterManager.SubJualTableAdapter = null;
            this.tableAdapterManager.SubTerimaBarangTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.TerimaBarangTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtangTableAdapter = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Nomor Ref. :";
            // 
            // noRefTxt
            // 
            this.noRefTxt.Location = new System.Drawing.Point(85, 66);
            this.noRefTxt.Name = "noRefTxt";
            this.noRefTxt.Size = new System.Drawing.Size(200, 20);
            this.noRefTxt.TabIndex = 43;
            // 
            // kodeperkiraan
            // 
            this.kodeperkiraan.HeaderText = "Kd. Perkiraan";
            this.kodeperkiraan.Name = "kodeperkiraan";
            this.kodeperkiraan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // namaperkiraan
            // 
            this.namaperkiraan.HeaderText = "Nm. Perkiraan";
            this.namaperkiraan.Name = "namaperkiraan";
            // 
            // debit
            // 
            this.debit.HeaderText = "Debit";
            this.debit.Name = "debit";
            // 
            // kredit
            // 
            this.kredit.HeaderText = "Kredit";
            this.kredit.Name = "kredit";
            // 
            // Modul_Akuntansi_JurnalUmum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 362);
            this.ControlBox = false;
            this.Controls.Add(this.noRefTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.noJurnalTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deskRTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tanggalDTP);
            this.Name = "Modul_Akuntansi_JurnalUmum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jurnal Umum";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Akuntansi_JurnalUmum_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.akunItemDTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tanggalDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox deskRTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView akunItemDTV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox noJurnalTxtBox;
        private System.Windows.Forms.Label crLbl;
        private System.Windows.Forms.Label drLbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_simpan;
        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.AccountTableAdapter accountTableAdapter;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox noRefTxt;
        private System.Windows.Forms.Button delItem;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeperkiraan;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaperkiraan;
        private System.Windows.Forms.DataGridViewTextBoxColumn debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn kredit;
    }
}