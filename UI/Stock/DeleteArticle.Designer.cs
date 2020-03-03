namespace UI.Stock
{
    partial class DeleteArticle
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDeleteArticle = new System.Windows.Forms.ComboBox();
            this.txtDeleteProductDescription = new System.Windows.Forms.TextBox();
            this.txtDeleteProductPrice = new System.Windows.Forms.TextBox();
            this.txtDeleteProductCategory = new System.Windows.Forms.TextBox();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(144, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Delete Artice";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::UI.Properties.Resources.close_window_32px;
            this.btnClose.Location = new System.Drawing.Point(479, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(28, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Article Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(28, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(28, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 50);
            this.label4.TabIndex = 36;
            this.label4.Text = "Article \r\nDescription";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(28, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(28, 327);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Category";
            // 
            // cbDeleteArticle
            // 
            this.cbDeleteArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDeleteArticle.FormattingEnabled = true;
            this.cbDeleteArticle.Location = new System.Drawing.Point(199, 76);
            this.cbDeleteArticle.Name = "cbDeleteArticle";
            this.cbDeleteArticle.Size = new System.Drawing.Size(200, 28);
            this.cbDeleteArticle.TabIndex = 39;
            this.cbDeleteArticle.SelectedIndexChanged += new System.EventHandler(this.cbDeleteArticle_SelectedIndexChanged);
            this.cbDeleteArticle.TextChanged += new System.EventHandler(this.cbDeleteArticle_TextChanged);
            this.cbDeleteArticle.Click += new System.EventHandler(this.cbDeleteArticle_Click);
            // 
            // txtDeleteProductDescription
            // 
            this.txtDeleteProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDeleteProductDescription.Location = new System.Drawing.Point(199, 160);
            this.txtDeleteProductDescription.Multiline = true;
            this.txtDeleteProductDescription.Name = "txtDeleteProductDescription";
            this.txtDeleteProductDescription.Size = new System.Drawing.Size(281, 61);
            this.txtDeleteProductDescription.TabIndex = 40;
            // 
            // txtDeleteProductPrice
            // 
            this.txtDeleteProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDeleteProductPrice.Location = new System.Drawing.Point(199, 264);
            this.txtDeleteProductPrice.Name = "txtDeleteProductPrice";
            this.txtDeleteProductPrice.Size = new System.Drawing.Size(200, 26);
            this.txtDeleteProductPrice.TabIndex = 42;
            // 
            // txtDeleteProductCategory
            // 
            this.txtDeleteProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDeleteProductCategory.Location = new System.Drawing.Point(199, 328);
            this.txtDeleteProductCategory.Name = "txtDeleteProductCategory";
            this.txtDeleteProductCategory.Size = new System.Drawing.Size(200, 26);
            this.txtDeleteProductCategory.TabIndex = 43;
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnAddArticle.FlatAppearance.BorderSize = 0;
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddArticle.ForeColor = System.Drawing.Color.White;
            this.btnAddArticle.Image = global::UI.Properties.Resources.submit_for_approval_32px;
            this.btnAddArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddArticle.Location = new System.Drawing.Point(374, 389);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(140, 57);
            this.btnAddArticle.TabIndex = 45;
            this.btnAddArticle.Text = "Delete";
            this.btnAddArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // DeleteArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(526, 458);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.txtDeleteProductCategory);
            this.Controls.Add(this.txtDeleteProductPrice);
            this.Controls.Add(this.txtDeleteProductDescription);
            this.Controls.Add(this.cbDeleteArticle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteArticle";
            this.Text = "DeleteArticle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteArticle_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDeleteArticle;
        public System.Windows.Forms.TextBox txtDeleteProductDescription;
        public System.Windows.Forms.TextBox txtDeleteProductPrice;
        public System.Windows.Forms.TextBox txtDeleteProductCategory;
        private System.Windows.Forms.Button btnAddArticle;
    }
}