namespace UserInterface
{
    partial class Auth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            metroTabControl_main = new MetroFramework.Controls.MetroTabControl();
            tabPage_signin = new TabPage();
            metroButton_auth_submit = new MetroFramework.Controls.MetroButton();
            metroTextBox_password = new MetroFramework.Controls.MetroTextBox();
            metroLabel_password = new MetroFramework.Controls.MetroLabel();
            metroTextBox_email = new MetroFramework.Controls.MetroTextBox();
            metroLabel_email = new MetroFramework.Controls.MetroLabel();
            tabPage_signup = new TabPage();
            metroTextBox_signup_repeat_password = new MetroFramework.Controls.MetroTextBox();
            metroLabel_signup_repeat_password = new MetroFramework.Controls.MetroLabel();
            metroTextBox_signup_prename = new MetroFramework.Controls.MetroTextBox();
            metroLabel_signup_prename = new MetroFramework.Controls.MetroLabel();
            metroTextBox_signup_name = new MetroFramework.Controls.MetroTextBox();
            metroLabel_signup_name = new MetroFramework.Controls.MetroLabel();
            metroButton_signup_submit = new MetroFramework.Controls.MetroButton();
            metroTextBox_signup_password = new MetroFramework.Controls.MetroTextBox();
            metroLabel_signup_password = new MetroFramework.Controls.MetroLabel();
            metroTextBox_signup_email = new MetroFramework.Controls.MetroTextBox();
            metroLabel_signup_email = new MetroFramework.Controls.MetroLabel();
            metroTabControl_main.SuspendLayout();
            tabPage_signin.SuspendLayout();
            tabPage_signup.SuspendLayout();
            SuspendLayout();
            // 
            // metroTabControl_main
            // 
            metroTabControl_main.Controls.Add(tabPage_signin);
            metroTabControl_main.Controls.Add(tabPage_signup);
            metroTabControl_main.CustomBackground = false;
            metroTabControl_main.FontSize = MetroFramework.MetroTabControlSize.Medium;
            metroTabControl_main.FontWeight = MetroFramework.MetroTabControlWeight.Light;
            metroTabControl_main.Location = new Point(0, 0);
            metroTabControl_main.Name = "metroTabControl_main";
            metroTabControl_main.Padding = new Point(6, 8);
            metroTabControl_main.SelectedIndex = 0;
            metroTabControl_main.Size = new Size(640, 480);
            metroTabControl_main.Style = MetroFramework.MetroColorStyle.Blue;
            metroTabControl_main.StyleManager = null;
            metroTabControl_main.TabIndex = 0;
            metroTabControl_main.TextAlign = ContentAlignment.MiddleLeft;
            metroTabControl_main.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTabControl_main.UseStyleColors = false;
            metroTabControl_main.SelectedIndexChanged += metroTabControl_main_SelectedIndexChanged;
            // 
            // tabPage_signin
            // 
            tabPage_signin.Controls.Add(metroButton_auth_submit);
            tabPage_signin.Controls.Add(metroTextBox_password);
            tabPage_signin.Controls.Add(metroLabel_password);
            tabPage_signin.Controls.Add(metroTextBox_email);
            tabPage_signin.Controls.Add(metroLabel_email);
            tabPage_signin.Location = new Point(4, 39);
            tabPage_signin.Name = "tabPage_signin";
            tabPage_signin.Size = new Size(632, 437);
            tabPage_signin.TabIndex = 0;
            tabPage_signin.Text = "Sign In";
            // 
            // metroButton_auth_submit
            // 
            metroButton_auth_submit.Font = new Font("Segoe UI", 12F);
            metroButton_auth_submit.Highlight = false;
            metroButton_auth_submit.Location = new Point(462, 341);
            metroButton_auth_submit.Name = "metroButton_auth_submit";
            metroButton_auth_submit.Size = new Size(144, 41);
            metroButton_auth_submit.Style = MetroFramework.MetroColorStyle.Blue;
            metroButton_auth_submit.StyleManager = null;
            metroButton_auth_submit.TabIndex = 4;
            metroButton_auth_submit.Text = "Sign In";
            metroButton_auth_submit.Theme = MetroFramework.MetroThemeStyle.Light;
            metroButton_auth_submit.Click += metroButton_auth_submit_Click;
            // 
            // metroTextBox_password
            // 
            metroTextBox_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            metroTextBox_password.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox_password.Location = new Point(8, 122);
            metroTextBox_password.Multiline = false;
            metroTextBox_password.Name = "metroTextBox_password";
            metroTextBox_password.SelectedText = "";
            metroTextBox_password.Size = new Size(598, 29);
            metroTextBox_password.Style = MetroFramework.MetroColorStyle.Black;
            metroTextBox_password.StyleManager = null;
            metroTextBox_password.TabIndex = 3;
            metroTextBox_password.Text = "123123";
            metroTextBox_password.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox_password.UseStyleColors = false;
            // 
            // metroLabel_password
            // 
            metroLabel_password.AutoSize = true;
            metroLabel_password.CustomBackground = false;
            metroLabel_password.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel_password.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel_password.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel_password.Location = new Point(8, 90);
            metroLabel_password.Name = "metroLabel_password";
            metroLabel_password.Size = new Size(66, 20);
            metroLabel_password.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel_password.StyleManager = null;
            metroLabel_password.TabIndex = 2;
            metroLabel_password.Text = "Password";
            metroLabel_password.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel_password.UseStyleColors = false;
            // 
            // metroTextBox_email
            // 
            metroTextBox_email.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            metroTextBox_email.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox_email.Location = new Point(8, 46);
            metroTextBox_email.Multiline = false;
            metroTextBox_email.Name = "metroTextBox_email";
            metroTextBox_email.SelectedText = "";
            metroTextBox_email.Size = new Size(598, 29);
            metroTextBox_email.Style = MetroFramework.MetroColorStyle.Black;
            metroTextBox_email.StyleManager = null;
            metroTextBox_email.TabIndex = 1;
            metroTextBox_email.Text = "employee";
            metroTextBox_email.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox_email.UseStyleColors = false;
            // 
            // metroLabel_email
            // 
            metroLabel_email.AutoSize = true;
            metroLabel_email.CustomBackground = false;
            metroLabel_email.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel_email.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel_email.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel_email.Location = new Point(8, 14);
            metroLabel_email.Name = "metroLabel_email";
            metroLabel_email.Size = new Size(42, 20);
            metroLabel_email.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel_email.StyleManager = null;
            metroLabel_email.TabIndex = 0;
            metroLabel_email.Text = "Email";
            metroLabel_email.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel_email.UseStyleColors = false;
            // 
            // tabPage_signup
            // 
            tabPage_signup.Controls.Add(metroTextBox_signup_repeat_password);
            tabPage_signup.Controls.Add(metroLabel_signup_repeat_password);
            tabPage_signup.Controls.Add(metroTextBox_signup_prename);
            tabPage_signup.Controls.Add(metroLabel_signup_prename);
            tabPage_signup.Controls.Add(metroTextBox_signup_name);
            tabPage_signup.Controls.Add(metroLabel_signup_name);
            tabPage_signup.Controls.Add(metroButton_signup_submit);
            tabPage_signup.Controls.Add(metroTextBox_signup_password);
            tabPage_signup.Controls.Add(metroLabel_signup_password);
            tabPage_signup.Controls.Add(metroTextBox_signup_email);
            tabPage_signup.Controls.Add(metroLabel_signup_email);
            tabPage_signup.Location = new Point(4, 39);
            tabPage_signup.Name = "tabPage_signup";
            tabPage_signup.Size = new Size(632, 437);
            tabPage_signup.TabIndex = 1;
            tabPage_signup.Text = "Sign Up";
            // 
            // metroTextBox_signup_repeat_password
            // 
            metroTextBox_signup_repeat_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            metroTextBox_signup_repeat_password.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox_signup_repeat_password.Location = new Point(8, 272);
            metroTextBox_signup_repeat_password.Multiline = false;
            metroTextBox_signup_repeat_password.Name = "metroTextBox_signup_repeat_password";
            metroTextBox_signup_repeat_password.SelectedText = "";
            metroTextBox_signup_repeat_password.Size = new Size(598, 29);
            metroTextBox_signup_repeat_password.Style = MetroFramework.MetroColorStyle.Black;
            metroTextBox_signup_repeat_password.StyleManager = null;
            metroTextBox_signup_repeat_password.TabIndex = 15;
            metroTextBox_signup_repeat_password.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox_signup_repeat_password.UseStyleColors = false;
            // 
            // metroLabel_signup_repeat_password
            // 
            metroLabel_signup_repeat_password.AutoSize = true;
            metroLabel_signup_repeat_password.CustomBackground = false;
            metroLabel_signup_repeat_password.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel_signup_repeat_password.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel_signup_repeat_password.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel_signup_repeat_password.Location = new Point(8, 240);
            metroLabel_signup_repeat_password.Name = "metroLabel_signup_repeat_password";
            metroLabel_signup_repeat_password.Size = new Size(146, 20);
            metroLabel_signup_repeat_password.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel_signup_repeat_password.StyleManager = null;
            metroLabel_signup_repeat_password.TabIndex = 14;
            metroLabel_signup_repeat_password.Text = "Repeat your password";
            metroLabel_signup_repeat_password.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel_signup_repeat_password.UseStyleColors = false;
            // 
            // metroTextBox_signup_prename
            // 
            metroTextBox_signup_prename.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            metroTextBox_signup_prename.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox_signup_prename.Location = new Point(318, 121);
            metroTextBox_signup_prename.Multiline = false;
            metroTextBox_signup_prename.Name = "metroTextBox_signup_prename";
            metroTextBox_signup_prename.SelectedText = "";
            metroTextBox_signup_prename.Size = new Size(288, 29);
            metroTextBox_signup_prename.Style = MetroFramework.MetroColorStyle.Black;
            metroTextBox_signup_prename.StyleManager = null;
            metroTextBox_signup_prename.TabIndex = 13;
            metroTextBox_signup_prename.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox_signup_prename.UseStyleColors = false;
            // 
            // metroLabel_signup_prename
            // 
            metroLabel_signup_prename.AutoSize = true;
            metroLabel_signup_prename.CustomBackground = false;
            metroLabel_signup_prename.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel_signup_prename.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel_signup_prename.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel_signup_prename.Location = new Point(318, 89);
            metroLabel_signup_prename.Name = "metroLabel_signup_prename";
            metroLabel_signup_prename.Size = new Size(65, 20);
            metroLabel_signup_prename.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel_signup_prename.StyleManager = null;
            metroLabel_signup_prename.TabIndex = 12;
            metroLabel_signup_prename.Text = "Prename";
            metroLabel_signup_prename.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel_signup_prename.UseStyleColors = false;
            // 
            // metroTextBox_signup_name
            // 
            metroTextBox_signup_name.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            metroTextBox_signup_name.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox_signup_name.Location = new Point(8, 121);
            metroTextBox_signup_name.Multiline = false;
            metroTextBox_signup_name.Name = "metroTextBox_signup_name";
            metroTextBox_signup_name.SelectedText = "";
            metroTextBox_signup_name.Size = new Size(288, 29);
            metroTextBox_signup_name.Style = MetroFramework.MetroColorStyle.Black;
            metroTextBox_signup_name.StyleManager = null;
            metroTextBox_signup_name.TabIndex = 11;
            metroTextBox_signup_name.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox_signup_name.UseStyleColors = false;
            // 
            // metroLabel_signup_name
            // 
            metroLabel_signup_name.AutoSize = true;
            metroLabel_signup_name.CustomBackground = false;
            metroLabel_signup_name.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel_signup_name.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel_signup_name.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel_signup_name.Location = new Point(8, 89);
            metroLabel_signup_name.Name = "metroLabel_signup_name";
            metroLabel_signup_name.Size = new Size(47, 20);
            metroLabel_signup_name.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel_signup_name.StyleManager = null;
            metroLabel_signup_name.TabIndex = 10;
            metroLabel_signup_name.Text = "Name";
            metroLabel_signup_name.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel_signup_name.UseStyleColors = false;
            // 
            // metroButton_signup_submit
            // 
            metroButton_signup_submit.Font = new Font("Segoe UI", 12F);
            metroButton_signup_submit.Highlight = false;
            metroButton_signup_submit.Location = new Point(462, 341);
            metroButton_signup_submit.Name = "metroButton_signup_submit";
            metroButton_signup_submit.Size = new Size(144, 41);
            metroButton_signup_submit.Style = MetroFramework.MetroColorStyle.Blue;
            metroButton_signup_submit.StyleManager = null;
            metroButton_signup_submit.TabIndex = 9;
            metroButton_signup_submit.Text = "Sign Up";
            metroButton_signup_submit.Theme = MetroFramework.MetroThemeStyle.Light;
            metroButton_signup_submit.Click += metroButton_signup_submit_Click;
            // 
            // metroTextBox_signup_password
            // 
            metroTextBox_signup_password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            metroTextBox_signup_password.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox_signup_password.Location = new Point(8, 197);
            metroTextBox_signup_password.Multiline = false;
            metroTextBox_signup_password.Name = "metroTextBox_signup_password";
            metroTextBox_signup_password.SelectedText = "";
            metroTextBox_signup_password.Size = new Size(598, 29);
            metroTextBox_signup_password.Style = MetroFramework.MetroColorStyle.Black;
            metroTextBox_signup_password.StyleManager = null;
            metroTextBox_signup_password.TabIndex = 8;
            metroTextBox_signup_password.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox_signup_password.UseStyleColors = false;
            // 
            // metroLabel_signup_password
            // 
            metroLabel_signup_password.AutoSize = true;
            metroLabel_signup_password.CustomBackground = false;
            metroLabel_signup_password.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel_signup_password.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel_signup_password.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel_signup_password.Location = new Point(8, 165);
            metroLabel_signup_password.Name = "metroLabel_signup_password";
            metroLabel_signup_password.Size = new Size(66, 20);
            metroLabel_signup_password.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel_signup_password.StyleManager = null;
            metroLabel_signup_password.TabIndex = 7;
            metroLabel_signup_password.Text = "Password";
            metroLabel_signup_password.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel_signup_password.UseStyleColors = false;
            // 
            // metroTextBox_signup_email
            // 
            metroTextBox_signup_email.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            metroTextBox_signup_email.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            metroTextBox_signup_email.Location = new Point(8, 47);
            metroTextBox_signup_email.Multiline = false;
            metroTextBox_signup_email.Name = "metroTextBox_signup_email";
            metroTextBox_signup_email.SelectedText = "";
            metroTextBox_signup_email.Size = new Size(598, 29);
            metroTextBox_signup_email.Style = MetroFramework.MetroColorStyle.Black;
            metroTextBox_signup_email.StyleManager = null;
            metroTextBox_signup_email.TabIndex = 6;
            metroTextBox_signup_email.Theme = MetroFramework.MetroThemeStyle.Light;
            metroTextBox_signup_email.UseStyleColors = false;
            // 
            // metroLabel_signup_email
            // 
            metroLabel_signup_email.AutoSize = true;
            metroLabel_signup_email.CustomBackground = false;
            metroLabel_signup_email.FontSize = MetroFramework.MetroLabelSize.Medium;
            metroLabel_signup_email.FontWeight = MetroFramework.MetroLabelWeight.Light;
            metroLabel_signup_email.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            metroLabel_signup_email.Location = new Point(8, 15);
            metroLabel_signup_email.Name = "metroLabel_signup_email";
            metroLabel_signup_email.Size = new Size(42, 20);
            metroLabel_signup_email.Style = MetroFramework.MetroColorStyle.Blue;
            metroLabel_signup_email.StyleManager = null;
            metroLabel_signup_email.TabIndex = 5;
            metroLabel_signup_email.Text = "Email";
            metroLabel_signup_email.Theme = MetroFramework.MetroThemeStyle.Light;
            metroLabel_signup_email.UseStyleColors = false;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 433);
            Controls.Add(metroTabControl_main);
            Name = "Auth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentication";
            metroTabControl_main.ResumeLayout(false);
            tabPage_signin.ResumeLayout(false);
            tabPage_signin.PerformLayout();
            tabPage_signup.ResumeLayout(false);
            tabPage_signup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl_main;
        private TabPage tabPage_signin;
        private TabPage tabPage_signup;
        private MetroFramework.Controls.MetroTextBox metroTextBox_email;
        private MetroFramework.Controls.MetroLabel metroLabel_email;
        private MetroFramework.Controls.MetroTextBox metroTextBox_password;
        private MetroFramework.Controls.MetroLabel metroLabel_password;
        private MetroFramework.Controls.MetroButton metroButton_auth_submit;
        private MetroFramework.Controls.MetroTextBox metroTextBox_signup_prename;
        private MetroFramework.Controls.MetroLabel metroLabel_signup_prename;
        private MetroFramework.Controls.MetroTextBox metroTextBox_signup_name;
        private MetroFramework.Controls.MetroLabel metroLabel_signup_name;
        private MetroFramework.Controls.MetroButton metroButton_signup_submit;
        private MetroFramework.Controls.MetroTextBox metroTextBox_signup_password;
        private MetroFramework.Controls.MetroLabel metroLabel_signup_password;
        private MetroFramework.Controls.MetroTextBox metroTextBox_signup_email;
        private MetroFramework.Controls.MetroLabel metroLabel_signup_email;
        private MetroFramework.Controls.MetroTextBox metroTextBox_signup_repeat_password;
        private MetroFramework.Controls.MetroLabel metroLabel_signup_repeat_password;
    }
}
