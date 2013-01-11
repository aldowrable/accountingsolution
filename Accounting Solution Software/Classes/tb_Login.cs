using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{

    [DataObject(true)]
    public class tb_Login
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Login_SelectAll", parameters, "Login");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string UserName)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("UserName",UserName) 
                };
            return dbo.RunProcedure("sp_Login_SelectRow", parameters, "Login");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string UserName, string Password, string KodeSistem, string LevelAccess, string NamaSistem, string KeteranganLevel, bool STKasirAktif, DateTime TanggalBertugas, DateTime JamMulai, DateTime JamSelesai)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("UserName",UserName),
					new SqlParameter("Password",Password),
					new SqlParameter("KodeSistem",KodeSistem),
					new SqlParameter("LevelAccess",LevelAccess),
					new SqlParameter("NamaSistem",NamaSistem),
					new SqlParameter("KeteranganLevel",KeteranganLevel),
					new SqlParameter("STKasirAktif",STKasirAktif),
					new SqlParameter("TanggalBertugas",TanggalBertugas),
					new SqlParameter("JamMulai",JamMulai),
					new SqlParameter("JamSelesai",JamSelesai) 
				};
            Result = dbo.RunProcedure("sp_Login_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string UserName, string Password, string KodeSistem, string LevelAccess, string NamaSistem, string KeteranganLevel, bool STKasirAktif, DateTime TanggalBertugas, DateTime JamMulai, DateTime JamSelesai)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("UserName",UserName),
					new SqlParameter("Password",Password),
					new SqlParameter("KodeSistem",KodeSistem),
					new SqlParameter("LevelAccess",LevelAccess),
					new SqlParameter("NamaSistem",NamaSistem),
					new SqlParameter("KeteranganLevel",KeteranganLevel),
					new SqlParameter("STKasirAktif",STKasirAktif),
					new SqlParameter("TanggalBertugas",TanggalBertugas),
					new SqlParameter("JamMulai",JamMulai),
					new SqlParameter("JamSelesai",JamSelesai) 
				};
            Result = dbo.RunProcedure("sp_Login_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public SqlDataReader setLogin(string UserName, string Password)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("UserName",UserName),
					new SqlParameter("Password",Password)
				};
            sdr = dbo.RunProcedure("sp_Login", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public SqlDataReader cekLogin(string UserName, string Password)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("UserName",UserName),
					new SqlParameter("Password",Password)
				};
            sdr = dbo.RunProcedure("sp_Login_Cek", parameters);
            return sdr;
        }

                [DataObjectMethod(DataObjectMethodType.Update)]
        public SqlDataReader setLogout(string UserName, string Password)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("UserName",UserName),
					new SqlParameter("Password",Password)
				};
            sdr = dbo.RunProcedure("sp_Logout", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string UserName)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("UserName",UserName) 
				};
            Result = dbo.RunProcedure("sp_Login_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader getPendapatanObat(DateTime tanggal, string kasir)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",tanggal),
					new SqlParameter("Kasir",kasir)
				};
            sdr = dbo.RunProcedure("sp_pendapatan_obat_by_tanggal_kasir", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader getPendapatanJasa(DateTime tanggal, string kasir)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",tanggal),
					new SqlParameter("Kasir",kasir)
				};
            sdr = dbo.RunProcedure("sp_pendapatan_jasa_by_tanggal_kasir", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader getPendapatanResep(DateTime tanggal, string kasir)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",tanggal),
					new SqlParameter("Kasir",kasir)
				};
            sdr = dbo.RunProcedure("sp_pendapatan_resep_by_tanggal_kasir", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader getPendapatanPiutang(DateTime tanggal, string kasir)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",tanggal),
					new SqlParameter("Kasir",kasir)
				};
            sdr = dbo.RunProcedure("sp_pendapatan_piutang_by_tanggal_kasir", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader getPendapatanAll(DateTime tanggal, string kasir)
        {
            SqlDataReader sdr = null;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("Tanggal",tanggal),
					new SqlParameter("Kasir",kasir)
				};
            sdr = dbo.RunProcedure("sp_pendapatan_all", parameters);
            return sdr;
        }
    }
}