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
        private AnswersIndex _answersIndex;
        public AnswersCreate(AnswersIndex answersIndex)
        {
            this.MaximizeBox = false;
            InitializeComponent();

            _answersIndex = answersIndex;
        }

        private void AnswersCreate_Load(object sender, EventArgs e)
        {

        }

        bool validate()
        {
            if (String.IsNullOrEmpty(textBox_answers_create_value.Text))
            {
                MessageBox.Show("Please enter a value.", "Validating");
                return false;
            } else if(!radioButton_answers_create_false.Checked && !radioButton_answers_create_true.Checked)
            {
                MessageBox.Show("Please select a validation.", "Validating");
                return false;
            }

            return true;
        }

        private void button_questions_create_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string value = textBox_answers_create_value.Text;
                bool validation = radioButton_answers_create_true.Checked;

                Question question = UserInterface.globals.sessionSelectedQuestion;

                question.AddAnswer(new Question.Answer(value, validation));
                question.updated_at = DateTime.Now;

                Evaluation evaluation = UserInterface.globals.sessionSelectedEvaluation;
                EvaluationInterface evaluationInterface = new EvaluationInterface();
                evaluationInterface.updateEvaluation(evaluation);

                textBox_answers_create_value.Text = String.Empty;
                radioButton_answers_create_false.Checked = false;
                radioButton_answers_create_true.Checked = false;

                MessageBox.Show("Answer created successfully.", "Success");
            }
        }
    }
}
