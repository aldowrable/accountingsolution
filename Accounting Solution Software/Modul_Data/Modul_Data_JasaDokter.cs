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
    public partial class Modul_Data_JasaDokter : Form
    {
        private JasaDokter obj;
        private AllFunc allFunc = null ;

        public Modul_Data_JasaDokter(MainForm mf)
        {
            InitializeComponent();
            obj = new JasaDokter();
            allFunc = new AllFunc("jasa dokter", mf);
        }

        public Modul_Data_JasaDokter()
        {
            InitializeComponent();
            obj = new JasaDokter();
            allFunc = new AllFunc("jasa dokter", null);
        }


        private void Modul_Data_JasaDokter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'penjualan_Data.JasaDokter' table. You can move, or remove it, as needed.
            //this.jasaDokterTableAdapter.Fill(this.penjualan_Data.JasaDokter);
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            if (allFunc.Mf != null) { allFunc.Mf.Enabled = true; }
            this.Close();
            this.Dispose();
        }


        private void jasaDokterBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            try{
            this.Validate();
            //this.jasaDokterBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.penjualan_Data);
            }
            catch (NullReferenceException ee)
            {
            }
            catch (ConstraintException ee)
            {
                MessageBox.Show("Duplikasi Kode Jasa, silakan input Kode Jasa yang unik");
            }
        }

        private void jasaDokterDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("dodol1");
           //if((jasaDokterDataGridView.CurrentCell.RowIndex >= 0)&&(jasaDokterDataGridView.CurrentCell.ColumnIndex == 2))
           //{
               //MessageBox.Show("dodol");
               //this.allFunc.digit_filter(sender, e, "harga"); 
           //}
        }

        private void jasaDokterDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                //this.jasaDokterBindingSource.EndEdit();
                //this.tableAdapterManager.UpdateAll(this.penjualan_Data);
            }
            catch (NullReferenceException ee)
            {
            }
            catch (ConstraintException ee)
            {
                MessageBox.Show("Duplikasi Kode Jasa, silakan input Kode Jasa yang unik");
            }
        }

        private void jasaDokterDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("dodol2");
        }
    }
}
