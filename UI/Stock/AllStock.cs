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

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllStock_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory();
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
                 
            FillDataGrid();
        }
    }
}
