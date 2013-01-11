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
    public partial class Modul_Data_Dokter_PopUp : Form
    {
        private Modul_Pembayaran pembayaran = null;
        private Modul_POS_Resep_Dokter resepDokter = null;

        public Modul_Data_Dokter_PopUp()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public Modul_Data_Dokter_PopUp(Modul_Pembayaran pembayaran)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.pembayaran = pembayaran;
        }

        public Modul_Data_Dokter_PopUp(Modul_POS_Resep_Dokter resepDokter)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.resepDokter = resepDokter;
        }

        private void Modul_Data_Dokter_PopUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Dokter' table. You can move, or remove it, as needed.
            this.dokterTableAdapter.Fill(this.master_Data.Dokter);

        }

        private void selectItem()
        {
            string kode = dokterDataGridView.Rows[dokterDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string nama = dokterDataGridView.Rows[dokterDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
            
            string[] dataDokterArr = new string[] { kode, nama};
            if (pembayaran != null)
            {
                pembayaran.setDataDokter(dataDokterArr);
            }
            else if (resepDokter != null)
            {
                resepDokter.setDataDokter(dataDokterArr);
            }
            close();
        }

        private void close()
        {
            if(pembayaran != null)
            {
                pembayaran.Enabled = true;
            }
            else if (resepDokter != null)
            {
                resepDokter.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Accounting_Solution_Software.Data_set.Master_Data.DokterRow> query =
                    from dokterData in this.master_Data.Dokter.AsEnumerable()
                    where dokterData.Field<String>("KodeDokter").ToLower().Contains(textBox1.Text.ToLower()) ||
                    dokterData.Field<String>("NamaDokter").ToLower().Contains(textBox1.Text.ToLower())
                    select dokterData;

                dokterDataGridView.DataSource = query.ToList();
                dokterDataGridView.Refresh();
            }
            catch (NullReferenceException null_e)
            {
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            selectItem();
        }

        private void Modul_Data_Dokter_PopUp_KeyDown(object sender, KeyEventArgs e)
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
