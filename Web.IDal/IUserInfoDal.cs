using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Model;

namespace Web.IDal
{
    public  interface IUserInfoDal
    {
        int Add(UserInfo  userInfo);
        int Del(int Id);
        int Update(UserInfo  userInfo);
        List<UserInfo> GetAll();
        List<UserInfo> GetAll(int id);


    }
}
