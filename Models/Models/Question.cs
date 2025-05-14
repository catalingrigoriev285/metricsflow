using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Question
    {
        public struct Answer
        {
            public string value { get; set; }
            public bool validation { get; set; }

            public Answer(string value, bool validation)
            {
                this.value = value;
                this.validation = validation;
            }

            public override string ToString()
            {
                return $"Answer: {value}, Valid: {validation}";
            }
        }

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public List<Answer> answers { get; set; }

        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public Question(string title, string description, List<Answer> answers = null)
        {
            this.title = title;
            this.description = description;

            this.answers = answers;

            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Question: {title}, Description: {description}, Created At: {created_at}, Updated At: {updated_at}";
        }

        public void AddAnswer(Answer answer)
        {
            if (answers == null)
            {
                answers = new List<Answer>();
            }
            answers.Add(answer);
        }

        public void RemoveAnswer(Answer answer)
        {
            if (answers != null)
            {
                answers.Remove(answer);
            }
        }
    }
}
