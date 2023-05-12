using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sisbro_LIB;

namespace Project_ISA
{
    public partial class FormRegist : Form
    {
        public User tmpUser = null;
        public Sellers tmpSellers = null;
        string foto = "";
        string file = "";
        public FormRegist()
        {
            InitializeComponent();
        }
        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignUp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxAgree.Checked == true)
                {
                    if (radioButtonPembeli.Checked == true)
                    {
                        if(textBoxPassword.Text != null)
                        {
                            if(file != "")
                            {
                                string username = textBoxUsername.Text;
                                string text = Cryptography.SHA512(textBoxPassword.Text);
                                string key = "sisbro";

                                Bitmap pict = new Bitmap(file);

                                string hasilAES = Cryptography.EncryptStringAES(text, key);
                                Bitmap bmp = Steganography.embedText(hasilAES, pict);

                                User user = new User(int.Parse(textBoxId.Text), textBoxUsername.Text,
                                                 hasilAES, textBoxEmail.Text,
                                                 int.Parse(textBoxNoTelp.Text), textBoxAlamat.Text, 0, file);

                                
                                pict.Save(@"C:\xampp\htdocs\img\" + textBoxId.Text + ".png");

                                if (user.TambahData())
                                {
                                    DialogResult hasil = MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK);
                                    if (hasil == DialogResult.OK)
                                    {
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    throw new Exception("Tidak dapat menambahkan data");
                                }
                            }
                            else
                            {
                                throw new Exception("Foto Profile tidak boleh kosong.");
                            }
                        }
                    }
                    else if(radioButtonPenjual.Checked == true)
                    {
                        if(file != "")
                        {
                            string text = Cryptography.SHA512(textBoxPassword.Text);
                            string key = "sisbro";

                            Bitmap pict = new Bitmap(file);

                            string hasilAES = Cryptography.EncryptStringAES(text, key);
                            Bitmap bmp = Steganography.embedText(hasilAES, pict);

                            Sellers seller = new Sellers(int.Parse(textBoxId.Text),
                                                        textBoxUsername.Text,
                                                        textBoxEmail.Text,
                                                        int.Parse(textBoxNoTelp.Text),
                                                        textBoxAlamat.Text,
                                                        hasilAES,
                                                        file);

                            pict.Save(@"C:\xampp\htdocs\img\" + textBoxId.Text + ".png");

                            if (seller.TambahData())
                            {
                                DialogResult hasil = MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK);
                                if (hasil == DialogResult.OK)
                                {
                                    this.Close();
                                }
                            }
                            else
                            {
                                throw new Exception("Tidak dapat menambahkan data");
                            }
                        }
                        else
                        {
                            throw new Exception("Foto Profile tidak boleh kosong.");
                        }
                        

                    }
                    else
                    {
                        string text = Cryptography.SHA512(textBoxPassword.Text);
                        string key = "sisbro";
                        string hasilAES = Cryptography.EncryptStringAES(text, key);
                        Administrator administrator = new Administrator(int.Parse(textBoxId.Text), 
                                                                        textBoxUsername.Text, 
                                                                        textBoxEmail.Text, 
                                                                        int.Parse(textBoxNoTelp.Text), 
                                                                        hasilAES);
                        if (administrator.TambahData())
                        {
                            DialogResult hasil = MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK);
                            if (hasil == DialogResult.OK)
                            {
                                this.Close();
                            }
                            else
                            {
                                throw new Exception("Tidak dapat menambahkan data");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Setujui Term and Conditions");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRegist_Load(object sender, EventArgs e)
        {
            if (radioButtonPembeli.Checked == true)
            {
                try
                {
                    int idBaru = User.GenerateIdUser();
                    textBoxId.Text = idBaru.ToString();

                    textBoxId.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(radioButtonPenjual.Checked == true)
            {
                try
                {
                    int idBaru = Sellers.GenerateIdSeller();
                    textBoxId.Text = idBaru.ToString();

                    textBoxId.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    int idBaru = Administrator.GenerateIdAdmin();
                    textBoxId.Text = idBaru.ToString();

                    textBoxId.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButtonPembeli_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idBaru = User.GenerateIdUser();
                textBoxId.Text = idBaru.ToString();

                textBoxId.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonPenjual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idBaru = Sellers.GenerateIdSeller();
                textBoxId.Text = idBaru.ToString();

                textBoxId.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idBaru = Administrator.GenerateIdAdmin();
                textBoxId.Text = idBaru.ToString();

                textBoxId.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idBaru = Administrator.GenerateIdAdmin();
                textBoxId.Text = idBaru.ToString();

                textBoxId.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    pictureBox1.BackgroundImage = Image.FromFile(file);
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

                    MessageBox.Show(file);

                    foto = file;
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
