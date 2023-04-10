
namespace Project_ISA
{
    partial class FormRegist
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
            this.labelClose = new System.Windows.Forms.Label();
            this.checkBoxAgree = new System.Windows.Forms.CheckBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNoTelp = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Controls.Add(this.checkBoxAgree);
            this.panel1.Controls.Add(this.buttonSignUp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 2;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.HotPink;
            this.labelClose.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelClose.Location = new System.Drawing.Point(741, 13);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(22, 28);
            this.labelClose.TabIndex = 6;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // checkBoxAgree
            // 
            this.checkBoxAgree.AutoSize = true;
            this.checkBoxAgree.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.checkBoxAgree.ForeColor = System.Drawing.Color.LavenderBlush;
            this.checkBoxAgree.Location = new System.Drawing.Point(429, 239);
            this.checkBoxAgree.Name = "checkBoxAgree";
            this.checkBoxAgree.Size = new System.Drawing.Size(215, 23);
            this.checkBoxAgree.TabIndex = 5;
            this.checkBoxAgree.Text = "I agree with Terms and Conditions";
            this.checkBoxAgree.UseVisualStyleBackColor = true;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.White;
            this.buttonSignUp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.Location = new System.Drawing.Point(429, 262);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(262, 40);
            this.buttonSignUp.TabIndex = 4;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(425, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aplikasi berbelanja yang aman dan terpercaya.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(422, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 84);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sudah siap berbelanja\r\ndengan SisBro?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Controls.Add(this.textBoxAlamat);
            this.panel2.Controls.Add(this.textBoxNoTelp);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.textBoxConfirmPass);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.textBoxUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 401);
            this.panel2.TabIndex = 1;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.BackColor = System.Drawing.Color.HotPink;
            this.textBoxAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlamat.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxAlamat.Location = new System.Drawing.Point(29, 321);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(273, 26);
            this.textBoxAlamat.TabIndex = 6;
            this.textBoxAlamat.Text = "Alamat";
            // 
            // textBoxNoTelp
            // 
            this.textBoxNoTelp.BackColor = System.Drawing.Color.HotPink;
            this.textBoxNoTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNoTelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoTelp.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxNoTelp.Location = new System.Drawing.Point(29, 280);
            this.textBoxNoTelp.Name = "textBoxNoTelp";
            this.textBoxNoTelp.Size = new System.Drawing.Size(273, 26);
            this.textBoxNoTelp.TabIndex = 5;
            this.textBoxNoTelp.Text = "No. Telepon";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.HotPink;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxEmail.Location = new System.Drawing.Point(29, 237);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(273, 26);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Text = "E-mail";
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.BackColor = System.Drawing.Color.HotPink;
            this.textBoxConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPass.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxConfirmPass.Location = new System.Drawing.Point(29, 193);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(273, 26);
            this.textBoxConfirmPass.TabIndex = 3;
            this.textBoxConfirmPass.Text = "Confirm Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.HotPink;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxPassword.Location = new System.Drawing.Point(29, 148);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(273, 26);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.HotPink;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.LavenderBlush;
            this.textBoxUsername.Location = new System.Drawing.Point(29, 104);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(273, 26);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // FormRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegist";
            this.Text = "FormRegist";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.CheckBox checkBoxAgree;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNoTelp;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
    }
}