using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Model;

namespace Web.IDal
{
    public interface IStudentDal
    {
        int Add(Student stu);
        int Del(int Id);
        int Update(Student stu);
        List<Student> GetAll();
    }
}
