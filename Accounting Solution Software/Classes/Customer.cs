using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Customer
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Customer_SelectAll", parameters, "Customer");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodePelanggan)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodePelanggan",KodePelanggan) 
                };
            return dbo.RunProcedure("sp_Customer_SelectRow", parameters, "Customer");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodePelanggan, string NamaPelanggan, string ContactPerson, string Alamat, string Kota, string KodePos, string Telepon1, string Telepon2, string Fax, string KodeArea, float PiutangAwal, string Acc_No, float JmlHari, float DiscTotal, float TotalPoint, string KodeGroup)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan),
					new SqlParameter("ContactPerson",ContactPerson),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Kota",Kota),
					new SqlParameter("KodePos",KodePos),
					new SqlParameter("Telepon1",Telepon1),
					new SqlParameter("Telepon2",Telepon2),
					new SqlParameter("Fax",Fax),
					new SqlParameter("KodeArea",KodeArea),
					new SqlParameter("PiutangAwal",PiutangAwal),
					new SqlParameter("Acc_No",Acc_No),
					new SqlParameter("JmlHari",JmlHari),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("TotalPoint",TotalPoint),
					new SqlParameter("KodeGroup",KodeGroup) 
				};
            Result = dbo.RunProcedure("sp_Customer_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodePelanggan, string NamaPelanggan, string ContactPerson, string Alamat, string Kota, string KodePos, string Telepon1, string Telepon2, string Fax, string KodeArea, float PiutangAwal, string Acc_No, float JmlHari, float DiscTotal, float TotalPoint, string KodeGroup)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodePelanggan",KodePelanggan),
					new SqlParameter("NamaPelanggan",NamaPelanggan),
					new SqlParameter("ContactPerson",ContactPerson),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Kota",Kota),
					new SqlParameter("KodePos",KodePos),
					new SqlParameter("Telepon1",Telepon1),
					new SqlParameter("Telepon2",Telepon2),
					new SqlParameter("Fax",Fax),
					new SqlParameter("KodeArea",KodeArea),
					new SqlParameter("PiutangAwal",PiutangAwal),
					new SqlParameter("Acc_No",Acc_No),
					new SqlParameter("JmlHari",JmlHari),
					new SqlParameter("DiscTotal",DiscTotal),
					new SqlParameter("TotalPoint",TotalPoint),
					new SqlParameter("KodeGroup",KodeGroup) 
				};
            Result = dbo.RunProcedure("sp_Customer_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodePelanggan)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodePelanggan",KodePelanggan) 
				};
            Result = dbo.RunProcedure("sp_Customer_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}