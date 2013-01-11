using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace Accounting_Solution_Software
{
    [DataObject(true)]
    public class Stock
    {

        DbObject dbo = new DbObject();
        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectAll()
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
 
                };
            return dbo.RunProcedure("sp_Stock_SelectAll", parameters, "Stock");
        }

        [DataObjectMethod(DataObjectMethodType.Fill)]
        public DataSet SelectRow(string KodeStock)
        {
            
            SqlParameter[] parameters = new SqlParameter[]
                {
					new SqlParameter("KodeStock",KodeStock) 
                };
            return dbo.RunProcedure("sp_Stock_SelectRow", parameters, "Stock");
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public int InsertRow(string KodeStock, string NamaStock, string Satuan, float JumlahStock, float PV, float BV, float StockAkhir, float HargaBeli, float NilaiStock, float HargaJual1, float HargaJual2, float HargaJual3, string KodeKelompok, string Ukuran, float StockMinimum, float Isi, string SatuanIsi, string KodeBarcode, float StockPesanan, float JumlahPemesanan, float JumlahPesanan, string KodeSupplier, float HargaRata, float HargaAwal, float NilaiAwal, float KomisiSalesman, string NamaFileGambar1, string NamaFileGambar2, int StRacik, string Kegunaan)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("NamaStock",NamaStock),
					new SqlParameter("Satuan",Satuan),
					new SqlParameter("JumlahStock",JumlahStock),
					new SqlParameter("PV",PV),
					new SqlParameter("BV",BV),
					new SqlParameter("StockAkhir",StockAkhir),
					new SqlParameter("HargaBeli",HargaBeli),
					new SqlParameter("NilaiStock",NilaiStock),
					new SqlParameter("HargaJual1",HargaJual1),
					new SqlParameter("HargaJual2",HargaJual2),
					new SqlParameter("HargaJual3",HargaJual3),
					new SqlParameter("KodeKelompok",KodeKelompok),
					new SqlParameter("Ukuran",Ukuran),
					new SqlParameter("StockMinimum",StockMinimum),
					new SqlParameter("Isi",Isi),
					new SqlParameter("SatuanIsi",SatuanIsi),
					new SqlParameter("KodeBarcode",KodeBarcode),
					new SqlParameter("StockPesanan",StockPesanan),
					new SqlParameter("JumlahPemesanan",JumlahPemesanan),
					new SqlParameter("JumlahPesanan",JumlahPesanan),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("HargaRata",HargaRata),
					new SqlParameter("HargaAwal",HargaAwal),
					new SqlParameter("NilaiAwal",NilaiAwal),
					new SqlParameter("KomisiSalesman",KomisiSalesman),
					new SqlParameter("NamaFileGambar1",NamaFileGambar1),
					new SqlParameter("NamaFileGambar2",NamaFileGambar2),
					new SqlParameter("StRacik",StRacik),
					new SqlParameter("Kegunaan",Kegunaan) 
				};
            Result = dbo.RunProcedure("sp_Stock_Insert", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRow(string KodeStock, string NamaStock, string Satuan, float JumlahStock, float PV, float BV, float StockAkhir, float HargaBeli, float NilaiStock, float HargaJual1, float HargaJual2, float HargaJual3, string KodeKelompok, string Ukuran, float StockMinimum, float Isi, string SatuanIsi, string KodeBarcode, float StockPesanan, float JumlahPemesanan, float JumlahPesanan, string KodeSupplier, float HargaRata, float HargaAwal, float NilaiAwal, float KomisiSalesman, string NamaFileGambar1, string NamaFileGambar2, int StRacik, string Kegunaan)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("NamaStock",NamaStock),
					new SqlParameter("Satuan",Satuan),
					new SqlParameter("JumlahStock",JumlahStock),
					new SqlParameter("PV",PV),
					new SqlParameter("BV",BV),
					new SqlParameter("StockAkhir",StockAkhir),
					new SqlParameter("HargaBeli",HargaBeli),
					new SqlParameter("NilaiStock",NilaiStock),
					new SqlParameter("HargaJual1",HargaJual1),
					new SqlParameter("HargaJual2",HargaJual2),
					new SqlParameter("HargaJual3",HargaJual3),
					new SqlParameter("KodeKelompok",KodeKelompok),
					new SqlParameter("Ukuran",Ukuran),
					new SqlParameter("StockMinimum",StockMinimum),
					new SqlParameter("Isi",Isi),
					new SqlParameter("SatuanIsi",SatuanIsi),
					new SqlParameter("KodeBarcode",KodeBarcode),
					new SqlParameter("StockPesanan",StockPesanan),
					new SqlParameter("JumlahPemesanan",JumlahPemesanan),
					new SqlParameter("JumlahPesanan",JumlahPesanan),
					new SqlParameter("KodeSupplier",KodeSupplier),
					new SqlParameter("HargaRata",HargaRata),
					new SqlParameter("HargaAwal",HargaAwal),
					new SqlParameter("NilaiAwal",NilaiAwal),
					new SqlParameter("KomisiSalesman",KomisiSalesman),
					new SqlParameter("NamaFileGambar1",NamaFileGambar1),
					new SqlParameter("NamaFileGambar2",NamaFileGambar2),
					new SqlParameter("StRacik",StRacik),
					new SqlParameter("Kegunaan",Kegunaan) 
				};
            Result = dbo.RunProcedure("sp_Stock_Update", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateRowHargaBeli(string KodeStock, float HargaBeli)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("HargaBeli",HargaBeli)
				};
            Result = dbo.RunProcedure("sp_Stock_Update_Harga_Beli", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int UpdateJumlah(string KodeStock, float JumlahStock)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("JumlahStock",JumlahStock)
				};
            Result = dbo.RunProcedure("sp_Stock_UpdateJumlah", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public int TambahJumlah(string KodeStock, float JumlahStock)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("JumlahStock",JumlahStock)
				};
            Result = dbo.RunProcedure("sp_Stock_TambahJumlah", parameters, out RowsAffected);
            return Result;
        }

        public int UpdateJumlahTerjual(string KodeStock, float JumlahStock,string IdGudang)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeStock",KodeStock),
					new SqlParameter("JumlahStock",JumlahStock),
                    new SqlParameter("idGudang",IdGudang)
				};
            Result = dbo.RunProcedure("sp_Stock_Update_Jumlah_terjual", parameters, out RowsAffected);
            return Result;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public int DeleteRow(string KodeStock)
        {
            int RowsAffected = 0;
            int Result = 0;
            
            SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("KodeStock",KodeStock) 
				};
            Result = dbo.RunProcedure("sp_Stock_DeleteRow", parameters, out RowsAffected);
            return Result;
        }

        public SqlDataReader generateNoBukti(string namaKelompok)
        {
            SqlDataReader sdr = null;
            SqlParameter[] parameters = new SqlParameter[] 
            {
					new SqlParameter("kodekelompok",namaKelompok) 
            };
            sdr = dbo.RunProcedure("get_kode_stock", parameters);
            return sdr;
        }

    }
}