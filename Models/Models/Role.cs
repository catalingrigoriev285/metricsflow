using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public Role(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Role: {name}, Description: {description}, Created At: {created_at}, Updated At: {updated_at}";
        }
    }
}
