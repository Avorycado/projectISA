using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sisbro_LIB;

namespace Project_ISA
{
    public partial class FormLogin : Form
    {
        public static Koneksi cdb;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBoxUsername_MouseLeave(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
            }
        }

        private void textBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.BackColor = Color.IndianRed;
            }
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.BackColor = Color.IndianRed;
            }

            try
            {
                if (textBoxUsername.Text == "")
                {
                    throw new Exception("Username tidak boleh kosong");
                }
                if (textBoxPassword.Text == "")
                {
                    throw new Exception("Password tidak boleh kosong");
                }


                if (radioButtonUser.Checked == true)
                {
                   
                    User tmp = User.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                    if (tmp != null)
                    {
                        string hasilDecryptUser = Cryptography.DecryptStringAES(tmp.Password , "sisbro");
                        if (Cryptography.SHA512(textBoxPassword.Text) == hasilDecryptUser)
                        {
                            FormUtama form = (FormUtama)this.Owner;
                            //FormUtama form = new FormUtama();
                            //form.ShowDialog();
                            form.tmpUser = tmp;
                            form.hasilDecrypt = hasilDecryptUser;
                            form.FormUtama_Load(this, e);
                            MessageBox.Show("Login Berhasil. Selamat datang di Aplikasi SisBro.", "Information");

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        throw new Exception("Data pengguna tidak ditemukan");
                    }
                }
                if(radioButtonSeller.Checked== true)
                {
                    Sellers tmp = Sellers.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                    if (tmp != null)
                    {
                        string hasilDecryptSeller = Cryptography.DecryptStringAES(tmp.Password, "sisbro");
                        if (Cryptography.SHA512(textBoxPassword.Text) == hasilDecryptSeller)
                        {
                            FormUtama form = (FormUtama)this.Owner;
                            //FormUtama form = new FormUtama();
                            //form.ShowDialog();
                            form.tmpSellers = tmp;
                            form.hasilDecrypt = hasilDecryptSeller;
                            form.FormUtama_Load(this, e);
                            MessageBox.Show("Login Berhasil. Selamat datang di Aplikasi SisBro.", "Information");

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        throw new Exception("Data seller tidak ditemukan");
                    }
                }
                if(radioButtonAdmin.Checked == true)
                {
                    Administrator tmp = Administrator.CekLogin(textBoxUsername.Text, textBoxPassword.Text);
                    if (tmp != null)
                    {
                        string hasilDecryptAdmin = Cryptography.DecryptStringAES(tmp.Password, "sisbro");
                        if (Cryptography.SHA512(textBoxPassword.Text) == hasilDecryptAdmin)
                        {
                            FormUtama form = (FormUtama)this.Owner;
                            //FormUtama form = new FormUtama();
                            //form.ShowDialog();
                            form.tmpAdministrator = tmp;
                            form.hasilDecrypt = hasilDecryptAdmin;
                            form.FormUtama_Load(this, e);
                            MessageBox.Show("Login Berhasil. Selamat datang di Aplikasi SisBro.", "Information");

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        throw new Exception("Data administrator tidak ditemukan");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            radioButtonUser.Checked = true;
        }

        private void textBoxUsername_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.BackColor = Color.HotPink;
            }
        }

        private void textBoxUsername_MouseLeave_1(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.BackColor = Color.HotPink;
            }
        }

        private void textBoxPassword_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.BackColor = Color.HotPink;
            }
        }

        private void textBoxPassword_MouseLeave_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
            }
        }

        private void labelDaftar_Click(object sender, EventArgs e)
        {
            FormRegist formRegist = new FormRegist();
            formRegist.Owner = this;
            formRegist.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonUser_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
