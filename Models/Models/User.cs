using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public int id { get; set; }

        public string name { get; set; }
        public string prename { get; set; }

        public string email { get; set; }

        private string password { get; set; }

        public string phone { get; set; }

        public Role role { get; set; }

        public string created_at { get; set; }
        public string updated_at { get; set; }

        public User() { }

        public User(string name, string prename, string email, Role role)
        {
            this.name = name;
            this.prename = prename;
            this.email = email;
            this.role = role;
            this.created_at = DateTime.Now.ToString();
            this.updated_at = DateTime.Now.ToString();
        }

        public override string ToString()
        {
            return $"User: {name} {prename}, Email: {email}, Role: {role.name}, Created At: {created_at}, Updated At: {updated_at}";
        }

        public string display()
        {
            return $"{id}, {name} {prename}, Email: {email}, Role: {role.name}, Created At: {created_at}, Updated At: {updated_at}";
        }

        public string getRole()
        {
            return this.role?.name ?? "undefined";
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public void setPassword(string password, bool hashing = true)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password cannot be null or empty", nameof(password));
            }

            if (hashing)
            {
                Models.Encryption encryption = new Models.Encryption(password);
                this.password = encryption.ToString();
            }
            else
            {
                this.password = password;
            }
        }

        public string getPassword()
        {
            return this.password;
        }

        public void destroy()
        {
            this.name = null;
            this.prename = null;
            this.email = null;
            this.password = null;
            this.phone = null;
            this.role = null;
            this.created_at = DateTime.MinValue.ToString();
            this.updated_at = DateTime.MinValue.ToString();
        }
    }
}
