using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Jual
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Jual_SelectAll", parameters, "Jual");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NoBon)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NoBon",NoBon) 
                };
            return dbo.RunProcedure("sp_Jual_SelectRow", parameters, "Jual");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public SqlDataReader getJualTunai(DateTime tanggal,string kasir)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("Tanggal",tanggal),                
					new SqlParameter("Kasir",kasir)
                };
            sdr = dbo.RunProcedure("sp_Jual_Tunai", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NoBon, DateTime Tanggal, float JumlahPenjualan, string Kasir, DateTime Jam, string NoResep, string KodePelanggan, string NamaPelanggan, float DiscTotal, DateTime TanggalJT, string KetRacikan, string KodeDokter)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBon",NoBon),
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("JumlahPenjualan",JumlahPenjualan),
					new SqlParameter("Kasir",Kasir),
					new SqlParameter("Jam",Jam),
					new SqlParameter("NoResep",NoResep),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("TanggalJT",TanggalJT),
					new SqlParameter("KetRacikan",KetRacikan),
					new SqlParameter("KodeDokter",KodeDokter) 
				};
            Result = dbo.RunProcedure("sp_Jual_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NoBon, DateTime Tanggal, float JumlahPenjualan, string Kasir, DateTime Jam, string NoResep, string KodePelanggan, string NamaPelanggan, float DiscTotal, DateTime TanggalJT, string KetRacikan, string KodeDokter)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBon",NoBon),
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("JumlahPenjualan",JumlahPenjualan),
					new SqlParameter("Kasir",Kasir),
					new SqlParameter("Jam",Jam),
					new SqlParameter("NoResep",NoResep),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("TanggalJT",TanggalJT),
					new SqlParameter("KetRacikan",KetRacikan),
					new SqlParameter("KodeDokter",KodeDokter) 
				};
            Result = dbo.RunProcedure("sp_Jual_Update", parameters, out RowsAffected);
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
            Result = dbo.RunProcedure("sp_Jual_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}