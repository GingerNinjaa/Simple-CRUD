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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdminAllEmployee = new System.Windows.Forms.Button();
            this.btnAdminChangePassword = new System.Windows.Forms.Button();
            this.btnAdminAddEmployee = new System.Windows.Forms.Button();
            this.panelChildFormAdmin = new System.Windows.Forms.Panel();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(28, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 0;
            this.btnGoBack.Text = "Wróć";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteEmployee);
            this.panel1.Controls.Add(this.btnAdminAllEmployee);
            this.panel1.Controls.Add(this.btnAdminChangePassword);
            this.panel1.Controls.Add(this.btnGoBack);
            this.panel1.Controls.Add(this.btnAdminAddEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 35);
            this.panel1.TabIndex = 2;
            // 
            // btnAdminAllEmployee
            // 
            this.btnAdminAllEmployee.Location = new System.Drawing.Point(140, 12);
            this.btnAdminAllEmployee.Name = "btnAdminAllEmployee";
            this.btnAdminAllEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAdminAllEmployee.TabIndex = 6;
            this.btnAdminAllEmployee.Text = "All Employee";
            this.btnAdminAllEmployee.UseVisualStyleBackColor = true;
            this.btnAdminAllEmployee.Click += new System.EventHandler(this.btnAdminAllEmployee_Click);
            // 
            // btnAdminChangePassword
            // 
            this.btnAdminChangePassword.Location = new System.Drawing.Point(537, 12);
            this.btnAdminChangePassword.Name = "btnAdminChangePassword";
            this.btnAdminChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnAdminChangePassword.TabIndex = 5;
            this.btnAdminChangePassword.Text = "ChangePassword";
            this.btnAdminChangePassword.UseVisualStyleBackColor = true;
            this.btnAdminChangePassword.Click += new System.EventHandler(this.btnAdminChangePassword_Click);
            // 
            // btnAdminAddEmployee
            // 
            this.btnAdminAddEmployee.Location = new System.Drawing.Point(247, 12);
            this.btnAdminAddEmployee.Name = "btnAdminAddEmployee";
            this.btnAdminAddEmployee.Size = new System.Drawing.Size(139, 23);
            this.btnAdminAddEmployee.TabIndex = 4;
            this.btnAdminAddEmployee.Text = "Add Employee";
            this.btnAdminAddEmployee.UseVisualStyleBackColor = true;
            this.btnAdminAddEmployee.Click += new System.EventHandler(this.btnAdminAddEmployee_Click);
            // 
            // panelChildFormAdmin
            // 
            this.panelChildFormAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormAdmin.Location = new System.Drawing.Point(0, 35);
            this.panelChildFormAdmin.Name = "panelChildFormAdmin";
            this.panelChildFormAdmin.Size = new System.Drawing.Size(1084, 726);
            this.panelChildFormAdmin.TabIndex = 7;
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(392, 12);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(139, 23);
            this.btnDeleteEmployee.TabIndex = 7;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
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