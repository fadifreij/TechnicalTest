using System;
using System.Collections.Generic;
using System.Text;
using DataBaseProject.Models;

namespace DataBaseProject.Repositories
{
    public class ProductRepo : IProduct
    {
        private readonly ApplicationDbContext db;

        public ProductRepo(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddNewProduct(Product product)
        {
            if (product == null)
                throw new ArgumentException();
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}
