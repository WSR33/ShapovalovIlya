
namespace OrdersProgramm
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradeDataSet = new OrdersProgramm.TradeDataSet();
            this.orderTableAdapter = new OrdersProgramm.TradeDataSetTableAdapters.OrderTableAdapter();
            this.Pravkaorder = new System.Windows.Forms.Button();
            this.BackToMenuFromOrders = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tradeDataSet4 = new OrdersProgramm.TradeDataSet4();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new OrdersProgramm.TradeDataSet4TableAdapters.UserTableAdapter();
            this.tradeDataSet6 = new OrdersProgramm.TradeDataSet6();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter1 = new OrdersProgramm.TradeDataSet6TableAdapters.OrderTableAdapter();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavZakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataofMakingOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDeliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPickupPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeForPickupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.sostavZakazaDataGridViewTextBoxColumn,
            this.dataofMakingOrderDataGridViewTextBoxColumn,
            this.orderDeliveryDateDataGridViewTextBoxColumn,
            this.orderPickupPointDataGridViewTextBoxColumn,
            this.clienUsernameDataGridViewTextBoxColumn,
            this.codeForPickupDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.f9DataGridViewTextBoxColumn,
            this.f10DataGridViewTextBoxColumn,
            this.f11DataGridViewTextBoxColumn,
            this.f12DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-59, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 552);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.tradeDataSet;
            // 
            // tradeDataSet
            // 
            this.tradeDataSet.DataSetName = "TradeDataSet";
            this.tradeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // Pravkaorder
            // 
            this.Pravkaorder.Location = new System.Drawing.Point(915, 17);
            this.Pravkaorder.Name = "Pravkaorder";
            this.Pravkaorder.Size = new System.Drawing.Size(177, 86);
            this.Pravkaorder.TabIndex = 1;
            this.Pravkaorder.Text = "Править столбцы";
            this.Pravkaorder.UseVisualStyleBackColor = true;
            this.Pravkaorder.Click += new System.EventHandler(this.Pravkaorder_Click);
            // 
            // BackToMenuFromOrders
            // 
            this.BackToMenuFromOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToMenuFromOrders.Location = new System.Drawing.Point(929, 450);
            this.BackToMenuFromOrders.Name = "BackToMenuFromOrders";
            this.BackToMenuFromOrders.Size = new System.Drawing.Size(145, 65);
            this.BackToMenuFromOrders.TabIndex = 2;
            this.BackToMenuFromOrders.Text = "Назад к меню";
            this.BackToMenuFromOrders.UseVisualStyleBackColor = false;
            this.BackToMenuFromOrders.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(927, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 158);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить столбец";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tradeDataSet4
            // 
            this.tradeDataSet4.DataSetName = "TradeDataSet4";
            this.tradeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.tradeDataSet4;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tradeDataSet6
            // 
            this.tradeDataSet6.DataSetName = "TradeDataSet6";
            this.tradeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "Order";
            this.orderBindingSource1.DataSource = this.tradeDataSet6;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sostavZakazaDataGridViewTextBoxColumn
            // 
            this.sostavZakazaDataGridViewTextBoxColumn.DataPropertyName = "SostavZakaza";
            this.sostavZakazaDataGridViewTextBoxColumn.HeaderText = "SostavZakaza";
            this.sostavZakazaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sostavZakazaDataGridViewTextBoxColumn.Name = "sostavZakazaDataGridViewTextBoxColumn";
            this.sostavZakazaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataofMakingOrderDataGridViewTextBoxColumn
            // 
            this.dataofMakingOrderDataGridViewTextBoxColumn.DataPropertyName = "DataofMakingOrder";
            this.dataofMakingOrderDataGridViewTextBoxColumn.HeaderText = "DataofMakingOrder";
            this.dataofMakingOrderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataofMakingOrderDataGridViewTextBoxColumn.Name = "dataofMakingOrderDataGridViewTextBoxColumn";
            this.dataofMakingOrderDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDeliveryDateDataGridViewTextBoxColumn
            // 
            this.orderDeliveryDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDeliveryDate";
            this.orderDeliveryDateDataGridViewTextBoxColumn.HeaderText = "OrderDeliveryDate";
            this.orderDeliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDeliveryDateDataGridViewTextBoxColumn.Name = "orderDeliveryDateDataGridViewTextBoxColumn";
            this.orderDeliveryDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderPickupPointDataGridViewTextBoxColumn
            // 
            this.orderPickupPointDataGridViewTextBoxColumn.DataPropertyName = "OrderPickupPoint";
            this.orderPickupPointDataGridViewTextBoxColumn.HeaderText = "OrderPickupPoint";
            this.orderPickupPointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderPickupPointDataGridViewTextBoxColumn.Name = "orderPickupPointDataGridViewTextBoxColumn";
            this.orderPickupPointDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienUsernameDataGridViewTextBoxColumn
            // 
            this.clienUsernameDataGridViewTextBoxColumn.DataPropertyName = "ClienUsername";
            this.clienUsernameDataGridViewTextBoxColumn.HeaderText = "ClienUsername";
            this.clienUsernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienUsernameDataGridViewTextBoxColumn.Name = "clienUsernameDataGridViewTextBoxColumn";
            this.clienUsernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeForPickupDataGridViewTextBoxColumn
            // 
            this.codeForPickupDataGridViewTextBoxColumn.DataPropertyName = "CodeForPickup";
            this.codeForPickupDataGridViewTextBoxColumn.HeaderText = "CodeForPickup";
            this.codeForPickupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeForPickupDataGridViewTextBoxColumn.Name = "codeForPickupDataGridViewTextBoxColumn";
            this.codeForPickupDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // f9DataGridViewTextBoxColumn
            // 
            this.f9DataGridViewTextBoxColumn.DataPropertyName = "F9";
            this.f9DataGridViewTextBoxColumn.HeaderText = "F9";
            this.f9DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.f9DataGridViewTextBoxColumn.Name = "f9DataGridViewTextBoxColumn";
            this.f9DataGridViewTextBoxColumn.Width = 125;
            // 
            // f10DataGridViewTextBoxColumn
            // 
            this.f10DataGridViewTextBoxColumn.DataPropertyName = "F10";
            this.f10DataGridViewTextBoxColumn.HeaderText = "F10";
            this.f10DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.f10DataGridViewTextBoxColumn.Name = "f10DataGridViewTextBoxColumn";
            this.f10DataGridViewTextBoxColumn.Width = 125;
            // 
            // f11DataGridViewTextBoxColumn
            // 
            this.f11DataGridViewTextBoxColumn.DataPropertyName = "F11";
            this.f11DataGridViewTextBoxColumn.HeaderText = "F11";
            this.f11DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.f11DataGridViewTextBoxColumn.Name = "f11DataGridViewTextBoxColumn";
            this.f11DataGridViewTextBoxColumn.Width = 125;
            // 
            // f12DataGridViewTextBoxColumn
            // 
            this.f12DataGridViewTextBoxColumn.DataPropertyName = "F12";
            this.f12DataGridViewTextBoxColumn.HeaderText = "F12";
            this.f12DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.f12DataGridViewTextBoxColumn.Name = "f12DataGridViewTextBoxColumn";
            this.f12DataGridViewTextBoxColumn.Width = 125;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 563);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BackToMenuFromOrders);
            this.Controls.Add(this.Pravkaorder);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradeDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TradeDataSet tradeDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private TradeDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Button Pravkaorder;
        private System.Windows.Forms.Button BackToMenuFromOrders;
        private System.Windows.Forms.Button button3;
        private TradeDataSet4 tradeDataSet4;
        private System.Windows.Forms.BindingSource userBindingSource;
        private TradeDataSet4TableAdapters.UserTableAdapter userTableAdapter;
        private TradeDataSet6 tradeDataSet6;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private TradeDataSet6TableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostavZakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataofMakingOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDeliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPickupPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeForPickupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn f9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn f10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn f11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn f12DataGridViewTextBoxColumn;
    }
}