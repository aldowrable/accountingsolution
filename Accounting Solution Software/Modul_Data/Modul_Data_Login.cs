using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Accounting_Solution_Software
{
    public partial class Modul_Data_Login : Form
    {
        protected MainForm mf;
        protected String prefix = "User";
        private DbObject dbo = new DbObject();
        private SqlDataReader sdr = null;
        private DataTable dt = null;

        public Modul_Data_Login(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void blankField()
        {
            eraseDataGrid();
            levelAksesTxtBox.Text = "";
        }

        private void eraseDataGrid()
        {
            try
            {
                previlegeDGV.DataSource = null;
                previlegeDGV.Rows.Clear();
                previlegeDGV.Refresh();
            }
            catch (ArgumentException ae) { }
        }

        private void refreshLevelAkses()
        {
            dt = dbo.get_all(new String[] { "LevelAccess", "KeteranganLevel" }, "LevelAccess","", "LevelAccess", "ASC", 0, 0);

            var items3 = new BindingList<KeyValuePair<string, string>>();

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {
                items3.Add(new KeyValuePair<string, string>(row["LevelAccess"].ToString(), row["KeteranganLevel"].ToString()));
            }

            keteranganLevelComboBox.DataSource = items3;
            keteranganLevelComboBox.ValueMember = "Key";
            keteranganLevelComboBox.DisplayMember = "Value";

        }

        private void editItem(string idLevel)
        {
            blankField();
            dt = dbo.get_all(new String[] { "previlegeID", "modul", "description" }, "View_levelaccess_previlege", "LevelAccessID = '" + idLevel + "'", "previlegeID ASC, modul", "ASC", 0, 0);

            foreach (DataRow row in dt.Rows) // Loop over the rows.
            {
                previlegeDGV.Rows.Add(row.ItemArray);
            }
            previlegeDGV.Refresh();
        }

        private void simpan()
        {
            string spQuery = null;
            spQuery = "EXEC [dbo].[previlege_Delete] '"+ keteranganLevelComboBox.SelectedValue.ToString() +"' ;";
            
            for (int i = 0; i < previlegeDGV.Rows.Count ; i++)
            {
                if (previlegeDGV.Rows[i].Cells[0].Value != null)
                {
                    spQuery += "EXEC [dbo].[previlege_Insert] '" + keteranganLevelComboBox.SelectedValue.ToString() + "'," + previlegeDGV.Rows[i].Cells[0].Value.ToString() + " ;";
                }
            }

            dbo.run_query(spQuery);
            MessageBox.Show("Data Telah Tersimpan.");
            rebindAll();
        }

        private void rebindAll()
        {
            blankField();
            refreshDataGrid();
            editItem(keteranganLevelComboBox.SelectedValue.ToString());
        }

        private void tambahPrevilege()
        {
            string id = previlegeDataGridView.Rows[previlegeDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            string kategori = previlegeDataGridView.Rows[previlegeDataGridView.CurrentRow.Index].Cells[2].Value.ToString();
            string modul = previlegeDataGridView.Rows[previlegeDataGridView.CurrentRow.Index].Cells[3].Value.ToString();
            bool check = true;
            for (int i = 0; i < previlegeDGV.Rows.Count; i++)
            {
                if (previlegeDGV.Rows[i].Cells[0].Value != null)
                {
                    if (previlegeDGV.Rows[i].Cells[0].Value.ToString().CompareTo(id) == 0)
                    {
                        check = false;
                    }
                }
            }
            if (check)
            {
                previlegeDGV.Rows.Add(new String[] { id, kategori, modul });
            }
        }

        private void hapusPrevilege()
        {
            try
            {
                if (previlegeDGV.Rows.Count > 0)
                {
                    previlegeDGV.Rows.RemoveAt(previlegeDGV.CurrentRow.Index);
                    previlegeDGV.Refresh();
                }
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show("Tidak dapat menghapus baris kosong.");
            }
        }

        private void tambahLevelAkses()
        {
            if(levelAksesTxtBox.Text.ToString().CompareTo("")!=0)
            {
                string spQuery = null;
                spQuery = "EXEC [dbo].[level_akses_insert] '" + levelAksesTxtBox.Text + "' ;";
                dbo.run_query(spQuery);
                rebindAll();
                MessageBox.Show("Level Akses Berhasil Ditambahkan.");
            }
        }

        private void Modul_Data_Login_Load(object sender, EventArgs e)
        {
            this.previlegeTableAdapter.Fill(this.previlege.previlege);
            refreshLevelAkses();
            editItem(keteranganLevelComboBox.SelectedValue.ToString());
        }

        private void refreshDataGrid()
        {
            this.previlegeTableAdapter.Fill(this.previlege.previlege);
            refreshLevelAkses();
        }

        private void close()
        {
            mf.Enabled = true;
            this.Close();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            close();
        }

        private void loginBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
                                 

        }

        private void loginDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        
        private void resetBtn_Click(object sender, EventArgs e)
        {
            blankField();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            simpan();
        }

        private void addLevelAccessBtn_Click(object sender, EventArgs e)
        {
            tambahLevelAkses();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            tambahPrevilege();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            hapusPrevilege();
        }

        private void keteranganLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void keteranganLevelComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            editItem(keteranganLevelComboBox.SelectedValue.ToString());
        }

        private void previlegeDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tambahPrevilege();
        }
    }
}
