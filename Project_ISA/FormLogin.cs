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

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.BackColor = Color.White;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "Username")
            {
                textBoxUsername.BackColor = Color.IndianRed;
            }
            if (textBoxUsername.Text == "Password")
            {
                textBoxUsername.BackColor = Color.IndianRed;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormRegist formRegist = new FormRegist();
            formRegist.Owner = this;
            formRegist.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        
        }
    }
}
