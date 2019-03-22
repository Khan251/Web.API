using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Model;

namespace Web.IDal
{
    public interface IRoleInfoDal
    {

        int Add(RoleInfo roleInfo);
        int Del(int Id);
        int Update(RoleInfo roleInfo);
        List<RoleInfo> GetAll();
        List<RoleInfo> GetAll(int id);
    }
}
