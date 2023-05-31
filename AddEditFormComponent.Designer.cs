namespace Hardware_Shop
{
    partial class AddEditFormComponent
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
            this.tbManu = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.upDId = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.upDPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.upDId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbManu
            // 
            this.tbManu.Location = new System.Drawing.Point(107, 77);
            this.tbManu.Name = "tbManu";
            this.tbManu.Size = new System.Drawing.Size(100, 22);
            this.tbManu.TabIndex = 0;
            this.tbManu.Validating += new System.ComponentModel.CancelEventHandler(this.tbManu_Validating);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(107, 152);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 22);
            this.tbModel.TabIndex = 1;
            this.tbModel.Validating += new System.ComponentModel.CancelEventHandler(this.tbModel_Validating);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(107, 233);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 2;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // upDId
            // 
            this.upDId.Location = new System.Drawing.Point(307, 77);
            this.upDId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDId.Name = "upDId";
            this.upDId.Size = new System.Drawing.Size(120, 22);
            this.upDId.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(352, 324);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(107, 324);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "ID";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(307, 236);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(120, 22);
            this.tbType.TabIndex = 10;
            this.tbType.Validating += new System.ComponentModel.CancelEventHandler(this.tbType_Validating);
            // 
            // upDPrice
            // 
            this.upDPrice.Location = new System.Drawing.Point(307, 158);
            this.upDPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDPrice.Name = "upDPrice";
            this.upDPrice.Size = new System.Drawing.Size(120, 22);
            this.upDPrice.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddEditFormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 421);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.upDPrice);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.upDId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbManu);
            this.Name = "AddEditFormComponent";
            this.Text = "EditAddFormComponent";
            this.Load += new System.EventHandler(this.AddEditFormComponent_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddEditFormComponent_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.upDId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbManu;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown upDId;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.NumericUpDown upDPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}