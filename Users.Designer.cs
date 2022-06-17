
namespace OrdersProgramm
{
    partial class Users
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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.BackToMenuFromOrders = new System.Windows.Forms.Button();
            this.Pravkaorder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tradeDataSet5 = new OrdersProgramm.TradeDataSet5();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new OrdersProgramm.TradeDataSet5TableAdapters.UserTableAdapter();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPatronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(998, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 158);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить столбец";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackToMenuFromOrders
            // 
            this.BackToMenuFromOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToMenuFromOrders.Location = new System.Drawing.Point(1000, 457);
            this.BackToMenuFromOrders.Name = "BackToMenuFromOrders";
            this.BackToMenuFromOrders.Size = new System.Drawing.Size(145, 65);
            this.BackToMenuFromOrders.TabIndex = 6;
            this.BackToMenuFromOrders.Text = "Назад к меню";
            this.BackToMenuFromOrders.UseVisualStyleBackColor = false;
            this.BackToMenuFromOrders.Click += new System.EventHandler(this.BackToMenuFromOrders_Click);
            // 
            // Pravkaorder
            // 
            this.Pravkaorder.Location = new System.Drawing.Point(986, 24);
            this.Pravkaorder.Name = "Pravkaorder";
            this.Pravkaorder.Size = new System.Drawing.Size(177, 86);
            this.Pravkaorder.TabIndex = 5;
            this.Pravkaorder.Text = "Править столбцы";
            this.Pravkaorder.UseVisualStyleBackColor = true;
            this.Pravkaorder.Click += new System.EventHandler(this.Pravkaorder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userSurnameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPatronymicDataGridViewTextBoxColumn,
            this.userLoginDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userRoleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 552);
            this.dataGridView1.TabIndex = 4;
            // 
            // tradeDataSet5
            // 
            this.tradeDataSet5.DataSetName = "TradeDataSet5";
            this.tradeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.tradeDataSet5;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userSurnameDataGridViewTextBoxColumn
            // 
            this.userSurnameDataGridViewTextBoxColumn.DataPropertyName = "UserSurname";
            this.userSurnameDataGridViewTextBoxColumn.HeaderText = "UserSurname";
            this.userSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userSurnameDataGridViewTextBoxColumn.Name = "userSurnameDataGridViewTextBoxColumn";
            this.userSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userPatronymicDataGridViewTextBoxColumn
            // 
            this.userPatronymicDataGridViewTextBoxColumn.DataPropertyName = "UserPatronymic";
            this.userPatronymicDataGridViewTextBoxColumn.HeaderText = "UserPatronymic";
            this.userPatronymicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPatronymicDataGridViewTextBoxColumn.Name = "userPatronymicDataGridViewTextBoxColumn";
            this.userPatronymicDataGridViewTextBoxColumn.Width = 125;
            // 
            // userLoginDataGridViewTextBoxColumn
            // 
            this.userLoginDataGridViewTextBoxColumn.DataPropertyName = "UserLogin";
            this.userLoginDataGridViewTextBoxColumn.HeaderText = "UserLogin";
            this.userLoginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userLoginDataGridViewTextBoxColumn.Name = "userLoginDataGridViewTextBoxColumn";
            this.userLoginDataGridViewTextBoxColumn.Width = 125;
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "UserPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "UserPassword";
            this.userPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            this.userPasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // userRoleDataGridViewTextBoxColumn
            // 
            this.userRoleDataGridViewTextBoxColumn.DataPropertyName = "UserRole";
            this.userRoleDataGridViewTextBoxColumn.HeaderText = "UserRole";
            this.userRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userRoleDataGridViewTextBoxColumn.Name = "userRoleDataGridViewTextBoxColumn";
            this.userRoleDataGridViewTextBoxColumn.Width = 125;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 580);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BackToMenuFromOrders);
            this.Controls.Add(this.Pravkaorder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BackToMenuFromOrders;
        private System.Windows.Forms.Button Pravkaorder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TradeDataSet5 tradeDataSet5;
        private System.Windows.Forms.BindingSource userBindingSource;
        private TradeDataSet5TableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPatronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleDataGridViewTextBoxColumn;
    }
}