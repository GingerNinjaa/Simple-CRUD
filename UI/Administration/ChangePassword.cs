using BusinessLogic;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Common;

namespace UI.Administration
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            FillComboBox();
        }
        public string ChangPassUser { get; set; }

        #region
        //Turbo ważne do przesuwanie okienka PART 2
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ChangePassword_MouseDown(object sender, MouseEventArgs e)
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
        private void FillComboBox()
        {
            using (DbModel db = new DbModel())
            {
                cbChangePassword.DataSource = db.Users.ToList();
                cbChangePassword.ValueMember = "UserId";
                cbChangePassword.DisplayMember = "UserName";
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txtChangePassword_Enter(object sender, EventArgs e)
        {
            txtChangePassword.UseSystemPasswordChar = true;
        }

        private void txtChangePasswordConf_Enter(object sender, EventArgs e)
        {
            txtChangePasswordConf.UseSystemPasswordChar = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                Change();
                this.Alert("Password changed", Messages.enmType.Success);
            }
            catch (DbEntityValidationException)
            {
                this.Alert("Fill all spaces", Messages.enmType.Error);
            }
            catch (Exception ex)
            {

                this.Alert(ex.Message, Messages.enmType.Error);
            }

        }

        private void Change()
        {

            this.ChangPassUser = cbChangePassword.Text;
            ChangePass pass = new ChangePass(
                              this.ChangPassUser
                              ,this.txtChangePassword.Text
                              ,this.txtChangePasswordConf.Text);

            pass.Change();
        }

        private void cbChangePassword_Click(object sender, EventArgs e)
        {
            FillComboBox();
        }
    }
}
