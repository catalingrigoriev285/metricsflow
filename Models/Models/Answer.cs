using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Answer
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
}
