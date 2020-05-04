using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Order
    {
        public static void AddProducToOrder(OrderEntity oOrder)
        {
            using(var db = new InventaryContext())
            {
                try
                {
                    db.Orders.Add(oOrder);
                    db.SaveChanges();
                } catch (DbUpdateException)
                {
                    throw;
                }

            }

        }
    }
}
