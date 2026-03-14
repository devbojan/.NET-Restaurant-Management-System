namespace Restaurant_Management_System_v0._1
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shop_receiptBtn = new System.Windows.Forms.Button();
            this.shop_placeOrderBtn = new System.Windows.Forms.Button();
            this.shop_amount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shop_change = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shop_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(19, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 679);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(641, 644);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.shop_receiptBtn);
            this.panel2.Controls.Add(this.shop_placeOrderBtn);
            this.panel2.Controls.Add(this.shop_amount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.shop_change);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.shop_total);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(702, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 679);
            this.panel2.TabIndex = 1;
            // 
            // shop_receiptBtn
            // 
            this.shop_receiptBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.shop_receiptBtn.FlatAppearance.BorderSize = 0;
            this.shop_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_receiptBtn.ForeColor = System.Drawing.Color.White;
            this.shop_receiptBtn.Location = new System.Drawing.Point(16, 598);
            this.shop_receiptBtn.Name = "shop_receiptBtn";
            this.shop_receiptBtn.Size = new System.Drawing.Size(336, 42);
            this.shop_receiptBtn.TabIndex = 8;
            this.shop_receiptBtn.Text = "Receipt";
            this.shop_receiptBtn.UseVisualStyleBackColor = false;
            this.shop_receiptBtn.Click += new System.EventHandler(this.shop_receiptBtn_Click);
            // 
            // shop_placeOrderBtn
            // 
            this.shop_placeOrderBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.shop_placeOrderBtn.FlatAppearance.BorderSize = 0;
            this.shop_placeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_placeOrderBtn.ForeColor = System.Drawing.Color.White;
            this.shop_placeOrderBtn.Location = new System.Drawing.Point(16, 545);
            this.shop_placeOrderBtn.Name = "shop_placeOrderBtn";
            this.shop_placeOrderBtn.Size = new System.Drawing.Size(336, 42);
            this.shop_placeOrderBtn.TabIndex = 7;
            this.shop_placeOrderBtn.Text = "Place order";
            this.shop_placeOrderBtn.UseVisualStyleBackColor = false;
            this.shop_placeOrderBtn.Click += new System.EventHandler(this.shop_placeOrderBtn_Click);
            // 
            // shop_amount
            // 
            this.shop_amount.AutoSize = true;
            this.shop_amount.Location = new System.Drawing.Point(199, 493);
            this.shop_amount.Name = "shop_amount";
            this.shop_amount.Size = new System.Drawing.Size(45, 22);
            this.shop_amount.TabIndex = 6;
            this.shop_amount.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount:";
            // 
            // shop_change
            // 
            this.shop_change.Location = new System.Drawing.Point(203, 448);
            this.shop_change.Name = "shop_change";
            this.shop_change.Size = new System.Drawing.Size(100, 28);
            this.shop_change.TabIndex = 4;
            this.shop_change.Enter += new System.EventHandler(this.shop_change_Enter);
            this.shop_change.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shop_change_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Change:";
            // 
            // shop_total
            // 
            this.shop_total.AutoSize = true;
            this.shop_total.Location = new System.Drawing.Point(199, 416);
            this.shop_total.Name = "shop_total";
            this.shop_total.Size = new System.Drawing.Size(45, 22);
            this.shop_total.TabIndex = 2;
            this.shop_total.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total($):";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prodName,
            this.QTY,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(16, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 67;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(336, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 165;
            // 
            // prodName
            // 
            this.prodName.HeaderText = "prodName";
            this.prodName.MinimumWidth = 8;
            this.prodName.Name = "prodName";
            this.prodName.Width = 165;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 8;
            this.QTY.Name = "QTY";
            this.QTY.Width = 165;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 165;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ShopForm";
            this.Size = new System.Drawing.Size(1084, 727);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label shop_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shop_change;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button shop_receiptBtn;
        private System.Windows.Forms.Button shop_placeOrderBtn;
        private System.Windows.Forms.Label shop_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
