using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class NoBon
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_NoBon_SelectAll", parameters, "NoBon");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NoBon)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NoBon",NoBon) 
                };
            return dbo.RunProcedure("sp_NoBon_SelectRow", parameters, "NoBon");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NoBon, DateTime TanggalJam, string Kasir, string KodePelanggan, string NamaPelanggan, float SubTotal, float DiscTotal, float DiscRp, float NilaiFaktur, float BiayaKirim, string Pembayaran, int Term, DateTime TglJT, string StatusPenjualan, float Dibayar, float Kembali, string KodeSalesman, string StatusBon, string NoSJ, string NoBukti, float KomisiSales, int Konsinyasi, string NoResep, string NamaPasien, string AlamatPasien, string KodeDokter, string NamaDokter, string NoBarcode)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBon",NoBon),
					new SqlParameter("TanggalJam",TanggalJam),
					new SqlParameter("Kasir",Kasir),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan),
					new SqlParameter("SubTotal",SubTotal),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("NilaiFaktur",NilaiFaktur),
					new SqlParameter("BiayaKirim",BiayaKirim),
					new SqlParameter("Pembayaran",Pembayaran),
					new SqlParameter("Term",Term),
					new SqlParameter("TglJT",TglJT),
					new SqlParameter("StatusPenjualan",StatusPenjualan),
					new SqlParameter("Dibayar",Dibayar),
					new SqlParameter("Kembali",Kembali),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("StatusBon",StatusBon),
					new SqlParameter("NoSJ",NoSJ),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("KomisiSales",KomisiSales),
					new SqlParameter("Konsinyasi",Konsinyasi),
					new SqlParameter("NoResep",NoResep),
					new SqlParameter("NamaPasien",NamaPasien),
					new SqlParameter("AlamatPasien",AlamatPasien),
					new SqlParameter("KodeDokter",KodeDokter),
					new SqlParameter("NamaDokter",NamaDokter),
					new SqlParameter("NoBarcode",NoBarcode) 
				};
            Result = dbo.RunProcedure("sp_NoBon_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader InsertRow(DateTime TanggalJam, string Kasir, string KodePelanggan, string NamaPelanggan, float SubTotal, float DiscTotal, float DiscRp, float NilaiFaktur, float BiayaKirim, string Pembayaran, int Term, DateTime TglJT, string StatusPenjualan, float Dibayar, float Kembali, string KodeSalesman, string StatusBon, string NoSJ, string NoBukti, float KomisiSales, int Konsinyasi, string NoResep, string NamaPasien, string AlamatPasien, string KodeDokter, string NamaDokter)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("TanggalJam",TanggalJam),
					new SqlParameter("Kasir",Kasir),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan),
					new SqlParameter("SubTotal",SubTotal),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("NilaiFaktur",NilaiFaktur),
					new SqlParameter("BiayaKirim",BiayaKirim),
					new SqlParameter("Pembayaran",Pembayaran),
					new SqlParameter("Term",Term),
					new SqlParameter("TglJT",TglJT),
					new SqlParameter("StatusPenjualan",StatusPenjualan),
					new SqlParameter("Dibayar",Dibayar),
					new SqlParameter("Kembali",Kembali),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("StatusBon",StatusBon),
					new SqlParameter("NoSJ",NoSJ),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("KomisiSales",KomisiSales),
					new SqlParameter("Konsinyasi",Konsinyasi),
					new SqlParameter("NoResep",NoResep),
					new SqlParameter("NamaPasien",NamaPasien),
					new SqlParameter("AlamatPasien",AlamatPasien),
					new SqlParameter("KodeDokter",KodeDokter),
					new SqlParameter("NamaDokter",NamaDokter), 
				};
            sdr = dbo.RunProcedure("sp_NoBon_Insert", parameters);
            return sdr;
        }

        //[DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader JU_SJU_NoBon_Kas_Jual_Piutang(DateTime TanggalKasir,String NamaKasir,String KodePelanggan,String NamaPelanggan, String Tunai_Piutang,DateTime TglJT,String NoResep,String NamaPasien,String AlamatPasien,String KodeDokter,String NamaDokter,double KasNetto,double TotalDiskon,double KasBruto,double dibayar,double kembalian,double PPN)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("TanggalKasir",TanggalKasir),
                    new SqlParameter("NamaKasir",NamaKasir),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan),
					new SqlParameter("Tunai_Piutang",Tunai_Piutang),
					new SqlParameter("TglJT",TglJT),
					new SqlParameter("NoResep",NoResep),
					new SqlParameter("NamaPasien",NamaPasien),
					new SqlParameter("AlamatPasien",AlamatPasien),
					new SqlParameter("KodeDokter",KodeDokter),
                    new SqlParameter("NamaDokter",NamaDokter),
					new SqlParameter("KasNetto",KasNetto),
					new SqlParameter("TotalDiskon",TotalDiskon),
					new SqlParameter("KasBruto",KasBruto),
                    new SqlParameter("Dibayar",dibayar),
                    new SqlParameter("Kembalian",kembalian),
					new SqlParameter("PPN",PPN)
				};
            sdr = dbo.RunProcedure("[dbo].[JU_SJU_NoBon_Kas_Jual_Piutang]", parameters);
            return sdr;
        }

        //[DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader SJU_Stock_SubJual_Racikan(String stockQuery,String subJurnalUmumQuery,String subJualQuery,String racikanQuery,String jasaQuery)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("stockQuery",stockQuery),
                    new SqlParameter("subJurnalUmumQuery",subJurnalUmumQuery),
                    new SqlParameter("subJualQuery",subJualQuery),
                    new SqlParameter("racikanQuery",racikanQuery),
                    new SqlParameter("jasaQuery",jasaQuery)				
                };
            sdr = dbo.RunProcedure("[dbo].[SJU_Stock_SubJual_Racikan]", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NoBon, DateTime TanggalJam, string Kasir, string KodePelanggan, string NamaPelanggan, float SubTotal, float DiscTotal, float DiscRp, float NilaiFaktur, float BiayaKirim, string Pembayaran, int Term, DateTime TglJT, string StatusPenjualan, float Dibayar, float Kembali, string KodeSalesman, string StatusBon, string NoSJ, string NoBukti, float KomisiSales, int Konsinyasi, string NoResep, string NamaPasien, string AlamatPasien, string KodeDokter, string NamaDokter, string NoBarcode)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBon",NoBon),
					new SqlParameter("TanggalJam",TanggalJam),
					new SqlParameter("Kasir",Kasir),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan),
					new SqlParameter("SubTotal",SubTotal),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("NilaiFaktur",NilaiFaktur),
					new SqlParameter("BiayaKirim",BiayaKirim),
					new SqlParameter("Pembayaran",Pembayaran),
					new SqlParameter("Term",Term),
					new SqlParameter("TglJT",TglJT),
					new SqlParameter("StatusPenjualan",StatusPenjualan),
					new SqlParameter("Dibayar",Dibayar),
					new SqlParameter("Kembali",Kembali),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("StatusBon",StatusBon),
					new SqlParameter("NoSJ",NoSJ),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("KomisiSales",KomisiSales),
					new SqlParameter("Konsinyasi",Konsinyasi),
					new SqlParameter("NoResep",NoResep),
					new SqlParameter("NamaPasien",NamaPasien),
					new SqlParameter("AlamatPasien",AlamatPasien),
					new SqlParameter("KodeDokter",KodeDokter),
					new SqlParameter("NamaDokter",NamaDokter),
					new SqlParameter("NoBarcode",NoBarcode) 
				};
            Result = dbo.RunProcedure("sp_NoBon_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NoBon)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBon",NoBon) 
				};
            Result = dbo.RunProcedure("sp_NoBon_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}