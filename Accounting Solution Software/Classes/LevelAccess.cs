using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class LevelAccess
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_LevelAccess_SelectAll", parameters, "LevelAccess");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string LevelAccess)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("LevelAccess",LevelAccess) 
                };
            return dbo.RunProcedure("sp_LevelAccess_SelectRow", parameters, "LevelAccess");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string LevelAccess, string KeteranganLevel)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("LevelAccess",LevelAccess),
					new SqlParameter("KeteranganLevel",KeteranganLevel) 
				};
            Result = dbo.RunProcedure("sp_LevelAccess_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string LevelAccess, string KeteranganLevel)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("LevelAccess",LevelAccess),
					new SqlParameter("KeteranganLevel",KeteranganLevel) 
				};
            Result = dbo.RunProcedure("sp_LevelAccess_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string LevelAccess)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("LevelAccess",LevelAccess) 
				};
            Result = dbo.RunProcedure("sp_LevelAccess_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}