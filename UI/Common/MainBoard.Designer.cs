namespace UI.Common
{
    partial class MainBoard
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panelPlaylistSubmenu = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnShowStock = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnAdministration = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSideMenu.SuspendLayout();
            this.panelPlaylistSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelSideMenu.Controls.Add(this.btnLogout);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.btnUser);
            this.panelSideMenu.Controls.Add(this.panelPlaylistSubmenu);
            this.panelSideMenu.Controls.Add(this.btnStock);
            this.panelSideMenu.Controls.Add(this.btnAdministration);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 800);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSideMenu_MouseDown);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.ForeColor = System.Drawing.Color.Honeydew;
            this.btnLogout.Image = global::UI.Properties.Resources.logout_rounded_down_32px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 572);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(250, 45);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Wyloguj";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.ForeColor = System.Drawing.Color.Honeydew;
            this.btnHelp.Image = global::UI.Properties.Resources.help_32px;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 527);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(250, 45);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUser.ForeColor = System.Drawing.Color.Honeydew;
            this.btnUser.Image = global::UI.Properties.Resources.user_32px;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 482);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(250, 45);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Uzytkownik";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panelPlaylistSubmenu
            // 
            this.panelPlaylistSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelPlaylistSubmenu.Controls.Add(this.button5);
            this.panelPlaylistSubmenu.Controls.Add(this.btnAddStock);
            this.panelPlaylistSubmenu.Controls.Add(this.btnShowStock);
            this.panelPlaylistSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlaylistSubmenu.Location = new System.Drawing.Point(0, 358);
            this.panelPlaylistSubmenu.Name = "panelPlaylistSubmenu";
            this.panelPlaylistSubmenu.Size = new System.Drawing.Size(250, 124);
            this.panelPlaylistSubmenu.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(166)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.Honeydew;
            this.button5.Location = new System.Drawing.Point(0, 80);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(166)))));
            this.btnAddStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStock.FlatAppearance.BorderSize = 0;
            this.btnAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddStock.ForeColor = System.Drawing.Color.Honeydew;
            this.btnAddStock.Image = global::UI.Properties.Resources.add_item_32px;
            this.btnAddStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.Location = new System.Drawing.Point(0, 40);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddStock.Size = new System.Drawing.Size(250, 40);
            this.btnAddStock.TabIndex = 1;
            this.btnAddStock.Text = "Dodaj Towar";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnShowStock
            // 
            this.btnShowStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(128)))), ((int)(((byte)(166)))));
            this.btnShowStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowStock.FlatAppearance.BorderSize = 0;
            this.btnShowStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowStock.ForeColor = System.Drawing.Color.Honeydew;
            this.btnShowStock.Image = global::UI.Properties.Resources.depot_32px;
            this.btnShowStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowStock.Location = new System.Drawing.Point(0, 0);
            this.btnShowStock.Name = "btnShowStock";
            this.btnShowStock.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnShowStock.Size = new System.Drawing.Size(250, 40);
            this.btnShowStock.TabIndex = 0;
            this.btnShowStock.Text = "Pokaż Towar";
            this.btnShowStock.UseVisualStyleBackColor = false;
            this.btnShowStock.Click += new System.EventHandler(this.btnShowStock_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStock.ForeColor = System.Drawing.Color.Honeydew;
            this.btnStock.Image = global::UI.Properties.Resources.box_32px;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 313);
            this.btnStock.Name = "btnStock";
            this.btnStock.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStock.Size = new System.Drawing.Size(250, 45);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Towar";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnAdministration
            // 
            this.btnAdministration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAdministration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministration.FlatAppearance.BorderSize = 0;
            this.btnAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdministration.ForeColor = System.Drawing.Color.Honeydew;
            this.btnAdministration.Image = global::UI.Properties.Resources.admin_settings_male_32px;
            this.btnAdministration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministration.Location = new System.Drawing.Point(0, 245);
            this.btnAdministration.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.btnAdministration.Size = new System.Drawing.Size(250, 68);
            this.btnAdministration.TabIndex = 1;
            this.btnAdministration.Text = "Administration";
            this.btnAdministration.UseVisualStyleBackColor = false;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 245);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 245);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1100, 800);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1350, 800);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(1350, 800);
            this.Name = "MainBoard";
            this.Opacity = 0D;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainBoard_FormClosed);
            this.panelSideMenu.ResumeLayout(false);
            this.panelPlaylistSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panelPlaylistSubmenu;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnShowStock;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnAdministration;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timer1;
    }
}

