using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Client
    {
        public static void CreateClient(ClientEntity oClient)
        {
            using (var db = new InventaryContext())
            {
                try
                {
                    db.Clients.Add(oClient);
                    db.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    throw;
                }

            }

        }
    }
}
