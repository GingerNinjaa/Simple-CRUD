using System;
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
using Mail;

namespace UI.Common
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
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



        private void Alert(string msg, Messages.enmType type)
        {
            Messages popup = new Messages();
            popup.showAlert(msg, type);
        }

        #region Login and Password
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            //Jeśli pole zawiera User To zamien to na puste pole
            if (txtEmail.Text == "USER")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            // jeśli pole jest puste to wpisz tam "USER"
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "USER";
                txtEmail.ForeColor = Color.DimGray;
            }
        }


        #endregion


        // Logowanie do Systemu 
        private void btnLogin_Click(object sender, EventArgs e)
        {

            
            var menu = new MainBoard();
            menu.Show();
            

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();

            SendMail mail = new SendMail();
            mail.Send();

            var login = new Login();
            login.Show();
            this.Alert("Check your mailbox", Messages.enmType.Success);
        }
    }
}
