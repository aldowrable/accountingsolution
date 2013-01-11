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
    public partial class Modul_Data_Salesman : Form
    {
        protected Salesman obj;
        protected MainForm mf;
        protected String prefix = "salesman";

        public Modul_Data_Salesman(MainForm mf)
        {
            InitializeComponent();
            obj = new Salesman();
            this.mf = mf;
        }

        private void blank_field()
        {
            kodeSalesmanTextBox.Text = "";
            namaSalesmanTextBox.Text = "";
            alamatTextBox.Text = "";
            kotaComboBox.Text = "";
            kodePosTextBox.Text = "";
            telepon1TextBox.Text = "";
            telepon2TextBox.Text = "";
            komisiTextBox.Text = "";
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
            salesmanDataGridView.Enabled = true;
            this.salesmanTableAdapter.Fill(this.master_Data.Salesman);
            salesmanDataGridView.Refresh();
        }

        private void komisiTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("Isilah isian komisi dengan angka.");
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void salesmanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesmanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.master_Data);

        }

        private void Modul_Data_Salesman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.master_Data.Kota);
            // TODO: This line of code loads data into the 'master_Data.Salesman' table. You can move, or remove it, as needed.
            this.salesmanTableAdapter.Fill(this.master_Data.Salesman);

        }

        private void kodePosLabel_Click(object sender, EventArgs e)
        {

        }

        private void kodePosTextBox_TextChanged(object sender, EventArgs e)
        {

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
                kodeSalesmanTextBox.ReadOnly = false;
                unreset_field_form();
                salesmanDataGridView.Enabled = false;
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
                    obj.DeleteRow(kodeSalesmanTextBox.Text);
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
                obj.UpdateRow(kodeSalesmanTextBox.Text, namaSalesmanTextBox.Text, alamatTextBox.Text, kotaComboBox.Text, kodePosTextBox.Text, telepon1TextBox.Text, telepon2TextBox.Text, "", (float) Convert.ToDouble(komisiTextBox.Text));
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
            String v1 = kodeSalesmanTextBox.Text;
            String v2 = namaSalesmanTextBox.Text;

            if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0))
            {
                try
                {
                    obj.InsertRow(kodeSalesmanTextBox.Text, namaSalesmanTextBox.Text, alamatTextBox.Text, kotaComboBox.Text, kodePosTextBox.Text, telepon1TextBox.Text, telepon2TextBox.Text, "", (float)Convert.ToDouble(komisiTextBox.Text));
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
