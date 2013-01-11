using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class JasaDokter
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_JasaDokter_SelectAll", parameters, "JasaDokter");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodeJasa)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodeJasa",KodeJasa) 
                };
            return dbo.RunProcedure("sp_JasaDokter_SelectRow", parameters, "JasaDokter");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodeJasa, string NamaJasa, float Harga, float Komisi, string KodeDokter)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeJasa",KodeJasa),
					new SqlParameter("NamaJasa",NamaJasa),
					new SqlParameter("Harga",Harga),
					new SqlParameter("Komisi",Komisi),
					new SqlParameter("KodeDokter",KodeDokter) 
				};
            Result = dbo.RunProcedure("sp_JasaDokter_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodeJasa, string NamaJasa, float Harga, float Komisi, string KodeDokter)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeJasa",KodeJasa),
					new SqlParameter("NamaJasa",NamaJasa),
					new SqlParameter("Harga",Harga),
					new SqlParameter("Komisi",Komisi),
					new SqlParameter("KodeDokter",KodeDokter) 
				};
            Result = dbo.RunProcedure("sp_JasaDokter_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodeJasa)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeJasa",KodeJasa) 
				};
            Result = dbo.RunProcedure("sp_JasaDokter_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}