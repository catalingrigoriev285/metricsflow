namespace UserInterface.Resources.Evaluations.Questions
{
    partial class QuestionsEdit
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
            button_questions_edit = new Button();
            textBox_questions_edit_desc = new TextBox();
            label_questions_edit_desc = new Label();
            textBox_questions_edit_title = new TextBox();
            label_questions_edit_name = new Label();
            SuspendLayout();
            // 
            // button_questions_edit
            // 
            button_questions_edit.FlatStyle = FlatStyle.Flat;
            button_questions_edit.Location = new Point(10, 483);
            button_questions_edit.Name = "button_questions_edit";
            button_questions_edit.Size = new Size(556, 29);
            button_questions_edit.TabIndex = 25;
            button_questions_edit.Text = "Save";
            button_questions_edit.UseVisualStyleBackColor = true;
            button_questions_edit.Click += button_questions_edit_Click;
            // 
            // textBox_questions_edit_desc
            // 
            textBox_questions_edit_desc.Location = new Point(13, 119);
            textBox_questions_edit_desc.Multiline = true;
            textBox_questions_edit_desc.Name = "textBox_questions_edit_desc";
            textBox_questions_edit_desc.PlaceholderText = "Description";
            textBox_questions_edit_desc.Size = new Size(553, 166);
            textBox_questions_edit_desc.TabIndex = 24;
            // 
            // label_questions_edit_desc
            // 
            label_questions_edit_desc.AutoSize = true;
            label_questions_edit_desc.Location = new Point(13, 87);
            label_questions_edit_desc.Name = "label_questions_edit_desc";
            label_questions_edit_desc.Size = new Size(85, 20);
            label_questions_edit_desc.TabIndex = 23;
            label_questions_edit_desc.Text = "Description";
            // 
            // textBox_questions_edit_title
            // 
            textBox_questions_edit_title.Location = new Point(13, 43);
            textBox_questions_edit_title.Name = "textBox_questions_edit_title";
            textBox_questions_edit_title.PlaceholderText = "Title";
            textBox_questions_edit_title.Size = new Size(553, 27);
            textBox_questions_edit_title.TabIndex = 22;
            // 
            // label_questions_edit_name
            // 
            label_questions_edit_name.AutoSize = true;
            label_questions_edit_name.Location = new Point(13, 11);
            label_questions_edit_name.Name = "label_questions_edit_name";
            label_questions_edit_name.Size = new Size(38, 20);
            label_questions_edit_name.TabIndex = 21;
            label_questions_edit_name.Text = "Title";
            // 
            // QuestionsEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 522);
            Controls.Add(button_questions_edit);
            Controls.Add(textBox_questions_edit_desc);
            Controls.Add(label_questions_edit_desc);
            Controls.Add(textBox_questions_edit_title);
            Controls.Add(label_questions_edit_name);
            Name = "QuestionsEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit a question";
            Load += QuestionsEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_questions_edit;
        private TextBox textBox_questions_edit_desc;
        private Label label_questions_edit_desc;
        private TextBox textBox_questions_edit_title;
        private Label label_questions_edit_name;
    }
}