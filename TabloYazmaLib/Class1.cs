using System;
using System.Data;

namespace TabloYazmaLib
{
    public class TabloOlusturma
    {
        public DataTable TabloOlustur(string Ad)
        {
            DataTable Temp = new DataTable();
            Temp.TableName = Ad;
            return Temp;

        }

        public void TabloyaTekSutunEkle(DataTable dataTableAdı,string eklenecekKolonBilgisi)
        {
            dataTableAdı.Columns.Add(eklenecekKolonBilgisi);

        }

        public void TabloyaTekSatırEkle(DataTable dataTableAdı,string kolonBilgisi, string eklenecekSey)
        {
            DataRow row = dataTableAdı.NewRow();
            row[kolonBilgisi] = eklenecekSey;
            dataTableAdı.Rows.Add(row);
        }
    }
}
