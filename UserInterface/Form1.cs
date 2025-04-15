namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private bool validateSignUp()
        {
            if (string.IsNullOrEmpty(metroTextBox_signup_email.Text))
            {
                MessageBox.Show("Please enter an email!", "Validation");
                return false;
            }
            else if (string.IsNullOrEmpty(metroTextBox_signup_name.Text))
            {
                MessageBox.Show("Please enter a name!", "Validation");
                return false;
            }
            else if (string.IsNullOrEmpty(metroTextBox_signup_prename.Text))
            {
                MessageBox.Show("Please enter a prename!", "Validation");
                return false;
            }
            else if (string.IsNullOrEmpty(metroTextBox_signup_password.Text))
            {
                MessageBox.Show("Please enter a password!", "Validation");
                return false;
            }
            else if (string.IsNullOrEmpty(metroTextBox_signup_repeat_password.Text))
            {
                MessageBox.Show("Please confirm your password!", "Validation");
                return false;
            }
            else if (metroTextBox_signup_password.Text != metroTextBox_signup_repeat_password.Text)
            {
                MessageBox.Show("Passwords do not match!", "Validation");
                return false;
            }

            return true;
        }

        private void metroButton_signup_submit_Click(object sender, EventArgs e)
        {
            if (validateSignUp())
            {
                Models.User user = new Models.User();
                user.email = metroTextBox_signup_email.Text;
                user.name = metroTextBox_signup_name.Text;
                user.prename = metroTextBox_signup_prename.Text;
                user.setPassword(metroTextBox_signup_password.Text);

                if ((new DatabaseManagement.FileSystem.RoleInterface()).loadRoles().Count == 0)
                {
                    MessageBox.Show("No roles found! Please create a role first.", "Validation");
                    return;
                }
                else
                {
                    List<Models.Role> tempRoles = (new DatabaseManagement.FileSystem.RoleInterface()).loadRoles();
                    Models.Role role = tempRoles.FirstOrDefault(r => r.name == "employee");

                    if (role == null)
                    {
                        MessageBox.Show("Employee role not found!", "Validation");
                        return;
                    }

                    user.role = role;
                }

                DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();

                try
                {
                    userInterface.saveUser(user);
                    MessageBox.Show("Your account successfuly created!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating user: {ex.Message}", "Error");
                }
            }
        }

        bool validateLogin()
        {
            if (string.IsNullOrEmpty(metroTextBox_email.Text))
            {
                MessageBox.Show("Please enter an email!", "Validation");
                return false;
            }
            else if (string.IsNullOrEmpty(metroTextBox_password.Text))
            {
                MessageBox.Show("Please enter a password!", "Validation");
                return false;
            }
            return true;
        }

        private void metroButton_auth_submit_Click(object sender, EventArgs e)
        {
            if(validateLogin())
            {
                Models.User user = new Models.User();
                user.email = metroTextBox_email.Text;
                user.setPassword(metroTextBox_password.Text);
                DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
                
                try
                {
                    if (userInterface.auth(user.email, user.getPassword()))
                    {
                        MessageBox.Show("Login successful!", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password!", "Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error logging in: {ex.Message}", "Error");
                }
            }
        }
    }
}
