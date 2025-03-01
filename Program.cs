using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metricsflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(1, "Technical Assessment");
            test.AddQuestion("What is OOP?", 1);
            test.AddQuestion("What is C#?", 2);

            Employee emp = new Employee(101, "John Doe");
            emp.SubmitAnswer(0, 1);
            emp.SubmitAnswer(1, 2);

            emp.TakeTest(test);
        }
    }
}
