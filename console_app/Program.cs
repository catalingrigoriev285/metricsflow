using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    internal class Program
    {
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1. Add User");
                Console.WriteLine("2. Show Users");
                Console.WriteLine("3. Search User");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        ShowUsers();
                        break;
                    case "3":
                        SearchUser();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddUser()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Role: ");
            string role = Console.ReadLine();

            users.Add(new User(id, name, email, password, role, null));

            Console.WriteLine("User added successfully!");
        }

        static void ShowUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users found.");
                return;
            }

            Console.WriteLine("\nUser List:");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }

        static void SearchUser()
        {
            Console.Write("Enter search term (name/email/role): ");
            string searchTerm = Console.ReadLine().ToLower();

            var foundUsers = users.Where(u =>
                u.name.ToLower().Contains(searchTerm) ||
                u.email.ToLower().Contains(searchTerm) ||
                u.role.ToLower().Contains(searchTerm)).ToList();

            if (foundUsers.Count == 0)
            {
                Console.WriteLine("No matching users found.");
                return;
            }

            Console.WriteLine("\nSearch Results:");
            foreach (var user in foundUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}
