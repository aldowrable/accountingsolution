using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Beli
    {
        DbObject dbo = new DbObject();
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Beli_SelectAll", parameters, "Beli");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string NomorBukti)
        {
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("NomorBukti",NomorBukti) 
                };
            return dbo.RunProcedure("sp_Beli_SelectRow", parameters, "Beli");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string NomorBukti, string NomorFaktur, DateTime TglTransaksi, DateTime TglPembukuan, string KodeSupplier, string StatusPembelian, DateTime TglJT, float UangMuka, float SubJumlah, float TotDiscRp, float TotPPnRp, float JumlahPembelian, float Term, float Bulat, float Materai)
        {
            int RowsAffected = 0;
            int Result = 0;
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("TglPembukuan",TglPembukuan),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("StatusPembelian",StatusPembelian),
					new SqlParameter("TglJT",TglJT),
					new SqlParameter("UangMuka",UangMuka),
					new SqlParameter("SubJumlah",SubJumlah),
					new SqlParameter("TotDiscRp",TotDiscRp),
					new SqlParameter("TotPPnRp",TotPPnRp),
					new SqlParameter("JumlahPembelian",JumlahPembelian),
					new SqlParameter("Term",Term),
					new SqlParameter("Bulat",Bulat),
					new SqlParameter("Materai",Materai) 
				};
            Result = dbo.RunProcedure("sp_Beli_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string NomorBukti, string NomorFaktur, DateTime TglTransaksi, DateTime TglPembukuan, string KodeSupplier, string StatusPembelian, DateTime TglJT, float UangMuka, float SubJumlah, float TotDiscRp, float TotPPnRp, float JumlahPembelian, float Term, float Bulat, float Materai)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti),
					new SqlParameter("NomorFaktur",NomorFaktur),
					new SqlParameter("TglTransaksi",TglTransaksi),
					new SqlParameter("TglPembukuan",TglPembukuan),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("StatusPembelian",StatusPembelian),
					new SqlParameter("TglJT",TglJT),
					new SqlParameter("UangMuka",UangMuka),
					new SqlParameter("SubJumlah",SubJumlah),
					new SqlParameter("TotDiscRp",TotDiscRp),
					new SqlParameter("TotPPnRp",TotPPnRp),
					new SqlParameter("JumlahPembelian",JumlahPembelian),
					new SqlParameter("Term",Term),
					new SqlParameter("Bulat",Bulat),
					new SqlParameter("Materai",Materai) 
				};
            Result = dbo.RunProcedure("sp_Beli_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public SqlDataReader generateNoBukti()
        {
            SqlDataReader sdr = null;
            SqlParameter[] parameters = new SqlParameter[] { };
            sdr = dbo.RunProcedure("sp_get_noBukti_pembelian", parameters);
            return sdr;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string NomorBukti)
        {
            int RowsAffected = 0;
            int Result = 0;
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("NomorBukti",NomorBukti) 
				};
            Result = dbo.RunProcedure("sp_Beli_DeleteRow", parameters, out RowsAffected);
            return Result;
        }
    }
}