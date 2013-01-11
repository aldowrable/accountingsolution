using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class stockMovement
    {
        DbObject dbo = new DbObject();
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_stockMovement_SelectAll", parameters, "stockMovement");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string no_bukti)
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("no_bukti",no_bukti) 
                };
            return dbo.RunProcedure("sp_stockMovement_SelectRow", parameters, "stockMovement");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string no_bukti,DateTime tanggal, string id_gudang_asal, string id_gudang_tujuan)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("no_bukti",no_bukti),
                    new SqlParameter("tanggal",tanggal),
					new SqlParameter("id_gudang_asal",id_gudang_asal),
					new SqlParameter("id_gudang_tujuan",id_gudang_tujuan)
				};
            Result = dbo.RunProcedure("stockMovement_Insert", parameters, out RowsAffected);
            return Result;
        }

        public int InsertRowAutoId(string id_gudang_asal, string id_gudang_tujuan, string id_stock, int qty)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("id_gudang_asal",id_gudang_asal),
					new SqlParameter("id_gudang_tujuan",id_gudang_tujuan),
					new SqlParameter("id_stock",id_stock),
					new SqlParameter("qty",qty) 
				};
            Result = dbo.RunProcedure("sp_stockMovement_InsertAutoID", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string no_bukti, string id_gudang_asal, string id_gudang_tujuan)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("no_bukti",no_bukti),
					new SqlParameter("id_gudang_asal",id_gudang_asal),
					new SqlParameter("id_gudang_tujuan",id_gudang_tujuan)
				};
            Result = dbo.RunProcedure("sp_stockMovement_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string no_bukti)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("no_bukti",no_bukti) 
				};
            Result = dbo.RunProcedure("sp_stockMovement_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

        public SqlDataReader generateNoBukti()
        {
            SqlDataReader sdr = null;
            SqlParameter[] parameters = new SqlParameter[] { };
            sdr = dbo.RunProcedure("[sp_get_noBukti_stockMovement]", parameters);
            return sdr;
        }
    }
}