using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Resources.Employee.Evaluations
{
    public partial class EvaluationPending : Form
    {
        private Models.Evaluation _evaluation;
        private Dictionary<RadioButton, Models.Question.Answer> answerMap = new Dictionary<RadioButton, Models.Question.Answer>();

        public EvaluationPending()
        {
            this.MaximizeBox = false;
            InitializeComponent();

            this._evaluation = UserInterface.globals.sessionSelectedEvaluation;
        }

        private void EvaluationPending_Load(object sender, EventArgs e)
        {
            this.Text = "Evaluation Pending - " + _evaluation.title;

            this.label_evaluation_title.Text = "[ " + _evaluation.title + " ]";
            this.label_evaluation_desc.Text = _evaluation.description;

            foreach (Models.Question question in _evaluation.questions)
            {
                Panel questionContainer = new Panel();
                questionContainer.AutoSize = true;
                questionContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                questionContainer.Margin = new Padding(0, 10, 0, 10);

                FlowLayoutPanel questionPanel = new FlowLayoutPanel();
                questionPanel.FlowDirection = FlowDirection.TopDown;
                questionPanel.WrapContents = false;
                questionPanel.AutoSize = true;
                questionPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

                Label questionLabel = new Label();
                questionLabel.Text = question.title;
                questionLabel.AutoSize = true;
                questionLabel.Font = new Font("Arial", 10, FontStyle.Bold);
                questionPanel.Controls.Add(questionLabel);

                if (!string.IsNullOrEmpty(question.description))
                {
                    Label questionDescLabel = new Label();
                    questionDescLabel.Text = question.description;
                    questionDescLabel.AutoSize = true;
                    questionPanel.Controls.Add(questionDescLabel);
                }

                foreach (Models.Question.Answer answer in question.answers)
                {
                    RadioButton answerRadioButton = new RadioButton();
                    answerRadioButton.Text = answer.value;
                    answerRadioButton.AutoSize = true;

                    // Save mapping
                    answerMap[answerRadioButton] = answer;

                    questionPanel.Controls.Add(answerRadioButton);
                }

                questionContainer.Controls.Add(questionPanel);

                this.flowLayoutPanel_questions.Controls.Add(questionContainer);
            }
        }

        private void button_evaluation_submit_Click(object sender, EventArgs e)
        {
            foreach (var entry in answerMap)
            {
                RadioButton radioButton = entry.Key;
                Models.Question.Answer answer = entry.Value;

                // Default color
                radioButton.ForeColor = SystemColors.ControlText;

                if (answer.validation)
                {
                    // Correct answer - mark green
                    radioButton.ForeColor = Color.Green;
                }

                if (radioButton.Checked && !answer.validation)
                {
                    // Selected but incorrect - mark red
                    radioButton.ForeColor = Color.Red;
                }
            }

            int correctCount = answerMap.Count(entry => entry.Key.Checked && entry.Value.validation);
            MessageBox.Show($"You have answered {correctCount} correct questions!", "Evaluation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
