using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseManagement.FileSystem
{
    public class EvaluationInterface
    {
        string file_path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\data\\evaluations.txt";

        List<Evaluation> evaluations = new List<Evaluation>();

        public void saveEvaluation(Evaluation evaluation)
        {
            if (evaluation == null)
            {
                throw new ArgumentNullException(nameof(evaluation), "Evaluation cannot be null");
            }
            if (evaluation.id == null)
            {
                throw new ArgumentException("Evaluation ID cannot be null or empty", nameof(evaluation.id));
            }
            else if (evaluation.title == null)
            {
                throw new ArgumentException("Evaluation name cannot be null or empty", nameof(evaluation.title));
            }
            else if (evaluation.description == null)
            {
                throw new ArgumentException("Evaluation description cannot be null or empty", nameof(evaluation.description));
            }
            //else if (evaluation.questions == null)
            //{
            //    throw new ArgumentException("Evaluation questions cannot be null or empty", nameof(evaluation.questions));
            //}

            string directoryPath = Path.GetDirectoryName(file_path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (StreamWriter writer = new StreamWriter(file_path, true))
            {
                writer.WriteLine($"{evaluation.id},{evaluation.title},{evaluation.description},{(int)evaluation.type},{evaluation.user_id}");
                
                if(evaluation.questions != null)
                {
                    foreach (var question in evaluation.questions)
                    {
                        writer.WriteLine($"{question.id},{question.title},{question.description}");
                        foreach (var answer in question.answers)
                        {
                            writer.WriteLine($"{answer.value},{answer.validation}");
                        }
                    }
                }

                writer.WriteLine("\n");
            }
        }

        public List<Evaluation> loadEvaluations()
        {
            if (!File.Exists(file_path))
            {
                return new List<Evaluation>();
            }

            using (StreamReader reader = new StreamReader(file_path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    string[] evaluationData = line.Split(',');
                    if (evaluationData.Length < 5)
                    {
                        throw new FormatException("Invalid evaluation data format.");
                    }
                    Evaluation evaluation = new Evaluation(evaluationData[1], evaluationData[2])
                    {
                        id = int.Parse(evaluationData[0]),
                        type = Enum.Parse<Evaluation.EvaluationType>(evaluationData[3]),
                        user_id = int.Parse(evaluationData[4]),
                    };
                    while ((line = reader.ReadLine()) != null && !string.IsNullOrWhiteSpace(line))
                    {
                        string[] questionData = line.Split(',');
                        if (questionData.Length < 3)
                        {
                            throw new FormatException("Invalid question data format.");
                        }
                        Question question = new Question(questionData[1], questionData[2])
                        {
                            id = int.Parse(questionData[0])
                        };
                        while ((line = reader.ReadLine()) != null && !string.IsNullOrWhiteSpace(line))
                        {
                            string[] answerData = line.Split(',');
                            if (answerData.Length < 2)
                            {
                                throw new FormatException("Invalid answer data format.");
                            }
                            Question.Answer answer = new Question.Answer(answerData[0], bool.Parse(answerData[1]));
                            question.AddAnswer(answer);
                        }
                        evaluation.AddQuestion(question);
                    }
                    evaluations.Add(evaluation);
                }
            }

            return evaluations;
        }

        public void destroyEvaluation(Evaluation evaluation)
        {
            if (evaluation == null)
            {
                throw new ArgumentNullException(nameof(evaluation), "Evaluation cannot be null");
            }
            List<Evaluation> evaluations = loadEvaluations();
            evaluations.RemoveAll(e => e.id == evaluation.id);
            using (StreamWriter writer = new StreamWriter(file_path, false))
            {
                foreach (Evaluation e in evaluations)
                {
                    writer.WriteLine($"{e.id},{e.title},{e.description}");
                    foreach (var question in e.questions)
                    {
                        writer.WriteLine($"{question.id},{question.title},{question.description}");
                        foreach (var answer in question.answers)
                        {
                            writer.WriteLine($"{answer.value},{answer.validation}");
                        }
                    }
                    writer.WriteLine("\n");
                }
            }
        }
    }
}
