﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metricsflow
{
    public class Test
    {
        public int TestId { get; set; }
        public string Title { get; set; }
        public List<string> Questions { get; set; }
        public Dictionary<int, int> CorrectAnswers { get; set; }

        public Test(int testId, string title)
        {
            TestId = testId;
            Title = title;
            Questions = new List<string>();
            CorrectAnswers = new Dictionary<int, int>();
        }

        public void AddQuestion(string question, int correctOptionIndex)
        {
            int questionId = Questions.Count;
            Questions.Add(question);
            CorrectAnswers[questionId] = correctOptionIndex;
        }

        public bool Evaluate(Dictionary<int, int> employeeAnswers)
        {
            int score = 0;
            foreach (var answer in employeeAnswers)
            {
                if (CorrectAnswers.ContainsKey(answer.Key) && CorrectAnswers[answer.Key] == answer.Value)
                {
                    score++;
                }
            }
            Console.WriteLine($"Score: {score}/{Questions.Count}");
            return true;
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public Dictionary<int, int> Answers { get; set; }

        public Employee(int employeeId, string name)
        {
            EmployeeId = employeeId;
            Name = name;
            Answers = new Dictionary<int, int>();
        }

        public void SubmitAnswer(int questionId, int optionIndex)
        {
            Answers[questionId] = optionIndex;
        }

        public void TakeTest(Test test)
        {
            test.Evaluate(Answers);
        }
    }
}
