namespace LibraryManagement.Forms
{
    partial class OrderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 123);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(619, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Admin panel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvOrders.Location = new System.Drawing.Point(12, 150);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(541, 284);
            this.dgvOrders.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "New Order";
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(604, 185);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(121, 24);
            this.cmbBooks.TabIndex = 11;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(604, 233);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 24);
            this.cmbUsers.TabIndex = 12;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(624, 288);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Book Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Take Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Deadline";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Price";
            this.Column4.Name = "Column4";
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Text = "OrderManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderManagement_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}