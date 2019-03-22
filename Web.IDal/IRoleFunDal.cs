using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Model;

namespace Web.IDal
{
    public interface IRoleFunDal
    {
        int Add(RoleFun  roleFun);
        int Del(int Id);
        int Update(RoleFun  roleFun);
        List<RoleFun> GetAll();
        List<RoleFun> GetAll(int id);

    }
}
