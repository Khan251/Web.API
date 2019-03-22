using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.IDal;
using System.Reflection;
using System.Configuration;
using System.Web;
using System.IO;

namespace Web.Fac
{
    public class Factory
    {
        public static T Create<T>(string className) 
        {
            string path = Path.Combine(
                HttpContext.Current.Server.MapPath(@"~/Bin/AAA"), 
                ConfigurationManager.AppSettings["DalPath"]+".dll"); 
            Assembly assembly = Assembly.LoadFile(
                //程序集的实际地址  D:\VSProjects\Web.API\Web.API\bin\AAA\Web.SqlDal.dll
                path
                );

            T t = (T)assembly.CreateInstance(
                //类的完全限定名 Web.SqlDal.StudentDal
                ConfigurationManager.AppSettings["DalPath"] + "."+className
                
                );
            return t;
        }
    }
}
