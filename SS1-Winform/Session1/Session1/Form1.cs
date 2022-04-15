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
    public partial class Form1 : Form
    {
        List<Employee> employee = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            listViewEmployee.Items.Clear();
            foreach (Employee e in employee)
            {
                ListViewItem item = new ListViewItem(e.Id.ToString());
                item.SubItems.Add(e.Name.ToString());
                item.SubItems.Add(e.Age.ToString());
                item.SubItems.Add(e.Address.ToString());
                item.SubItems.Add(e.YearOfExperience.ToString());
                item.SubItems.Add(e.Qualification.ToString());
                item.SubItems.Add(e.Phone.ToString());
                item.SubItems.Add(e.Email.ToString());
                listViewEmployee.Items.Add(item);
            }
        }


        private void listViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm(this, employee);
            this.Hide();
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
