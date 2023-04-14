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
            //this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            try
            {
                Koneksi koneksi = new Koneksi(db.Default.DbServer, db.Default.DbName, db.Default.DbUsername, db.Default.DbPassword);
                //labelUser.Text = tmpUser.Nama;
                //labelStatus.Text = "Log In";
                //MessageBox.Show("Koneksi Berhasil", "Informasi");
            }
            catch(Exception ex)
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

        private void pictureBoxShoes_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormShoes frm = new FormShoes();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void labelShoes_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormShoes frm = new FormShoes();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void pictureBoxBag_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormBag frm = new FormBag();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void labelBag_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormBag frm = new FormBag();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void pictureBoxSkincare_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormSkincare frm = new FormSkincare();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void labelSkincare_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormSkincare frm = new FormSkincare();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormProduct frm = new FormProduct();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormCart frm = new FormCart();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormOrder frm = new FormOrder();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormHistory frm = new FormHistory();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpUser == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormProfile frm = new FormProfile();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tmpUser != null || tmpSellers != null)
            {
                if(logInToolStripMenuItem.Enabled == true)
                {
                    MessageBox.Show("Anda sudah login.");
                }
            }
            else
            {
                FormLogin frm = new FormLogin();
                frm.Owner = this;
                frm.ShowDialog();

                if(frm.ShowDialog() == DialogResult.OK)
                {
                    labelUser.Text = "User: " + tmpUser.Nama;
                    if(tmpUser != null)
                    {
                        labelStatus.Text = "Status: Log In";
                    }
                    else
                    {
                        labelStatus.Text = "Status: Log In";
                    }
                }
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(tmpUser != null)
            {
                tmpUser = null;
                FormUtama_Load(this, e);
                MessageBox.Show("Anda berhasil Log Out!");

                labelUser.Text = "User: ";
                labelStatus.Text = "Status: Not in Account";
            }
            else
            {
                MessageBox.Show("Akun anda tidak sedang Log In!");
            }

            if(tmpSellers != null)
            {
                tmpSellers = null;
                FormUtama_Load(this, e);
                MessageBox.Show("Anda berhasil Log Out!");

                labelUser.Text = "User: ";
                labelStatus.Text = "Status: Not in Account";
            }
        }

        private void labelUser_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
