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
using DatabaseManagement.FileSystem;

namespace UserInterface.Resources.Evaluations.Questions.Answers
{
    public partial class AnswersIndex : Form
    {
        private readonly QuestionsIndex _questionForm;
        private readonly Question _question;
        private readonly EvaluationInterface _evaluationInterface;

        public AnswersIndex(QuestionsIndex questionForm, Question question)
        {
            InitializeComponent();
            _questionForm = questionForm;
            _question = question;
            _evaluationInterface = new EvaluationInterface();
        }

        private void AnswersIndex_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = $"Answers for: {_question?.title}";
                LoadAnswers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading answers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAnswers()
        {
            try
            {
                if (_question == null)
                {
                    MessageBox.Show("No question selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Evaluation evaluation = _evaluationInterface.getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id);
                Question updatedQuestion = evaluation.questions?.FirstOrDefault(q => q.id == _question.id);
                
                if (updatedQuestion != null)
                {
                    _question.answers = updatedQuestion.answers;
                }

                dataGridView_answers_render(_question.answers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading answers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void dataGridView_answers_render(List<Question.Answer> answers)
        {
            try
            {
                dataGridView_answers.DataSource = null;

                if (answers == null || answers.Count == 0)
                {
                    dataGridView_answers.DataSource = new List<Question.Answer>();
                    return;
                }

                dataGridView_answers.AutoGenerateColumns = false;
                dataGridView_answers.Columns.Clear();

                dataGridView_answers.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Value",
                    HeaderText = "Answer Value",
                    DataPropertyName = "value",
                    Width = 300
                });

                dataGridView_answers.Columns.Add(new DataGridViewCheckBoxColumn
                {
                    Name = "Validation",
                    HeaderText = "Is Valid",
                    DataPropertyName = "validation",
                    Width = 100
                });

                dataGridView_answers.DataSource = answers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error rendering answers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_questions_create_Click(object sender, EventArgs e)
        {
            try
            {
                var answersCreate = new AnswersCreate(this);
                answersCreate.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating answer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_questions_search_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
