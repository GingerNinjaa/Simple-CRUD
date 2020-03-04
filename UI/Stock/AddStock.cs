using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Przesuwanie okna PART 1 
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UI.Common;
using BusinessLogic;
using Data;
using System.Data.Entity.Validation;

namespace UI.Stock
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        #region
        //Turbo ważne do przesuwanie okienka PART 2
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AddStock_MouseDown(object sender, MouseEventArgs e)
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


        private void txtAddProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            // this.Close();

            this.Visible = false;
            
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewArticle();
                ClearBoard();
                FillComboBox();
                this.Alert("Success", Messages.enmType.Success);  //Messages.Messages.enmType.Success
            }
            catch (DbEntityValidationException)
            {
                this.Alert("Fill all spaces", Messages.enmType.Error);
            }
            catch (Exception ex)
            {
                this.Alert(ex.Message, Messages.enmType.Error);
            }

           
            //System.Data.Entity.Validation.DbEntityValidationException
        }

        private void AddNewArticle()
        {
            AddArticle add = new AddArticle(txtAddProductName.Text,txtAddProductDescription.Text,decimal.Parse(txtAddProductPrice.Text),cbAddProductCategory.Text);

            add.Add_or_edit();
        }
        private void ClearBoard()
        {
            txtAddProductName.Text = null;
            txtAddProductDescription.Text = null;
            txtAddProductPrice.Text = null;
        }

        private void btnAddProductClear_Click(object sender, EventArgs e)
        {
            txtAddProductName.Text = "";
            txtAddProductDescription.Text = "";
            txtAddProductPrice.Text = "";
            cbAddProductCategory.Text = "";
        }
        private void FillComboBox()
        {
            using (DbModel db = new DbModel())
            {
                cbAddProductCategory.DataSource = db.Categories.ToList();
                cbAddProductCategory.ValueMember = "CategoryId";
                cbAddProductCategory.DisplayMember = "CategoryName";
            }
        }


    }
}
