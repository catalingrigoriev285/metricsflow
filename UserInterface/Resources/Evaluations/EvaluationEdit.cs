using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagement.FileSystem;
using Models;

namespace UserInterface.Resources.Evaluations
{
    public partial class EvaluationEdit : Form
    {
        private Admin _adminForm;

        public EvaluationEdit(Admin adminForm)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _adminForm = adminForm;
        }

        private void EvaluationEdit_Load(object sender, EventArgs e)
        {
            if(UserInterface.globals._sessionSelectedEvaluation == null)
            {
                MessageBox.Show("No evaluation selected.");
                this.Close();
            }

            this.Text = "Editing evaluation [ #" + UserInterface.globals._sessionSelectedEvaluation.id + " ]";

            Evaluation evaluation = UserInterface.globals._sessionSelectedEvaluation;

            EvaluationInterface evaluationInterface = new EvaluationInterface();
            evaluation = evaluationInterface.getEvaluationById(evaluation.id);

            textBox_evaluation_edit_title.Text = evaluation.title;
            textBox_evaluation_edit_description.Text = evaluation.description;

            DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
            List<User> users = userInterface.loadUsers();

            users = users.Where(u => u.id != UserInterface.globals.sessionUser.id).ToList();

            foreach (var user in users)
            {
                if (user is Models.User)
                {
                    comboBox_evaluation_edit_user.Items.Add(user.name);
                }
            }

            comboBox_evaluation_edit_user.SelectedItem = users.FirstOrDefault(u => u.id == evaluation.user_id)?.name;

            var types = Enum.GetValues(typeof(Evaluation.EvaluationType));

            foreach (var type in types)
            {
                comboBox_evaluation_edit_type.Items.Add(type.ToString());
            }

            comboBox_evaluation_edit_type.SelectedItem = evaluation.type.ToString();
        }

        bool validate()
        {
            if (string.IsNullOrWhiteSpace(textBox_evaluation_edit_title.Text))
            {
                MessageBox.Show("Title is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBox_evaluation_edit_description.Text))
            {
                MessageBox.Show("Description is required.");
                return false;
            }
            if (comboBox_evaluation_edit_user.SelectedItem == null)
            {
                MessageBox.Show("User is required.");
                return false;
            }
            if (comboBox_evaluation_edit_type.SelectedItem == null)
            {
                MessageBox.Show("Type is required.");
                return false;
            }
            return true;
        }

        private void button_evaluation_edit_submit_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Evaluation evaluation = UserInterface.globals._sessionSelectedEvaluation;

                evaluation.title = textBox_evaluation_edit_title.Text;
                evaluation.description = textBox_evaluation_edit_description.Text;

                DatabaseManagement.FileSystem.UserInterface userInterface = new DatabaseManagement.FileSystem.UserInterface();
                List<User> users = userInterface.loadUsers();

                users = users.Where(u => u.id != UserInterface.globals.sessionUser.id).ToList();
                foreach (var user in users)
                {
                    if (user.name == comboBox_evaluation_edit_user.SelectedItem.ToString())
                    {
                        evaluation.user_id = user.id;
                    }
                }

                evaluation.type = (Evaluation.EvaluationType)Enum.Parse(typeof(Evaluation.EvaluationType), comboBox_evaluation_edit_type.SelectedItem.ToString());
                EvaluationInterface evaluationInterface = new EvaluationInterface();

                evaluationInterface.updateEvaluation(evaluation);

                List<Models.Evaluation> evaluations = new List<Models.Evaluation>();
                evaluations.AddRange((new DatabaseManagement.FileSystem.EvaluationInterface()).loadEvaluations());
                _adminForm.dataGridView_evaluations_render(evaluations);

                MessageBox.Show("Evaluation updated successfully.");
                this.Close();
            }
        }
    }
}
