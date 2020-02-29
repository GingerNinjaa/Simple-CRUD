using System;
using BusinessLogic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Przesuwanie okien PART 1
using System.Runtime.InteropServices;



namespace UI.Common
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region
        //Turbo ważne do przesuwanie okienka PART 2
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Przesuwanie Okien PART 3  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Przesuwanie Okien PART 3  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Alert(string msg, Messages.enmType type)
        {
            Messages popup = new Messages();
            popup.showAlert(msg, type);
        }

        #region Login and Password
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            //Jeśli pole zawiera User To zamien to na puste pole
            if (txtLogin.Text == "USER")
            {
                txtLogin.Text = "";
                txtLogin.ForeColor = Color.LightGray;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            // jeśli pole jest puste to wpisz tam "USER"
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "USER";
                txtLogin.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //Jeśli pole zawiera PASSWORD To zamien to na puste pole
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            // jeśli pole jest puste to wpisz tam "PASSWORD"
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }

        }
        #endregion

        private void GetAccess()
        {
            Login_access log = new Login_access(txtLogin.Text,txtPassword.Text);

            try
            {
                log.Logowanie();

                this.Hide();
                var menu = new MainBoard();
                menu.Show();
                this.Alert("Access granted", Messages.enmType.Success);
            }
            catch (Exception e)
            {
                 this.Alert(e.ToString(), Messages.enmType.Error); 
            }
            


        }
        // Logowanie do Systemu 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetAccess();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void linkPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var reset = new ResetPassword();
            reset.Show();
        }
    }
}
