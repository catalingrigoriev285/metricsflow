﻿using System;
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

        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public User() { }

        public User(string name, string prename, string email, Role role)
        {
            this.name = name;
            this.prename = prename;
            this.email = email;
            this.role = role;
            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
        }

        public override string ToString()
        {
            return $"User: {name} {prename}, Email: {email}, Role: {role.name}, Created At: {created_at}, Updated At: {updated_at}";
        }

        public string display()
        {
            return $"{id}, {name} {prename}, Email: {email}, Role: {role.name}, Created At: {created_at}, Updated At: {updated_at}";
        }

        public void setPassword(string password)
        {
            this.password = password;
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
            this.created_at = DateTime.MinValue;
            this.updated_at = DateTime.MinValue;
        }
    }
}
