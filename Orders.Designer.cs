
namespace OrdersProgramm
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.button3 = new System.Windows.Forms.Button();
            this.BackToMenuFromOrders = new System.Windows.Forms.Button();
            this.Pravkaorder = new System.Windows.Forms.Button();
            this.OrderProductGriedView = new System.Windows.Forms.DataGridView();
            this.tradeDataSet3 = new OrdersProgramm.TradeDataSet3();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new OrdersProgramm.TradeDataSet3TableAdapters.ProductTableAdapter();
            this.productArticleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edinicaIzmereniyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximumofDiscountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDiscountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPhotoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductGriedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(801, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 145);
            this.button3.TabIndex = 14;
            this.button3.Text = "Удалить столбец";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackToMenuFromOrders
            // 
            this.BackToMenuFromOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToMenuFromOrders.Location = new System.Drawing.Point(803, 303);
            this.BackToMenuFromOrders.Name = "BackToMenuFromOrders";
            this.BackToMenuFromOrders.Size = new System.Drawing.Size(139, 52);
            this.BackToMenuFromOrders.TabIndex = 13;
            this.BackToMenuFromOrders.Text = "Назад к меню";
            this.BackToMenuFromOrders.UseVisualStyleBackColor = false;
            // 
            // Pravkaorder
            // 
            this.Pravkaorder.Location = new System.Drawing.Point(789, 33);
            this.Pravkaorder.Name = "Pravkaorder";
            this.Pravkaorder.Size = new System.Drawing.Size(171, 73);
            this.Pravkaorder.TabIndex = 12;
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
            this.productArticleNumberDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.edinicaIzmereniyaDataGridViewTextBoxColumn,
            this.productCostDataGridViewTextBoxColumn,
            this.maximumofDiscountAmountDataGridViewTextBoxColumn,
            this.productManufacturerDataGridViewTextBoxColumn,
            this.postavshikDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn,
            this.productDiscountAmountDataGridViewTextBoxColumn,
            this.productQuantityInStockDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productPhotoDataGridViewTextBoxColumn});
            this.OrderProductGriedView.DataSource = this.productBindingSource;
            this.OrderProductGriedView.GridColor = System.Drawing.Color.MediumAquamarine;
            this.OrderProductGriedView.Location = new System.Drawing.Point(12, 12);
            this.OrderProductGriedView.Name = "OrderProductGriedView";
            this.OrderProductGriedView.RowHeadersWidth = 51;
            this.OrderProductGriedView.RowTemplate.Height = 24;
            this.OrderProductGriedView.Size = new System.Drawing.Size(771, 514);
            this.OrderProductGriedView.TabIndex = 11;
            // 
            // tradeDataSet3
            // 
            this.tradeDataSet3.DataSetName = "TradeDataSet3";
            this.tradeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.tradeDataSet3;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productArticleNumberDataGridViewTextBoxColumn
            // 
            this.productArticleNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.HeaderText = "ProductArticleNumber";
            this.productArticleNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productArticleNumberDataGridViewTextBoxColumn.Name = "productArticleNumberDataGridViewTextBoxColumn";
            this.productArticleNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // edinicaIzmereniyaDataGridViewTextBoxColumn
            // 
            this.edinicaIzmereniyaDataGridViewTextBoxColumn.DataPropertyName = "EdinicaIzmereniya";
            this.edinicaIzmereniyaDataGridViewTextBoxColumn.HeaderText = "EdinicaIzmereniya";
            this.edinicaIzmereniyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edinicaIzmereniyaDataGridViewTextBoxColumn.Name = "edinicaIzmereniyaDataGridViewTextBoxColumn";
            this.edinicaIzmereniyaDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCostDataGridViewTextBoxColumn
            // 
            this.productCostDataGridViewTextBoxColumn.DataPropertyName = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.HeaderText = "ProductCost";
            this.productCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCostDataGridViewTextBoxColumn.Name = "productCostDataGridViewTextBoxColumn";
            this.productCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // maximumofDiscountAmountDataGridViewTextBoxColumn
            // 
            this.maximumofDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "MaximumofDiscountAmount";
            this.maximumofDiscountAmountDataGridViewTextBoxColumn.HeaderText = "MaximumofDiscountAmount";
            this.maximumofDiscountAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maximumofDiscountAmountDataGridViewTextBoxColumn.Name = "maximumofDiscountAmountDataGridViewTextBoxColumn";
            this.maximumofDiscountAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productManufacturerDataGridViewTextBoxColumn
            // 
            this.productManufacturerDataGridViewTextBoxColumn.DataPropertyName = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.HeaderText = "ProductManufacturer";
            this.productManufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productManufacturerDataGridViewTextBoxColumn.Name = "productManufacturerDataGridViewTextBoxColumn";
            this.productManufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // postavshikDataGridViewTextBoxColumn
            // 
            this.postavshikDataGridViewTextBoxColumn.DataPropertyName = "Postavshik";
            this.postavshikDataGridViewTextBoxColumn.HeaderText = "Postavshik";
            this.postavshikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postavshikDataGridViewTextBoxColumn.Name = "postavshikDataGridViewTextBoxColumn";
            this.postavshikDataGridViewTextBoxColumn.Width = 125;
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "Product Category";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "Product Category";
            this.productCategoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            this.productCategoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDiscountAmountDataGridViewTextBoxColumn
            // 
            this.productDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.HeaderText = "ProductDiscountAmount";
            this.productDiscountAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDiscountAmountDataGridViewTextBoxColumn.Name = "productDiscountAmountDataGridViewTextBoxColumn";
            this.productDiscountAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productQuantityInStockDataGridViewTextBoxColumn
            // 
            this.productQuantityInStockDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.HeaderText = "ProductQuantityInStock";
            this.productQuantityInStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productQuantityInStockDataGridViewTextBoxColumn.Name = "productQuantityInStockDataGridViewTextBoxColumn";
            this.productQuantityInStockDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product Description";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "Product Description";
            this.productDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            this.productDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPhotoDataGridViewTextBoxColumn
            // 
            this.productPhotoDataGridViewTextBoxColumn.DataPropertyName = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.HeaderText = "ProductPhoto";
            this.productPhotoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPhotoDataGridViewTextBoxColumn.Name = "productPhotoDataGridViewTextBoxColumn";
            this.productPhotoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BackToMenuFromOrders);
            this.Controls.Add(this.Pravkaorder);
            this.Controls.Add(this.OrderProductGriedView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderProductGriedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BackToMenuFromOrders;
        private System.Windows.Forms.Button Pravkaorder;
        private System.Windows.Forms.DataGridView OrderProductGriedView;
        private TradeDataSet3 tradeDataSet3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private TradeDataSet3TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productArticleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edinicaIzmereniyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumofDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPhotoDataGridViewTextBoxColumn;
    }
}