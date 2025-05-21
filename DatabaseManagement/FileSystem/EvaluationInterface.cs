using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseManagement.Interfaces;
using Models;

namespace DatabaseManagement.FileSystem
{
    public class EvaluationInterface : IEvaluationInterface
    {
        private readonly string _filePath;
        private readonly string _directoryPath;

        public EvaluationInterface()
        {
            _directoryPath = Path.Combine(
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,
                "data"
            );
            _filePath = Path.Combine(_directoryPath, "evaluations.txt");
            EnsureDirectoryExists();
        }

        private void EnsureDirectoryExists()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
        }

        private void WriteEvaluationsToFile(List<Evaluation> evaluations, bool append = false)
        {
            try
            {
                using var writer = new StreamWriter(_filePath, append);
                foreach (var eval in evaluations)
                {
                    // Write evaluation header
                    writer.WriteLine($"EVAL|{eval.id}|{eval.title}|{eval.description}|{(int)eval.type}|{eval.user_id}|{eval.created_at:yyyy-MM-dd HH:mm:ss}|{eval.updated_at:yyyy-MM-dd HH:mm:ss}");

                    if (eval.questions != null)
                    {
                        foreach (var question in eval.questions)
                        {
                            // Write question
                            writer.WriteLine($"Q|{question.id}|{question.title}|{question.description}|{question.created_at:yyyy-MM-dd HH:mm:ss}|{question.updated_at:yyyy-MM-dd HH:mm:ss}");

                            if (question.answers != null)
                            {
                                foreach (var answer in question.answers)
                                {
                                    // Write answer
                                    writer.WriteLine($"A|{answer.value}|{answer.validation}");
                                }
                            }
                        }
                    }

                    writer.WriteLine(); // Empty line to separate evaluations
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Failed to write evaluations to file: {ex.Message}", ex);
            }
        }

        public void saveEvaluation(Evaluation evaluation)
        {
            if (evaluation == null)
                throw new ArgumentNullException(nameof(evaluation), "Evaluation cannot be null");

            ValidateEvaluation(evaluation);

            evaluation.setID(GetNextEvaluationId());
            evaluation.created_at = DateTime.Now;
            evaluation.updated_at = DateTime.Now;

            WriteEvaluationsToFile(new List<Evaluation> { evaluation }, true);
        }

        private void ValidateEvaluation(Evaluation evaluation)
        {
            if (string.IsNullOrWhiteSpace(evaluation.title))
                throw new ArgumentException("Evaluation title cannot be null or empty", nameof(evaluation.title));
            if (string.IsNullOrWhiteSpace(evaluation.description))
                throw new ArgumentException("Evaluation description cannot be null or empty", nameof(evaluation.description));
            if (evaluation.user_id <= 0)
                throw new ArgumentException("User ID must be greater than zero", nameof(evaluation.user_id));
        }

        public List<Evaluation> loadEvaluations()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Evaluation>();
            }

            var evaluations = new List<Evaluation>();
            Evaluation currentEvaluation = null;
            Question currentQuestion = null;

            try
            {
                foreach (var line in File.ReadLines(_filePath))
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

                    var parts = line.Split('|');
                    if (parts.Length < 2) continue;

                    switch (parts[0])
                    {
                        case "EVAL":
                            if (currentEvaluation != null)
                            {
                                evaluations.Add(currentEvaluation);
                            }
                            currentEvaluation = ParseEvaluation(parts);
                            currentQuestion = null;
                            break;

                        case "Q":
                            if (currentEvaluation != null)
                            {
                                currentQuestion = ParseQuestion(parts);
                                currentEvaluation.AddQuestion(currentQuestion);
                            }
                            break;

                        case "A":
                            if (currentQuestion != null)
                            {
                                currentQuestion.AddAnswer(ParseAnswer(parts));
                            }
                            break;
                    }
                }

                if (currentEvaluation != null)
                {
                    evaluations.Add(currentEvaluation);
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Failed to load evaluations: {ex.Message}", ex);
            }

            return RemoveDuplicates(evaluations);
        }

        private Evaluation ParseEvaluation(string[] parts)
        {
            return new Evaluation(parts[2], parts[3])
            {
                id = int.Parse(parts[1]),
                type = (Evaluation.EvaluationType)int.Parse(parts[4]),
                user_id = int.Parse(parts[5]),
                created_at = DateTime.Parse(parts[6]),
                updated_at = DateTime.Parse(parts[7])
            };
        }

        private Question ParseQuestion(string[] parts)
        {
            return new Question(parts[2], parts[3])
            {
                id = int.Parse(parts[1]),
                created_at = DateTime.Parse(parts[4]),
                updated_at = DateTime.Parse(parts[5])
            };
        }

        private Question.Answer ParseAnswer(string[] parts)
        {
            return new Question.Answer(parts[1], bool.Parse(parts[2]));
        }

        public Evaluation getEvaluationById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero");

            var evaluation = loadEvaluations().FirstOrDefault(e => e.id == id);
            if (evaluation == null)
                throw new KeyNotFoundException($"Evaluation with ID {id} not found");

            return evaluation;
        }

        private int GetNextEvaluationId()
        {
            if (!File.Exists(_filePath))
                return 1;

            return loadEvaluations().Max(e => e.id) + 1;
        }

        public void updateEvaluation(Evaluation evaluation)
        {
            if (evaluation == null)
                throw new ArgumentNullException(nameof(evaluation), "Evaluation cannot be null");

            ValidateEvaluation(evaluation);

            var evaluations = loadEvaluations();
            var evalToUpdate = evaluations.FirstOrDefault(e => e.id == evaluation.id);

            if (evalToUpdate == null)
                throw new KeyNotFoundException($"Evaluation with ID {evaluation.id} not found");

            // Update basic properties
            evalToUpdate.title = evaluation.title;
            evalToUpdate.description = evaluation.description;
            evalToUpdate.type = evaluation.type;
            evalToUpdate.user_id = evaluation.user_id;
            evalToUpdate.updated_at = DateTime.Now;

            // Update questions
            if (evaluation.questions != null)
            {
                // Replace the entire questions list to ensure proper removal
                evalToUpdate.questions = evaluation.questions;
            }
            else
            {
                // If questions is null, clear the list
                evalToUpdate.questions = new List<Question>();
            }

            // Write to file with append=false to overwrite the entire file
            WriteEvaluationsToFile(evaluations, false);
        }

        public void destroyEvaluation(Evaluation evaluation)
        {
            if (evaluation == null)
                throw new ArgumentNullException(nameof(evaluation), "Evaluation cannot be null");

            var evaluations = loadEvaluations();
            evaluations.RemoveAll(e => e.id == evaluation.id);
            WriteEvaluationsToFile(evaluations, false);
        }

        private List<Evaluation> RemoveDuplicates(List<Evaluation> evaluations)
        {
            return evaluations
                .GroupBy(e => e.id)
                .Select(g => g.OrderByDescending(e => e.updated_at).First())
                .ToList();
        }

        public int GetNextQuestionId()
        {
            var evaluations = loadEvaluations();
            if (evaluations == null || evaluations.Count == 0)
                return 1;
            return evaluations
                .SelectMany(e => e.questions ?? new List<Question>())
                .Select(q => q.id)
                .DefaultIfEmpty(0)
                .Max() + 1;
        }

        public int getLatestID()
        {
            return GetNextEvaluationId();
        }

        public int getLatestID_Question()
        {
            return GetNextQuestionId();
        }

        public List<Evaluation> removeDuplicates(List<Evaluation> evaluations)
        {
            return RemoveDuplicates(evaluations);
        }

        public List<Question> removeQuestionsDuplicates(List<Question> questions)
        {
            if (questions == null || questions.Count == 0)
                return new List<Question>();

            return questions
                .GroupBy(q => q.id)
                .Select(g => g.OrderByDescending(q => q.updated_at).First())
                .ToList();
        }
    }
}
