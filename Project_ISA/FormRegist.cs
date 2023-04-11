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

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            try
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

                User user = new User(0, textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, int.Parse(textBoxNoTelp.Text), textBoxAlamat.Text);
                if (user.TambahData())
                {
                    MessageBox.Show("Data user berhasil disimpan.");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new Exception("Tidak dapat menambahkan data");
                }

                this.Close();
            }
            catch(Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }


        }
    }
}
