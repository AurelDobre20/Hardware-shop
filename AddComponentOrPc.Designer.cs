namespace Hardware_Shop
{
    partial class AddComponentOrPc
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
            this.lvComputers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvComp = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addComputerBtn = new System.Windows.Forms.Button();
            this.addComponentBtn = new System.Windows.Forms.Button();
            this.deleteBtnComputer = new System.Windows.Forms.Button();
            this.editBtnComputer = new System.Windows.Forms.Button();
            this.deleteBtnComp = new System.Windows.Forms.Button();
            this.editBtnComp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentToBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.componentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
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
            this.lvComputers.Location = new System.Drawing.Point(12, 144);
            this.lvComputers.Name = "lvComputers";
            this.lvComputers.Size = new System.Drawing.Size(543, 445);
            this.lvComputers.TabIndex = 0;
            this.lvComputers.UseCompatibleStateImageBehavior = false;
            this.lvComputers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Brand";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Proccesor";
            this.columnHeader2.Width = 76;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "RAM";
            this.columnHeader3.Width = 53;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Storage";
            this.columnHeader4.Width = 63;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "GraphicCard";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            this.columnHeader6.Width = 55;
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
            this.lvComp.Location = new System.Drawing.Point(594, 144);
            this.lvComp.Name = "lvComp";
            this.lvComp.Size = new System.Drawing.Size(540, 445);
            this.lvComp.TabIndex = 1;
            this.lvComp.UseCompatibleStateImageBehavior = false;
            this.lvComp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Type";
            this.columnHeader8.Width = 88;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Manufactuer";
            this.columnHeader9.Width = 107;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Model";
            this.columnHeader10.Width = 92;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Price";
            this.columnHeader11.Width = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Computers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Components";
            // 
            // addComputerBtn
            // 
            this.addComputerBtn.Location = new System.Drawing.Point(480, 111);
            this.addComputerBtn.Name = "addComputerBtn";
            this.addComputerBtn.Size = new System.Drawing.Size(75, 23);
            this.addComputerBtn.TabIndex = 4;
            this.addComputerBtn.Text = "Add";
            this.addComputerBtn.UseVisualStyleBackColor = true;
            this.addComputerBtn.Click += new System.EventHandler(this.addComputerBtn_Click);
            // 
            // addComponentBtn
            // 
            this.addComponentBtn.Location = new System.Drawing.Point(1059, 108);
            this.addComponentBtn.Name = "addComponentBtn";
            this.addComponentBtn.Size = new System.Drawing.Size(75, 23);
            this.addComponentBtn.TabIndex = 5;
            this.addComponentBtn.Text = "Add";
            this.addComponentBtn.UseVisualStyleBackColor = true;
            this.addComponentBtn.Click += new System.EventHandler(this.addComponentBtn_Click);
            // 
            // deleteBtnComputer
            // 
            this.deleteBtnComputer.Location = new System.Drawing.Point(387, 111);
            this.deleteBtnComputer.Name = "deleteBtnComputer";
            this.deleteBtnComputer.Size = new System.Drawing.Size(75, 23);
            this.deleteBtnComputer.TabIndex = 6;
            this.deleteBtnComputer.Text = "Delete";
            this.deleteBtnComputer.UseVisualStyleBackColor = true;
            this.deleteBtnComputer.Click += new System.EventHandler(this.deleteBtnComputer_Click);
            // 
            // editBtnComputer
            // 
            this.editBtnComputer.Location = new System.Drawing.Point(292, 111);
            this.editBtnComputer.Name = "editBtnComputer";
            this.editBtnComputer.Size = new System.Drawing.Size(75, 23);
            this.editBtnComputer.TabIndex = 7;
            this.editBtnComputer.Text = "Edit";
            this.editBtnComputer.UseVisualStyleBackColor = true;
            this.editBtnComputer.Click += new System.EventHandler(this.editBtnComputer_Click);
            // 
            // deleteBtnComp
            // 
            this.deleteBtnComp.Location = new System.Drawing.Point(955, 108);
            this.deleteBtnComp.Name = "deleteBtnComp";
            this.deleteBtnComp.Size = new System.Drawing.Size(75, 23);
            this.deleteBtnComp.TabIndex = 8;
            this.deleteBtnComp.Text = "Delete";
            this.deleteBtnComp.UseVisualStyleBackColor = true;
            this.deleteBtnComp.Click += new System.EventHandler(this.deleteBtnComp_Click);
            // 
            // editBtnComp
            // 
            this.editBtnComp.Location = new System.Drawing.Point(854, 108);
            this.editBtnComp.Name = "editBtnComp";
            this.editBtnComp.Size = new System.Drawing.Size(75, 23);
            this.editBtnComp.TabIndex = 9;
            this.editBtnComp.Text = "Edit";
            this.editBtnComp.UseVisualStyleBackColor = true;
            this.editBtnComp.Click += new System.EventHandler(this.editBtnComp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1146, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.componentToBinaryToolStripMenuItem});
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.serializareToolStripMenuItem.Text = "Serialization";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.binaryToolStripMenuItem.Text = "Computer to binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // componentToBinaryToolStripMenuItem
            // 
            this.componentToBinaryToolStripMenuItem.Name = "componentToBinaryToolStripMenuItem";
            this.componentToBinaryToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.componentToBinaryToolStripMenuItem.Text = "Component to binary";
            this.componentToBinaryToolStripMenuItem.Click += new System.EventHandler(this.componentToBinaryToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem1,
            this.componentToolStripMenuItem});
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deserializareToolStripMenuItem.Text = "Deserialization";
            // 
            // binaryToolStripMenuItem1
            // 
            this.binaryToolStripMenuItem1.Name = "binaryToolStripMenuItem1";
            this.binaryToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.binaryToolStripMenuItem1.Text = "Computer";
            this.binaryToolStripMenuItem1.Click += new System.EventHandler(this.binaryToolStripMenuItem1_Click);
            // 
            // componentToolStripMenuItem
            // 
            this.componentToolStripMenuItem.Name = "componentToolStripMenuItem";
            this.componentToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.componentToolStripMenuItem.Text = "Component";
            this.componentToolStripMenuItem.Click += new System.EventHandler(this.componentToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddComponentOrPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 606);
            this.Controls.Add(this.editBtnComp);
            this.Controls.Add(this.deleteBtnComp);
            this.Controls.Add(this.editBtnComputer);
            this.Controls.Add(this.deleteBtnComputer);
            this.Controls.Add(this.addComponentBtn);
            this.Controls.Add(this.addComputerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvComp);
            this.Controls.Add(this.lvComputers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddComponentOrPc";
            this.Text = "AddComponentOrPc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddComponentOrPc_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddComponentOrPc_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvComputers;
        private System.Windows.Forms.ListView lvComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addComputerBtn;
        private System.Windows.Forms.Button addComponentBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button deleteBtnComputer;
        private System.Windows.Forms.Button editBtnComputer;
        private System.Windows.Forms.Button deleteBtnComp;
        private System.Windows.Forms.Button editBtnComp;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem componentToBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}