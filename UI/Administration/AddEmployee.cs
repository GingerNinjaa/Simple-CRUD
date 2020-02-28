using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UI.Common;

namespace UI.Administration
{
    public partial class AddEmployee : Form
    {    
        public AddEmployee()
        {
            InitializeComponent();


        }

        //Turbo ważne do przesuwanie okienka PART 2
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AddEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            //Przesuwanie Okien PART 3  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Alert(string msg, Messages.enmType type)
        {
            Messages popup = new Messages();
            popup.showAlert(msg, type);
        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
        private void btnAdminAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //Adding new user to the database
            tblUser model = new tblUser();

            if (txtAdminAddPassword.Text != txtAdminAddPasswordConfirm.Text)
            {
                //RedPopup
                this.Alert("passwords are not the same", Messages.Messages.enmType.Error);
            }

            model.FirstName = txtAdminAddFirstName.Text;
            model.LastName = txtAdminAddLastName.Text;
            model.Email = txtAdminAddEmail.Text;
            model.UserName = txtAdminAddUserName.Text;
            model.Password = txtAdminAddPassword.Text;
            model.Position = cbAdminPickPosition.Text;
            model.Role = cbAdminPickRole.Text;

            try
            {
                using (DB db = new DB())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }

                this.Alert("User added", Messages.Messages.enmType.Success);
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {

                this.Alert("Fail", Messages.Messages.enmType.Error);
            }
            */
        }

        private void cbAdminPickPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {    
            this.Visible = false;
        }
    }
}
