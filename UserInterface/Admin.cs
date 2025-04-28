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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            dataGridView_users_render();

            DataGridViewButtonColumn buttonColumn_edit = new DataGridViewButtonColumn();
            buttonColumn_edit.Name = "Edit";
            buttonColumn_edit.HeaderText = "";
            buttonColumn_edit.Text = "Edit";
            buttonColumn_edit.UseColumnTextForButtonValue = true;
            dataGridView_users.Columns.Add(buttonColumn_edit);

            DataGridViewButtonColumn buttonColumn_destroy = new DataGridViewButtonColumn();
            buttonColumn_destroy.Name = "Destroy";
            buttonColumn_destroy.HeaderText = "";
            buttonColumn_destroy.Text = "Destroy";
            buttonColumn_destroy.UseColumnTextForButtonValue = true;
            dataGridView_users.Columns.Add(buttonColumn_destroy);

            dataGridView_users.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dataGridView_users.Columns["Destroy"].Index)
                    {
                        var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirm == DialogResult.Yes)
                        {
                            int userId = (int)dataGridView_users.Rows[e.RowIndex].Cells[0].Value;
                            Models.User user = new Models.User();
                            user.setID(userId);
                            DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
                            userInterface.destroyUser(user);
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dataGridView_users_render();
                        }
                    }
                    else if (e.ColumnIndex == dataGridView_users.Columns["Edit"].Index)
                    {
                        int userId = (int)dataGridView_users.Rows[e.RowIndex].Cells[0].Value;
                        MessageBox.Show($"Edit functionality for User ID: {userId} is not implemented yet.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            };
        }

        private void dataGridView_users_render()
        {
            List<Models.User> users = new List<Models.User>();
            users.AddRange((new DatabaseManagement.FileSystem.UserInterface()).loadUsers());

            users = users.Where(u => u.id != UserInterface.globals.sessionUser.id).ToList();

            dataGridView_users.DataSource = null;
            dataGridView_users.DataSource = users;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterface.globals.sessionUser = null;
            this.Hide();

            UserInterface.Auth auth = new UserInterface.Auth();
            auth.ShowDialog();
            this.Close();
        }
    }
}
