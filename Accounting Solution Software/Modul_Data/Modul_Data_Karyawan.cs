using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting_Solution_Software
{
    public partial class Modul_Data_Karyawan : Form
    {
        protected String prefix = "karyawan";
        protected MainForm mf;

        public Modul_Data_Karyawan(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }



        private void Modul_Data_Karyawan_Load(object sender, EventArgs e)
        {
            this.info_statusTableAdapter.Fill(this.login_Data.info_status);
            this.levelAccessTableAdapter.Fill(this.login_Data.LevelAccess);
            this.loginTableAdapter.Fill(this.login_Data.Login);
        }

        private void loginBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.login_Data);
                        }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("Nama "+ prefix +" harus diisi.");
            }
            catch (ConstraintException ee)
            {
                MessageBox.Show("Duplikasi id " + prefix + ", silakan input id " + prefix + " yang unik");
            }
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void loginDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                this.loginBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.login_Data);
            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("Nama " + prefix + " harus diisi.");
            }
            catch (ConstraintException ee)
            {
                MessageBox.Show("Duplikasi id " + prefix + ", silakan input id " + prefix + " yang unik");
            }
        }
    }
}
