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
    public partial class Modul_Data_Dokter : Form
    {
        protected Dokter dokter;
        protected MainForm mf;
        protected String prefix = "dokter";

        public Modul_Data_Dokter(MainForm mf)
        {
            InitializeComponent();
            dokter = new Dokter();
            this.mf = mf;
        }
        private void blank_field()
        {
            namaDokterTextBox.Text = "";
            kodeDokterTextBox.Text = "";
            alamatTextBox.Text = "";
            teleponTextBox.Text = "";
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
            dokterDataGridView.Enabled = true;
            this.dokterTableAdapter.Fill(this.master_Data.Dokter);
            dokterDataGridView.Refresh();
        }
        private void dokterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dokterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.master_Data);

        }

        private void Modul_Data_Dokter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Dokter' table. You can move, or remove it, as needed.
            this.dokterTableAdapter.Fill(this.master_Data.Dokter);

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
                kodeDokterTextBox.ReadOnly = false;
                unreset_field_form();
                dokterDataGridView.Enabled = false;
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
                    dokter.DeleteRow(kodeDokterTextBox.Text);
                    MessageBox.Show("Data "+ prefix +" berhasil dihapus.");
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
                dokter.UpdateRow(kodeDokterTextBox.Text, namaDokterTextBox.Text, alamatTextBox.Text, teleponTextBox.Text);
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
            String v1 = kodeDokterTextBox.Text;
            String v2 = namaDokterTextBox.Text;

            if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0))
            {
                try
                {
                    dokter.InsertRow(kodeDokterTextBox.Text, namaDokterTextBox.Text, alamatTextBox.Text, teleponTextBox.Text);

                    //supplier.InsertRow(kodeSupplier, namaSupplier, txt_contact_person.Text, txt_alamat.Text, txt_kota.Text, txt_kodepos.Text, txt_telepon_1.Text, txt_telepon_2.Text, txt_fax.Text, "", 0, "");
                    MessageBox.Show("Data "+ prefix +" berhasil ditambahkan.");
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
