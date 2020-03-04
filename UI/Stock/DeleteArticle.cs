using BusinessLogic;
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

namespace UI.Stock
{
    public partial class DeleteArticle : Form
    {
        public DeleteArticle()
        {
            InitializeComponent();
            FillComboBox();
        }
        public int DeletedArticleId { get; set; }

        #region
        //Turbo ważne do przesuwanie okienka PART 2
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void DeleteArticle_MouseDown(object sender, MouseEventArgs e)
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
                cbDeleteArticle.DataSource = db.Articles.ToList();
                cbDeleteArticle.ValueMember = "ArticleId";
                cbDeleteArticle.DisplayMember = "ArticleName";
            }
        }
        private void FillTextBox()
        {
            
            using (DbModel db = new DbModel())
            {

                txtDeleteProductDescription.Text = db.Articles.ToList().Find(x => x.ArticleName == cbDeleteArticle.Text).ArticleDescription;

                txtDeleteProductPrice.Text = db.Articles.ToList().Find(x => x.ArticleName == cbDeleteArticle.Text).Price.ToString();

                txtDeleteProductCategory.Text = db.Articles.ToList().Find(x => x.ArticleName == cbDeleteArticle.Text).ArticleCategory;

                   this.DeletedArticleId = db.Articles.ToList().Find(x => x.ArticleName == cbDeleteArticle.Text).ArticleId;


            }
        }
        private void Delete()
        {
            DelArticle del = new DelArticle(this.DeletedArticleId);

            del.Delete();

        }

        private void cbDeleteArticle_Click(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void cbDeleteArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void cbDeleteArticle_TextChanged(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                this.Alert("Succes", Messages.enmType.Success);
            }
            catch (Exception)
            {
                this.Alert("Error", Messages.enmType.Error);
                throw;
            }
            FillComboBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void DeleteArticle_Load(object sender, EventArgs e)
        {

        }
    }
}
