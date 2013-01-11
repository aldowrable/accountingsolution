using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Giro
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Giro_SelectAll", parameters, "Giro");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NoBG)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NoBG",NoBG) 
                };
            return dbo.RunProcedure("sp_Giro_SelectRow", parameters, "Giro");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NoBG, string NamaBank, string NoRekening, DateTime TJT, DateTime TGLKeluar, string Untuk, string NamaToko, float NilaiGiro, bool StCair, bool StBatal, string Pribadi, float SaldoJml, string No_Bukti, string Keterangan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBG",NoBG),
					new SqlParameter("NamaBank",NamaBank),
					new SqlParameter("NoRekening",NoRekening),
					new SqlParameter("TJT",TJT),
					new SqlParameter("TGLKeluar",TGLKeluar),
					new SqlParameter("Untuk",Untuk),
					new SqlParameter("NamaToko",NamaToko),
					new SqlParameter("NilaiGiro",NilaiGiro),
					new SqlParameter("StCair",StCair),
					new SqlParameter("StBatal",StBatal),
					new SqlParameter("Pribadi",Pribadi),
					new SqlParameter("SaldoJml",SaldoJml),
					new SqlParameter("No_Bukti",No_Bukti),
					new SqlParameter("Keterangan",Keterangan) 
				};
            Result = dbo.RunProcedure("sp_Giro_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NoBG, string NamaBank, string NoRekening, DateTime TJT, DateTime TGLKeluar, string Untuk, string NamaToko, float NilaiGiro, bool StCair, bool StBatal, string Pribadi, float SaldoJml, string No_Bukti, string Keterangan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBG",NoBG),
					new SqlParameter("NamaBank",NamaBank),
					new SqlParameter("NoRekening",NoRekening),
					new SqlParameter("TJT",TJT),
					new SqlParameter("TGLKeluar",TGLKeluar),
					new SqlParameter("Untuk",Untuk),
					new SqlParameter("NamaToko",NamaToko),
					new SqlParameter("NilaiGiro",NilaiGiro),
					new SqlParameter("StCair",StCair),
					new SqlParameter("StBatal",StBatal),
					new SqlParameter("Pribadi",Pribadi),
					new SqlParameter("SaldoJml",SaldoJml),
					new SqlParameter("No_Bukti",No_Bukti),
					new SqlParameter("Keterangan",Keterangan) 
				};
            Result = dbo.RunProcedure("sp_Giro_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NoBG)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBG",NoBG) 
				};
            Result = dbo.RunProcedure("sp_Giro_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}