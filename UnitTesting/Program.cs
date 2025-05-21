// for Evaluation

using Models;

Evaluation evaluation = new Evaluation();
evaluation.title = "Unit Testing";
evaluation.description = "description";
evaluation.type = Evaluation.EvaluationType.CriterionReferenced;

evaluation.setID(2);
evaluation.user_id = 4;

evaluation.questions = new List<Question>();

Question question1 = new Question("question 2", "question desc 2");
Question.Answer answer1 = new Question.Answer("answer 1", true);
Question.Answer answer2 = new Question.Answer("answer 2", false);

question1.AddAnswer(answer1);
question1.AddAnswer(answer2);

evaluation.questions.Add(question1);

DatabaseManagement.FileSystem.EvaluationInterface evaluationInterface = new DatabaseManagement.FileSystem.EvaluationInterface();
evaluationInterface.saveEvaluation(evaluation);

Console.WriteLine("Evaluation saved to file.");