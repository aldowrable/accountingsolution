namespace Accounting_Solution_Software
{
    partial class Modul_Data_JasaDokter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modul_Data_JasaDokter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.jasaDokterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.jasaDokterBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.jasaDokterDataGridView = new System.Windows.Forms.DataGridView();
            this.HargaBebas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jasaDokterBindingNavigator)).BeginInit();
            this.jasaDokterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jasaDokterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(477, 340);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(75, 23);
            this.btn_keluar.TabIndex = 56;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // jasaDokterBindingNavigator
            // 
            this.jasaDokterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jasaDokterBindingNavigator.CountItem = null;
            this.jasaDokterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jasaDokterBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.jasaDokterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.jasaDokterBindingNavigatorSaveItem});
            this.jasaDokterBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jasaDokterBindingNavigator.MoveFirstItem = null;
            this.jasaDokterBindingNavigator.MoveLastItem = null;
            this.jasaDokterBindingNavigator.MoveNextItem = null;
            this.jasaDokterBindingNavigator.MovePreviousItem = null;
            this.jasaDokterBindingNavigator.Name = "jasaDokterBindingNavigator";
            this.jasaDokterBindingNavigator.PositionItem = null;
            this.jasaDokterBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.jasaDokterBindingNavigator.Size = new System.Drawing.Size(566, 25);
            this.jasaDokterBindingNavigator.TabIndex = 57;
            this.jasaDokterBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // jasaDokterBindingNavigatorSaveItem
            // 
            this.jasaDokterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jasaDokterBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jasaDokterBindingNavigatorSaveItem.Image")));
            this.jasaDokterBindingNavigatorSaveItem.Name = "jasaDokterBindingNavigatorSaveItem";
            this.jasaDokterBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.jasaDokterBindingNavigatorSaveItem.Text = "Save Data";
            this.jasaDokterBindingNavigatorSaveItem.Click += new System.EventHandler(this.jasaDokterBindingNavigatorSaveItem_Click_2);
            // 
            // jasaDokterDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jasaDokterDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jasaDokterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jasaDokterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HargaBebas});
            this.jasaDokterDataGridView.Location = new System.Drawing.Point(12, 38);
            this.jasaDokterDataGridView.Name = "jasaDokterDataGridView";
            this.jasaDokterDataGridView.RowHeadersVisible = false;
            this.jasaDokterDataGridView.Size = new System.Drawing.Size(540, 296);
            this.jasaDokterDataGridView.TabIndex = 57;
            this.jasaDokterDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.jasaDokterDataGridView_DataError);
            this.jasaDokterDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jasaDokterDataGridView_KeyDown);
            this.jasaDokterDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jasaDokterDataGridView_KeyPress);
            // 
            // HargaBebas
            // 
            this.HargaBebas.DataPropertyName = "HargaBebas";
            this.HargaBebas.HeaderText = "Harga Bebas";
            this.HargaBebas.Name = "HargaBebas";
            // 
            // Modul_Data_JasaDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(566, 372);
            this.ControlBox = false;
            this.Controls.Add(this.jasaDokterDataGridView);
            this.Controls.Add(this.jasaDokterBindingNavigator);
            this.Controls.Add(this.btn_keluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modul_Data_JasaDokter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar Jasa Dokter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Modul_Data_JasaDokter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jasaDokterBindingNavigator)).EndInit();
            this.jasaDokterBindingNavigator.ResumeLayout(false);
            this.jasaDokterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jasaDokterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.BindingNavigator jasaDokterBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton jasaDokterBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView jasaDokterDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaBebas;

    }
}