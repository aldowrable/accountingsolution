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
    public partial class Modul_Data_Gudang : Form
    {
        protected Gudang obj;
        protected MainForm mf;
        protected String prefix = "gudang";

        public Modul_Data_Gudang(MainForm mf)
        {
            InitializeComponent();
            obj = new Gudang();
            this.mf = mf;
        }

        private void blank_field()
        {
            idTextBox.Text = "";
            namaTextBox.Text = "";
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
            gudangDataGridView.Enabled = true;
            this.gudangTableAdapter.Fill(this.master_Data.Gudang);
            gudangDataGridView.Refresh();
        }

        private void gudangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gudangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.master_Data);

        }

        private void Modul_Data_Gudang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Gudang' table. You can move, or remove it, as needed.
            this.gudangTableAdapter.Fill(this.master_Data.Gudang);

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
                idTextBox.ReadOnly = false;
                unreset_field_form();
                gudangDataGridView.Enabled = false;
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
                    obj.DeleteRow(idTextBox.Text);
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
                obj.UpdateRow(idTextBox.Text, namaTextBox.Text);
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
            String v1 = idTextBox.Text;
            String v2 = namaTextBox.Text;

            if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0))
            {
                try
                {
                    obj.InsertRow(idTextBox.Text, namaTextBox.Text);
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
