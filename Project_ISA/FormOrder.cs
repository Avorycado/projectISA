﻿using System;
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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
        public User u;
        private void FormOrder_Load(object sender, EventArgs e)
        {
            labelAlamat.Text = "Alamat Pengiriman: " + u.Alamat;
        }
    }
}
