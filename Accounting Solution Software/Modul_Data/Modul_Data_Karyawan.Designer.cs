namespace Accounting_Solution_Software
{
    partial class Modul_Data_Karyawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modul_Data_Karyawan));
            this.loginBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_Data = new Accounting_Solution_Software.Data_set.Login_Data();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.loginBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.loginDataGridView = new System.Windows.Forms.DataGridView();
            this.levelAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infostatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_keluar = new System.Windows.Forms.Button();
            this.loginTableAdapter = new Accounting_Solution_Software.Data_set.Login_DataTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new Accounting_Solution_Software.Data_set.Login_DataTableAdapters.TableAdapterManager();
            this.info_statusTableAdapter = new Accounting_Solution_Software.Data_set.Login_DataTableAdapters.info_statusTableAdapter();
            this.levelAccessTableAdapter = new Accounting_Solution_Software.Data_set.Login_DataTableAdapters.LevelAccessTableAdapter();
            this.infostatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.STKasirAktif = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).BeginInit();
            this.loginBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelAccessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infostatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infostatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBindingNavigator
            // 
            this.loginBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loginBindingNavigator.BindingSource = this.loginBindingSource;
            this.loginBindingNavigator.CountItem = null;
            this.loginBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loginBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.loginBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.loginBindingNavigatorSaveItem});
            this.loginBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loginBindingNavigator.MoveFirstItem = null;
            this.loginBindingNavigator.MoveLastItem = null;
            this.loginBindingNavigator.MoveNextItem = null;
            this.loginBindingNavigator.MovePreviousItem = null;
            this.loginBindingNavigator.Name = "loginBindingNavigator";
            this.loginBindingNavigator.PositionItem = null;
            this.loginBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.loginBindingNavigator.Size = new System.Drawing.Size(827, 25);
            this.loginBindingNavigator.TabIndex = 0;
            this.loginBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.login_Data;
            // 
            // login_Data
            // 
            this.login_Data.DataSetName = "Login_Data";
            this.login_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // loginBindingNavigatorSaveItem
            // 
            this.loginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loginBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("loginBindingNavigatorSaveItem.Image")));
            this.loginBindingNavigatorSaveItem.Name = "loginBindingNavigatorSaveItem";
            this.loginBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.loginBindingNavigatorSaveItem.Text = "Save Data";
            this.loginBindingNavigatorSaveItem.Click += new System.EventHandler(this.loginBindingNavigatorSaveItem_Click_1);
            // 
            // loginDataGridView
            // 
            this.loginDataGridView.AutoGenerateColumns = false;
            this.loginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loginDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.STKasirAktif});
            this.loginDataGridView.DataSource = this.loginBindingSource;
            this.loginDataGridView.Location = new System.Drawing.Point(12, 37);
            this.loginDataGridView.Name = "loginDataGridView";
            this.loginDataGridView.RowHeadersVisible = false;
            this.loginDataGridView.Size = new System.Drawing.Size(803, 354);
            this.loginDataGridView.TabIndex = 1;
            this.loginDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.loginDataGridView_DataError);
            // 
            // levelAccessBindingSource
            // 
            this.levelAccessBindingSource.DataMember = "LevelAccess";
            this.levelAccessBindingSource.DataSource = this.login_Data;
            // 
            // infostatusBindingSource1
            // 
            this.infostatusBindingSource1.DataMember = "info_status";
            this.infostatusBindingSource1.DataSource = this.login_Data;
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(740, 397);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 58;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.info_statusTableAdapter = this.info_statusTableAdapter;
            this.tableAdapterManager.levelaccess_previlegeTableAdapter = null;
            this.tableAdapterManager.LevelAccessTableAdapter = this.levelAccessTableAdapter;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.previlegeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Accounting_Solution_Software.Data_set.Login_DataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // info_statusTableAdapter
            // 
            this.info_statusTableAdapter.ClearBeforeFill = true;
            // 
            // levelAccessTableAdapter
            // 
            this.levelAccessTableAdapter.ClearBeforeFill = true;
            // 
            // infostatusBindingSource
            // 
            this.infostatusBindingSource.DataMember = "info_status";
            this.infostatusBindingSource.DataSource = this.login_Data;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Alamat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Jabatan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Jabatan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "notelp";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telepon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn6.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn7.HeaderText = "Password";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LevelAccess";
            this.dataGridViewTextBoxColumn9.DataSource = this.levelAccessBindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "KeteranganLevel";
            this.dataGridViewTextBoxColumn9.HeaderText = "Level Access";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "LevelAccess";
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // STKasirAktif
            // 
            this.STKasirAktif.DataPropertyName = "STKasirAktif";
            this.STKasirAktif.DataSource = this.infostatusBindingSource1;
            this.STKasirAktif.DisplayMember = "status";
            this.STKasirAktif.HeaderText = "Login Aktif";
            this.STKasirAktif.Name = "STKasirAktif";
            this.STKasirAktif.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STKasirAktif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.STKasirAktif.ValueMember = "id";
            this.STKasirAktif.Width = 75;
            // 
            // Modul_Data_Karyawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 428);
            this.ControlBox = false;
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.loginDataGridView);
            this.Controls.Add(this.loginBindingNavigator);
            this.Name = "Modul_Data_Karyawan";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Karyawan";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Data_Karyawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingNavigator)).EndInit();
            this.loginBindingNavigator.ResumeLayout(false);
            this.loginBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelAccessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infostatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infostatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Accounting_Solution_Software.Data_set.Login_Data login_Data;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Accounting_Solution_Software.Data_set.Login_DataTableAdapters.LoginTableAdapter loginTableAdapter;
        private Accounting_Solution_Software.Data_set.Login_DataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator loginBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton loginBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView loginDataGridView;
        private Accounting_Solution_Software.Data_set.Login_DataTableAdapters.LevelAccessTableAdapter levelAccessTableAdapter;
        private System.Windows.Forms.BindingSource levelAccessBindingSource;
        private System.Windows.Forms.Button btn_keluar;
        private Accounting_Solution_Software.Data_set.Login_DataTableAdapters.info_statusTableAdapter info_statusTableAdapter;
        private System.Windows.Forms.BindingSource infostatusBindingSource;
        private System.Windows.Forms.BindingSource infostatusBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn STKasirAktif;






    }
}