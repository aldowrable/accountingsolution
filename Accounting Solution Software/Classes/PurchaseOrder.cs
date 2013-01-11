using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    class PurchaseOrder
    {
        DbObject dbo = new DbObject();

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("PurchaseOrder_SelectAll", parameters, "PurchaseOrder");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string id)
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("id",id) 
                };
            return dbo.RunProcedure("PurchaseOrder_SelectRow", parameters, "PurchaseOrder");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string id, DateTime tanggal, string KodeSupplier, string alamatkirim, string statuskirim)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("tanggal",tanggal),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("alamatkirim",alamatkirim),
					new SqlParameter("statuskirim",statuskirim) 
				};
            Result = dbo.RunProcedure("PurchaseOrder_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string id, DateTime tanggal, string KodeSupplier, string alamatkirim, string statuskirim)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id),
					new SqlParameter("tanggal",tanggal),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("alamatkirim",alamatkirim),
					new SqlParameter("statuskirim",statuskirim) 
				};
            Result = dbo.RunProcedure("PurchaseOrder_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string id)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id",id) 
				};
            Result = dbo.RunProcedure("PurchaseOrder_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

        public SqlDataReader generateNoBukti()
        {
            SqlDataReader sdr = null;
            SqlParameter[] parameters = new SqlParameter[] { };
            sdr = dbo.RunProcedure("PurchaseOrder_get_noBukti", parameters);
            return sdr;
        }
    }
}
