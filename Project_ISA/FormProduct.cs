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
        public int pmbt = 0;
        public List<Product> product = Product.AmbilDataVerif();
        List<Panel> listPanel = new List<Panel>();

        private void FormProduct_Load(object sender, EventArgs e)
        {
            listProduct = Product.AmbilDataVerif();
            //MessageBox.Show(listProduct.Count().ToString());

            //List<string> poto = Product.AmbilFoto();

            

            //pbox.Image = Image.FromFile(@"C:\Users\satya\Pictures\hitam.jpeg");

            //MessageBox.Show(tableLayoutPanel1.ColumnCount.ToString());
            //MessageBox.Show(tableLayoutPanel1.RowCount.ToString());

            //tableLayoutPanel1.Controls.Add(pbox, 1, 1);


            int cols = 3; //Will come from database
            //int rows = 3;
            int rows = (int)Math.Ceiling((double)listProduct.Count / cols); //Will come from database
            int colWidth;
            int rowHeight;

            colWidth = 100 / cols;
            if (100 % cols != 0)
                colWidth--;

            rowHeight = 100 / rows;
            if (100 % rows != 0)
                rowHeight--;

            //MessageBox.Show(rows.ToString());
            int height = rows * 180;

            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.Parent = flowLayoutPanel1;
            tableLayoutPanel1.Size = new Size(670, height);

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = cols;

            

            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, rowHeight));
                for (int j = 0; j < cols; j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colWidth));

                    if (pmbt < product.Count)
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
                        cart.Name = listPanel.Count.ToString();
                        cart.Click += new EventHandler(Cart_Click);
                        //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                        pnl.Controls.Add(cart);

                        Label harga = new Label();
                        harga.Text = product[pmbt].Harga.ToString();
                        harga.Location = new Point(168, 5);
                        harga.BringToFront();
                        //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                        pnl.Controls.Add(harga);

                        Label co = new Label();
                        co.Text = "Check Out";
                        co.Location = new Point(150, 155);
                        co.Name = listPanel.Count.ToString();
                        co.Click += new EventHandler(Co_Click);
                        //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                        pnl.Controls.Add(co);

                        tableLayoutPanel1.Controls.Add(pnl, j, i);
                        listPanel.Add(pnl);
                        //MessageBox.Show(product[pmbt].Status.ToString());
                        //if (product[pmbt].Status == "Verified")
                        //{

                        //}
                    }
                    pmbt++;
                }
            }
            //foreach (Control c in listPanel[0].Controls)
            //{
            //    if (c is Label)
            //    {

            //        MessageBox.Show(c.ToString());
            //    }
            //}
            
        }

        private void Co_Click(object sender, EventArgs e)
        {
            Label a = sender as Label;
            //MessageBox.Show(listProduct[int.Parse(a.Name)].Nama.ToString());

            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder(listProduct[int.Parse(a.Name)]);
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            Label a = sender as Label;
            FormUtama formUtama = (FormUtama)this.Owner;

            int id = Cart.GenerateIdCard();

            Cart cart = new Cart(id, formUtama.tmpUser, listProduct[int.Parse(a.Name)], 1);

            if (cart.TambahData())
            {
                DialogResult hasil = MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK);
                if (hasil == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                throw new Exception("Tidak dapat menambahkan data");
            }
            //FormCart frm = new FormCart();
            //frm.Owner = this;
            //frm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
