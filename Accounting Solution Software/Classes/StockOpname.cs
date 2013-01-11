using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    
    [DataObject(true)]
    public class StockOpname
    {
        DbObject dbo = new DbObject();
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_StockOpname_SelectAll", parameters, "StockOpname");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NoBukti)
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NoBukti",NoBukti) 
                };
            return dbo.RunProcedure("sp_StockOpname_SelectRow", parameters, "StockOpname");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NoBukti, DateTime Tanggal, string KodeStock, float StockAwal, float StockOpname, float Selisih, float Harga, float Jumlah, int Status, string PartNo)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBuktiold",NoBukti),
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("StockAwal",StockAwal),
					new SqlParameter("StockOpname",StockOpname),
					new SqlParameter("Selisih",Selisih),
					new SqlParameter("Harga",Harga),
					new SqlParameter("Jumlah",Jumlah),
					new SqlParameter("Status",Status),
					new SqlParameter("PartNo",PartNo) 
				};
            Result = dbo.RunProcedure("sp_StockOpname_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NoBukti, DateTime Tanggal, string KodeStock, float StockAwal, float StockOpname, float Selisih, float Harga, float Jumlah, int Status, string PartNo)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBukti",NoBukti),
					new SqlParameter("Tanggal",Tanggal),
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("StockAwal",StockAwal),
					new SqlParameter("StockOpname",StockOpname),
					new SqlParameter("Selisih",Selisih),
					new SqlParameter("Harga",Harga),
					new SqlParameter("Jumlah",Jumlah),
					new SqlParameter("Status",Status),
					new SqlParameter("PartNo",PartNo) 
				};
            Result = dbo.RunProcedure("sp_StockOpname_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NoBukti)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NoBukti",NoBukti) 
				};
            Result = dbo.RunProcedure("sp_StockOpname_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

        public SqlDataReader generateNoBukti()
        {
            SqlDataReader sdr = null;
            SqlParameter[] parameters = new SqlParameter[] { };
            sdr = dbo.RunProcedure("[get_noBukti_stockOpname]", parameters);
            return sdr;
        }

    }
}