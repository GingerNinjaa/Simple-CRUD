namespace UI.Administration
{
    partial class DeleteEmployee
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeleteUserFirstName = new System.Windows.Forms.TextBox();
            this.txtDeleteUserLastName = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbDeleteUser = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(123, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Delete Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(31, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(31, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Last Name";
            // 
            // txtDeleteUserFirstName
            // 
            this.txtDeleteUserFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDeleteUserFirstName.Location = new System.Drawing.Point(204, 143);
            this.txtDeleteUserFirstName.Name = "txtDeleteUserFirstName";
            this.txtDeleteUserFirstName.ReadOnly = true;
            this.txtDeleteUserFirstName.Size = new System.Drawing.Size(200, 26);
            this.txtDeleteUserFirstName.TabIndex = 28;
            // 
            // txtDeleteUserLastName
            // 
            this.txtDeleteUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDeleteUserLastName.Location = new System.Drawing.Point(204, 194);
            this.txtDeleteUserLastName.Name = "txtDeleteUserLastName";
            this.txtDeleteUserLastName.ReadOnly = true;
            this.txtDeleteUserLastName.Size = new System.Drawing.Size(200, 26);
            this.txtDeleteUserLastName.TabIndex = 29;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Image = global::UI.Properties.Resources.submit_for_approval_32px;
            this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUser.Location = new System.Drawing.Point(390, 234);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(140, 57);
            this.btnDeleteUser.TabIndex = 31;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::UI.Properties.Resources.close_window_32px;
            this.btnClose.Location = new System.Drawing.Point(495, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbDeleteUser
            // 
            this.cbDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDeleteUser.FormattingEnabled = true;
            this.cbDeleteUser.Location = new System.Drawing.Point(204, 100);
            this.cbDeleteUser.Name = "cbDeleteUser";
            this.cbDeleteUser.Size = new System.Drawing.Size(200, 28);
            this.cbDeleteUser.TabIndex = 34;
            // 
            // DeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(542, 303);
            this.Controls.Add(this.cbDeleteUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.txtDeleteUserLastName);
            this.Controls.Add(this.txtDeleteUserFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteEmployee";
            this.Text = "DeleteEmployee";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeleteEmployee_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeleteUserFirstName;
        private System.Windows.Forms.TextBox txtDeleteUserLastName;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbDeleteUser;
    }
}