﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Sisbro_LIB;

namespace Project_ISA
{
    public partial class FormTambahProduct : Form
    {
        public FormTambahProduct()
        {
            InitializeComponent();
        }
        string foto = "";
        public List<Category> listCategory = new List<Category>();
        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    foto = file;
                    size = text.Length;
                    pictureBox1.BackgroundImage = Image.FromFile(file);
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

                    //MessageBox.Show(foto);
                }
                catch (IOException)
                {
                }
            }
            
        }

        private void FormTambahProduct_Load(object sender, EventArgs e)
        {
            try
            {
                int idBaru = Product.GenerateIdProduct();
                textBoxId.Text = idBaru.ToString();

                textBoxId.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            listCategory = Category.BacaData("", "");

            comboBoxCategory.DataSource = listCategory;
            comboBoxCategory.DisplayMember = "nama";

            FormUtama formUtama = (FormUtama)this.Owner;
            textBoxNamaToko.Text = formUtama.tmpSellers.Nama;
            textBoxNamaToko.Enabled = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi k = new Koneksi();
                DialogResult hasil = MessageBox.Show("Apakah data yang anda masukkan sudah benar?", "Konfirmasi", MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if(hasil == DialogResult.Yes)
                {
                    Category category = (Category)comboBoxCategory.SelectedItem;
                    FormUtama formUtama = (FormUtama)this.Owner;

                    Product product = new Product(int.Parse(textBoxId.Text), textBoxNamaProduk.Text, double.Parse(textBoxHarga.Text), textBoxDeskripsi.Text,
                        int.Parse(textBoxJumlah.Text), category, formUtama.tmpSellers, null, foto, "Unverified");


                    if (product.TambahData())
                    {
                        DialogResult hasil2 = MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK);
                        if (hasil2 == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
