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

            user.setID(getLatestID() + 1);

            using (StreamWriter writer = new StreamWriter(File.Open(file_path, FileMode.Append)))
            {
                writer.WriteLine($"{user.id}, {user.name},{user.prename},{user.email},{user.getPassword()},{user.role.name},{user.phone},{user.created_at},{user.updated_at}");
            }
        }

        public void updateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null");
            }
            if (string.IsNullOrWhiteSpace(user.name))
            {
                throw new ArgumentException("User name cannot be null or empty", nameof(user.name));
            }
            if (string.IsNullOrWhiteSpace(user.prename))
            {
                throw new ArgumentException("User prename cannot be null or empty", nameof(user.prename));
            }
            if (string.IsNullOrWhiteSpace(user.email))
            {
                throw new ArgumentException("User email cannot be null or empty", nameof(user.email));
            }
            if (user.role == null)
            {
                throw new ArgumentException("User role cannot be null", nameof(user.role));
            }
            if (string.IsNullOrWhiteSpace(user.created_at))
            {
                throw new ArgumentException("User created_at cannot be null or empty", nameof(user.created_at));
            }
            if (string.IsNullOrWhiteSpace(user.updated_at))
            {
                throw new ArgumentException("User updated_at cannot be null or empty", nameof(user.updated_at));
            }

            List<User> users = loadUsers();
            int index = users.FindIndex(u => u.id == user.id);
            if (index == -1)
            {
                throw new KeyNotFoundException($"User with ID {user.id} not found");
            }

            users[index].name = user.name;
            users[index].prename = user.prename;
            users[index].email = user.email;
            users[index].setPassword(user.getPassword());
            users[index].role = user.role;
            users[index].phone = user.phone;
            users[index].created_at = user.created_at;
            users[index].updated_at = DateTime.UtcNow.ToString("o");

            users = removeDuplicates(users);

            using (StreamWriter writer = new StreamWriter(file_path, false))
            {
                foreach (User u in users)
                {
                    writer.WriteLine($"{u.id},{u.name},{u.prename},{u.email},{u.getPassword()},{u.role.name},{u.phone},{u.created_at},{u.updated_at}");
                }
            }
        }

        public int getLatestID()
        {
            if (!File.Exists(file_path))
            {
                throw new FileNotFoundException($"File not found: {file_path}");
            }
            using (StreamReader reader = new StreamReader(file_path))
            {
                string line;
                int latestID = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length > 0 && int.TryParse(parts[0], out int id))
                    {
                        latestID = Math.Max(latestID, id);
                    }
                }
                return latestID;
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
                    if (parts.Length != 9)
                    {
                        throw new FormatException($"Invalid line format: {line}");
                    }
                    try
                    {
                        User user = new User(parts[1].Trim(), parts[2].Trim(), parts[3].Trim(), new Role(parts[5].Trim(), ""));
                        user.setID(int.Parse(parts[0].Trim()));
                        user.setPassword(parts[4].Trim(), false);
                        user.phone = parts[6].Trim();
                        user.created_at = parts[7].Trim();
                        user.updated_at = parts[8].Trim();
                        users.Add(user);
                    }
                    catch (Exception ex)
                    {
                        throw new FormatException($"Error parsing line: {line}. Details: {ex.Message}");
                    }
                }
            }
            return users;
        }

        public User getUserById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than 0", nameof(id));
            }
            List<User> users = loadUsers();
            User user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                throw new KeyNotFoundException($"User with ID {id} not found");
            }
            return user;
        }

        public void destroyUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null");
            }
            List<User> users = loadUsers();
            User userToDelete = users.FirstOrDefault(u => u.id == user.id);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);
                using (StreamWriter writer = new StreamWriter(File.Open(file_path, FileMode.Create)))
                {
                    foreach (User u in users)
                    {
                        writer.WriteLine($"{u.id}, {u.name},{u.prename},{u.email},{u.getPassword()},{u.role.name},{u.phone},{u.created_at},{u.updated_at}");
                    }
                }
            }
        }

        public bool auth(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
            {
                //throw new ArgumentException("Email cannot be null or empty", nameof(email));
                return false;
            }
            else if (string.IsNullOrEmpty(password))
            {
                //throw new ArgumentException("Password cannot be null or empty", nameof(password));
                return false;
            }

            List<User> users = loadUsers();
            User user = users.FirstOrDefault(u => u.email == email && u.getPassword() == password);
            return user != null;
        }

        public List<User> removeDuplicates(List<User> users)
        {
            List<User> uniqueUsers = new List<User>();
            HashSet<int> seenIDs = new HashSet<int>();
            foreach (User user in users)
            {
                if (!seenIDs.Contains(user.id))
                {
                    uniqueUsers.Add(user);
                    seenIDs.Add(user.id);
                }
            }
            return uniqueUsers;
        }
    }
}
