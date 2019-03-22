using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Model;

namespace Web.IDal
{
   public  interface IUserRoleDal
    {
        int Add(UserRole  userRole);
        int Del(int Id);
        int Update(UserRole  userRole);
        List<UserRole> GetAll();
        List<UserRole> GetAll(int id);
    }
}
