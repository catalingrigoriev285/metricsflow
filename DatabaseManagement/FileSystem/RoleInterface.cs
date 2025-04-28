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

            role.setID(getLatestID() + 1);

            role.created_at = DateTime.UtcNow.ToString("o");
            role.updated_at = DateTime.UtcNow.ToString("o");

            using (StreamWriter writer = new StreamWriter(file_path, true))
            {
                writer.WriteLine($"{role.id},{role.name},{role.description}, {role.created_at}, {role.updated_at}");
            }
        }

        public void updateRole(Role role)
        {
            if (role == null)
            {
                throw new ArgumentNullException(nameof(role), "Role cannot be null");
            }
            if (string.IsNullOrWhiteSpace(role.name))
            {
                throw new ArgumentException("Role name cannot be null or empty", nameof(role.name));
            }
            if (string.IsNullOrWhiteSpace(role.description))
            {
                throw new ArgumentException("Role description cannot be null or empty", nameof(role.description));
            }

            List<Role> roles = loadRoles();
            int index = roles.FindIndex(r => r.id == role.id);
            if (index == -1)
            {
                throw new KeyNotFoundException($"Role with ID {role.id} not found");
            }

            roles[index].name = role.name;
            roles[index].description = role.description;
            roles[index].updated_at = DateTime.UtcNow.ToString("o");

            roles = removeDuplicates(roles);

            foreach (Role r in roles)
            {
                Console.WriteLine(r.display());
            }

            using (StreamWriter writer = new StreamWriter(file_path, false))
            {
                foreach (Role r in roles)
                {
                    writer.WriteLine($"{r.id},{r.name},{r.description},{r.created_at},{r.updated_at}");
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

        public List<Role> loadRoles()
        {
            if (!File.Exists(file_path))
            {
                return new List<Role>();
            }

            using (StreamReader reader = new StreamReader(file_path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length != 5)
                    {
                        throw new FormatException($"Invalid line format: {line}");
                    }

                    Role role = new Role(parts[1], parts[2])
                    {
                        id = int.Parse(parts[0]),
                        created_at = parts[3],
                        updated_at = parts[4]
                    };
                    roles.Add(role);
                }
            }

            roles = removeDuplicates(roles);

            return roles;
        }

        public Role getRoleById(int id)
        {
            List<Role> roles = loadRoles();
            return roles.FirstOrDefault(r => r.id == id);
        }

        public void destroyRole(Role role)
        {
            if (role == null)
            {
                throw new ArgumentNullException(nameof(role), "Role cannot be null");
            }
            List<Role> roles = loadRoles();
            roles.RemoveAll(r => r.id == role.id);
            using (StreamWriter writer = new StreamWriter(file_path, false))
            {
                foreach (Role r in roles)
                {
                    writer.WriteLine($"{r.id},{r.name},{r.description}");
                }
            }
        }

        public List<Role> removeDuplicates(List<Role> roles)
        {
            Dictionary<int, Role> latestRoles = new Dictionary<int, Role>();

            foreach (var role in roles)
            {
                if (!latestRoles.ContainsKey(role.id) ||
                    DateTime.Parse(role.updated_at) > DateTime.Parse(latestRoles[role.id].updated_at))
                {
                    latestRoles[role.id] = role;
                }
            }

            return latestRoles.Values.ToList();
        }
    }
}
