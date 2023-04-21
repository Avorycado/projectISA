using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Category
    {
        #region Data Member
        private int idCategory;
        private string nama;
        #endregion

        #region Constructors
        public Category()
        {
            IdCategory = 0;
            Nama = "";
        }

        public Category(int idCategory, string nama)
        {
            this.IdCategory = idCategory;
            this.Nama = nama;
        }
        #endregion

        #region Properties
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Method
        public static List<Category> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT idcategory, nama " +
                      "FROM category ";
            }
            else
            {
                sql = "SELECT idcategory, nama " +
                      "FROM category " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Category> listCategory= new List<Category>();
            while (hasil.Read() == true) //selama masih ada data
            {
                Category category = new Category(int.Parse(hasil.GetValue(0).ToString()),
                                           hasil.GetValue(1).ToString());
                listCategory.Add(category);
            }
            return listCategory;
        }

        public bool TambahData()
        {
            string sql = "INSERT INTO category(idCategory, nama) VALUES ('" +
                         this.IdCategory + "', '" +
                         this.Nama + ";";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public static Category AmbilDataByKode(int idcategory)
        {
            string sql = "SELECT idcategory, nama " +
                         "FROM category " +
                         "WHERE idcategory = '" + idcategory + "'";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read())
            {
                Category kategori = new Category(int.Parse(hasil.GetValue(0).ToString()),
                                                 hasil.GetValue(1).ToString());
                return kategori;
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
