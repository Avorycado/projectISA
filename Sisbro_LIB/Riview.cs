using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Riview
    {
        #region Data Member
        private int idRiview;
        private string deskripsi;
        private Product product;
        #endregion

        #region Constructors
        public Riview(int idRiview, string deskripsi, Product product)
        {
            this.IdRiview = idRiview;
            this.Deskripsi = deskripsi;
            this.Product = product;
        }
        #endregion

        #region Properties
        public int IdRiview { get => idRiview; set => idRiview = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public Product Product { get => product; set => product = value; }
        #endregion

        #region Method
        public static List<Riview> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT r.idriview, r.deskripsi, r.product_idproduct " +
                      "FROM riview r inner join product p on p.idproduct = r.product_idproduct";
            }
            else
            {
                sql = "r.idriview, r.deskripsi, r.product_idproduct " +
                      "FROM riview r inner join product p on p.idproduct = r.product_idproduct " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Riview> listriview = new List<Riview>();
            while (hasil.Read() == true) //selama masih ada data
            {
                Product produk = Product.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                //baca data dr MySqlDataReader dan simpan di objek
                Riview riview = new Riview(int.Parse(hasil.GetValue(0).ToString()),
                                           hasil.GetValue(1).ToString(),
                                           produk);
                listriview.Add(riview);
            }
            return listriview;
        }
        #endregion
    }
}
