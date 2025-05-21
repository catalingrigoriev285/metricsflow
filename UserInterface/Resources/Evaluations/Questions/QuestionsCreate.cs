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

namespace UserInterface.Resources.Evaluations.Questions
{
    public partial class QuestionsCreate : Form
    {
        private QuestionsIndex _questionForm;

        public QuestionsCreate(QuestionsIndex questionForm)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _questionForm = questionForm;
        }

        private void QuestionsCreate_Load(object sender, EventArgs e)
        {

        }

        bool validate()
        {
            if (string.IsNullOrEmpty(textBox_questions_create_title.Text))
            {
                MessageBox.Show("Please enter a title.", "Validating");
                return false;
            }

            if (string.IsNullOrEmpty(textBox_questions_create_desc.Text))
            {
                MessageBox.Show("Please enter a description.", "Validating");
                return false;
            }

            return true;
        }

        private void button_questions_create_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string title = textBox_questions_create_title.Text;
                string description = textBox_questions_create_desc.Text;

                Question question = new Question(title, description);

                question.id = new EvaluationInterface().GetNextQuestionId();
                question.answers = new List<Question.Answer>();
                question.created_at = DateTime.Now;
                question.updated_at = DateTime.Now;

                Evaluation evaluation = new DatabaseManagement.FileSystem.EvaluationInterface().getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id);
                evaluation.AddQuestion(question);

                DatabaseManagement.FileSystem.EvaluationInterface evaluationInterface = new DatabaseManagement.FileSystem.EvaluationInterface();
                evaluationInterface.updateEvaluation(evaluation);

                MessageBox.Show("Question created successfully.", "Success");

                _questionForm.dataGridView_questions_render(evaluation.questions);

                this.Close();
            }
        }

        private void label_questions_create_name_Click(object sender, EventArgs e)
        {

        }
    }
}
