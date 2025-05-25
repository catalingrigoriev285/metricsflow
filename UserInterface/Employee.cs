using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace UserInterface
{
    public partial class Employee : Form
    {
        private User _sessionUser;

        public Employee()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            _sessionUser = UserInterface.globals._sessionUser;

            updateWelcomeTitle();
        }

        public void updateWelcomeTitle()
        {
            _sessionUser = UserInterface.globals.sessionUser;
            label_welcome_back.Text = $"Welcome back, {_sessionUser.name} {_sessionUser.prename}!";
        }

        private void tabPage_employee_home_Click(object sender, EventArgs e)
        {

        }

        private void button_employee_edit_profile_Click(object sender, EventArgs e)
        {
            UserInterface.Resources.Employee.EmployeeEdit employeeEdit = new UserInterface.Resources.Employee.EmployeeEdit(this);
            employeeEdit.ShowDialog();
        }

        private void button_employee_evaluations_Click(object sender, EventArgs e)
        {
            Resources.Employee.Evaluations.EvaluationsIndex evaluationsIndex = new Resources.Employee.Evaluations.EvaluationsIndex();
            evaluationsIndex.ShowDialog();
        }
    }
}
