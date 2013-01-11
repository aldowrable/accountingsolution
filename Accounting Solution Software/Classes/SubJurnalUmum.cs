using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class SubJurnalUmum
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_SubJurnalUmum_SelectAll", parameters, "SubJurnalUmum");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(int id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_SubJurnalUmum_SelectRow", parameters, "SubJurnalUmum");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int setKreditUser(string NomorBukti, string KodePerkiraan, string Keterangan, float Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("KodePerkiraan",KodePerkiraan),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_InsertKredit", parameters, out RowsAffected);
            return Result;
        }

        public int setDebitUser(string NomorBukti, string KodePerkiraan, string Keterangan, float Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("KodePerkiraan",KodePerkiraan),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_InsertDebit", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int setKreditSystem(string NomorBukti, string AccountId, string Keterangan, float Nilai)
        {
            //float dodol = Nilai;
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("AccountId",AccountId),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_InsertKredit_system", parameters, out RowsAffected);
            return Result;
        }

        public int setDebitSystem(string NomorBukti, string AccountId, string Keterangan, float Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("AccountId",AccountId),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_InsertDebit_system", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int setKreditUser_double(string NomorBukti, string KodePerkiraan, string Keterangan, double Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("KodePerkiraan",KodePerkiraan),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_InsertKredit", parameters, out RowsAffected);
            return Result;
        }

        public int setDebitUser_double(string NomorBukti, string KodePerkiraan, string Keterangan, double Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("KodePerkiraan",KodePerkiraan),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_InsertDebit", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int setKreditSystem_double(string NomorBukti, string AccountId, string Keterangan, double Nilai)
        {
            //float dodol = Nilai;
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("AccountId",AccountId),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_InsertKredit_system", parameters, out RowsAffected);
            return Result;
        }

        public int setDebitSystem_double(string NomorBukti, string AccountId, string Keterangan, double Nilai)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("AccountId",AccountId),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_InsertDebit_system", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NomorBukti, string KodePerkiraan, string Keterangan, float Nilai, string PosisiPerkiraan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("KodePerkiraan",KodePerkiraan),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai),
					new SqlParameter("PosisiPerkiraan",PosisiPerkiraan) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(int id, string NomorBukti, string KodePerkiraan, string Keterangan, float Nilai, string PosisiPerkiraan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("KodePerkiraan",KodePerkiraan),
					new SqlParameter("Keterangan",Keterangan),
					new SqlParameter("Nilai",Nilai),
					new SqlParameter("PosisiPerkiraan",PosisiPerkiraan) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NomorBuktiJurnal)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBuktiJurnal) 
				};
            Result = dbo.RunProcedure("sp_SubJurnalUmum_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}