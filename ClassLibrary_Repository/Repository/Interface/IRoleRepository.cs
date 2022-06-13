using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;

namespace ClassLibrary_RepositoryDLL.Repository.Interface
{
    public interface IRoleRepository
    {
        List<Role> getAllRole();
        void AddRole (Role newrole);
        bool UpdateRole (Role newrole);
        bool DeleteRole(int roleId);
        Role getRole(int roleId);
    }
}
