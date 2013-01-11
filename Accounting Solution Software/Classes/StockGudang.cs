using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class StockGudang
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_StockGudang_SelectAll", parameters, "StockGudang");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_StockGudang_SelectRow", parameters, "StockGudang");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string id_gudang, string KodeStock, float jumlah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id_gudang",id_gudang),
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("jumlah",jumlah) 
				};
            Result = dbo.RunProcedure("sp_StockGudang_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, string id_gudang, string KodeStock, float jumlah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("id_gudang",id_gudang),
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("jumlah",jumlah) 
				};
            Result = dbo.RunProcedure("sp_StockGudang_Update", parameters, out RowsAffected);
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
            Result = dbo.RunProcedure("sp_StockGudang_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}