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
        }

        private void AllEmployee_Load(object sender, EventArgs e)
        {
        }
        public void AllEmployeeTableUpdate()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 4000;
            AllEmployeeTableUpdate();
        }
    }
}
