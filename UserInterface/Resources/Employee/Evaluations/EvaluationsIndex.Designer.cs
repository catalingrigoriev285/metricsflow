namespace UserInterface.Resources.Employee.Evaluations
{
    partial class EvaluationsIndex
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
            dataGridView_local_user_evaluations = new DataGridView();
            evaluationBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            useridDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_local_user_evaluations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)evaluationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_local_user_evaluations
            // 
            dataGridView_local_user_evaluations.AllowUserToAddRows = false;
            dataGridView_local_user_evaluations.AllowUserToDeleteRows = false;
            dataGridView_local_user_evaluations.AutoGenerateColumns = false;
            dataGridView_local_user_evaluations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_local_user_evaluations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_local_user_evaluations.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, useridDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, createdatDataGridViewTextBoxColumn, updatedatDataGridViewTextBoxColumn });
            dataGridView_local_user_evaluations.DataSource = evaluationBindingSource;
            dataGridView_local_user_evaluations.Dock = DockStyle.Fill;
            dataGridView_local_user_evaluations.Location = new Point(0, 0);
            dataGridView_local_user_evaluations.Name = "dataGridView_local_user_evaluations";
            dataGridView_local_user_evaluations.ReadOnly = true;
            dataGridView_local_user_evaluations.RowHeadersVisible = false;
            dataGridView_local_user_evaluations.RowHeadersWidth = 51;
            dataGridView_local_user_evaluations.Size = new Size(800, 450);
            dataGridView_local_user_evaluations.TabIndex = 0;
            dataGridView_local_user_evaluations.CellContentClick += dataGridView1_CellContentClick;
            // 
            // evaluationBindingSource
            // 
            evaluationBindingSource.DataSource = typeof(Models.Evaluation);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            titleDataGridViewTextBoxColumn.HeaderText = "title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            typeDataGridViewTextBoxColumn.HeaderText = "type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // EvaluationsIndex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_local_user_evaluations);
            Name = "EvaluationsIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EvaluationsIndex";
            WindowState = FormWindowState.Maximized;
            Load += EvaluationsIndex_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_local_user_evaluations).EndInit();
            ((System.ComponentModel.ISupportInitialize)evaluationBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_local_user_evaluations;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedatDataGridViewTextBoxColumn;
        private BindingSource evaluationBindingSource;
    }
}