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
using UI.Common;
using BusinessLogic;
using Data;

namespace UI.Stock
{
    public partial class DeleteCategory : Form
    {
        public DeleteCategory()
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

        private void AddCategory_MouseDown(object sender, MouseEventArgs e)
        {
            //Przesuwanie Okien PART 3  
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void Alert(string msg, Messages.enmType type)
        {
            Messages popup = new Messages();
            popup.showAlert(msg, type);

        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            try
            {
                delete();
                this.Alert("Category added", Messages.enmType.Success);
            }
            catch (Exception ex)  //System.Data.Entity.Validation.DbEntityValidationException
            {
                this.Alert(ex.Message, Messages.enmType.Error);  
            }
            FillComboBox();
        }

        private void delete()
        {
            BusinessLogic.DeleteCategory del = new BusinessLogic.DeleteCategory(cbDeleteCategory.Text);
            del.Delete();
        }

        private void FillComboBox()
        {
            using (DbModel db = new DbModel())
            {
                cbDeleteCategory.DataSource = db.Categories.ToList();
                cbDeleteCategory.ValueMember = "CategoryId";
                cbDeleteCategory.DisplayMember = "CategoryName";
               
               
            }
        }

    }
}
