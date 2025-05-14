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

        public bool enabled { get; set; } = true;

        public string created_at { get; set; }
        public string updated_at { get; set; }

        public Role() { }

        public Role(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.created_at = DateTime.Now.ToString();
            this.updated_at = DateTime.Now.ToString();
        }

        public override string ToString()
        {
            return $"{name}";
        }

        public string display()
        {
            return $"{id}, {name}, {description}, Created At: {created_at}, Updated At: {updated_at}";
        }

        public void setID(int id)
        {
            this.id = id;
        }
    }
}
