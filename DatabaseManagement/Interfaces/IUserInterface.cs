using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseManagement.Interfaces
{
    interface IUserInterface
    {
        public void saveUser(User user);
        public void updateUser(User user);
        public int getLatestID();
        public List<User> loadUsers();
        public User getUserById(int id);
        public User getUserByName(string name);
        public void destroyUser(User user);
        public bool auth(string email, string password);
        public List<User> removeDuplicates(List<User> users);
    }
}
