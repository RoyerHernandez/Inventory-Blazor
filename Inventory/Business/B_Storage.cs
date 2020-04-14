using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.warehouse)
                    .ToList();
            }
        }

        public static StorageEntity CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();

                return GetStorageById(oStorage.storageId);
            }
        }

        /* NUEVO MÉTODO */
        public static StorageEntity GetStorageById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.warehouse)
                    .ToList()
                    .LastOrDefault(s => s.storageId == id);
            }
        }

        /* NUEVO MÉTODO */
        public static bool IsProductInWarehouse(string id)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList()
                    .Where(p => p.storageId == id);

                return product.Any();
            }
        }

        /* NUEVO MÉTODO */
        public static List<StorageEntity> StorageListByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.warehouse)
                    .Where(s => s.warehouseId == idWarehouse)
                    .ToList();
            }
        }

        public static void UpdateStorage(StorageEntity oStorage)
        {
            oStorage.LastUpdate = DateTime.Now;

            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
