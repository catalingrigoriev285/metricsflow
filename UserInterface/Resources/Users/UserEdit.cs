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
                }
            }
        }

        private void button_users_edit_save_Click(object sender, EventArgs e)
        {
            
        }
    }
}
