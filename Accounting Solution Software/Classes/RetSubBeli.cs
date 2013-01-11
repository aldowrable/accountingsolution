using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class RetSubBeli
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_RetSubBeli_SelectAll", parameters, "RetSubBeli");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_RetSubBeli_SelectRow", parameters, "RetSubBeli");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NomorFaktur, float Qty, string Satuan, string KodeBarang, float HargaBeli, float Disc, float DiscRp, float SubJumlah, float Jumlah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("Qty",Qty),
					new SqlParameter("Satuan",Satuan),
					new SqlParameter("KodeBarang",KodeBarang),
					new SqlParameter("HargaBeli",HargaBeli),
					new SqlParameter("Disc",Disc),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("SubJumlah",SubJumlah),
					new SqlParameter("Jumlah",Jumlah) 
				};
            Result = dbo.RunProcedure("sp_RetSubBeli_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, string NomorFaktur, float Qty, string Satuan, string KodeBarang, float HargaBeli, float Disc, float DiscRp, float SubJumlah, float Jumlah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("Qty",Qty),
					new SqlParameter("Satuan",Satuan),
					new SqlParameter("KodeBarang",KodeBarang),
					new SqlParameter("HargaBeli",HargaBeli),
					new SqlParameter("Disc",Disc),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("SubJumlah",SubJumlah),
					new SqlParameter("Jumlah",Jumlah) 
				};
            Result = dbo.RunProcedure("sp_RetSubBeli_Update", parameters, out RowsAffected);
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
            Result = dbo.RunProcedure("sp_RetSubBeli_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}