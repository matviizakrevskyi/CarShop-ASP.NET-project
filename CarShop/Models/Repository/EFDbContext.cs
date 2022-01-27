using System.Collections.Generic;
using System.Data.Entity;

namespace CarShop.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


        public void IfObjects()
        {
            List<Product> db = new List<Product>();
            foreach (var item in Products)
                db.Add(item);


            DbObjects def = new DbObjects();
            int n;
            foreach (var item in def.DefProducts)
            {
                n = 0;
                foreach (var dbitem in db)
                {
                    if (dbitem.Name == item.Name)
                        n++;
                }
                if (n == 0)
                {
                    db.Add(item);
                    Products.Add(item);
                    SaveChanges();
                }
            }
        }
    }
}