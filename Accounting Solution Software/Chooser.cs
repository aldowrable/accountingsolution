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
    public partial class Chooser : Form
    {
        public Login login = null;
        public Modul_POS posObatBebas = null;
        public Modul_POS_Resep_Dokter posResepDokter = null;
        public Chooser()
        {
            InitializeComponent();
        }

        public Chooser(Login login,string level)
        {
            InitializeComponent();
            this.login = login;

            posObatBebas = new Modul_POS(this.login);
            posResepDokter = new Modul_POS_Resep_Dokter(this.login);
            posObatBebas.setModulResepDokter(posResepDokter);
            posResepDokter.setModulObatBebas(posObatBebas);

            if (level.CompareTo("1") == 0)
            {
                posObatBebasBtn.Visible = true;
                //posResepBtn.Visible = true;
                integratedBtn.Visible = true;
                this.Visible = true;
                
            }
            else
            {
                this.Visible = false;
                posObatBebas.Show();
                //posObatBebasBtn.Visible = true;
                //integratedBtn.Visible = false;
            }
        }

        private void close()
        {
            //this.Close();
            this.Visible = false;
        }

        private void integratedBtn_Click(object sender, EventArgs e)
        {
            MainForm integrated = new MainForm(this.login);
            integrated.Show();
            close();
        }
        
        private void posObatBebasBtn_Click(object sender, EventArgs e)
        {
            posObatBebas.Show();
            close();
        }

        private void posResepBtn_Click(object sender, EventArgs e)
        {   
            posResepDokter.Show();
            close();
        }



    }
}
