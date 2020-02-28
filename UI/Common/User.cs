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
       // tblUser CurentUser = new tblUser();
        public User()
        {
            //CurentUser = user;
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
            /*
            //Show part
            lblUserNameShow.Text = CurentUser.UserName;
            lblFirstNameShow.Text = CurentUser.FirstName;
            lblLastNameShow.Text = CurentUser.LastName;
            lblEmailShow.Text = CurentUser.Email;
            lblPositionShow.Text = CurentUser.Position;

            //Edit part
            txtUserNameEdit.Text = CurentUser.UserName.ToString();
            txtFirstNameEdit.Text = CurentUser.FirstName.ToString();
            txtLastNameEdit.Text = CurentUser.LastName.ToString();
            txtEmailEdit.Text = CurentUser.Email.ToString();
            */
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
            /*
            using (DB db = new DB())
            {
                if (db.Users.Any(x => x.UserName.Equals(txtUserNameEdit.Text)) && CurentUser.UserName != lblUserNameShow.Text)
                {
                    //wyswietli ten czerwony prostokąt
                    this.Alert("Username is taken", Messages.enmType.Error);
                }
                else if (txtPasswordEdit.Text != txtPasswordConfEdit.Text)
                {
                    //wyswietli ten czerwony prostokąt
                    this.Alert("passwords are not the same", Messages.enmType.Error);
                }
                else
                {
                    this.CurentUser.UserId = this.CurentUser.UserId;
                    this.CurentUser.UserName = txtUserNameEdit.Text.Trim();
                    this.CurentUser.FirstName = txtFirstNameEdit.Text.Trim();
                    this.CurentUser.LastName = txtLastNameEdit.Text.Trim();
                    this.CurentUser.Email = txtEmailEdit.Text.Trim();

                    if (txtPasswordEdit.Text != "" && txtPasswordConfEdit.Text != "")
                    {
                        if (txtPasswordEdit.Text == txtPasswordConfEdit.Text)
                        {
                            this.CurentUser.Password = txtPasswordConfEdit.Text.Trim();
                        }
                    }

                    //if admin
                    this.CurentUser.Position = "User";
                    this.CurentUser.Role = "User";


                    db.Entry(CurentUser).State = EntityState.Modified;
                    db.SaveChanges();

                    //ten zielony komunikat
                    this.Alert("Edit succes", Messages.enmType.Success);
                }
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
    }
}
