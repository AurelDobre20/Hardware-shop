namespace Hardware_Shop
{
    partial class AddEditFormComputer
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
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbProcessor = new System.Windows.Forms.TextBox();
            this.tbGraphicsCard = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.upDId = new System.Windows.Forms.NumericUpDown();
            this.upDRam = new System.Windows.Forms.NumericUpDown();
            this.upDStorage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.upDPrice = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.upDId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(375, 51);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 22);
            this.tbBrand.TabIndex = 4;
            this.tbBrand.Validating += new System.ComponentModel.CancelEventHandler(this.tbBrand_Validating);
            // 
            // tbProcessor
            // 
            this.tbProcessor.Location = new System.Drawing.Point(375, 122);
            this.tbProcessor.Name = "tbProcessor";
            this.tbProcessor.Size = new System.Drawing.Size(100, 22);
            this.tbProcessor.TabIndex = 5;
            this.tbProcessor.Validating += new System.ComponentModel.CancelEventHandler(this.tbProcessor_Validating);
            // 
            // tbGraphicsCard
            // 
            this.tbGraphicsCard.Location = new System.Drawing.Point(375, 201);
            this.tbGraphicsCard.Name = "tbGraphicsCard";
            this.tbGraphicsCard.Size = new System.Drawing.Size(100, 22);
            this.tbGraphicsCard.TabIndex = 6;
            this.tbGraphicsCard.Validating += new System.ComponentModel.CancelEventHandler(this.tbGraphicsCard_Validating);
            // 
            // Save
            // 
            this.Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save.Location = new System.Drawing.Point(400, 375);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(109, 375);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // upDId
            // 
            this.upDId.Location = new System.Drawing.Point(109, 52);
            this.upDId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDId.Name = "upDId";
            this.upDId.Size = new System.Drawing.Size(120, 22);
            this.upDId.TabIndex = 9;
            // 
            // upDRam
            // 
            this.upDRam.Location = new System.Drawing.Point(109, 123);
            this.upDRam.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDRam.Name = "upDRam";
            this.upDRam.Size = new System.Drawing.Size(120, 22);
            this.upDRam.TabIndex = 10;
            // 
            // upDStorage
            // 
            this.upDStorage.Location = new System.Drawing.Point(109, 202);
            this.upDStorage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDStorage.Name = "upDStorage";
            this.upDStorage.Size = new System.Drawing.Size(120, 22);
            this.upDStorage.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "RAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Storage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Processor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "GraphicsCard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Price";
            // 
            // upDPrice
            // 
            this.upDPrice.Location = new System.Drawing.Point(109, 292);
            this.upDPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDPrice.Name = "upDPrice";
            this.upDPrice.Size = new System.Drawing.Size(120, 22);
            this.upDPrice.TabIndex = 23;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddEditFormComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.upDPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upDStorage);
            this.Controls.Add(this.upDRam);
            this.Controls.Add(this.upDId);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.tbGraphicsCard);
            this.Controls.Add(this.tbProcessor);
            this.Controls.Add(this.tbBrand);
            this.Name = "AddEditFormComputer";
            this.Text = "AddEditFormComputer";
            this.Load += new System.EventHandler(this.AddEditFormComputer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddEditFormComputer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.upDId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbProcessor;
        private System.Windows.Forms.TextBox tbGraphicsCard;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.NumericUpDown upDId;
        private System.Windows.Forms.NumericUpDown upDRam;
        private System.Windows.Forms.NumericUpDown upDStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown upDPrice;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}