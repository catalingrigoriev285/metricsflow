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

            List<Models.User> users = new List<Models.User>();
            users.AddRange((new DatabaseManagement.FileSystem.UserInterface()).loadUsers());

            users = users.Where(u => u.id != UserInterface.globals.sessionUser.id).ToList();

            dataGridView_users.DataSource = users;

            DataGridViewButtonColumn buttonColumn_destroy = new DataGridViewButtonColumn();
            buttonColumn_destroy.Name = "Actions"; // Important!
            buttonColumn_destroy.HeaderText = "Actions";
            buttonColumn_destroy.Text = "Destroy";
            buttonColumn_destroy.UseColumnTextForButtonValue = true;
            dataGridView_users.Columns.Add(buttonColumn_destroy);

            dataGridView_users.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView_users.Columns["Actions"].Index)
                {
                    MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            };
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
