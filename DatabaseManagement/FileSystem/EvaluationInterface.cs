using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseManagement.Interfaces;
using Models;

namespace DatabaseManagement.FileSystem
{
    public class EvaluationInterface : IEvaluationInterface
    {
        string file_path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\data\\evaluations.txt";

        List<Evaluation> evaluations = new List<Evaluation>();

        private void WriteEvaluationsToFile(List<Evaluation> evaluations, bool append = false)
        {
            using (StreamWriter writer = new StreamWriter(file_path, append))
            {
                foreach (var eval in evaluations)
                {
                    writer.WriteLine($"{eval.id},{eval.title},{eval.description},{(int)eval.type},{eval.user_id}");

                    if (eval.questions != null)
                    {
                        foreach (var question in eval.questions)
                        {
                            writer.WriteLine($"{question.id},{question.title},{question.description},{question.created_at},{question.updated_at}");

                            if (question.answers != null)
                            {
                                foreach (var answer in question.answers)
                                {
                                    writer.WriteLine($"{answer.value},{answer.validation}");
                                }
                            }
                        }
                    }

                    writer.WriteLine(); // Empty line to separate evaluations
                }
            }
        }

        public void saveEvaluation(Evaluation evaluation)
        {
            if (evaluation == null)
                throw new ArgumentNullException(nameof(evaluation), "Evaluation cannot be null");
            if (evaluation.id == null)
                throw new ArgumentException("Evaluation ID cannot be null or empty", nameof(evaluation.id));
            if (evaluation.title == null)
                throw new ArgumentException("Evaluation title cannot be null or empty", nameof(evaluation.title));
            if (evaluation.description == null)
                throw new ArgumentException("Evaluation description cannot be null or empty", nameof(evaluation.description));

            string directoryPath = Path.GetDirectoryName(file_path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            evaluation.setID(getLatestID() + 1);
            WriteEvaluationsToFile(new List<Evaluation> { evaluation }, true);
        }

        public List<Evaluation> loadEvaluations()
        {
            if (!File.Exists(file_path))
            {
                return new List<Evaluation>();
            }

            evaluations.Clear(); // Clear any previously loaded evaluations

            using (StreamReader reader = new StreamReader(file_path))
            {
                string? line;
                Evaluation? currentEvaluation = null;
                Question? currentQuestion = null;

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        if (currentEvaluation != null)
                        {
                            evaluations.Add(currentEvaluation);
                            currentEvaluation = null;
                            currentQuestion = null;
                        }
                        continue;
                    }

                    string[] parts = line.Split(',');

                    // Evaluation line
                    if (parts.Length == 5 && int.TryParse(parts[0], out int evalId) && Enum.TryParse<Evaluation.EvaluationType>(parts[3], out _))
                    {
                        if (currentEvaluation != null)
                        {
                            evaluations.Add(currentEvaluation);
                        }

                        currentEvaluation = new Evaluation(parts[1], parts[2])
                        {
                            id = evalId,
                            type = Enum.Parse<Evaluation.EvaluationType>(parts[3]),
                            user_id = int.Parse(parts[4])
                        };

                        currentQuestion = null;
                    }
                    // Question line (5 parts: id, title, description, created_at, updated_at)
                    else if (parts.Length == 5 && int.TryParse(parts[0], out int questionId) && DateTime.TryParse(parts[3], out DateTime createdAt) && DateTime.TryParse(parts[4], out DateTime updatedAt))
                    {
                        currentQuestion = new Question(parts[1], parts[2])
                        {
                            id = questionId,
                            created_at = createdAt,
                            updated_at = updatedAt
                        };

                        currentEvaluation?.AddQuestion(currentQuestion);
                    }
                    // Answer line (2 parts)
                    else if (parts.Length == 2 && currentQuestion != null)
                    {
                        bool isValid = bool.TryParse(parts[1], out bool validation) && validation;
                        currentQuestion.AddAnswer(new Question.Answer(parts[0], isValid));
                    }
                    else
                    {
                        throw new FormatException($"Unrecognized line format: {line}");
                    }
                }

                if (currentEvaluation != null)
                {
                    evaluations.Add(currentEvaluation);
                }
            }

            evaluations = removeDuplicates(evaluations);

            foreach (var evaluation in evaluations)
            {
                if (evaluation.questions != null)
                {
                    evaluation.questions = removeQuestionsDuplicates(evaluation.questions);
                }
            }

            return evaluations;
        }

        public Evaluation getEvaluationById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero.");
            }
            List<Evaluation> evaluations = loadEvaluations();
            Evaluation? evaluation = evaluations.FirstOrDefault(e => e.id == id);
            if (evaluation == null)
            {
                throw new KeyNotFoundException($"Evaluation with ID {id} not found.");
            }
            return evaluation;
        }

        public int getLatestID()
        {
            if (!File.Exists(file_path))
            {
                return 0;
            }
            using (StreamReader reader = new StreamReader(file_path))
            {
                string? line;
                int latestID = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    string[] data = line.Split(',');

                    // Ensure the line corresponds to an Evaluation entry (5 parts and valid type)  
                    if (data.Length == 5 && Enum.TryParse<Evaluation.EvaluationType>(data[3], out _))
                    {
                        if (int.TryParse(data[0], out int currentID) && currentID > latestID)
                        {
                            latestID = currentID;
                        }
                    }
                }
                return latestID;
            }
        }

        public int getLatestID_Question()
        {
            if (!File.Exists(file_path))
            {
                return 0;
            }
            using (StreamReader reader = new StreamReader(file_path))
            {
                string? line;
                int latestID = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }
                    string[] questionData = line.Split(',');
                    int currentID = int.Parse(questionData[0]);
                    if (currentID > latestID)
                    {
                        latestID = currentID;
                    }
                }
                return latestID;
            }
        }

        public void updateEvaluation(Evaluation evaluation)
        {
            if (evaluation == null)
                throw new ArgumentNullException(nameof(evaluation), "Evaluation cannot be null");

            List<Evaluation> evaluations = loadEvaluations();
            Evaluation? evalToUpdate = evaluations.FirstOrDefault(e => e.id == evaluation.id);

            if (evalToUpdate != null)
            {
                evalToUpdate.title = evaluation.title;
                evalToUpdate.description = evaluation.description;
                evalToUpdate.type = evaluation.type;
                evalToUpdate.user_id = evaluation.user_id;
                evalToUpdate.questions = evaluation.questions;

                WriteEvaluationsToFile(evaluations, false);
            }
        }

        public void destroyEvaluation(Evaluation evaluation)
        {
            if (evaluation == null)
                throw new ArgumentNullException(nameof(evaluation), "Evaluation cannot be null");

            List<Evaluation> evaluations = loadEvaluations();
            evaluations.RemoveAll(e => e.id == evaluation.id);

            WriteEvaluationsToFile(evaluations, false);
        }

        public List<Evaluation> removeDuplicates(List<Evaluation> evaluations)
        {
            List<Evaluation> uniqueEvaluations = new List<Evaluation>();
            foreach (var evaluation in evaluations)
            {
                if (!uniqueEvaluations.Any(e => e.id == evaluation.id))
                {
                    uniqueEvaluations.Add(evaluation);
                }
            }
            return uniqueEvaluations;
        }

        public List<Question> removeQuestionsDuplicates(List<Question> questions)
        {
            return questions
                .OrderByDescending(q => q.created_at)
                .GroupBy(q => q.id)
                .Select(g => g.First())
                .ToList();
        }
    }
}
