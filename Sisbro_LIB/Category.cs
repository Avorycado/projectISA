﻿using System;
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
