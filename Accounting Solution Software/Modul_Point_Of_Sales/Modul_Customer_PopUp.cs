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
    public partial class Modul_Customer_PopUp : Form
    {
        private Modul_POS pos = null;
        private Modul_POS_Resep_Dokter posResep = null;
        public Modul_Customer_PopUp()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public Modul_Customer_PopUp(Modul_POS pos)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.pos = pos;
        }

        public Modul_Customer_PopUp(Modul_POS_Resep_Dokter posResep)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.posResep = posResep;
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.master_Data);

        }

        private void Modul_Customer_PopUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.master_Data.Customer);

        }

        private void baruBtn_Click(object sender, EventArgs e)
        {
            Modul_Data_Customer customer = new Modul_Data_Customer(this);
            customer.Show();
            this.Enabled = false;
        }

        public void refreshDataGrid()
        {
            this.customerTableAdapter.Fill(this.master_Data.Customer);
            customerDataGridView.Refresh();
        }

        private void close()
        {
            if(pos != null)
            {
                pos.Enabled = true;
            }
            else if (posResep != null)
            {
                posResep.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close();
        }

        private void customerDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectItem();
        }

        private void customerDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                selectItem();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectItem();
        }

        private void selectItem()
        {
            try
            {

                string kode = customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string nama = customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string alamat = customerDataGridView.Rows[customerDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString();

                string[] custDataArr = new string[] { kode, nama, alamat };
                if (pos != null)
                {
                    pos.setCustomer(custDataArr);
                }
                else if (posResep != null)
                {
                    posResep.setCustomer(custDataArr);
                }
            }
            catch (NullReferenceException null_e)
            {
            }
            close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Accounting_Solution_Software.Data_set.Master_Data.CustomerRow> query =
                    from customerData in this.master_Data.Customer.AsEnumerable()
                    where customerData.Field<String>("KodePelanggan").ToLower().Contains(textBox1.Text.ToLower()) || 
                    customerData.Field<String>("NamaPelanggan").ToLower().Contains(textBox1.Text.ToLower())
                    select customerData;

                customerDataGridView.DataSource = query.ToList();
                customerDataGridView.Refresh();
            }
            catch (NullReferenceException null_e)
            {
            }
        }

        private void customerDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void Modul_Customer_PopUp_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    {
                        close();
                        break;
                    }
            }
        }
    }
}
