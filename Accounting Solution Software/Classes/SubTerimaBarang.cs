using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class SubTerimaBarang
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_SubTerimaBarang_SelectAll", parameters, "SubTerimaBarang");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public SqlDataReader SelectRow(string NomorBukti, string KodeBarang)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("KodeBarang",KodeBarang)
                };

            sdr = dbo.RunProcedure("sp_SubTerimaBarang_SelectRow", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public SqlDataReader SelectRow(string NomorBukti)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NomorBukti",NomorBukti)
                };
            sdr = dbo.RunProcedure("sp_SubTerimaBarang_PerNomorBukti_SelectRow", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NomorBukti, float Qty, string KodeBarang, DateTime TglTerima, string StatusTerima)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("Qty",Qty),
					new SqlParameter("KodeBarang",KodeBarang),
					new SqlParameter("TglTerima",TglTerima),
					new SqlParameter("StatusTerima",StatusTerima) 
				};
            Result = dbo.RunProcedure("[dbo].[sp_SubTerimaBarang_Insert]", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, string NomorBukti, float Qty, string KodeBarang, DateTime TglTerima, string StatusTerima,string editOrTerima)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("Qty",Qty),
					new SqlParameter("KodeBarang",KodeBarang),
					new SqlParameter("TglTerima",TglTerima),
					new SqlParameter("StatusTerima",StatusTerima),
                    new SqlParameter("edit_terima",editOrTerima)

				};
            Result = dbo.RunProcedure("[dbo].[SubTerimaBarang_Update]", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string nomorBuktiTerimaBarang)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",nomorBuktiTerimaBarang) 
				};
            Result = dbo.RunProcedure("sp_SubTerimaBarang_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string nomorBuktiTerimaBarang, string KodeBarang)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",nomorBuktiTerimaBarang) ,
                    new SqlParameter("KodeBarang",KodeBarang)
				};
            Result = dbo.RunProcedure("sp_SubTerimaBarang_PerKodeBarang_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}