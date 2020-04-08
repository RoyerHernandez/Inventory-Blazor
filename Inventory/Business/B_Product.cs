using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db= new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity ProductById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList().LastOrDefault(p=>p.productId==id);
            }
        }
        public static void CreateProduct(ProductEntity oProduct)
        {   
            using (var db = new InventaryContext())
            {
                try {
                    db.Products.Add(oProduct);
                    db.SaveChanges();
                }
                catch (DbUpdateException) {
                    throw;
                }
            }
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext()) 
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
