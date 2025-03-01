using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metricsflow
{
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
