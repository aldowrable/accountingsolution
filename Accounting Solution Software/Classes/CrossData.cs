using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Accounting_Solution_Software.Classes
{
    class CrossData
    {
        public String kodeStock = "", namaStock = "", satuan = "";

        public CrossData()
        {
        }

        public ArrayList getStockData()
        {
            ArrayList stockAL = new ArrayList();
            stockAL.Add(this.KodeStock);
            stockAL.Add(this.NamaStock);
            stockAL.Add(this.Satuan);
            return stockAL;
        }

        public void setStockData(String kodeStock, String namaStock, String satuan)
        {
            this.kodeStock = kodeStock;
            this.namaStock = namaStock;
            this.satuan = satuan;
        }

        public string KodeStock { get; set; }
        public string NamaStock { get; set; }
        public string Satuan { get; set; }

    }
}
