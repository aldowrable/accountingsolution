using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Salesman
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Salesman_SelectAll", parameters, "Salesman");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodeSalesman)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodeSalesman",KodeSalesman) 
                };
            return dbo.RunProcedure("sp_Salesman_SelectRow", parameters, "Salesman");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodeSalesman, string NamaSalesman, string Alamat, string Kota, string KodePos, string Telepon1, string Telepon2, string KodeArea, float Komisi)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("NamaSalesman",NamaSalesman),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Kota",Kota),
					new SqlParameter("KodePos",KodePos),
					new SqlParameter("Telepon1",Telepon1),
					new SqlParameter("Telepon2",Telepon2),
					new SqlParameter("KodeArea",KodeArea),
					new SqlParameter("Komisi",Komisi) 
				};
            Result = dbo.RunProcedure("sp_Salesman_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodeSalesman, string NamaSalesman, string Alamat, string Kota, string KodePos, string Telepon1, string Telepon2, string KodeArea, float Komisi)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeSalesman",KodeSalesman),
					new SqlParameter("NamaSalesman",NamaSalesman),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Kota",Kota),
					new SqlParameter("KodePos",KodePos),
					new SqlParameter("Telepon1",Telepon1),
					new SqlParameter("Telepon2",Telepon2),
					new SqlParameter("KodeArea",KodeArea),
					new SqlParameter("Komisi",Komisi) 
				};
            Result = dbo.RunProcedure("sp_Salesman_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodeSalesman)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeSalesman",KodeSalesman) 
				};
            Result = dbo.RunProcedure("sp_Salesman_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}