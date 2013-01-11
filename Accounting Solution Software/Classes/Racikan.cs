using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Racikan
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Racikan_SelectAll", parameters, "Racikan");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_Racikan_SelectRow", parameters, "Racikan");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NoBon, string KodeBarang, string NamaBarang, string KodeRacikan, float QtyRacikan, string Satuan, float HargaJual,float dicount, float discountPersen, string NomorResep, string NamaDokter, DateTime TanggalResep, string NamaPasien, string UmurPasien, float HargaSatuan, string KodePelanggan, string NamaPelanggan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBon",NoBon),
					new SqlParameter("KodeBarang",KodeBarang),
					new SqlParameter("NamaBarang",NamaBarang),
					new SqlParameter("KodeRacikan",KodeRacikan),
					new SqlParameter("QtyRacikan",QtyRacikan),
					new SqlParameter("Satuan",Satuan),
					new SqlParameter("HargaJual",HargaJual),
					new SqlParameter("Discount",dicount),
					new SqlParameter("DiscountPers",discountPersen),
					new SqlParameter("NomorResep",NomorResep),
					new SqlParameter("NamaDokter",NamaDokter),
					new SqlParameter("TanggalResep",TanggalResep),
					new SqlParameter("NamaPasien",NamaPasien),
					new SqlParameter("UmurPasien",UmurPasien),
					new SqlParameter("HargaSatuan",HargaSatuan),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan) 
				};
            Result = dbo.RunProcedure("sp_Racikan_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, string NoBon, string KodeBarang, string NamaBarang, string KodeRacikan, float QtyRacikan, string Satuan, float HargaJual, float dicount, float discountPersen, string NomorResep, string NamaDokter, DateTime TanggalResep, string NamaPasien, string UmurPasien, float HargaSatuan, string KodePelanggan, string NamaPelanggan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("NoBon",NoBon),
					new SqlParameter("KodeBarang",KodeBarang),
					new SqlParameter("NamaBarang",NamaBarang),
					new SqlParameter("KodeRacikan",KodeRacikan),
					new SqlParameter("QtyRacikan",QtyRacikan),
					new SqlParameter("Satuan",Satuan),
					new SqlParameter("HargaJual",HargaJual),
					new SqlParameter("Discount",dicount),
					new SqlParameter("DiscountPers",discountPersen),
					new SqlParameter("NomorResep",NomorResep),
					new SqlParameter("NamaDokter",NamaDokter),
					new SqlParameter("TanggalResep",TanggalResep),
					new SqlParameter("NamaPasien",NamaPasien),
					new SqlParameter("UmurPasien",UmurPasien),
					new SqlParameter("HargaSatuan",HargaSatuan),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan) 
				};
            Result = dbo.RunProcedure("sp_Racikan_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(int id)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id) 
				};
            Result = dbo.RunProcedure("sp_Racikan_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}