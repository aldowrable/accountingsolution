using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Cek
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Cek_SelectAll", parameters, "Cek");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NomorCek)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NomorCek",NomorCek) 
                };
            return dbo.RunProcedure("sp_Cek_SelectRow", parameters, "Cek");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NomorCek, DateTime TanggalTitipan, string PemberiCek, float NilaiCek, DateTime TanggalJT, DateTime TanggalCair1, string NoRekening)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorCek",NomorCek),
					new SqlParameter("TanggalTitipan",TanggalTitipan),
					new SqlParameter("PemberiCek",PemberiCek),
					new SqlParameter("NilaiCek",NilaiCek),
					new SqlParameter("TanggalJT",TanggalJT),
					new SqlParameter("TanggalCair1",TanggalCair1),
					new SqlParameter("NoRekening",NoRekening) 
				};
            Result = dbo.RunProcedure("sp_Cek_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NomorCek, DateTime TanggalTitipan, string PemberiCek, float NilaiCek, DateTime TanggalJT, DateTime TanggalCair1, string NoRekening)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorCek",NomorCek),
					new SqlParameter("TanggalTitipan",TanggalTitipan),
					new SqlParameter("PemberiCek",PemberiCek),
					new SqlParameter("NilaiCek",NilaiCek),
					new SqlParameter("TanggalJT",TanggalJT),
					new SqlParameter("TanggalCair1",TanggalCair1),
					new SqlParameter("NoRekening",NoRekening) 
				};
            Result = dbo.RunProcedure("sp_Cek_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NomorCek)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorCek",NomorCek) 
				};
            Result = dbo.RunProcedure("sp_Cek_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}