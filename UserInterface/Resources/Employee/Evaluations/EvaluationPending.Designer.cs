namespace UserInterface.Resources.Employee.Evaluations
{
    partial class EvaluationPending
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
            label_evaluation_title = new Label();
            label_evaluation_desc = new Label();
            flowLayoutPanel_questions = new FlowLayoutPanel();
            button_evaluation_submit = new Button();
            SuspendLayout();
            // 
            // label_evaluation_title
            // 
            label_evaluation_title.AutoSize = true;
            label_evaluation_title.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_evaluation_title.Location = new Point(12, 9);
            label_evaluation_title.Name = "label_evaluation_title";
            label_evaluation_title.Size = new Size(243, 31);
            label_evaluation_title.TabIndex = 0;
            label_evaluation_title.Text = "label_evaluation_title";
            // 
            // label_evaluation_desc
            // 
            label_evaluation_desc.AutoSize = true;
            label_evaluation_desc.Location = new Point(12, 49);
            label_evaluation_desc.Name = "label_evaluation_desc";
            label_evaluation_desc.Size = new Size(153, 20);
            label_evaluation_desc.TabIndex = 1;
            label_evaluation_desc.Text = "label_evaluation_desc";
            // 
            // flowLayoutPanel_questions
            // 
            flowLayoutPanel_questions.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_questions.Location = new Point(12, 91);
            flowLayoutPanel_questions.Name = "flowLayoutPanel_questions";
            flowLayoutPanel_questions.Size = new Size(724, 352);
            flowLayoutPanel_questions.TabIndex = 2;
            // 
            // button_evaluation_submit
            // 
            button_evaluation_submit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_evaluation_submit.Location = new Point(563, 14);
            button_evaluation_submit.Name = "button_evaluation_submit";
            button_evaluation_submit.Size = new Size(173, 55);
            button_evaluation_submit.TabIndex = 3;
            button_evaluation_submit.Text = "Submit Answers";
            button_evaluation_submit.UseVisualStyleBackColor = true;
            // 
            // EvaluationPending
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(button_evaluation_submit);
            Controls.Add(flowLayoutPanel_questions);
            Controls.Add(label_evaluation_desc);
            Controls.Add(label_evaluation_title);
            Name = "EvaluationPending";
            Text = "EvaluationPending";
            Load += EvaluationPending_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_evaluation_title;
        private Label label_evaluation_desc;
        private FlowLayoutPanel flowLayoutPanel_questions;
        private Button button_evaluation_submit;
    }
}