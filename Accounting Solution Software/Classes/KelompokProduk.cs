using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class KelompokProduk
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_KelompokProduk_SelectAll", parameters, "KelompokProduk");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodeKelompok)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodeKelompok",KodeKelompok) 
                };
            return dbo.RunProcedure("sp_KelompokProduk_SelectRow", parameters, "KelompokProduk");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodeKelompok, string NamaKelompok, string JenisStock, float D_Sales, string STHarga, int StTuslah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeKelompok",KodeKelompok),
					new SqlParameter("NamaKelompok",NamaKelompok),
					new SqlParameter("JenisStock",JenisStock),
					new SqlParameter("D_Sales",D_Sales),
					new SqlParameter("STHarga",STHarga),
					new SqlParameter("StTuslah",StTuslah) 
				};
            Result = dbo.RunProcedure("sp_KelompokProduk_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodeKelompok, string NamaKelompok, string JenisStock, float D_Sales, string STHarga, int StTuslah)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeKelompok",KodeKelompok),
					new SqlParameter("NamaKelompok",NamaKelompok),
					new SqlParameter("JenisStock",JenisStock),
					new SqlParameter("D_Sales",D_Sales),
					new SqlParameter("STHarga",STHarga),
					new SqlParameter("StTuslah",StTuslah) 
				};
            Result = dbo.RunProcedure("sp_KelompokProduk_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodeKelompok)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeKelompok",KodeKelompok) 
				};
            Result = dbo.RunProcedure("sp_KelompokProduk_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}