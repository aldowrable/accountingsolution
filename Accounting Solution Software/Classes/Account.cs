using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Account
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Account_SelectAll", parameters, "Account");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodePerkiraan)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodePerkiraan",KodePerkiraan) 
                };
            return dbo.RunProcedure("sp_Account_SelectRow", parameters, "Account");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodePerkiraan, string NamaPerkiraan, string KodeKelompok6, float AccLevel, float Debet, float Kredit, float SaldoAwal01, float SaldoAwal02, float SaldoAwal03, float SaldoAwal04, float SaldoAwal05, float SaldoAwal06, float SaldoAwal07, float SaldoAwal08, float SaldoAwal09, float SaldoAwal10, float SaldoAwal11, float SaldoAwal12, float SaldoAkhir01, float SaldoAkhir02, float SaldoAkhir03, float SaldoAkhir04, float SaldoAkhir05, float SaldoAkhir06, float SaldoAkhir07, float SaldoAkhir08, float SaldoAkhir09, float SaldoAkhir10, float SaldoAkhir11, float SaldoAkhir12, string KelompokLaporan, string NamaKelompok, string KelompokDetail, string KasBank)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodePerkiraan",KodePerkiraan),
					new SqlParameter("NamaPerkiraan",NamaPerkiraan),
					new SqlParameter("KodeKelompok6",KodeKelompok6),
					new SqlParameter("AccLevel",AccLevel),
					new SqlParameter("Debet",Debet),
					new SqlParameter("Kredit",Kredit),
					new SqlParameter("SaldoAwal01",SaldoAwal01),
					new SqlParameter("SaldoAwal02",SaldoAwal02),
					new SqlParameter("SaldoAwal03",SaldoAwal03),
					new SqlParameter("SaldoAwal04",SaldoAwal04),
					new SqlParameter("SaldoAwal05",SaldoAwal05),
					new SqlParameter("SaldoAwal06",SaldoAwal06),
					new SqlParameter("SaldoAwal07",SaldoAwal07),
					new SqlParameter("SaldoAwal08",SaldoAwal08),
					new SqlParameter("SaldoAwal09",SaldoAwal09),
					new SqlParameter("SaldoAwal10",SaldoAwal10),
					new SqlParameter("SaldoAwal11",SaldoAwal11),
					new SqlParameter("SaldoAwal12",SaldoAwal12),
					new SqlParameter("SaldoAkhir01",SaldoAkhir01),
					new SqlParameter("SaldoAkhir02",SaldoAkhir02),
					new SqlParameter("SaldoAkhir03",SaldoAkhir03),
					new SqlParameter("SaldoAkhir04",SaldoAkhir04),
					new SqlParameter("SaldoAkhir05",SaldoAkhir05),
					new SqlParameter("SaldoAkhir06",SaldoAkhir06),
					new SqlParameter("SaldoAkhir07",SaldoAkhir07),
					new SqlParameter("SaldoAkhir08",SaldoAkhir08),
					new SqlParameter("SaldoAkhir09",SaldoAkhir09),
					new SqlParameter("SaldoAkhir10",SaldoAkhir10),
					new SqlParameter("SaldoAkhir11",SaldoAkhir11),
					new SqlParameter("SaldoAkhir12",SaldoAkhir12),
					new SqlParameter("KelompokLaporan",KelompokLaporan),
					new SqlParameter("NamaKelompok",NamaKelompok),
					new SqlParameter("KelompokDetail",KelompokDetail),
					new SqlParameter("KasBank",KasBank) 
				};
            Result = dbo.RunProcedure("sp_Account_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodePerkiraan, string NamaPerkiraan, string KodeKelompok6, float AccLevel, float Debet, float Kredit, float SaldoAwal01, float SaldoAwal02, float SaldoAwal03, float SaldoAwal04, float SaldoAwal05, float SaldoAwal06, float SaldoAwal07, float SaldoAwal08, float SaldoAwal09, float SaldoAwal10, float SaldoAwal11, float SaldoAwal12, float SaldoAkhir01, float SaldoAkhir02, float SaldoAkhir03, float SaldoAkhir04, float SaldoAkhir05, float SaldoAkhir06, float SaldoAkhir07, float SaldoAkhir08, float SaldoAkhir09, float SaldoAkhir10, float SaldoAkhir11, float SaldoAkhir12, string KelompokLaporan, string NamaKelompok, string KelompokDetail, string KasBank)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodePerkiraan",KodePerkiraan),
					new SqlParameter("NamaPerkiraan",NamaPerkiraan),
					new SqlParameter("KodeKelompok6",KodeKelompok6),
					new SqlParameter("AccLevel",AccLevel),
					new SqlParameter("Debet",Debet),
					new SqlParameter("Kredit",Kredit),
					new SqlParameter("SaldoAwal01",SaldoAwal01),
					new SqlParameter("SaldoAwal02",SaldoAwal02),
					new SqlParameter("SaldoAwal03",SaldoAwal03),
					new SqlParameter("SaldoAwal04",SaldoAwal04),
					new SqlParameter("SaldoAwal05",SaldoAwal05),
					new SqlParameter("SaldoAwal06",SaldoAwal06),
					new SqlParameter("SaldoAwal07",SaldoAwal07),
					new SqlParameter("SaldoAwal08",SaldoAwal08),
					new SqlParameter("SaldoAwal09",SaldoAwal09),
					new SqlParameter("SaldoAwal10",SaldoAwal10),
					new SqlParameter("SaldoAwal11",SaldoAwal11),
					new SqlParameter("SaldoAwal12",SaldoAwal12),
					new SqlParameter("SaldoAkhir01",SaldoAkhir01),
					new SqlParameter("SaldoAkhir02",SaldoAkhir02),
					new SqlParameter("SaldoAkhir03",SaldoAkhir03),
					new SqlParameter("SaldoAkhir04",SaldoAkhir04),
					new SqlParameter("SaldoAkhir05",SaldoAkhir05),
					new SqlParameter("SaldoAkhir06",SaldoAkhir06),
					new SqlParameter("SaldoAkhir07",SaldoAkhir07),
					new SqlParameter("SaldoAkhir08",SaldoAkhir08),
					new SqlParameter("SaldoAkhir09",SaldoAkhir09),
					new SqlParameter("SaldoAkhir10",SaldoAkhir10),
					new SqlParameter("SaldoAkhir11",SaldoAkhir11),
					new SqlParameter("SaldoAkhir12",SaldoAkhir12),
					new SqlParameter("KelompokLaporan",KelompokLaporan),
					new SqlParameter("NamaKelompok",NamaKelompok),
					new SqlParameter("KelompokDetail",KelompokDetail),
					new SqlParameter("KasBank",KasBank) 
				};
            Result = dbo.RunProcedure("sp_Account_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodePerkiraan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodePerkiraan",KodePerkiraan) 
				};
            Result = dbo.RunProcedure("sp_Account_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}