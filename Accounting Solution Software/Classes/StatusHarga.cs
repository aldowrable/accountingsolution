using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class StatusHarga
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_StatusHarga_SelectAll", parameters, "StatusHarga");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int IdStatus)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("IdStatus",IdStatus) 
                };
            return dbo.RunProcedure("sp_StatusHarga_SelectRow", parameters, "StatusHarga");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(int IdStatus, string NamaStatus)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("IdStatus",IdStatus),
					new SqlParameter("NamaStatus",NamaStatus) 
				};
            Result = dbo.RunProcedure("sp_StatusHarga_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int IdStatus, string NamaStatus)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("IdStatus",IdStatus),
					new SqlParameter("NamaStatus",NamaStatus) 
				};
            Result = dbo.RunProcedure("sp_StatusHarga_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(int IdStatus)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("IdStatus",IdStatus) 
				};
            Result = dbo.RunProcedure("sp_StatusHarga_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}