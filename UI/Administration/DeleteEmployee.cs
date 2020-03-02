using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Common;

namespace UI.Administration
{
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
        {
            InitializeComponent();
            FillComboBox();
        }

        #region
        //Turbo ważne do przesuwanie okienka PART 2
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void DeleteEmployee_MouseDown(object sender, MouseEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillComboBox()
        {
            using (DbModel db = new DbModel())
            {
                cbDeleteUser.DataSource = db.Users.ToList();
                cbDeleteUser.ValueMember = "UserId";
                cbDeleteUser.DisplayMember = "UserName";
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //when I select user name from combobox txtbox fill witch data 
            //(FirstName and LastName)


            try
            {
                this.Alert("Succes", Messages.enmType.Success);
            }
            catch (Exception ex)
            {

                this.Alert(ex.Message, Messages.enmType.Error);
            }
        }
        private void FillTextBox()
        {
            //txtDeleteUserFirstName.Text =
            //txtDeleteUserLastName.Text =
        }


    }
}
