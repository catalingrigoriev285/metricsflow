namespace UserInterface.Resources.Roles
{
    partial class RoleCreate
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
            label_roles_create_name = new Label();
            textBox_roles_create_name = new TextBox();
            label_roles_create_desc = new Label();
            textBox_roles_create_desc = new TextBox();
            button_roles_edit_create = new Button();
            SuspendLayout();
            // 
            // label_roles_create_name
            // 
            label_roles_create_name.AutoSize = true;
            label_roles_create_name.Location = new Point(12, 9);
            label_roles_create_name.Name = "label_roles_create_name";
            label_roles_create_name.Size = new Size(49, 20);
            label_roles_create_name.TabIndex = 0;
            label_roles_create_name.Text = "Name";
            // 
            // textBox_roles_create_name
            // 
            textBox_roles_create_name.Location = new Point(12, 41);
            textBox_roles_create_name.Name = "textBox_roles_create_name";
            textBox_roles_create_name.PlaceholderText = "Name";
            textBox_roles_create_name.Size = new Size(553, 27);
            textBox_roles_create_name.TabIndex = 1;
            // 
            // label_roles_create_desc
            // 
            label_roles_create_desc.AutoSize = true;
            label_roles_create_desc.Location = new Point(12, 85);
            label_roles_create_desc.Name = "label_roles_create_desc";
            label_roles_create_desc.Size = new Size(85, 20);
            label_roles_create_desc.TabIndex = 2;
            label_roles_create_desc.Text = "Description";
            // 
            // textBox_roles_create_desc
            // 
            textBox_roles_create_desc.Location = new Point(12, 117);
            textBox_roles_create_desc.Multiline = true;
            textBox_roles_create_desc.Name = "textBox_roles_create_desc";
            textBox_roles_create_desc.PlaceholderText = "Description";
            textBox_roles_create_desc.Size = new Size(553, 166);
            textBox_roles_create_desc.TabIndex = 3;
            // 
            // button_roles_edit_create
            // 
            button_roles_edit_create.FlatStyle = FlatStyle.Flat;
            button_roles_edit_create.Location = new Point(9, 481);
            button_roles_edit_create.Name = "button_roles_edit_create";
            button_roles_edit_create.Size = new Size(556, 29);
            button_roles_edit_create.TabIndex = 15;
            button_roles_edit_create.Text = "Create";
            button_roles_edit_create.UseVisualStyleBackColor = true;
            button_roles_edit_create.Click += button_roles_edit_create_Click;
            // 
            // RoleCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 522);
            Controls.Add(button_roles_edit_create);
            Controls.Add(textBox_roles_create_desc);
            Controls.Add(label_roles_create_desc);
            Controls.Add(textBox_roles_create_name);
            Controls.Add(label_roles_create_name);
            Name = "RoleCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create a new role";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_roles_create_name;
        private TextBox textBox_roles_create_name;
        private TextBox textBox1;
        private Label label_roles_create_desc;
        private TextBox textBox_roles_create_desc;
        private Button button_roles_edit_create;
    }
}