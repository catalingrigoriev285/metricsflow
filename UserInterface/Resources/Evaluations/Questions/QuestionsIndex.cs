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

namespace UserInterface.Resources.Evaluations.Questions
{
    public partial class QuestionsIndex : Form
    {
        private Admin _adminForm;
        private Evaluation _evaluation;

        public QuestionsIndex(Admin adminForm)
        {
            InitializeComponent();
            _adminForm = adminForm;

            Evaluation evaluation = new DatabaseManagement.FileSystem.EvaluationInterface().getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id);

            if (evaluation == null)
            {
                MessageBox.Show("Evaluation not found.");
                return;
            }

            _evaluation = evaluation;

            DataGridViewButtonColumn answersButton = new DataGridViewButtonColumn();
            answersButton.HeaderText = "";
            answersButton.Text = "Answers";
            answersButton.Name = "Answers";
            answersButton.UseColumnTextForButtonValue = true;
            dataGridView_questions.Columns.Add(answersButton);

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.Name = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            dataGridView_questions.Columns.Add(editButton);

            DataGridViewButtonColumn destroyButton = new DataGridViewButtonColumn();
            destroyButton.HeaderText = "";
            destroyButton.Text = "Destroy";
            destroyButton.Name = "Destroy";
            destroyButton.UseColumnTextForButtonValue = true;
            dataGridView_questions.Columns.Add(destroyButton);

            dataGridView_questions.CellClick += (s, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (dataGridView_questions.Columns["Edit"] != null && e.ColumnIndex == dataGridView_questions.Columns["Edit"].Index)
                    {
                        if (dataGridView_questions.Rows[e.RowIndex].Cells[0].Value is int questionID)
                        {
                            Question question = new Question(string.Empty, string.Empty);
                            question.id = questionID;

                            UserInterface.globals.sessionSelectedQuestion = question;

                            UserInterface.Resources.Evaluations.Questions.QuestionsEdit questionsEdit = new UserInterface.Resources.Evaluations.Questions.QuestionsEdit(this);
                            questionsEdit.ShowDialog();
                        }
                    }
                    else if (dataGridView_questions.Columns["Destroy"] != null && e.ColumnIndex == dataGridView_questions.Columns["Destroy"].Index)
                    {
                        var confirm = MessageBox.Show("Are you sure you want to delete this question?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirm == DialogResult.Yes)
                        {
                            int questionID = (int)dataGridView_questions.Rows[e.RowIndex].Cells[0].Value;

                            Question question = new Question(string.Empty, string.Empty);
                            question.id = questionID;

                            Evaluation evaluation = new DatabaseManagement.FileSystem.EvaluationInterface().getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id);
                            Question questionToDelete = evaluation.questions.FirstOrDefault(q => q.id == questionID);
                            if (questionToDelete != null)
                            {
                                evaluation.questions.Remove(questionToDelete);
                                new DatabaseManagement.FileSystem.EvaluationInterface().updateEvaluation(evaluation);
                                dataGridView_questions_render(evaluation.questions);
                            }
                            else
                            {
                                MessageBox.Show("Question not found.");
                            }
                        }
                    }
                    else if (dataGridView_questions.Columns["Answers"] != null && e.ColumnIndex == dataGridView_questions.Columns["Answers"].Index)
                    {
                        MessageBox.Show("Answers button clicked");
                    }
                };
            };
        }

        private void QuestionsIndex_Load(object sender, EventArgs e)
        {
            this.Text = "Questions for " + _evaluation?.title;

            Evaluation evaluation = new DatabaseManagement.FileSystem.EvaluationInterface().getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id);
            dataGridView_questions_render(evaluation?.questions);
        }

        public void dataGridView_questions_render(List<Question> questions)
        {
            dataGridView_questions.DataSource = null;

            if (questions == null || questions.Count == 0)
            {
                dataGridView_questions.DataSource = new List<Question>();
                return;
            }
            else
            {
                dataGridView_questions.DataSource = questions;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_questions_create_Click(object sender, EventArgs e)
        {
            UserInterface.Resources.Evaluations.Questions.QuestionsCreate questionsCreate = new UserInterface.Resources.Evaluations.Questions.QuestionsCreate(this);
            questionsCreate.ShowDialog();
        }

        private void button_questions_search_Click(object sender, EventArgs e)
        {
            string searchText = textBox_questions_search.Text;

            List<Question> questions = new DatabaseManagement.FileSystem.EvaluationInterface().getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id).questions;

            List<Question> filteredQuestions = questions.Where(q => q.title.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
            dataGridView_questions_render(filteredQuestions);
        }

        private void button_questions_destroy_all_Click(object sender, EventArgs e)
        {
            Evaluation currentEvaluation = new DatabaseManagement.FileSystem.EvaluationInterface().getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id);
            if (currentEvaluation == null)
            {
                MessageBox.Show("Evaluation not found.");
                return;
            }

            if (currentEvaluation == null || currentEvaluation.questions == null || currentEvaluation.questions.Count == 0)
            {
                MessageBox.Show("No questions to destroy.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to destroy all questions?", "Destroy All Questions", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                currentEvaluation.questions.Clear();
                new DatabaseManagement.FileSystem.EvaluationInterface().updateEvaluation(currentEvaluation);

                dataGridView_questions_render(currentEvaluation.questions);
                MessageBox.Show("All questions destroyed.");
            }
        }
    }
}
