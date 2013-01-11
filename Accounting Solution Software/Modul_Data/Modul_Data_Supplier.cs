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
    public partial class Modul_Data_Supplier : Form
    {
        protected Supplier obj;
        protected MainForm mf;
        protected String prefix = "supplier";

        public Modul_Data_Supplier(MainForm mf)
        {
            InitializeComponent();
            obj = new Supplier();
            this.mf = mf;
        }

        private void blank_field()
        {
            txt_kode_supplier.Text = "";
            txt_nama_supplier.Text = "";
            txt_alamat.Text = "";
            txt_contact_person_1.Text = "";
            //txt_kodepos.Text = "";
            txt_telepon_1.Text = "";
            txt_telepon_2.Text = "";
            txt_fax.Text = "";
            txt_kota.Text = "";
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
            supplierDataGridView.Enabled = true;
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);
            supplierDataGridView.Refresh();
        }

        private void Modul_Data_Supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);
            // TODO: This line of code loads data into the 'master_Data.Kota' table. You can move, or remove it, as needed.
            this.kotaTableAdapter.Fill(this.master_Data.Kota);            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            String v1 = txt_kode_supplier.Text;
            String v2 = txt_nama_supplier.Text;

            if ((v1.CompareTo("") != 0) && (v2.CompareTo("") != 0))
            {
                try
                {
                    //obj.InsertRow(v1, v2, txt_contact_person_1.Text, txt_alamat.Text, txt_kota.Text, txt_kodepos.Text, txt_telepon_1.Text, txt_telepon_2.Text, txt_fax.Text, "", 0, "");
                    obj.InsertRow(v1, v2, txt_contact_person_1.Text, txt_alamat.Text, txt_kota.Text, "", txt_telepon_1.Text, txt_telepon_2.Text, txt_fax.Text, "", 0, "");
                    MessageBox.Show("Data " + prefix + " berhasil ditambahkan.");
                    refresh_data_grid();
                    reset_field_form();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
            }
            else{
                MessageBox.Show("Kode " + prefix + " dan Nama " + prefix + " harus terisi.");
            }
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            if (btn_reset.Text.CompareTo("Batal")!=0)
            {
                txt_kode_supplier.ReadOnly = false;
                unreset_field_form();
                supplierDataGridView.Enabled = false;
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
                    obj.DeleteRow(txt_kode_supplier.Text);
                    MessageBox.Show("Data " + prefix + " berhasil dihapus.");
                    refresh_data_grid();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }

            }

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {          
            try
            {
                //obj.UpdateRow(txt_kode_supplier.Text, txt_nama_supplier.Text, txt_contact_person_1.Text, txt_alamat.Text, txt_kota.Text, txt_kodepos.Text, txt_telepon_1.Text, txt_telepon_2.Text, txt_fax.Text, "", 0, "");
                obj.UpdateRow(txt_kode_supplier.Text, txt_nama_supplier.Text, txt_contact_person_1.Text, txt_alamat.Text, txt_kota.Text, "", txt_telepon_1.Text, txt_telepon_2.Text, txt_fax.Text, "", 0, "");
                
                MessageBox.Show("Data "+ prefix +" berhasil dirubah.");
                refresh_data_grid();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modul_Laporan_Supplier lap_supp = new Modul_Laporan_Supplier();
            lap_supp.Show();
        }


    }
}
