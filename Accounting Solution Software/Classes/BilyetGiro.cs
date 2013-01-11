using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class BilyetGiro
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_BilyetGiro_SelectAll", parameters, "BilyetGiro");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NomorGiro)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NomorGiro",NomorGiro) 
                };
            return dbo.RunProcedure("sp_BilyetGiro_SelectRow", parameters, "BilyetGiro");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NomorGiro, DateTime TanggalTitipan, string PemberiGiro, float NilaiGiro, DateTime TanggalJT, DateTime TanggalCair1, string NoRekening, string NamaBank, string NamaToko, float SaldoJml, bool StatusGiro, bool StatusCair, bool StatusDibayar, string Keterangan, string KodeSalesman, string No_Bukti)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorGiro",NomorGiro),
					new SqlParameter("TanggalTitipan",TanggalTitipan),
					new SqlParameter("PemberiGiro",PemberiGiro),
					new SqlParameter("NilaiGiro",NilaiGiro),
					new SqlParameter("TanggalJT",TanggalJT),
					new SqlParameter("TanggalCair1",TanggalCair1),
					new SqlParameter("NoRekening",NoRekening),
					new SqlParameter("NamaBank",NamaBank),
					new SqlParameter("NamaToko",NamaToko),
					new SqlParameter("SaldoJml",SaldoJml),
					new SqlParameter("StatusGiro",StatusGiro),
					new SqlParameter("StatusCair",StatusCair),
					new SqlParameter("StatusDibayar",StatusDibayar),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("No_Bukti",No_Bukti) 
				};
            Result = dbo.RunProcedure("sp_BilyetGiro_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NomorGiro, DateTime TanggalTitipan, string PemberiGiro, float NilaiGiro, DateTime TanggalJT, DateTime TanggalCair1, string NoRekening, string NamaBank, string NamaToko, float SaldoJml, bool StatusGiro, bool StatusCair, bool StatusDibayar, string Keterangan, string KodeSalesman, string No_Bukti)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorGiro",NomorGiro),
					new SqlParameter("TanggalTitipan",TanggalTitipan),
					new SqlParameter("PemberiGiro",PemberiGiro),
					new SqlParameter("NilaiGiro",NilaiGiro),
					new SqlParameter("TanggalJT",TanggalJT),
					new SqlParameter("TanggalCair1",TanggalCair1),
					new SqlParameter("NoRekening",NoRekening),
					new SqlParameter("NamaBank",NamaBank),
					new SqlParameter("NamaToko",NamaToko),
					new SqlParameter("SaldoJml",SaldoJml),
					new SqlParameter("StatusGiro",StatusGiro),
					new SqlParameter("StatusCair",StatusCair),
					new SqlParameter("StatusDibayar",StatusDibayar),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("No_Bukti",No_Bukti) 
				};
            Result = dbo.RunProcedure("sp_BilyetGiro_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NomorGiro)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorGiro",NomorGiro) 
				};
            Result = dbo.RunProcedure("sp_BilyetGiro_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}