
namespace Project_ISA
{
    partial class FormTambahProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNamaToko = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxDeskripsi = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxNamaProduk = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Input Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(111, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.HotPink;
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxId.Location = new System.Drawing.Point(56, 239);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(273, 26);
            this.textBoxId.TabIndex = 14;
            // 
            // textBoxNamaToko
            // 
            this.textBoxNamaToko.BackColor = System.Drawing.Color.HotPink;
            this.textBoxNamaToko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNamaToko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaToko.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxNamaToko.Location = new System.Drawing.Point(56, 497);
            this.textBoxNamaToko.Name = "textBoxNamaToko";
            this.textBoxNamaToko.Size = new System.Drawing.Size(273, 26);
            this.textBoxNamaToko.TabIndex = 13;
            this.textBoxNamaToko.Text = "Nama Toko";
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.BackColor = System.Drawing.Color.HotPink;
            this.textBoxJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJumlah.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxJumlah.Location = new System.Drawing.Point(56, 413);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(273, 26);
            this.textBoxJumlah.TabIndex = 11;
            this.textBoxJumlah.Text = "Jumlah";
            // 
            // textBoxDeskripsi
            // 
            this.textBoxDeskripsi.BackColor = System.Drawing.Color.HotPink;
            this.textBoxDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeskripsi.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxDeskripsi.Location = new System.Drawing.Point(56, 369);
            this.textBoxDeskripsi.Name = "textBoxDeskripsi";
            this.textBoxDeskripsi.Size = new System.Drawing.Size(273, 26);
            this.textBoxDeskripsi.TabIndex = 10;
            this.textBoxDeskripsi.Text = "Deskripsi";
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.BackColor = System.Drawing.Color.HotPink;
            this.textBoxHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHarga.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxHarga.Location = new System.Drawing.Point(56, 324);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(273, 26);
            this.textBoxHarga.TabIndex = 9;
            this.textBoxHarga.Text = "Harga";
            // 
            // textBoxNamaProduk
            // 
            this.textBoxNamaProduk.BackColor = System.Drawing.Color.HotPink;
            this.textBoxNamaProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNamaProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaProduk.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxNamaProduk.Location = new System.Drawing.Point(56, 280);
            this.textBoxNamaProduk.Name = "textBoxNamaProduk";
            this.textBoxNamaProduk.Size = new System.Drawing.Size(273, 26);
            this.textBoxNamaProduk.TabIndex = 8;
            this.textBoxNamaProduk.Text = "Nama Produk";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(39, 537);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(303, 36);
            this.buttonSubmit.TabIndex = 47;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.HotPink;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(56, 456);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(273, 28);
            this.comboBoxCategory.TabIndex = 48;
            // 
            // FormTambahProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(380, 585);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxNamaToko);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxDeskripsi);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNamaProduk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormTambahProduct";
            this.Text = "FormTambahProduct";
            this.Load += new System.EventHandler(this.FormTambahProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNamaToko;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxDeskripsi;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxNamaProduk;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}