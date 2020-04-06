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
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-2ID8ELN; DataBase=InventoryDb; User id=royer; Password=Israfel2112");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { categoryId="JS", categoryName= "Juguetes Sexuales"},
                new CategoryEntity { categoryId = "LI", categoryName = "Lubricantes Intimos" },
                new CategoryEntity { categoryId = "RE", categoryName = "Retardantes" },
                new CategoryEntity { categoryId = "RI", categoryName = "Ropa Intiva" },
                new CategoryEntity { categoryId = "AS", categoryName = "Accesorios Sexuales" }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { warehouseId = Guid.NewGuid().ToString(), warehouseName = "Bodega Central", warehouseAddress = "Calle 8 con 23" },
                new WarehouseEntity { warehouseId = Guid.NewGuid().ToString(), warehouseName = "Bodega Norte", warehouseAddress = "Calle norte con occidente" }
                );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { productId = "ASJ-98745", productName = "Consoladores", productDesciption = "", categoryId = "JS" },
                new ProductEntity { productId = "RPT-5465879", productName = "Aceite retardante", productDesciption = "", categoryId = "RE" }
                );
        }

    }
}
