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
    public partial class Modul_Data_Group : Form
    {
        protected GroupCustomer obj;
        protected MainForm mf;
        protected String prefix = "group customer";

        public Modul_Data_Group(MainForm mf)
        {
            InitializeComponent();
            obj = new GroupCustomer();
            this.mf = mf;
        }

        private void blank_field()
        {
            kodeGroupTextBox.Text = "";
            namaGroupTextBox.Text = "";
            prosMarkUpTextBox.Text = "";
        }
        private void reset_field_form()
        {
            btn_simpan.Enabled = false;
            btn_ubah.Enabled = true;
            btn_hapus.Enabled = true;
            btn_reset.Text = "Reset";
        }

        private void unreset_field_form()
        {
            blank_field();
            btn_simpan.Enabled = true;
            btn_ubah.Enabled = false;
            btn_hapus.Enabled = false;
            btn_reset.Text = "Batal";
        }

        private void refresh_data_grid()
        {
            groupCustomerDataGridView.Enabled = true;
            this.groupCustomerTableAdapter.Fill(this.master_Data.GroupCustomer);
            groupCustomerDataGridView.Refresh();
        }

        private void markupTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            digit_filter(sender, e, "Prosentase Mark Up");
        }

        private void digit_filter(object sender, KeyPressEventArgs e, String str)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Isilah isian " + str + " dengan angka.");
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void groupCustomerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupCustomerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.master_Data);

        }

        private void Modul_Data_Group_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.GroupCustomer' table. You can move, or remove it, as needed.
            this.groupCustomerTableAdapter.Fill(this.master_Data.GroupCustomer);

        }
        private void btn_keluar_Click(object sender, EventArgs e)
        {
            mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (btn_reset.Text.CompareTo("Batal") != 0)
            {
                unreset_field_form();
                groupCustomerDataGridView.Enabled = false;
            }
            else
            {
                refresh_data_grid();
                reset_field_form();
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silakan klik OK untuk menghapus data ?", "Konfirmasi", MessageBoxButtons.YesNo)
== DialogResult.Yes)
            {
                try
                {
                    obj.DeleteRow(kodeGroupTextBox.Text);
                    MessageBox.Show("Data " + prefix + " berhasil dihapus.");
                    refresh_data_grid();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }

            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            try
            {
                obj.UpdateRow(kodeGroupTextBox.Text, namaGroupTextBox.Text, (float)Convert.ToDouble(prosMarkUpTextBox.Text));
                MessageBox.Show("Data " + prefix + " berhasil dirubah.");
                refresh_data_grid();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            String v1 = namaGroupTextBox.Text;

            if (v1.CompareTo("") != 0)
            {
                try
                {
                    obj.InsertRow(namaGroupTextBox.Text, (float)Convert.ToDouble(prosMarkUpTextBox.Text));
                    MessageBox.Show("Data " + prefix + " berhasil ditambahkan.");
                    refresh_data_grid();
                    reset_field_form();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
            }
            else
            {
                MessageBox.Show("Kode " + prefix + " dan Nama " + prefix + " harus terisi.");
            }
        }
    }
}
