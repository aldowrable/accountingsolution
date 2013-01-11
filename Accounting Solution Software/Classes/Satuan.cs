using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Satuan
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Satuan_SelectAll", parameters, "Satuan");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NamaSatuan)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NamaSatuan",NamaSatuan) 
                };
            return dbo.RunProcedure("sp_Satuan_SelectRow", parameters, "Satuan");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NamaSatuan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NamaSatuan",NamaSatuan) 
				};
            Result = dbo.RunProcedure("sp_Satuan_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NamaSatuan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NamaSatuan",NamaSatuan) 
				};
            Result = dbo.RunProcedure("sp_Satuan_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NamaSatuan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NamaSatuan",NamaSatuan) 
				};
            Result = dbo.RunProcedure("sp_Satuan_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}