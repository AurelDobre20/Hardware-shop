namespace Hardware_Shop
{
    partial class AdminOrCustomer
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
            this.label2 = new System.Windows.Forms.Label();
            this.adminBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.customerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Are you a customer or an admin?";
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(122, 135);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(86, 29);
            this.adminBtn.TabIndex = 4;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // customerBtn
            // 
            this.customerBtn.Location = new System.Drawing.Point(122, 214);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(86, 29);
            this.customerBtn.TabIndex = 5;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // AdminOrCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 316);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.label2);
            this.Name = "AdminOrCustomer";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminOrCustomer_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminOrCustomer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button customerBtn;
    }
}

