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

namespace UserInterface.Resources.Users
{
    public partial class UserEdit : Form
    {
        private Admin _adminForm;

        public UserEdit(Admin adminForm)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _adminForm = adminForm;
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {
            if (UserInterface.globals.sessionSelectedUser == null)
            {
                MessageBox.Show("No user selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
                Models.User user = userInterface.getUserById(UserInterface.globals.sessionSelectedUser.id);

                if (user != null)
                {
                    textBox_users_edit_name.Text = user.name;
                    textBox_users_edit_prename.Text = user.prename;
                    textBox_users_edit_email.Text = user.email;
                    textBox_users_edit_phone.Text = user.phone;

                    comboBox_users_edit.Items.Clear();
                    List<Models.Role> roles = new List<Models.Role>();
                    roles.AddRange((new DatabaseManagement.FileSystem.RoleInterface()).loadRoles());
                    foreach (Models.Role role in roles)
                    {
                        comboBox_users_edit.Items.Add(role.name);
                    }

                    comboBox_users_edit.SelectedIndex = comboBox_users_edit.Items.IndexOf(user.getRole());
                }
            }
        }

        private void button_users_edit_save_Click(object sender, EventArgs e)
        {
            User currentUser = UserInterface.globals.sessionSelectedUser;
            string name = textBox_users_edit_name.Text;
            string prename = textBox_users_edit_prename.Text;
            string email = textBox_users_edit_email.Text;
            string phone = textBox_users_edit_phone.Text;
            string roleName = comboBox_users_edit.SelectedItem.ToString();

            DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
            Models.User user = userInterface.getUserById(currentUser.id);
            Models.Role role = (new DatabaseManagement.FileSystem.RoleInterface()).getRoleByName(roleName);

            if (user != null && role != null)
            {
                user.name = name;
                user.prename = prename;
                user.email = email;
                user.phone = phone;
                user.role = role;

                if(!string.IsNullOrEmpty(textBox_users_edit_password.Text))
                {
                    user.setPassword(textBox_users_edit_password.Text, false);
                }

                user.updated_at = DateTime.UtcNow.ToString("o");

                userInterface.updateUser(user);
            }
            else
            {
                MessageBox.Show("Error updating user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _adminForm.dataGridView_users_render((new DatabaseManagement.FileSystem.UserInterface()).loadUsers());

            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
