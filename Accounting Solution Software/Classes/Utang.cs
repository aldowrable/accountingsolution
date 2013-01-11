using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Utang
    {
        DbObject dbo = new DbObject();

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Utang_SelectAll", parameters, "Utang");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_Utang_SelectRow", parameters, "Utang");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(DateTime TANGGAL, string FAKTUR, string NO_BUKTI, string KodeSupplier, string PosisiPerkiraan, float Nominal, float RETUR, DateTime TJT, string KET, DateTime TGLFAKTUR)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("TANGGAL",TANGGAL),
					new SqlParameter("FAKTUR",FAKTUR),
					new SqlParameter("NO_BUKTI",NO_BUKTI),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("PosisiPerkiraan",PosisiPerkiraan),
					new SqlParameter("Nominal",Nominal),
					new SqlParameter("RETUR",RETUR),
					new SqlParameter("TJT",TJT),
					new SqlParameter("KET",KET),
					new SqlParameter("TGLFAKTUR",TGLFAKTUR) 
				};
            Result = dbo.RunProcedure("sp_Utang_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRowKredit(DateTime TANGGAL, string FAKTUR, string NO_BUKTI, string KodeSupplier, float Nominal, float RETUR, DateTime TJT, string KET, DateTime TGLFAKTUR)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("TANGGAL",TANGGAL),
					new SqlParameter("FAKTUR",FAKTUR),
					new SqlParameter("NO_BUKTI",NO_BUKTI),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("Nominal",Nominal),
					new SqlParameter("RETUR",RETUR),
					new SqlParameter("TJT",TJT),
					new SqlParameter("KET",KET),
					new SqlParameter("TGLFAKTUR",TGLFAKTUR) 
				};
            Result = dbo.RunProcedure("sp_Utang_InsertKredit", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader InsertRowDebit(DateTime TANGGAL, string FAKTUR, string KodeSupplier, float Nominal, float RETUR, DateTime TJT, string KET, DateTime TGLFAKTUR)
        {
            SqlDataReader sdr = null;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("TANGGAL",TANGGAL),
					new SqlParameter("FAKTUR",FAKTUR),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("Nominal",Nominal),
					new SqlParameter("RETUR",RETUR),
					new SqlParameter("TJT",TJT),
					new SqlParameter("KET",KET),
					new SqlParameter("TGLFAKTUR",TGLFAKTUR) 
				};
            sdr = dbo.RunProcedure("sp_Utang_InsertDebit", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, DateTime TANGGAL, string FAKTUR, string NO_BUKTI, string KodeSupplier, string PosisiPerkiraan, float Nominal, float RETUR, DateTime TJT, string KET, DateTime TGLFAKTUR)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("TANGGAL",TANGGAL),
					new SqlParameter("FAKTUR",FAKTUR),
					new SqlParameter("NO_BUKTI",NO_BUKTI),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("PosisiPerkiraan",PosisiPerkiraan),
					new SqlParameter("Nominal",Nominal),
					new SqlParameter("RETUR",RETUR),
					new SqlParameter("TJT",TJT),
					new SqlParameter("KET",KET),
					new SqlParameter("TGLFAKTUR",TGLFAKTUR) 
				};
            Result = dbo.RunProcedure("sp_Utang_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NoBuktiPembelian)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NoBuktiPembelian) 
				};
            Result = dbo.RunProcedure("sp_Utang_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

        public SqlDataReader generateNoBukti()
        {
            SqlDataReader sdr = null;
            SqlParameter[] parameters = new SqlParameter[] { };
            sdr = dbo.RunProcedure("get_noBukti_utang", parameters);
            return sdr;
        }
    }
}