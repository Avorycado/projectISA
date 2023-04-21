using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Product
    {
        #region Data Member
        private int idProduct;
        private string nama;
        private double harga;
        private string deskripsi;
        private int jumlah;
        private Category category;
        private Sellers sellers;
        private Administrator administrator;
        private string foto;
        #endregion

        #region Constructors
        public Product(int idProduct, string nama, double harga, string deskripsi, int jumlah, Category category, Sellers sellers, Administrator administrator, string foto)
        {
            this.IdProduct = idProduct;
            this.Nama = nama;
            this.Harga = harga;
            this.Deskripsi = deskripsi;
            this.Jumlah = jumlah;
            this.Category = category;
            this.Sellers = sellers;
            this.Administrator = administrator;
            this.Foto = foto;
        }
        #endregion

        #region Properties
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string Nama { get => nama; set => nama = value; }
        public double Harga { get => harga; set => harga = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public Category Category { get => category; set => category = value; }
        public Sellers Sellers { get => sellers; set => sellers = value; }
        public Administrator Administrator { get => administrator; set => administrator = value; }
        public string Foto { get => foto; set => foto = value; }
        #endregion

        #region Method
        public static List<Product> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT p.idproduct, p.nama, p.harga, p.deskripsi, p.jumlah, p.category_idcategory, p.sellers_idsellers, p.administrator_idadministrator, p.foto_product " +
                      "FROM product p inner join category c on p.category_idcategory=c.idcategory inner join sellers s on p.sellers_idsellers = s.idsellersinner join administrator a on p.administrator_idadministrator = a.idadministrator ";
            }
            else
            {
                sql = "SELECT p.idproduct, p.nama, p.harga, p.deskripsi, p.jumlah, p.category_idcategory, p.sellers_idsellers, p.administrator_idadministrator, p.foto_product " +
                      "FROM product p inner join category c on p.category_idcategory=c.idcategory inner join sellers s on p.sellers_idsellers = s.idsellersinner join administrator a on p.administrator_idadministrator = a.idadministrator " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Product> listProduct = new List<Product>();
            while (hasil.Read() == true) //selama masih ada data
            {
                //baca data dr MySqlDataReader dan simpan di objek
                Category category = Category.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                Sellers sellers = Sellers.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                Administrator administrator = Administrator.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                Product product = new Product(int.Parse(hasil.GetValue(0).ToString()),
                                                hasil.GetValue(1).ToString(),
                                                double.Parse(hasil.GetValue(2).ToString()),
                                                hasil.GetValue(3).ToString(),
                                                int.Parse(hasil.GetValue(4).ToString()),
                                                category, 
                                                sellers,
                                                administrator, hasil.GetValue(8).ToString());
                listProduct.Add(product);
            }
            return listProduct;
        }
        public bool TambahData()
        {
            string sql = "INSERT INTO product(idProduct, nama, harga, deskripsi, jumlah, category_idcategory, sellers_idsellers, administrator_idadministrator, foto_product) VALUES ('" +
                         this.IdProduct + "', '" +
                         this.Nama.Replace("'", "\\'") +
                         this.Harga + "', '" +
                         this.Deskripsi.Replace("'", "\\'") + "', '" +
                         this.Jumlah +
                         this.Category.IdCategory + "', '" +
                         this.Sellers.IdSeller + "', '" +
                         this.Administrator.IdAdministrator + "', '" +
                         this.Foto + "');";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool UbahData()
        {
            string sql = "UPDATE product " +
                         "SET " +
                         "nama = '" + this.Nama.Replace("'", "\\'") + "', " + 
                         "harga = '" + this.Harga + "', " +
                         "deskripsi = '" + this.Deskripsi.Replace("'", "\\'") + "', " +
                         "alamat = '" + this.Jumlah+ "', " +
                         "WHERE idProduct = '" + this.IdProduct + "';";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool HapusData()
        {
            string sql = "DELETE FROM product WHERE idProduct='" + this.IdProduct + "'";
            bool result = Koneksi.ExecuteDML(sql);
            return true;
        }

        public static Product AmbilDataByKode(int idproduct)
        {
            string sql = "SELECT idproduct, nama, harga, deskripsi, jumlah, category_idcategory, sellers_idsellers, administrator_idadministrator, foto_product " +
                         "FROM product " +
                         "WHERE idproduct = '" + idproduct + "'";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);
            while(hasil.Read() == true)
            {
                Category kategori = Category.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                Sellers sellers = Sellers.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                Administrator admin = Administrator.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                if (hasil.Read())
                {
                    Product produk = new Product(int.Parse(hasil.GetValue(0).ToString()),
                                                     hasil.GetValue(1).ToString(),
                                                     double.Parse(hasil.GetValue(2).ToString()),
                                                     hasil.GetValue(3).ToString(),
                                                     int.Parse(hasil.GetValue(4).ToString()),
                                                     kategori, sellers, admin, hasil.GetValue(8).ToString());
                    return produk;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public static int GenerateIdProduct()
        {
            string sql = "SELECT MAX(idproduct) " +
                         "FROM product " + ";";

            int hasilId = 0;
            MySqlDataReader hasil = Koneksi.AmbilData(sql);
            if (hasil.Read())
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    hasilId = int.Parse(hasil.GetValue(0).ToString()) + 1;
                }
                else
                {
                    hasilId = 1;
                }
            }
            return hasilId;
        }
        #endregion
    }
}
