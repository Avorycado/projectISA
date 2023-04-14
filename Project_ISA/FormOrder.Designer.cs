namespace Project_ISA
{
    partial class FormOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.listBoxInfoOrder = new System.Windows.Forms.ListBox();
            this.comboBoxMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxInfoPengiriman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInfoToko = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.buttonCheckOut);
            this.panel1.Controls.Add(this.listBoxInfoOrder);
            this.panel1.Controls.Add(this.comboBoxMetodePembayaran);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxInfoPengiriman);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelInfoToko);
            this.panel1.Controls.Add(this.labelAlamat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 459);
            this.panel1.TabIndex = 6;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.Location = new System.Drawing.Point(225, 423);
            this.buttonCheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(80, 26);
            this.buttonCheckOut.TabIndex = 59;
            this.buttonCheckOut.Text = "CheckOut";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // listBoxInfoOrder
            // 
            this.listBoxInfoOrder.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxInfoOrder.FormattingEnabled = true;
            this.listBoxInfoOrder.ItemHeight = 16;
            this.listBoxInfoOrder.Location = new System.Drawing.Point(18, 245);
            this.listBoxInfoOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxInfoOrder.Name = "listBoxInfoOrder";
            this.listBoxInfoOrder.Size = new System.Drawing.Size(288, 148);
            this.listBoxInfoOrder.TabIndex = 58;
            // 
            // comboBoxMetodePembayaran
            // 
            this.comboBoxMetodePembayaran.FormattingEnabled = true;
            this.comboBoxMetodePembayaran.Items.AddRange(new object[] {
            "SisBroPay",
            "COD",
            "Transfer Bank"});
            this.comboBoxMetodePembayaran.Location = new System.Drawing.Point(151, 196);
            this.comboBoxMetodePembayaran.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMetodePembayaran.Name = "comboBoxMetodePembayaran";
            this.comboBoxMetodePembayaran.Size = new System.Drawing.Size(156, 21);
            this.comboBoxMetodePembayaran.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Metode Pembayaran : ";
            // 
            // comboBoxInfoPengiriman
            // 
            this.comboBoxInfoPengiriman.FormattingEnabled = true;
            this.comboBoxInfoPengiriman.Items.AddRange(new object[] {
            "JNE - Rp. 8000",
            "JNT - Rp. 10.000",
            "SiCepat - Rp. 12.000"});
            this.comboBoxInfoPengiriman.Location = new System.Drawing.Point(120, 150);
            this.comboBoxInfoPengiriman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxInfoPengiriman.Name = "comboBoxInfoPengiriman";
            this.comboBoxInfoPengiriman.Size = new System.Drawing.Size(156, 21);
            this.comboBoxInfoPengiriman.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Info Pengiriman : ";
            // 
            // labelInfoToko
            // 
            this.labelInfoToko.AutoSize = true;
            this.labelInfoToko.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoToko.Location = new System.Drawing.Point(10, 101);
            this.labelInfoToko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoToko.Name = "labelInfoToko";
            this.labelInfoToko.Size = new System.Drawing.Size(73, 19);
            this.labelInfoToko.TabIndex = 53;
            this.labelInfoToko.Text = "Info Toko ";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(11, 63);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(137, 19);
            this.labelAlamat.TabIndex = 51;
            this.labelAlamat.Text = "Alamat Pengiriman :  ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DeepPink;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(8, -6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 50);
            this.label6.TabIndex = 50;
            this.label6.Text = "Order";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 459);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.ListBox listBoxInfoOrder;
        private System.Windows.Forms.ComboBox comboBoxMetodePembayaran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxInfoPengiriman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInfoToko;
        private System.Windows.Forms.Button buttonCheckOut;
    }
}