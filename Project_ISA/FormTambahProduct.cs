using System;
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

        Sellers s;

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
                    size = text.Length;
                    pictureBox1.BackgroundImage = Image.FromFile(file);
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
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
                    Category c = (Category)comboBoxCategory.SelectedItem;
                    Sellers s = (Sellers)textBoxNamaToko.SelectedText;

                    Product p = new Product(int.Parse(textBoxId.Text), textBoxNamaProduk.Text, double.Parse(textBoxHarga.Text), textBoxDeskripsi.Text,
                        int.Parse(textBoxJumlah.Text), c, namat, )
                }
            }
            catch ()
            {

            }
        }
    }
}
