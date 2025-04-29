namespace UserInterface.Resources.Evaluations.Questions
{
    partial class QuestionsIndex
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
            dataGridView_questions = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            questionBindingSource = new BindingSource(components);
            textBox_questions_search = new TextBox();
            button_questions_search = new Button();
            button_questions_create = new Button();
            button_questions_destroy_all = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_questions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_questions
            // 
            dataGridView_questions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_questions.AutoGenerateColumns = false;
            dataGridView_questions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_questions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_questions.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, createdatDataGridViewTextBoxColumn, updatedatDataGridViewTextBoxColumn });
            dataGridView_questions.DataSource = questionBindingSource;
            dataGridView_questions.Location = new Point(0, 51);
            dataGridView_questions.Name = "dataGridView_questions";
            dataGridView_questions.RowHeadersVisible = false;
            dataGridView_questions.RowHeadersWidth = 51;
            dataGridView_questions.Size = new Size(1184, 423);
            dataGridView_questions.TabIndex = 0;
            dataGridView_questions.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            titleDataGridViewTextBoxColumn.HeaderText = "title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn.HeaderText = "created_at";
            createdatDataGridViewTextBoxColumn.MinimumWidth = 6;
            createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // updatedatDataGridViewTextBoxColumn
            // 
            updatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at";
            updatedatDataGridViewTextBoxColumn.HeaderText = "updated_at";
            updatedatDataGridViewTextBoxColumn.MinimumWidth = 6;
            updatedatDataGridViewTextBoxColumn.Name = "updatedatDataGridViewTextBoxColumn";
            // 
            // questionBindingSource
            // 
            questionBindingSource.DataSource = typeof(Models.Question);
            // 
            // textBox_questions_search
            // 
            textBox_questions_search.Location = new Point(12, 12);
            textBox_questions_search.Name = "textBox_questions_search";
            textBox_questions_search.PlaceholderText = "Search a question...";
            textBox_questions_search.Size = new Size(209, 27);
            textBox_questions_search.TabIndex = 1;
            // 
            // button_questions_search
            // 
            button_questions_search.Location = new Point(227, 11);
            button_questions_search.Name = "button_questions_search";
            button_questions_search.Size = new Size(94, 29);
            button_questions_search.TabIndex = 2;
            button_questions_search.Text = "Search";
            button_questions_search.UseVisualStyleBackColor = true;
            button_questions_search.Click += button_questions_search_Click;
            // 
            // button_questions_create
            // 
            button_questions_create.Location = new Point(327, 11);
            button_questions_create.Name = "button_questions_create";
            button_questions_create.Size = new Size(171, 29);
            button_questions_create.TabIndex = 3;
            button_questions_create.Text = "Create a new question";
            button_questions_create.UseVisualStyleBackColor = true;
            button_questions_create.Click += button_questions_create_Click;
            // 
            // button_questions_destroy_all
            // 
            button_questions_destroy_all.Location = new Point(504, 11);
            button_questions_destroy_all.Name = "button_questions_destroy_all";
            button_questions_destroy_all.Size = new Size(171, 29);
            button_questions_destroy_all.TabIndex = 4;
            button_questions_destroy_all.Text = "Destroy all questions";
            button_questions_destroy_all.UseVisualStyleBackColor = true;
            button_questions_destroy_all.Click += button_questions_destroy_all_Click;
            // 
            // QuestionsIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 475);
            Controls.Add(button_questions_destroy_all);
            Controls.Add(button_questions_create);
            Controls.Add(button_questions_search);
            Controls.Add(textBox_questions_search);
            Controls.Add(dataGridView_questions);
            Name = "QuestionsIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questions List";
            Load += QuestionsIndex_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_questions).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_questions;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private BindingSource questionBindingSource;
        private TextBox textBox_questions_search;
        private Button button_questions_search;
        private Button button_questions_create;
        private Button button_questions_destroy_all;
    }
}