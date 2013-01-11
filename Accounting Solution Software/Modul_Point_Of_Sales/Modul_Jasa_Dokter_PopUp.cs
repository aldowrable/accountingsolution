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
    public partial class Modul_Jasa_Dokter_PopUp : Form
    {
        private Modul_POS pos = null;
        private Modul_POS_Resep_Dokter posResep = null;
        public Modul_Jasa_Dokter_PopUp()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public Modul_Jasa_Dokter_PopUp(Modul_POS pos)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.pos = pos;
        }

        public Modul_Jasa_Dokter_PopUp(Modul_POS_Resep_Dokter posResep)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.posResep = posResep;
        }

        private void close()
        {
            if (pos != null)
            {
                pos.Enabled = true;
            }
            else if(posResep != null)
            {
                posResep.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void jasaDokterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jasaDokterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.master_Data);

        }

        private void Modul_Jasa_Dokter_PopUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'view.view_dokter_jasadokter' table. You can move, or remove it, as needed.
            this.view_dokter_jasadokterTableAdapter.Fill(this.view.view_dokter_jasadokter);
            // TODO: This line of code loads data into the 'master_Data.JasaDokter' table. You can move, or remove it, as needed.
            this.jasaDokterTableAdapter.Fill(this.master_Data.JasaDokter);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectItem();
        }

        private void selectItem()
        {
            string kode = view_dokter_jasadokterDataGridView.Rows[view_dokter_jasadokterDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string nama = view_dokter_jasadokterDataGridView.Rows[view_dokter_jasadokterDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string harga = view_dokter_jasadokterDataGridView.Rows[view_dokter_jasadokterDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string kodeDokter = view_dokter_jasadokterDataGridView.Rows[view_dokter_jasadokterDataGridView.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string namaDokter = view_dokter_jasadokterDataGridView.Rows[view_dokter_jasadokterDataGridView.CurrentCell.RowIndex].Cells[5].Value.ToString();

            string[] jasaDokterDataArr = new string[] { kode, nama, harga,kodeDokter,namaDokter };
            if (pos != null)
            {
                pos.setJasaDokter(jasaDokterDataArr);
            }
            else if (posResep != null)
            {
                posResep.setJasaDokter(jasaDokterDataArr);
            }
            close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Accounting_Solution_Software.Data_set.view.view_dokter_jasadokterRow> query =
                    from jasaDokterData in this.view.view_dokter_jasadokter.AsEnumerable()
                    where jasaDokterData.Field<String>("KodeJasa").ToLower().Contains(textBox1.Text.ToLower()) ||
                    jasaDokterData.Field<String>("NamaJasa").ToLower().Contains(textBox1.Text.ToLower())
                    select jasaDokterData;

                view_dokter_jasadokterDataGridView.DataSource = query.ToList();
                view_dokter_jasadokterDataGridView.Refresh();
            }
            catch (NullReferenceException null_e)
            {
            }
        }

        private void view_dokter_jasadokterDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void view_dokter_jasadokterDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                selectItem();
            }

        }

        private void view_dokter_jasadokterDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectItem();
        }

        private void okBtn_KeyDown(object sender, KeyEventArgs e)
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
