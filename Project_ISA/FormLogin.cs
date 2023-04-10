using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ISA
{
    public partial class FormLogin : Form
    {
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
                if(radioButtonUser.Checked == true)
                {

                }
            }
            catch
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        
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
                textBoxPassword.BackColor = Color.White;
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
    }
}
