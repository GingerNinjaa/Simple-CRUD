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

namespace UI.Administration
{
    public partial class AllEmployee : Form
    {
        public AllEmployee()
        {
            InitializeComponent();
            FillDataGrid();
        }

        AddEmployee addEmployee = new AddEmployee();

        private void AllEmployee_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }
       
        public void FillDataGrid()
        {
            using (DbModel db = new DbModel())
            {
                dataGridView1.DataSource = db.Users.Where(x => x.Position != "GM").ToList();

                //this.dataGridView1.Columns[0].Visible = false;

                this.dataGridView1.Columns[0].Visible = false;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[2].Visible = false;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addEmployee.Visible = !addEmployee.Visible;

            int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            using (DbModel db = new DbModel())
            {
                tblUser model = new tblUser();

                model = db.Users.Where(x => x.UserId == id).FirstOrDefault();
                addEmployee.UserId = model.UserId;
                addEmployee.txtAdminAddFirstName.Text = model.FirstName;
                addEmployee.txtAdminAddLastName.Text = model.LastName;
                addEmployee.txtAdminAddUserName.Text = model.UserName;
                addEmployee.txtAdminAddEmail.Text = model.Email;
                
     
            }
        }
    }
}
