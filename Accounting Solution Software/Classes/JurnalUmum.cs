using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class JurnalUmum
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_JurnalUmum_SelectAll", parameters, "JurnalUmum");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NomorBukti)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NomorBukti",NomorBukti) 
                };
            return dbo.RunProcedure("sp_JurnalUmum_SelectRow", parameters, "JurnalUmum");
        }

        public SqlDataReader getSaldoPerkiraan(int tahun)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("Tahun",tahun),
            };
            sdr = dbo.RunProcedure("Saldo_Perkiraan", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader generateNoBukti()
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]{};
            sdr = dbo.RunProcedure("sp_get_noBukti_jurnal_umum", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader InsertRow(DateTime Tanggal, string NomorFaktur, string Keterangan)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("Keterangan",Keterangan) 
				};
            sdr = dbo.RunProcedure("sp_JurnalUmum_Insert", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NomorBukti, DateTime Tanggal, string NomorFaktur, string Keterangan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("Keterangan",Keterangan) 
				};
            Result = dbo.RunProcedure("sp_JurnalUmum_Update", parameters, out RowsAffected);
            return Result;
        }

        public SqlDataReader UpdateRow(DateTime Tanggal, string NomorFaktur, string Keterangan)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("Keterangan",Keterangan) 
				};
            sdr = dbo.RunProcedure("sp_JurnalUmum_Update_Get_NoBukti", parameters);
            return sdr;
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
            Result = dbo.RunProcedure("sp_JurnalUmum_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

       /* public string generateNoBuktiString()
        {
            SqlDataReader sdr = generateNoBukti();
            string noBuktiJurnal = "";
            while (sdr.Read())
            {
                noBuktiJurnal = (string)sdr["result"];
            }
            return noBuktiJurnal;
        }*/

    }
}