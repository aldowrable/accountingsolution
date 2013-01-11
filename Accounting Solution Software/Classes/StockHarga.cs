using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class StockHarga
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_StockHarga_SelectAll", parameters, "StockHarga");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_StockHarga_SelectRow", parameters, "StockHarga");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodeStock, float HargaBeli, float jumlah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("HargaBeli",HargaBeli),
					new SqlParameter("jumlah",jumlah) 
				};
            Result = dbo.RunProcedure("sp_StockHarga_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, string KodeStock, float HargaBeli, float jumlah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("HargaBeli",HargaBeli),
					new SqlParameter("jumlah",jumlah) 
				};
            Result = dbo.RunProcedure("sp_StockHarga_Update", parameters, out RowsAffected);
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
            Result = dbo.RunProcedure("sp_StockHarga_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}