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
using Data;
using System.Data.Entity.Validation;

namespace UI.Administration
{
    public partial class AddEmployee : Form
    {
        public int UserId { get; set; }
        public AddEmployee()
        {
            InitializeComponent();
        }
        private void FillComboBox()
        {
            using (DbModel db = new DbModel())
            {
                cbAdminPickPosition.DataSource = db.Positions.ToList();
                cbAdminPickPosition.ValueMember = "PositionId";
                cbAdminPickPosition.DisplayMember = "PositionName";
            }
        }

        #region
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
        #endregion
        private void Alert(string msg, Messages.enmType type)
        {
            Messages popup = new Messages();
            popup.showAlert(msg, type);
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }
        private void btnAdminAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AddNew();
                this.Alert("Succes", Messages.enmType.Success);
                ClearBoard();

                AllEmployee mtp = new AllEmployee();
                mtp.FillDataGrid();

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

        private void AddNew()
        {

            BusinessLogic.AddUser add = new BusinessLogic.AddUser
                                       (this.UserId,txtAdminAddUserName.Text, txtAdminAddPassword.Text,txtAdminAddPasswordConfirm.Text, txtAdminAddFirstName.Text,
                                       txtAdminAddLastName.Text, cbAdminPickPosition.Text, txtAdminAddEmail.Text);

            add.Add_or_Edit();
        }

        private void ClearBoard()
        {
            txtAdminAddEmail.Text = null;
            txtAdminAddFirstName.Text = null;
            txtAdminAddLastName.Text = null;
            txtAdminAddPassword.Text = null;
            txtAdminAddPasswordConfirm.Text = null;
            txtAdminAddUserName.Text = null;
        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {    
            this.Visible = false;
        }
    }
}
