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
    public partial class FormRegist : Form
    {
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
                    if (textBoxUsername.Text == "Username")
                    {
                        textBoxUsername.BackColor = Color.IndianRed;
                    }
                    if (textBoxPassword.Text == "Password")
                    {
                        textBoxPassword.BackColor = Color.IndianRed;
                    }
                    if (textBoxConfirmPass.Text == "Confirm Password")
                    {
                        textBoxConfirmPass.BackColor = Color.IndianRed;
                    }
                    if (textBoxEmail.Text == "E-mail")
                    {
                        textBoxEmail.BackColor = Color.IndianRed;
                    }
                    if (textBoxNoTelp.Text == "No. Telepon")
                    {
                        textBoxNoTelp.BackColor = Color.IndianRed;
                    }
                    if (textBoxAlamat.Text == "Alamat")
                    {
                        textBoxAlamat.BackColor = Color.IndianRed;
                    }

                    User user = new User();
                    user.IdUser = int.Parse(textBoxId.Text);
                    user.Nama = textBoxUsername.Text;
                    user.Password = textBoxPassword.Text;
                    user.Email = textBoxEmail.Text;
                    user.NoHp = int.Parse(textBoxNoTelp.Text);
                    user.Alamat = textBoxAlamat.Text;

                    if (user.TambahData())
                    {
                        MessageBox.Show("Data berhasil disimpan");
                    }
                    else
                    {
                        throw new Exception("Tidak dapat menambahkan data");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void FormRegist_Load(object sender, EventArgs e)
        {
            try
            {
                int idBaru = User.GenerateIdUser();
                textBoxId.Text = idBaru.ToString();

                textBoxId.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
