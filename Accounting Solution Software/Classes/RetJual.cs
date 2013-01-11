using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class RetJual
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_RetJual_SelectAll", parameters, "RetJual");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NomorFaktur)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NomorFaktur",NomorFaktur) 
                };
            return dbo.RunProcedure("sp_RetJual_SelectRow", parameters, "RetJual");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NomorFaktur, DateTime TglTransaksi, string KodeSalesman, string NoExFaktur, string KodePelanggan, float SubTotal, float DiscTotal, float DiscRp, float JumlahRetur, string StatusPenjualan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("NoExFaktur",NoExFaktur),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("SubTotal",SubTotal),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("JumlahRetur",JumlahRetur),
					new SqlParameter("StatusPenjualan",StatusPenjualan) 
				};
            Result = dbo.RunProcedure("sp_RetJual_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader InsertRow(DateTime TglTransaksi, string KodeSalesman, string NoExFaktur, string KodePelanggan, float SubTotal, float DiscTotal, float DiscRp, float JumlahRetur, string StatusPenjualan)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorFaktur",""),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("NoExFaktur",NoExFaktur),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("SubTotal",SubTotal),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("JumlahRetur",JumlahRetur),
					new SqlParameter("StatusPenjualan",StatusPenjualan) 
				};
            sdr = dbo.RunProcedure("sp_RetJual_Insert", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NomorFaktur, DateTime TglTransaksi, string KodeSalesman, string NoExFaktur, string KodePelanggan, float SubTotal, float DiscTotal, float DiscRp, float JumlahRetur, string StatusPenjualan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("NoExFaktur",NoExFaktur),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("SubTotal",SubTotal),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("JumlahRetur",JumlahRetur),
					new SqlParameter("StatusPenjualan",StatusPenjualan) 
				};
            Result = dbo.RunProcedure("sp_RetJual_Update", parameters, out RowsAffected);
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
            Result = dbo.RunProcedure("sp_RetJual_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}