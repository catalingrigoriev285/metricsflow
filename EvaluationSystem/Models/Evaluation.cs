using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSystem.Models
{
    public class Evaluation
    {
        public enum EvaluationType
        {
            Formative,
            Summative,
            Diagnostic,
            Normative,
            CriterionReferenced,
            Ipsative,
            Peer,
            Self,
            Authentic,
            Performance,
            Portfolio,
        }

        public int id { get; set; }

        public string title { get; set; }
        public string description { get; set; }

        public int user_id { get; set; }

        public EvaluationType type { get; set; }

        public List<Question> questions { get; set; }

        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public Evaluation(string title, string description)
        {
            this.title = title;
            this.description = description;
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Evaluation: {title}, Description: {description}, Created At: {created_at}, Updated At: {updated_at}";
        }

        public void AddQuestion(Question question)
        {
            if (questions == null)
            {
                questions = new List<Question>();
            }
            questions.Add(question);
        }

        public void RemoveQuestion(Question question)
        {
            if (questions != null)
            {
                questions.Remove(question);
            }
        }
    }
}
