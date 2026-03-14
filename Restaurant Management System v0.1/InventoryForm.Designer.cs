namespace Restaurant_Management_System_v0._1
{
    partial class InventoryForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Inventory_ImportBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Inventory_Status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Inventory_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Inventory_Stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Inventory_Category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Inventory_ProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Inventory_ProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Inventory_AddBtn = new System.Windows.Forms.Button();
            this.Inventory_UpdateBtn = new System.Windows.Forms.Button();
            this.Inventory_ClearBtn = new System.Windows.Forms.Button();
            this.Inventory_DeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 340);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(20, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "All Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 67;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(997, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Inventory_ClearBtn);
            this.panel2.Controls.Add(this.Inventory_DeleteBtn);
            this.panel2.Controls.Add(this.Inventory_UpdateBtn);
            this.panel2.Controls.Add(this.Inventory_AddBtn);
            this.panel2.Controls.Add(this.Inventory_ImportBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Inventory_Status);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Inventory_Price);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Inventory_Stock);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Inventory_Category);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Inventory_ProductName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Inventory_ProductID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(20, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 311);
            this.panel2.TabIndex = 1;
            // 
            // Inventory_ImportBtn
            // 
            this.Inventory_ImportBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Inventory_ImportBtn.FlatAppearance.BorderSize = 0;
            this.Inventory_ImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_ImportBtn.ForeColor = System.Drawing.Color.White;
            this.Inventory_ImportBtn.Location = new System.Drawing.Point(905, 155);
            this.Inventory_ImportBtn.Name = "Inventory_ImportBtn";
            this.Inventory_ImportBtn.Size = new System.Drawing.Size(102, 35);
            this.Inventory_ImportBtn.TabIndex = 13;
            this.Inventory_ImportBtn.Text = "import";
            this.Inventory_ImportBtn.UseVisualStyleBackColor = false;
            this.Inventory_ImportBtn.Click += new System.EventHandler(this.Inventory_ImportBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(905, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 131);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Inventory_Status
            // 
            this.Inventory_Status.FormattingEnabled = true;
            this.Inventory_Status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.Inventory_Status.Location = new System.Drawing.Point(552, 119);
            this.Inventory_Status.Name = "Inventory_Status";
            this.Inventory_Status.Size = new System.Drawing.Size(260, 30);
            this.Inventory_Status.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // Inventory_Price
            // 
            this.Inventory_Price.Location = new System.Drawing.Point(552, 70);
            this.Inventory_Price.Name = "Inventory_Price";
            this.Inventory_Price.Size = new System.Drawing.Size(260, 28);
            this.Inventory_Price.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price($):";
            // 
            // Inventory_Stock
            // 
            this.Inventory_Stock.Location = new System.Drawing.Point(552, 18);
            this.Inventory_Stock.Name = "Inventory_Stock";
            this.Inventory_Stock.Size = new System.Drawing.Size(260, 28);
            this.Inventory_Stock.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stock:";
            // 
            // Inventory_Category
            // 
            this.Inventory_Category.FormattingEnabled = true;
            this.Inventory_Category.Location = new System.Drawing.Point(145, 120);
            this.Inventory_Category.Name = "Inventory_Category";
            this.Inventory_Category.Size = new System.Drawing.Size(260, 30);
            this.Inventory_Category.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category:";
            // 
            // Inventory_ProductName
            // 
            this.Inventory_ProductName.Location = new System.Drawing.Point(145, 71);
            this.Inventory_ProductName.Name = "Inventory_ProductName";
            this.Inventory_ProductName.Size = new System.Drawing.Size(260, 28);
            this.Inventory_ProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // Inventory_ProductID
            // 
            this.Inventory_ProductID.Location = new System.Drawing.Point(145, 19);
            this.Inventory_ProductID.Name = "Inventory_ProductID";
            this.Inventory_ProductID.Size = new System.Drawing.Size(260, 28);
            this.Inventory_ProductID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID:";
            // 
            // Inventory_AddBtn
            // 
            this.Inventory_AddBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Inventory_AddBtn.FlatAppearance.BorderSize = 0;
            this.Inventory_AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_AddBtn.ForeColor = System.Drawing.Color.White;
            this.Inventory_AddBtn.Location = new System.Drawing.Point(18, 242);
            this.Inventory_AddBtn.Name = "Inventory_AddBtn";
            this.Inventory_AddBtn.Size = new System.Drawing.Size(102, 35);
            this.Inventory_AddBtn.TabIndex = 14;
            this.Inventory_AddBtn.Text = "Add";
            this.Inventory_AddBtn.UseVisualStyleBackColor = false;
            this.Inventory_AddBtn.Click += new System.EventHandler(this.Inventory_AddBtn_Click);
            // 
            // Inventory_UpdateBtn
            // 
            this.Inventory_UpdateBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Inventory_UpdateBtn.FlatAppearance.BorderSize = 0;
            this.Inventory_UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.Inventory_UpdateBtn.Location = new System.Drawing.Point(170, 242);
            this.Inventory_UpdateBtn.Name = "Inventory_UpdateBtn";
            this.Inventory_UpdateBtn.Size = new System.Drawing.Size(102, 35);
            this.Inventory_UpdateBtn.TabIndex = 15;
            this.Inventory_UpdateBtn.Text = "Update";
            this.Inventory_UpdateBtn.UseVisualStyleBackColor = false;
            this.Inventory_UpdateBtn.Click += new System.EventHandler(this.Inventory_UpdateBtn_Click);
            // 
            // Inventory_ClearBtn
            // 
            this.Inventory_ClearBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Inventory_ClearBtn.FlatAppearance.BorderSize = 0;
            this.Inventory_ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_ClearBtn.ForeColor = System.Drawing.Color.White;
            this.Inventory_ClearBtn.Location = new System.Drawing.Point(634, 242);
            this.Inventory_ClearBtn.Name = "Inventory_ClearBtn";
            this.Inventory_ClearBtn.Size = new System.Drawing.Size(102, 35);
            this.Inventory_ClearBtn.TabIndex = 17;
            this.Inventory_ClearBtn.Text = "Clear";
            this.Inventory_ClearBtn.UseVisualStyleBackColor = false;
            this.Inventory_ClearBtn.Click += new System.EventHandler(this.Inventory_ClearBtn_Click);
            // 
            // Inventory_DeleteBtn
            // 
            this.Inventory_DeleteBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Inventory_DeleteBtn.FlatAppearance.BorderSize = 0;
            this.Inventory_DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory_DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.Inventory_DeleteBtn.Location = new System.Drawing.Point(482, 242);
            this.Inventory_DeleteBtn.Name = "Inventory_DeleteBtn";
            this.Inventory_DeleteBtn.Size = new System.Drawing.Size(102, 35);
            this.Inventory_DeleteBtn.TabIndex = 16;
            this.Inventory_DeleteBtn.Text = "Delete";
            this.Inventory_DeleteBtn.UseVisualStyleBackColor = false;
            this.Inventory_DeleteBtn.Click += new System.EventHandler(this.Inventory_DeleteBtn_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InventoryForm";
            this.Size = new System.Drawing.Size(1084, 727);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Inventory_ProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Inventory_ProductID;
        private System.Windows.Forms.ComboBox Inventory_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Inventory_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Inventory_Stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Inventory_Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Inventory_ImportBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Inventory_ClearBtn;
        private System.Windows.Forms.Button Inventory_DeleteBtn;
        private System.Windows.Forms.Button Inventory_UpdateBtn;
        private System.Windows.Forms.Button Inventory_AddBtn;
    }
}
