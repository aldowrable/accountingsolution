using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class StockHistory
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_StockHistory_SelectAll", parameters, "StockHistory");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_StockHistory_SelectRow", parameters, "StockHistory");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodeProduk, string NoBukti, float Jumlah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeProduk",KodeProduk),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("Jumlah",Jumlah) 
				};
            Result = dbo.RunProcedure("sp_StockHistory_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, string KodeProduk, string NoBukti, float Jumlah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("KodeProduk",KodeProduk),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("Jumlah",Jumlah) 
				};
            Result = dbo.RunProcedure("sp_StockHistory_Update", parameters, out RowsAffected);
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
            Result = dbo.RunProcedure("sp_StockHistory_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}