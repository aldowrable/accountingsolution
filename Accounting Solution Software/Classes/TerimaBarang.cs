using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class TerimaBarang
    {
        DbObject dbo = new DbObject();
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_TerimaBarang_SelectAll", parameters, "TerimaBarang");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NomorBukti)
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NomorBukti",NomorBukti) 
                };
            return dbo.RunProcedure("sp_TerimaBarang_SelectRow", parameters, "TerimaBarang");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader InsertRow(string NomorBuktiPembelian, string NomorSJ, string KodeSupplier, string Keterangan)
        {
            SqlDataReader sdr = null;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBuktiPembelian",NomorBuktiPembelian),
					new SqlParameter("NomorSJ",NomorSJ),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("Keterangan",Keterangan) 
				};

            sdr = dbo.RunProcedure("sp_TerimaBarang_Insert", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NomorBukti, string NomorBuktiPembelian, string NomorSJ, string KodeSupplier, string Keterangan)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("NomorBuktiPembelian",NomorBuktiPembelian),
					new SqlParameter("NomorSJ",NomorSJ),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("Keterangan",Keterangan) 
				};
            Result = dbo.RunProcedure("sp_TerimaBarang_Update", parameters, out RowsAffected);
            return Result;
        }

        public SqlDataReader UpdateRow(string NomorBuktiPembelian, string NomorSJ, string KodeSupplier, string Keterangan)
        {
            SqlDataReader sdr = null;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBuktiPembelian",NomorBuktiPembelian),
					new SqlParameter("NomorSJ",NomorSJ),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("Keterangan",Keterangan) 
				};
            sdr = dbo.RunProcedure("sp_TerimaBarang_Update_By_NomorBuktiPembelian", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NomorBukti)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti) 
				};
            Result = dbo.RunProcedure("sp_TerimaBarang_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

        public SqlDataReader generateNoBukti()
        {
            SqlDataReader sdr = null;
            SqlParameter[] parameters = new SqlParameter[] { };
            sdr = dbo.RunProcedure("TerimaBarang_get_noBukti", parameters);
            return sdr;
        }
    }
}