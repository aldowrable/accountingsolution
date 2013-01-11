using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Supplier
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Supplier_SelectAll", parameters, "Supplier");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodeSupplier)
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodeSupplier",KodeSupplier) 
                };
            return dbo.RunProcedure("sp_Supplier_SelectRow", parameters, "Supplier");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodeSupplier, string NamaSupplier, string ContactPerson, string Alamat, string Kota, string KodePos, string Telepon1, string Telepon2, string Fax, string KodeArea, float UtangAwal, string Acc_No)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("NamaSupplier",NamaSupplier),
					new SqlParameter("ContactPerson",ContactPerson),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Kota",Kota),
					new SqlParameter("KodePos",KodePos),
					new SqlParameter("Telepon1",Telepon1),
					new SqlParameter("Telepon2",Telepon2),
					new SqlParameter("Fax",Fax),
					new SqlParameter("KodeArea",KodeArea),
					new SqlParameter("UtangAwal",UtangAwal),
					new SqlParameter("Acc_No",Acc_No) 
				};
            Result = dbo.RunProcedure("sp_Supplier_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodeSupplier, string NamaSupplier, string ContactPerson, string Alamat, string Kota, string KodePos, string Telepon1, string Telepon2, string Fax, string KodeArea, float UtangAwal, string Acc_No)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("NamaSupplier",NamaSupplier),
					new SqlParameter("ContactPerson",ContactPerson),
					new SqlParameter("Alamat",Alamat),
					new SqlParameter("Kota",Kota),
					new SqlParameter("KodePos",KodePos),
					new SqlParameter("Telepon1",Telepon1),
					new SqlParameter("Telepon2",Telepon2),
					new SqlParameter("Fax",Fax),
					new SqlParameter("KodeArea",KodeArea),
					new SqlParameter("UtangAwal",UtangAwal),
					new SqlParameter("Acc_No",Acc_No) 
				};
            Result = dbo.RunProcedure("sp_Supplier_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodeSupplier)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeSupplier",KodeSupplier) 
				};
            Result = dbo.RunProcedure("sp_Supplier_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}