namespace UserInterface.Resources.Evaluations
{
    partial class EvaluationEdit
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
            label_evaluation_edit_type = new Label();
            comboBox_evaluation_edit_type = new ComboBox();
            button_evaluation_edit_submit = new Button();
            label_evaluation_edit_user_id = new Label();
            comboBox_evaluation_edit_user = new ComboBox();
            textBox_evaluation_edit_description = new TextBox();
            label_evaluation_edit_description = new Label();
            textBox_evaluation_edit_title = new TextBox();
            label_evaluation_edit_title = new Label();
            SuspendLayout();
            // 
            // label_evaluation_edit_type
            // 
            label_evaluation_edit_type.AutoSize = true;
            label_evaluation_edit_type.Location = new Point(12, 240);
            label_evaluation_edit_type.Name = "label_evaluation_edit_type";
            label_evaluation_edit_type.Size = new Size(41, 20);
            label_evaluation_edit_type.TabIndex = 17;
            label_evaluation_edit_type.Text = "Type";
            // 
            // comboBox_evaluation_edit_type
            // 
            comboBox_evaluation_edit_type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_evaluation_edit_type.FormattingEnabled = true;
            comboBox_evaluation_edit_type.Location = new Point(12, 275);
            comboBox_evaluation_edit_type.Name = "comboBox_evaluation_edit_type";
            comboBox_evaluation_edit_type.Size = new Size(553, 28);
            comboBox_evaluation_edit_type.TabIndex = 16;
            // 
            // button_evaluation_edit_submit
            // 
            button_evaluation_edit_submit.Location = new Point(12, 483);
            button_evaluation_edit_submit.Name = "button_evaluation_edit_submit";
            button_evaluation_edit_submit.Size = new Size(553, 29);
            button_evaluation_edit_submit.TabIndex = 15;
            button_evaluation_edit_submit.Text = "Save";
            button_evaluation_edit_submit.UseVisualStyleBackColor = true;
            button_evaluation_edit_submit.Click += button_evaluation_edit_submit_Click;
            // 
            // label_evaluation_edit_user_id
            // 
            label_evaluation_edit_user_id.AutoSize = true;
            label_evaluation_edit_user_id.Location = new Point(12, 162);
            label_evaluation_edit_user_id.Name = "label_evaluation_edit_user_id";
            label_evaluation_edit_user_id.Size = new Size(82, 20);
            label_evaluation_edit_user_id.TabIndex = 14;
            label_evaluation_edit_user_id.Text = "Select User";
            // 
            // comboBox_evaluation_edit_user
            // 
            comboBox_evaluation_edit_user.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_evaluation_edit_user.FormattingEnabled = true;
            comboBox_evaluation_edit_user.Location = new Point(12, 197);
            comboBox_evaluation_edit_user.Name = "comboBox_evaluation_edit_user";
            comboBox_evaluation_edit_user.Size = new Size(553, 28);
            comboBox_evaluation_edit_user.TabIndex = 13;
            // 
            // textBox_evaluation_edit_description
            // 
            textBox_evaluation_edit_description.Location = new Point(12, 118);
            textBox_evaluation_edit_description.Name = "textBox_evaluation_edit_description";
            textBox_evaluation_edit_description.PlaceholderText = "Description";
            textBox_evaluation_edit_description.Size = new Size(553, 27);
            textBox_evaluation_edit_description.TabIndex = 12;
            // 
            // label_evaluation_edit_description
            // 
            label_evaluation_edit_description.AutoSize = true;
            label_evaluation_edit_description.Location = new Point(12, 85);
            label_evaluation_edit_description.Name = "label_evaluation_edit_description";
            label_evaluation_edit_description.Size = new Size(85, 20);
            label_evaluation_edit_description.TabIndex = 11;
            label_evaluation_edit_description.Text = "Description";
            // 
            // textBox_evaluation_edit_title
            // 
            textBox_evaluation_edit_title.Location = new Point(12, 44);
            textBox_evaluation_edit_title.Name = "textBox_evaluation_edit_title";
            textBox_evaluation_edit_title.PlaceholderText = "Title";
            textBox_evaluation_edit_title.Size = new Size(553, 27);
            textBox_evaluation_edit_title.TabIndex = 10;
            // 
            // label_evaluation_edit_title
            // 
            label_evaluation_edit_title.AutoSize = true;
            label_evaluation_edit_title.Location = new Point(12, 11);
            label_evaluation_edit_title.Name = "label_evaluation_edit_title";
            label_evaluation_edit_title.Size = new Size(38, 20);
            label_evaluation_edit_title.TabIndex = 9;
            label_evaluation_edit_title.Text = "Title";
            // 
            // EvaluationEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 522);
            Controls.Add(label_evaluation_edit_type);
            Controls.Add(comboBox_evaluation_edit_type);
            Controls.Add(button_evaluation_edit_submit);
            Controls.Add(label_evaluation_edit_user_id);
            Controls.Add(comboBox_evaluation_edit_user);
            Controls.Add(textBox_evaluation_edit_description);
            Controls.Add(label_evaluation_edit_description);
            Controls.Add(textBox_evaluation_edit_title);
            Controls.Add(label_evaluation_edit_title);
            Name = "EvaluationEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EvaluationEdit";
            Load += EvaluationEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_evaluation_edit_type;
        private ComboBox comboBox_evaluation_edit_type;
        private Button button_evaluation_edit_submit;
        private Label label_evaluation_edit_user_id;
        private ComboBox comboBox_evaluation_edit_user;
        private TextBox textBox_evaluation_edit_description;
        private Label label_evaluation_edit_description;
        private TextBox textBox_evaluation_edit_title;
        private Label label_evaluation_edit_title;
    }
}