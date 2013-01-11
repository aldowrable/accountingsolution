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
    public partial class Modul_Pembelian_InputBarangPopup : Form
    {
        private Modul_Pembelian pembelian = null;
        private AllFunc allFunc = null;
        private DbObject dbo = null;
        private DataGridViewRow row = null;

        public Modul_Pembelian_InputBarangPopup(Modul_Pembelian pembelian)
        {
            InitializeComponent();
            this.pembelian = pembelian;
            this.allFunc = new AllFunc();
            this.allFunc.Prefix = "Stock";
            this.dbo = new DbObject();
        }

        public void edit_item_row(DataGridViewRow row)
        {
            this.row = row;
            setForm(this.row);
        }

        private void blank_field()
        {
            kodeBarangTxt.Text = "";
            namaBarangTxt.Text = "";
            qtyTxt.Text = "";
            discountTxt.Text = "";
            ppnTxt.Text = "";
            hargaBeliTxt.Text = "";
            subJumlahTxt.Text = "";
            discountRpTxt.Text = "";
            ppnRpTxt.Text = "";
            jumlahTxt.Text = "";
            pembulatanTxt.Text = "";
        }
        private void close()
        {
            pembelian.Enabled = true;
            Close();
            Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((kodeBarangTxt.Text.CompareTo("") == 0) || (namaBarangTxt.Text.CompareTo("") == 0) || (jumlahTxt.Text.CompareTo("") == 0) || (jumlahTxt.Text.CompareTo("0") == 0))
            {
                MessageBox.Show("Silakan mengisi Kode "+ allFunc.Prefix +" ,Nama "+ allFunc.Prefix +", dan perhitungan pembelian "+ allFunc.Prefix +"." );
            }
            else
            {
                            /*
                Kode Barang
                Nama Barang
                Qty
                Satuan
                Harga Beli
                Discount%
                Discount Rp
                PPn %
                PPn Rp
                Pembulatan 
                Grand Total
             */
                if (this.row==null)
                {
                    //string[] items = new string[] { kodeBarangTxt.Text, namaBarangTxt.Text, qtyTxt.Text, satuanTxt.Text, hargaBeliTxt.Text, discountTxt.Text, discountRpTxt.Text, ppnTxt.Text, ppnRpTxt.Text, pembulatanTxt.Text, jumlahTxt.Text ,kadaluarsaDTPicker.Text,jmlStockLamaTxt.Text,hargaBeliStockLamaTxt.Text};
                    string[] items = new string[] { kodeBarangTxt.Text, namaBarangTxt.Text, qtyTxt.Text, satuanTxt.Text, hargaBeliTxt.Text, discountTxt.Text, discountRpTxt.Text, ppnTxt.Text, ppnRpTxt.Text, pembulatanTxt.Text, jumlahTxt.Text, "", jmlStockLamaTxt.Text, hargaBeliStockLamaTxt.Text };
                    pembelian.addItemDataGrid(items);
                }
                else{
                    row.Cells[0].Value = kodeBarangTxt.Text;
                    row.Cells[1].Value = namaBarangTxt.Text;
                    row.Cells[2].Value = qtyTxt.Text;
                    row.Cells[3].Value = satuanTxt.Text;
                    row.Cells[4].Value = allFunc.remove_separated(hargaBeliTxt.Text);
                    row.Cells[5].Value = discountTxt.Text ;
                    row.Cells[6].Value = allFunc.remove_separated(discountRpTxt.Text);
                    row.Cells[7].Value = ppnTxt.Text;
                    row.Cells[8].Value = allFunc.remove_separated(ppnRpTxt.Text);
                    row.Cells[9].Value = allFunc.remove_separated(pembulatanTxt.Text);
                    row.Cells[10].Value = allFunc.remove_separated(jumlahTxt.Text) ;
                    //row.Cells[11].Value = kadaluarsaDTPicker.Text;
                    row.Cells[12].Value = jmlStockLamaTxt.Text;
                    row.Cells[13].Value = hargaBeliStockLamaTxt.Text;
                    pembelian.edit_item_row(row);
                    
                }
                pembelian.calculate();
                close(); 
                
            }
        }

        public void setForm(string[] item)
        {
            kodeBarangTxt.Text = item[0];
            namaBarangTxt.Text = item[1];
            satuanTxt.Text = item[3];
            jmlStockLamaTxt.Text = item[4];
            hargaBeliStockLamaTxt.Text = item[5];
            hargaBeliTxt.Text = item[5];
        }

        public void setForm(DataGridViewRow row)
        {
            kodeBarangTxt.Text = row.Cells[0].Value.ToString();
            namaBarangTxt.Text = row.Cells[1].Value.ToString();
            qtyTxt.Text = row.Cells[2].Value.ToString();
            satuanTxt.Text = row.Cells[3].Value.ToString();
            hargaBeliTxt.Text = row.Cells[4].Value.ToString();
            discountTxt.Text = row.Cells[5].Value.ToString();
            ppnTxt.Text = row.Cells[7].Value.ToString();
            pembulatanTxt.Text = row.Cells[9].Value.ToString();
            //kadaluarsaDTPicker.Value = Convert.ToDateTime(row.Cells[11].Value.ToString());
            SqlDataReader sdr = dbo.get_single_data(new string[]{"jumlahstock","hargabeli"}, "kodestock", row.Cells[0].Value.ToString(), "stock");
            while(sdr.Read())
            {
                jmlStockLamaTxt.Text = Convert.ToString((double)sdr["jumlahstock"]);
                hargaBeliStockLamaTxt.Text = Convert.ToString((double)sdr["hargabeli"]);
            }
            calculate();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void hargaSatuanTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Harga Satuan");
            if (e.KeyData == Keys.Enter)
            {
                calculate();
                discountRpTxt.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pembulatanTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Nilai Pembulatan");
            if (e.KeyData == Keys.Enter)
            {
                calculate();
                button4.Focus();
            }
        }

        private void pembulatanTextBox_Enter(object sender, EventArgs e)
        {
            pembulatanTxt.Text = allFunc.remove_separated(pembulatanTxt.Text);
        }

        private void pembulatanTextBox_Leave(object sender, EventArgs e)
        {
            pembulatanTxt.Text = allFunc.digit_separated(pembulatanTxt.Text);
            calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modul_Barang_CariPopup barangPopup = new Modul_Barang_CariPopup(this);
            barangPopup.Show();
            this.Enabled = false;
        }

        private void ppnTxt_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter_allow_dot(sender, e, "PPN",ppnTxt);
            if (e.KeyData == Keys.Enter)
            {
                calculate();
                hargaBeliTxt.Focus();
            }
        }

        private void discountTxt_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter_allow_dot(sender, e, "Discount",discountTxt);
            if (e.KeyData == Keys.Enter)
            {
                calculate();
                ppnTxt.Focus();
            }
        }

        private void qtyTxt_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Quantity");
            if (e.KeyData == Keys.Enter)
            {
                calculate();
                discountTxt.Focus();
            }
        }

        private void hargaBeliTxt_Enter(object sender, EventArgs e)
        {
            hargaBeliTxt.Text = allFunc.remove_separated(hargaBeliTxt.Text);
        }

        private void hargaBeliTxt_Leave(object sender, EventArgs e)
        {
            hargaBeliTxt.Text = allFunc.digit_separated(hargaBeliTxt.Text);
            calculate();
        }

        private void qtyTxt_Leave(object sender, EventArgs e)
        {
            calculate();
        }

        private void discountTxt_Leave(object sender, EventArgs e)
        {
            calculate();
        }

        private void ppnTxt_Leave(object sender, EventArgs e)
        {
            calculate();
        }
        private void calculate()
        {
            double hargaSatuan = Convert.ToDouble(allFunc.remove_separated(hargaBeliTxt.Text));
            double qty = Convert.ToDouble(allFunc.remove_separated(qtyTxt.Text));
            double ppn = Convert.ToDouble(allFunc.remove_separated(ppnTxt.Text));
            double pembulatan = Convert.ToDouble(allFunc.remove_separated(pembulatanTxt.Text));
            double subJumlah = hargaSatuan * qty;
            subJumlahTxt.Text = allFunc.digit_separated(subJumlah.ToString());
            double discount = Convert.ToDouble(allFunc.remove_separated(discountTxt.Text))*subJumlah/100;
            double discountRp = Convert.ToDouble(allFunc.remove_separated(discountRpTxt.Text));

            if(discount !=0 )
            {
                discountRpTxt.Text = allFunc.digit_separated(discount.ToString());
            }
            else if (discountRp != 0)
            {
                discount = discountRp;
            }

            subJumlah = subJumlah - discount;

            ppn = subJumlah * ppn / 100;

            double grandTotal = subJumlah + ppn + pembulatan;

            ppnRpTxt.Text = allFunc.digit_separated(ppn.ToString());
            jumlahTxt.Text = allFunc.digit_separated(grandTotal.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            close();
        }

        private void ppnRpTxt_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void discountRpTxt_Enter(object sender, EventArgs e)
        {
            discountRpTxt.Text = allFunc.remove_separated(discountRpTxt.Text);
        }

        private void discountRpTxt_KeyDown(object sender, KeyEventArgs e)
        {
            allFunc.digit_filter(sender, e, "Discount");
            if (e.KeyData == Keys.Enter)
            {
                calculate();
                pembulatanTxt.Focus();
            }
        }

        private void discountRpTxt_Leave(object sender, EventArgs e)
        {
            discountRpTxt.Text = allFunc.digit_separated(discountRpTxt.Text);
            calculate();
        }
    }
}
