using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Order
    {
        public static void AddProducToOrder(OrderEntity oOrder)
        {
            using (var db = new InventaryContext())
            {
                ProductEntity produc = new ProductEntity();

                try
                {
                    oOrder.orderId = Guid.NewGuid().ToString();
                    db.Orders.Add(oOrder);
                    db.SaveChanges();
                } catch (DbUpdateException)
                {
                    throw;
                }

            }

        }
        public static IEnumerable<OrderEntity> OrderById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Orders.ToList().Where(o => o.clientIdentifier == id); // Products.ToList().LastOrDefault(p => p.productId == id);
            }
        }

        public static List<OrderEntity> OrderList(){
            using (var db = new InventaryContext()) 
            {
               return db.Orders.ToList();
            }                
        } 

        public static int CreateIdentifier()
        {
            var rdn = new Random().Next(10000,99999);

            return rdn;
        }
    }
}
