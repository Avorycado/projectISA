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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }
        public User tmpUser = null;
        public Sellers tmpSellers = null;
        public void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            try
            {
                Koneksi koneksi = new Koneksi(db.Default.DbServer, db.Default.DbName, db.Default.DbUsername, db.Default.DbPassword);
                //MessageBox.Show("Koneksi Berhasil", "Informasi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex);
            }
        }

        public void FormUtama_Load(object sender, EventArgs e, User u)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            tmpUser = u;
            try
            {
                Koneksi koneksi = new Koneksi(db.Default.DbServer, db.Default.DbName, db.Default.DbUsername, db.Default.DbPassword);
                //MessageBox.Show("Koneksi Berhasil", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex);
            }
        }

        private void pictureBoxCloth_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormCloth frm = new FormCloth();
                frm.Owner = this;
                frm.ShowDialog();
            }
            
        }

        private void labelCloth_Click(object sender, EventArgs e)
        {
            FormCloth frm = new FormCloth();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void pictureBoxShoes_Click(object sender, EventArgs e)
        {
            FormShoes frm = new FormShoes();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void labelShoes_Click(object sender, EventArgs e)
        {
            FormShoes frm = new FormShoes();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void pictureBoxBag_Click(object sender, EventArgs e)
        {
            FormBag frm = new FormBag();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void labelBag_Click(object sender, EventArgs e)
        {
            FormBag frm = new FormBag();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void pictureBoxSkincare_Click(object sender, EventArgs e)
        {
            FormSkincare frm = new FormSkincare();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void labelSkincare_Click(object sender, EventArgs e)
        {
            FormSkincare frm = new FormSkincare();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct frm = new FormProduct();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrder frm = new FormOrder();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory frm = new FormHistory();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfile frm = new FormProfile();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.Owner = this;
            frm.ShowDialog();
        }
    }
}
