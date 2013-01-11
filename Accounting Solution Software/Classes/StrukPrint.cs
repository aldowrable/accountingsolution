using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
//using Microsoft.PointOfService;
using System.IO;
using System.Globalization;
using System.Data.SqlClient;
using System.Drawing.Printing;


namespace Accounting_Solution_Software
{

    class StrukPrint
    {
        private PrintDocument printDoc = new PrintDocument();
        //PosPrinter m_Printer = null;
        const int MAX_LINE_WIDTHS = 2;
        string strLogicalName = "PosPrinter";
        int paperWidth = 34;
        int marginLeftSubs = 85;
        string strips = "==================================\n";
        string singleStrips = "----------------------------------\n";
        AllFunc allfunc = new AllFunc();
        bool sukses;
        private PrintDocument printDocObatBebas = new PrintDocument();
        private PrintDocument printDocResepDokter = new PrintDocument();
        private PrintDocument printDocGantiOperator = new PrintDocument();

        string noBarcode = "";
        string noNota = "";
        string kasirUsername = "";
        string pelanggan = "";
        string alamat = "";
        DataGridView item = null;
        Double subTotal = 0;
        Double discount = 0;
        Double grandTotal = 0;
        Double dibayar = 0;
        Double kembali = 0;

        string noResep = "";
        string namaPasien = "";
        string namaDokter = "";
        double Jasa = 0;
        double Obat = 0;

        DateTime jamMulai;
        DateTime jamSelesai;
        DataGridView kelompokOmset = null;
        DataGridView piutang = null;
        Double omset = 0;
        Double kasAwal = 0;
        Double penjualanTunai = 0;

        float fontSize = 8.5F;

        public StrukPrint()
        {
            printDocObatBebas.PrintPage += new PrintPageEventHandler(printDoc_obatBebas_PrintPage);
            printDocResepDokter.PrintPage += new PrintPageEventHandler(printDoc_resepDokter_PrintPage);
            printDocGantiOperator.PrintPage += new PrintPageEventHandler(printDoc_gantiOperator_PrintPage);
            System.OperatingSystem osInfo = System.Environment.OSVersion;
            //MessageBox.Show(osInfo.Version.ToString());
            PrinterSettings setttt = new PrinterSettings();
            foreach(string printer in PrinterSettings.InstalledPrinters)
            {
                setttt.PrinterName = printer;
                if (setttt.IsDefaultPrinter)
                {
                    if (printer.ToLower().Contains("220"))
                    {
                        this.fontSize = 8.55F;
                        this.paperWidth = 32;
                        this.strips = "================================\n";
                        this.singleStrips = "--------------------------------\n";
                        this.marginLeftSubs = 90;
                    }
                    else
                    {
                        this.fontSize = 8.5F;
                        this.paperWidth = 34;
                        this.strips = "==================================\n";
                        this.singleStrips = "----------------------------------\n";
                        this.marginLeftSubs = 85;
                    }
                }
            }
        }

        //public void starting()
        //{
        //    try
        //    {
        //        //Create PosExplorer
        //        PosExplorer posExplorer = new PosExplorer();
        //        DeviceInfo deviceInfo = null;

        //        try
        //        {
        //            deviceInfo = posExplorer.GetDevice(DeviceType.PosPrinter, strLogicalName);
        //            m_Printer = (PosPrinter)posExplorer.CreateInstance(deviceInfo);
        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Tidak dapat mencetak bukti , silakan cek koneksi printer.");
        //            return;
        //        }
        //        //m_Printer.Release();
        //        //Open the device
        //        m_Printer.Open();

        //        //Get the exclusive control right for the opened device.
        //        //Then the device is disable from other application.

        //        m_Printer.Claim(1000);

        //        //Enable the device.
        //        m_Printer.DeviceEnabled = true;


        //        m_Printer.MapMode = MapMode.Metric;
        //        //<<<step5>>>--End
        //    }
        //    catch (PosControlException poe)
        //    {
        //        MessageBox.Show("Tidak dapat mencetak bon , silakan cek koneksi printer.");
        //    }
        //}


        //public void closing()
        //{
        //    if (m_Printer != null)
        //    {
        //        try
        //        {
        //            m_Printer.DeviceEnabled = false;
        //            m_Printer.Release();
        //        }
        //        catch (PosControlException)
        //        {
        //        }
        //        finally
        //        {
        //            m_Printer.Close();
        //        }
        //    }
        //}

        //public void releasing()
        //{
        //    try
        //    {
        //        //Create PosExplorer
        //        PosExplorer posExplorer = new PosExplorer();

        //        DeviceInfo deviceInfo = null;

        //        try
        //        {
        //            deviceInfo = posExplorer.GetDevice(DeviceType.PosPrinter, strLogicalName);
        //            m_Printer = (PosPrinter)posExplorer.CreateInstance(deviceInfo);
        //            try
        //            {
        //                m_Printer.DeviceEnabled = false;
        //                m_Printer.Release();
        //            }
        //            catch (PosControlException)
        //            {
        //            }
        //            finally
        //            {
        //                m_Printer.Close();
        //            }

        //        }
        //        catch (Exception)
        //        {
        //            MessageBox.Show("Tidak dapat mencetak bukti pembayaran, silakan cek koneksi printer.");
        //            return;
        //        }

        //    }
        //    catch (PosControlException poe)
        //    {
        //        MessageBox.Show("Tidak dapat mencetak bukti pembayaran, silakan cek koneksi printer." + poe.ToString());
        //    }
        //}

    //    public void testing()
    //    {

    //        try
    //        {
    //            starting();
    //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + "\u001b|2C" + "\u001b|cA"
    //                + "APOTEK YOPE \n");
    //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + "\u001b|2C" + "\u001b|cA"
    //+ "APOTEK YOPE \n");
    //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + "\u001b|2C" + "\u001b|cA"
    //+ "APOTEK YOPE \n");
    //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + "\u001b|2C" + "\u001b|cA"
    //+ "APOTEK YOPE \n");
    //            closing();
    //        }
    //        catch (PosControlException)
    //        {
    //        }
    //    }

        public String MakePrintString(int iLineChars, String strBuf, String strPrice)
        {
            int iSpaces = 0;
            String tab = "";
            try
            {
                iSpaces = iLineChars - (strBuf.Length + strPrice.Length);
                for (int j = 0; j < iSpaces; j++)
                {
                    tab += " ";
                }
            }
            catch (Exception)
            {
            }
            return strBuf + tab + strPrice;
        }

        public String MakePrintString(int iLineChars, String strBuf, String strPrice, String subTotal)
        {
            int iSpaces = 0;
            String tab = "";
            try
            {
                iSpaces = iLineChars - (strBuf.Length + strPrice.Length + subTotal.Length);
                iSpaces = iSpaces / 2;
                for (int j = 0; j < iSpaces; j++)
                {
                    tab += " ";
                }
            }
            catch (Exception)
            {
            }
            return strBuf + tab + strPrice + tab + subTotal;
        }

        //private long GetRecLineChars(ref int[] RecLineChars)
        //{
        //    long lRecLineChars = 0;
        //    long lCount;
        //    int i;

        //    // Calculate the element count.
        //    lCount = m_Printer.RecLineCharsList.GetLength(0);

        //    if (lCount == 0)
        //    {
        //        lRecLineChars = 0;
        //    }
        //    else
        //    {
        //        if (lCount > MAX_LINE_WIDTHS)
        //        {
        //            lCount = MAX_LINE_WIDTHS;
        //        }

        //        for (i = 0; i < lCount; i++)
        //        {
        //            RecLineChars[i] = m_Printer.RecLineCharsList[i];
        //        }

        //        lRecLineChars = lCount;
        //    }

        //    return lRecLineChars;
        //}

        public bool printLaporanGantiOperatorDirectPrint(string noBarcode, string kasirUsername, DateTime jamMulai, DateTime jamSelesai, DataGridView kelompokOmset, DataGridView piutang, Double omset, Double kasAwal, Double penjualanTunai)
        {
            try
            {
                this.kasirUsername = kasirUsername;
                this.jamMulai = jamMulai;
                this.jamSelesai = jamSelesai;
                this.kelompokOmset = kelompokOmset;
                this.piutang = piutang;
                this.omset = omset;
                this.kasAwal = kasAwal;
                this.penjualanTunai = penjualanTunai;
                printDocGantiOperator.Print();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //public bool printLaporanGantiOperator(string noBarcode, string kasirUsername, DateTime jamMulai, DateTime jamSelesai, DataGridView kelompokOmset, DataGridView piutang, Double omset, Double kasAwal, Double penjualanTunai)
        //{
        //    //<<<step2>>>--Start
        //    //Initialization
        //    DateTime nowDate = DateTime.Now;							//System date
        //    DateTimeFormatInfo dateFormat = new DateTimeFormatInfo();	//Date Format
        //    dateFormat.MonthDayPattern = "MMMM";
        //    string strDate = nowDate.ToString("HH:MM:ss dd-mm-yyyy", dateFormat);
        //    string strbcData = noBarcode;//13 characters
        //    int[] RecLineChars = new int[MAX_LINE_WIDTHS] { 0, 0 };
        //    sukses = false;

        //    try
        //    {
        //        starting();
        //        if (m_Printer != null)
        //        {
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + "\u001b|2C" + "\u001b|cA"
        //                + "APOTEK YOPE \n");

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA"
        //                + "JL Raya Lembang NO. 384 \n LEMBANG 40391 \n Telp:(022)2787155 \n");

        //            //<<<step5>>--Start
        //            //Make 2mm speces
        //            //ESC|#uF = Line Feed
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");
        //            //<<<step5>>>-End

        //            m_Printer.PrintNormal(PrinterStation.Receipt, strDate + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Kasir       : " + kasirUsername + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Tanggal     : " + strDate + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Jam Mulai   : " + jamMulai.ToString("dd MMM yyyy HH:mm") + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Jam Selesai : " + jamSelesai.ToString("dd MMM yyyy HH:mm") + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Lama Kerja  : " + jamSelesai.Subtract(jamMulai).ToString() + " \n");
        //            string strPrintData = "";

        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|uC" + "\u001b|200uF");

        //            //Print buying goods
        //            double total = 0.0;
        //            DataGridView dgv = kelompokOmset;

        //            for (int i = 0; i < dgv.Rows.Count; i++)
        //            {
        //                strPrintData = MakePrintString(m_Printer.RecLineChars, dgv.Rows[i].Cells[0].Value.ToString(), dgv.Rows[i].Cells[1].Value.ToString());
        //                m_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + "\n");

        //                //total += Convert.ToDouble();

        //            }

        //            //Make 2mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");
        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");

        //            string omsetStr = "                                     " + allfunc.digit_separated(omset.ToString());
        //            string strKasAwal = "                                     " + allfunc.digit_separated(kasAwal.ToString());
        //            string tot = "                                     " + allfunc.digit_separated((omset + kasAwal).ToString());
        //            omsetStr = omsetStr.Substring(omsetStr.Length - 19);
        //            strKasAwal = strKasAwal.Substring(strKasAwal.Length - 19);
        //            tot = tot.Substring(tot.Length - 19);

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Total Omset :" + omsetStr + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Kas Awal :" + strKasAwal + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Grand Total :" + tot + "\n");

        //            //Make 5mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|500uF");

        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "Rincian Omset");

        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|uC" + "\u001b|200uF");

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Penjualan Kredit / Piutang" + "\n");

        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|uC" + "\u001b|200uF");

        //            double totalPiutang = 0.0;
        //            DataGridView dgv1 = piutang;
        //            for (int i = 0; i < dgv1.Rows.Count; i++)
        //            {
        //                strPrintData = MakePrintString(m_Printer.RecLineChars, dgv1.Rows[i].Cells[0].Value.ToString(), dgv1.Rows[i].Cells[1].Value.ToString());
        //                m_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + "\n");

        //                totalPiutang += Convert.ToDouble(allfunc.remove_separated(dgv1.Rows[i].Cells[1].Value.ToString()));
        //            }

        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");


        //            //Make 2mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");

        //            string penjualanPiutangStr = "                                     " + allfunc.digit_separated(totalPiutang.ToString());
        //            string penjualanTunaiStr = "                                       " + allfunc.digit_separated(penjualanTunai.ToString());

        //            penjualanPiutangStr = penjualanPiutangStr.Substring(penjualanPiutangStr.Length - 19);
        //            penjualanTunaiStr = penjualanTunaiStr.Substring(penjualanTunaiStr.Length - 19);

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Piutang :" + penjualanPiutangStr + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Tunai :" + penjualanTunaiStr + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Total Omset :" + omsetStr + "\n");


        //            //Make 2mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");

        //            //<<<step5>>>--End

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|fP");
        //            //<<<step2>>>--End
        //            sukses = true;
        //        }
        //        closing();
        //        return sukses;
        //    }
        //    catch (PosControlException)
        //    {
        //        return false;
        //        MessageBox.Show("Tidak dapat mencetak struk.");
        //    }

        //}

        private string makeCenter(string text)
        {
            int textWidth = text.Length;
            string tempText = "";
            for (int i = 0; i < (this.paperWidth - textWidth) / 2; i++)
            {
                tempText += " ";
            }
            text = tempText + text + tempText;
            return text;
        }

        private string fullWidth(string textLeft, string textRight)
        {
            string text = "";
            string tempText = "";
            int textLeftWidth = textLeft.Length;
            int textRightWidth = textRight.Length;
            for (int i = 0; i < (this.paperWidth - textLeftWidth - textRightWidth); i++)
            {
                tempText += " ";
            }
            text = textLeft + tempText + textRight;
            return text;
        }

        private string makeRight(string text)
        {
            string tempText = "";
            for (int i = 0; i < (this.paperWidth - text.Length); i++)
            {
                tempText += " ";
            }
            text = tempText + text;
            return text;
        }

        private string makeThreeSection(string text1, string text2, string text3)
        {
            int textWidth = text1.Length + text2.Length + text3.Length;
            string tempText = "";
            string text = "";
            for (int i = 0; i < (this.paperWidth - textWidth) / 2; i++)
            {
                tempText += " ";
            }
            text = text1 + tempText + text2 + tempText + text3;
            return text;
        }

        public void setPrintHeader(PrintPageEventArgs e)
        {
            printHeader("APOTEK YOPE", new string[] { "JL Raya Lembang NO. 384", "LEMBANG 40391", "Telp:(022)2787155" }, e);
        }

        public void printHeader(string title, string[] subtitle, PrintPageEventArgs e)
        {
            string textToPrint = title;

            Font printFont = new Font(FontFamily.GenericSansSerif, 12.0F, FontStyle.Bold);
            int leftMargin = e.MarginBounds.Left - 35;
            int topMargin = e.MarginBounds.Top - 90;
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, leftMargin, topMargin);

            textToPrint = "";

            for (int i = 0; i < subtitle.Length; i++)
            {
                textToPrint += makeCenter(subtitle[i]) + "\n";
            }
            textToPrint += "\n\n";

            printFont = new Font(FontFamily.GenericMonospace, this.fontSize);
            leftMargin = e.MarginBounds.Left - this.marginLeftSubs;
            topMargin = e.MarginBounds.Top - 65;
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, leftMargin, topMargin);
        }

        private void printDoc_obatBebas_PrintPage(Object sender, PrintPageEventArgs e)
        {

            DateTime nowDate = DateTime.Now;							//System date
            DateTimeFormatInfo dateFormat = new DateTimeFormatInfo();	//Date Format
            dateFormat.MonthDayPattern = "MMMM";
            string strDate = nowDate.ToString("HH:MM:ss dd-MMM-yyyy", dateFormat);

            setPrintHeader(e);

            String textToPrint = "";
            textToPrint += strDate + "\n";
            textToPrint += "No. Nota    : " + this.noNota + " \n";
            textToPrint += "Kasir       : " + this.kasirUsername + " \n";
            textToPrint += "Kepada      : " + this.pelanggan + " \n";
            textToPrint += "Alamat      : " + this.alamat + " \n";
            //string strPrintData = "";

            textToPrint += strips;

            for (int i = 0; i < this.item.RowCount; i++)
            {
                textToPrint += this.item.Rows[i].Cells[1].Value.ToString() + " \n";
                double qtyxhargabeli = Convert.ToDouble(this.item.Rows[i].Cells[2].Value.ToString()) * Convert.ToDouble(this.item.Rows[i].Cells[4].Value.ToString());
                textToPrint += makeThreeSection("   " + this.item.Rows[i].Cells[2].Value.ToString() + " x", allfunc.digit_separated(this.item.Rows[i].Cells[4].Value.ToString()), allfunc.digit_separated(qtyxhargabeli.ToString())) + "\n";
            }
            textToPrint += strips;

            string Total = "                                     " + allfunc.digit_separated(this.subTotal.ToString());
            string Discount = "                                     " + allfunc.digit_separated(this.discount.ToString());
            string GrandTotal = "                                     " + allfunc.digit_separated(this.grandTotal.ToString());
            string Dibayar = "                                     " + allfunc.digit_separated(this.dibayar.ToString());
            string Kembali = "                                     " + allfunc.digit_separated(this.kembali.ToString());

            Total = Total.Substring(Total.Length - 19);
            Discount = Discount.Substring(Discount.Length - 19);
            GrandTotal = GrandTotal.Substring(GrandTotal.Length - 19);
            Dibayar = Dibayar.Substring(Dibayar.Length - 19);
            Kembali = Kembali.Substring(Kembali.Length - 19);

            textToPrint += makeRight("Sub Total :" + Total) + "\n";
            textToPrint += makeRight("Discount :" + Discount) + "\n";
            textToPrint += makeRight("Grand Total :" + GrandTotal) + "\n";
            textToPrint += makeRight("Dibayar :" + Dibayar) + "\n";
            textToPrint += makeRight("Kembali :" + Kembali) + "\n\n";

            textToPrint += makeCenter("Terimakasih Atas Kunjungan Anda") + "\n";
            textToPrint += makeCenter("Semoga Lekas Sembuh") + "\n\n\n";

            Font printFont = new Font(FontFamily.GenericMonospace, this.fontSize);
            int leftMargin = e.MarginBounds.Left - this.marginLeftSubs;
            int topMargin = e.MarginBounds.Top - 10;
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, leftMargin, topMargin);
        }

        private void printDoc_resepDokter_PrintPage(Object sender, PrintPageEventArgs e)
        {
            DateTime nowDate = DateTime.Now;							//System date
            DateTimeFormatInfo dateFormat = new DateTimeFormatInfo();	//Date Format
            dateFormat.MonthDayPattern = "MMMM";
            string strDate = nowDate.ToString("HH:MM:ss dd-MMM-yyyy", dateFormat);

            setPrintHeader(e);

            String textToPrint = "";
            textToPrint += strDate + "\n";
            textToPrint += "No. Nota    : " + this.noNota + " \n";
            textToPrint += "Kasir       : " + this.kasirUsername + " \n";
            textToPrint += "Pelanggan   : " + this.pelanggan + " \n";
            textToPrint += "No. Resep   : " + this.noResep + " \n";
            textToPrint += "Nama Pasien : " + this.namaPasien + " \n";
            textToPrint += "Nama Dokter : " + this.namaDokter + " \n";

            textToPrint += strips;

            textToPrint += fullWidth("Jasa", allfunc.digit_separated(this.Jasa.ToString())) + " \n";
            textToPrint += fullWidth("Obat", allfunc.digit_separated(this.Obat.ToString())) + " \n";

            textToPrint += strips;

            string Total = "                                     " + allfunc.digit_separated(this.subTotal.ToString());
            string Discount = "                                     " + allfunc.digit_separated(this.discount.ToString());
            string GrandTotal = "                                     " + allfunc.digit_separated(this.grandTotal.ToString());
            string Dibayar = "                                     " + allfunc.digit_separated(this.dibayar.ToString());
            string Kembali = "                                     " + allfunc.digit_separated(this.kembali.ToString());

            Total = Total.Substring(Total.Length - 19);
            Discount = Discount.Substring(Discount.Length - 19);
            GrandTotal = GrandTotal.Substring(GrandTotal.Length - 19);
            Dibayar = Dibayar.Substring(Dibayar.Length - 19);
            Kembali = Kembali.Substring(Kembali.Length - 19);

            textToPrint += makeRight("Sub Total :" + Total) + "\n";
            textToPrint += makeRight("Discount :" + Discount) + "\n";
            textToPrint += makeRight("Grand Total :" + GrandTotal) + "\n";
            textToPrint += makeRight("Dibayar :" + Dibayar) + "\n";
            textToPrint += makeRight("Kembali :" + Kembali) + "\n\n";

            textToPrint += makeCenter("Terimakasih Atas Kunjungan Anda") + "\n";
            textToPrint += makeCenter("Semoga Lekas Sembuh") + "\n\n\n";

            Font printFont = new Font(FontFamily.GenericMonospace, this.fontSize);
            int leftMargin = e.MarginBounds.Left - this.marginLeftSubs;
            int topMargin = e.MarginBounds.Top - 10;
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, leftMargin, topMargin);
        }

        private void printDoc_gantiOperator_PrintPage(Object sender, PrintPageEventArgs e)
        {
            DateTime nowDate = DateTime.Now;							//System date
            DateTimeFormatInfo dateFormat = new DateTimeFormatInfo();	//Date Format
            dateFormat.MonthDayPattern = "MMMM";
            string strDate = nowDate.ToString("dd-MMM-yyyy", dateFormat);

            setPrintHeader(e);

            String textToPrint = "";
            textToPrint += "Kasir       : " + this.kasirUsername + " \n";
            textToPrint += "Tanggal     : " + strDate + "\n";
            textToPrint += "Jam Mulai   : " + this.jamMulai.ToString("dd MMM yyyy HH:mm") + " \n";
            textToPrint += "Jam Selesai : " + this.jamSelesai.ToString("dd MMM yyyy HH:mm") + " \n";
            textToPrint += "Lama Kerja  : " + this.jamSelesai.Subtract(jamMulai).ToString() + " \n";

            textToPrint += strips;


            //            double total = 0.0;
            DataGridView dgv = this.kelompokOmset;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                textToPrint += fullWidth(dgv.Rows[i].Cells[0].Value.ToString(), allfunc.digit_separated(dgv.Rows[i].Cells[1].Value.ToString())) + " \n";
            }

            textToPrint += strips;

            string omsetStr = "                                     " + allfunc.digit_separated(this.omset.ToString());
            string strKasAwal = "                                     " + allfunc.digit_separated(this.kasAwal.ToString());
            string tot = "                                     " + allfunc.digit_separated((this.omset + this.kasAwal).ToString());

            omsetStr = omsetStr.Substring(omsetStr.Length - 19);
            strKasAwal = strKasAwal.Substring(strKasAwal.Length - 19);
            tot = tot.Substring(tot.Length - 19);

            textToPrint += makeRight("Total Omset :" + omsetStr) + "\n";
            textToPrint += makeRight("Kas Awal :" + strKasAwal) + "\n";
            textToPrint += makeRight("Grand Total :" + tot) + "\n\n";

            textToPrint += singleStrips;
            textToPrint += makeCenter("Rincian Omset") + "\n";
            textToPrint += singleStrips;
            textToPrint += "Penjualan Kredit / Piutang" + "\n";
            textToPrint += singleStrips;

            double totalPiutang = 0.0;
            DataGridView dgv1 = this.piutang;
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                textToPrint += fullWidth(dgv1.Rows[i].Cells[0].Value.ToString(), allfunc.digit_separated(dgv1.Rows[i].Cells[1].Value.ToString())) + " \n";
                totalPiutang += Convert.ToDouble(allfunc.remove_separated(dgv1.Rows[i].Cells[1].Value.ToString()));
            }

            textToPrint += singleStrips;

            string penjualanPiutangStr = "                                     " + allfunc.digit_separated(totalPiutang.ToString());
            string penjualanTunaiStr = "                                       " + allfunc.digit_separated(this.penjualanTunai.ToString());

            penjualanPiutangStr = penjualanPiutangStr.Substring(penjualanPiutangStr.Length - 19);
            penjualanTunaiStr = penjualanTunaiStr.Substring(penjualanTunaiStr.Length - 19);

            textToPrint += makeRight("Piutang :" + penjualanPiutangStr) + "\n";
            textToPrint += makeRight("Tunai :" + penjualanTunaiStr) + "\n";
            textToPrint += makeRight("Total Omset :" + omsetStr) + "\n\n\n";

            Font printFont = new Font(FontFamily.GenericMonospace, this.fontSize);
            int leftMargin = e.MarginBounds.Left - this.marginLeftSubs;
            int topMargin = e.MarginBounds.Top - 10;
            e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, leftMargin, topMargin);

        }


        public bool printTransaksiObatBebasDirectPrint(string noBarcode, string noNota, string kasirUsername, string pelanggan, string alamat, DataGridView item, Double subTotal, Double discount, Double grandTotal, Double dibayar, Double kembali)
        {
            try
            {
                this.noBarcode = noBarcode;
                this.noNota = noNota;
                this.kasirUsername = kasirUsername;
                this.pelanggan = pelanggan;
                this.alamat = alamat;
                this.item = item;
                this.subTotal = subTotal;
                this.discount = discount;
                this.grandTotal = grandTotal;
                this.dibayar = dibayar;
                this.kembali = kembali;
                printDocObatBebas.Print();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool printTransaksiResepDirectPrint(string noBarcode, string noNota, string kasirUsername, string pelanggan, string noResep, string namaPasien, string alamat, string namaDokter, Double Jasa, Double Obat, Double subTotal, Double discount, Double grandTotal, Double dibayar, Double kembali)
        {
            try
            {
                this.noBarcode = noBarcode;
                this.noNota = noNota;
                this.kasirUsername = kasirUsername;
                this.pelanggan = pelanggan;
                this.noResep = noResep;
                this.namaPasien = namaPasien;
                this.alamat = alamat;
                this.namaDokter = namaDokter;
                this.Jasa = Jasa;
                this.Obat = Obat;
                this.subTotal = subTotal;
                this.discount = discount;
                this.grandTotal = grandTotal;
                this.dibayar = dibayar;
                this.kembali = kembali;

                printDocResepDokter.Print();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //public bool printTransaksiObatBebas(string noBarcode, string noNota, string kasirUsername, string pelanggan, string alamat, DataGridView item, Double subTotal, Double discount, Double grandTotal, Double dibayar, Double kembali)
        //{

        //    //<<<step2>>>--Start
        //    //Initialization
        //    DateTime nowDate = DateTime.Now;							//System date
        //    DateTimeFormatInfo dateFormat = new DateTimeFormatInfo();	//Date Format
        //    dateFormat.MonthDayPattern = "MMMM";
        //    string strDate = nowDate.ToString("HH:MM:ss dd-MMM-yyyy", dateFormat);
        //    string strbcData = noBarcode;//13 characters
        //    int[] RecLineChars = new int[MAX_LINE_WIDTHS] { 0, 0 };
        //    sukses = false;
        //    try
        //    {
        //        starting();
        //        if (m_Printer != null)
        //        {

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + "\u001b|2C" + "\u001b|cA" + "APOTEK YOPE \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "JL Raya Lembang NO. 384 \n LEMBANG 40391 \n Telp:(022)2787155 \n");

        //            //<<<step5>>--Start
        //            //Make 2mm speces
        //            //ESC|#uF = Line Feed
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");
        //            //<<<step5>>>-End

        //            m_Printer.PrintNormal(PrinterStation.Receipt, strDate + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "No. Nota    : " + noNota + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Kasir       : " + kasirUsername + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Kepada      : " + pelanggan + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Alamat      : " + alamat + " \n");
        //            string strPrintData = "";

        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|uC" + "\u001b|200uF");

        //            //Print buying goods
        //            //SqlDataReader sdr = produk;

        //            //if (sdr != null)
        //            //{
        //            //    while (sdr.Read())
        //            for (int i = 0; i < item.RowCount; i++)
        //            {
        //                m_Printer.PrintNormal(PrinterStation.Receipt, item.Rows[i].Cells[1].Value.ToString() + " \n");
        //                double qtyxhargabeli = Convert.ToDouble(item.Rows[i].Cells[2].Value.ToString()) * Convert.ToDouble(item.Rows[i].Cells[4].Value.ToString());
        //                strPrintData = MakePrintString(m_Printer.RecLineChars, item.Rows[i].Cells[2].Value.ToString() + " x", allfunc.digit_separated(item.Rows[i].Cells[4].Value.ToString()), allfunc.digit_separated(qtyxhargabeli.ToString()));
        //                m_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + "\n");
        //            }
        //            //}
        //            /*if (sdr != null)
        //            {
        //                sdr = jasa;
        //                double tempJml = 0;
        //                while (sdr.Read())
        //                {
        //                    m_Printer.PrintNormal(PrinterStation.Receipt, (string)sdr["NamaJasa"] + " \n");
        //                    tempJml = Convert.ToDouble(allfunc.digit_separated(Convert.ToString((double)sdr["qty"] * (double)sdr["Harga"])));
        //                    strPrintData = MakePrintString(m_Printer.RecLineChars, Convert.ToString((double)sdr["qty"]) + " x", allfunc.digit_separated(Convert.ToString((double)sdr["Harga"])),allfunc.digit_separated(tempJml.ToString()));
        //                    m_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + "\n");

        //                    total += tempJml;

        //                }
        //            }*/


        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");

        //            //Make 2mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");

        //            string Total = "                                     " + allfunc.digit_separated(subTotal.ToString());
        //            string Discount = "                                     " + allfunc.digit_separated(discount.ToString());
        //            string GrandTotal = "                                     " + allfunc.digit_separated(grandTotal.ToString());
        //            string Dibayar = "                                     " + allfunc.digit_separated(dibayar.ToString());
        //            string Kembali = "                                     " + allfunc.digit_separated(kembali.ToString());
        //            Total = Total.Substring(Total.Length - 19);
        //            Discount = Discount.Substring(Discount.Length - 19);
        //            GrandTotal = GrandTotal.Substring(GrandTotal.Length - 19);
        //            Dibayar = Dibayar.Substring(Dibayar.Length - 19);
        //            Kembali = Kembali.Substring(Kembali.Length - 19);

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Sub Total :" + Total + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Discount :" + Discount + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Grand Total :" + GrandTotal + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Dibayar :" + Dibayar + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Kembali :" + Kembali + "\n");

        //            //Make 5mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|500uF");

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "Terimakasih Atas Kunjungan Anda \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "Semoga Lekas Sembuh \n");

        //            //Make 5mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|500uF");

        //            //<<<step4>>>--Start
        //            //if (m_Printer.CapRecBarCode == true)
        //            //{
        //            //Barcode printing
        //            //   m_Printer.PrintBarCode(PrinterStation.Receipt, strbcData,
        //            //       BarCodeSymbology.EanJan13, 1000,
        //            //       m_Printer.RecLineWidth, PosPrinter.PrinterBarCodeLeft,
        //            //       BarCodeTextPosition.Below);
        //            //}
        //            //<<<step4>>>--End
        //            //<<<step5>>>--End

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|fP");
        //            //<<<step2>>>--End
        //            sukses = true;
        //        }
        //        closing();
        //        return sukses;
        //    }
        //    catch (PosControlException)
        //    {
        //        return false;
        //    }
        //}




        //public bool printTransaksiResep(string noBarcode, string noNota, string kasirUsername, string pelanggan, string noResep, string namaPasien, string alamat, string namaDokter, Double Jasa, Double Obat, Double subTotal, Double discount, Double grandTotal, Double dibayar, Double kembali)
        //{
        //    //<<<step2>>>--Start
        //    //Initialization
        //    DateTime nowDate = DateTime.Now;							//System date
        //    DateTimeFormatInfo dateFormat = new DateTimeFormatInfo();	//Date Format
        //    dateFormat.MonthDayPattern = "MMMM";
        //    string strDate = nowDate.ToString("HH:MM:ss dd-mm-yyyy", dateFormat);
        //    string strbcData = noBarcode;//13 characters
        //    int[] RecLineChars = new int[MAX_LINE_WIDTHS] { 0, 0 };
        //    sukses = false;

        //    try
        //    {
        //        starting();
        //        if (m_Printer != null)
        //        {
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|bC" + "\u001b|2C" + "\u001b|cA" + "APOTEK YOPE \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "JL Raya Lembang NO. 384 \n LEMBANG 40391 \n Telp:(022)2787155 \n");

        //            //<<<step5>>--Start
        //            //Make 2mm speces
        //            //ESC|#uF = Line Feed
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");
        //            //<<<step5>>>-End

        //            m_Printer.PrintNormal(PrinterStation.Receipt, strDate + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "No. Nota    : " + noNota + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Kasir       : " + kasirUsername + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Pelanggan   : " + pelanggan + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "No. Resep   : " + noResep + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Nama Pasien : " + namaPasien + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Alamat      : " + alamat + " \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "Nama Dokter : " + namaDokter + " \n");
        //            string strPrintData = "";

        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|uC" + "\u001b|200uF");

        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "Jasa", allfunc.digit_separated(Jasa.ToString()));
        //            m_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + "\n");
        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "Obat", allfunc.digit_separated(Obat.ToString()));
        //            m_Printer.PrintNormal(PrinterStation.Receipt, strPrintData + "\n");

        //            strPrintData = MakePrintString(m_Printer.RecLineChars, "   ", "   ");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|2uC" + strPrintData + "\n");

        //            //Make 2mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|200uF");

        //            string Total = "                                     " + allfunc.digit_separated(subTotal.ToString());
        //            string Discount = "                                     " + allfunc.digit_separated(discount.ToString());
        //            string GrandTotal = "                                     " + allfunc.digit_separated(grandTotal.ToString());
        //            string Dibayar = "                                     " + allfunc.digit_separated(dibayar.ToString());
        //            string Kembali = "                                     " + allfunc.digit_separated(kembali.ToString());
        //            Total = Total.Substring(Total.Length - 19);
        //            Discount = Discount.Substring(Discount.Length - 19);
        //            GrandTotal = GrandTotal.Substring(GrandTotal.Length - 19);
        //            Dibayar = Dibayar.Substring(Dibayar.Length - 19);
        //            Kembali = Kembali.Substring(Kembali.Length - 19);

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Sub Total :" + Total + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Discount :" + Discount + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Grand Total :" + GrandTotal + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Dibayar :" + Dibayar + "\n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|rA" + "Kembali :" + Kembali + "\n");

        //            //Make 5mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|500uF");

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "Terimakasih Atas Kunjungan Anda \n");
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|cA" + "Semoga Lekas Sembuh \n");

        //            //Make 5mm speces
        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|500uF");

        //            //<<<step4>>>--Start
        //            // if (m_Printer.CapRecBarCode == true)
        //            //{
        //            //Barcode printing
        //            //   m_Printer.PrintBarCode(PrinterStation.Receipt, strbcData,
        //            //      BarCodeSymbology.EanJan13, 1000,
        //            //      m_Printer.RecLineWidth, PosPrinter.PrinterBarCodeLeft,
        //            //      BarCodeTextPosition.Below);
        //            //}
        //            //<<<step4>>>--End
        //            //<<<step5>>>--End

        //            m_Printer.PrintNormal(PrinterStation.Receipt, "\u001b|fP");
        //            //<<<step2>>>--End
        //            sukses = true;
        //        }
        //        closing();
        //        return sukses;
        //    }
        //    catch (PosControlException)
        //    {
        //        return false;
        //    }

        //}


    }
}
