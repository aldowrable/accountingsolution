using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Kas
    {
        DbObject dbo = new DbObject();

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Kas_SelectAll", parameters, "Kas");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NoBukti)
        {
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NoBukti",NoBukti) 
                };
            return dbo.RunProcedure("sp_Kas_SelectRow", parameters, "Kas");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(DateTime Tanggal, string NoBukti, string NoFaktur, string Keterangan, float Nilai, string KodePerkiraanKas, string PosisiPerkiraan)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("NoFaktur",NoFaktur),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai),
					new SqlParameter("KodePerkiraanKas",KodePerkiraanKas),
					new SqlParameter("PosisiPerkiraan",PosisiPerkiraan) 
				};
            Result = dbo.RunProcedure("sp_Kas_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRowDebit(DateTime Tanggal, string NoBukti, string NoFaktur, string Keterangan, float Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("NoFaktur",NoFaktur),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai)
				};
            Result = dbo.RunProcedure("sp_Kas_InsertDebit", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRowDebit(DateTime Tanggal, string NoFaktur, string Keterangan, float Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NoFaktur",NoFaktur),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai)
				};
            Result = dbo.RunProcedure("sp_Kas_InsertDebit_Generate_NoBukti", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRowKredit(DateTime Tanggal, string NoBukti, string NoFaktur, string Keterangan, float Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("NoFaktur",NoFaktur),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai)
				};
            Result = dbo.RunProcedure("sp_Kas_InsertKredit", parameters, out RowsAffected);
            return Result;
        }

        public int InsertRowKredit(DateTime Tanggal, string NoFaktur, string Keterangan, float Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NoFaktur",NoFaktur),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai)
				};
            Result = dbo.RunProcedure("sp_Kas_InsertKredit_Generate_NoBukti", parameters, out RowsAffected);
            return Result;
        }

        public int InsertKasKecilRowDebit(DateTime Tanggal, string NoBukti, string NoFaktur, string Keterangan, float Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("NoFaktur",NoFaktur),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai)
				};
            Result = dbo.RunProcedure("sp_KasKecil_InsertDebit", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertKasKecilRowKredit(DateTime Tanggal, string NoBukti, string NoFaktur, string Keterangan, float Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("NoFaktur",NoFaktur),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai)
				};
            Result = dbo.RunProcedure("sp_KasKecil_InsertKredit", parameters, out RowsAffected);
            return Result;
        }




        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader generateNoBuktiMasuk()
        {
            SqlDataReader sdr = null;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{};
            sdr = dbo.RunProcedure("sp_get_noBukti_kas_masuk", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader generateNoBuktiKeluar()
        {
            SqlDataReader sdr = null;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[] { };
            sdr = dbo.RunProcedure("sp_get_noBukti_kas_keluar", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader getSaldo(string accountId)
        {
            SqlDataReader sdr = null;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("AccountId",accountId)
				};
            sdr = dbo.RunProcedure("sp_get_saldo", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader getSaldoBulanLalu(string accountId)
        {
            SqlDataReader sdr = null;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("AccountId",accountId)
				};
            sdr = dbo.RunProcedure("sp_get_saldo_bulanlalu", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader getSaldoBulanIni(string accountId)
        {
            SqlDataReader sdr = null;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("AccountId",accountId)
				};
            sdr = dbo.RunProcedure("sp_get_saldo_bulanini", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(DateTime Tanggal, string NoBukti, string NoFaktur, string Keterangan, float Nilai, string KodePerkiraanKas, string PosisiPerkiraan)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("NoFaktur",NoFaktur),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai),
					new SqlParameter("KodePerkiraanKas",KodePerkiraanKas),
					new SqlParameter("PosisiPerkiraan",PosisiPerkiraan) 
				};
            Result = dbo.RunProcedure("sp_Kas_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NoBukti)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBukti",NoBukti) 
				};
            Result = dbo.RunProcedure("sp_Kas_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRowByNoFaktur(string NoFaktur)
        {
            int RowsAffected = 0;
            int Result = 0;
            //DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoFaktur",NoFaktur) 
				};
            Result = dbo.RunProcedure("sp_Kas_DeleteRow_By_NoFaktur", parameters, out RowsAffected);
            return Result;
        }

    }
}