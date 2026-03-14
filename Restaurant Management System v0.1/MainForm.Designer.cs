namespace Restaurant_Management_System_v0._1
{
    partial class MainForm
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
            this.Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dashboard_btn = new System.Windows.Forms.Button();
            this.Shop_btn = new System.Windows.Forms.Button();
            this.Inventory_btn = new System.Windows.Forms.Button();
            this.Categories_btn = new System.Windows.Forms.Button();
            this.Customers_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.categoriesForm1 = new Restaurant_Management_System_v0._1.CategoriesForm();
            this.inventoryForm1 = new Restaurant_Management_System_v0._1.InventoryForm();
            this.shopForm1 = new Restaurant_Management_System_v0._1.ShopForm();
            this.dashboardForm1 = new Restaurant_Management_System_v0._1.DashboardForm();
            this.customersForm1 = new Restaurant_Management_System_v0._1.CustomersForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 35);
            this.panel1.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Firebrick;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(1281, 1);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(52, 31);
            this.Close.TabIndex = 15;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Controls.Add(this.Customers_btn);
            this.panel2.Controls.Add(this.Categories_btn);
            this.panel2.Controls.Add(this.Inventory_btn);
            this.panel2.Controls.Add(this.Shop_btn);
            this.panel2.Controls.Add(this.Dashboard_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 705);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(82, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(60, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, Admin!";
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Dashboard_btn.FlatAppearance.BorderSize = 0;
            this.Dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboard_btn.Location = new System.Drawing.Point(26, 226);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(204, 34);
            this.Dashboard_btn.TabIndex = 2;
            this.Dashboard_btn.Text = "Dashboard";
            this.Dashboard_btn.UseVisualStyleBackColor = false;
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // Shop_btn
            // 
            this.Shop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Shop_btn.FlatAppearance.BorderSize = 0;
            this.Shop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shop_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Shop_btn.Location = new System.Drawing.Point(26, 286);
            this.Shop_btn.Name = "Shop_btn";
            this.Shop_btn.Size = new System.Drawing.Size(204, 34);
            this.Shop_btn.TabIndex = 3;
            this.Shop_btn.Text = "Shop";
            this.Shop_btn.UseVisualStyleBackColor = false;
            this.Shop_btn.Click += new System.EventHandler(this.Shop_btn_Click);
            // 
            // Inventory_btn
            // 
            this.Inventory_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Inventory_btn.FlatAppearance.BorderSize = 0;
            this.Inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inventory_btn.Location = new System.Drawing.Point(26, 340);
            this.Inventory_btn.Name = "Inventory_btn";
            this.Inventory_btn.Size = new System.Drawing.Size(204, 34);
            this.Inventory_btn.TabIndex = 4;
            this.Inventory_btn.Text = "Inventory";
            this.Inventory_btn.UseVisualStyleBackColor = false;
            this.Inventory_btn.Click += new System.EventHandler(this.Inventory_btn_Click);
            // 
            // Categories_btn
            // 
            this.Categories_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Categories_btn.FlatAppearance.BorderSize = 0;
            this.Categories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categories_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Categories_btn.Location = new System.Drawing.Point(26, 391);
            this.Categories_btn.Name = "Categories_btn";
            this.Categories_btn.Size = new System.Drawing.Size(204, 34);
            this.Categories_btn.TabIndex = 5;
            this.Categories_btn.Text = "Categories";
            this.Categories_btn.UseVisualStyleBackColor = false;
            this.Categories_btn.Click += new System.EventHandler(this.Categories_btn_Click);
            // 
            // Customers_btn
            // 
            this.Customers_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Customers_btn.FlatAppearance.BorderSize = 0;
            this.Customers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Customers_btn.Location = new System.Drawing.Point(26, 442);
            this.Customers_btn.Name = "Customers_btn";
            this.Customers_btn.Size = new System.Drawing.Size(204, 34);
            this.Customers_btn.TabIndex = 6;
            this.Customers_btn.Text = "Customers";
            this.Customers_btn.UseVisualStyleBackColor = false;
            this.Customers_btn.Click += new System.EventHandler(this.Customers_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logout_btn.Location = new System.Drawing.Point(26, 568);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(204, 34);
            this.Logout_btn.TabIndex = 7;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Restaurant Management System v0.1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.customersForm1);
            this.flowLayoutPanel1.Controls.Add(this.categoriesForm1);
            this.flowLayoutPanel1.Controls.Add(this.inventoryForm1);
            this.flowLayoutPanel1.Controls.Add(this.shopForm1);
            this.flowLayoutPanel1.Controls.Add(this.dashboardForm1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(257, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1076, 705);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // categoriesForm1
            // 
            this.categoriesForm1.Location = new System.Drawing.Point(3, 736);
            this.categoriesForm1.Name = "categoriesForm1";
            this.categoriesForm1.Size = new System.Drawing.Size(1084, 727);
            this.categoriesForm1.TabIndex = 3;
            // 
            // inventoryForm1
            // 
            this.inventoryForm1.Location = new System.Drawing.Point(3, 1469);
            this.inventoryForm1.Name = "inventoryForm1";
            this.inventoryForm1.Size = new System.Drawing.Size(1061, 690);
            this.inventoryForm1.TabIndex = 2;
            // 
            // shopForm1
            // 
            this.shopForm1.Location = new System.Drawing.Point(3, 2165);
            this.shopForm1.Name = "shopForm1";
            this.shopForm1.Size = new System.Drawing.Size(1084, 727);
            this.shopForm1.TabIndex = 1;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(3, 2898);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1084, 727);
            this.dashboardForm1.TabIndex = 0;
            // 
            // customersForm1
            // 
            this.customersForm1.Location = new System.Drawing.Point(3, 3);
            this.customersForm1.Name = "customersForm1";
            this.customersForm1.Size = new System.Drawing.Size(1084, 727);
            this.customersForm1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 740);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Dashboard_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Customers_btn;
        private System.Windows.Forms.Button Categories_btn;
        private System.Windows.Forms.Button Inventory_btn;
        private System.Windows.Forms.Button Shop_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DashboardForm dashboardForm1;
        private ShopForm shopForm1;
        private InventoryForm inventoryForm1;
        private CategoriesForm categoriesForm1;
        private CustomersForm customersForm1;
    }
}