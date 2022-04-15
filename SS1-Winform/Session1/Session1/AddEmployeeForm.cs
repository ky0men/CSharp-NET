using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class AddEmployeeForm : Form
    {
        private Form1 form1;
        List<Employee> empList;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        public AddEmployeeForm(Form1 form1, List<Employee> empList)
        {
            InitializeComponent();
            this.form1 = form1;
            this.empList = empList;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.form1.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(txtName.Text, Convert.ToInt32(txtAge.Text), txtAddress.Text, Convert.ToInt32(txtYearOfExperience.Text), txtQualification.Text, txtPhone.Text, txtEmail.Text);
            this.empList.Add(emp);
            this.form1.Show();
            form1.Refresh();

            this.Close();
        }
    }
}
