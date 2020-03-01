namespace UI.Stock
{
    partial class AddCategory
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbDeleteCategory = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(159, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Delete Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(32, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Category";
            // 
            // cbDeleteCategory
            // 
            this.cbDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDeleteCategory.FormattingEnabled = true;
            this.cbDeleteCategory.Location = new System.Drawing.Point(211, 128);
            this.cbDeleteCategory.Name = "cbDeleteCategory";
            this.cbDeleteCategory.Size = new System.Drawing.Size(215, 28);
            this.cbDeleteCategory.TabIndex = 34;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::UI.Properties.Resources.close_window_32px;
            this.btnClose.Location = new System.Drawing.Point(571, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnAddArticle.FlatAppearance.BorderSize = 0;
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddArticle.ForeColor = System.Drawing.Color.White;
            this.btnAddArticle.Image = global::UI.Properties.Resources.submit_for_approval_32px;
            this.btnAddArticle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddArticle.Location = new System.Drawing.Point(439, 178);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(167, 57);
            this.btnAddArticle.TabIndex = 31;
            this.btnAddArticle.Text = "Delete Category";
            this.btnAddArticle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddArticle.UseVisualStyleBackColor = false;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(618, 247);
            this.Controls.Add(this.cbDeleteCategory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddCategory_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbDeleteCategory;
    }
}