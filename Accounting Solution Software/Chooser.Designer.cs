namespace Accounting_Solution_Software
{
    partial class Chooser
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
            this.integratedBtn = new System.Windows.Forms.Button();
            this.posObatBebasBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integratedBtn
            // 
            this.integratedBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integratedBtn.Location = new System.Drawing.Point(16, 98);
            this.integratedBtn.Name = "integratedBtn";
            this.integratedBtn.Size = new System.Drawing.Size(235, 53);
            this.integratedBtn.TabIndex = 0;
            this.integratedBtn.Text = "Integrated Accounting System";
            this.integratedBtn.UseVisualStyleBackColor = true;
            this.integratedBtn.Click += new System.EventHandler(this.integratedBtn_Click);
            // 
            // posObatBebasBtn
            // 
            this.posObatBebasBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posObatBebasBtn.Location = new System.Drawing.Point(16, 45);
            this.posObatBebasBtn.Name = "posObatBebasBtn";
            this.posObatBebasBtn.Size = new System.Drawing.Size(235, 47);
            this.posObatBebasBtn.TabIndex = 0;
            this.posObatBebasBtn.Text = "Point Of Sales ";
            this.posObatBebasBtn.UseVisualStyleBackColor = true;
            this.posObatBebasBtn.Click += new System.EventHandler(this.posObatBebasBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silakan pilih sistem yang diinginkan";
            // 
            // Chooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 171);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posObatBebasBtn);
            this.Controls.Add(this.integratedBtn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Chooser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selamat Datang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button integratedBtn;
        private System.Windows.Forms.Button posObatBebasBtn;
        private System.Windows.Forms.Label label1;
    }
}