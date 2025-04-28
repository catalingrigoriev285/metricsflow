namespace UserInterface.Resources.Evaluations
{
    partial class EvaluationCreate
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
            label_evaluation_create_title = new Label();
            textBox_evaluation_create_title = new TextBox();
            textBox_evaluation_create_description = new TextBox();
            label_evaluation_create_description = new Label();
            comboBox_evaluation_create_user = new ComboBox();
            label_evaluation_create_user_id = new Label();
            button_evaluation_create_submit = new Button();
            label_evaluation_create_type = new Label();
            comboBox_evaluation_create_type = new ComboBox();
            SuspendLayout();
            // 
            // label_evaluation_create_title
            // 
            label_evaluation_create_title.AutoSize = true;
            label_evaluation_create_title.Location = new Point(12, 9);
            label_evaluation_create_title.Name = "label_evaluation_create_title";
            label_evaluation_create_title.Size = new Size(38, 20);
            label_evaluation_create_title.TabIndex = 0;
            label_evaluation_create_title.Text = "Title";
            // 
            // textBox_evaluation_create_title
            // 
            textBox_evaluation_create_title.Location = new Point(12, 42);
            textBox_evaluation_create_title.Name = "textBox_evaluation_create_title";
            textBox_evaluation_create_title.PlaceholderText = "Title";
            textBox_evaluation_create_title.Size = new Size(553, 27);
            textBox_evaluation_create_title.TabIndex = 1;
            // 
            // textBox_evaluation_create_description
            // 
            textBox_evaluation_create_description.Location = new Point(12, 116);
            textBox_evaluation_create_description.Name = "textBox_evaluation_create_description";
            textBox_evaluation_create_description.PlaceholderText = "Title";
            textBox_evaluation_create_description.Size = new Size(553, 27);
            textBox_evaluation_create_description.TabIndex = 3;
            // 
            // label_evaluation_create_description
            // 
            label_evaluation_create_description.AutoSize = true;
            label_evaluation_create_description.Location = new Point(12, 83);
            label_evaluation_create_description.Name = "label_evaluation_create_description";
            label_evaluation_create_description.Size = new Size(85, 20);
            label_evaluation_create_description.TabIndex = 2;
            label_evaluation_create_description.Text = "Description";
            // 
            // comboBox_evaluation_create_user
            // 
            comboBox_evaluation_create_user.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_evaluation_create_user.FormattingEnabled = true;
            comboBox_evaluation_create_user.Location = new Point(12, 195);
            comboBox_evaluation_create_user.Name = "comboBox_evaluation_create_user";
            comboBox_evaluation_create_user.Size = new Size(553, 28);
            comboBox_evaluation_create_user.TabIndex = 4;
            // 
            // label_evaluation_create_user_id
            // 
            label_evaluation_create_user_id.AutoSize = true;
            label_evaluation_create_user_id.Location = new Point(12, 160);
            label_evaluation_create_user_id.Name = "label_evaluation_create_user_id";
            label_evaluation_create_user_id.Size = new Size(82, 20);
            label_evaluation_create_user_id.TabIndex = 5;
            label_evaluation_create_user_id.Text = "Select User";
            // 
            // button_evaluation_create_submit
            // 
            button_evaluation_create_submit.Location = new Point(12, 481);
            button_evaluation_create_submit.Name = "button_evaluation_create_submit";
            button_evaluation_create_submit.Size = new Size(553, 29);
            button_evaluation_create_submit.TabIndex = 6;
            button_evaluation_create_submit.Text = "Create a new evaluation";
            button_evaluation_create_submit.UseVisualStyleBackColor = true;
            button_evaluation_create_submit.Click += button_evaluation_create_submit_Click;
            // 
            // label_evaluation_create_type
            // 
            label_evaluation_create_type.AutoSize = true;
            label_evaluation_create_type.Location = new Point(12, 238);
            label_evaluation_create_type.Name = "label_evaluation_create_type";
            label_evaluation_create_type.Size = new Size(41, 20);
            label_evaluation_create_type.TabIndex = 8;
            label_evaluation_create_type.Text = "Type";
            // 
            // comboBox_evaluation_create_type
            // 
            comboBox_evaluation_create_type.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_evaluation_create_type.FormattingEnabled = true;
            comboBox_evaluation_create_type.Location = new Point(12, 273);
            comboBox_evaluation_create_type.Name = "comboBox_evaluation_create_type";
            comboBox_evaluation_create_type.Size = new Size(553, 28);
            comboBox_evaluation_create_type.TabIndex = 7;
            // 
            // EvaluationCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 522);
            Controls.Add(label_evaluation_create_type);
            Controls.Add(comboBox_evaluation_create_type);
            Controls.Add(button_evaluation_create_submit);
            Controls.Add(label_evaluation_create_user_id);
            Controls.Add(comboBox_evaluation_create_user);
            Controls.Add(textBox_evaluation_create_description);
            Controls.Add(label_evaluation_create_description);
            Controls.Add(textBox_evaluation_create_title);
            Controls.Add(label_evaluation_create_title);
            Name = "EvaluationCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EvaluationCreate";
            Load += EvaluationCreate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_evaluation_create_title;
        private TextBox textBox_evaluation_create_title;
        private TextBox textBox_evaluation_create_description;
        private Label label_evaluation_create_description;
        private ComboBox comboBox_evaluation_create_user;
        private Label label_evaluation_create_user_id;
        private Button button_evaluation_create_submit;
        private Label label_evaluation_create_type;
        private ComboBox comboBox_evaluation_create_type;
    }
}