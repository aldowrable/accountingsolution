using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class OwnerIdentity
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_OwnerIdentity_SelectAll", parameters, "OwnerIdentity");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NamaPerusahaan)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NamaPerusahaan",NamaPerusahaan) 
                };
            return dbo.RunProcedure("sp_OwnerIdentity_SelectRow", parameters, "OwnerIdentity");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NamaPerusahaan, string Alamat, string Kota, string KodePos, string Kode_Area, string Telepon1, string Telepon2, string Fax, string Email, string Web, string KodeBon, string KodeSJ, string Alamat1, bool Cetakan1, string Reg, bool Cetakan2, bool Cetakan3, DateTime TanggalPKP, string NamaPKP, string FakturSign, string NPWP, string Jabatan, bool StatusLogo, string NamaFileGambar1)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NamaPerusahaan",NamaPerusahaan),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Kota",Kota),
					new SqlParameter("KodePos",KodePos),
					new SqlParameter("Kode_Area",Kode_Area),
					new SqlParameter("Telepon1",Telepon1),
					new SqlParameter("Telepon2",Telepon2),
					new SqlParameter("Fax",Fax),
					new SqlParameter("Email",Email),
					new SqlParameter("Web",Web),
					new SqlParameter("KodeBon",KodeBon),
					new SqlParameter("KodeSJ",KodeSJ),
					new SqlParameter("Alamat1",Alamat1),
					new SqlParameter("Cetakan1",Cetakan1),
					new SqlParameter("Reg",Reg),
					new SqlParameter("Cetakan2",Cetakan2),
					new SqlParameter("Cetakan3",Cetakan3),
					new SqlParameter("TanggalPKP",TanggalPKP),
					new SqlParameter("NamaPKP",NamaPKP),
					new SqlParameter("FakturSign",FakturSign),
					new SqlParameter("NPWP",NPWP),
					new SqlParameter("Jabatan",Jabatan),
					new SqlParameter("StatusLogo",StatusLogo),
					new SqlParameter("NamaFileGambar1",NamaFileGambar1) 
				};
            Result = dbo.RunProcedure("sp_OwnerIdentity_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NamaPerusahaan, string Alamat, string Kota, string KodePos, string Kode_Area, string Telepon1, string Telepon2, string Fax, string Email, string Web, string KodeBon, string KodeSJ, string Alamat1, bool Cetakan1, string Reg, bool Cetakan2, bool Cetakan3, DateTime TanggalPKP, string NamaPKP, string FakturSign, string NPWP, string Jabatan, bool StatusLogo, string NamaFileGambar1)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NamaPerusahaan",NamaPerusahaan),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Kota",Kota),
					new SqlParameter("KodePos",KodePos),
					new SqlParameter("Kode_Area",Kode_Area),
					new SqlParameter("Telepon1",Telepon1),
					new SqlParameter("Telepon2",Telepon2),
					new SqlParameter("Fax",Fax),
					new SqlParameter("Email",Email),
					new SqlParameter("Web",Web),
					new SqlParameter("KodeBon",KodeBon),
					new SqlParameter("KodeSJ",KodeSJ),
					new SqlParameter("Alamat1",Alamat1),
					new SqlParameter("Cetakan1",Cetakan1),
					new SqlParameter("Reg",Reg),
					new SqlParameter("Cetakan2",Cetakan2),
					new SqlParameter("Cetakan3",Cetakan3),
					new SqlParameter("TanggalPKP",TanggalPKP),
					new SqlParameter("NamaPKP",NamaPKP),
					new SqlParameter("FakturSign",FakturSign),
					new SqlParameter("NPWP",NPWP),
					new SqlParameter("Jabatan",Jabatan),
					new SqlParameter("StatusLogo",StatusLogo),
					new SqlParameter("NamaFileGambar1",NamaFileGambar1) 
				};
            Result = dbo.RunProcedure("sp_OwnerIdentity_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NamaPerusahaan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NamaPerusahaan",NamaPerusahaan) 
				};
            Result = dbo.RunProcedure("sp_OwnerIdentity_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}