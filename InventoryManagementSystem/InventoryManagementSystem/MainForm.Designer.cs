namespace InventoryManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrdersBtn = new InventoryManagementSystem.CustomerButton();
            this.UsersBtn = new InventoryManagementSystem.CustomerButton();
            this.CategoriesBtn = new InventoryManagementSystem.CustomerButton();
            this.CustomerBtn = new InventoryManagementSystem.CustomerButton();
            this.ProductBtn = new InventoryManagementSystem.CustomerButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.OrdersBtn);
            this.panel1.Controls.Add(this.UsersBtn);
            this.panel1.Controls.Add(this.CategoriesBtn);
            this.panel1.Controls.Add(this.CustomerBtn);
            this.panel1.Controls.Add(this.ProductBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 99);
            this.panel1.TabIndex = 0;
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.Image = ((System.Drawing.Image)(resources.GetObject("OrdersBtn.Image")));
            this.OrdersBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("OrdersBtn.ImageHover")));
            this.OrdersBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("OrdersBtn.ImageNormal")));
            this.OrdersBtn.Location = new System.Drawing.Point(641, 20);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(60, 40);
            this.OrdersBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrdersBtn.TabIndex = 8;
            this.OrdersBtn.TabStop = false;
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Image = ((System.Drawing.Image)(resources.GetObject("UsersBtn.Image")));
            this.UsersBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("UsersBtn.ImageHover")));
            this.UsersBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("UsersBtn.ImageNormal")));
            this.UsersBtn.Location = new System.Drawing.Point(572, 20);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(60, 40);
            this.UsersBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsersBtn.TabIndex = 8;
            this.UsersBtn.TabStop = false;
            this.UsersBtn.Click += new System.EventHandler(this.UsersBtn_Click);
            // 
            // CategoriesBtn
            // 
            this.CategoriesBtn.Image = ((System.Drawing.Image)(resources.GetObject("CategoriesBtn.Image")));
            this.CategoriesBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("CategoriesBtn.ImageHover")));
            this.CategoriesBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("CategoriesBtn.ImageNormal")));
            this.CategoriesBtn.Location = new System.Drawing.Point(491, 20);
            this.CategoriesBtn.Name = "CategoriesBtn";
            this.CategoriesBtn.Size = new System.Drawing.Size(60, 40);
            this.CategoriesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CategoriesBtn.TabIndex = 8;
            this.CategoriesBtn.TabStop = false;
            this.CategoriesBtn.Click += new System.EventHandler(this.CategoriesBtn_Click);
            // 
            // CustomerBtn
            // 
            this.CustomerBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.Image")));
            this.CustomerBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.ImageHover")));
            this.CustomerBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("CustomerBtn.ImageNormal")));
            this.CustomerBtn.Location = new System.Drawing.Point(395, 20);
            this.CustomerBtn.Name = "CustomerBtn";
            this.CustomerBtn.Size = new System.Drawing.Size(60, 40);
            this.CustomerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CustomerBtn.TabIndex = 8;
            this.CustomerBtn.TabStop = false;
            this.CustomerBtn.Click += new System.EventHandler(this.CustomerBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProductBtn.Image")));
            this.ProductBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("ProductBtn.ImageHover")));
            this.ProductBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ProductBtn.ImageNormal")));
            this.ProductBtn.Location = new System.Drawing.Point(305, 20);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(60, 40);
            this.ProductBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductBtn.TabIndex = 8;
            this.ProductBtn.TabStop = false;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(639, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "ORDERS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(575, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "USERS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(474, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CATEGORIES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(383, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "CUSTOMER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRODUCT";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 487);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 24);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 99);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(934, 388);
            this.panelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomerButton btnUsers;
        private CustomerButton btnOrders;
        private CustomerButton btnCategories;
        private CustomerButton btnCustomer;
        private CustomerButton btnProduct;
        private CustomerButton ProductBtn;
        private CustomerButton OrdersBtn;
        private CustomerButton UsersBtn;
        private CustomerButton CategoriesBtn;
        private CustomerButton CustomerBtn;
    }
}