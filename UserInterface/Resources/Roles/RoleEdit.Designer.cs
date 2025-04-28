namespace UserInterface.Resources.Roles
{
    partial class RoleEdit
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
            button_roles_edit_save = new Button();
            textBox_roles_edit_desc = new TextBox();
            label_roles_edit_desc = new Label();
            textBox_roles_edit_name = new TextBox();
            label_roles_edit_name = new Label();
            SuspendLayout();
            // 
            // button_roles_edit_save
            // 
            button_roles_edit_save.FlatStyle = FlatStyle.Flat;
            button_roles_edit_save.Location = new Point(10, 483);
            button_roles_edit_save.Name = "button_roles_edit_save";
            button_roles_edit_save.Size = new Size(556, 29);
            button_roles_edit_save.TabIndex = 20;
            button_roles_edit_save.Text = "Save";
            button_roles_edit_save.UseVisualStyleBackColor = true;
            button_roles_edit_save.Click += button_roles_edit_save_Click;
            // 
            // textBox_roles_edit_desc
            // 
            textBox_roles_edit_desc.Location = new Point(13, 119);
            textBox_roles_edit_desc.Multiline = true;
            textBox_roles_edit_desc.Name = "textBox_roles_edit_desc";
            textBox_roles_edit_desc.PlaceholderText = "Description";
            textBox_roles_edit_desc.Size = new Size(553, 166);
            textBox_roles_edit_desc.TabIndex = 19;
            // 
            // label_roles_edit_desc
            // 
            label_roles_edit_desc.AutoSize = true;
            label_roles_edit_desc.Location = new Point(13, 87);
            label_roles_edit_desc.Name = "label_roles_edit_desc";
            label_roles_edit_desc.Size = new Size(85, 20);
            label_roles_edit_desc.TabIndex = 18;
            label_roles_edit_desc.Text = "Description";
            // 
            // textBox_roles_edit_name
            // 
            textBox_roles_edit_name.Location = new Point(13, 43);
            textBox_roles_edit_name.Name = "textBox_roles_edit_name";
            textBox_roles_edit_name.PlaceholderText = "Name";
            textBox_roles_edit_name.Size = new Size(553, 27);
            textBox_roles_edit_name.TabIndex = 17;
            // 
            // label_roles_edit_name
            // 
            label_roles_edit_name.AutoSize = true;
            label_roles_edit_name.Location = new Point(13, 11);
            label_roles_edit_name.Name = "label_roles_edit_name";
            label_roles_edit_name.Size = new Size(49, 20);
            label_roles_edit_name.TabIndex = 16;
            label_roles_edit_name.Text = "Name";
            // 
            // RoleEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 522);
            Controls.Add(button_roles_edit_save);
            Controls.Add(textBox_roles_edit_desc);
            Controls.Add(label_roles_edit_desc);
            Controls.Add(textBox_roles_edit_name);
            Controls.Add(label_roles_edit_name);
            Name = "RoleEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit role";
            Load += RoleEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_roles_edit_save;
        private TextBox textBox_roles_edit_desc;
        private Label label_roles_edit_desc;
        private TextBox textBox_roles_edit_name;
        private Label label_roles_edit_name;
    }
}