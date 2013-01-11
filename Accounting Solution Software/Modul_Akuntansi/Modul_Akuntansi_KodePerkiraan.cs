using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Accounting_Solution_Software
{
    public partial class Modul_Akuntansi_KodePerkiraan : Form
    {
        private MainForm mf = null;
        private Modul_Kas_Besar mkb = null;
        private Modul_Kas_Kecil mkk = null;
        private Modul_Akuntansi_JurnalUmum ju = null;
        private String prefix = "kode perkiraan";
        private List<String> dataPerkiraan = new List<String>();

        public Modul_Akuntansi_KodePerkiraan()
        {
            InitializeComponent();
        }

        public Modul_Akuntansi_KodePerkiraan(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        public Modul_Akuntansi_KodePerkiraan(Modul_Kas_Besar mkb)
        {
            InitializeComponent();
            this.mkb = mkb;
        }

        public Modul_Akuntansi_KodePerkiraan(Modul_Kas_Kecil mkk)
        {
            InitializeComponent();
            this.mkk = mkk;
        }

        public Modul_Akuntansi_KodePerkiraan(Modul_Akuntansi_JurnalUmum ju)
        {
            InitializeComponent();
            this.ju = ju;
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.accountBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.master_Data);
            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("id "+ prefix +" harus diisi.");
            }

        }

        private void Modul_Akuntansi_KodePerkiraan_Load(object sender, EventArgs e)
        {
            this.accountTableAdapter.Fill(this.master_Data.Account);
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            close();
        }

        private void close()
        {
            if (this.mf != null)
            {
                mf.Enabled = true;
            }
            else if (this.mkb != null)
            {
                this.mkb.Enabled = true;
            }
            else if (this.mkk != null)
            {
                this.mkk.Enabled = true;
            }
            else if (this.ju != null)
            {
                this.ju.Enabled = true;
            }
            Close();
            Dispose();
        }

        private void accountDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                this.accountBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.master_Data);
            }
            catch (NoNullAllowedException nonullallowed_e)
            {
                MessageBox.Show("id " + prefix + " harus diisi.");
            }
        }

        private void accountDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            KodePerkiraanSelectedHandler();
        }

        private void accountDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                KodePerkiraanSelectedHandler();
            }
        }

        private void KodePerkiraanSelectedHandler()
        {
            dataPerkiraan.Add(accountDataGridView.Rows[accountDataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString());
            dataPerkiraan.Add(accountDataGridView.Rows[accountDataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString());
            if (this.mkb != null)
            {
                this.mkb.setKodePerkiraanTextBox(this.dataPerkiraan);
            }
            else if (this.mkk != null)
            {
                this.mkk.setKodePerkiraanTextBox(this.dataPerkiraan);
            }
            else if(this.ju != null)
            {
                this.ju.addAkunItem(this.dataPerkiraan);
            }
            
            close();
        }

    }
}
