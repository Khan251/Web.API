using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Model;
using Web.IDal;
using Web.Fac;

namespace Web.Bll
{
    public class StudentBll
    {
        IStudentDal dal = Factory.Create<IStudentDal>("StudentDal");
        public int Add(Student stu)
        {
            return dal.Add(stu);
        }
    }
}
