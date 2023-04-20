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
    public partial class FormSkincare : Form
    {
        public FormSkincare()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormUtama frm = new FormUtama();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
