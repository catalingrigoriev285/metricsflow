namespace UserInterface
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button_users_create = new Button();
            button_users_search = new Button();
            textBox_users_search = new TextBox();
            dataGridView_users = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            tabPage2 = new TabPage();
            button_roles_refresh = new Button();
            button_roles_destroyAll = new Button();
            button_roles_edit_add = new Button();
            dataGridView_roles = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            updatedatDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            roleBindingSource = new BindingSource(components);
            button_roles_search = new Button();
            textBox_roles_search = new TextBox();
            tabPage3 = new TabPage();
            button_evaluation_create = new Button();
            button_evaluation_search = new Button();
            textBox_evaluation_search = new TextBox();
            dataGridView_evaluations = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            user_id = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            evaluationBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            accountToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            button_users_generate = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_users).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_roles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_evaluations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)evaluationBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(782, 448);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button_users_generate);
            tabPage1.Controls.Add(button_users_create);
            tabPage1.Controls.Add(button_users_search);
            tabPage1.Controls.Add(textBox_users_search);
            tabPage1.Controls.Add(dataGridView_users);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(774, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button_users_create
            // 
            button_users_create.Location = new Point(284, 6);
            button_users_create.Name = "button_users_create";
            button_users_create.Size = new Size(128, 29);
            button_users_create.TabIndex = 3;
            button_users_create.Text = "Add a new user";
            button_users_create.UseVisualStyleBackColor = true;
            button_users_create.Click += button_users_create_Click;
            // 
            // button_users_search
            // 
            button_users_search.Location = new Point(184, 6);
            button_users_search.Name = "button_users_search";
            button_users_search.Size = new Size(94, 29);
            button_users_search.TabIndex = 2;
            button_users_search.Text = "Search";
            button_users_search.UseVisualStyleBackColor = true;
            button_users_search.Click += button_users_search_Click;
            // 
            // textBox_users_search
            // 
            textBox_users_search.Location = new Point(6, 8);
            textBox_users_search.Name = "textBox_users_search";
            textBox_users_search.PlaceholderText = "Search an user...";
            textBox_users_search.Size = new Size(172, 27);
            textBox_users_search.TabIndex = 1;
            // 
            // dataGridView_users
            // 
            dataGridView_users.AllowUserToAddRows = false;
            dataGridView_users.AllowUserToDeleteRows = false;
            dataGridView_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_users.AutoGenerateColumns = false;
            dataGridView_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_users.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, prenameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, createdatDataGridViewTextBoxColumn, updatedatDataGridViewTextBoxColumn });
            dataGridView_users.DataSource = userBindingSource;
            dataGridView_users.Location = new Point(3, 41);
            dataGridView_users.Name = "dataGridView_users";
            dataGridView_users.ReadOnly = true;
            dataGridView_users.RowHeadersVisible = false;
            dataGridView_users.RowHeadersWidth = 51;
            dataGridView_users.Size = new Size(768, 371);
            dataGridView_users.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenameDataGridViewTextBoxColumn
            // 
            prenameDataGridViewTextBoxColumn.DataPropertyName = "prename";
            prenameDataGridViewTextBoxColumn.HeaderText = "prename";
            prenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            prenameDataGridViewTextBoxColumn.Name = "prenameDataGridViewTextBoxColumn";
            prenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            emailDataGridViewTextBoxColumn.HeaderText = "email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            roleDataGridViewTextBoxColumn.HeaderText = "role";
            roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            updatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            updatedatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            userBindingSource.CurrentChanged += userBindingSource_CurrentChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button_roles_refresh);
            tabPage2.Controls.Add(button_roles_destroyAll);
            tabPage2.Controls.Add(button_roles_edit_add);
            tabPage2.Controls.Add(dataGridView_roles);
            tabPage2.Controls.Add(button_roles_search);
            tabPage2.Controls.Add(textBox_roles_search);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(774, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Roles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_roles_refresh
            // 
            button_roles_refresh.Location = new Point(283, 6);
            button_roles_refresh.Name = "button_roles_refresh";
            button_roles_refresh.Size = new Size(132, 29);
            button_roles_refresh.TabIndex = 8;
            button_roles_refresh.Text = "Refresh";
            button_roles_refresh.UseVisualStyleBackColor = true;
            button_roles_refresh.Click += button_roles_refresh_Click;
            // 
            // button_roles_destroyAll
            // 
            button_roles_destroyAll.Location = new Point(559, 5);
            button_roles_destroyAll.Name = "button_roles_destroyAll";
            button_roles_destroyAll.Size = new Size(135, 29);
            button_roles_destroyAll.TabIndex = 7;
            button_roles_destroyAll.Text = "Destroy all roles";
            button_roles_destroyAll.UseVisualStyleBackColor = true;
            button_roles_destroyAll.Click += button_roles_destroyAll_Click;
            // 
            // button_roles_edit_add
            // 
            button_roles_edit_add.Location = new Point(421, 6);
            button_roles_edit_add.Name = "button_roles_edit_add";
            button_roles_edit_add.Size = new Size(132, 29);
            button_roles_edit_add.TabIndex = 6;
            button_roles_edit_add.Text = "Add a new role";
            button_roles_edit_add.UseVisualStyleBackColor = true;
            button_roles_edit_add.Click += button_roles_edit_add_Click;
            // 
            // dataGridView_roles
            // 
            dataGridView_roles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_roles.AutoGenerateColumns = false;
            dataGridView_roles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_roles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_roles.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn, createdatDataGridViewTextBoxColumn1, updatedatDataGridViewTextBoxColumn1 });
            dataGridView_roles.DataSource = roleBindingSource;
            dataGridView_roles.Location = new Point(6, 41);
            dataGridView_roles.Name = "dataGridView_roles";
            dataGridView_roles.RowHeadersVisible = false;
            dataGridView_roles.RowHeadersWidth = 51;
            dataGridView_roles.Size = new Size(760, 366);
            dataGridView_roles.TabIndex = 5;
            dataGridView_roles.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            idDataGridViewTextBoxColumn1.HeaderText = "id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn1.HeaderText = "name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn1
            // 
            createdatDataGridViewTextBoxColumn1.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn1.HeaderText = "created_at";
            createdatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            createdatDataGridViewTextBoxColumn1.Name = "createdatDataGridViewTextBoxColumn1";
            // 
            // updatedatDataGridViewTextBoxColumn1
            // 
            updatedatDataGridViewTextBoxColumn1.DataPropertyName = "updated_at";
            updatedatDataGridViewTextBoxColumn1.HeaderText = "updated_at";
            updatedatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            updatedatDataGridViewTextBoxColumn1.Name = "updatedatDataGridViewTextBoxColumn1";
            // 
            // roleBindingSource
            // 
            roleBindingSource.DataSource = typeof(Models.Role);
            // 
            // button_roles_search
            // 
            button_roles_search.Location = new Point(183, 6);
            button_roles_search.Name = "button_roles_search";
            button_roles_search.Size = new Size(94, 29);
            button_roles_search.TabIndex = 4;
            button_roles_search.Text = "Search";
            button_roles_search.UseVisualStyleBackColor = true;
            button_roles_search.Click += button_roles_search_Click;
            // 
            // textBox_roles_search
            // 
            textBox_roles_search.Location = new Point(5, 8);
            textBox_roles_search.Name = "textBox_roles_search";
            textBox_roles_search.PlaceholderText = "Search a role...";
            textBox_roles_search.Size = new Size(172, 27);
            textBox_roles_search.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button_evaluation_create);
            tabPage3.Controls.Add(button_evaluation_search);
            tabPage3.Controls.Add(textBox_evaluation_search);
            tabPage3.Controls.Add(dataGridView_evaluations);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(774, 415);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Evaluations";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button_evaluation_create
            // 
            button_evaluation_create.Location = new Point(284, 4);
            button_evaluation_create.Name = "button_evaluation_create";
            button_evaluation_create.Size = new Size(181, 29);
            button_evaluation_create.TabIndex = 7;
            button_evaluation_create.Text = "Create a new evaluation";
            button_evaluation_create.UseVisualStyleBackColor = true;
            button_evaluation_create.Click += button_evaluation_create_Click;
            // 
            // button_evaluation_search
            // 
            button_evaluation_search.Location = new Point(184, 4);
            button_evaluation_search.Name = "button_evaluation_search";
            button_evaluation_search.Size = new Size(94, 29);
            button_evaluation_search.TabIndex = 6;
            button_evaluation_search.Text = "Search";
            button_evaluation_search.UseVisualStyleBackColor = true;
            button_evaluation_search.Click += button_evaluation_search_Click;
            // 
            // textBox_evaluation_search
            // 
            textBox_evaluation_search.Location = new Point(6, 6);
            textBox_evaluation_search.Name = "textBox_evaluation_search";
            textBox_evaluation_search.PlaceholderText = "Search an user...";
            textBox_evaluation_search.Size = new Size(172, 27);
            textBox_evaluation_search.TabIndex = 5;
            // 
            // dataGridView_evaluations
            // 
            dataGridView_evaluations.AllowUserToAddRows = false;
            dataGridView_evaluations.AllowUserToDeleteRows = false;
            dataGridView_evaluations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_evaluations.AutoGenerateColumns = false;
            dataGridView_evaluations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_evaluations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_evaluations.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, title, description, type, user_id, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dataGridView_evaluations.DataSource = evaluationBindingSource;
            dataGridView_evaluations.Location = new Point(3, 39);
            dataGridView_evaluations.Name = "dataGridView_evaluations";
            dataGridView_evaluations.ReadOnly = true;
            dataGridView_evaluations.RowHeadersVisible = false;
            dataGridView_evaluations.RowHeadersWidth = 51;
            dataGridView_evaluations.Size = new Size(768, 371);
            dataGridView_evaluations.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "id";
            dataGridViewTextBoxColumn1.HeaderText = "id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // title
            // 
            title.DataPropertyName = "title";
            title.HeaderText = "title";
            title.MinimumWidth = 6;
            title.Name = "title";
            title.ReadOnly = true;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.HeaderText = "description";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // type
            // 
            type.DataPropertyName = "type";
            type.HeaderText = "type";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // user_id
            // 
            user_id.DataPropertyName = "user_id";
            user_id.HeaderText = "user_id";
            user_id.MinimumWidth = 6;
            user_id.Name = "user_id";
            user_id.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "created_at";
            dataGridViewTextBoxColumn7.HeaderText = "created_at";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "updated_at";
            dataGridViewTextBoxColumn8.HeaderText = "updated_at";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // evaluationBindingSource
            // 
            evaluationBindingSource.DataSource = typeof(Models.Evaluation);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { signOutToolStripMenuItem });
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(77, 24);
            accountToolStripMenuItem.Text = "Account";
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(149, 26);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // button_users_generate
            // 
            button_users_generate.Location = new Point(418, 6);
            button_users_generate.Name = "button_users_generate";
            button_users_generate.Size = new Size(184, 29);
            button_users_generate.TabIndex = 4;
            button_users_generate.Text = "Generate a random user";
            button_users_generate.UseVisualStyleBackColor = true;
            button_users_generate.Click += button_users_generate_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 476);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_users).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_roles).EndInit();
            ((System.ComponentModel.ISupportInitialize)roleBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_evaluations).EndInit();
            ((System.ComponentModel.ISupportInitialize)evaluationBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private TabPage tabPage1;
        private DataGridView dataGridView_users;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private Button button_users_search;
        private TextBox textBox_users_search;
        private DataGridView dataGridView_roles;
        private Button button_roles_search;
        private TextBox textBox_roles_search;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn1;
        private BindingSource roleBindingSource;
        private Button button_roles_edit_add;
        private Button button_users_create;
        private Button button_roles_destroyAll;
        private Button button_roles_refresh;
        private Button button_evaluation_create;
        private Button button_evaluation_search;
        private TextBox textBox_evaluation_search;
        private DataGridView dataGridView_evaluations;
        private BindingSource evaluationBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn user_id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Button button_users_generate;
    }
}