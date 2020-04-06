using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InOut
    {
        public List<InOutEntity> InOutList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInOut(InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInOut);
                db.SaveChanges();
            }
        }

        public void UpdateInOut(InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInOut);
                db.SaveChanges();
            }
        }
    }
}
