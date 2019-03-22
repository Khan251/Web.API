using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Web.Model;
using System.Data.Entity.Infrastructure;

namespace Web.SqlDal
{
    public partial class EmpManageContext : DbContext
    {
        public EmpManageContext()
            : base("name=EmpManageEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<RoleFun> RoleFun { get; set; }
        public virtual DbSet<RoleInfo> RoleInfo { get; set; }
        public virtual DbSet<SysFun> SysFun { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
    }




}
