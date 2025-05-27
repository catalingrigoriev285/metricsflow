namespace UserInterface.Resources.Evaluations.Questions.Answers
{
    partial class AnswersIndex
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
            button_questions_search = new Button();
            textBox_answers_search = new TextBox();
            dataGridView_answers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_answers).BeginInit();
            SuspendLayout();
            // 
            // button_questions_create
            // 
            button_questions_create.Location = new Point(327, 11);
            button_questions_create.Name = "button_questions_create";
            button_questions_create.Size = new Size(171, 29);
            button_questions_create.TabIndex = 7;
            button_questions_create.Text = "Create a new answer";
            button_questions_create.UseVisualStyleBackColor = true;
            button_questions_create.Click += button_questions_create_Click;
            // 
            // button_questions_search
            // 
            button_questions_search.Location = new Point(227, 11);
            button_questions_search.Name = "button_questions_search";
            button_questions_search.Size = new Size(94, 29);
            button_questions_search.TabIndex = 6;
            button_questions_search.Text = "Search";
            button_questions_search.UseVisualStyleBackColor = true;
            button_questions_search.Click += button_questions_search_Click;
            // 
            // textBox_answers_search
            // 
            textBox_answers_search.Location = new Point(12, 12);
            textBox_answers_search.Name = "textBox_answers_search";
            textBox_answers_search.PlaceholderText = "Search an answer...";
            textBox_answers_search.Size = new Size(209, 27);
            textBox_answers_search.TabIndex = 5;
            // 
            // dataGridView_answers
            // 
            dataGridView_answers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_answers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_answers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_answers.Location = new Point(0, 55);
            dataGridView_answers.Name = "dataGridView_answers";
            dataGridView_answers.RowHeadersVisible = false;
            dataGridView_answers.RowHeadersWidth = 51;
            dataGridView_answers.Size = new Size(1107, 448);
            dataGridView_answers.TabIndex = 9;
            // 
            // AnswersIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 450);
            Controls.Add(dataGridView_answers);
            Controls.Add(button_questions_create);
            Controls.Add(button_questions_search);
            Controls.Add(textBox_answers_search);
            Name = "AnswersIndex";
            Text = "Answers List";
            Load += AnswersIndex_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_answers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_questions_create;
        private Button button_questions_search;
        private TextBox textBox_answers_search;
        private DataGridView dataGridView_answers;
    }
}