namespace UserInterface.Resources.Evaluations.Questions
{
    partial class QuestionsCreate
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
            button_questions_create = new Button();
            textBox_questions_create_desc = new TextBox();
            label_questions_create_desc = new Label();
            textBox_questions_create_title = new TextBox();
            label_questions_create_name = new Label();
            SuspendLayout();
            // 
            // button_questions_create
            // 
            button_questions_create.FlatStyle = FlatStyle.Flat;
            button_questions_create.Location = new Point(10, 483);
            button_questions_create.Name = "button_questions_create";
            button_questions_create.Size = new Size(556, 29);
            button_questions_create.TabIndex = 20;
            button_questions_create.Text = "Create";
            button_questions_create.UseVisualStyleBackColor = true;
            button_questions_create.Click += button_questions_create_Click;
            // 
            // textBox_questions_create_desc
            // 
            textBox_questions_create_desc.Location = new Point(13, 119);
            textBox_questions_create_desc.Multiline = true;
            textBox_questions_create_desc.Name = "textBox_questions_create_desc";
            textBox_questions_create_desc.PlaceholderText = "Description";
            textBox_questions_create_desc.Size = new Size(553, 166);
            textBox_questions_create_desc.TabIndex = 19;
            // 
            // label_questions_create_desc
            // 
            label_questions_create_desc.AutoSize = true;
            label_questions_create_desc.Location = new Point(13, 87);
            label_questions_create_desc.Name = "label_questions_create_desc";
            label_questions_create_desc.Size = new Size(85, 20);
            label_questions_create_desc.TabIndex = 18;
            label_questions_create_desc.Text = "Description";
            // 
            // textBox_questions_create_title
            // 
            textBox_questions_create_title.Location = new Point(13, 43);
            textBox_questions_create_title.Name = "textBox_questions_create_title";
            textBox_questions_create_title.PlaceholderText = "Title";
            textBox_questions_create_title.Size = new Size(553, 27);
            textBox_questions_create_title.TabIndex = 17;
            // 
            // label_questions_create_name
            // 
            label_questions_create_name.AutoSize = true;
            label_questions_create_name.Location = new Point(13, 11);
            label_questions_create_name.Name = "label_questions_create_name";
            label_questions_create_name.Size = new Size(38, 20);
            label_questions_create_name.TabIndex = 16;
            label_questions_create_name.Text = "Title";
            // 
            // QuestionsCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 522);
            Controls.Add(button_questions_create);
            Controls.Add(textBox_questions_create_desc);
            Controls.Add(label_questions_create_desc);
            Controls.Add(textBox_questions_create_title);
            Controls.Add(label_questions_create_name);
            Name = "QuestionsCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create a new question";
            Load += QuestionsCreate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_questions_create;
        private TextBox textBox_questions_create_desc;
        private Label label_questions_create_desc;
        private TextBox textBox_questions_create_title;
        private Label label_questions_create_name;
    }
}