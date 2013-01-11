using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class RetBeli
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_RetBeli_SelectAll", parameters, "RetBeli");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NomorFaktur)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NomorFaktur",NomorFaktur) 
                };
            return dbo.RunProcedure("sp_RetBeli_SelectRow", parameters, "RetBeli");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NomorFaktur, DateTime TglTransaksi, string KodeSupplier, string NoExFaktur, float SubTotal, float DiscTotal, float DiscRp, float JumlahPembelian)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("NoExFaktur",NoExFaktur),
					new SqlParameter("SubTotal",SubTotal),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("JumlahPembelian",JumlahPembelian) 
				};
            Result = dbo.RunProcedure("sp_RetBeli_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader InsertRow(DateTime TglTransaksi, string KodeSupplier, string NoExFaktur, float SubTotal, float DiscTotal, float DiscRp, float JumlahPembelian)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorFaktur",""),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("NoExFaktur",NoExFaktur),
					new SqlParameter("SubTotal",SubTotal),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("JumlahPembelian",JumlahPembelian) 
				};
            sdr = dbo.RunProcedure("sp_RetBeli_Insert", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NomorFaktur, DateTime TglTransaksi, string KodeSupplier, string NoExFaktur, float SubTotal, float DiscTotal, float DiscRp, float JumlahPembelian)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("NoExFaktur",NoExFaktur),
					new SqlParameter("SubTotal",SubTotal),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("JumlahPembelian",JumlahPembelian) 
				};
            Result = dbo.RunProcedure("sp_RetBeli_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NomorFaktur)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorFaktur",NomorFaktur) 
				};
            Result = dbo.RunProcedure("sp_RetBeli_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}