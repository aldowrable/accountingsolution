using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Budget
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Budget_SelectAll", parameters, "Budget");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_Budget_SelectRow", parameters, "Budget");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(int id, string no_perkiraan, float budget)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("no_perkiraan",no_perkiraan),
					new SqlParameter("budget",budget) 
				};
            Result = dbo.RunProcedure("sp_Budget_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, string no_perkiraan, float budget)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("no_perkiraan",no_perkiraan),
					new SqlParameter("budget",budget) 
				};
            Result = dbo.RunProcedure("sp_Budget_Update", parameters, out RowsAffected);
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
            Result = dbo.RunProcedure("sp_Budget_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}