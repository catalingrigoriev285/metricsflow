namespace UserInterface.Resources.Evaluations.Questions.Answers
{
    partial class AnswersCreate
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
            textBox_answers_create_value = new TextBox();
            label_answers_create_value = new Label();
            label_answers_create_validation = new Label();
            radioButton_answers_create_true = new RadioButton();
            radioButton_answers_create_false = new RadioButton();
            SuspendLayout();
            // 
            // button_questions_create
            // 
            button_questions_create.FlatStyle = FlatStyle.Flat;
            button_questions_create.Location = new Point(10, 483);
            button_questions_create.Name = "button_questions_create";
            button_questions_create.Size = new Size(556, 29);
            button_questions_create.TabIndex = 23;
            button_questions_create.Text = "Create";
            button_questions_create.UseVisualStyleBackColor = true;
            button_questions_create.Click += button_questions_create_Click;
            // 
            // textBox_answers_create_value
            // 
            textBox_answers_create_value.Location = new Point(13, 43);
            textBox_answers_create_value.Name = "textBox_answers_create_value";
            textBox_answers_create_value.PlaceholderText = "Value";
            textBox_answers_create_value.Size = new Size(553, 27);
            textBox_answers_create_value.TabIndex = 22;
            // 
            // label_answers_create_value
            // 
            label_answers_create_value.AutoSize = true;
            label_answers_create_value.Location = new Point(13, 11);
            label_answers_create_value.Name = "label_answers_create_value";
            label_answers_create_value.Size = new Size(46, 20);
            label_answers_create_value.TabIndex = 21;
            label_answers_create_value.Text = "Value";
            // 
            // label_answers_create_validation
            // 
            label_answers_create_validation.AutoSize = true;
            label_answers_create_validation.Location = new Point(13, 84);
            label_answers_create_validation.Name = "label_answers_create_validation";
            label_answers_create_validation.Size = new Size(77, 20);
            label_answers_create_validation.TabIndex = 24;
            label_answers_create_validation.Text = "Validation";
            // 
            // radioButton_answers_create_true
            // 
            radioButton_answers_create_true.AutoSize = true;
            radioButton_answers_create_true.Location = new Point(13, 116);
            radioButton_answers_create_true.Name = "radioButton_answers_create_true";
            radioButton_answers_create_true.Size = new Size(59, 24);
            radioButton_answers_create_true.TabIndex = 25;
            radioButton_answers_create_true.TabStop = true;
            radioButton_answers_create_true.Text = "True";
            radioButton_answers_create_true.UseVisualStyleBackColor = true;
            // 
            // radioButton_answers_create_false
            // 
            radioButton_answers_create_false.AutoSize = true;
            radioButton_answers_create_false.Location = new Point(78, 116);
            radioButton_answers_create_false.Name = "radioButton_answers_create_false";
            radioButton_answers_create_false.Size = new Size(63, 24);
            radioButton_answers_create_false.TabIndex = 26;
            radioButton_answers_create_false.TabStop = true;
            radioButton_answers_create_false.Text = "False";
            radioButton_answers_create_false.UseVisualStyleBackColor = true;
            // 
            // AnswersCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 522);
            Controls.Add(radioButton_answers_create_false);
            Controls.Add(radioButton_answers_create_true);
            Controls.Add(label_answers_create_validation);
            Controls.Add(button_questions_create);
            Controls.Add(textBox_answers_create_value);
            Controls.Add(label_answers_create_value);
            Name = "AnswersCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnswersCreate";
            Load += AnswersCreate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_questions_create;
        private TextBox textBox_answers_create_value;
        private Label label_answers_create_value;
        private Label label_answers_create_validation;
        private RadioButton radioButton_answers_create_true;
        private RadioButton radioButton_answers_create_false;
    }
}