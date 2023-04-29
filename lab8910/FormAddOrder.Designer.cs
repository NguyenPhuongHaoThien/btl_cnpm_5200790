namespace BaiTapLonCNPM
{
    partial class FormAddOrder
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetIdAgent = new System.Windows.Forms.Button();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.btnAddOrderDetails = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textPriceItem = new System.Windows.Forms.TextBox();
            this.txtQuantityItem = new System.Windows.Forms.TextBox();
            this.dataGridViewOrderDetail = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelAgentID = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Print Order";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Thêm Hóa Đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agent Name";
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(116, 62);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(306, 20);
            this.txtAgentName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "AgentID: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 25;
            // 
            // btnGetIdAgent
            // 
            this.btnGetIdAgent.Location = new System.Drawing.Point(759, 58);
            this.btnGetIdAgent.Name = "btnGetIdAgent";
            this.btnGetIdAgent.Size = new System.Drawing.Size(96, 23);
            this.btnGetIdAgent.TabIndex = 26;
            this.btnGetIdAgent.Text = "Kiểm tra Agent";
            this.btnGetIdAgent.UseVisualStyleBackColor = true;
            this.btnGetIdAgent.Click += new System.EventHandler(this.btnGetIdAgent_Click);
            // 
            // dateOrder
            // 
            this.dateOrder.Location = new System.Drawing.Point(116, 105);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(200, 20);
            this.dateOrder.TabIndex = 27;
            this.dateOrder.ValueChanged += new System.EventHandler(this.dateOrder_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày dặt hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Chọn Sản Phẩm";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(116, 199);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(167, 21);
            this.comboBoxItems.TabIndex = 30;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // btnAddOrderDetails
            // 
            this.btnAddOrderDetails.Location = new System.Drawing.Point(381, 250);
            this.btnAddOrderDetails.Name = "btnAddOrderDetails";
            this.btnAddOrderDetails.Size = new System.Drawing.Size(121, 23);
            this.btnAddOrderDetails.TabIndex = 31;
            this.btnAddOrderDetails.Text = "Thêm vào hóa đơn";
            this.btnAddOrderDetails.UseVisualStyleBackColor = true;
            this.btnAddOrderDetails.Click += new System.EventHandler(this.btnAddOrderDetails_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Nhập số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "Chi tiết hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Giá sản phẩm";
            // 
            // textPriceItem
            // 
            this.textPriceItem.Location = new System.Drawing.Point(414, 200);
            this.textPriceItem.Name = "textPriceItem";
            this.textPriceItem.Size = new System.Drawing.Size(133, 20);
            this.textPriceItem.TabIndex = 36;
            this.textPriceItem.TextChanged += new System.EventHandler(this.textPriceItem_TextChanged);
            // 
            // txtQuantityItem
            // 
            this.txtQuantityItem.Location = new System.Drawing.Point(686, 200);
            this.txtQuantityItem.Name = "txtQuantityItem";
            this.txtQuantityItem.Size = new System.Drawing.Size(112, 20);
            this.txtQuantityItem.TabIndex = 37;
            this.txtQuantityItem.TextChanged += new System.EventHandler(this.txtQuantityItem_TextChanged);
            // 
            // dataGridViewOrderDetail
            // 
            this.dataGridViewOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.ItemID,
            this.UnitPrice,
            this.Quantity,
            this.RemoveDetail});
            this.dataGridViewOrderDetail.Location = new System.Drawing.Point(11, 299);
            this.dataGridViewOrderDetail.Name = "dataGridViewOrderDetail";
            this.dataGridViewOrderDetail.Size = new System.Drawing.Size(844, 150);
            this.dataGridViewOrderDetail.TabIndex = 38;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "OrderID";
            this.OrderID.Name = "OrderID";
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitAmount";
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // RemoveDetail
            // 
            this.RemoveDetail.HeaderText = "Remove";
            this.RemoveDetail.Name = "RemoveDetail";
            this.RemoveDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RemoveDetail.Text = "Remove Item";
            // 
            // labelAgentID
            // 
            this.labelAgentID.AutoSize = true;
            this.labelAgentID.Location = new System.Drawing.Point(635, 68);
            this.labelAgentID.Name = "labelAgentID";
            this.labelAgentID.Size = new System.Drawing.Size(0, 13);
            this.labelAgentID.TabIndex = 39;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(725, 463);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(120, 23);
            this.btnCreateOrder.TabIndex = 40;
            this.btnCreateOrder.Text = "Tạo Hóa Đơn";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.labelAgentID);
            this.Controls.Add(this.dataGridViewOrderDetail);
            this.Controls.Add(this.txtQuantityItem);
            this.Controls.Add(this.textPriceItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddOrderDetails);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateOrder);
            this.Controls.Add(this.btnGetIdAgent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAgentName);
            this.Name = "FormAddOrder";
            this.Text = "FormAddOrder";
            this.Load += new System.EventHandler(this.FormAddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetIdAgent;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button btnAddOrderDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPriceItem;
        private System.Windows.Forms.TextBox txtQuantityItem;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetail;
        private System.Windows.Forms.Label labelAgentID;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveDetail;
    }
}