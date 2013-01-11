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
    public partial class Modul_Penjualan_DaftarPiutang : Form
    {
        private MainForm mf = null;

        public Modul_Penjualan_DaftarPiutang()
        {
            InitializeComponent();
        }

        public Modul_Penjualan_DaftarPiutang(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void Modul_Penjualan_DaftarPiutang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'master_Data.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.master_Data.Customer);
            // TODO: This line of code loads data into the 'view2.view_Piutang_all' table. You can move, or remove it, as needed.
            //this.view_Piutang_allTableAdapter.Fill(this.view2.view_Piutang_all);
            this.view_Piutang_allTableAdapter.FillByTop150(this.view2.view_Piutang_all);

        }

        public void refreshDataGridView()
        {
            cariTxt.Text = "";
            blmTerbayarChk.Checked = false;
            this.view_Piutang_allBindingSource.DataMember = "view_Piutang_all";
            this.view_Piutang_allBindingSource.DataSource = this.view2;
            this.view_Piutang_allDataGridView.DataSource = this.view_Piutang_allBindingSource;
            this.view_Piutang_allTableAdapter.Fill(this.view2.view_Piutang_all);
            view_Piutang_allDataGridView.Refresh();
        }

        private void close()
        {
            if(mf != null)
            {
                mf.Enabled = true;
            }
            this.Close();
            this.Dispose();
        }

        private void bayarPiutang(int row, int cell)
        {
            Modul_Penjualan_PembayaranPiutang bayarPiutang = new Modul_Penjualan_PembayaranPiutang(this,view_Piutang_allDataGridView.Rows[row]);
            bayarPiutang.Show();
            this.Enabled = false;
        }

        private void changeFilter()
        {
            string sql = "";
            string subsql = "";

            this.view_Piutang_allTableAdapter.Fill(this.view2.view_Piutang_all);

            if (checkBox3.Checked)
            {
                sql = "KodePelanggan LIKE'%" + statusPembayaranTxt.SelectedValue.ToString() + "%'";
            }

            if (blmTerbayarChk.Checked)
            {
                subsql = "saldo > 0";
                if ((checkBox2.Checked) || (checkBox3.Checked))
                {
                    sql += " AND " + subsql;
                }
                else
                {
                    sql += subsql;
                }
            }

            if (checkBox2.Checked)
            {
                subsql = "Faktur LIKE '%" + cariTxt.Text + "%' OR NamaPelanggan LIKE '%" + cariTxt.Text + "%'";
                if ((checkBox3.Checked) || (blmTerbayarChk.Checked))
                {
                    sql += " AND (" + subsql;
                    sql = sql + ")";
                }
                else
                {
                    sql += subsql;
                }
            }

            if ((!checkBox3.Checked) && (!blmTerbayarChk.Checked) && (!checkBox2.Checked))
            {
                this.view_Piutang_allTableAdapter.FillByTop150(this.view2.view_Piutang_all);
                sql = "";
            }

            view_Piutang_allBindingSource.Filter = sql;
            view_Piutang_allDataGridView.DataSource = view_Piutang_allBindingSource;
            view_Piutang_allDataGridView.Refresh();

        }

        private void cariTxt_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void view_Piutang_allDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex > 0) && (e.RowIndex > 0))
            {
                bayarPiutang(e.RowIndex, e.ColumnIndex);
            }
        }

        private void lihatRincianTxt_Click(object sender, EventArgs e)
        {
            bayarPiutang(view_Piutang_allDataGridView.CurrentCell.RowIndex, view_Piutang_allDataGridView.CurrentCell.ColumnIndex);
        }

        private void view_Piutang_allDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bayarPiutang(view_Piutang_allDataGridView.CurrentCell.RowIndex, view_Piutang_allDataGridView.CurrentCell.ColumnIndex);
            }
        }

        private void keluarBtn_Click(object sender, EventArgs e)
        {
            close();
        }

        private void cariTxt_TextChanged_1(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void statusPembayaranTxt_TextChanged(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            changeFilter();
        }

        private void blmTerbayarChk_Click(object sender, EventArgs e)
        {
            changeFilter();
        }

    }
}
