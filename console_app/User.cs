using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace console_app
{
    internal class User
    {
        public static readonly string[] Roles = { "Admin", "Employee" };

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string password_hash { get; set; }

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Email: {email}, Role: {role}";
        }

        public User(int id, string name = "undefined", string email = "undefined", string password = "undefined", string role = "undefined", string password_hash = "undefined")
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
            this.password_hash = password_hash;
        }
    }
}
