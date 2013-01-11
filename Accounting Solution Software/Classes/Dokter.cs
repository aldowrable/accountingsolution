using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Dokter
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Dokter_SelectAll", parameters, "Dokter");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodeDokter)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodeDokter",KodeDokter) 
                };
            return dbo.RunProcedure("sp_Dokter_SelectRow", parameters, "Dokter");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodeDokter, string NamaDokter, string Alamat, string Telepon)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeDokter",KodeDokter),
					new SqlParameter("NamaDokter",NamaDokter),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Telepon",Telepon) 
				};
            Result = dbo.RunProcedure("sp_Dokter_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodeDokter, string NamaDokter, string Alamat, string Telepon)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeDokter",KodeDokter),
					new SqlParameter("NamaDokter",NamaDokter),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Telepon",Telepon) 
				};
            Result = dbo.RunProcedure("sp_Dokter_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodeDokter)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeDokter",KodeDokter) 
				};
            Result = dbo.RunProcedure("sp_Dokter_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}