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
    public partial class Modul_Data_SupplierPopUp : Form
    {
        Modul_Pembelian pembelian = null;
        Modul_Pembelian_PurchaseOrder po= null;

        public Modul_Data_SupplierPopUp()
        {
            InitializeComponent();
        }

        public Modul_Data_SupplierPopUp(Modul_Pembelian pembelian)
        {
            InitializeComponent();
            this.pembelian = pembelian;
        }

        public Modul_Data_SupplierPopUp(Modul_Pembelian_PurchaseOrder po)
        {
            InitializeComponent();
            this.po = po;
        }

        private void supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.master_Data);

        }

        private void Modul_Data_SupplierPopUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.master_Data.Supplier);

        }

        private void supplierDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            item_selected();
            close();
        }

        private void supplierDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                item_selected();
                close();
            }

        }

        private void item_selected()
        {
            if(pembelian != null)
            {
                pembelian.addSupplier(new string[] { supplierDataGridView.Rows[supplierDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), supplierDataGridView.Rows[supplierDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString() });
            }
            else if(po != null)
            {
                po.addSupplier(new string[] { supplierDataGridView.Rows[supplierDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), supplierDataGridView.Rows[supplierDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString() });
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            close();
        }

        private void close()
        {
            if (pembelian != null)
            {
                pembelian.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void txt_search_1_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Accounting_Solution_Software.Data_set.Master_Data.SupplierRow> query =
    from supplierData in this.master_Data.Supplier.AsEnumerable()
    where supplierData.Field<String>("kodesupplier").ToLower().Contains(txt_search_1.Text.ToLower()) || supplierData.Field<String>("namasupplier").ToLower().Contains(txt_search_1.Text.ToLower())
    select supplierData;

            supplierDataGridView.DataSource = query.ToList();
            supplierDataGridView.Refresh();
        }
    }
}
