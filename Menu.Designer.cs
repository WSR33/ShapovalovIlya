
namespace OrdersProgramm
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Role = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.OrderProduct = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Role
            // 
            this.Role.Location = new System.Drawing.Point(65, 167);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(111, 54);
            this.Role.TabIndex = 0;
            this.Role.Text = "Роли";
            this.Role.UseVisualStyleBackColor = true;
            this.Role.Click += new System.EventHandler(this.Role_Click);
            // 
            // Users
            // 
            this.Users.Location = new System.Drawing.Point(25, 21);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(188, 67);
            this.Users.TabIndex = 1;
            this.Users.Text = "Пользователи";
            this.Users.UseVisualStyleBackColor = true;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // OrderProduct
            // 
            this.OrderProduct.Location = new System.Drawing.Point(25, 103);
            this.OrderProduct.Name = "OrderProduct";
            this.OrderProduct.Size = new System.Drawing.Size(188, 58);
            this.OrderProduct.TabIndex = 2;
            this.OrderProduct.Text = "Заказанные продукты";
            this.OrderProduct.UseVisualStyleBackColor = true;
            this.OrderProduct.Click += new System.EventHandler(this.OrderProduct_Click);
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(65, 227);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(111, 68);
            this.Order.TabIndex = 3;
            this.Order.Text = "Заказы";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(227, 370);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(310, 405);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.OrderProduct);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Role);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Role;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button OrderProduct;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button Exit;
    }
}