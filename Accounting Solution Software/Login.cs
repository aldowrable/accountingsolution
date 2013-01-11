using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Accounting_Solution_Software
{
    public partial class Login : Form
    {
        private tb_Login tbLogin = null;
        public string username = "";
        public string password = "";
        public string levelAccess = "";
        public bool permission = false;
        public DateTime logTime;
        private DataGridView dgv = null;
        private DbObject dbo = new DbObject();

        public Login()
        {
            InitializeComponent();
            tbLogin = new tb_Login();
            button1.Text = "Login";
        }

        public Login(bool permission,DataGridView dgv)
        {
            InitializeComponent();
            tbLogin = new tb_Login();
            button1.Text = "Submit";
            this.dgv = dgv;
        }

        public bool checkPrevilege(string[] previlegePos)
        {
            string whereQuery = " username = '" + username + "' AND ( posID ='" + string.Join("' OR posID = '", previlegePos) + "') AND aktif = 1";
            DataTable dt = dbo.get_all(new string[] { "id" },"view_login_levelaccess_previlege",whereQuery,"","",0,0);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Level akses Anda tidak dapat memproses fungsi ini, silakan hubungi Administrator.");
                return false;
            }
        }

        private void blank_field()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        public void close()
        {
            this.Close();
            this.Dispose();
        }

        public void logout()
        {
            tbLogin.setLogout(this.username, this.password);
            //close();
        }

        private void submitClick()
        {
            if ((txtUsername.Text.CompareTo("") != 0) && (txtPassword.Text.CompareTo("") != 0))
            {

                if (button1.Text.ToLower().CompareTo("login") == 0)
                {
                    SqlDataReader sdr = tbLogin.setLogin(txtUsername.Text, txtPassword.Text);
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            string levelAccess = (string)sdr["level"];
                            this.username = txtUsername.Text;
                            this.password = txtPassword.Text;
                            this.levelAccess = levelAccess;
                            this.logTime = DateTime.Now;
                            blank_field();
                            this.Visible = false;

                            MainForm integrated = new MainForm(this);
                            integrated.Show();

                            //Chooser chooser = new Chooser(this, levelAccess);
                            //chooser.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username dan Password salah.");
                    }
                }
                else if (button1.Text.ToLower().CompareTo("submit") == 0)
                {
                    SqlDataReader sdr = tbLogin.cekLogin(txtUsername.Text, txtPassword.Text);
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            string levelAccess = (string)sdr["level"];
                            if (levelAccess.CompareTo("3") != 0)
                            {
                                dgv.Rows[dgv.CurrentCell.RowIndex].Cells[dgv.CurrentCell.ColumnIndex].ReadOnly = false;
                                dgv.CurrentCell = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[dgv.CurrentCell.ColumnIndex];
                            }
                            else
                            {
                                MessageBox.Show("Level Akses Username tidak di otorisasi.");
                            }
                            blank_field();
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username dan Password salah.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Silakan mengisi Username dan Password");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            submitClick();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                submitClick();
            }
        }
    }
}
