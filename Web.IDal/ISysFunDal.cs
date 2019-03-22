using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Model;

namespace Web.IDal
{
   public    interface ISysFunDal
    {
        int Add(SysFun  sysFun);
        int Del(int Id);
        int Update(SysFun  sysFun);
        List<SysFun> GetAll();
        List<SysFun> GetAll(int id);
    }
}
