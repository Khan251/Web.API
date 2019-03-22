using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.IDal;
using Web.Model;
using Web.SqlDal;
using Web.Fac;


namespace Web.Bll
{
   public class EmpBll
    {
        IStudentDal dal = Factory.Create<IStudentDal>("StudentDal");
        public int Add(Student stu)
        {
            return dal.Add(stu);
        }

        IDal.IUserInfoDal userInfoDal = Factory.Create<IUserInfoDal>("Emp._UserInfo");
        public int AddUserInfo(UserInfo userInfo) {
            return userInfoDal.Add(userInfo);

        }

        public int DelUserInfo(int id ) {
            return userInfoDal.Del(id);
        }





    }
}
