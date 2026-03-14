namespace Restaurant_Management_System_v0._1
{
    partial class signupForm
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
            this.close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelYesaccount1 = new System.Windows.Forms.Label();
            this.Signup_username = new System.Windows.Forms.TextBox();
            this.Signup_password = new System.Windows.Forms.TextBox();
            this.Signup_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.Signup_showPassword = new System.Windows.Forms.CheckBox();
            this.Signup_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Firebrick;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(279, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(52, 31);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hello new user!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(114, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 35);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Confirm Password";
            // 
            // LabelYesaccount1
            // 
            this.LabelYesaccount1.AutoSize = true;
            this.LabelYesaccount1.Location = new System.Drawing.Point(24, 537);
            this.LabelYesaccount1.Name = "LabelYesaccount1";
            this.LabelYesaccount1.Size = new System.Drawing.Size(300, 22);
            this.LabelYesaccount1.TabIndex = 23;
            this.LabelYesaccount1.Text = "Have account already? Sign In here.";
            this.LabelYesaccount1.Click += new System.EventHandler(this.LabelYesaccount1_Click);
            // 
            // Signup_username
            // 
            this.Signup_username.Location = new System.Drawing.Point(27, 271);
            this.Signup_username.Name = "Signup_username";
            this.Signup_username.Size = new System.Drawing.Size(297, 28);
            this.Signup_username.TabIndex = 24;
            // 
            // Signup_password
            // 
            this.Signup_password.Location = new System.Drawing.Point(28, 327);
            this.Signup_password.Name = "Signup_password";
            this.Signup_password.PasswordChar = '*';
            this.Signup_password.Size = new System.Drawing.Size(297, 28);
            this.Signup_password.TabIndex = 25;
            // 
            // Signup_ConfirmPassword
            // 
            this.Signup_ConfirmPassword.Location = new System.Drawing.Point(29, 395);
            this.Signup_ConfirmPassword.Name = "Signup_ConfirmPassword";
            this.Signup_ConfirmPassword.PasswordChar = '*';
            this.Signup_ConfirmPassword.Size = new System.Drawing.Size(297, 28);
            this.Signup_ConfirmPassword.TabIndex = 26;
            // 
            // Signup_showPassword
            // 
            this.Signup_showPassword.AutoSize = true;
            this.Signup_showPassword.Location = new System.Drawing.Point(29, 438);
            this.Signup_showPassword.Name = "Signup_showPassword";
            this.Signup_showPassword.Size = new System.Drawing.Size(163, 26);
            this.Signup_showPassword.TabIndex = 27;
            this.Signup_showPassword.Text = "Show password";
            this.Signup_showPassword.UseVisualStyleBackColor = true;
            this.Signup_showPassword.CheckedChanged += new System.EventHandler(this.Signup_showPassword_CheckedChanged_1);
            // 
            // Signup_btn
            // 
            this.Signup_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Signup_btn.FlatAppearance.BorderSize = 0;
            this.Signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signup_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Signup_btn.Location = new System.Drawing.Point(12, 486);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(319, 36);
            this.Signup_btn.TabIndex = 28;
            this.Signup_btn.Text = "Register";
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 621);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.Signup_showPassword);
            this.Controls.Add(this.Signup_ConfirmPassword);
            this.Controls.Add(this.Signup_password);
            this.Controls.Add(this.Signup_username);
            this.Controls.Add(this.LabelYesaccount1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signupForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelYesaccount1;
        private System.Windows.Forms.TextBox Signup_username;
        private System.Windows.Forms.TextBox Signup_password;
        private System.Windows.Forms.TextBox Signup_ConfirmPassword;
        private System.Windows.Forms.CheckBox Signup_showPassword;
        private System.Windows.Forms.Button Signup_btn;
    }
}