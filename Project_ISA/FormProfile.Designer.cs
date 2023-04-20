
namespace Project_ISA
{
    partial class FormProfile
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNoTelp = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(296, 28);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(41, 13);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama: ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(296, 63);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email: ";
            // 
            // labelNoTelp
            // 
            this.labelNoTelp.AutoSize = true;
            this.labelNoTelp.Location = new System.Drawing.Point(296, 99);
            this.labelNoTelp.Name = "labelNoTelp";
            this.labelNoTelp.Size = new System.Drawing.Size(72, 13);
            this.labelNoTelp.TabIndex = 3;
            this.labelNoTelp.Text = "No. Telepon: ";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(296, 134);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(45, 13);
            this.labelAlamat.TabIndex = 4;
            this.labelAlamat.Text = "Alamat: ";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(536, 223);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNoTelp);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNoTelp;
        private System.Windows.Forms.Label labelAlamat;
    }
}