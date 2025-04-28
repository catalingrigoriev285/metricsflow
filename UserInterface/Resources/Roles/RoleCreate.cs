using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Resources.Roles
{
    public partial class RoleCreate : Form
    {
        private Admin _adminForm;

        public RoleCreate(Admin adminForm)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _adminForm = adminForm;
        }

        private bool validate()
        {
            if (string.IsNullOrEmpty(textBox_roles_create_name.Text))
            {
                MessageBox.Show("Role name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBox_roles_create_desc.Text))
            {
                MessageBox.Show("Role description cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button_roles_edit_create_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                DatabaseManagement.FileSystem.RoleInterface roleInterface = new DatabaseManagement.FileSystem.RoleInterface();
                Models.Role role = new Models.Role();

                role.name = textBox_roles_create_name.Text;
                role.description = textBox_roles_create_desc.Text;

                role.created_at = DateTime.UtcNow.ToString("o");
                role.updated_at = DateTime.UtcNow.ToString("o");

                roleInterface.saveRole(role);

                MessageBox.Show("Role created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Models.Role> roles = new List<Models.Role>();
                roles.AddRange(roleInterface.loadRoles());
                _adminForm.dataGridView_roles_render(roles);

                this.Close();
            }
        }
    }
}
