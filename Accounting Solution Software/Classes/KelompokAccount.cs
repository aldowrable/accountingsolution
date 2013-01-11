using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class KelompokAccount
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_KelompokAccount_SelectAll", parameters, "KelompokAccount");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodeKelompok)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodeKelompok",KodeKelompok) 
                };
            return dbo.RunProcedure("sp_KelompokAccount_SelectRow", parameters, "KelompokAccount");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodeKelompok, string NamaKelompok, string JenisAccount)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeKelompok",KodeKelompok),
					new SqlParameter("NamaKelompok",NamaKelompok),
					new SqlParameter("JenisAccount",JenisAccount) 
				};
            Result = dbo.RunProcedure("sp_KelompokAccount_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodeKelompok, string NamaKelompok, string JenisAccount)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeKelompok",KodeKelompok),
					new SqlParameter("NamaKelompok",NamaKelompok),
					new SqlParameter("JenisAccount",JenisAccount) 
				};
            Result = dbo.RunProcedure("sp_KelompokAccount_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodeKelompok)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeKelompok",KodeKelompok) 
				};
            Result = dbo.RunProcedure("sp_KelompokAccount_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}