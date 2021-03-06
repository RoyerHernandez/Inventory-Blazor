﻿using Entities;
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

        public DbSet<OrderEntity> Orders { get; set; }

        public DbSet<ClientEntity> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
          /*  if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-2ID8ELN; DataBase=InventoryDb; User id=royer; Password=Israfel2112");
            }*/
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=tcp:royerserver.database.windows.net,1433;Initial Catalog=InventoryDb;Persist Security Info=False;User ID=RoyerAdmin;Password=Israfel2112;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                //options.UseSqlServer("Server=tcp:cariciaserver.database.windows.net,1433;Initial Catalog=Inventory;Persist Security Info=False;User ID=RoyerAdmin;Password=Israfel2112;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { categoryId = "MD", categoryName = "Medicamentos" },
                new CategoryEntity { categoryId = "JB", categoryName = "Jabones" },
                new CategoryEntity { categoryId = "BT", categoryName = "Boticario" },
                new CategoryEntity { categoryId = "PB", categoryName = "Productos Bucales" },
                new CategoryEntity { categoryId = "AS", categoryName = "Aseo Personal" }
                );

            modelBuilder.Entity<ClientEntity>().HasData(
                new ClientEntity { clientId = 1024466070, clientName= "Jeimi Paola", clientLastName= "Chaparro", clientAddres="Cra 77 h # 65 j 86 sur", eMail="jeichap@hotmail.com", numberPhone = 7797467},
                new ClientEntity { clientId = 80142463, clientName = "Royer A", clientLastName = "Hernandez M", clientAddres = "Cra 77 h # 65 j 86 sur", eMail = "jeichap@hotmail.com", numberPhone = 7797467 }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { warehouseId = Guid.NewGuid().ToString(), warehouseName = "Bodega Central", warehouseAddress = "Calle 8 con 23" },
                new WarehouseEntity { warehouseId = Guid.NewGuid().ToString(), warehouseName = "Bodega Norte", warehouseAddress = "Calle norte con occidente" }
                );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { productId = "ASJ-98745", productName = "Medicamento", productDesciption = "", categoryId = "MD" },
                new ProductEntity { productId = "RPT-5465879", productName = "Boticario", productDesciption = "", categoryId = "BT" }
                );


            //            modelBuilder.Entity<CategoryEntity>().HasData(
            //                new CategoryEntity { categoryId = "AC", categoryName = "Aceites" },
            //                new CategoryEntity { categoryId = "LU", categoryName = "Lubricantes" },
            //                new CategoryEntity { categoryId = "VI", categoryName = "Vibradores" },
            //                new CategoryEntity { categoryId = "JS", categoryName = "Juguetes Sexuales" },
            //                new CategoryEntity { categoryId = "OS", categoryName = "Otros" }
            //                );

            //            modelBuilder.Entity<WarehouseEntity>().HasData(
            //                new WarehouseEntity { warehouseId = Guid.NewGuid().ToString(), warehouseName = "Bodega Central", warehouseAddress = "Calle 8 con 23" },
            //                new WarehouseEntity { warehouseId = Guid.NewGuid().ToString(), warehouseName = "Bodega Sur", warehouseAddress = "Calle norte con occidente" }
            //                );

            //            modelBuilder.Entity<ProductEntity>().HasData(
            //                new ProductEntity { productId = "100", productName = "ACEITE CALIENTE SKIN 30ML", productDesciption = "ACEITE CALIENTE SKIN 30ML", categoryId = "AC" },
            //new ProductEntity { productId = "101", productName = "ACEITE CALIENTE FRUIT LOVE 8 oz", productDesciption = "ACEITE CALIENTE FRUIT LOVE 8 oz", categoryId = "AC" },
            //new ProductEntity { productId = "102", productName = "ACEITE CALIENTE WARM UP 120 ml", productDesciption = "ACEITE CALIENTE WARM UP 120 ml", categoryId = "AC" },
            //new ProductEntity { productId = "103", productName = "ACEINTE CALIENTE WARM UP 240 ml", productDesciption = "ACEINTE CALIENTE WARM UP 240 ml", categoryId = "AC" },
            //new ProductEntity { productId = "104", productName = "ACEITE CALIENTE SWEET LOVE 37 ml", productDesciption = "ACEITE CALIENTE SWEET LOVE 37 ml", categoryId = "AC" },
            //new ProductEntity { productId = "105", productName = "ACEITE CALIENTE PASSION INTIMA 5ml", productDesciption = "ACEITE CALIENTE PASSION INTIMA 5ml", categoryId = "AC" },
            //new ProductEntity { productId = "106", productName = "ACEITE CALIENTE RELISTIC VALVULA 37ml", productDesciption = "ACEITE CALIENTE RELISTIC VALVULA 37ml", categoryId = "AC" },
            //new ProductEntity { productId = "107", productName = "ACEITE CALIENTE PECADOS 10ml", productDesciption = "ACEITE CALIENTE PECADOS 10ml", categoryId = "AC" },
            //new ProductEntity { productId = "108", productName = "ACEITE CALIENTE COCKTAIL LICOR 40ml", productDesciption = "ACEITE CALIENTE COCKTAIL LICOR 40ml", categoryId = "AC" },
            //new ProductEntity { productId = "109", productName = "COJIN BODY HEAT ACEITE CALIENTE", productDesciption = "COJIN BODY HEAT ACEITE CALIENTE", categoryId = "AC" },
            //new ProductEntity { productId = "110", productName = "COJIN SPANISH FLY GOTAS EXITANTES", productDesciption = "COJIN SPANISH FLY GOTAS EXITANTES", categoryId = "AC" },
            //new ProductEntity { productId = "111", productName = "RETARDEX CREMA CAJA ROJA 15gr", productDesciption = "RETARDEX CREMA CAJA ROJA 15gr", categoryId = "AC" },
            //new ProductEntity { productId = "112", productName = "RETARDING FRASCO BLANCO 15 gr", productDesciption = "RETARDING FRASCO BLANCO 15 gr", categoryId = "AC" },
            //new ProductEntity { productId = "113", productName = "APOLOS MAN CREMA 5gr mini", productDesciption = "APOLOS MAN CREMA 5gr mini", categoryId = "AC" },
            //new ProductEntity { productId = "114", productName = "APOLOS MAN CREMA 15gr", productDesciption = "APOLOS MAN CREMA 15gr", categoryId = "AC" },
            //new ProductEntity { productId = "115", productName = "RETARDEX CREMA 5gr mini", productDesciption = "RETARDEX CREMA 5gr mini", categoryId = "AC" },
            //new ProductEntity { productId = "116", productName = "SOBRE GEL PARADISE 5ml RETARDANTE", productDesciption = "SOBRE GEL PARADISE 5ml RETARDANTE", categoryId = "AC" },
            //new ProductEntity { productId = "117", productName = "RINO SPRAY AZUL", productDesciption = "RINO SPRAY AZUL", categoryId = "AC" },
            //new ProductEntity { productId = "118", productName = "RINO SPRAY SPRAY DORADO", productDesciption = "RINO SPRAY SPRAY DORADO", categoryId = "AC" },
            //new ProductEntity { productId = "119", productName = "RINO CREMA DORADO 10ml", productDesciption = "RINO CREMA DORADO 10ml", categoryId = "AC" },
            //new ProductEntity { productId = "120", productName = "GEL MR PROLONG SOBRE RETARDANTE 5ml", productDesciption = "GEL MR PROLONG SOBRE RETARDANTE 5ml", categoryId = "AC" },
            //new ProductEntity { productId = "121", productName = "KANGUROO CREMA 15gr RETARDANTE", productDesciption = "KANGUROO CREMA 15gr RETARDANTE", categoryId = "AC" },
            //new ProductEntity { productId = "122", productName = "KANGUROO GEL 30ml APLICADOR", productDesciption = "KANGUROO GEL 30ml APLICADOR", categoryId = "AC" },
            //new ProductEntity { productId = "123", productName = "STUD 100 INGLES 12gr ORIGINAL", productDesciption = "STUD 100 INGLES 12gr ORIGINAL", categoryId = "AC" },
            //new ProductEntity { productId = "124", productName = "BROCHA CHINA ORIGINAL  10ml HONG KONG", productDesciption = "BROCHA CHINA ORIGINAL  10ml HONG KONG", categoryId = "AC" },
            //new ProductEntity { productId = "125", productName = "MENTOL CHINO GRANDE  15gr", productDesciption = "MENTOL CHINO GRANDE  15gr", categoryId = "AC" },
            //new ProductEntity { productId = "126", productName = "MENTOL CHINO PEQUEÑO 5gr", productDesciption = "MENTOL CHINO PEQUEÑO 5gr", categoryId = "AC" },
            //new ProductEntity { productId = "127", productName = "STUD 100 CRISTAL PLASTICO 30ml", productDesciption = "STUD 100 CRISTAL PLASTICO 30ml", categoryId = "AC" },
            //new ProductEntity { productId = "128", productName = "STUD 100 CRISTAL VIDRIO mini 10ml", productDesciption = "STUD 100 CRISTAL VIDRIO mini 10ml", categoryId = "AC" },
            //new ProductEntity { productId = "129", productName = "PROCOMIL SPRAY ALEMAN ORIGINAL", productDesciption = "PROCOMIL SPRAY ALEMAN ORIGINAL", categoryId = "AC" },
            //new ProductEntity { productId = "130", productName = "CABALLO BLANCO SPRAY RETARDANTE", productDesciption = "CABALLO BLANCO SPRAY RETARDANTE", categoryId = "AC" },
            //new ProductEntity { productId = "131", productName = "PROLONGING CREMA 5gr mini", productDesciption = "PROLONGING CREMA 5gr mini", categoryId = "AC" },
            //new ProductEntity { productId = "132", productName = "KANGUROO GEL 5gr mini", productDesciption = "KANGUROO GEL 5gr mini", categoryId = "AC" },
            //new ProductEntity { productId = "133", productName = "PAÑITO CHINO RETARDANTE FOR MEN", productDesciption = "PAÑITO CHINO RETARDANTE FOR MEN", categoryId = "AC" },
            //new ProductEntity { productId = "134", productName = "PAÑITO CHINO EXCITANTE FOR LADY", productDesciption = "PAÑITO CHINO EXCITANTE FOR LADY", categoryId = "AC" },
            //new ProductEntity { productId = "135", productName = "TIGHTEN UP ESTRECHANTE SOBRE 5ml GEL", productDesciption = "TIGHTEN UP ESTRECHANTE SOBRE 5ml GEL", categoryId = "AC" },
            //new ProductEntity { productId = "136", productName = "GEL VIRGINIA 30ml APLICADOR  ESTRECHANTE", productDesciption = "GEL VIRGINIA 30ml APLICADOR  ESTRECHANTE", categoryId = "AC" },
            //new ProductEntity { productId = "137", productName = "CREMA AFRODITAS 15gr ESTRECHANTE", productDesciption = "CREMA AFRODITAS 15gr ESTRECHANTE", categoryId = "AC" },
            //new ProductEntity { productId = "138", productName = "TIGHTEN CREMA ESTRECHANTE 5gr mini", productDesciption = "TIGHTEN CREMA ESTRECHANTE 5gr mini", categoryId = "AC" },
            //new ProductEntity { productId = "139", productName = "CREMA 5gr AFRODITA mini ESTRECHANTE", productDesciption = "CREMA 5gr AFRODITA mini ESTRECHANTE", categoryId = "AC" },
            //new ProductEntity { productId = "140", productName = "GEL PARADISE ESTRECHANTE 5ml SOBRE", productDesciption = "GEL PARADISE ESTRECHANTE 5ml SOBRE", categoryId = "AC" },
            //new ProductEntity { productId = "141", productName = "VIRGINIA GOTAS ESTRECHANTES 5ml", productDesciption = "VIRGINIA GOTAS ESTRECHANTES 5ml", categoryId = "AC" },
            //new ProductEntity { productId = "142", productName = "PARADISE MULTIORGASMOS 5ml SOBRE", productDesciption = "PARADISE MULTIORGASMOS 5ml SOBRE", categoryId = "AC" },
            //new ProductEntity { productId = "143", productName = "AROUSAL 5ml SOBRE GEL MULTIORGASMOS", productDesciption = "AROUSAL 5ml SOBRE GEL MULTIORGASMOS", categoryId = "AC" },
            //new ProductEntity { productId = "144", productName = "MULTIORGASMO GEL APLICADOR 30 ml", productDesciption = "MULTIORGASMO GEL APLICADOR 30 ml", categoryId = "AC" },
            //new ProductEntity { productId = "145", productName = "CREMA 15 gr HIEDRA MULTIORGASMOS", productDesciption = "CREMA 15 gr HIEDRA MULTIORGASMOS", categoryId = "AC" },
            //new ProductEntity { productId = "146", productName = "CREMA 5gr mini HIEDRA MULTIORGASMOS", productDesciption = "CREMA 5gr mini HIEDRA MULTIORGASMOS", categoryId = "AC" },
            //new ProductEntity { productId = "147", productName = "AROUSAL GEL 5gr mini MULTIORAGASMOS", productDesciption = "AROUSAL GEL 5gr mini MULTIORAGASMOS", categoryId = "AC" },
            //new ProductEntity { productId = "148", productName = "GOTAS ORGASMICS GEL 10ml", productDesciption = "GOTAS ORGASMICS GEL 10ml", categoryId = "AC" },
            //new ProductEntity { productId = "149", productName = "ANALEAZE CREMA FRASCO BLANCO 15gr", productDesciption = "ANALEAZE CREMA FRASCO BLANCO 15gr", categoryId = "AC" },
            //new ProductEntity { productId = "150", productName = "EXXTREME VALVULA GEL DILATADOR 37ml", productDesciption = "EXXTREME VALVULA GEL DILATADOR 37ml", categoryId = "AC" },
            //new ProductEntity { productId = "151", productName = "TIGER CREMA ANAL 15 gr", productDesciption = "TIGER CREMA ANAL 15 gr", categoryId = "AC" },
            //new ProductEntity { productId = "152", productName = "TIGER CREMA ANAL 5gr mini", productDesciption = "TIGER CREMA ANAL 5gr mini", categoryId = "AC" },
            //new ProductEntity { productId = "153", productName = "ANALEZE CREMA 5gr mini ROJO", productDesciption = "ANALEZE CREMA 5gr mini ROJO", categoryId = "AC" },
            //new ProductEntity { productId = "153A", productName = "ANALEZE PORTABLE 5gr mini AZUL", productDesciption = "ANALEZE PORTABLE 5gr mini AZUL", categoryId = "AC" },
            //new ProductEntity { productId = "154", productName = "PARADISE GEL ANAL 5ml SOBRE", productDesciption = "PARADISE GEL ANAL 5ml SOBRE", categoryId = "AC" },
            //new ProductEntity { productId = "155", productName = "ANAL LUBRICANT SOBRE 5ml GEL", productDesciption = "ANAL LUBRICANT SOBRE 5ml GEL", categoryId = "AC" },
            //new ProductEntity { productId = "156", productName = "ANAL RUSH GEL APLICADOR 30ml", productDesciption = "ANAL RUSH GEL APLICADOR 30ml", categoryId = "AC" },
            //new ProductEntity { productId = "157", productName = "EXXTREME CHERRY 30ml GEL ANAL", productDesciption = "EXXTREME CHERRY 30ml GEL ANAL", categoryId = "AC" },
            //new ProductEntity { productId = "158", productName = "MAX MAN GEL 30ml APLICADOR", productDesciption = "MAX MAN GEL 30ml APLICADOR", categoryId = "AC" },
            //new ProductEntity { productId = "159", productName = "TIGER WOODS RETARDANTE Y ENGROSANTE 10ml", productDesciption = "TIGER WOODS RETARDANTE Y ENGROSANTE 10ml", categoryId = "AC" },
            //new ProductEntity { productId = "160", productName = "ACEITE TAPA DORADA MICHELS AGRANDADORA 120ml", productDesciption = "ACEITE TAPA DORADA MICHELS AGRANDADORA 120ml", categoryId = "AC" },
            //new ProductEntity { productId = "161", productName = "MAX MAN GEL 15gr  ORIGINAL", productDesciption = "MAX MAN GEL 15gr  ORIGINAL", categoryId = "AC" },
            //new ProductEntity { productId = "162", productName = "MAX MAN CREMA 30gr ORIGINAL", productDesciption = "MAX MAN CREMA 30gr ORIGINAL", categoryId = "AC" },
            //new ProductEntity { productId = "163", productName = "PENISEX CREMA 25gr ORIGINAL", productDesciption = "PENISEX CREMA 25gr ORIGINAL", categoryId = "AC" },
            //new ProductEntity { productId = "164", productName = "MANSIZE GEL 25gr ORIGINAL", productDesciption = "MANSIZE GEL 25gr ORIGINAL", categoryId = "AC" },
            //new ProductEntity { productId = "165", productName = "DICLONINE GEL 25gr ORIGINAL", productDesciption = "DICLONINE GEL 25gr ORIGINAL", categoryId = "AC" },
            //new ProductEntity { productId = "166", productName = "DEVELOPPE SEX GEL 60ml ORIGINAL", productDesciption = "DEVELOPPE SEX GEL 60ml ORIGINAL", categoryId = "AC" },
            //new ProductEntity { productId = "167", productName = "XXL CREAM 50ml ORIGINAL", productDesciption = "XXL CREAM 50ml ORIGINAL", categoryId = "AC" },
            //new ProductEntity { productId = "238", productName = "FUNDA MAGIC TUBE", productDesciption = "FUNDA MAGIC TUBE", categoryId = "AC" },
            //new ProductEntity { productId = "239", productName = "FUNDA MALLA CONEJO + 2 VIBRADORES", productDesciption = "FUNDA MALLA CONEJO + 2 VIBRADORES", categoryId = "AC" },
            //new ProductEntity { productId = "240", productName = "FUNDA MALLA CONEJO + 1VIBRADOR", productDesciption = "FUNDA MALLA CONEJO + 1VIBRADOR", categoryId = "AC" },
            //new ProductEntity { productId = "241", productName = "FUNDA PENIS EXXTENSION PERLAS  PEQ.", productDesciption = "FUNDA PENIS EXXTENSION PERLAS  PEQ.", categoryId = "AC" },
            //new ProductEntity { productId = "242", productName = "FUNDA GIGANTE COLORES", productDesciption = "FUNDA GIGANTE COLORES", categoryId = "AC" },
            //new ProductEntity { productId = "243", productName = "FUNDA PENE COMPLETA  BRAVEMAN SIN VIBRADOR", productDesciption = "FUNDA PENE COMPLETA  BRAVEMAN SIN VIBRADOR", categoryId = "AC" },
            //new ProductEntity { productId = "244", productName = "FUNDA PENE COMPLETA BRAVEMAN + CRESTA SIN VIBRADO", productDesciption = "FUNDA PENE COMPLETA BRAVEMAN + CRESTA SIN VIBRADO", categoryId = "AC" },
            //new ProductEntity { productId = "245", productName = "FUNDA PENE DRAGON + VIBRACION", productDesciption = "FUNDA PENE DRAGON + VIBRACION", categoryId = "AC" },
            //new ProductEntity { productId = "246", productName = "FUNDA MAGIC TUBE + VIBRACION", productDesciption = "FUNDA MAGIC TUBE + VIBRACION", categoryId = "AC" },
            //new ProductEntity { productId = "247", productName = "FUNDA + EXXTENSION  PENE PIEL", productDesciption = "FUNDA + EXXTENSION  PENE PIEL", categoryId = "AC" },
            //new ProductEntity { productId = "248", productName = "FUNDA BRAVEMAN CAJA BLANCA + 1 VIBRADOR CLITORIAL", productDesciption = "FUNDA BRAVEMAN CAJA BLANCA + 1 VIBRADOR CLITORIAL", categoryId = "AC" },
            //new ProductEntity { productId = "249", productName = "FUNDA BRAVEMAN CAJA MORADA + 1 VIBRADOR CLITORIAL", productDesciption = "FUNDA BRAVEMAN CAJA MORADA + 1 VIBRADOR CLITORIAL", categoryId = "AC" },
            //new ProductEntity { productId = "250", productName = "FUNDA BRAVEMAN CAJA + 1 VIBRADOR", productDesciption = "FUNDA BRAVEMAN CAJA + 1 VIBRADOR", categoryId = "AC" },
            //new ProductEntity { productId = "251", productName = "FUNDA BRAVEMAN CAJA + 1 VIBRADOR", productDesciption = "FUNDA BRAVEMAN CAJA + 1 VIBRADOR", categoryId = "AC" },
            //new ProductEntity { productId = "252", productName = "DESOS SILICONA * 2 JELLY FINGERS", productDesciption = "DESOS SILICONA * 2 JELLY FINGERS", categoryId = "AC" },
            //new ProductEntity { productId = "253", productName = "DEDOS MINI SILICONA  CLIT BANGERS", productDesciption = "DEDOS MINI SILICONA  CLIT BANGERS", categoryId = "AC" },
            //new ProductEntity { productId = "254", productName = "FUNDA SEX TOYS CONDON", productDesciption = "FUNDA SEX TOYS CONDON", categoryId = "AC" },
            //new ProductEntity { productId = "255", productName = "FUNDA DOBLE ESTIMULACION", productDesciption = "FUNDA DOBLE ESTIMULACION", categoryId = "AC" },
            //new ProductEntity { productId = "256", productName = "FUNDA PUNTOS LATERALES", productDesciption = "FUNDA PUNTOS LATERALES", categoryId = "AC" },
            //new ProductEntity { productId = "257", productName = "FUNDA ESTIMULACION + LENGUA", productDesciption = "FUNDA ESTIMULACION + LENGUA", categoryId = "AC" },
            //new ProductEntity { productId = "258", productName = "FUNDA ESTIMULADOR PUNTOS", productDesciption = "FUNDA ESTIMULADOR PUNTOS", categoryId = "AC" },
            //new ProductEntity { productId = "259", productName = "FUNDA ESTIMULACION + TESTICULOS", productDesciption = "FUNDA ESTIMULACION + TESTICULOS", categoryId = "AC" },
            //new ProductEntity { productId = "260", productName = "FUNDA ESTIMULACION REAL", productDesciption = "FUNDA ESTIMULACION REAL", categoryId = "AC" },
            //new ProductEntity { productId = "261", productName = "FUNDA ESTIMULACION REAL +VIBRADOR + TESTICULOS", productDesciption = "FUNDA ESTIMULACION REAL +VIBRADOR + TESTICULOS", categoryId = "AC" },
            //new ProductEntity { productId = "262", productName = "BOLAS ANALES JUMBO", productDesciption = "BOLAS ANALES JUMBO", categoryId = "AC" },
            //new ProductEntity { productId = "263", productName = "BOLAS BALLS +10 VEL.  WATERPROFF VIBRACION", productDesciption = "BOLAS BALLS +10 VEL.  WATERPROFF VIBRACION", categoryId = "AC" },
            //new ProductEntity { productId = "264", productName = "BOLAS ANAL + CHUPA + VIBRACION GRANDES", productDesciption = "BOLAS ANAL + CHUPA + VIBRACION GRANDES", categoryId = "AC" },
            //new ProductEntity { productId = "265", productName = "BOLAS ANAL + CHUPA + VIBRACION MEDIANAS", productDesciption = "BOLAS ANAL + CHUPA + VIBRACION MEDIANAS", categoryId = "AC" },
            //new ProductEntity { productId = "266", productName = "BOLAS ANAL G BEADS * 6 BOLAS", productDesciption = "BOLAS ANAL G BEADS * 6 BOLAS", categoryId = "AC" },
            //new ProductEntity { productId = "267", productName = "VIBRADOR DISTORTION + 6 FUNCIONES SILICONA", productDesciption = "VIBRADOR DISTORTION + 6 FUNCIONES SILICONA", categoryId = "AC" },
            //new ProductEntity { productId = "268", productName = "BOLAS ANALES GIGANTES", productDesciption = "BOLAS ANALES GIGANTES", categoryId = "AC" },
            //new ProductEntity { productId = "269", productName = "VIBRADOR DECADENCE + BOLAS  SILICONA", productDesciption = "VIBRADOR DECADENCE + BOLAS  SILICONA", categoryId = "AC" },
            //new ProductEntity { productId = "270", productName = "DUO BOLAS ANAL + MINI BOLAS SILICONA", productDesciption = "DUO BOLAS ANAL + MINI BOLAS SILICONA", categoryId = "AC" },
            //new ProductEntity { productId = "271", productName = "BOLAS VAGINALES EXXQUISITE 7 COLORES", productDesciption = "BOLAS VAGINALES EXXQUISITE 7 COLORES", categoryId = "AC" },
            //new ProductEntity { productId = "272", productName = "BOLAS VAGINALES ESTRIADAS", productDesciption = "BOLAS VAGINALES ESTRIADAS", categoryId = "AC" },
            //new ProductEntity { productId = "273", productName = "BOLAS VAGINALES ESTRIADAS + 7 VELOCIDADES", productDesciption = "BOLAS VAGINALES ESTRIADAS + 7 VELOCIDADES", categoryId = "AC" },
            //new ProductEntity { productId = "274", productName = "BOLAS VAGINALES + SENSORES DE CALOR+ VIBRACION", productDesciption = "BOLAS VAGINALES + SENSORES DE CALOR+ VIBRACION", categoryId = "AC" },
            //new ProductEntity { productId = "275", productName = "BOLAS VAGINALES GOLDEN+ VIBRADOR", productDesciption = "BOLAS VAGINALES GOLDEN+ VIBRADOR", categoryId = "AC" },
            //new ProductEntity { productId = "276", productName = "BOLAS VAGINALES FERRERO BALLS", productDesciption = "BOLAS VAGINALES FERRERO BALLS", categoryId = "AC" },
            //new ProductEntity { productId = "277", productName = "VIBRADOR DOBLE ESTIMULVIION GIGANTE", productDesciption = "VIBRADOR DOBLE ESTIMULVIION GIGANTE", categoryId = "VI" },
            //new ProductEntity { productId = "278", productName = "VIBRADOR SOPHIA ROTATORIO 5 COLORES", productDesciption = "VIBRADOR SOPHIA ROTATORIO 5 COLORES", categoryId = "VI" },
            //new ProductEntity { productId = "279", productName = "VIBRADOR DOBLE NAUGHTY", productDesciption = "VIBRADOR DOBLE NAUGHTY", categoryId = "VI" },
            //new ProductEntity { productId = "280", productName = "VIBRADOR CLIMBING RABITT VIBE", productDesciption = "VIBRADOR CLIMBING RABITT VIBE", categoryId = "VI" },
            //new ProductEntity { productId = "281", productName = "VIBRADOR  DOBLE BRIGTY ARTHUR", productDesciption = "VIBRADOR  DOBLE BRIGTY ARTHUR", categoryId = "VI" },
            //new ProductEntity { productId = "282", productName = "VIBRADOR DOBLE SNAPPY ANDRE", productDesciption = "VIBRADOR DOBLE SNAPPY ANDRE", categoryId = "VI" },
            //new ProductEntity { productId = "283", productName = "CONSOLADOR  DUAL LUCKY LADY", productDesciption = "CONSOLADOR  DUAL LUCKY LADY", categoryId = "VI" },
            //new ProductEntity { productId = "284", productName = "VIBRADOR DOBLE PENETRADOR", productDesciption = "VIBRADOR DOBLE PENETRADOR", categoryId = "VI" },
            //new ProductEntity { productId = "285", productName = "HUEVO VIBRADOR TRIPLE ESTIMULVIION", productDesciption = "HUEVO VIBRADOR TRIPLE ESTIMULVIION", categoryId = "VI" },
            //new ProductEntity { productId = "286", productName = "VIBRADOR DOBLE ROLLING  ROTATORIO", productDesciption = "VIBRADOR DOBLE ROLLING  ROTATORIO", categoryId = "VI" },
            //new ProductEntity { productId = "287", productName = "CONSOLADOR DOBLE PUNTA", productDesciption = "CONSOLADOR DOBLE PUNTA", categoryId = "VI" },
            //new ProductEntity { productId = "288", productName = "VIBRADOR DUAL PENETRATOR", productDesciption = "VIBRADOR DUAL PENETRATOR", categoryId = "VI" },
            //new ProductEntity { productId = "289", productName = "VIBRADOR  GK TRIPLE ESTIMULVIION.", productDesciption = "VIBRADOR  GK TRIPLE ESTIMULVIION.", categoryId = "VI" },
            //new ProductEntity { productId = "290", productName = "INICIADOR ANAL + VIB.", productDesciption = "INICIADOR ANAL + VIB.", categoryId = "AC" },
            //new ProductEntity { productId = "291", productName = "INICIO ANAL GIGANTE CURVO", productDesciption = "INICIO ANAL GIGANTE CURVO", categoryId = "AC" },
            //new ProductEntity { productId = "292", productName = "INICIO ANAL GIGANTE PEZ", productDesciption = "INICIO ANAL GIGANTE PEZ", categoryId = "AC" },
            //new ProductEntity { productId = "293", productName = "INICIO ANAL GIGANTE PUNTO G", productDesciption = "INICIO ANAL GIGANTE PUNTO G", categoryId = "AC" },
            //new ProductEntity { productId = "294", productName = "INICIO ANAL GIGANTE MISIL", productDesciption = "INICIO ANAL GIGANTE MISIL", categoryId = "AC" },
            //new ProductEntity { productId = "295", productName = "INICIO ANAL JELLY + SILICONA", productDesciption = "INICIO ANAL JELLY + SILICONA", categoryId = "AC" },
            //new ProductEntity { productId = "296", productName = "INICIO ANAL SENCILLO", productDesciption = "INICIO ANAL SENCILLO", categoryId = "AC" },
            //new ProductEntity { productId = "297", productName = "VIB. ANAL MISTYQUE + 7 VEL.", productDesciption = "VIB. ANAL MISTYQUE + 7 VEL.", categoryId = "AC" },
            //new ProductEntity { productId = "298", productName = "VIB. ANAL SLENDER + 7 VEL.", productDesciption = "VIB. ANAL SLENDER + 7 VEL.", categoryId = "AC" },
            //new ProductEntity { productId = "299", productName = "VIB. ANAL FISKY FLEX  + 7 VEL.", productDesciption = "VIB. ANAL FISKY FLEX  + 7 VEL.", categoryId = "AC" },
            //new ProductEntity { productId = "300", productName = "VIB. HONEY BUNNY + 7 VEL.", productDesciption = "VIB. HONEY BUNNY + 7 VEL.", categoryId = "AC" },
            //new ProductEntity { productId = "301", productName = "MUÑECOS VIBRADORES", productDesciption = "MUÑECOS VIBRADORES", categoryId = "AC" },
            //new ProductEntity { productId = "302", productName = "HUEVO JAPONES METALIZADOS X 10 VEL.", productDesciption = "HUEVO JAPONES METALIZADOS X 10 VEL.", categoryId = "AC" },
            //new ProductEntity { productId = "303", productName = "HUEVO PLATEADO GRANDE", productDesciption = "HUEVO PLATEADO GRANDE", categoryId = "AC" },
            //new ProductEntity { productId = "304", productName = "HUEVO JAPONES NEON X 10 VEL", productDesciption = "HUEVO JAPONES NEON X 10 VEL", categoryId = "AC" },
            //new ProductEntity { productId = "305", productName = "HUEVO VIBRADOR DE COLORES", productDesciption = "HUEVO VIBRADOR DE COLORES", categoryId = "AC" },
            //new ProductEntity { productId = "306", productName = "HUEVO VIBRADOR MONSTER METALIZADOS", productDesciption = "HUEVO VIBRADOR MONSTER METALIZADOS", categoryId = "AC" },
            //new ProductEntity { productId = "307", productName = "HUEVO VIBRADOR ANIMAL PRINT", productDesciption = "HUEVO VIBRADOR ANIMAL PRINT", categoryId = "AC" },
            //new ProductEntity { productId = "378", productName = "KIT SM NEGRO CLASSIC", productDesciption = "KIT SM NEGRO CLASSIC", categoryId = "AC" },
            //new ProductEntity { productId = "379", productName = "INICIO ANAL NEGRO MAS COLA DE LOBO", productDesciption = "INICIO ANAL NEGRO MAS COLA DE LOBO", categoryId = "AC" },
            //new ProductEntity { productId = "380", productName = "INICIO ANAL PIEL MAS COLA DE LOBO", productDesciption = "INICIO ANAL PIEL MAS COLA DE LOBO", categoryId = "AC" },
            //new ProductEntity { productId = "381", productName = "INICIO ANAL ACERO XXL MAS COLA DE LOBO", productDesciption = "INICIO ANAL ACERO XXL MAS COLA DE LOBO", categoryId = "AC" },
            //new ProductEntity { productId = "382", productName = "INICIO ANALACERO M MAS COLA DE LOBO", productDesciption = "INICIO ANALACERO M MAS COLA DE LOBO", categoryId = "AC" },
            //new ProductEntity { productId = "383", productName = "ESPOSAS POLICE MAS PELUCHE", productDesciption = "ESPOSAS POLICE MAS PELUCHE", categoryId = "AC" },
            //new ProductEntity { productId = "384", productName = "SOGAS SUSPENSIÓN COLORES", productDesciption = "SOGAS SUSPENSIÓN COLORES", categoryId = "AC" },
            //new ProductEntity { productId = "385", productName = "MUNECO INFLABLE HOMBRE", productDesciption = "MUNECO INFLABLE HOMBRE", categoryId = "AC" },
            //new ProductEntity { productId = "386", productName = "MUÑECA INFLABES PROFESIO MANOS Y PIES SEXO ORAL", productDesciption = "MUÑECA INFLABES PROFESIO MANOS Y PIES SEXO ORAL", categoryId = "AC" },
            //new ProductEntity { productId = "387", productName = "MUÑECA INFLABLE SENCILLA MAS VAGINA + ANO", productDesciption = "MUÑECA INFLABLE SENCILLA MAS VAGINA + ANO", categoryId = "AC" },
            //new ProductEntity { productId = "388", productName = "JUEGO ESCALERA EROTICO", productDesciption = "JUEGO ESCALERA EROTICO", categoryId = "AC" },
            //new ProductEntity { productId = "389", productName = "JUEGO RULETA EROTICA", productDesciption = "JUEGO RULETA EROTICA", categoryId = "AC" },
            //new ProductEntity { productId = "390", productName = "DADOS GIGANTES MAS ACEITES PECADOS", productDesciption = "DADOS GIGANTES MAS ACEITES PECADOS", categoryId = "AC" },
            //new ProductEntity { productId = "391", productName = "DADOS EROTICOS POR DOS ILUMINOSOS", productDesciption = "DADOS EROTICOS POR DOS ILUMINOSOS", categoryId = "AC" },
            //new ProductEntity { productId = "392", productName = "DADOS EROTICOS POR TRES ILUMINOSOS", productDesciption = "DADOS EROTICOS POR TRES ILUMINOSOS", categoryId = "AC" },
            //new ProductEntity { productId = "393", productName = "DADOS EROTICOS POR DOS", productDesciption = "DADOS EROTICOS POR DOS", categoryId = "AC" },
            //new ProductEntity { productId = "394", productName = "DADOS EROTICOS POR TRES", productDesciption = "DADOS EROTICOS POR TRES", categoryId = "AC" },
            //new ProductEntity { productId = "395", productName = "PIRINOLA EROTICA POSES O PRENDAS", productDesciption = "PIRINOLA EROTICA POSES O PRENDAS", categoryId = "AC" },
            //new ProductEntity { productId = "396", productName = "POKER KAMASUTRA ROJO Y NEGRO", productDesciption = "POKER KAMASUTRA ROJO Y NEGRO", categoryId = "AC" },
            //new ProductEntity { productId = "397", productName = "DOMINO JUEGO PAREJA", productDesciption = "DOMINO JUEGO PAREJA", categoryId = "AC" },
            //new ProductEntity { productId = "398", productName = "LINTERNA MASTURBADORA MULTIVELOCIDADES", productDesciption = "LINTERNA MASTURBADORA MULTIVELOCIDADES", categoryId = "AC" },
            //new ProductEntity { productId = "399", productName = "LINTERNA MASTURBADORA MAS 7 VELOCIDADES", productDesciption = "LINTERNA MASTURBADORA MAS 7 VELOCIDADES", categoryId = "AC" },
            //new ProductEntity { productId = "400", productName = "LINTERNA MASTURBADORA", productDesciption = "LINTERNA MASTURBADORA", categoryId = "AC" },
            //new ProductEntity { productId = "401", productName = "VAGINA REAL MAS VIBRJSION", productDesciption = "VAGINA REAL MAS VIBRJSION", categoryId = "JS" },
            //new ProductEntity { productId = "402", productName = "VAGINA REAL PASSION LADY", productDesciption = "VAGINA REAL PASSION LADY", categoryId = "JS" },
            //new ProductEntity { productId = "403", productName = "HUEVITO MASTURBADOR TENGA", productDesciption = "HUEVITO MASTURBADOR TENGA", categoryId = "JS" },
            //new ProductEntity { productId = "404", productName = "VAGINA REAL YIREN", productDesciption = "VAGINA REAL YIREN", categoryId = "JS" },
            //new ProductEntity { productId = "405", productName = "VAGINA MAS PENE HERMAFRODITA", productDesciption = "VAGINA MAS PENE HERMAFRODITA", categoryId = "JS" },
            //new ProductEntity { productId = "406", productName = "ANO MAS PENE MR BIG", productDesciption = "ANO MAS PENE MR BIG", categoryId = "JS" },
            //new ProductEntity { productId = "407", productName = "MINI VAGINA TARRO CHICLE", productDesciption = "MINI VAGINA TARRO CHICLE", categoryId = "JS" },
            //new ProductEntity { productId = "408", productName = "MINI VAGINA TARRO FRESA", productDesciption = "MINI VAGINA TARRO FRESA", categoryId = "JS" },
            //new ProductEntity { productId = "409", productName = "VAGINA CIBER REAL", productDesciption = "VAGINA CIBER REAL", categoryId = "JS" },
            //new ProductEntity { productId = "410", productName = "MINI VAGINA PART 6", productDesciption = "MINI VAGINA PART 6", categoryId = "AC" },
            //new ProductEntity { productId = "411", productName = "BOMBA DE SUCCION MAS MINI VAGINA SILICONA", productDesciption = "BOMBA DE SUCCION MAS MINI VAGINA SILICONA", categoryId = "AC" },
            //new ProductEntity { productId = "412", productName = "REPUESTO CAUCHO BOMBA", productDesciption = "REPUESTO CAUCHO BOMBA", categoryId = "AC" },
            //new ProductEntity { productId = "413", productName = "BOMBA CRECIMIENTO MANS  PUMP", productDesciption = "BOMBA CRECIMIENTO MANS  PUMP", categoryId = "AC" },
            //new ProductEntity { productId = "414", productName = "BOMBA PENIS ENLARGER", productDesciption = "BOMBA PENIS ENLARGER", categoryId = "AC" },
            //new ProductEntity { productId = "415", productName = "BOMBA LUX BUSTER MAS VIBRACION", productDesciption = "BOMBA LUX BUSTER MAS VIBRACION", categoryId = "AC" },
            //new ProductEntity { productId = "416", productName = "REPUESTO BOMBA MANGUERA MAS PERA", productDesciption = "REPUESTO BOMBA MANGUERA MAS PERA", categoryId = "AC" },
            //new ProductEntity { productId = "417", productName = "ARNES SENCILLO MEDIANO", productDesciption = "ARNES SENCILLO MEDIANO", categoryId = "AC" },
            //new ProductEntity { productId = "418", productName = "ARNES SENCILLO BULLDOG", productDesciption = "ARNES SENCILLO BULLDOG", categoryId = "AC" },
            //new ProductEntity { productId = "419", productName = "ARNES INFLABLE TESTICULOS", productDesciption = "ARNES INFLABLE TESTICULOS", categoryId = "AC" },
            //new ProductEntity { productId = "420", productName = "ARNES DE CONEJO ROTATORIO", productDesciption = "ARNES DE CONEJO ROTATORIO", categoryId = "AC" },
            //new ProductEntity { productId = "421", productName = "ARNES DOBLE PENETRACION", productDesciption = "ARNES DOBLE PENETRACION", categoryId = "AC" },
            //new ProductEntity { productId = "422", productName = "ARNES G SPOT", productDesciption = "ARNES G SPOT", categoryId = "AC" },
            //new ProductEntity { productId = "423", productName = "ARNES CONEJO ROTATORIO", productDesciption = "ARNES CONEJO ROTATORIO", categoryId = "AC" },
            //new ProductEntity { productId = "424", productName = "ARNES ULTRA SILICONE MAS VIBRACION PUNTO G", productDesciption = "ARNES ULTRA SILICONE MAS VIBRACION PUNTO G", categoryId = "AC" },
            //new ProductEntity { productId = "425", productName = "ARNES ULTRA #1 SUPER PENETRIS", productDesciption = "ARNES ULTRA #1 SUPER PENETRIS", categoryId = "AC" },
            //new ProductEntity { productId = "426", productName = "ARNES ULTRA #2 SUPER PENETRIS", productDesciption = "ARNES ULTRA #2 SUPER PENETRIS", categoryId = "AC" },
            //new ProductEntity { productId = "427", productName = "ARNES HUECO PARA CABALLERO", productDesciption = "ARNES HUECO PARA CABALLERO", categoryId = "AC" },
            //new ProductEntity { productId = "428", productName = "ARNES CHINO SILICONA HUECO", productDesciption = "ARNES CHINO SILICONA HUECO", categoryId = "AC" },
            //new ProductEntity { productId = "429", productName = "DILDO FLORECITA", productDesciption = "DILDO FLORECITA", categoryId = "AC" },
            //new ProductEntity { productId = "430", productName = "DILDO SKIN #1", productDesciption = "DILDO SKIN #1", categoryId = "AC" },
            //new ProductEntity { productId = "431", productName = "DILDO SKIN #2", productDesciption = "DILDO SKIN #2", categoryId = "AC" },
            //new ProductEntity { productId = "432", productName = "DILDO SKIN #3", productDesciption = "DILDO SKIN #3", categoryId = "AC" },
            //new ProductEntity { productId = "433", productName = "DILDO BULLDOG", productDesciption = "DILDO BULLDOG", categoryId = "AC" },
            //new ProductEntity { productId = "434", productName = "DILDO CILINDRO", productDesciption = "DILDO CILINDRO", categoryId = "AC" },
            //new ProductEntity { productId = "435", productName = "DILDO TESTICULOS", productDesciption = "DILDO TESTICULOS", categoryId = "AC" },
            //new ProductEntity { productId = "436", productName = "DILDO PEZ", productDesciption = "DILDO PEZ", categoryId = "AC" },
            //new ProductEntity { productId = "437", productName = "DILDO LARGO LISO", productDesciption = "DILDO LARGO LISO", categoryId = "AC" },
            //new ProductEntity { productId = "438", productName = "DONG CARVED 7 MAS CHUPA SILICONA", productDesciption = "DONG CARVED 7 MAS CHUPA SILICONA", categoryId = "AC" },
            //new ProductEntity { productId = "439", productName = "DONG CARVED 8 MAS CHUPA SILICONA", productDesciption = "DONG CARVED 8 MAS CHUPA SILICONA", categoryId = "AC" },
            //new ProductEntity { productId = "440", productName = "DONG CARVER 9 MAS CHUPA SILICONA", productDesciption = "DONG CARVER 9 MAS CHUPA SILICONA", categoryId = "AC" },
            //new ProductEntity { productId = "441", productName = "DONG LARGO LISO SILICONA PIEL MAS CHUPA", productDesciption = "DONG LARGO LISO SILICONA PIEL MAS CHUPA", categoryId = "AC" },
            //new ProductEntity { productId = "442", productName = "DONG LARGO LISO SILICONA MAS CHUPA MORADO", productDesciption = "DONG LARGO LISO SILICONA MAS CHUPA MORADO", categoryId = "AC" },
            //new ProductEntity { productId = "443", productName = "DONG LARGO LISO SILICONA ROSADO MAS CHUPA", productDesciption = "DONG LARGO LISO SILICONA ROSADO MAS CHUPA", categoryId = "AC" },
            //new ProductEntity { productId = "444", productName = "DONG LARGO LISO SILICONA ROJO MAS CHUPA", productDesciption = "DONG LARGO LISO SILICONA ROJO MAS CHUPA", categoryId = "AC" },
            //new ProductEntity { productId = "445", productName = "DONG FLORECITA SILICONA MORADO MAS CHUPA", productDesciption = "DONG FLORECITA SILICONA MORADO MAS CHUPA", categoryId = "AC" },
            //new ProductEntity { productId = "446", productName = "DONG FLORECITA SILICONA ROSADO MAS CHUPA", productDesciption = "DONG FLORECITA SILICONA ROSADO MAS CHUPA", categoryId = "AC" },
            //new ProductEntity { productId = "447", productName = "DONG FLORECITA SILICONA ROJO MAS CHUPA", productDesciption = "DONG FLORECITA SILICONA ROJO MAS CHUPA", categoryId = "AC" },
            //new ProductEntity { productId = "518", productName = "FANTASTICO PLUMA ROSADO", productDesciption = "FANTASTICO PLUMA ROSADO", categoryId = "AC" },
            //new ProductEntity { productId = "519", productName = "FANTASY PLUMA ROJA", productDesciption = "FANTASY PLUMA ROJA", categoryId = "AC" },
            //new ProductEntity { productId = "520", productName = "FANTASY PLUMA NEGRO", productDesciption = "FANTASY PLUMA NEGRO", categoryId = "AC" },
            //new ProductEntity { productId = "521", productName = "STRONGER SUCCTION", productDesciption = "STRONGER SUCCTION", categoryId = "AC" },
            //new ProductEntity { productId = "522", productName = "CORREA PARA DILDO ORGASM SERIES", productDesciption = "CORREA PARA DILDO ORGASM SERIES", categoryId = "AC" },
            //new ProductEntity { productId = "523", productName = "FUR LOVE CUFFS", productDesciption = "FUR LOVE CUFFS", categoryId = "AC" },
            //new ProductEntity { productId = "524", productName = "BOLAS LIKE A VIRGIN", productDesciption = "BOLAS LIKE A VIRGIN", categoryId = "AC" },
            //new ProductEntity { productId = "525", productName = "VIBRATOR LURE 8", productDesciption = "VIBRATOR LURE 8", categoryId = "AC" },
            //new ProductEntity { productId = "526", productName = "DEVIL DICK", productDesciption = "DEVIL DICK", categoryId = "AC" },
            //new ProductEntity { productId = "527", productName = "PERFECT G-SPOT", productDesciption = "PERFECT G-SPOT", categoryId = "AC" },
            //new ProductEntity { productId = "528", productName = "PERFECT G VIBE", productDesciption = "PERFECT G VIBE", categoryId = "AC" },
            //new ProductEntity { productId = "529", productName = "G-SPOT DOBLE", productDesciption = "G-SPOT DOBLE", categoryId = "AC" },
            //new ProductEntity { productId = "530", productName = "VIBRO FINGER", productDesciption = "VIBRO FINGER", categoryId = "AC" },
            //new ProductEntity { productId = "531", productName = "DUCHAS ANALES", productDesciption = "DUCHAS ANALES", categoryId = "AC" },
            //new ProductEntity { productId = "532", productName = "ARNES RABIT 8.5", productDesciption = "ARNES RABIT 8.5", categoryId = "AC" },
            //new ProductEntity { productId = "533", productName = "MUÑECO MASTURBADOR MACHO MAN", productDesciption = "MUÑECO MASTURBADOR MACHO MAN", categoryId = "AC" },
            //new ProductEntity { productId = "534", productName = "SNAPPY PIEL RECARGABLE", productDesciption = "SNAPPY PIEL RECARGABLE", categoryId = "AC" },
            //new ProductEntity { productId = "535", productName = "LILO CHIMONG", productDesciption = "LILO CHIMONG", categoryId = "AC" },
            //new ProductEntity { productId = "536", productName = "SLIDE LUBRICANTE 1000 ML ", productDesciption = "SLIDE LUBRICANTE 1000 ML ", categoryId = "AC" },
            //new ProductEntity { productId = "537", productName = "MAGIC MASSAGER GIGANTE", productDesciption = "MAGIC MASSAGER GIGANTE", categoryId = "AC" },
            //new ProductEntity { productId = "538", productName = "VAGINA GLOW PIEL", productDesciption = "VAGINA GLOW PIEL", categoryId = "AC" },
            //new ProductEntity { productId = "539", productName = "STUNING PLUG", productDesciption = "STUNING PLUG", categoryId = "AC" },
            //new ProductEntity { productId = "540", productName = "MASTURBADOR QUING", productDesciption = "MASTURBADOR QUING", categoryId = "AC" },
            //new ProductEntity { productId = "541", productName = "HUEVO VIBRADOR TRIPLE ESTIMULOSION", productDesciption = "HUEVO VIBRADOR TRIPLE ESTIMULOSION", categoryId = "OS" },
            //new ProductEntity { productId = "542", productName = "MONSTER BULLET DOBLE", productDesciption = "MONSTER BULLET DOBLE", categoryId = "OS" },
            //new ProductEntity { productId = "543", productName = "INICIADOR ANAL VIBROSION MINI", productDesciption = "INICIADOR ANAL VIBROSION MINI", categoryId = "OS" },
            //new ProductEntity { productId = "544", productName = "ARNES CLITORIAL MARIPOSA YEHING", productDesciption = "ARNES CLITORIAL MARIPOSA YEHING", categoryId = "OS" },
            //new ProductEntity { productId = "545", productName = "COOL PISTON MOSHINE", productDesciption = "COOL PISTON MOSHINE", categoryId = "OS" },
            //new ProductEntity { productId = "546", productName = "GUN MOSHINE", productDesciption = "GUN MOSHINE", categoryId = "OS" },
            //new ProductEntity { productId = "547", productName = "ROBO FUK", productDesciption = "ROBO FUK", categoryId = "OS" },
            //new ProductEntity { productId = "548", productName = "ARNES LUXURY", productDesciption = "ARNES LUXURY", categoryId = "OS" },
            //new ProductEntity { productId = "549", productName = "VIBRADOR CHOCOLATE GRANDE Y PEQUEÑO", productDesciption = "VIBRADOR CHOCOLATE GRANDE Y PEQUEÑO", categoryId = "OS" },
            //new ProductEntity { productId = "550", productName = "VIBRADOR VENOSO SILICONA", productDesciption = "VIBRADOR VENOSO SILICONA", categoryId = "OS" },
            //new ProductEntity { productId = "551", productName = "VIBRADOR VENOSO CABEZON", productDesciption = "VIBRADOR VENOSO CABEZON", categoryId = "OS" },
            //new ProductEntity { productId = "552", productName = "VIBRADOR VENOSO # 3", productDesciption = "VIBRADOR VENOSO # 3", categoryId = "OS" },
            //new ProductEntity { productId = "553", productName = "VIBRADOR SKIN SILICONA", productDesciption = "VIBRADOR SKIN SILICONA", categoryId = "OS" },
            //new ProductEntity { productId = "554", productName = "DONG GIGANTE 30 CM", productDesciption = "DONG GIGANTE 30 CM", categoryId = "OS" },
            //new ProductEntity { productId = "555", productName = "LUBRICANTE ANAL COJIN", productDesciption = "LUBRICANTE ANAL COJIN", categoryId = "OS" },
            //new ProductEntity { productId = "556", productName = "LUBRICANTE ANAL COJIN CHERRY", productDesciption = "LUBRICANTE ANAL COJIN CHERRY", categoryId = "OS" },
            //new ProductEntity { productId = "557", productName = "DILATADOR COJIN ANAL BLUE", productDesciption = "DILATADOR COJIN ANAL BLUE", categoryId = "OS" },
            //new ProductEntity { productId = "558", productName = "MULTIORGASMO FORIA COJIN", productDesciption = "MULTIORGASMO FORIA COJIN", categoryId = "OS" },
            //new ProductEntity { productId = "559", productName = "ESTRECHANTE LIFE VIRGIN COJIN", productDesciption = "ESTRECHANTE LIFE VIRGIN COJIN", categoryId = "OS" },
            //new ProductEntity { productId = "560", productName = "DILATADOR COJIN EXXTREME", productDesciption = "DILATADOR COJIN EXXTREME", categoryId = "OS" },
            //new ProductEntity { productId = "561", productName = "MULTIORGASMO AROUSAL COJIN", productDesciption = "MULTIORGASMO AROUSAL COJIN", categoryId = "OS" },
            //new ProductEntity { productId = "562", productName = "LIUBRICANTE NEUTRO SILICONA COJIN", productDesciption = "LIUBRICANTE NEUTRO SILICONA COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "563", productName = "LUBRICANTE CALIENTE COJIN", productDesciption = "LUBRICANTE CALIENTE COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "564", productName = "LUEITE CALIENTE CHAMPAN COJIN", productDesciption = "LUEITE CALIENTE CHAMPAN COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "565", productName = "LUBRICANTE FRIXXXKY COJIN", productDesciption = "LUBRICANTE FRIXXXKY COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "566", productName = "DILATADOR ANAL RUSH COJIN", productDesciption = "DILATADOR ANAL RUSH COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "567", productName = "RETARDANTE RETADEX COJIN", productDesciption = "RETARDANTE RETADEX COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "568", productName = "BLLUK -ICE FRIO CALIENTE COJIN", productDesciption = "BLLUK -ICE FRIO CALIENTE COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "569", productName = "STRIPER RETARDANTE ENGROSANTE COJIN", productDesciption = "STRIPER RETARDANTE ENGROSANTE COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "570", productName = "EXCITANTE DAMA GOLD FLY COJIN", productDesciption = "EXCITANTE DAMA GOLD FLY COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "571", productName = "CHOCOLATE SEXO ORAL COJIN", productDesciption = "CHOCOLATE SEXO ORAL COJIN", categoryId = "LU" },
            //new ProductEntity { productId = "572", productName = "OSEITES CALIENTES COMESTIBLES COJIN", productDesciption = "OSEITES CALIENTES COMESTIBLES COJIN", categoryId = "OS" },
            //new ProductEntity { productId = "573", productName = "RETARDANTE MAX MAN COJIN", productDesciption = "RETARDANTE MAX MAN COJIN", categoryId = "OS" },
            //new ProductEntity { productId = "574", productName = "ULTRA DOBLE", productDesciption = "ULTRA DOBLE", categoryId = "OS" },
            //new ProductEntity { productId = "575", productName = " ANAL BLUE Y RED", productDesciption = " ANAL BLUE Y RED", categoryId = "OS" },
            //new ProductEntity { productId = "576", productName = "MINI SILICONA", productDesciption = "MINI SILICONA", categoryId = "OS" },
            //new ProductEntity { productId = "577", productName = "DILATADOR ANAL 100ML", productDesciption = "DILATADOR ANAL 100ML", categoryId = "OS" },
            //new ProductEntity { productId = "578", productName = "GAY LUBE 100ML", productDesciption = "GAY LUBE 100ML", categoryId = "OS" },
            //new ProductEntity { productId = "579", productName = "LUBRICANTE HOT & REFRESH 100ML", productDesciption = "LUBRICANTE HOT & REFRESH 100ML", categoryId = "LU" },
            //new ProductEntity { productId = "580", productName = "LUBRICANTE GRAPE 100ML", productDesciption = "LUBRICANTE GRAPE 100ML", categoryId = "LU" },
            //new ProductEntity { productId = "581", productName = "LUBRICANTE APPLE 100ML", productDesciption = "LUBRICANTE APPLE 100ML", categoryId = "LU" },
            //new ProductEntity { productId = "582", productName = "LUBRICANTE ICE 100ML", productDesciption = "LUBRICANTE ICE 100ML", categoryId = "LU" },
            //new ProductEntity { productId = "583", productName = "LUBRICANTE HOT 100ML", productDesciption = "LUBRICANTE HOT 100ML", categoryId = "LU" },
            //new ProductEntity { productId = "584", productName = "LUBRICANTE STRAWBERRY 100ML", productDesciption = "LUBRICANTE STRAWBERRY 100ML", categoryId = "LU" },
            //new ProductEntity { productId = "585", productName = "LUBRICANTE NEUTRO 100ML", productDesciption = "LUBRICANTE NEUTRO 100ML", categoryId = "LU" },
            //new ProductEntity { productId = "586", productName = "LUBRICANTE DOBLE SENSLUION FRIO CALIENTE", productDesciption = "LUBRICANTE DOBLE SENSLUION FRIO CALIENTE", categoryId = "LU" },
            //new ProductEntity { productId = "587", productName = "LUBRICANTE APARIENCIA SEMEN", productDesciption = "LUBRICANTE APARIENCIA SEMEN", categoryId = "LU" },
            //new ProductEntity { productId = "588", productName = "SPANISH FLY 30ML", productDesciption = "SPANISH FLY 30ML", categoryId = "AC" }
            //                );

        }

    }
}
