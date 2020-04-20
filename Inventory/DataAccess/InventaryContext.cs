using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        public DbSet<WarehouseEntity> Warehouses { get; set; }

        public DbSet<InOutEntity> InOuts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
          /*  if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-2ID8ELN; DataBase=InventoryDb; User id=royer; Password=Israfel2112");
            }*/
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=tcp:royerserver.database.windows.net,1433;Initial Catalog=InventoryDb;Persist Security Info=False;User ID=RoyerAdmin;Password=Israfel2112;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { categoryId="MD", categoryName= "Medicamentos"},
                new CategoryEntity { categoryId = "JB", categoryName = "Jabones" },
                new CategoryEntity { categoryId = "BT", categoryName = "Boticario" },
                new CategoryEntity { categoryId = "PB", categoryName = "Productos Bucales" },
                new CategoryEntity { categoryId = "AS", categoryName = "Aseo Personal" }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { warehouseId = Guid.NewGuid().ToString(), warehouseName = "Bodega Central", warehouseAddress = "Calle 8 con 23" },
                new WarehouseEntity { warehouseId = Guid.NewGuid().ToString(), warehouseName = "Bodega Norte", warehouseAddress = "Calle norte con occidente" }
                );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { productId = "ASJ-98745", productName = "Medicamento", productDesciption = "", categoryId = "MD" },
                new ProductEntity { productId = "RPT-5465879", productName = "Boticario", productDesciption = "", categoryId = "BT" }
                );
        }

    }
}
