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
    public class ProductRepository : IRepository<Product>
    {
        ErdalBakkalEntities db = new ErdalBakkalEntities();
        public void Add(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Product entity)
        {
            db.Products.Remove(entity);
            db.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int Id)
        {
            return db.Products.FirstOrDefault(z => z.Id == Id);
        }

        public void Update(Product entity)
        {
            Product p = db.Products.FirstOrDefault(z => z.Id == entity.Id);
            p.Category = entity.Category;
            p.Name = entity.Name;
            p.Price = entity.Price;
            p.Stock = entity.Stock;
            db.SaveChanges();
        }
    }
}
