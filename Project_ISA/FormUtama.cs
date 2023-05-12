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
        public Administrator tmpAdministrator = null;

        public Product tmpProduct = null;

        public string hasilDecrypt = "";

        public void FormUtama_Load(object sender, EventArgs e)
        {
            
            //this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
            try
            {
                Koneksi koneksi = new Koneksi(db.Default.DbServer, db.Default.DbName, db.Default.DbUsername, db.Default.DbPassword);
                ////labeluser.text = tmpuser.nama;
                ////labelstatus.text = "log in";
                //MessageBox.Show("Koneksi Berhasil", "Informasi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex);
            } 

            if (tmpSellers != null)
            {
                productsToolStripMenuItem.Visible = true;
                productsToolStripMenuItem1.Visible = false;
                accProductsToolStripMenuItem.Visible = false;
                yourOrdersToolStripMenuItem.Visible = false;
                cartsToolStripMenuItem.Visible = false;
                historyOrdersToolStripMenuItem.Visible = false;
                addPaymentMethodsToolStripMenuItem.Visible = false;
                profileToolStripMenuItem.Visible = false;

                updatePasswordToolStripMenuItem.Visible = true;
                addProductsToolStripMenuItem.Visible = true;
                logInToolStripMenuItem.Visible = true;
                logInToolStripMenuItem.Visible = true;
                exitToolStripMenuItem.Visible = true;
            }
            else if(tmpAdministrator != null)
            {
                productsToolStripMenuItem.Visible = true;
                productsToolStripMenuItem1.Visible = false;
                addProductsToolStripMenuItem.Visible = false;
                yourOrdersToolStripMenuItem.Visible = false;
                cartsToolStripMenuItem.Visible = false;
                historyOrdersToolStripMenuItem.Visible = false;
                profileToolStripMenuItem.Visible = false;
                updatePasswordToolStripMenuItem.Visible = false;

                accProductsToolStripMenuItem.Visible = true;
                addPaymentMethodsToolStripMenuItem.Visible = true;
                logInToolStripMenuItem.Visible = true;
                logInToolStripMenuItem.Visible = true;
                exitToolStripMenuItem.Visible = true;
            }
            else
            {
                addPaymentMethodsToolStripMenuItem.Visible = false;
                addProductsToolStripMenuItem.Visible = false;
                accProductsToolStripMenuItem.Visible = false;

                updatePasswordToolStripMenuItem.Visible = true;
                productsToolStripMenuItem1.Visible = true;
                historyOrdersToolStripMenuItem.Visible = true;
                cartsToolStripMenuItem.Visible = true;
                ordersToolStripMenuItem.Visible = true;
                profileToolStripMenuItem.Visible = true;
                productsToolStripMenuItem.Visible = true;
                logInToolStripMenuItem.Visible = true;
                logInToolStripMenuItem.Visible = true;
                exitToolStripMenuItem.Visible = true;
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
            if(tmpUser != null || tmpSellers != null || tmpAdministrator != null)
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
                //frm.ShowDialog();

                if(frm.ShowDialog() == DialogResult.OK)
                {
                    
                    if(tmpUser != null)
                    {
                        labelUser.Text = "User: " + tmpUser.Nama;
                        labelStatus.Text = "Status: Log In";
                    }
                    else if(tmpSellers != null)
                    {
                        labelUser.Text = "User: " + tmpSellers.Nama;
                        labelStatus.Text = "Status: Log In";
                    }
                    else
                    {
                        labelUser.Text = "User: " + tmpAdministrator.Nama;
                        labelStatus.Text = "Status: Log In";
                        //MessageBox.Show(tmpAdministrator.ToString());
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
            else if (tmpSellers != null)
            {
                tmpSellers = null;
                FormUtama_Load(this, e);
                MessageBox.Show("Anda berhasil Log Out!");
                addProductsToolStripMenuItem.Visible = true;
                historyOrdersToolStripMenuItem.Visible = true;
                cartsToolStripMenuItem.Visible = true;
                ordersToolStripMenuItem.Visible = true;
                profileToolStripMenuItem.Visible = true;
            }
            else if(tmpAdministrator != null)
            {
                tmpAdministrator = null;
                FormUtama_Load(this, e);
                MessageBox.Show("Anda berhasil Log Out!");
                accProductsToolStripMenuItem.Visible = true;
                historyOrdersToolStripMenuItem.Visible = true;
                cartsToolStripMenuItem.Visible = true;
                ordersToolStripMenuItem.Visible = true;
                profileToolStripMenuItem.Visible = true;
            }
            else
            {
                MessageBox.Show("Akun anda tidak sedang Log In!");
            }            
        }
  
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolSlripMenuItemLogOut_Click(object sender, EventArgs e)
        {
            if (tmpSellers != null)
            {
                tmpSellers = null;
                FormUtama_Load(this, e);
                MessageBox.Show("Anda berhasil Log Out!");

                labelUser.Text = "User: ";
                labelStatus.Text = "Status: Not in Account";
            }

            if (tmpAdministrator != null)
            {
                tmpAdministrator = null;
                FormUtama_Load(this, e);
                MessageBox.Show("Anda berhasil Log Out!");

                labelUser.Text = "Administrator: ";
                labelStatus.Text = "Status: Not in Account";
            }
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tmpAdministrator != null)
            {
                tmpAdministrator = null;
                FormUtama_Load(this, e);
                MessageBox.Show("Anda berhasil Log Out!");

                labelUser.Text = "Admin: ";
                labelStatus.Text = "Status: Not in Account";
            }
            else
            {
                MessageBox.Show("Akun anda tidak sedang Log In!");
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yourOrdersToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpSellers == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormTambahProduct frm = new FormTambahProduct();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void cartsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void historyOrdersToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void accProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpAdministrator == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormVerifikasi frm = new FormVerifikasi();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpSellers != null || tmpUser != null )
            {
                FormUpdatePassword frm = new FormUpdatePassword();
                frm.hasilDecrypt = hasilDecrypt;
                frm.user = tmpUser;
                frm.seller = tmpSellers;
                frm.Owner = this;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Log In terlebih dahulu untuk melanjutkan pembelian!");
            }
        }

        private void addPaymentMethodsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (tmpAdministrator == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormAddPaymentMethods frm = new FormAddPaymentMethods();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tmpAdministrator == null)
            {
                MessageBox.Show("Login terlebih dahulu untuk melanjutkan pembelian!");
            }
            else
            {
                FormAddCategory frm = new FormAddCategory();
                frm.Owner = this;
                frm.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
