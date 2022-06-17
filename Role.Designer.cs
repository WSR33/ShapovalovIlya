
namespace OrdersProgramm
{
    partial class Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role));
            this.button3 = new System.Windows.Forms.Button();
            this.BackToMenuFromOrders = new System.Windows.Forms.Button();
            this.Pravkaorder = new System.Windows.Forms.Button();
            this.OrderProductGriedView = new System.Windows.Forms.DataGridView();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradeDataSet2 = new OrdersProgramm.TradeDataSet2();
            this.roleTableAdapter = new OrdersProgramm.TradeDataSet2TableAdapters.RoleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductGriedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(519, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 158);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить столбец";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackToMenuFromOrders
            // 
            this.BackToMenuFromOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToMenuFromOrders.Location = new System.Drawing.Point(521, 359);
            this.BackToMenuFromOrders.Name = "BackToMenuFromOrders";
            this.BackToMenuFromOrders.Size = new System.Drawing.Size(145, 65);
            this.BackToMenuFromOrders.TabIndex = 9;
            this.BackToMenuFromOrders.Text = "Назад к меню";
            this.BackToMenuFromOrders.UseVisualStyleBackColor = false;
            this.BackToMenuFromOrders.Click += new System.EventHandler(this.BackToMenuFromOrders_Click);
            // 
            // Pravkaorder
            // 
            this.Pravkaorder.Location = new System.Drawing.Point(507, 89);
            this.Pravkaorder.Name = "Pravkaorder";
            this.Pravkaorder.Size = new System.Drawing.Size(177, 86);
            this.Pravkaorder.TabIndex = 8;
            this.Pravkaorder.Text = "Править столбцы";
            this.Pravkaorder.UseVisualStyleBackColor = true;
            this.Pravkaorder.Click += new System.EventHandler(this.Pravkaorder_Click);
            // 
            // OrderProductGriedView
            // 
            this.OrderProductGriedView.AutoGenerateColumns = false;
            this.OrderProductGriedView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderProductGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderProductGriedView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleIDDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn});
            this.OrderProductGriedView.DataSource = this.roleBindingSource;
            this.OrderProductGriedView.GridColor = System.Drawing.Color.MediumAquamarine;
            this.OrderProductGriedView.Location = new System.Drawing.Point(3, 12);
            this.OrderProductGriedView.Name = "OrderProductGriedView";
            this.OrderProductGriedView.RowHeadersWidth = 51;
            this.OrderProductGriedView.RowTemplate.Height = 24;
            this.OrderProductGriedView.Size = new System.Drawing.Size(483, 468);
            this.OrderProductGriedView.TabIndex = 7;
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            this.roleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.tradeDataSet2;
            // 
            // tradeDataSet2
            // 
            this.tradeDataSet2.DataSetName = "TradeDataSet2";
            this.tradeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 492);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BackToMenuFromOrders);
            this.Controls.Add(this.Pravkaorder);
            this.Controls.Add(this.OrderProductGriedView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Role";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductGriedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BackToMenuFromOrders;
        private System.Windows.Forms.Button Pravkaorder;
        private System.Windows.Forms.DataGridView OrderProductGriedView;
        private TradeDataSet2 tradeDataSet2;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private TradeDataSet2TableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
    }
}