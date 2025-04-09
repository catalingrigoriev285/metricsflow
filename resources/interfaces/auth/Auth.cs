using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using metricsflow.app.models;
using metricsflow.app.services;
using Microsoft.IdentityModel.Tokens;

namespace metricsflow.resources.interfaces.auth
{
    public partial class Auth : Form
    {
        public Auth()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private bool validateRegisterRequest()
        {
            if (String.IsNullOrEmpty(textBox_reg_email.Text)){
                textBox_reg_email.BackColor = Color.DarkRed;
                textBox_reg_email.ForeColor = Color.White;
                return false;
            }

            if( String.IsNullOrEmpty(textBox_reg_name.Text))
            {
                textBox_reg_name.BackColor = Color.DarkRed;
                textBox_reg_name.ForeColor = Color.White;
                return false;
            }

            if (String.IsNullOrEmpty(textBox_reg_prename.Text))
            {
                textBox_reg_prename.BackColor = Color.DarkRed;
                textBox_reg_prename.ForeColor = Color.White;
                return false;
            }

            if (String.IsNullOrEmpty(textBox_reg_password.Text))
            {
                textBox_reg_password.BackColor = Color.DarkRed;
                textBox_reg_password.ForeColor = Color.White;
                return false;
            }

            if (String.IsNullOrEmpty(textBox_reg_repeat_password.Text) || (textBox_reg_password.Text != textBox_reg_repeat_password.Text))
            {
                textBox_reg_repeat_password.BackColor = Color.DarkRed;
                textBox_reg_repeat_password.ForeColor = Color.White;
                return false;
            }

            return true;
        }

        private void button_reg_signup_Click(object sender, EventArgs e)
        {
            textBox_reg_email.BackColor = Color.White;
            textBox_reg_email.ForeColor = Color.Black;

            textBox_reg_name.BackColor = Color.White;
            textBox_reg_name.ForeColor = Color.Black;

            textBox_reg_prename.BackColor = Color.White;
            textBox_reg_prename.ForeColor = Color.Black;

            textBox_reg_password.BackColor = Color.White;
            textBox_reg_password.ForeColor = Color.Black;

            textBox_reg_repeat_password.BackColor = Color.White;
            textBox_reg_repeat_password.ForeColor = Color.Black;

            if (validateRegisterRequest())
            {
                UserService userService = new UserService();

                if (!userService.Where("email", textBox_reg_email.Text).IsNullOrEmpty())
                {
                    MessageBox.Show("Email already exists");
                    return;
                } else
                {
                    User user = new User();
                    user.email = textBox_reg_email.Text;
                    user.name = textBox_reg_name.Text;
                    user.prename = textBox_reg_prename.Text;
                    user.password = textBox_reg_password.Text;

                    userService.Create(user);
                }
            }
        }
    }
}
