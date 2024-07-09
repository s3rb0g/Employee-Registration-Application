using EmployeeNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dgtData.Columns.Add("EmployeeID", "Employee ID");
            dgtData.Columns.Add("FirstName", "First Name");
            dgtData.Columns.Add("LastName", "Last Name");
            dgtData.Columns.Add("Position", "Position");

            dgtData.Columns["EmployeeID"].Width = 100;
            dgtData.Columns["FirstName"].Width = 150;
            dgtData.Columns["LastName"].Width = 150;
            dgtData.Columns["Position"].Width = 150;
        }

        private void fromEmployeeDatabase_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int studId = int.Parse(employeeId.Text);
            string fname = firstName.Text.ToString();
            string lname = lastName.Text.ToString();
            string pos = position.Text.ToString();

            Employee employee = new Employee(studId, fname, lname, pos);

            dgtData.Rows.Add(employee.EmployeeId, employee.FirstName, employee.LastName, employee.Position);

            employeeId.Clear();
            firstName.Clear();
            lastName.Clear();
            position.Clear();
        }
    }
}
