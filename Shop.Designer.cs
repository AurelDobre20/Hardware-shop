namespace Hardware_Shop
{
    partial class Shop
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
            this.lvComputers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.lvComp = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvComputersCart = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCompCart = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderBtn = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvComputers
            // 
            this.lvComputers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvComputers.HideSelection = false;
            this.lvComputers.Location = new System.Drawing.Point(12, 48);
            this.lvComputers.Name = "lvComputers";
            this.lvComputers.Size = new System.Drawing.Size(591, 271);
            this.lvComputers.TabIndex = 0;
            this.lvComputers.UseCompatibleStateImageBehavior = false;
            this.lvComputers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Brand";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Proccesor";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RAM";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Storage";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "GraphicsCard";
            this.columnHeader5.Width = 102;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.Location = new System.Drawing.Point(548, 379);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(114, 23);
            this.addToCartBtn.TabIndex = 4;
            this.addToCartBtn.Text = "Add to Cart";
            this.addToCartBtn.UseVisualStyleBackColor = true;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // lvComp
            // 
            this.lvComp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvComp.HideSelection = false;
            this.lvComp.Location = new System.Drawing.Point(599, 48);
            this.lvComp.Name = "lvComp";
            this.lvComp.Size = new System.Drawing.Size(591, 271);
            this.lvComp.TabIndex = 5;
            this.lvComp.UseCompatibleStateImageBehavior = false;
            this.lvComp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Type";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Manufacturer";
            this.columnHeader9.Width = 103;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Model";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Available items";
            // 
            // lvComputersCart
            // 
            this.lvComputersCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lvComputersCart.HideSelection = false;
            this.lvComputersCart.Location = new System.Drawing.Point(12, 422);
            this.lvComputersCart.Name = "lvComputersCart";
            this.lvComputersCart.Size = new System.Drawing.Size(591, 271);
            this.lvComputersCart.TabIndex = 10;
            this.lvComputersCart.UseCompatibleStateImageBehavior = false;
            this.lvComputersCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Brand";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Proccesor";
            this.columnHeader13.Width = 88;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "RAM";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Storage";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "GraphicsCard";
            this.columnHeader16.Width = 108;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Price";
            // 
            // lvCompCart
            // 
            this.lvCompCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.lvCompCart.HideSelection = false;
            this.lvCompCart.Location = new System.Drawing.Point(599, 422);
            this.lvCompCart.Name = "lvCompCart";
            this.lvCompCart.Size = new System.Drawing.Size(591, 271);
            this.lvCompCart.TabIndex = 11;
            this.lvCompCart.UseCompatibleStateImageBehavior = false;
            this.lvCompCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Name";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Type";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Manufacturer";
            this.columnHeader20.Width = 109;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Model";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Price";
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(548, 699);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(114, 23);
            this.orderBtn.TabIndex = 12;
            this.orderBtn.Text = "Order items";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Computers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(872, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Components";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 734);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvComputers);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.lvCompCart);
            this.Controls.Add(this.lvComputersCart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvComp);
            this.Controls.Add(this.addToCartBtn);
            this.Name = "Shop";
            this.Text = "Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shop_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Shop_KeyDown);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvComputers;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.ListView lvComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView lvComputersCart;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ListView lvCompCart;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}