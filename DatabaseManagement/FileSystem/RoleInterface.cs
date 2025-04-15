using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseManagement.FileSystem
{
    public class RoleInterface
    {
        string file_path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\data\\roles.txt";

        List<Role> roles = new List<Role>();

        public void saveRole(Role role)
        {
            if (role == null)
            {
                throw new ArgumentNullException(nameof(role), "Role cannot be null");
            }
            if (role.name == null)
            {
                throw new ArgumentException("Role name cannot be null or empty", nameof(role.name));
            }
            else if (role.description == null)
            {
                throw new ArgumentException("Role description cannot be null or empty", nameof(role.description));
            }

            string directoryPath = Path.GetDirectoryName(file_path);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (StreamWriter writer = new StreamWriter(file_path, true))
            {
                writer.WriteLine($"{role.id},{role.name},{role.description}");
            }
        }

        public List<Role> loadRoles()
        {
            if (!File.Exists(file_path))
            {
                //throw new FileNotFoundException("The file does not exist.", file_path);
                return new List<Role>();
            }

            using (StreamReader reader = new StreamReader(file_path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length != 3)
                    {
                        throw new FormatException($"Invalid line format: {line}");
                    }
                    Role role = new Role(parts[1], parts[2]);
                    role.id = int.Parse(parts[0]);
                    roles.Add(role);
                }
            }
            return roles;
        }
    }
}
