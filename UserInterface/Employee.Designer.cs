namespace UserInterface
{
    partial class Employee
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
            label_welcome_back = new Label();
            button_employee_evaluations = new Button();
            button_employee_edit_profile = new Button();
            SuspendLayout();
            // 
            // label_welcome_back
            // 
            label_welcome_back.AutoSize = true;
            label_welcome_back.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_welcome_back.Location = new Point(36, 39);
            label_welcome_back.Name = "label_welcome_back";
            label_welcome_back.Size = new Size(286, 41);
            label_welcome_back.TabIndex = 0;
            label_welcome_back.Text = "label_welcome_back";
            // 
            // button_employee_evaluations
            // 
            button_employee_evaluations.Location = new Point(120, 123);
            button_employee_evaluations.Name = "button_employee_evaluations";
            button_employee_evaluations.Size = new Size(444, 43);
            button_employee_evaluations.TabIndex = 1;
            button_employee_evaluations.Text = "My Evaluations";
            button_employee_evaluations.UseVisualStyleBackColor = true;
            button_employee_evaluations.Click += button_employee_evaluations_Click;
            // 
            // button_employee_edit_profile
            // 
            button_employee_edit_profile.Location = new Point(120, 190);
            button_employee_edit_profile.Name = "button_employee_edit_profile";
            button_employee_edit_profile.Size = new Size(444, 43);
            button_employee_edit_profile.TabIndex = 2;
            button_employee_edit_profile.Text = "Edit my profile";
            button_employee_edit_profile.UseVisualStyleBackColor = true;
            button_employee_edit_profile.Click += button_employee_edit_profile_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 301);
            Controls.Add(button_employee_edit_profile);
            Controls.Add(button_employee_evaluations);
            Controls.Add(label_welcome_back);
            Name = "Employee";
            Text = "Employee Dashboard";
            Load += Employee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_welcome_back;
        private Button button_employee_evaluations;
        private Button button_employee_edit_profile;
        private Label label1;
    }
}