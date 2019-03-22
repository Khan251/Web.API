using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.IDal;
using Web.Model;

namespace Web.SqlDal
{
    public class StudentDal : IDal.IStudentDal
    {
        public int Add(Student stu)
        {
            return 100;
        }

        public int Del(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Student stu)
        {
            throw new NotImplementedException();
        }
    }
}
