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
    public partial class Modul_Data_Customer : Form
    {
        protected Customer obj = null;
        protected MainForm mf = null;
        private Modul_Customer_PopUp custPopup = null;
        protected String prefix = "customer";

        public Modul_Data_Customer(MainForm mf)
        {
            InitializeComponent();
            obj = new Customer();
            this.mf = mf;
        }

        public Modul_Data_Customer(Modul_Customer_PopUp custPopup)
        {
            InitializeComponent();
            obj = new Customer();
            this.custPopup = custPopup;
        }

        private void blank_field()
        {
            namaPelangganTextBox.Text = "";
            kodePelangganTextBox.Text = "";
            contactPersonTextBox.Text = "";
            alamatTextBox.Text = "";
            kotaComboBox.Text = "";
            telepon1TextBox.Text = "";
            telepon2TextBox.Text = "";
            faxTextBox.Text = "";
            kodePosTextBox.Text = "";
            acc_NoTextBox.Text = "";
            piutangAwalTextBox.Text = "";
            discTotalTextBox.Text = "";
            totalPointTextBox.Text = "";

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
            customerDataGridView.Enabled = true;
            this.customerTableAdapter.Fill(this.master_Data.Customer);
            customerDataGridView.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.master_Data);

        }

        private void Modul_Data_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.master_Data.Kota);
            // TODO: This line of code loads data into the 'master_Data.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.master_Data.Customer);

        }

        private void kodePosTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (btn_reset.Text.CompareTo("Batal")!=0)
            {
                kodePelangganTextBox.ReadOnly = false;
                unreset_field_form();
                customerDataGridView.Enabled = false;
            }
            else
            {
                refresh_data_grid();
                reset_field_form();
            }
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if(mf != null)
            {
                mf.Enabled = true;
            }
            else if(custPopup != null)
            {
                custPopup.Enabled = true;
                custPopup.refreshDataGrid();
            }

            this.Close();
            this.Dispose();
        }

        private void close()
        {

        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silakan klik OK untuk menghapus data ?", "Konfirmasi", MessageBoxButtons.YesNo)
== DialogResult.Yes)
            {
                try
                {
                    obj.DeleteRow(kodePelangganTextBox.Text);
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
                obj.UpdateRow(kodePelangganTextBox.Text, namaPelangganTextBox.Text, contactPersonTextBox.Text, alamatTextBox.Text, kotaComboBox.Text, kodePosTextBox.Text, telepon1TextBox.Text, telepon2TextBox.Text, faxTextBox.Text, "", /*(float)Convert.ToDouble(piutangAwalTextBox.Text)*/0, acc_NoTextBox.Text, 0, 0, 0, "");
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
            String v1 = kodePelangganTextBox.Text;
            String v2 = namaPelangganTextBox.Text;

            if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0))
            {
                try
                {
                    obj.InsertRow(kodePelangganTextBox.Text, namaPelangganTextBox.Text, contactPersonTextBox.Text, alamatTextBox.Text, kotaComboBox.Text, kodePosTextBox.Text, telepon1TextBox.Text, telepon2TextBox.Text, faxTextBox.Text, "", /*(float)Convert.ToDouble(piutangAwalTextBox.Text)*/ 0, acc_NoTextBox.Text, 0, 0, 0, ""); 
      
                    //supplier.InsertRow(kodeSupplier, namaSupplier, txt_contact_person.Text, txt_alamat.Text, txt_kota.Text, txt_kodepos.Text, txt_telepon_1.Text, txt_telepon_2.Text, txt_fax.Text, "", 0, "");
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
