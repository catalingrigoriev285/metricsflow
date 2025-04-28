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
            dataGridView_users_render(users);

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

                            List<Models.User> users = new List<Models.User>();
                            users.AddRange((new DatabaseManagement.FileSystem.UserInterface()).loadUsers());

                            dataGridView_users_render(users);
                        }
                    }
                    else if (e.ColumnIndex == dataGridView_users.Columns["Edit"].Index)
                    {
                        int userId = (int)dataGridView_users.Rows[e.RowIndex].Cells[0].Value;
                        Models.User user = new Models.User();
                        user.setID(userId);

                        UserInterface.globals.sessionSelectedUser = user;
                        UserInterface.Resources.Users.UserEdit userEdit = new UserInterface.Resources.Users.UserEdit(this);
                        userEdit.ShowDialog();
                    }
                }
            };

            List<Models.Role> roles = new List<Models.Role>();
            roles.AddRange((new DatabaseManagement.FileSystem.RoleInterface()).loadRoles());
            dataGridView_roles_render(roles);

            DataGridViewButtonColumn buttonColumn_edit_role = new DataGridViewButtonColumn();
            buttonColumn_edit_role.Name = "Edit";
            buttonColumn_edit_role.HeaderText = "";
            buttonColumn_edit_role.Text = "Edit";
            buttonColumn_edit_role.UseColumnTextForButtonValue = true;
            dataGridView_roles.Columns.Add(buttonColumn_edit_role);

            DataGridViewButtonColumn buttonColumn_destroy_role = new DataGridViewButtonColumn();
            buttonColumn_destroy_role.Name = "Destroy";
            buttonColumn_destroy_role.HeaderText = "";
            buttonColumn_destroy_role.Text = "Destroy";
            buttonColumn_destroy_role.UseColumnTextForButtonValue = true;
            dataGridView_roles.Columns.Add(buttonColumn_destroy_role);

            dataGridView_roles.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dataGridView_roles.Columns["Destroy"].Index)
                    {
                        var confirm = MessageBox.Show("Are you sure you want to delete this role?", "Delete Role", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            int roleId = (int)dataGridView_roles.Rows[e.RowIndex].Cells[0].Value;
                            Models.Role role = new Models.Role();
                            role.setID(roleId);
                            DatabaseManagement.FileSystem.RoleInterface roleInterface = new DatabaseManagement.FileSystem.RoleInterface();
                            roleInterface.destroyRole(role);
                            MessageBox.Show("Role deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            List<Models.Role> roles = new List<Models.Role>();
                            roles.AddRange((new DatabaseManagement.FileSystem.RoleInterface()).loadRoles());
                            dataGridView_roles_render(roles);
                        }
                    }
                    else if (e.ColumnIndex == dataGridView_roles.Columns["Edit"].Index)
                    {
                        int roleId = (int)dataGridView_roles.Rows[e.RowIndex].Cells[0].Value;
                        Models.Role role = new Models.Role();
                        role.setID(roleId);
                        UserInterface.globals.sessionSelectedRole = role;
                        UserInterface.Resources.Roles.RoleEdit roleEdit = new UserInterface.Resources.Roles.RoleEdit(this);
                        roleEdit.ShowDialog();
                    }
                }
            };

            List<Models.Evaluation> evaluations = new List<Models.Evaluation>();
            evaluations.AddRange((new DatabaseManagement.FileSystem.EvaluationInterface()).loadEvaluations());

            dataGridView_evaluations_render(evaluations);

            DataGridViewButtonColumn buttonColumn_edit_evaluation = new DataGridViewButtonColumn();
            buttonColumn_edit_evaluation.Name = "Edit";
            buttonColumn_edit_evaluation.HeaderText = "";
            buttonColumn_edit_evaluation.Text = "Edit";
            buttonColumn_edit_evaluation.UseColumnTextForButtonValue = true;
            dataGridView_evaluations.Columns.Add(buttonColumn_edit_evaluation);

            DataGridViewButtonColumn buttonColumn_destroy_evaluation = new DataGridViewButtonColumn();
            buttonColumn_destroy_evaluation.Name = "Destroy";
            buttonColumn_destroy_evaluation.HeaderText = "";
            buttonColumn_destroy_evaluation.Text = "Destroy";
            buttonColumn_destroy_evaluation.UseColumnTextForButtonValue = true;
            dataGridView_evaluations.Columns.Add(buttonColumn_destroy_evaluation);

            dataGridView_evaluations.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dataGridView_evaluations.Columns["Destroy"].Index)
                    {
                        var confirm = MessageBox.Show("Are you sure you want to delete this evaluation?", "Delete Evaluation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            int evaluationId = (int)dataGridView_evaluations.Rows[e.RowIndex].Cells[0].Value;
                            Models.Evaluation evaluation = new Models.Evaluation();
                            evaluation.setID(evaluationId);
                            DatabaseManagement.FileSystem.EvaluationInterface evaluationInterface = new DatabaseManagement.FileSystem.EvaluationInterface();
                            evaluationInterface.destroyEvaluation(evaluation);
                            MessageBox.Show("Evaluation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            List<Models.Evaluation> evaluations = new List<Models.Evaluation>();
                            evaluations.AddRange((new DatabaseManagement.FileSystem.EvaluationInterface()).loadEvaluations());
                            dataGridView_evaluations_render(evaluations);
                        }
                    }
                    else if (e.ColumnIndex == dataGridView_evaluations.Columns["Edit"].Index)
                    {
                        int evaluationId = (int)dataGridView_evaluations.Rows[e.RowIndex].Cells[0].Value;
                        Models.Evaluation evaluation = new Models.Evaluation();
                        evaluation.setID(evaluationId);
                        UserInterface.globals.sessionSelectedEvaluation = evaluation;
                        UserInterface.Resources.Evaluations.EvaluationEdit evaluationEdit = new UserInterface.Resources.Evaluations.EvaluationEdit(this);
                        evaluationEdit.ShowDialog();
                    }
                }
            };
        }

        public void dataGridView_users_render(List<Models.User> users)
        {
            users = users.Where(u => u.id != UserInterface.globals.sessionUser.id).ToList();

            dataGridView_users.DataSource = null;
            dataGridView_users.DataSource = users;
        }

        public void dataGridView_roles_render(List<Models.Role> roles)
        {
            dataGridView_roles.DataSource = null;
            dataGridView_roles.DataSource = roles;
        }

        public void dataGridView_evaluations_render(List<Models.Evaluation> evaluations)
        {
            dataGridView_evaluations.DataSource = null;
            dataGridView_evaluations.DataSource = evaluations;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterface.globals.sessionUser = null;
            this.Hide();

            UserInterface.Auth auth = new UserInterface.Auth();
            auth.ShowDialog();
            this.Close();
        }

        private void button_users_search_Click(object sender, EventArgs e)
        {
            List<Models.User> users = new List<Models.User>();
            users.AddRange((new DatabaseManagement.FileSystem.UserInterface()).loadUsers());
            string searchText = textBox_users_search.Text.ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                dataGridView_users_render(users);
            }
            else
            {
                var filteredUsers = users.Where(u => u.name.ToLower().Contains(searchText) || u.prename.ToLower().Contains(searchText) || u.email.ToLower().Contains(searchText)).ToList();
                dataGridView_users_render(filteredUsers);
            }
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_roles_edit_add_Click(object sender, EventArgs e)
        {
            UserInterface.Resources.Roles.RoleCreate roleCreate = new UserInterface.Resources.Roles.RoleCreate(this);
            roleCreate.ShowDialog(this);
        }

        private void button_roles_search_Click(object sender, EventArgs e)
        {
            List<Models.Role> roles = new List<Models.Role>();
            roles.AddRange((new DatabaseManagement.FileSystem.RoleInterface()).loadRoles());
            string searchText = textBox_roles_search.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridView_roles_render(roles);
            }
            else
            {
                var filteredRoles = roles.Where(r => r.name.ToLower().Contains(searchText) || r.description.ToLower().Contains(searchText)).ToList();
                dataGridView_roles_render(filteredRoles);
            }
        }

        private void button_users_create_Click(object sender, EventArgs e)
        {
            UserInterface.Resources.Users.UserCreate userCreate = new UserInterface.Resources.Users.UserCreate(this);
            userCreate.ShowDialog(this);
        }

        private void button_roles_destroyAll_Click(object sender, EventArgs e)
        {
            List<Models.Role> roles = new List<Models.Role>();
            roles.AddRange((new DatabaseManagement.FileSystem.RoleInterface()).loadRoles());

            if (roles.Count == 0)
            {
                MessageBox.Show("No roles to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete all roles?", "Delete All Roles", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                foreach (Models.Role role in roles)
                {
                    DatabaseManagement.FileSystem.RoleInterface roleInterface = new DatabaseManagement.FileSystem.RoleInterface();
                    roleInterface.destroyRole(role);
                }

                dataGridView_roles_render((new DatabaseManagement.FileSystem.RoleInterface()).loadRoles());
                MessageBox.Show("All roles deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_roles_refresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roles refreshed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_evaluation_create_Click(object sender, EventArgs e)
        {
            UserInterface.Resources.Evaluations.EvaluationCreate evaluationCreate = new UserInterface.Resources.Evaluations.EvaluationCreate(this);
            evaluationCreate.ShowDialog(this);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button_evaluation_search_Click(object sender, EventArgs e)
        {
            List<Models.Evaluation> evaluations = new List<Models.Evaluation>();
            evaluations.AddRange((new DatabaseManagement.FileSystem.EvaluationInterface()).loadEvaluations());

            string searchText = textBox_evaluation_search.Text.ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridView_evaluations_render(evaluations);
            }
            else
            {
                var filteredEvaluations = evaluations.Where(e => e.title.ToLower().Contains(searchText) || e.description.ToLower().Contains(searchText)).ToList();
                dataGridView_evaluations_render(filteredEvaluations);
            }
        }
    }
}
