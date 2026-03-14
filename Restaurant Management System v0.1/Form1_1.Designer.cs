namespace Restaurant_Management_System_v0._1
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelNoaccount = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Login_username = new System.Windows.Forms.TextBox();
            this.Login_password = new System.Windows.Forms.TextBox();
            this.Login_showPassword = new System.Windows.Forms.CheckBox();
            this.Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 35);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(121, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome back!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // LabelNoaccount
            // 
            this.LabelNoaccount.AutoSize = true;
            this.LabelNoaccount.Location = new System.Drawing.Point(47, 492);
            this.LabelNoaccount.Name = "LabelNoaccount";
            this.LabelNoaccount.Size = new System.Drawing.Size(258, 22);
            this.LabelNoaccount.TabIndex = 10;
            this.LabelNoaccount.Text = "No account yet? Register here.";
            this.LabelNoaccount.Click += new System.EventHandler(this.LabelNoaccount_Click_1);
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Login_btn.Location = new System.Drawing.Point(13, 442);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(319, 36);
            this.Login_btn.TabIndex = 11;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click_1);
            // 
            // Login_username
            // 
            this.Login_username.Location = new System.Drawing.Point(34, 267);
            this.Login_username.Name = "Login_username";
            this.Login_username.Size = new System.Drawing.Size(297, 28);
            this.Login_username.TabIndex = 12;
            // 
            // Login_password
            // 
            this.Login_password.Location = new System.Drawing.Point(34, 338);
            this.Login_password.Name = "Login_password";
            this.Login_password.PasswordChar = '*';
            this.Login_password.Size = new System.Drawing.Size(297, 28);
            this.Login_password.TabIndex = 13;
            // 
            // Login_showPassword
            // 
            this.Login_showPassword.AutoSize = true;
            this.Login_showPassword.Location = new System.Drawing.Point(34, 372);
            this.Login_showPassword.Name = "Login_showPassword";
            this.Login_showPassword.Size = new System.Drawing.Size(163, 26);
            this.Login_showPassword.TabIndex = 14;
            this.Login_showPassword.Text = "Show password";
            this.Login_showPassword.UseVisualStyleBackColor = true;
            this.Login_showPassword.CheckedChanged += new System.EventHandler(this.Login_showPassword_CheckedChanged_1);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Firebrick;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(291, 1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(52, 31);
            this.Close.TabIndex = 15;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 621);
            this.Controls.Add(this.Login_showPassword);
            this.Controls.Add(this.Login_password);
            this.Controls.Add(this.Login_username);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.LabelNoaccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelNoaccount;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox Login_username;
        private System.Windows.Forms.TextBox Login_password;
        private System.Windows.Forms.CheckBox Login_showPassword;
        private System.Windows.Forms.Button Close;
    }
}

