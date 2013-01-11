namespace Accounting_Solution_Software
{
    partial class Modul_Penjualan_DaftarPiutang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.view2 = new Accounting_Solution_Software.Data_set.view2();
            this.view_Piutang_allBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Piutang_allTableAdapter = new Accounting_Solution_Software.Data_set.view2TableAdapters.view_Piutang_allTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.view2TableAdapters.TableAdapterManager();
            this.view_Piutang_allDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keluarBtn = new System.Windows.Forms.Button();
            this.lihatRincianTxt = new System.Windows.Forms.Button();
            this.blmTerbayarChk = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.statusPembayaranTxt = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_Data = new Accounting_Solution_Software.Data_set.Master_Data();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerTableAdapter = new Accounting_Solution_Software.Data_set.Master_DataTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.view2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Piutang_allBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Piutang_allDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // view2
            // 
            this.view2.DataSetName = "view2";
            this.view2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_Piutang_allBindingSource
            // 
            this.view_Piutang_allBindingSource.DataMember = "view_Piutang_all";
            this.view_Piutang_allBindingSource.DataSource = this.view2;
            // 
            // view_Piutang_allTableAdapter
            // 
            this.view_Piutang_allTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.view2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_Piutang_allDataGridView
            // 
            this.view_Piutang_allDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.view_Piutang_allDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.view_Piutang_allDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_Piutang_allDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.view_Piutang_allDataGridView.DataSource = this.view_Piutang_allBindingSource;
            this.view_Piutang_allDataGridView.Location = new System.Drawing.Point(9, 120);
            this.view_Piutang_allDataGridView.Name = "view_Piutang_allDataGridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.view_Piutang_allDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.view_Piutang_allDataGridView.RowHeadersVisible = false;
            this.view_Piutang_allDataGridView.Size = new System.Drawing.Size(583, 283);
            this.view_Piutang_allDataGridView.TabIndex = 1;
            this.view_Piutang_allDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_Piutang_allDataGridView_CellDoubleClick);
            this.view_Piutang_allDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.view_Piutang_allDataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "KodePelanggan";
            this.dataGridViewTextBoxColumn1.HeaderText = "Kode Pelanggan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NamaPelanggan";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama Pelanggan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FAKTUR";
            this.dataGridViewTextBoxColumn3.HeaderText = "Faktur";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Saldo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Saldo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // keluarBtn
            // 
            this.keluarBtn.Location = new System.Drawing.Point(514, 415);
            this.keluarBtn.Name = "keluarBtn";
            this.keluarBtn.Size = new System.Drawing.Size(75, 23);
            this.keluarBtn.TabIndex = 11;
            this.keluarBtn.Text = "Keluar";
            this.keluarBtn.UseVisualStyleBackColor = true;
            this.keluarBtn.Click += new System.EventHandler(this.keluarBtn_Click);
            // 
            // lihatRincianTxt
            // 
            this.lihatRincianTxt.Location = new System.Drawing.Point(426, 415);
            this.lihatRincianTxt.Name = "lihatRincianTxt";
            this.lihatRincianTxt.Size = new System.Drawing.Size(75, 23);
            this.lihatRincianTxt.TabIndex = 12;
            this.lihatRincianTxt.Text = "LihatRincian";
            this.lihatRincianTxt.UseVisualStyleBackColor = true;
            this.lihatRincianTxt.Click += new System.EventHandler(this.lihatRincianTxt_Click);
            // 
            // blmTerbayarChk
            // 
            this.blmTerbayarChk.AutoSize = true;
            this.blmTerbayarChk.Location = new System.Drawing.Point(143, 74);
            this.blmTerbayarChk.Name = "blmTerbayarChk";
            this.blmTerbayarChk.Size = new System.Drawing.Size(126, 17);
            this.blmTerbayarChk.TabIndex = 15;
            this.blmTerbayarChk.Text = "Piutang Belum Lunas";
            this.blmTerbayarChk.UseVisualStyleBackColor = true;
            this.blmTerbayarChk.Click += new System.EventHandler(this.blmTerbayarChk_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.blmTerbayarChk);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.cariTxt);
            this.groupBox4.Controls.Add(this.statusPembayaranTxt);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(10, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 102);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 50);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBox3_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // cariTxt
            // 
            this.cariTxt.Location = new System.Drawing.Point(143, 20);
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Size = new System.Drawing.Size(312, 20);
            this.cariTxt.TabIndex = 16;
            this.cariTxt.TextChanged += new System.EventHandler(this.cariTxt_TextChanged_1);
            // 
            // statusPembayaranTxt
            // 
            this.statusPembayaranTxt.DataSource = this.customerBindingSource;
            this.statusPembayaranTxt.DisplayMember = "NamaPelanggan";
            this.statusPembayaranTxt.FormattingEnabled = true;
            this.statusPembayaranTxt.Location = new System.Drawing.Point(143, 47);
            this.statusPembayaranTxt.Name = "statusPembayaranTxt";
            this.statusPembayaranTxt.Size = new System.Drawing.Size(121, 21);
            this.statusPembayaranTxt.TabIndex = 6;
            this.statusPembayaranTxt.ValueMember = "KodePelanggan";
            this.statusPembayaranTxt.TextChanged += new System.EventHandler(this.statusPembayaranTxt_TextChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.master_Data;
            // 
            // master_Data
            // 
            this.master_Data.DataSetName = "Master_Data";
            this.master_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cari ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pelanggan";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // Modul_Penjualan_DaftarPiutang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 444);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.keluarBtn);
            this.Controls.Add(this.lihatRincianTxt);
            this.Controls.Add(this.view_Piutang_allDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Penjualan_DaftarPiutang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Piutang";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Penjualan_DaftarPiutang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Piutang_allBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_Piutang_allDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Accounting_Solution_Software.Data_set.view2 view2;
        private System.Windows.Forms.BindingSource view_Piutang_allBindingSource;
        private Accounting_Solution_Software.Data_set.view2TableAdapters.view_Piutang_allTableAdapter view_Piutang_allTableAdapter;
        private Accounting_Solution_Software.Data_set.view2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_Piutang_allDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button keluarBtn;
        private System.Windows.Forms.Button lihatRincianTxt;
        private System.Windows.Forms.CheckBox blmTerbayarChk;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.ComboBox statusPembayaranTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Accounting_Solution_Software.Data_set.Master_Data master_Data;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Accounting_Solution_Software.Data_set.Master_DataTableAdapters.CustomerTableAdapter customerTableAdapter;



    }
}