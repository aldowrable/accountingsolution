using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class GroupCustomer
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_GroupCustomer_SelectAll", parameters, "GroupCustomer");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodeGroup)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodeGroup",KodeGroup) 
                };
            return dbo.RunProcedure("sp_GroupCustomer_SelectRow", parameters, "GroupCustomer");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NamaGroup, float ProsMarkUp)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NamaGroup",NamaGroup),
					new SqlParameter("ProsMarkUp",ProsMarkUp) 
				};
            Result = dbo.RunProcedure("sp_GroupCustomer_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodeGroup, string NamaGroup, float ProsMarkUp)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeGroup",KodeGroup),
					new SqlParameter("NamaGroup",NamaGroup),
					new SqlParameter("ProsMarkUp",ProsMarkUp) 
				};
            Result = dbo.RunProcedure("sp_GroupCustomer_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodeGroup)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeGroup",KodeGroup) 
				};
            Result = dbo.RunProcedure("sp_GroupCustomer_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}