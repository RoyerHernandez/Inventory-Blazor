using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<string>(maxLength: 100, nullable: false),
                    categoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    clientId = table.Column<int>(maxLength: 12, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clientName = table.Column<string>(maxLength: 50, nullable: false),
                    clientLastName = table.Column<string>(maxLength: 50, nullable: false),
                    clientAddres = table.Column<string>(nullable: false),
                    numberPhone = table.Column<int>(maxLength: 10, nullable: false),
                    eMail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.clientId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<string>(nullable: false),
                    clientId = table.Column<int>(maxLength: 12, nullable: false),
                    clientFullname = table.Column<string>(maxLength: 150, nullable: true),
                    productName = table.Column<string>(nullable: true),
                    unitPrice = table.Column<decimal>(nullable: false),
                    totalPrice = table.Column<decimal>(nullable: false),
                    IsAdd = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    warehouseId = table.Column<string>(maxLength: 100, nullable: false),
                    warehouseName = table.Column<string>(nullable: false),
                    warehouseAddress = table.Column<string>(nullable: true),
                    WarehouseEntitywarehouseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.warehouseId);
                    table.ForeignKey(
                        name: "FK_Warehouses_Warehouses_WarehouseEntitywarehouseId",
                        column: x => x.WarehouseEntitywarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "warehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<string>(maxLength: 100, nullable: false),
                    productName = table.Column<string>(nullable: false),
                    productDesciption = table.Column<string>(nullable: true),
                    totalQuantity = table.Column<int>(nullable: false),
                    unitPrice = table.Column<decimal>(nullable: false),
                    categoryId = table.Column<string>(nullable: false),
                    WarehouseEntitywarehouseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Products_Warehouses_WarehouseEntitywarehouseId",
                        column: x => x.WarehouseEntitywarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "warehouseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    storageId = table.Column<string>(maxLength: 100, nullable: false),
                    partialQuantity = table.Column<int>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    warehouseId = table.Column<string>(nullable: true),
                    productId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.storageId);
                    table.ForeignKey(
                        name: "FK_Storages_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Storages_Warehouses_warehouseId",
                        column: x => x.warehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "warehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InOuts",
                columns: table => new
                {
                    inOutsID = table.Column<string>(maxLength: 100, nullable: false),
                    InOutDate = table.Column<DateTime>(nullable: false),
                    Quality = table.Column<int>(nullable: false),
                    IsInput = table.Column<bool>(nullable: false),
                    storageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOuts", x => x.inOutsID);
                    table.ForeignKey(
                        name: "FK_InOuts_Storages_storageId",
                        column: x => x.storageId,
                        principalTable: "Storages",
                        principalColumn: "storageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[,]
                {
                    { "AC", "Aceites" },
                    { "LU", "Lubricantes" },
                    { "VI", "Vibradores" },
                    { "JS", "Juguetes Sexuales" },
                    { "OS", "Otros" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[,]
                {
                    { "cf9d55a2-c52b-46e8-82f4-691602f046d5", null, "Calle 8 con 23", "Bodega Central" },
                    { "7cb8e915-5704-41ad-8e4e-090cb95246aa", null, "Calle norte con occidente", "Bodega Sur" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "WarehouseEntitywarehouseId", "categoryId", "productDesciption", "productName", "totalQuantity", "unitPrice" },
                values: new object[,]
                {
                    { "100", null, "AC", "ACEITE CALIENTE SKIN 30ML", "ACEITE CALIENTE SKIN 30ML", 0, 0m },
                    { "438", null, "AC", "DONG CARVED 7 MAS CHUPA SILICONA", "DONG CARVED 7 MAS CHUPA SILICONA", 0, 0m },
                    { "439", null, "AC", "DONG CARVED 8 MAS CHUPA SILICONA", "DONG CARVED 8 MAS CHUPA SILICONA", 0, 0m },
                    { "440", null, "AC", "DONG CARVER 9 MAS CHUPA SILICONA", "DONG CARVER 9 MAS CHUPA SILICONA", 0, 0m },
                    { "441", null, "AC", "DONG LARGO LISO SILICONA PIEL MAS CHUPA", "DONG LARGO LISO SILICONA PIEL MAS CHUPA", 0, 0m },
                    { "442", null, "AC", "DONG LARGO LISO SILICONA MAS CHUPA MORADO", "DONG LARGO LISO SILICONA MAS CHUPA MORADO", 0, 0m },
                    { "443", null, "AC", "DONG LARGO LISO SILICONA ROSADO MAS CHUPA", "DONG LARGO LISO SILICONA ROSADO MAS CHUPA", 0, 0m },
                    { "444", null, "AC", "DONG LARGO LISO SILICONA ROJO MAS CHUPA", "DONG LARGO LISO SILICONA ROJO MAS CHUPA", 0, 0m },
                    { "445", null, "AC", "DONG FLORECITA SILICONA MORADO MAS CHUPA", "DONG FLORECITA SILICONA MORADO MAS CHUPA", 0, 0m },
                    { "446", null, "AC", "DONG FLORECITA SILICONA ROSADO MAS CHUPA", "DONG FLORECITA SILICONA ROSADO MAS CHUPA", 0, 0m },
                    { "447", null, "AC", "DONG FLORECITA SILICONA ROJO MAS CHUPA", "DONG FLORECITA SILICONA ROJO MAS CHUPA", 0, 0m },
                    { "518", null, "AC", "FANTASTICO PLUMA ROSADO", "FANTASTICO PLUMA ROSADO", 0, 0m },
                    { "519", null, "AC", "FANTASY PLUMA ROJA", "FANTASY PLUMA ROJA", 0, 0m },
                    { "520", null, "AC", "FANTASY PLUMA NEGRO", "FANTASY PLUMA NEGRO", 0, 0m },
                    { "521", null, "AC", "STRONGER SUCCTION", "STRONGER SUCCTION", 0, 0m },
                    { "522", null, "AC", "CORREA PARA DILDO ORGASM SERIES", "CORREA PARA DILDO ORGASM SERIES", 0, 0m },
                    { "523", null, "AC", "FUR LOVE CUFFS", "FUR LOVE CUFFS", 0, 0m },
                    { "524", null, "AC", "BOLAS LIKE A VIRGIN", "BOLAS LIKE A VIRGIN", 0, 0m },
                    { "538", null, "AC", "VAGINA GLOW PIEL", "VAGINA GLOW PIEL", 0, 0m },
                    { "537", null, "AC", "MAGIC MASSAGER GIGANTE", "MAGIC MASSAGER GIGANTE", 0, 0m },
                    { "536", null, "AC", "SLIDE LUBRICANTE 1000 ML ", "SLIDE LUBRICANTE 1000 ML ", 0, 0m },
                    { "535", null, "AC", "LILO CHIMONG", "LILO CHIMONG", 0, 0m },
                    { "534", null, "AC", "SNAPPY PIEL RECARGABLE", "SNAPPY PIEL RECARGABLE", 0, 0m },
                    { "533", null, "AC", "MUÑECO MASTURBADOR MACHO MAN", "MUÑECO MASTURBADOR MACHO MAN", 0, 0m },
                    { "437", null, "AC", "DILDO LARGO LISO", "DILDO LARGO LISO", 0, 0m },
                    { "532", null, "AC", "ARNES RABIT 8.5", "ARNES RABIT 8.5", 0, 0m },
                    { "530", null, "AC", "VIBRO FINGER", "VIBRO FINGER", 0, 0m },
                    { "529", null, "AC", "G-SPOT DOBLE", "G-SPOT DOBLE", 0, 0m },
                    { "528", null, "AC", "PERFECT G VIBE", "PERFECT G VIBE", 0, 0m },
                    { "527", null, "AC", "PERFECT G-SPOT", "PERFECT G-SPOT", 0, 0m },
                    { "526", null, "AC", "DEVIL DICK", "DEVIL DICK", 0, 0m },
                    { "525", null, "AC", "VIBRATOR LURE 8", "VIBRATOR LURE 8", 0, 0m },
                    { "531", null, "AC", "DUCHAS ANALES", "DUCHAS ANALES", 0, 0m },
                    { "539", null, "AC", "STUNING PLUG", "STUNING PLUG", 0, 0m },
                    { "436", null, "AC", "DILDO PEZ", "DILDO PEZ", 0, 0m },
                    { "434", null, "AC", "DILDO CILINDRO", "DILDO CILINDRO", 0, 0m },
                    { "394", null, "AC", "DADOS EROTICOS POR TRES", "DADOS EROTICOS POR TRES", 0, 0m },
                    { "395", null, "AC", "PIRINOLA EROTICA POSES O PRENDAS", "PIRINOLA EROTICA POSES O PRENDAS", 0, 0m },
                    { "396", null, "AC", "POKER KAMASUTRA ROJO Y NEGRO", "POKER KAMASUTRA ROJO Y NEGRO", 0, 0m },
                    { "397", null, "AC", "DOMINO JUEGO PAREJA", "DOMINO JUEGO PAREJA", 0, 0m },
                    { "398", null, "AC", "LINTERNA MASTURBADORA MULTIVELOCIDADES", "LINTERNA MASTURBADORA MULTIVELOCIDADES", 0, 0m },
                    { "399", null, "AC", "LINTERNA MASTURBADORA MAS 7 VELOCIDADES", "LINTERNA MASTURBADORA MAS 7 VELOCIDADES", 0, 0m },
                    { "400", null, "AC", "LINTERNA MASTURBADORA", "LINTERNA MASTURBADORA", 0, 0m },
                    { "410", null, "AC", "MINI VAGINA PART 6", "MINI VAGINA PART 6", 0, 0m },
                    { "411", null, "AC", "BOMBA DE SUCCION MAS MINI VAGINA SILICONA", "BOMBA DE SUCCION MAS MINI VAGINA SILICONA", 0, 0m },
                    { "412", null, "AC", "REPUESTO CAUCHO BOMBA", "REPUESTO CAUCHO BOMBA", 0, 0m },
                    { "413", null, "AC", "BOMBA CRECIMIENTO MANS  PUMP", "BOMBA CRECIMIENTO MANS  PUMP", 0, 0m },
                    { "414", null, "AC", "BOMBA PENIS ENLARGER", "BOMBA PENIS ENLARGER", 0, 0m },
                    { "415", null, "AC", "BOMBA LUX BUSTER MAS VIBRACION", "BOMBA LUX BUSTER MAS VIBRACION", 0, 0m },
                    { "416", null, "AC", "REPUESTO BOMBA MANGUERA MAS PERA", "REPUESTO BOMBA MANGUERA MAS PERA", 0, 0m },
                    { "417", null, "AC", "ARNES SENCILLO MEDIANO", "ARNES SENCILLO MEDIANO", 0, 0m },
                    { "418", null, "AC", "ARNES SENCILLO BULLDOG", "ARNES SENCILLO BULLDOG", 0, 0m },
                    { "419", null, "AC", "ARNES INFLABLE TESTICULOS", "ARNES INFLABLE TESTICULOS", 0, 0m },
                    { "433", null, "AC", "DILDO BULLDOG", "DILDO BULLDOG", 0, 0m },
                    { "432", null, "AC", "DILDO SKIN #3", "DILDO SKIN #3", 0, 0m },
                    { "431", null, "AC", "DILDO SKIN #2", "DILDO SKIN #2", 0, 0m },
                    { "430", null, "AC", "DILDO SKIN #1", "DILDO SKIN #1", 0, 0m },
                    { "429", null, "AC", "DILDO FLORECITA", "DILDO FLORECITA", 0, 0m },
                    { "428", null, "AC", "ARNES CHINO SILICONA HUECO", "ARNES CHINO SILICONA HUECO", 0, 0m },
                    { "435", null, "AC", "DILDO TESTICULOS", "DILDO TESTICULOS", 0, 0m },
                    { "427", null, "AC", "ARNES HUECO PARA CABALLERO", "ARNES HUECO PARA CABALLERO", 0, 0m },
                    { "425", null, "AC", "ARNES ULTRA #1 SUPER PENETRIS", "ARNES ULTRA #1 SUPER PENETRIS", 0, 0m },
                    { "424", null, "AC", "ARNES ULTRA SILICONE MAS VIBRACION PUNTO G", "ARNES ULTRA SILICONE MAS VIBRACION PUNTO G", 0, 0m },
                    { "423", null, "AC", "ARNES CONEJO ROTATORIO", "ARNES CONEJO ROTATORIO", 0, 0m },
                    { "422", null, "AC", "ARNES G SPOT", "ARNES G SPOT", 0, 0m },
                    { "421", null, "AC", "ARNES DOBLE PENETRACION", "ARNES DOBLE PENETRACION", 0, 0m },
                    { "420", null, "AC", "ARNES DE CONEJO ROTATORIO", "ARNES DE CONEJO ROTATORIO", 0, 0m },
                    { "426", null, "AC", "ARNES ULTRA #2 SUPER PENETRIS", "ARNES ULTRA #2 SUPER PENETRIS", 0, 0m },
                    { "393", null, "AC", "DADOS EROTICOS POR DOS", "DADOS EROTICOS POR DOS", 0, 0m },
                    { "540", null, "AC", "MASTURBADOR QUING", "MASTURBADOR QUING", 0, 0m },
                    { "562", null, "LU", "LIUBRICANTE NEUTRO SILICONA COJIN", "LIUBRICANTE NEUTRO SILICONA COJIN", 0, 0m },
                    { "405", null, "JS", "VAGINA MAS PENE HERMAFRODITA", "VAGINA MAS PENE HERMAFRODITA", 0, 0m },
                    { "406", null, "JS", "ANO MAS PENE MR BIG", "ANO MAS PENE MR BIG", 0, 0m },
                    { "407", null, "JS", "MINI VAGINA TARRO CHICLE", "MINI VAGINA TARRO CHICLE", 0, 0m },
                    { "408", null, "JS", "MINI VAGINA TARRO FRESA", "MINI VAGINA TARRO FRESA", 0, 0m },
                    { "409", null, "JS", "VAGINA CIBER REAL", "VAGINA CIBER REAL", 0, 0m },
                    { "541", null, "OS", "HUEVO VIBRADOR TRIPLE ESTIMULOSION", "HUEVO VIBRADOR TRIPLE ESTIMULOSION", 0, 0m },
                    { "542", null, "OS", "MONSTER BULLET DOBLE", "MONSTER BULLET DOBLE", 0, 0m },
                    { "543", null, "OS", "INICIADOR ANAL VIBROSION MINI", "INICIADOR ANAL VIBROSION MINI", 0, 0m },
                    { "544", null, "OS", "ARNES CLITORIAL MARIPOSA YEHING", "ARNES CLITORIAL MARIPOSA YEHING", 0, 0m },
                    { "545", null, "OS", "COOL PISTON MOSHINE", "COOL PISTON MOSHINE", 0, 0m },
                    { "546", null, "OS", "GUN MOSHINE", "GUN MOSHINE", 0, 0m },
                    { "547", null, "OS", "ROBO FUK", "ROBO FUK", 0, 0m },
                    { "548", null, "OS", "ARNES LUXURY", "ARNES LUXURY", 0, 0m },
                    { "549", null, "OS", "VIBRADOR CHOCOLATE GRANDE Y PEQUEÑO", "VIBRADOR CHOCOLATE GRANDE Y PEQUEÑO", 0, 0m },
                    { "550", null, "OS", "VIBRADOR VENOSO SILICONA", "VIBRADOR VENOSO SILICONA", 0, 0m },
                    { "551", null, "OS", "VIBRADOR VENOSO CABEZON", "VIBRADOR VENOSO CABEZON", 0, 0m },
                    { "552", null, "OS", "VIBRADOR VENOSO # 3", "VIBRADOR VENOSO # 3", 0, 0m },
                    { "576", null, "OS", "MINI SILICONA", "MINI SILICONA", 0, 0m },
                    { "575", null, "OS", " ANAL BLUE Y RED", " ANAL BLUE Y RED", 0, 0m },
                    { "574", null, "OS", "ULTRA DOBLE", "ULTRA DOBLE", 0, 0m },
                    { "573", null, "OS", "RETARDANTE MAX MAN COJIN", "RETARDANTE MAX MAN COJIN", 0, 0m },
                    { "572", null, "OS", "OSEITES CALIENTES COMESTIBLES COJIN", "OSEITES CALIENTES COMESTIBLES COJIN", 0, 0m },
                    { "561", null, "OS", "MULTIORGASMO AROUSAL COJIN", "MULTIORGASMO AROUSAL COJIN", 0, 0m },
                    { "404", null, "JS", "VAGINA REAL YIREN", "VAGINA REAL YIREN", 0, 0m },
                    { "560", null, "OS", "DILATADOR COJIN EXXTREME", "DILATADOR COJIN EXXTREME", 0, 0m },
                    { "558", null, "OS", "MULTIORGASMO FORIA COJIN", "MULTIORGASMO FORIA COJIN", 0, 0m },
                    { "557", null, "OS", "DILATADOR COJIN ANAL BLUE", "DILATADOR COJIN ANAL BLUE", 0, 0m },
                    { "556", null, "OS", "LUBRICANTE ANAL COJIN CHERRY", "LUBRICANTE ANAL COJIN CHERRY", 0, 0m },
                    { "555", null, "OS", "LUBRICANTE ANAL COJIN", "LUBRICANTE ANAL COJIN", 0, 0m },
                    { "554", null, "OS", "DONG GIGANTE 30 CM", "DONG GIGANTE 30 CM", 0, 0m },
                    { "553", null, "OS", "VIBRADOR SKIN SILICONA", "VIBRADOR SKIN SILICONA", 0, 0m },
                    { "559", null, "OS", "ESTRECHANTE LIFE VIRGIN COJIN", "ESTRECHANTE LIFE VIRGIN COJIN", 0, 0m },
                    { "588", null, "AC", "SPANISH FLY 30ML", "SPANISH FLY 30ML", 0, 0m },
                    { "403", null, "JS", "HUEVITO MASTURBADOR TENGA", "HUEVITO MASTURBADOR TENGA", 0, 0m },
                    { "401", null, "JS", "VAGINA REAL MAS VIBRJSION", "VAGINA REAL MAS VIBRJSION", 0, 0m },
                    { "563", null, "LU", "LUBRICANTE CALIENTE COJIN", "LUBRICANTE CALIENTE COJIN", 0, 0m },
                    { "564", null, "LU", "LUEITE CALIENTE CHAMPAN COJIN", "LUEITE CALIENTE CHAMPAN COJIN", 0, 0m },
                    { "565", null, "LU", "LUBRICANTE FRIXXXKY COJIN", "LUBRICANTE FRIXXXKY COJIN", 0, 0m },
                    { "566", null, "LU", "DILATADOR ANAL RUSH COJIN", "DILATADOR ANAL RUSH COJIN", 0, 0m },
                    { "567", null, "LU", "RETARDANTE RETADEX COJIN", "RETARDANTE RETADEX COJIN", 0, 0m },
                    { "568", null, "LU", "BLLUK -ICE FRIO CALIENTE COJIN", "BLLUK -ICE FRIO CALIENTE COJIN", 0, 0m },
                    { "569", null, "LU", "STRIPER RETARDANTE ENGROSANTE COJIN", "STRIPER RETARDANTE ENGROSANTE COJIN", 0, 0m },
                    { "570", null, "LU", "EXCITANTE DAMA GOLD FLY COJIN", "EXCITANTE DAMA GOLD FLY COJIN", 0, 0m },
                    { "571", null, "LU", "CHOCOLATE SEXO ORAL COJIN", "CHOCOLATE SEXO ORAL COJIN", 0, 0m },
                    { "579", null, "LU", "LUBRICANTE HOT & REFRESH 100ML", "LUBRICANTE HOT & REFRESH 100ML", 0, 0m },
                    { "580", null, "LU", "LUBRICANTE GRAPE 100ML", "LUBRICANTE GRAPE 100ML", 0, 0m },
                    { "581", null, "LU", "LUBRICANTE APPLE 100ML", "LUBRICANTE APPLE 100ML", 0, 0m },
                    { "582", null, "LU", "LUBRICANTE ICE 100ML", "LUBRICANTE ICE 100ML", 0, 0m },
                    { "583", null, "LU", "LUBRICANTE HOT 100ML", "LUBRICANTE HOT 100ML", 0, 0m },
                    { "584", null, "LU", "LUBRICANTE STRAWBERRY 100ML", "LUBRICANTE STRAWBERRY 100ML", 0, 0m },
                    { "585", null, "LU", "LUBRICANTE NEUTRO 100ML", "LUBRICANTE NEUTRO 100ML", 0, 0m },
                    { "586", null, "LU", "LUBRICANTE DOBLE SENSLUION FRIO CALIENTE", "LUBRICANTE DOBLE SENSLUION FRIO CALIENTE", 0, 0m },
                    { "289", null, "VI", "VIBRADOR  GK TRIPLE ESTIMULVIION.", "VIBRADOR  GK TRIPLE ESTIMULVIION.", 0, 0m },
                    { "288", null, "VI", "VIBRADOR DUAL PENETRATOR", "VIBRADOR DUAL PENETRATOR", 0, 0m },
                    { "287", null, "VI", "CONSOLADOR DOBLE PUNTA", "CONSOLADOR DOBLE PUNTA", 0, 0m },
                    { "286", null, "VI", "VIBRADOR DOBLE ROLLING  ROTATORIO", "VIBRADOR DOBLE ROLLING  ROTATORIO", 0, 0m },
                    { "285", null, "VI", "HUEVO VIBRADOR TRIPLE ESTIMULVIION", "HUEVO VIBRADOR TRIPLE ESTIMULVIION", 0, 0m },
                    { "284", null, "VI", "VIBRADOR DOBLE PENETRADOR", "VIBRADOR DOBLE PENETRADOR", 0, 0m },
                    { "402", null, "JS", "VAGINA REAL PASSION LADY", "VAGINA REAL PASSION LADY", 0, 0m },
                    { "283", null, "VI", "CONSOLADOR  DUAL LUCKY LADY", "CONSOLADOR  DUAL LUCKY LADY", 0, 0m },
                    { "281", null, "VI", "VIBRADOR  DOBLE BRIGTY ARTHUR", "VIBRADOR  DOBLE BRIGTY ARTHUR", 0, 0m },
                    { "280", null, "VI", "VIBRADOR CLIMBING RABITT VIBE", "VIBRADOR CLIMBING RABITT VIBE", 0, 0m },
                    { "279", null, "VI", "VIBRADOR DOBLE NAUGHTY", "VIBRADOR DOBLE NAUGHTY", 0, 0m },
                    { "278", null, "VI", "VIBRADOR SOPHIA ROTATORIO 5 COLORES", "VIBRADOR SOPHIA ROTATORIO 5 COLORES", 0, 0m },
                    { "277", null, "VI", "VIBRADOR DOBLE ESTIMULVIION GIGANTE", "VIBRADOR DOBLE ESTIMULVIION GIGANTE", 0, 0m },
                    { "587", null, "LU", "LUBRICANTE APARIENCIA SEMEN", "LUBRICANTE APARIENCIA SEMEN", 0, 0m },
                    { "282", null, "VI", "VIBRADOR DOBLE SNAPPY ANDRE", "VIBRADOR DOBLE SNAPPY ANDRE", 0, 0m },
                    { "392", null, "AC", "DADOS EROTICOS POR TRES ILUMINOSOS", "DADOS EROTICOS POR TRES ILUMINOSOS", 0, 0m },
                    { "391", null, "AC", "DADOS EROTICOS POR DOS ILUMINOSOS", "DADOS EROTICOS POR DOS ILUMINOSOS", 0, 0m },
                    { "390", null, "AC", "DADOS GIGANTES MAS ACEITES PECADOS", "DADOS GIGANTES MAS ACEITES PECADOS", 0, 0m },
                    { "136", null, "AC", "GEL VIRGINIA 30ml APLICADOR  ESTRECHANTE", "GEL VIRGINIA 30ml APLICADOR  ESTRECHANTE", 0, 0m },
                    { "137", null, "AC", "CREMA AFRODITAS 15gr ESTRECHANTE", "CREMA AFRODITAS 15gr ESTRECHANTE", 0, 0m },
                    { "138", null, "AC", "TIGHTEN CREMA ESTRECHANTE 5gr mini", "TIGHTEN CREMA ESTRECHANTE 5gr mini", 0, 0m },
                    { "139", null, "AC", "CREMA 5gr AFRODITA mini ESTRECHANTE", "CREMA 5gr AFRODITA mini ESTRECHANTE", 0, 0m },
                    { "140", null, "AC", "GEL PARADISE ESTRECHANTE 5ml SOBRE", "GEL PARADISE ESTRECHANTE 5ml SOBRE", 0, 0m },
                    { "141", null, "AC", "VIRGINIA GOTAS ESTRECHANTES 5ml", "VIRGINIA GOTAS ESTRECHANTES 5ml", 0, 0m },
                    { "142", null, "AC", "PARADISE MULTIORGASMOS 5ml SOBRE", "PARADISE MULTIORGASMOS 5ml SOBRE", 0, 0m },
                    { "143", null, "AC", "AROUSAL 5ml SOBRE GEL MULTIORGASMOS", "AROUSAL 5ml SOBRE GEL MULTIORGASMOS", 0, 0m },
                    { "144", null, "AC", "MULTIORGASMO GEL APLICADOR 30 ml", "MULTIORGASMO GEL APLICADOR 30 ml", 0, 0m },
                    { "145", null, "AC", "CREMA 15 gr HIEDRA MULTIORGASMOS", "CREMA 15 gr HIEDRA MULTIORGASMOS", 0, 0m },
                    { "146", null, "AC", "CREMA 5gr mini HIEDRA MULTIORGASMOS", "CREMA 5gr mini HIEDRA MULTIORGASMOS", 0, 0m },
                    { "147", null, "AC", "AROUSAL GEL 5gr mini MULTIORAGASMOS", "AROUSAL GEL 5gr mini MULTIORAGASMOS", 0, 0m },
                    { "148", null, "AC", "GOTAS ORGASMICS GEL 10ml", "GOTAS ORGASMICS GEL 10ml", 0, 0m },
                    { "149", null, "AC", "ANALEAZE CREMA FRASCO BLANCO 15gr", "ANALEAZE CREMA FRASCO BLANCO 15gr", 0, 0m },
                    { "150", null, "AC", "EXXTREME VALVULA GEL DILATADOR 37ml", "EXXTREME VALVULA GEL DILATADOR 37ml", 0, 0m },
                    { "151", null, "AC", "TIGER CREMA ANAL 15 gr", "TIGER CREMA ANAL 15 gr", 0, 0m },
                    { "152", null, "AC", "TIGER CREMA ANAL 5gr mini", "TIGER CREMA ANAL 5gr mini", 0, 0m },
                    { "165", null, "AC", "DICLONINE GEL 25gr ORIGINAL", "DICLONINE GEL 25gr ORIGINAL", 0, 0m },
                    { "164", null, "AC", "MANSIZE GEL 25gr ORIGINAL", "MANSIZE GEL 25gr ORIGINAL", 0, 0m },
                    { "163", null, "AC", "PENISEX CREMA 25gr ORIGINAL", "PENISEX CREMA 25gr ORIGINAL", 0, 0m },
                    { "162", null, "AC", "MAX MAN CREMA 30gr ORIGINAL", "MAX MAN CREMA 30gr ORIGINAL", 0, 0m },
                    { "161", null, "AC", "MAX MAN GEL 15gr  ORIGINAL", "MAX MAN GEL 15gr  ORIGINAL", 0, 0m },
                    { "160", null, "AC", "ACEITE TAPA DORADA MICHELS AGRANDADORA 120ml", "ACEITE TAPA DORADA MICHELS AGRANDADORA 120ml", 0, 0m },
                    { "135", null, "AC", "TIGHTEN UP ESTRECHANTE SOBRE 5ml GEL", "TIGHTEN UP ESTRECHANTE SOBRE 5ml GEL", 0, 0m },
                    { "159", null, "AC", "TIGER WOODS RETARDANTE Y ENGROSANTE 10ml", "TIGER WOODS RETARDANTE Y ENGROSANTE 10ml", 0, 0m },
                    { "157", null, "AC", "EXXTREME CHERRY 30ml GEL ANAL", "EXXTREME CHERRY 30ml GEL ANAL", 0, 0m },
                    { "156", null, "AC", "ANAL RUSH GEL APLICADOR 30ml", "ANAL RUSH GEL APLICADOR 30ml", 0, 0m },
                    { "155", null, "AC", "ANAL LUBRICANT SOBRE 5ml GEL", "ANAL LUBRICANT SOBRE 5ml GEL", 0, 0m },
                    { "154", null, "AC", "PARADISE GEL ANAL 5ml SOBRE", "PARADISE GEL ANAL 5ml SOBRE", 0, 0m },
                    { "153A", null, "AC", "ANALEZE PORTABLE 5gr mini AZUL", "ANALEZE PORTABLE 5gr mini AZUL", 0, 0m },
                    { "153", null, "AC", "ANALEZE CREMA 5gr mini ROJO", "ANALEZE CREMA 5gr mini ROJO", 0, 0m },
                    { "158", null, "AC", "MAX MAN GEL 30ml APLICADOR", "MAX MAN GEL 30ml APLICADOR", 0, 0m },
                    { "166", null, "AC", "DEVELOPPE SEX GEL 60ml ORIGINAL", "DEVELOPPE SEX GEL 60ml ORIGINAL", 0, 0m },
                    { "134", null, "AC", "PAÑITO CHINO EXCITANTE FOR LADY", "PAÑITO CHINO EXCITANTE FOR LADY", 0, 0m },
                    { "132", null, "AC", "KANGUROO GEL 5gr mini", "KANGUROO GEL 5gr mini", 0, 0m },
                    { "101", null, "AC", "ACEITE CALIENTE FRUIT LOVE 8 oz", "ACEITE CALIENTE FRUIT LOVE 8 oz", 0, 0m },
                    { "102", null, "AC", "ACEITE CALIENTE WARM UP 120 ml", "ACEITE CALIENTE WARM UP 120 ml", 0, 0m },
                    { "103", null, "AC", "ACEINTE CALIENTE WARM UP 240 ml", "ACEINTE CALIENTE WARM UP 240 ml", 0, 0m },
                    { "104", null, "AC", "ACEITE CALIENTE SWEET LOVE 37 ml", "ACEITE CALIENTE SWEET LOVE 37 ml", 0, 0m },
                    { "105", null, "AC", "ACEITE CALIENTE PASSION INTIMA 5ml", "ACEITE CALIENTE PASSION INTIMA 5ml", 0, 0m },
                    { "106", null, "AC", "ACEITE CALIENTE RELISTIC VALVULA 37ml", "ACEITE CALIENTE RELISTIC VALVULA 37ml", 0, 0m },
                    { "107", null, "AC", "ACEITE CALIENTE PECADOS 10ml", "ACEITE CALIENTE PECADOS 10ml", 0, 0m },
                    { "108", null, "AC", "ACEITE CALIENTE COCKTAIL LICOR 40ml", "ACEITE CALIENTE COCKTAIL LICOR 40ml", 0, 0m },
                    { "109", null, "AC", "COJIN BODY HEAT ACEITE CALIENTE", "COJIN BODY HEAT ACEITE CALIENTE", 0, 0m },
                    { "110", null, "AC", "COJIN SPANISH FLY GOTAS EXITANTES", "COJIN SPANISH FLY GOTAS EXITANTES", 0, 0m },
                    { "111", null, "AC", "RETARDEX CREMA CAJA ROJA 15gr", "RETARDEX CREMA CAJA ROJA 15gr", 0, 0m },
                    { "112", null, "AC", "RETARDING FRASCO BLANCO 15 gr", "RETARDING FRASCO BLANCO 15 gr", 0, 0m },
                    { "113", null, "AC", "APOLOS MAN CREMA 5gr mini", "APOLOS MAN CREMA 5gr mini", 0, 0m },
                    { "114", null, "AC", "APOLOS MAN CREMA 15gr", "APOLOS MAN CREMA 15gr", 0, 0m },
                    { "115", null, "AC", "RETARDEX CREMA 5gr mini", "RETARDEX CREMA 5gr mini", 0, 0m },
                    { "116", null, "AC", "SOBRE GEL PARADISE 5ml RETARDANTE", "SOBRE GEL PARADISE 5ml RETARDANTE", 0, 0m },
                    { "117", null, "AC", "RINO SPRAY AZUL", "RINO SPRAY AZUL", 0, 0m },
                    { "131", null, "AC", "PROLONGING CREMA 5gr mini", "PROLONGING CREMA 5gr mini", 0, 0m },
                    { "130", null, "AC", "CABALLO BLANCO SPRAY RETARDANTE", "CABALLO BLANCO SPRAY RETARDANTE", 0, 0m },
                    { "129", null, "AC", "PROCOMIL SPRAY ALEMAN ORIGINAL", "PROCOMIL SPRAY ALEMAN ORIGINAL", 0, 0m },
                    { "128", null, "AC", "STUD 100 CRISTAL VIDRIO mini 10ml", "STUD 100 CRISTAL VIDRIO mini 10ml", 0, 0m },
                    { "127", null, "AC", "STUD 100 CRISTAL PLASTICO 30ml", "STUD 100 CRISTAL PLASTICO 30ml", 0, 0m },
                    { "126", null, "AC", "MENTOL CHINO PEQUEÑO 5gr", "MENTOL CHINO PEQUEÑO 5gr", 0, 0m },
                    { "133", null, "AC", "PAÑITO CHINO RETARDANTE FOR MEN", "PAÑITO CHINO RETARDANTE FOR MEN", 0, 0m },
                    { "125", null, "AC", "MENTOL CHINO GRANDE  15gr", "MENTOL CHINO GRANDE  15gr", 0, 0m },
                    { "123", null, "AC", "STUD 100 INGLES 12gr ORIGINAL", "STUD 100 INGLES 12gr ORIGINAL", 0, 0m },
                    { "122", null, "AC", "KANGUROO GEL 30ml APLICADOR", "KANGUROO GEL 30ml APLICADOR", 0, 0m },
                    { "121", null, "AC", "KANGUROO CREMA 15gr RETARDANTE", "KANGUROO CREMA 15gr RETARDANTE", 0, 0m },
                    { "120", null, "AC", "GEL MR PROLONG SOBRE RETARDANTE 5ml", "GEL MR PROLONG SOBRE RETARDANTE 5ml", 0, 0m },
                    { "119", null, "AC", "RINO CREMA DORADO 10ml", "RINO CREMA DORADO 10ml", 0, 0m },
                    { "118", null, "AC", "RINO SPRAY SPRAY DORADO", "RINO SPRAY SPRAY DORADO", 0, 0m },
                    { "124", null, "AC", "BROCHA CHINA ORIGINAL  10ml HONG KONG", "BROCHA CHINA ORIGINAL  10ml HONG KONG", 0, 0m },
                    { "167", null, "AC", "XXL CREAM 50ml ORIGINAL", "XXL CREAM 50ml ORIGINAL", 0, 0m },
                    { "238", null, "AC", "FUNDA MAGIC TUBE", "FUNDA MAGIC TUBE", 0, 0m },
                    { "239", null, "AC", "FUNDA MALLA CONEJO + 2 VIBRADORES", "FUNDA MALLA CONEJO + 2 VIBRADORES", 0, 0m },
                    { "276", null, "AC", "BOLAS VAGINALES FERRERO BALLS", "BOLAS VAGINALES FERRERO BALLS", 0, 0m },
                    { "290", null, "AC", "INICIADOR ANAL + VIB.", "INICIADOR ANAL + VIB.", 0, 0m },
                    { "291", null, "AC", "INICIO ANAL GIGANTE CURVO", "INICIO ANAL GIGANTE CURVO", 0, 0m },
                    { "292", null, "AC", "INICIO ANAL GIGANTE PEZ", "INICIO ANAL GIGANTE PEZ", 0, 0m },
                    { "293", null, "AC", "INICIO ANAL GIGANTE PUNTO G", "INICIO ANAL GIGANTE PUNTO G", 0, 0m },
                    { "294", null, "AC", "INICIO ANAL GIGANTE MISIL", "INICIO ANAL GIGANTE MISIL", 0, 0m },
                    { "295", null, "AC", "INICIO ANAL JELLY + SILICONA", "INICIO ANAL JELLY + SILICONA", 0, 0m },
                    { "296", null, "AC", "INICIO ANAL SENCILLO", "INICIO ANAL SENCILLO", 0, 0m },
                    { "297", null, "AC", "VIB. ANAL MISTYQUE + 7 VEL.", "VIB. ANAL MISTYQUE + 7 VEL.", 0, 0m },
                    { "298", null, "AC", "VIB. ANAL SLENDER + 7 VEL.", "VIB. ANAL SLENDER + 7 VEL.", 0, 0m },
                    { "299", null, "AC", "VIB. ANAL FISKY FLEX  + 7 VEL.", "VIB. ANAL FISKY FLEX  + 7 VEL.", 0, 0m },
                    { "300", null, "AC", "VIB. HONEY BUNNY + 7 VEL.", "VIB. HONEY BUNNY + 7 VEL.", 0, 0m },
                    { "301", null, "AC", "MUÑECOS VIBRADORES", "MUÑECOS VIBRADORES", 0, 0m },
                    { "302", null, "AC", "HUEVO JAPONES METALIZADOS X 10 VEL.", "HUEVO JAPONES METALIZADOS X 10 VEL.", 0, 0m },
                    { "303", null, "AC", "HUEVO PLATEADO GRANDE", "HUEVO PLATEADO GRANDE", 0, 0m },
                    { "304", null, "AC", "HUEVO JAPONES NEON X 10 VEL", "HUEVO JAPONES NEON X 10 VEL", 0, 0m },
                    { "305", null, "AC", "HUEVO VIBRADOR DE COLORES", "HUEVO VIBRADOR DE COLORES", 0, 0m },
                    { "389", null, "AC", "JUEGO RULETA EROTICA", "JUEGO RULETA EROTICA", 0, 0m },
                    { "388", null, "AC", "JUEGO ESCALERA EROTICO", "JUEGO ESCALERA EROTICO", 0, 0m },
                    { "387", null, "AC", "MUÑECA INFLABLE SENCILLA MAS VAGINA + ANO", "MUÑECA INFLABLE SENCILLA MAS VAGINA + ANO", 0, 0m },
                    { "386", null, "AC", "MUÑECA INFLABES PROFESIO MANOS Y PIES SEXO ORAL", "MUÑECA INFLABES PROFESIO MANOS Y PIES SEXO ORAL", 0, 0m },
                    { "385", null, "AC", "MUNECO INFLABLE HOMBRE", "MUNECO INFLABLE HOMBRE", 0, 0m },
                    { "384", null, "AC", "SOGAS SUSPENSIÓN COLORES", "SOGAS SUSPENSIÓN COLORES", 0, 0m },
                    { "275", null, "AC", "BOLAS VAGINALES GOLDEN+ VIBRADOR", "BOLAS VAGINALES GOLDEN+ VIBRADOR", 0, 0m },
                    { "383", null, "AC", "ESPOSAS POLICE MAS PELUCHE", "ESPOSAS POLICE MAS PELUCHE", 0, 0m },
                    { "381", null, "AC", "INICIO ANAL ACERO XXL MAS COLA DE LOBO", "INICIO ANAL ACERO XXL MAS COLA DE LOBO", 0, 0m },
                    { "380", null, "AC", "INICIO ANAL PIEL MAS COLA DE LOBO", "INICIO ANAL PIEL MAS COLA DE LOBO", 0, 0m },
                    { "379", null, "AC", "INICIO ANAL NEGRO MAS COLA DE LOBO", "INICIO ANAL NEGRO MAS COLA DE LOBO", 0, 0m },
                    { "378", null, "AC", "KIT SM NEGRO CLASSIC", "KIT SM NEGRO CLASSIC", 0, 0m },
                    { "307", null, "AC", "HUEVO VIBRADOR ANIMAL PRINT", "HUEVO VIBRADOR ANIMAL PRINT", 0, 0m },
                    { "306", null, "AC", "HUEVO VIBRADOR MONSTER METALIZADOS", "HUEVO VIBRADOR MONSTER METALIZADOS", 0, 0m },
                    { "382", null, "AC", "INICIO ANALACERO M MAS COLA DE LOBO", "INICIO ANALACERO M MAS COLA DE LOBO", 0, 0m },
                    { "274", null, "AC", "BOLAS VAGINALES + SENSORES DE CALOR+ VIBRACION", "BOLAS VAGINALES + SENSORES DE CALOR+ VIBRACION", 0, 0m },
                    { "273", null, "AC", "BOLAS VAGINALES ESTRIADAS + 7 VELOCIDADES", "BOLAS VAGINALES ESTRIADAS + 7 VELOCIDADES", 0, 0m },
                    { "272", null, "AC", "BOLAS VAGINALES ESTRIADAS", "BOLAS VAGINALES ESTRIADAS", 0, 0m },
                    { "253", null, "AC", "DEDOS MINI SILICONA  CLIT BANGERS", "DEDOS MINI SILICONA  CLIT BANGERS", 0, 0m },
                    { "252", null, "AC", "DESOS SILICONA * 2 JELLY FINGERS", "DESOS SILICONA * 2 JELLY FINGERS", 0, 0m },
                    { "251", null, "AC", "FUNDA BRAVEMAN CAJA + 1 VIBRADOR", "FUNDA BRAVEMAN CAJA + 1 VIBRADOR", 0, 0m },
                    { "250", null, "AC", "FUNDA BRAVEMAN CAJA + 1 VIBRADOR", "FUNDA BRAVEMAN CAJA + 1 VIBRADOR", 0, 0m },
                    { "249", null, "AC", "FUNDA BRAVEMAN CAJA MORADA + 1 VIBRADOR CLITORIAL", "FUNDA BRAVEMAN CAJA MORADA + 1 VIBRADOR CLITORIAL", 0, 0m },
                    { "248", null, "AC", "FUNDA BRAVEMAN CAJA BLANCA + 1 VIBRADOR CLITORIAL", "FUNDA BRAVEMAN CAJA BLANCA + 1 VIBRADOR CLITORIAL", 0, 0m },
                    { "254", null, "AC", "FUNDA SEX TOYS CONDON", "FUNDA SEX TOYS CONDON", 0, 0m },
                    { "247", null, "AC", "FUNDA + EXXTENSION  PENE PIEL", "FUNDA + EXXTENSION  PENE PIEL", 0, 0m },
                    { "245", null, "AC", "FUNDA PENE DRAGON + VIBRACION", "FUNDA PENE DRAGON + VIBRACION", 0, 0m },
                    { "244", null, "AC", "FUNDA PENE COMPLETA BRAVEMAN + CRESTA SIN VIBRADO", "FUNDA PENE COMPLETA BRAVEMAN + CRESTA SIN VIBRADO", 0, 0m },
                    { "243", null, "AC", "FUNDA PENE COMPLETA  BRAVEMAN SIN VIBRADOR", "FUNDA PENE COMPLETA  BRAVEMAN SIN VIBRADOR", 0, 0m },
                    { "242", null, "AC", "FUNDA GIGANTE COLORES", "FUNDA GIGANTE COLORES", 0, 0m },
                    { "241", null, "AC", "FUNDA PENIS EXXTENSION PERLAS  PEQ.", "FUNDA PENIS EXXTENSION PERLAS  PEQ.", 0, 0m },
                    { "240", null, "AC", "FUNDA MALLA CONEJO + 1VIBRADOR", "FUNDA MALLA CONEJO + 1VIBRADOR", 0, 0m },
                    { "246", null, "AC", "FUNDA MAGIC TUBE + VIBRACION", "FUNDA MAGIC TUBE + VIBRACION", 0, 0m },
                    { "577", null, "OS", "DILATADOR ANAL 100ML", "DILATADOR ANAL 100ML", 0, 0m },
                    { "255", null, "AC", "FUNDA DOBLE ESTIMULACION", "FUNDA DOBLE ESTIMULACION", 0, 0m },
                    { "257", null, "AC", "FUNDA ESTIMULACION + LENGUA", "FUNDA ESTIMULACION + LENGUA", 0, 0m },
                    { "271", null, "AC", "BOLAS VAGINALES EXXQUISITE 7 COLORES", "BOLAS VAGINALES EXXQUISITE 7 COLORES", 0, 0m },
                    { "270", null, "AC", "DUO BOLAS ANAL + MINI BOLAS SILICONA", "DUO BOLAS ANAL + MINI BOLAS SILICONA", 0, 0m },
                    { "269", null, "AC", "VIBRADOR DECADENCE + BOLAS  SILICONA", "VIBRADOR DECADENCE + BOLAS  SILICONA", 0, 0m },
                    { "268", null, "AC", "BOLAS ANALES GIGANTES", "BOLAS ANALES GIGANTES", 0, 0m },
                    { "267", null, "AC", "VIBRADOR DISTORTION + 6 FUNCIONES SILICONA", "VIBRADOR DISTORTION + 6 FUNCIONES SILICONA", 0, 0m },
                    { "266", null, "AC", "BOLAS ANAL G BEADS * 6 BOLAS", "BOLAS ANAL G BEADS * 6 BOLAS", 0, 0m },
                    { "256", null, "AC", "FUNDA PUNTOS LATERALES", "FUNDA PUNTOS LATERALES", 0, 0m },
                    { "265", null, "AC", "BOLAS ANAL + CHUPA + VIBRACION MEDIANAS", "BOLAS ANAL + CHUPA + VIBRACION MEDIANAS", 0, 0m },
                    { "263", null, "AC", "BOLAS BALLS +10 VEL.  WATERPROFF VIBRACION", "BOLAS BALLS +10 VEL.  WATERPROFF VIBRACION", 0, 0m },
                    { "262", null, "AC", "BOLAS ANALES JUMBO", "BOLAS ANALES JUMBO", 0, 0m },
                    { "261", null, "AC", "FUNDA ESTIMULACION REAL +VIBRADOR + TESTICULOS", "FUNDA ESTIMULACION REAL +VIBRADOR + TESTICULOS", 0, 0m },
                    { "260", null, "AC", "FUNDA ESTIMULACION REAL", "FUNDA ESTIMULACION REAL", 0, 0m },
                    { "259", null, "AC", "FUNDA ESTIMULACION + TESTICULOS", "FUNDA ESTIMULACION + TESTICULOS", 0, 0m },
                    { "258", null, "AC", "FUNDA ESTIMULADOR PUNTOS", "FUNDA ESTIMULADOR PUNTOS", 0, 0m },
                    { "264", null, "AC", "BOLAS ANAL + CHUPA + VIBRACION GRANDES", "BOLAS ANAL + CHUPA + VIBRACION GRANDES", 0, 0m },
                    { "578", null, "OS", "GAY LUBE 100ML", "GAY LUBE 100ML", 0, 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_InOuts_storageId",
                table: "InOuts",
                column: "storageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WarehouseEntitywarehouseId",
                table: "Products",
                column: "WarehouseEntitywarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_productId",
                table: "Storages",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_warehouseId",
                table: "Storages",
                column: "warehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_WarehouseEntitywarehouseId",
                table: "Warehouses",
                column: "WarehouseEntitywarehouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "InOuts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
