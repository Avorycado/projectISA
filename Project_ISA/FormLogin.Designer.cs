
namespace Project_ISA
{
    partial class FormLogin
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
            this.label6 = new System.Windows.Forms.Label();
            this.labelDaftar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonSeller = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.radioButtonSeller);
            this.panel1.Controls.Add(this.radioButtonUser);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelDaftar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 396);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DeepPink;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(8, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 46);
            this.label6.TabIndex = 50;
            this.label6.Text = "Sisbro Online Shop";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDaftar
            // 
            this.labelDaftar.AutoSize = true;
            this.labelDaftar.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Underline);
            this.labelDaftar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelDaftar.Location = new System.Drawing.Point(173, 298);
            this.labelDaftar.Name = "labelDaftar";
            this.labelDaftar.Size = new System.Drawing.Size(55, 25);
            this.labelDaftar.TabIndex = 49;
            this.labelDaftar.Text = "Daftar";
            this.labelDaftar.Click += new System.EventHandler(this.labelDaftar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F);
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(70, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Baru di SisBro?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(36, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "- - - - - - - - - - - - - - - - -  ATAU  - - - - - - - - - - - - - - - - -";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(30, 191);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(258, 36);
            this.buttonLogin.TabIndex = 46;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.HotPink;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Poppins", 10F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxPassword.Location = new System.Drawing.Point(34, 152);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(254, 27);
            this.textBoxPassword.TabIndex = 45;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPassword_MouseClick_1);
            this.textBoxPassword.MouseLeave += new System.EventHandler(this.textBoxPassword_MouseLeave_1);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.HotPink;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Poppins", 10F);
            this.textBoxUsername.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxUsername.Location = new System.Drawing.Point(34, 119);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(254, 27);
            this.textBoxUsername.TabIndex = 44;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxUsername_MouseClick_1);
            this.textBoxUsername.MouseLeave += new System.EventHandler(this.textBoxUsername_MouseLeave_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(114, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 43;
            this.label3.Text = "Log In";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Location = new System.Drawing.Point(34, 337);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(47, 17);
            this.radioButtonUser.TabIndex = 51;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "User";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonSeller
            // 
            this.radioButtonSeller.AutoSize = true;
            this.radioButtonSeller.Location = new System.Drawing.Point(87, 337);
            this.radioButtonSeller.Name = "radioButtonSeller";
            this.radioButtonSeller.Size = new System.Drawing.Size(51, 17);
            this.radioButtonSeller.TabIndex = 52;
            this.radioButtonSeller.TabStop = true;
            this.radioButtonSeller.Text = "Seller";
            this.radioButtonSeller.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Form Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDaftar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSeller;
        private System.Windows.Forms.RadioButton radioButtonUser;
    }
}

