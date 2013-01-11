using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class SubBeli
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_SubBeli_SelectAll", parameters, "SubBeli");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_SubBeli_SelectRow", parameters, "SubBeli");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NomorBukti, float Qty, string KodeBarang, float HargaBeli, float Disc, float DiscRp, float SubJumlah, float Jumlah, string Keterangan, DateTime TglTransaksi, DateTime TglPembukuan, string KodeSupplier, float PPn, float PPnRp, float Bulat, DateTime TglKadaluarsa)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("Qty",Qty),
					new SqlParameter("KodeBarang",KodeBarang),
					new SqlParameter("HargaBeli",HargaBeli),
					new SqlParameter("Disc",Disc),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("SubJumlah",SubJumlah),
					new SqlParameter("Jumlah",Jumlah),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("TglPembukuan",TglPembukuan),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("PPn",PPn),
					new SqlParameter("PPnRp",PPnRp),
					new SqlParameter("Bulat",Bulat),
					new SqlParameter("TglKadaluarsa",TglKadaluarsa) 
				};
            Result = dbo.RunProcedure("sp_SubBeli_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, string NomorBukti, float Qty, string KodeBarang, float HargaBeli, float Disc, float DiscRp, float SubJumlah, float Jumlah, string Keterangan, DateTime TglTransaksi, DateTime TglPembukuan, string KodeSupplier, float PPn, float PPnRp, float Bulat, DateTime TglKadaluarsa)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("Qty",Qty),
					new SqlParameter("KodeBarang",KodeBarang),
					new SqlParameter("HargaBeli",HargaBeli),
					new SqlParameter("Disc",Disc),
					new SqlParameter("DiscRp",DiscRp),
					new SqlParameter("SubJumlah",SubJumlah),
					new SqlParameter("Jumlah",Jumlah),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("TglPembukuan",TglPembukuan),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("PPn",PPn),
					new SqlParameter("PPnRp",PPnRp),
					new SqlParameter("Bulat",Bulat),
					new SqlParameter("TglKadaluarsa",TglKadaluarsa) 
				};
            Result = dbo.RunProcedure("sp_SubBeli_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NomorBukti)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti) 
				};
            Result = dbo.RunProcedure("sp_SubBeli_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}