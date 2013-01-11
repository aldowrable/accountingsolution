namespace Accounting_Solution_Software
{
    partial class Modul_Data_Login
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
            System.Windows.Forms.Label keteranganLevelLabel;
            this.closeBtn = new System.Windows.Forms.Button();
            this.previlege = new Accounting_Solution_Software.Data_set.Previlege();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.PrevilegeTableAdapters.TableAdapterManager();
            this.previlegeTableAdapter = new Accounting_Solution_Software.Data_set.PrevilegeTableAdapters.previlegeTableAdapter();
            this.previlegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addLevelAccessBtn = new System.Windows.Forms.Button();
            this.keteranganLevelComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.previlegeDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.previlegeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.levelAksesTxtBox = new System.Windows.Forms.TextBox();
            keteranganLevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previlege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previlegeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previlegeDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previlegeDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // keteranganLevelLabel
            // 
            keteranganLevelLabel.AutoSize = true;
            keteranganLevelLabel.Location = new System.Drawing.Point(12, 48);
            keteranganLevelLabel.Name = "keteranganLevelLabel";
            keteranganLevelLabel.Size = new System.Drawing.Size(71, 13);
            keteranganLevelLabel.TabIndex = 10;
            keteranganLevelLabel.Text = "Level Akses :";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(693, 558);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "Keluar";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // previlege
            // 
            this.previlege.DataSetName = "Previlege";
            this.previlege.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.levelaccess_previlegeTableAdapter = null;
            this.tableAdapterManager.previlegeTableAdapter = this.previlegeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.PrevilegeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // previlegeTableAdapter
            // 
            this.previlegeTableAdapter.ClearBeforeFill = true;
            // 
            // previlegeBindingSource
            // 
            this.previlegeBindingSource.DataMember = "previlege";
            this.previlegeBindingSource.DataSource = this.previlege;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.simpanBtn);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.removeBtn);
            this.groupBox1.Controls.Add(keteranganLevelLabel);
            this.groupBox1.Controls.Add(this.keteranganLevelComboBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 542);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Kewenangan";
            // 
            // simpanBtn
            // 
            this.simpanBtn.Location = new System.Drawing.Point(668, 509);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(75, 23);
            this.simpanBtn.TabIndex = 15;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(15, 509);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(360, 202);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(46, 34);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "<--";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(360, 260);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(46, 34);
            this.removeBtn.TabIndex = 13;
            this.removeBtn.Text = "-->";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addLevelAccessBtn
            // 
            this.addLevelAccessBtn.Location = new System.Drawing.Point(202, 27);
            this.addLevelAccessBtn.Name = "addLevelAccessBtn";
            this.addLevelAccessBtn.Size = new System.Drawing.Size(42, 23);
            this.addLevelAccessBtn.TabIndex = 12;
            this.addLevelAccessBtn.Text = "+";
            this.addLevelAccessBtn.UseVisualStyleBackColor = true;
            this.addLevelAccessBtn.Click += new System.EventHandler(this.addLevelAccessBtn_Click);
            // 
            // keteranganLevelComboBox
            // 
            this.keteranganLevelComboBox.FormattingEnabled = true;
            this.keteranganLevelComboBox.Location = new System.Drawing.Point(83, 45);
            this.keteranganLevelComboBox.Name = "keteranganLevelComboBox";
            this.keteranganLevelComboBox.Size = new System.Drawing.Size(159, 21);
            this.keteranganLevelComboBox.TabIndex = 11;
            this.keteranganLevelComboBox.ValueMember = "LevelAccess";
            this.keteranganLevelComboBox.SelectionChangeCommitted += new System.EventHandler(this.keteranganLevelComboBox_SelectionChangeCommitted);
            this.keteranganLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.keteranganLevelComboBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.previlegeDGV);
            this.groupBox3.Location = new System.Drawing.Point(15, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 405);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kewenangan";
            // 
            // previlegeDGV
            // 
            this.previlegeDGV.AllowUserToAddRows = false;
            this.previlegeDGV.AllowUserToOrderColumns = true;
            this.previlegeDGV.AllowUserToResizeColumns = false;
            this.previlegeDGV.AllowUserToResizeRows = false;
            this.previlegeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previlegeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.previlegeDGV.Location = new System.Drawing.Point(16, 26);
            this.previlegeDGV.Name = "previlegeDGV";
            this.previlegeDGV.ReadOnly = true;
            this.previlegeDGV.RowHeadersVisible = false;
            this.previlegeDGV.Size = new System.Drawing.Size(302, 360);
            this.previlegeDGV.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kategori";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Modul";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 175;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.previlegeDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(412, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 405);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daftar Modul";
            // 
            // previlegeDataGridView
            // 
            this.previlegeDataGridView.AllowUserToAddRows = false;
            this.previlegeDataGridView.AllowUserToResizeColumns = false;
            this.previlegeDataGridView.AllowUserToResizeRows = false;
            this.previlegeDataGridView.AutoGenerateColumns = false;
            this.previlegeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previlegeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.previlegeDataGridView.DataSource = this.previlegeBindingSource;
            this.previlegeDataGridView.Location = new System.Drawing.Point(15, 26);
            this.previlegeDataGridView.Name = "previlegeDataGridView";
            this.previlegeDataGridView.ReadOnly = true;
            this.previlegeDataGridView.RowHeadersVisible = false;
            this.previlegeDataGridView.Size = new System.Drawing.Size(302, 360);
            this.previlegeDataGridView.TabIndex = 4;
            this.previlegeDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previlegeDataGridView_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "posID";
            this.dataGridViewTextBoxColumn4.HeaderText = "posID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "modul";
            this.dataGridViewTextBoxColumn5.HeaderText = "Kategori";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Modul";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.levelAksesTxtBox);
            this.groupBox4.Controls.Add(this.addLevelAccessBtn);
            this.groupBox4.Location = new System.Drawing.Point(262, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 73);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tambah Level Akses";
            // 
            // levelAksesTxtBox
            // 
            this.levelAksesTxtBox.Location = new System.Drawing.Point(19, 29);
            this.levelAksesTxtBox.Name = "levelAksesTxtBox";
            this.levelAksesTxtBox.Size = new System.Drawing.Size(177, 20);
            this.levelAksesTxtBox.TabIndex = 0;
            // 
            // Modul_Data_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 593);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Data_Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kewenangan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Data_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previlege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previlegeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previlegeDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previlegeDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private Accounting_Solution_Software.Data_set.Previlege previlege;
        private Accounting_Solution_Software.Data_set.PrevilegeTableAdapters.TableAdapterManager tableAdapterManager;
        private Accounting_Solution_Software.Data_set.PrevilegeTableAdapters.previlegeTableAdapter previlegeTableAdapter;
        private System.Windows.Forms.BindingSource previlegeBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addLevelAccessBtn;
        private System.Windows.Forms.ComboBox keteranganLevelComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView previlegeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.DataGridView previlegeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox levelAksesTxtBox;
    }
}