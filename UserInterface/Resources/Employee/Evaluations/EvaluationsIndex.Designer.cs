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
            dataGridView_local_user_evaluations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_local_user_evaluations).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_local_user_evaluations
            // 
            dataGridView_local_user_evaluations.AllowUserToAddRows = false;
            dataGridView_local_user_evaluations.AllowUserToDeleteRows = false;
            dataGridView_local_user_evaluations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_local_user_evaluations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_local_user_evaluations;
    }
}