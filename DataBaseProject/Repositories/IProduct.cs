using DataBaseProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseProject.Repositories
{
   public interface IProduct
    {
        void AddNewProduct(Product product);
    }
}
