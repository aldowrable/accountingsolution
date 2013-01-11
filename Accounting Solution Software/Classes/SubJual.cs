using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class SubJual
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_SubJual_SelectAll", parameters, "SubJual");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_SubJual_SelectRow", parameters, "SubJual");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NoBon, string KodeStock, float Qty, float Harga, float Jumlah, float Discount, float DiscountPersent, float TotalPenjualan, string JenisHarga, int konsinyasi, float Tuslah1, float Tuslah2, float Embalase)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBon",NoBon),
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("Qty",Qty),
					new SqlParameter("Harga",Harga),
					new SqlParameter("Jumlah",Jumlah),
					new SqlParameter("Discount",Discount),
					new SqlParameter("DiscountPersent",DiscountPersent),
					new SqlParameter("TotalPenjualan",TotalPenjualan),
					new SqlParameter("JenisHarga",JenisHarga),
					new SqlParameter("konsinyasi",konsinyasi),
					new SqlParameter("Tuslah1",Tuslah1),
					new SqlParameter("Tuslah2",Tuslah2),
					new SqlParameter("Embalase",Embalase) 
				};
            Result = dbo.RunProcedure("sp_SubJual_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NoBon, string KodeStock, float Qty, float Harga, float Jumlah, float Discount, float DiscountPersent, float TotalPenjualan, string JenisHarga, bool konsinyasi, float Tuslah1, float Tuslah2, float Embalase)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBon",NoBon),
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("Qty",Qty),
					new SqlParameter("Harga",Harga),
					new SqlParameter("Jumlah",Jumlah),
					new SqlParameter("Discount",Discount),
					new SqlParameter("DiscountPersent",DiscountPersent),
					new SqlParameter("TotalPenjualan",TotalPenjualan),
					new SqlParameter("JenisHarga",JenisHarga),
					new SqlParameter("konsinyasi",konsinyasi),
					new SqlParameter("Tuslah1",Tuslah1),
					new SqlParameter("Tuslah2",Tuslah2),
					new SqlParameter("Embalase",Embalase) 
				};
            Result = dbo.RunProcedure("sp_SubJual_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow()
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
 
				};
            Result = dbo.RunProcedure("sp_SubJual_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}