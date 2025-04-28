using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace UserInterface.Resources.Evaluations
{
    public partial class EvaluationCreate : Form
    {
        private Admin _adminForm;

        public EvaluationCreate(Admin adminForm)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _adminForm = adminForm;
        }

        private void EvaluationCreate_Load(object sender, EventArgs e)
        {
            DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
            List<User> users = userInterface.loadUsers();

            users = users.Where(u => u.id != UserInterface.globals.sessionUser.id).ToList();

            foreach (var user in users)
            {
                if (user is Models.User)
                {
                    comboBox_evaluation_create_user.Items.Add(user.name);
                }
            }

            comboBox_evaluation_create_user.SelectedIndex = 0;

            var types = Enum.GetValues(typeof(Evaluation.EvaluationType));

            foreach (var type in types)
            {
                comboBox_evaluation_create_type.Items.Add(type.ToString());
            }

            comboBox_evaluation_create_type.SelectedIndex = 0;
        }

        private bool validate()
        {
            if (string.IsNullOrEmpty(textBox_evaluation_create_title.Text))
            {
                MessageBox.Show("Please enter a title for the evaluation.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox_evaluation_create_description.Text))
            {
                MessageBox.Show("Please enter a description for the evaluation.");
                return false;
            }
            return true;
        }

        private void button_evaluation_create_submit_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Evaluation evaluation = new Evaluation(textBox_evaluation_create_title.Text, textBox_evaluation_create_description.Text);

                evaluation.user_id = comboBox_evaluation_create_user.SelectedIndex + 1;
                evaluation.type = (Evaluation.EvaluationType)Enum.Parse(typeof(Evaluation.EvaluationType), comboBox_evaluation_create_type.SelectedItem.ToString());
                
                DatabaseManagement.FileSystem.EvaluationInterface evaluationInterface = new DatabaseManagement.FileSystem.EvaluationInterface();
                evaluationInterface.saveEvaluation(evaluation);

                MessageBox.Show("Evaluation created successfully!");

                List<Models.Evaluation> evaluations = new List<Models.Evaluation>();
                evaluations.AddRange((new DatabaseManagement.FileSystem.EvaluationInterface()).loadEvaluations());
                _adminForm.dataGridView_evaluations_render(evaluations);

                this.Close();
            }
        }
    }
}
