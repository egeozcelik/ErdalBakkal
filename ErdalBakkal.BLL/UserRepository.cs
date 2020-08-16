using ErdalBakkal.BLL.Core;
using ErdalBakkal.DAL;
using ErdalBakkal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalBakkal.BLL
{
    public class UserRepository : IRepository<User>
    {
        ErdalBakkalEntities db = new ErdalBakkalEntities();
        public void Add(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
        }

        public void Delete(User entity)
        {
            db.Users.Remove(entity);
            db.SaveChanges();
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public User GetById(int Id)
        {
            return db.Users.FirstOrDefault(z => z.Id == Id);
        }

        public void Update(User entity)
        {
            User u = db.Users.FirstOrDefault(z => z.Id == entity.Id);
            u.Password = entity.Password;
            u.RoleId = entity.RoleId;
            u.UserName = entity.UserName;
            db.SaveChanges();
        }

        public User Login(string userName, string Password)
        {
            return db.Users.FirstOrDefault(z => z.UserName == userName && z.Password == Password);
        }
    }
}
