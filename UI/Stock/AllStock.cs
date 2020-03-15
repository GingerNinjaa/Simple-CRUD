using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Stock
{
    public partial class AllStock : Form
    {
        public AllStock()
        {
            InitializeComponent();
            FillDataGrid();
        }
        AddStock addStock = new AddStock();
        DeleteArticle deleteArticle = new DeleteArticle();
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllStock_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteCategory addCategory = new DeleteCategory();
            addCategory.Show();
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            using (DbModel db = new DbModel())
            {
                AllStockDataGridView.DataSource = db.Articles.ToList();

                this.AllStockDataGridView.Columns[0].Visible = false; 
                this.AllStockDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.AllStockDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.AllStockDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.AllStockDataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                 
           // FillDataGrid();
        }

     

        private void btnDeleteArticle_Click(object sender, EventArgs e)
        {
            deleteArticle.Visible = !deleteArticle.Visible;
        }

        private void AllStockDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            addStock.Visible = !addStock.Visible;

            int id = Convert.ToInt32(this.AllStockDataGridView.CurrentRow.Cells[0].Value);

            using (DbModel db = new DbModel())
            {
                tblArticle model = new tblArticle();

                model = db.Articles.Where(x => x.ArticleId == id).FirstOrDefault();

                addStock.txtAddProductName.Text = model.ArticleName;
                addStock.txtAddProductDescription.Text = model.ArticleDescription;
                addStock.txtAddProductPrice.Text = model.Price.ToString();
                addStock.cbAddProductCategory.Text = model.ArticleCategory;

            }
        }
    }
}
