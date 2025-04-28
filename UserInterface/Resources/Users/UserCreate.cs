using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagement.FileSystem;
using Models;

namespace UserInterface.Resources.Users
{
    public partial class UserCreate : Form
    {
        private Admin _adminForm;

        public UserCreate(Admin adminForm)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _adminForm = adminForm;
        }

        private void UserCreate_Load(object sender, EventArgs e)
        {
            RoleInterface roleInterface = new RoleInterface();
            List<Role> roles = roleInterface.loadRoles();

            if (roles != null)
            {
                foreach (Role role in roles)
                {
                    comboBox_users_create.Items.Add(role);
                }
            }
        }

        private void comboBox_users_create_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_users_create_save_Click(object sender, EventArgs e)
        {
            User tempUser = new User();
            tempUser.name = textBox_users_create_name.Text;
            tempUser.prename = textBox_users_create_prename.Text;
            tempUser.email = textBox_users_create_email.Text;

            tempUser.phone = textBox_users_create_phone.Text;

            tempUser.setPassword(textBox_users_create_password.Text);

            tempUser.role = (Role)comboBox_users_create.SelectedItem;

            tempUser.created_at = DateTime.UtcNow.ToString("o");
            tempUser.updated_at = DateTime.UtcNow.ToString("o");

            UserInterface.globals.sessionSelectedUser = tempUser;
            DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
            userInterface.saveUser(tempUser);

            MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _adminForm.dataGridView_users_render(userInterface.loadUsers());
            this.Close();
        }
    }
}
