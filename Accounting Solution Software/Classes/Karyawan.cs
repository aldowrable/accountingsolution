using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class karyawan
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_karyawan_SelectAll", parameters, "karyawan");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string id)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("sp_karyawan_SelectRow", parameters, "karyawan");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string id, string nama, string alamat, string telp, DateTime mulai_kerja, string jabatan, float gaji_pokok, float tunjangan, string statuskerja)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("nama",nama),
					new SqlParameter("alamat",alamat),
					new SqlParameter("telp",telp),
					new SqlParameter("mulai_kerja",mulai_kerja),
					new SqlParameter("jabatan",jabatan),
					new SqlParameter("gaji_pokok",gaji_pokok),
					new SqlParameter("tunjangan",tunjangan),
					new SqlParameter("statuskerja",statuskerja) 
				};
            Result = dbo.RunProcedure("sp_karyawan_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string id, string nama, string alamat, string telp, DateTime mulai_kerja, string jabatan, float gaji_pokok, float tunjangan, string statuskerja)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("nama",nama),
					new SqlParameter("alamat",alamat),
					new SqlParameter("telp",telp),
					new SqlParameter("mulai_kerja",mulai_kerja),
					new SqlParameter("jabatan",jabatan),
					new SqlParameter("gaji_pokok",gaji_pokok),
					new SqlParameter("tunjangan",tunjangan),
					new SqlParameter("statuskerja",statuskerja) 
				};
            Result = dbo.RunProcedure("sp_karyawan_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string id)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id) 
				};
            Result = dbo.RunProcedure("sp_karyawan_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}