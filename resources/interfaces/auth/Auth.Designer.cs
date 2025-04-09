namespace metricsflow.resources.interfaces.auth
{
    partial class Auth
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button_auth_signin = new Button();
            textBox_auth_password = new TextBox();
            label2 = new Label();
            textBox_auth_email = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            textBox_reg_repeat_password = new TextBox();
            label_reg_repeat_password = new Label();
            button_reg_signup = new Button();
            textBox_reg_password = new TextBox();
            label_reg_password = new Label();
            textBox_reg_email = new TextBox();
            label_reg_email = new Label();
            tabPage3 = new TabPage();
            textBox_reg_name = new TextBox();
            label_reg_name = new Label();
            textBox_reg_prename = new TextBox();
            label_reg_prename = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(650, 459);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(181, 209, 255);
            tabPage1.Controls.Add(button_auth_signin);
            tabPage1.Controls.Add(textBox_auth_password);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox_auth_email);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(642, 426);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sign In";
            // 
            // button_auth_signin
            // 
            button_auth_signin.BackColor = Color.White;
            button_auth_signin.Cursor = Cursors.Hand;
            button_auth_signin.FlatStyle = FlatStyle.Flat;
            button_auth_signin.Location = new Point(19, 183);
            button_auth_signin.Name = "button_auth_signin";
            button_auth_signin.Size = new Size(585, 51);
            button_auth_signin.TabIndex = 4;
            button_auth_signin.Text = "Sign In";
            button_auth_signin.UseVisualStyleBackColor = false;
            // 
            // textBox_auth_password
            // 
            textBox_auth_password.Location = new Point(19, 136);
            textBox_auth_password.Name = "textBox_auth_password";
            textBox_auth_password.PlaceholderText = "Enter your password";
            textBox_auth_password.Size = new Size(585, 27);
            textBox_auth_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(19, 101);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // textBox_auth_email
            // 
            textBox_auth_email.Location = new Point(19, 56);
            textBox_auth_email.Name = "textBox_auth_email";
            textBox_auth_email.PlaceholderText = "Enter your email";
            textBox_auth_email.Size = new Size(585, 27);
            textBox_auth_email.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(181, 209, 255);
            tabPage2.Controls.Add(textBox_reg_prename);
            tabPage2.Controls.Add(label_reg_prename);
            tabPage2.Controls.Add(textBox_reg_name);
            tabPage2.Controls.Add(label_reg_name);
            tabPage2.Controls.Add(textBox_reg_repeat_password);
            tabPage2.Controls.Add(label_reg_repeat_password);
            tabPage2.Controls.Add(button_reg_signup);
            tabPage2.Controls.Add(textBox_reg_password);
            tabPage2.Controls.Add(label_reg_password);
            tabPage2.Controls.Add(textBox_reg_email);
            tabPage2.Controls.Add(label_reg_email);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(642, 426);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sign Up";
            // 
            // textBox_reg_repeat_password
            // 
            textBox_reg_repeat_password.Location = new Point(19, 287);
            textBox_reg_repeat_password.Name = "textBox_reg_repeat_password";
            textBox_reg_repeat_password.PlaceholderText = "Repeat your password";
            textBox_reg_repeat_password.Size = new Size(585, 27);
            textBox_reg_repeat_password.TabIndex = 11;
            // 
            // label_reg_repeat_password
            // 
            label_reg_repeat_password.AutoSize = true;
            label_reg_repeat_password.Font = new Font("Segoe UI", 10F);
            label_reg_repeat_password.Location = new Point(19, 261);
            label_reg_repeat_password.Name = "label_reg_repeat_password";
            label_reg_repeat_password.Size = new Size(178, 23);
            label_reg_repeat_password.TabIndex = 10;
            label_reg_repeat_password.Text = "Repeat your password";
            // 
            // button_reg_signup
            // 
            button_reg_signup.BackColor = Color.White;
            button_reg_signup.Cursor = Cursors.Hand;
            button_reg_signup.FlatStyle = FlatStyle.Flat;
            button_reg_signup.Location = new Point(19, 331);
            button_reg_signup.Name = "button_reg_signup";
            button_reg_signup.Size = new Size(585, 51);
            button_reg_signup.TabIndex = 9;
            button_reg_signup.Text = "Sign Up";
            button_reg_signup.UseVisualStyleBackColor = false;
            button_reg_signup.Click += button_reg_signup_Click;
            // 
            // textBox_reg_password
            // 
            textBox_reg_password.Location = new Point(19, 214);
            textBox_reg_password.Name = "textBox_reg_password";
            textBox_reg_password.PlaceholderText = "Enter your password";
            textBox_reg_password.Size = new Size(585, 27);
            textBox_reg_password.TabIndex = 8;
            // 
            // label_reg_password
            // 
            label_reg_password.AutoSize = true;
            label_reg_password.Font = new Font("Segoe UI", 10F);
            label_reg_password.Location = new Point(19, 188);
            label_reg_password.Name = "label_reg_password";
            label_reg_password.Size = new Size(81, 23);
            label_reg_password.TabIndex = 7;
            label_reg_password.Text = "Password";
            // 
            // textBox_reg_email
            // 
            textBox_reg_email.Location = new Point(19, 56);
            textBox_reg_email.Name = "textBox_reg_email";
            textBox_reg_email.PlaceholderText = "Enter your email";
            textBox_reg_email.Size = new Size(585, 27);
            textBox_reg_email.TabIndex = 6;
            // 
            // label_reg_email
            // 
            label_reg_email.AutoSize = true;
            label_reg_email.Font = new Font("Segoe UI", 10F);
            label_reg_email.Location = new Point(19, 21);
            label_reg_email.Name = "label_reg_email";
            label_reg_email.Size = new Size(51, 23);
            label_reg_email.TabIndex = 5;
            label_reg_email.Text = "Email";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(181, 209, 255);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(642, 426);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "About";
            // 
            // textBox_reg_name
            // 
            textBox_reg_name.Location = new Point(19, 134);
            textBox_reg_name.Name = "textBox_reg_name";
            textBox_reg_name.PlaceholderText = "Enter your name";
            textBox_reg_name.Size = new Size(281, 27);
            textBox_reg_name.TabIndex = 13;
            // 
            // label_reg_name
            // 
            label_reg_name.AutoSize = true;
            label_reg_name.Font = new Font("Segoe UI", 10F);
            label_reg_name.Location = new Point(19, 99);
            label_reg_name.Name = "label_reg_name";
            label_reg_name.Size = new Size(56, 23);
            label_reg_name.TabIndex = 12;
            label_reg_name.Text = "Name";
            // 
            // textBox_reg_prename
            // 
            textBox_reg_prename.Location = new Point(306, 134);
            textBox_reg_prename.Name = "textBox_reg_prename";
            textBox_reg_prename.PlaceholderText = "Enter your prename";
            textBox_reg_prename.Size = new Size(298, 27);
            textBox_reg_prename.TabIndex = 15;
            // 
            // label_reg_prename
            // 
            label_reg_prename.AutoSize = true;
            label_reg_prename.Font = new Font("Segoe UI", 10F);
            label_reg_prename.Location = new Point(306, 99);
            label_reg_prename.Name = "label_reg_prename";
            label_reg_prename.Size = new Size(78, 23);
            label_reg_prename.TabIndex = 14;
            label_reg_prename.Text = "Prename";
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(622, 433);
            Controls.Add(tabControl1);
            MaximumSize = new Size(640, 480);
            MinimumSize = new Size(640, 480);
            Name = "Auth";
            Text = "MetricsFlow";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage1;
        private TextBox textBox_auth_email;
        private Label label1;
        private Button button_auth_signin;
        private TextBox textBox_auth_password;
        private Label label2;
        private TextBox textBox_reg_repeat_password;
        private Label label_reg_repeat_password;
        private Button button_reg_signup;
        private TextBox textBox_reg_password;
        private Label label_reg_password;
        private TextBox textBox_reg_email;
        private Label label_reg_email;
        private TextBox textBox_reg_prename;
        private Label label_reg_prename;
        private TextBox textBox_reg_name;
        private Label label_reg_name;
    }
}