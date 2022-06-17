
namespace OrdersProgramm
{
    partial class OrderProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderProduct));
            this.OrderProductGriedView = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productArticleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradeDataSet1 = new OrdersProgramm.TradeDataSet1();
            this.button3 = new System.Windows.Forms.Button();
            this.BackToMenuFromOrders = new System.Windows.Forms.Button();
            this.Pravkaorder = new System.Windows.Forms.Button();
            this.tradeDataSet = new OrdersProgramm.TradeDataSet();
            this.tradeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderProductTableAdapter = new OrdersProgramm.TradeDataSet1TableAdapters.OrderProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductGriedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderProductGriedView
            // 
            this.OrderProductGriedView.AutoGenerateColumns = false;
            this.OrderProductGriedView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OrderProductGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderProductGriedView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.productArticleDataGridViewTextBoxColumn});
            this.OrderProductGriedView.DataSource = this.orderProductBindingSource;
            this.OrderProductGriedView.GridColor = System.Drawing.Color.MediumAquamarine;
            this.OrderProductGriedView.Location = new System.Drawing.Point(3, 12);
            this.OrderProductGriedView.Name = "OrderProductGriedView";
            this.OrderProductGriedView.RowHeadersWidth = 51;
            this.OrderProductGriedView.RowTemplate.Height = 24;
            this.OrderProductGriedView.Size = new System.Drawing.Size(519, 488);
            this.OrderProductGriedView.TabIndex = 0;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productArticleDataGridViewTextBoxColumn
            // 
            this.productArticleDataGridViewTextBoxColumn.DataPropertyName = "ProductArticle";
            this.productArticleDataGridViewTextBoxColumn.HeaderText = "ProductArticle";
            this.productArticleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productArticleDataGridViewTextBoxColumn.Name = "productArticleDataGridViewTextBoxColumn";
            this.productArticleDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderProductBindingSource
            // 
            this.orderProductBindingSource.DataMember = "OrderProduct";
            this.orderProductBindingSource.DataSource = this.tradeDataSet1;
            // 
            // tradeDataSet1
            // 
            this.tradeDataSet1.DataSetName = "TradeDataSet1";
            this.tradeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(551, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 158);
            this.button3.TabIndex = 6;
            this.button3.Text = "Удалить столбец";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackToMenuFromOrders
            // 
            this.BackToMenuFromOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToMenuFromOrders.Location = new System.Drawing.Point(553, 352);
            this.BackToMenuFromOrders.Name = "BackToMenuFromOrders";
            this.BackToMenuFromOrders.Size = new System.Drawing.Size(153, 65);
            this.BackToMenuFromOrders.TabIndex = 5;
            this.BackToMenuFromOrders.Text = "Назад к меню";
            this.BackToMenuFromOrders.UseVisualStyleBackColor = false;
            this.BackToMenuFromOrders.Click += new System.EventHandler(this.BackToMenuFromOrders_Click);
            // 
            // Pravkaorder
            // 
            this.Pravkaorder.Location = new System.Drawing.Point(539, 82);
            this.Pravkaorder.Name = "Pravkaorder";
            this.Pravkaorder.Size = new System.Drawing.Size(185, 86);
            this.Pravkaorder.TabIndex = 4;
            this.Pravkaorder.Text = "Править столбцы";
            this.Pravkaorder.UseVisualStyleBackColor = true;
            this.Pravkaorder.Click += new System.EventHandler(this.Pravkaorder_Click);
            // 
            // tradeDataSet
            // 
            this.tradeDataSet.DataSetName = "TradeDataSet";
            this.tradeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tradeDataSetBindingSource
            // 
            this.tradeDataSetBindingSource.DataSource = this.tradeDataSet;
            this.tradeDataSetBindingSource.Position = 0;
            // 
            // tradeDataSetBindingSource1
            // 
            this.tradeDataSetBindingSource1.DataSource = this.tradeDataSet;
            this.tradeDataSetBindingSource1.Position = 0;
            // 
            // orderProductTableAdapter
            // 
            this.orderProductTableAdapter.ClearBeforeFill = true;
            // 
            // OrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 512);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BackToMenuFromOrders);
            this.Controls.Add(this.Pravkaorder);
            this.Controls.Add(this.OrderProductGriedView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderProduct";
            this.Text = "OrderProduct";
            this.Load += new System.EventHandler(this.OrderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductGriedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderProductGriedView;
        private System.Windows.Forms.BindingSource tradeDataSetBindingSource1;
        private TradeDataSet tradeDataSet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BackToMenuFromOrders;
        private System.Windows.Forms.Button Pravkaorder;
        private System.Windows.Forms.BindingSource tradeDataSetBindingSource;
        private TradeDataSet1 tradeDataSet1;
        private System.Windows.Forms.BindingSource orderProductBindingSource;
        private TradeDataSet1TableAdapters.OrderProductTableAdapter orderProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productArticleDataGridViewTextBoxColumn;
    }
}