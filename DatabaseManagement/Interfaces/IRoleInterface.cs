using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseManagement.Interfaces
{
    public interface IRoleInterface
    {
        public void saveRole(Role role);
        public void updateRole(Role role);
        public int getLatestID();
        public List<Role> loadRoles();
        public Role getRoleById(int id);
        public Role getRoleByName(string name);
        public void destroyRole(Role role);
        public List<Role> removeDuplicates(List<Role> roles);
    }
}
