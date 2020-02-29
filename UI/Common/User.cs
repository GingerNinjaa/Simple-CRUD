using BusinessLogic;
using Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Common
{
    public partial class User : Form
    {

        public User()
        {

            InitializeComponent();
            setUserData();
        }

        private void Alert(string msg, Messages.enmType type)
        {
            Messages popup = new Messages();
            popup.showAlert(msg, type);
        }

        private void setUserData()
        {

            //Show part
            lblUserNameShow.Text = ActiveUser.c_UserName;
            lblFirstNameShow.Text = ActiveUser.c_FirstName;
            lblLastNameShow.Text = ActiveUser.c_LastName;
            lblEmailShow.Text = ActiveUser.c_Email;
            lblPositionShow.Text = ActiveUser.c_Position;

            //Edit part
            txtUserNameEdit.Text = ActiveUser.c_UserName;
            txtFirstNameEdit.Text = ActiveUser.c_FirstName;
            txtLastNameEdit.Text = ActiveUser.c_LastName;
            txtEmailEdit.Text = ActiveUser.c_Email;

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region magicEnterLeaveZone

        private void txtFirstNameEdit_Enter_1(object sender, EventArgs e)
        {
            /*
            //If the textbox contain CurentUser.FirstName, change to ""
            if (txtFirstNameEdit.Text == CurentUser.FirstName.ToString())
            {
                txtFirstNameEdit.Text = "";

            }
            */
        }

        private void txtFirstNameEdit_Leave_1(object sender, EventArgs e)
        {
            /*
            // If the textbox is empty fill with CurentUser.FirstName
            if (txtFirstNameEdit.Text == "")
            {
                txtFirstNameEdit.Text = CurentUser.FirstName.ToString();

            }
            */
        }


        private void txtUserNameEdit_Enter(object sender, EventArgs e)
        {
            /*
            if (txtUserNameEdit.Text == CurentUser.UserName.ToString())
            {
                txtUserNameEdit.Text = "";

            }
            */
        }

        private void txtUserNameEdit_Leave(object sender, EventArgs e)
        {
            /*
            if (txtUserNameEdit.Text == "")
            {
                txtUserNameEdit.Text = CurentUser.UserName.ToString();

            }
            */
        }

        private void txtLastNameEdit_Enter(object sender, EventArgs e)
        {
            /*
            if (txtLastNameEdit.Text == CurentUser.LastName.ToString())
            {
                txtLastNameEdit.Text = "";

            }
            */
        }

        private void txtLastNameEdit_Leave(object sender, EventArgs e)
        {
            /*
                if (txtLastNameEdit.Text == "")
                {
                    txtLastNameEdit.Text = CurentUser.LastName.ToString();

                }
                */
        }

        private void txtEmailEdit_Enter(object sender, EventArgs e)
        {
            /*
                if (txtEmailEdit.Text == CurentUser.Email.ToString())
                {
                    txtEmailEdit.Text = "";

                }
                */

        }

        private void txtEmailEdit_Leave(object sender, EventArgs e)
        {
            /*
            if (txtEmailEdit.Text == "")
            {
                txtEmailEdit.Text = CurentUser.Email.ToString();

            }
            */
        }



        #endregion

        private void txtPasswordEdit_TextChanged(object sender, EventArgs e)
        {
            txtPasswordEdit.UseSystemPasswordChar = true;
        }

        private void txtPasswordConfEdit_TextChanged(object sender, EventArgs e)
        {
            txtPasswordConfEdit.UseSystemPasswordChar = true;
        }

        private void btnShowEditPanel_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void btnEditUserDataSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit();
                this.Alert("Data Edited", Messages.enmType.Success);
            }
            catch (Exception ex)
            {

                this.Alert(ex.Message, Messages.enmType.Error);
            }

            txtPasswordConfEdit.Text = "";
            txtPasswordEdit.Text = "";

            setUserData();
        }
        private void Edit()
        {
            EditUserData edit = new EditUserData
                                (ActiveUser.c_Id, txtUserNameEdit.Text, txtFirstNameEdit.Text, txtLastNameEdit.Text,
                                txtEmailEdit.Text, ActiveUser.c_Position, txtPasswordEdit.Text, txtPasswordConfEdit.Text);

            edit.EditUser();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
