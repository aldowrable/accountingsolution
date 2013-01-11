using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Jasa
    {
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Jasa_SelectAll", parameters, "Jasa");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow()
        {
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Jasa_SelectRow", parameters, "Jasa");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NoBukti, string KodeJasa,float Qty,float HargaBebas)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("KodeJasa",KodeJasa) ,
                    new SqlParameter("Qty",Qty) ,
                    new SqlParameter("HargaBebas",HargaBebas)
				};
            Result = dbo.RunProcedure("sp_Jasa_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NoBukti, string KodeJasa)
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("KodeJasa",KodeJasa) 
				};
            Result = dbo.RunProcedure("sp_Jasa_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow()
        {
            int RowsAffected = 0;
            int Result = 0;
            DbObject dbo = new DbObject();
            SqlParameter[] parameters = new SqlParameter[]
				{
 
				};
            Result = dbo.RunProcedure("sp_Jasa_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}