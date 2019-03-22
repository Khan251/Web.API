using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.IDal;
using Web.Model;

namespace Web.SqlDal
{
    public class Emp
    {

        public List<UserInfo> Login(UserInfo user)
        {
            EmpManageContext context = new EmpManageContext();
            var a = context.UserInfo.Where(m => m.Name == user.Name && m.Pass == user.Pass).ToList();
            return a;
        }
        /// <summary>
        /// 用户信息
        /// </summary>
        public class _UserInfo : IUserInfoDal
        {
            EmpManageContext context = new EmpManageContext();
            /// <summary>
            /// 添加信息用户信息
            /// </summary>
            /// <param name="userInfo"></param>
            /// <returns></returns>
            public int Add(Model.UserInfo userInfo)
            {
                context.UserInfo.Add(userInfo);
                return context.SaveChanges();
            }
            /// <summary>
            /// 删除用户信息
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public int Del(int Id)
            {
                //获取表中Id相等的一条 加入临时表
                var a = context.UserInfo.Where(m => m.Id == Id).FirstOrDefault();
                //删除获取Id的临时表
                context.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                return context.SaveChanges();
            }
            /// <summary>
            ///  查询用户表
            /// </summary>
            /// <returns></returns>
            public List<Model.UserInfo> GetAll()
            {
                return context.UserInfo.ToList();
            }
            /// <summary>
            /// 根据ID查询用户表
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public List<Model.UserInfo> GetAll(int id)
            {
                return context.UserInfo.Where(m => m.Id == id).ToList();
            }
            /// <summary>
            /// 修改用户信息
            /// </summary>
            /// <param name="userInfo"></param>
            /// <returns></returns>
            public int Update(Model.UserInfo userInfo)
            {
                context.Entry(userInfo).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
        }

        /// <summary>
        /// 角色
        /// </summary>
        public class _RoleInfo : IRoleInfoDal
        {
            EmpManageContext context = new EmpManageContext();
            /// <summary>
            /// 添加角色
            /// </summary>
            /// <param name="roleInfo"></param>
            /// <returns></returns>
            public int Add(Model.RoleInfo roleInfo)
            {
                context.RoleInfo.Add(roleInfo);
                return context.SaveChanges();
            }
            /// <summary>
            /// 删除角色
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public int Del(int Id)
            {
                //获取表中Id相等的一条 加入临时表
                var a = context.RoleInfo.Where(m => m.Id == Id).FirstOrDefault();
                //删除获取Id的临时表
                context.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                return context.SaveChanges();
            }
            /// <summary>
            /// 查询角色
            /// </summary>
            /// <returns></returns>
            public List<Model.RoleInfo> GetAll()
            {
                return context.RoleInfo.ToList();
            }
            /// <summary>
            /// 根据Id查询角色
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public List<Model.RoleInfo> GetAll(int id)
            {
                return context.RoleInfo.Where(m => m.Id == id).ToList();
            }

            /// <summary>
            /// 修改角色
            /// </summary>
            /// <param name="roleInfo"></param>
            /// <returns></returns>
            public int Update(Model.RoleInfo roleInfo)
            {
                context.Entry(roleInfo).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
        }

        /// <summary>
        /// 功能
        /// </summary>
        public class _SysFun : ISysFunDal
        {
            EmpManageContext context = new EmpManageContext();
            /// <summary>
            /// 添加功能
            /// </summary>
            /// <param name="sysFun"></param>
            /// <returns></returns>
            public int Add(Model.SysFun sysFun)
            {
                context.SysFun.Add(sysFun);
                return context.SaveChanges();
            }
            /// <summary>
            /// 删除功能
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public int Del(int Id)
            {
                //获取表中Id相等的一条 加入临时表
                var a = context.SysFun.Where(m => m.Id == Id).FirstOrDefault();
                //删除获取Id的临时表
                context.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                return context.SaveChanges();
            }
            /// <summary>
            /// 查询功能
            /// </summary>
            /// <returns></returns>
            public List<Model.SysFun> GetAll()
            {
                return context.SysFun.ToList();
            }
            /// <summary>
            /// 根据Id查询功能
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public List<Model.SysFun> GetAll(int id)
            {
                return context.SysFun.Where(m => m.Id == id).ToList();
            }
            /// <summary>
            /// 修改功能
            /// </summary>
            /// <param name="sysFun"></param>
            /// <returns></returns>
            public int Update(Model.SysFun sysFun)
            {
                context.Entry(sysFun).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
        }

        /// <summary>
        /// 用户角色信息
        /// </summary>
        public class _UserRole : IUserRoleDal
        {
            EmpManageContext context = new EmpManageContext();
            /// <summary>
            /// 添加用户角色信息
            /// </summary>
            /// <param name="userRole"></param>
            /// <returns></returns>
            public int Add(Model.UserRole userRole)
            {
                context.UserRole.Add(userRole);
                return context.SaveChanges();
            }
            /// <summary>
            /// 删除用户角色信息
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public int Del(int Id)
            {
                //获取表中Id相等的一条 加入临时表
                var a = context.UserRole.Where(m => m.Id == Id).FirstOrDefault();
                //删除获取Id的临时表
                context.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                return context.SaveChanges();
            }
            /// <summary>
            /// 查询用户角色信息
            /// </summary>
            /// <returns></returns>
            public List<Model.UserRole> GetAll()
            {
                return context.UserRole.ToList();
            }
            /// <summary>
            /// 根据Id查询用户角色信息
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public List<Model.UserRole> GetAll(int id)
            {
                return context.UserRole.Where(m => m.Id == id).ToList();
            }
            /// <summary>
            /// 修改用户信息
            /// </summary>
            /// <param name="userRole"></param>
            /// <returns></returns>
            public int Update(Model.UserRole userRole)
            {
                context.Entry(userRole).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
        }

        /// <summary>
        /// 用户功能信息
        /// </summary>
        public class _RoleFun : IRoleFunDal
        {
            /// <summary>
            /// 添加用户功能
            /// </summary>
            EmpManageContext context = new EmpManageContext();
            public int Add(Model.RoleFun roleFun)
            {
                context.RoleFun.Add(roleFun);
                return context.SaveChanges();
            }
            /// <summary>
            /// 删除用户功能
            /// </summary>
            /// <param name="Id"></param>
            /// <returns></returns>
            public int Del(int Id)
            {
                //获取表中Id相等的一条 加入临时表
                var a = context.RoleFun.Where(m => m.Id == Id).FirstOrDefault();
                //删除获取Id的临时表
                context.Entry(a).State = System.Data.Entity.EntityState.Deleted;
                return context.SaveChanges();
            }
            /// <summary>
            /// 查询用户功能
            /// </summary>
            /// <returns></returns>
            public List<Model.RoleFun> GetAll()
            {
                return context.RoleFun.ToList();
            }
            /// <summary>
            /// 根据Id查询用户功能
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public List<Model.RoleFun> GetAll(int id)
            {
                return context.RoleFun.Where(m => m.Id == id).ToList();
            }

            /// <summary>
            /// 修改用户功能
            /// </summary>
            /// <param name="roleFun"></param>
            /// <returns></returns>
            public int Update(Model.RoleFun roleFun)
            {
                context.Entry(roleFun).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
        }


    }
}
