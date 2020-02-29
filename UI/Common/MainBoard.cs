using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using UI.Stock;
using UI.Administration;
using Cache;

namespace UI.Common
{
    public partial class MainBoard : Form
    {
        //tblUser CurentUser = new tblUser();
          AddStock addstock = new AddStock();
        public MainBoard()
        {
            //this.CurentUser = dto;

            InitializeComponent();
            customizeDesing();
/*
            if (CurentUser.Role.Trim() != "Admin") 
            {
                btnAdministration.Enabled = false;
            }
            */
        }

        private void Alert(string msg, Messages.enmType type)
        {
            Messages popup = new Messages();
            popup.showAlert(msg, type);
        }

        #region
        //Turbo ważne do przesuwanie okienka PART 2
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Przesuwanie Okien PART 3  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelSideMenu_MouseDown(object sender, MouseEventArgs e)
        {
            //Przesuwanie Okien PART 3  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        private void customizeDesing()
        {
            // chowamy submenu
          
            panelPlaylistSubmenu.Visible = false;

        }

  

        private void showSubMenu(Panel subMenu)
        {
            // jeśli submenu jest schowane 
            if (subMenu.Visible == false)
            {
                //chowaj wszystkie submenu
                // hideSubMenu();

                //pokaż to nasze submenu
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);
        }

        #region PlaylistSubMenuButtons

        private void btnShowStock_Click(object sender, EventArgs e)
        {

            openChildForm(new AllStock());


          //  hideSubMenu();
        }

        //
   
        private void button6_Click(object sender, EventArgs e)
        {

            addstock.Visible = !addstock.Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        #endregion



        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm!=null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();      
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new User());

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Alert("Welcome to my website", Messages.enmType.Info);

            System.Diagnostics.Process.Start("https://www.dlewandowski.pl");
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Alert("Logout", Messages.enmType.Info);

            //Clear cache
            ActiveUser.Reset();


            this.Hide();
            var login = new Login();
            login.Show();
        }



        private void btnAdministration_Click(object sender, EventArgs e)
        {

           openChildForm(new AdminArea());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
