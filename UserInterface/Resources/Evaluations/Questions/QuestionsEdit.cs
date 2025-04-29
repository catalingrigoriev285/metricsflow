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
    public partial class QuestionsEdit : Form
    {
        private QuestionsIndex _questionsIndexForm;

        public QuestionsEdit(QuestionsIndex questionsIndexForm)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _questionsIndexForm = questionsIndexForm;
        }

        private void QuestionsEdit_Load(object sender, EventArgs e)
        {
            if (UserInterface.globals.sessionSelectedQuestion == null)
            {
                MessageBox.Show("Question not found.");
                return;
            }

            this.Text = "Edit Question [ #" + UserInterface.globals.sessionSelectedQuestion.id + " ]";

            Question question = new EvaluationInterface().getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id).questions.FirstOrDefault(q => q.id == UserInterface.globals.sessionSelectedQuestion.id);

            if (question == null)
            {
                MessageBox.Show("Question not found.");
                return;
            }

            textBox_questions_edit_title.Text = question.title;
            textBox_questions_edit_desc.Text = question.description;
        }

        private bool validate()
        {
            if (string.IsNullOrEmpty(textBox_questions_edit_title.Text))
            {
                MessageBox.Show("Title is required.");
                return false;
            }
            if (string.IsNullOrEmpty(textBox_questions_edit_desc.Text))
            {
                MessageBox.Show("Description is required.");
                return false;
            }
            return true;
        }

        private void button_questions_edit_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                Question question = new Question(textBox_questions_edit_title.Text, textBox_questions_edit_desc.Text);
                question.id = UserInterface.globals.sessionSelectedQuestion.id;

                DatabaseManagement.FileSystem.EvaluationInterface evaluationInterface = new DatabaseManagement.FileSystem.EvaluationInterface();

                EvaluationInterface evaluation = new EvaluationInterface();
                Evaluation evaluationSelected = evaluation.getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id);

                if(evaluation != null)
                {
                    evaluationSelected.questions.Remove(UserInterface.globals.sessionSelectedQuestion);
                    evaluationSelected.questions.Add(question);
                }

                evaluationInterface.updateEvaluation(evaluationSelected);

                List<Question> updatedQuestions = evaluation.getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id).questions;
                _questionsIndexForm.dataGridView_questions_render(updatedQuestions);

                MessageBox.Show("Question updated successfully.");

                this.Close();
            }
        }
    }
}
