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

namespace UserInterface.Resources.Employee
{
    public partial class EmployeeEdit : Form
    {
        private UserInterface.Employee _employeeInstance;

        public EmployeeEdit(UserInterface.Employee employeeInstance)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            this._employeeInstance = employeeInstance;

            this.Text = "Profile editing";
        }

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
            Models.User user = userInterface.getUserById(UserInterface.globals.sessionUser.id);

            if (user != null)
            {
                textBox_users_edit_name.Text = user.name;
                textBox_users_edit_prename.Text = user.prename;
                textBox_users_edit_email.Text = user.email;
                textBox_users_edit_phone.Text = user.phone;
            }
        }

        private void button_users_edit_save_Click(object sender, EventArgs e)
        {
            User currentUser = UserInterface.globals.sessionUser;
            string name = textBox_users_edit_name.Text;
            string prename = textBox_users_edit_prename.Text;
            string email = textBox_users_edit_email.Text;
            string phone = textBox_users_edit_phone.Text;

            DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
            Models.User user = userInterface.getUserById(currentUser.id);

            if (user != null)
            {
                user.name = name;
                user.prename = prename;
                user.email = email;
                user.phone = phone;

                if (!string.IsNullOrEmpty(textBox_users_edit_password.Text))
                {
                    user.setPassword(textBox_users_edit_password.Text, false);
                }

                user.updated_at = DateTime.UtcNow.ToString("o");

                userInterface.updateUser(user);
            }
            else
            {
                MessageBox.Show("Error updating your profile!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _employeeInstance.updateWelcomeTitle();

            MessageBox.Show("Your profile successfuly updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
