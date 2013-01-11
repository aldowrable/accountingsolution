using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class subPurchaseOrder
    {
        DbObject dbo = new DbObject();
		[DataObjectMethod(DataObjectMethodType.Fill)]
		public DataSet SelectAll()
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("subPurchaseOrder_SelectAll", parameters, "subPurchaseOrder");
        }

		[DataObjectMethod(DataObjectMethodType.Fill)]
		public DataSet SelectRow(int id)
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("subPurchaseOrder_SelectRow", parameters, "subPurchaseOrder");
        }

		[DataObjectMethod(DataObjectMethodType.Insert)]
		public int InsertRow(string kodepo,string kodeproduk,float qty,string satuan,float hargabeli)
		{
			int RowsAffected = 0;
			int Result = 0;
			
			SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("kodepo",kodepo),
					new SqlParameter("kodeproduk",kodeproduk),
					new SqlParameter("qty",qty),
					new SqlParameter("satuan",satuan),
					new SqlParameter("hargabeli",hargabeli) 
				};
			Result = dbo.RunProcedure("subPurchaseOrder_Insert", parameters, out RowsAffected);
			return Result;
        }

		[DataObjectMethod(DataObjectMethodType.Update)]
		public int UpdateRow(int id,string kodepo,string kodeproduk,float qty,string satuan,float hargabeli)
		{
			int RowsAffected = 0;
			int Result = 0;
			
			SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("kodepo",kodepo),
					new SqlParameter("kodeproduk",kodeproduk),
					new SqlParameter("qty",qty),
					new SqlParameter("satuan",satuan),
					new SqlParameter("hargabeli",hargabeli) 
				};
			Result = dbo.RunProcedure("subPurchaseOrder_Update", parameters, out RowsAffected);
			return Result;
        }

		[DataObjectMethod(DataObjectMethodType.Delete)]
		public int DeleteRow(int id)
		{
			int RowsAffected = 0;
			int Result = 0;
			
			SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id) 
				};
			Result = dbo.RunProcedure("subPurchaseOrder_DeleteRow", parameters, out RowsAffected);
			return Result;
        }
    }
}