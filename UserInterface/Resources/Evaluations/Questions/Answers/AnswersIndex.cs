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

namespace UserInterface.Resources.Evaluations.Questions.Answers
{
    public partial class AnswersIndex : Form
    {
        private QuestionsIndex _questionForm;
        private Question _question;

        public AnswersIndex(QuestionsIndex questionForm, Question question)
        {
            InitializeComponent();
            _questionForm = questionForm;
            _question = question;
        }

        private void AnswersIndex_Load(object sender, EventArgs e)
        {
            this.Text = "Answers for " + _question?.title;

            Evaluation evaluation = new DatabaseManagement.FileSystem.EvaluationInterface().getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id);
            dataGridView_answers_render(_question?.answers);
        }

        public void dataGridView_answers_render(List<Question.Answer> answers)
        {
            dataGridView_answers.DataSource = null;

            if (answers == null || answers.Count == 0)
            {
                dataGridView_answers.DataSource = new List<Question>();
                return;
            }
            else
            {
                dataGridView_answers.DataSource = answers;
            }
        }

        private void button_questions_create_Click(object sender, EventArgs e)
        {
            UserInterface.Resources.Evaluations.Questions.Answers.AnswersCreate answersCreate = new UserInterface.Resources.Evaluations.Questions.Answers.AnswersCreate(this, _question);
            answersCreate.ShowDialog();
        }

        private void button_questions_search_Click(object sender, EventArgs e)
        {

        }
    }
}
