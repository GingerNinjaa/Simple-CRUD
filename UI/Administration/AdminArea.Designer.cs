namespace UI.Administration
{
    partial class AdminArea
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildFormAdmin = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAdminAllEmployee = new System.Windows.Forms.Button();
            this.btnAdminChangePassword = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnAdminAddEmployee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnDeleteEmployee);
            this.panel1.Controls.Add(this.btnAdminAllEmployee);
            this.panel1.Controls.Add(this.btnAdminChangePassword);
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Controls.Add(this.btnAdminAddEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 45);
            this.panel1.TabIndex = 2;
            // 
            // panelChildFormAdmin
            // 
            this.panelChildFormAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormAdmin.Location = new System.Drawing.Point(0, 45);
            this.panelChildFormAdmin.Name = "panelChildFormAdmin";
            this.panelChildFormAdmin.Size = new System.Drawing.Size(1084, 716);
            this.panelChildFormAdmin.TabIndex = 7;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Image = global::UI.Properties.Resources.trash_32px;
            this.btnDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(447, 3);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(218, 39);
            this.btnDeleteEmployee.TabIndex = 7;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnAdminAllEmployee
            // 
            this.btnAdminAllEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminAllEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminAllEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAdminAllEmployee.Image = global::UI.Properties.Resources.refresh_30px;
            this.btnAdminAllEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminAllEmployee.Location = new System.Drawing.Point(109, 3);
            this.btnAdminAllEmployee.Name = "btnAdminAllEmployee";
            this.btnAdminAllEmployee.Size = new System.Drawing.Size(132, 39);
            this.btnAdminAllEmployee.TabIndex = 6;
            this.btnAdminAllEmployee.Text = "Refresh";
            this.btnAdminAllEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminAllEmployee.UseVisualStyleBackColor = true;
            this.btnAdminAllEmployee.Click += new System.EventHandler(this.btnAdminAllEmployee_Click);
            // 
            // btnAdminChangePassword
            // 
            this.btnAdminChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnAdminChangePassword.Image = global::UI.Properties.Resources.lock_26px;
            this.btnAdminChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminChangePassword.Location = new System.Drawing.Point(671, 3);
            this.btnAdminChangePassword.Name = "btnAdminChangePassword";
            this.btnAdminChangePassword.Size = new System.Drawing.Size(211, 39);
            this.btnAdminChangePassword.TabIndex = 5;
            this.btnAdminChangePassword.Text = "Change Password";
            this.btnAdminChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminChangePassword.UseVisualStyleBackColor = true;
            this.btnAdminChangePassword.Click += new System.EventHandler(this.btnAdminChangePassword_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Image = global::UI.Properties.Resources.undo_32px;
            this.btnGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoBack.Location = new System.Drawing.Point(3, 3);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(100, 39);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Wróć";
            this.btnGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnAdminAddEmployee
            // 
            this.btnAdminAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAdminAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdminAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAdminAddEmployee.Image = global::UI.Properties.Resources.add_user_26px;
            this.btnAdminAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminAddEmployee.Location = new System.Drawing.Point(247, 3);
            this.btnAdminAddEmployee.Name = "btnAdminAddEmployee";
            this.btnAdminAddEmployee.Size = new System.Drawing.Size(194, 39);
            this.btnAdminAddEmployee.TabIndex = 4;
            this.btnAdminAddEmployee.Text = "Add Employee";
            this.btnAdminAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminAddEmployee.UseVisualStyleBackColor = false;
            this.btnAdminAddEmployee.Click += new System.EventHandler(this.btnAdminAddEmployee_Click);
            // 
            // AdminArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.panelChildFormAdmin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminArea";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminAddEmployee;
        private System.Windows.Forms.Button btnAdminChangePassword;
        private System.Windows.Forms.Button btnAdminAllEmployee;
        private System.Windows.Forms.Panel panelChildFormAdmin;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}