using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using Models;
using System.IO;

namespace DatabaseManagement.FileSystem
{
    public class UserInterface
    {
        //string file_path = AppDomain.CurrentDomain.BaseDirectory + "\\" + ConfigurationManager.AppSettings["users_path"];
        string file_path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\data\\users.txt";

        List<User> users = new List<User>();

        public void saveUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null");
            }

            if (user.name == null)
            {
                throw new ArgumentException("User name cannot be null or empty", nameof(user.name));
            }
            else if (user.prename == null)
            {
                throw new ArgumentException("User prename cannot be null or empty", nameof(user.prename));
            }
            else if (user.email == null)
            {
                throw new ArgumentException("User email cannot be null or empty", nameof(user.email));
            }
            else if (user.role == null)
            {
                throw new ArgumentException("User role cannot be null or empty", nameof(user.role));
            }
            //else if (user.phone == null)
            //{
            //    throw new ArgumentException("User phone cannot be null or empty", nameof(user.phone));
            //}
            else if (user.created_at == null)
            {
                throw new ArgumentException("User created_at cannot be null or empty", nameof(user.created_at));
            }
            else if (user.updated_at == null)
            {
                throw new ArgumentException("User updated_at cannot be null or empty", nameof(user.updated_at));
            }

            string directoryPath = Path.GetDirectoryName(file_path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (StreamWriter writer = new StreamWriter(File.Open(file_path, FileMode.Append)))
            {
                writer.WriteLine($"{user.name},{user.prename},{user.email},{user.role.name},{user.phone},{user.created_at},{user.updated_at}");
            }
        }

        public List<User> loadUsers()
        {
            if (!File.Exists(file_path))
            {
                throw new FileNotFoundException($"File not found: {file_path}");
            }
            using (StreamReader reader = new StreamReader(file_path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length != 7)
                    {
                        throw new FormatException($"Invalid line format: {line}");
                    }
                    User user = new User(parts[0], parts[1], parts[2], new Role(parts[3], ""));
                    user.phone = parts[4];
                    user.created_at = DateTime.Parse(parts[5]);
                    user.updated_at = DateTime.Parse(parts[6]);
                    users.Add(user);
                }
            }
            return users;
        }
    }
}
