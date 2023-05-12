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
    public partial class FormUpdatePassword : Form
    {
        public User user;
        public Sellers seller;
        public string hasilDecrypt = "";
        public FormUpdatePassword()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (Cryptography.SHA512(textBoxOldPassword.Text) == hasilDecrypt)
            {
                if (textBoxNewPassword.Text == textBoxRetypePassword.Text)
                {
                    if (user != null)
                    {

                        //Convert new password to SHA512
                        string resultSHA = Cryptography.SHA512(textBoxNewPassword.Text);

                        //Convert SHA512 to encrypt
                        string resultAES = Cryptography.EncryptStringAES(resultSHA, "sisbro");

                        //Convert resultAES to stegano
                        

                        user = new User(user.IdUser, user.Nama, resultAES, user.Email, user.NoHp, user.Alamat, user.Saldo, user.Foto);
                        user.Update(user);
                        MessageBox.Show("Update Succesfull");
                    }
                    else
                    {
                       

                        //Convert new password to SHA512
                        string resultSHA = Cryptography.SHA512(textBoxNewPassword.Text);

                        //Convert SHA512 to encrypt
                        string resultAES = Cryptography.EncryptStringAES(resultSHA, "sisbro");

                        

                        seller = new Sellers(seller.IdSeller, seller.Nama, seller.Email, seller.NoHp, seller.Alamat, 
                            seller.Password, seller.Foto);
                        seller.UbahData(seller);
                        MessageBox.Show("Update Succesfull");
                    }
                }
                else
                {
                    MessageBox.Show("Please entry the correct retype password!");
                }
            }
            else
            {
                MessageBox.Show("Please fill the correct old-password!");
            }
        }

        private void FormUpdatePassword_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxOldPassword.PasswordChar = '\0';
                textBoxNewPassword.PasswordChar = '\0';
                textBoxRetypePassword.PasswordChar = '\0';
            }
            else
            {
                textBoxOldPassword.PasswordChar = '*';
                textBoxNewPassword.PasswordChar = '*';
                textBoxRetypePassword.PasswordChar = '*';
            }
        }
    }
}
