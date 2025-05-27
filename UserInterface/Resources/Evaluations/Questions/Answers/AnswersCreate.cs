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

namespace UserInterface.Resources.Evaluations.Questions.Answers
{
    public partial class AnswersCreate : Form
    {
        private readonly AnswersIndex _answersIndex;
        private readonly EvaluationInterface _evaluationInterface;

        public AnswersCreate(AnswersIndex answersIndex)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _answersIndex = answersIndex;
            _evaluationInterface = new EvaluationInterface();
        }

        private void AnswersCreate_Load(object sender, EventArgs e)
        {
            
        }

        private bool Validate()
        {
            if (String.IsNullOrWhiteSpace(textBox_answers_create_value.Text))
            {
                MessageBox.Show("Please enter a value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (!radioButton_answers_create_false.Checked && !radioButton_answers_create_true.Checked)
            {
                MessageBox.Show("Please select a validation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void button_questions_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validate())
                    return;

                string value = textBox_answers_create_value.Text.Trim();
                bool validation = radioButton_answers_create_true.Checked;

                Evaluation evaluation = _evaluationInterface.getEvaluationById(UserInterface.globals.sessionSelectedEvaluation.id);
                Question question = evaluation.questions?.FirstOrDefault(q => q.id == UserInterface.globals.sessionSelectedQuestion.id);
                
                if (question == null)
                {
                    MessageBox.Show("No question selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                question.AddAnswer(new Question.Answer(value, validation));
                question.updated_at = DateTime.Now;

                _evaluationInterface.updateEvaluation(evaluation);

                UserInterface.globals.sessionSelectedQuestion = question;

                textBox_answers_create_value.Text = String.Empty;
                radioButton_answers_create_false.Checked = false;
                radioButton_answers_create_true.Checked = false;

                _answersIndex.dataGridView_answers_render(question.answers);

                MessageBox.Show("Answer created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
