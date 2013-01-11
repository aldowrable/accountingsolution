using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Piutang
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Piutang_SelectAll", parameters, "Piutang");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_Piutang_SelectRow", parameters, "Piutang");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(DateTime TANGGAL, string FAKTUR, string NO_BUKTI, string KodePelanggan, string KodeSalesman, string NamaSalesman, float SALDO, float Nominal, string PosisiPerkiraan, DateTime TJT, string KET, float Komisi)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("TANGGAL",TANGGAL),
					new SqlParameter("FAKTUR",FAKTUR),
					new SqlParameter("NO_BUKTI",NO_BUKTI),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("NamaSalesman",NamaSalesman),
					new SqlParameter("SALDO",SALDO),
					new SqlParameter("Nominal",Nominal),
					new SqlParameter("PosisiPerkiraan",PosisiPerkiraan),
					new SqlParameter("TJT",TJT),
					new SqlParameter("KET",KET),
					new SqlParameter("Komisi",Komisi) 
				};
            Result = dbo.RunProcedure("sp_Piutang_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRowDebit(DateTime TANGGAL, string FAKTUR, string KodePelanggan, string KodeSalesman, string NamaSalesman, float SALDO, float Nominal, DateTime TJT, string KET, float Komisi)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("TANGGAL",TANGGAL),
					new SqlParameter("FAKTUR",FAKTUR),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("NamaSalesman",NamaSalesman),
					new SqlParameter("SALDO",SALDO),
					new SqlParameter("Nominal",Nominal),
					new SqlParameter("TJT",TJT),
					new SqlParameter("KET",KET),
					new SqlParameter("Komisi",Komisi) 
				};
            Result = dbo.RunProcedure("sp_Piutang_InsertDebit", parameters, out RowsAffected);
            return Result;
        }

        public SqlDataReader InsertRowKredit(DateTime TANGGAL, string FAKTUR, string KodePelanggan, string KodeSalesman, string NamaSalesman, float SALDO, float Nominal, DateTime TJT, string KET, float Komisi)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("TANGGAL",TANGGAL),
					new SqlParameter("FAKTUR",FAKTUR),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("NamaSalesman",NamaSalesman),
					new SqlParameter("SALDO",SALDO),
					new SqlParameter("Nominal",Nominal),
					new SqlParameter("TJT",TJT),
					new SqlParameter("KET",KET),
					new SqlParameter("Komisi",Komisi) 
				};
            sdr = dbo.RunProcedure("sp_Piutang_InsertKredit", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, DateTime TANGGAL, string FAKTUR, string NO_BUKTI, string KodePelanggan, string KodeSalesman, string NamaSalesman, float SALDO, float Nominal, string PosisiPerkiraan, DateTime TJT, string KET, float Komisi)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("TANGGAL",TANGGAL),
					new SqlParameter("FAKTUR",FAKTUR),
					new SqlParameter("NO_BUKTI",NO_BUKTI),
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("NamaSalesman",NamaSalesman),
					new SqlParameter("SALDO",SALDO),
					new SqlParameter("Nominal",Nominal),
					new SqlParameter("PosisiPerkiraan",PosisiPerkiraan),
					new SqlParameter("TJT",TJT),
					new SqlParameter("KET",KET),
					new SqlParameter("Komisi",Komisi) 
				};
            Result = dbo.RunProcedure("sp_Piutang_Update", parameters, out RowsAffected);
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
            Result = dbo.RunProcedure("sp_Piutang_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}