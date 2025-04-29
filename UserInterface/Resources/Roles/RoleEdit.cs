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

namespace UserInterface.Resources.Roles
{
    public partial class RoleEdit : Form
    {
        private Admin _adminForm;

        public RoleEdit(Admin adminForm)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _adminForm = adminForm;
        }

        private bool validate()
        {
            if (string.IsNullOrEmpty(textBox_roles_edit_name.Text))
            {
                MessageBox.Show("Role name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBox_roles_edit_desc.Text))
            {
                MessageBox.Show("Role description cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            List<Role> roles = new List<Role>();
            roles.AddRange((new DatabaseManagement.FileSystem.RoleInterface()).loadRoles());

            foreach (Role role in roles)
            {
                if (role.name.Equals(textBox_roles_edit_name.Text) && role.id != UserInterface.globals.sessionSelectedRole.id)
                {
                    MessageBox.Show("Role name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void RoleEdit_Load(object sender, EventArgs e)
        {
            if (UserInterface.globals.sessionSelectedRole == null)
            {
                MessageBox.Show("No role selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                this.Text = "Editing role [ #" + UserInterface.globals.sessionSelectedRole.id + " ]";

                DatabaseManagement.FileSystem.RoleInterface roleInterface = new DatabaseManagement.FileSystem.RoleInterface();
                Models.Role role = roleInterface.getRoleById(UserInterface.globals.sessionSelectedRole.id);
                if (role != null)
                {
                    textBox_roles_edit_name.Text = role.name;
                    textBox_roles_edit_desc.Text = role.description;
                }
            }
        }

        private void button_roles_edit_save_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Role currentRole = UserInterface.globals.sessionSelectedRole;
                string name = textBox_roles_edit_name.Text;
                string description = textBox_roles_edit_desc.Text;

                DatabaseManagement.FileSystem.RoleInterface roleInterface = new DatabaseManagement.FileSystem.RoleInterface();
                Models.Role role = roleInterface.getRoleById(currentRole.id);

                if (role != null)
                {
                    role.id = currentRole.id;
                    role.name = name;
                    role.description = description;

                    role.updated_at = DateTime.UtcNow.ToString("o");

                    roleInterface.updateRole(role);
                }

                _adminForm.dataGridView_roles_render(roleInterface.loadRoles());
                MessageBox.Show("Role updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
