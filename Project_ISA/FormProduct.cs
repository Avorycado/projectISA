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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        PictureBox pbox;
        Product p;
        public List<Product> listProduct = new List<Product>();

        private void FormProduct_Load(object sender, EventArgs e)
        {
            listProduct = Product.AmbilFoto();
            //MessageBox.Show(listProduct.Count().ToString());

            //List<string> poto = Product.AmbilFoto();

            List<Product> product = Product.AmbilFoto();

            //pbox.Image = Image.FromFile(@"C:\Users\satya\Pictures\hitam.jpeg");

            //MessageBox.Show(tableLayoutPanel1.ColumnCount.ToString());
            //MessageBox.Show(tableLayoutPanel1.RowCount.ToString());

            //tableLayoutPanel1.Controls.Add(pbox, 1, 1);


            int cols = 3; //Will come from database
            int rows = 3;
            //int rows = (int)Math.Round((double)poto.Count / cols); //Will come from database
            int colWidth;
            int rowHeight;

            colWidth = 100 / cols;
            if (100 % cols != 0)
                colWidth--;

            rowHeight = 100 / rows;
            if (100 % rows != 0)
                rowHeight--;


            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = cols;

            int pmbt = 0;

            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, rowHeight));
                for (int j = 0; j < cols; j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colWidth));

                    if (pmbt < product.Count)
                    {
                        //MessageBox.Show(product[pmbt].Status.ToString());
                        if (product[pmbt].Status == "Verified")
                        {
                            Panel pnl = new Panel();
                            pnl.Size = new Size(212, 171);
                            pnl.Anchor = AnchorStyles.Top;

                            pbox = new PictureBox();
                            pbox.Image = Image.FromFile(@"" + product[pmbt].Foto);
                            pbox.Size = new Size(202, 128);
                            pbox.Location = new Point(5, 23);
                            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                            //pbox.Anchor = AnchorStyles.Top;
                            pnl.Controls.Add(pbox);

                            Label nama = new Label();
                            nama.Text = product[pmbt].Nama;
                            nama.Location = new Point(5, 5);
                            //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                            pnl.Controls.Add(nama);

                            Label cart = new Label();
                            cart.Text = "Add To Cart";
                            cart.Location = new Point(5, 155);
                            cart.Click += new EventHandler(Cart_Click);
                            //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                            pnl.Controls.Add(cart);

                            

                            Label harga = new Label();
                            harga.Text = product[pmbt].Harga.ToString();
                            harga.Location = new Point(175, 5);
                            harga.BringToFront();
                            //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                            pnl.Controls.Add(harga);

                            Label co = new Label();
                            co.Text = "Check Out";
                            co.Location = new Point(150, 155);
                            co.Click += new EventHandler(Co_Click);
                            //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                            pnl.Controls.Add(co);


                            tableLayoutPanel1.Controls.Add(pnl, j, i);
                        }
                        //pbox = new PictureBox();
                        //pbox.Image = Image.FromFile(@"" + product[pmbt].Foto);
                        //pbox.Size = new Size(172, 125);
                        ////pbox.Dock = DockStyle.Fill;
                        //pbox.Anchor = AnchorStyles.Top;
                        //pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                        //tableLayoutPanel1.Controls.Add(pbox, j, i);

                        //Label productName = new Label();
                        //productName.Text = product[pmbt].Nama;
                        //productName.Anchor = AnchorStyles.Bottom;
                        //tableLayoutPanel1.Controls.Add(productName, j, i);
                    }
                    pmbt++;

                }

            }
        }

        private void Co_Click(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder();
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            FormCart frm = new FormCart();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
