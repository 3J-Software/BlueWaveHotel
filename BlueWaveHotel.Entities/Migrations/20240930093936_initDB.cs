using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlueWaveHotel.Entities.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bedTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BedName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bedTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Adress = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Id_Number = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NickName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "floors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FloorNumber = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_floors", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "packages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    packageName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    fee = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packages", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "productCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryName = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productCategories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "professions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "salaryTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salaryTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "shifts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Start = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Finish = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shifts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "timeTrackings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Start = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Finish = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timeTrackings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "extras",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    customerIdId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    fee = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_extras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_extras_customers_customerIdId",
                        column: x => x.customerIdId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    customersId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    packageId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Purchase = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    BookingStart = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BookingEnd = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CheckOut = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Fee = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservations_customers_customersId",
                        column: x => x.customersId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservations_packages_packageId",
                        column: x => x.packageId,
                        principalTable: "packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductCategoriesId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_productCategories_ProductCategoriesId",
                        column: x => x.ProductCategoriesId,
                        principalTable: "productCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    salaryTypeIdId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    salary = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    professionId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Adress = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ID_number = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NickName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personels_professions_professionId",
                        column: x => x.professionId,
                        principalTable: "professions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_personels_salaryTypes_salaryTypeIdId",
                        column: x => x.salaryTypeIdId,
                        principalTable: "salaryTypes",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProfessionShift",
                columns: table => new
                {
                    ShiftId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    professionsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionShift", x => new { x.ShiftId, x.professionsId });
                    table.ForeignKey(
                        name: "FK_ProfessionShift_professions_professionsId",
                        column: x => x.professionsId,
                        principalTable: "professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionShift_shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    floorID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: true),
                    ReservationId1 = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rooms_floors_floorID",
                        column: x => x.floorID,
                        principalTable: "floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rooms_reservations_ReservationId1",
                        column: x => x.ReservationId1,
                        principalTable: "reservations",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ExtraProduct",
                columns: table => new
                {
                    extrasId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    productId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraProduct", x => new { x.extrasId, x.productId });
                    table.ForeignKey(
                        name: "FK_ExtraProduct_extras_extrasId",
                        column: x => x.extrasId,
                        principalTable: "extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExtraProduct_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonelShift",
                columns: table => new
                {
                    PersonelsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    shiftsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelShift", x => new { x.PersonelsId, x.shiftsId });
                    table.ForeignKey(
                        name: "FK_PersonelShift_personels_PersonelsId",
                        column: x => x.PersonelsId,
                        principalTable: "personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelShift_shifts_shiftsId",
                        column: x => x.shiftsId,
                        principalTable: "shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonelTimeTracking",
                columns: table => new
                {
                    MyPropertyId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    personelsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTimeTracking", x => new { x.MyPropertyId, x.personelsId });
                    table.ForeignKey(
                        name: "FK_PersonelTimeTracking_personels_personelsId",
                        column: x => x.personelsId,
                        principalTable: "personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelTimeTracking_timeTrackings_MyPropertyId",
                        column: x => x.MyPropertyId,
                        principalTable: "timeTrackings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BedTypeRoom",
                columns: table => new
                {
                    bedTypesId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    roomsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedTypeRoom", x => new { x.bedTypesId, x.roomsId });
                    table.ForeignKey(
                        name: "FK_BedTypeRoom_bedTypes_bedTypesId",
                        column: x => x.bedTypesId,
                        principalTable: "bedTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BedTypeRoom_rooms_roomsId",
                        column: x => x.roomsId,
                        principalTable: "rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "bedTypes",
                columns: new[] { "Id", "BedName", "CreatedTime" },
                values: new object[,]
                {
                    { "1", "Single", new DateTime(2024, 9, 30, 12, 39, 35, 441, DateTimeKind.Local).AddTicks(6802) },
                    { "2", "Double", new DateTime(2024, 9, 30, 12, 39, 35, 441, DateTimeKind.Local).AddTicks(6817) },
                    { "3", "Single-L", new DateTime(2024, 9, 30, 12, 39, 35, 441, DateTimeKind.Local).AddTicks(6818) },
                    { "4", "Double-L", new DateTime(2024, 9, 30, 12, 39, 35, 441, DateTimeKind.Local).AddTicks(6819) }
                });

            migrationBuilder.InsertData(
                table: "floors",
                columns: new[] { "Id", "CreatedTime", "FloorNumber" },
                values: new object[,]
                {
                    { "1", new DateTime(2024, 9, 30, 12, 39, 35, 442, DateTimeKind.Local).AddTicks(4718), "1" },
                    { "2", new DateTime(2024, 9, 30, 12, 39, 35, 442, DateTimeKind.Local).AddTicks(4719), "2" },
                    { "3", new DateTime(2024, 9, 30, 12, 39, 35, 442, DateTimeKind.Local).AddTicks(4720), "3" },
                    { "4", new DateTime(2024, 9, 30, 12, 39, 35, 442, DateTimeKind.Local).AddTicks(4722), "4" },
                    { "z", new DateTime(2024, 9, 30, 12, 39, 35, 442, DateTimeKind.Local).AddTicks(4703), "z" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "Id", "Capacity", "CreatedTime", "ReservationId", "ReservationId1", "Status", "floorID" },
                values: new object[,]
                {
                    { "1", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(121), null, null, "avaible", "1" },
                    { "10", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(1294), null, null, "avaible", "1" },
                    { "11", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(1410), null, null, "avaible", "1" },
                    { "12", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(1512), null, null, "avaible", "1" },
                    { "13", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(1608), null, null, "avaible", "1" },
                    { "14", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(1704), null, null, "avaible", "1" },
                    { "15", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(1808), null, null, "avaible", "1" },
                    { "16", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(1905), null, null, "avaible", "1" },
                    { "17", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2001), null, null, "avaible", "1" },
                    { "18", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2110), null, null, "avaible", "1" },
                    { "19", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2209), null, null, "avaible", "1" },
                    { "2", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(452), null, null, "avaible", "1" },
                    { "20", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2305), null, null, "avaible", "2" },
                    { "21", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2408), null, null, "avaible", "2" },
                    { "22", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2514), null, null, "avaible", "2" },
                    { "23", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2611), null, null, "avaible", "2" },
                    { "24", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2710), null, null, "avaible", "2" },
                    { "25", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2807), null, null, "avaible", "2" },
                    { "26", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(2911), null, null, "avaible", "2" },
                    { "27", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3008), null, null, "avaible", "2" },
                    { "28", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3107), null, null, "avaible", "2" },
                    { "29", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3211), null, null, "avaible", "2" },
                    { "3", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(567), null, null, "avaible", "1" },
                    { "30", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3311), null, null, "avaible", "2" },
                    { "31", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3418), null, null, "avaible", "2" },
                    { "32", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3520), null, null, "avaible", "2" },
                    { "33", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3626), null, null, "avaible", "2" },
                    { "34", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3728), null, null, "avaible", "2" },
                    { "35", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3826), null, null, "avaible", "2" },
                    { "36", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(3933), null, null, "avaible", "2" },
                    { "37", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4031), null, null, "avaible", "2" },
                    { "38", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4128), null, null, "avaible", "2" },
                    { "39", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4225), null, null, "avaible", "2" },
                    { "4", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(686), null, null, "avaible", "1" },
                    { "40", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4331), null, null, "avaible", "3" },
                    { "41", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4437), null, null, "avaible", "3" },
                    { "42", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4535), null, null, "avaible", "3" },
                    { "43", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4632), null, null, "avaible", "3" },
                    { "44", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4735), null, null, "avaible", "3" },
                    { "45", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4832), null, null, "avaible", "3" },
                    { "46", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(4929), null, null, "avaible", "3" },
                    { "47", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5031), null, null, "avaible", "3" },
                    { "48", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5129), null, null, "avaible", "3" },
                    { "49", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5227), null, null, "avaible", "3" },
                    { "5", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(786), null, null, "avaible", "1" },
                    { "50", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5324), null, null, "avaible", "3" },
                    { "51", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5440), null, null, "avaible", "3" },
                    { "52", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5545), null, null, "avaible", "3" },
                    { "53", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5644), null, null, "avaible", "3" },
                    { "54", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5746), null, null, "avaible", "3" },
                    { "55", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5856), null, null, "avaible", "3" },
                    { "56", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(5957), null, null, "avaible", "3" },
                    { "57", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6055), null, null, "avaible", "3" },
                    { "58", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6162), null, null, "avaible", "3" },
                    { "59", 3, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6262), null, null, "avaible", "3" },
                    { "6", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(887), null, null, "avaible", "1" },
                    { "60", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6364), null, null, "avaible", "4" },
                    { "61", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6471), null, null, "avaible", "4" },
                    { "62", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6579), null, null, "avaible", "4" },
                    { "63", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6680), null, null, "avaible", "4" },
                    { "64", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6780), null, null, "avaible", "4" },
                    { "65", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6888), null, null, "avaible", "4" },
                    { "66", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(6989), null, null, "avaible", "4" },
                    { "67", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(7084), null, null, "avaible", "4" },
                    { "68", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(7181), null, null, "avaible", "4" },
                    { "69", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(7290), null, null, "avaible", "4" },
                    { "7", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(994), null, null, "avaible", "1" },
                    { "70", 4, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(7393), null, null, "avaible", "4" },
                    { "71", 4, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(7498), null, null, "avaible", "4" },
                    { "72", 4, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(7607), null, null, "avaible", "4" },
                    { "73", 4, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(7709), null, null, "avaible", "4" },
                    { "74", 4, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(7809), null, null, "avaible", "4" },
                    { "75", 4, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(7909), null, null, "avaible", "4" },
                    { "76", 4, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(8016), null, null, "avaible", "4" },
                    { "77", 2, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(8114), null, null, "avaible", "4" },
                    { "8", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(1093), null, null, "avaible", "1" },
                    { "9", 1, new DateTime(2024, 9, 30, 12, 39, 35, 444, DateTimeKind.Local).AddTicks(1191), null, null, "avaible", "1" }
                });

            migrationBuilder.InsertData(
                table: "BedTypeRoom",
                columns: new[] { "bedTypesId", "roomsId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "1", "10" },
                    { "1", "11" },
                    { "1", "12" },
                    { "1", "13" },
                    { "1", "14" },
                    { "1", "15" },
                    { "1", "16" },
                    { "1", "17" },
                    { "1", "18" },
                    { "1", "19" },
                    { "1", "2" },
                    { "1", "20" },
                    { "1", "21" },
                    { "1", "22" },
                    { "1", "23" },
                    { "1", "24" },
                    { "1", "25" },
                    { "1", "26" },
                    { "1", "27" },
                    { "1", "28" },
                    { "1", "29" },
                    { "1", "3" },
                    { "1", "30" },
                    { "1", "31" },
                    { "1", "32" },
                    { "1", "33" },
                    { "1", "34" },
                    { "1", "35" },
                    { "1", "36" },
                    { "1", "37" },
                    { "1", "38" },
                    { "1", "39" },
                    { "1", "4" },
                    { "1", "5" },
                    { "1", "50" },
                    { "1", "51" },
                    { "1", "52" },
                    { "1", "53" },
                    { "1", "54" },
                    { "1", "55" },
                    { "1", "56" },
                    { "1", "57" },
                    { "1", "58" },
                    { "1", "59" },
                    { "1", "6" },
                    { "1", "7" },
                    { "1", "70" },
                    { "1", "71" },
                    { "1", "72" },
                    { "1", "73" },
                    { "1", "74" },
                    { "1", "75" },
                    { "1", "76" },
                    { "1", "8" },
                    { "1", "9" },
                    { "2", "40" },
                    { "2", "41" },
                    { "2", "42" },
                    { "2", "43" },
                    { "2", "44" },
                    { "2", "45" },
                    { "2", "46" },
                    { "2", "47" },
                    { "2", "48" },
                    { "2", "49" },
                    { "2", "50" },
                    { "2", "51" },
                    { "2", "52" },
                    { "2", "53" },
                    { "2", "54" },
                    { "2", "55" },
                    { "2", "56" },
                    { "2", "57" },
                    { "2", "58" },
                    { "2", "59" },
                    { "2", "60" },
                    { "2", "61" },
                    { "2", "62" },
                    { "2", "63" },
                    { "2", "64" },
                    { "2", "65" },
                    { "2", "66" },
                    { "2", "67" },
                    { "2", "68" },
                    { "2", "69" },
                    { "2", "70" },
                    { "2", "71" },
                    { "2", "72" },
                    { "2", "73" },
                    { "2", "74" },
                    { "2", "75" },
                    { "2", "76" },
                    { "3", "77" },
                    { "4", "77" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BedTypeRoom_roomsId",
                table: "BedTypeRoom",
                column: "roomsId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_Id_Number",
                table: "customers",
                column: "Id_Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_customers_Mail",
                table: "customers",
                column: "Mail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_customers_NickName",
                table: "customers",
                column: "NickName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_customers_Phone",
                table: "customers",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExtraProduct_productId",
                table: "ExtraProduct",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_extras_customerIdId",
                table: "extras",
                column: "customerIdId");

            migrationBuilder.CreateIndex(
                name: "IX_packages_packageName",
                table: "packages",
                column: "packageName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personels_ID_number",
                table: "personels",
                column: "ID_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personels_NickName",
                table: "personels",
                column: "NickName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personels_password",
                table: "personels",
                column: "password",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personels_professionId",
                table: "personels",
                column: "professionId");

            migrationBuilder.CreateIndex(
                name: "IX_personels_salaryTypeIdId",
                table: "personels",
                column: "salaryTypeIdId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelShift_shiftsId",
                table: "PersonelShift",
                column: "shiftsId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelTimeTracking_personelsId",
                table: "PersonelTimeTracking",
                column: "personelsId");

            migrationBuilder.CreateIndex(
                name: "IX_productCategories_CategoryName",
                table: "productCategories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductCategoriesId",
                table: "products",
                column: "ProductCategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductName",
                table: "products",
                column: "ProductName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionShift_professionsId",
                table: "ProfessionShift",
                column: "professionsId");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_customersId",
                table: "reservations",
                column: "customersId");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_packageId",
                table: "reservations",
                column: "packageId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_floorID",
                table: "rooms",
                column: "floorID");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_ReservationId1",
                table: "rooms",
                column: "ReservationId1");

            migrationBuilder.CreateIndex(
                name: "IX_shifts_Name",
                table: "shifts",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedTypeRoom");

            migrationBuilder.DropTable(
                name: "ExtraProduct");

            migrationBuilder.DropTable(
                name: "PersonelShift");

            migrationBuilder.DropTable(
                name: "PersonelTimeTracking");

            migrationBuilder.DropTable(
                name: "ProfessionShift");

            migrationBuilder.DropTable(
                name: "bedTypes");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "extras");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropTable(
                name: "timeTrackings");

            migrationBuilder.DropTable(
                name: "shifts");

            migrationBuilder.DropTable(
                name: "floors");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "productCategories");

            migrationBuilder.DropTable(
                name: "professions");

            migrationBuilder.DropTable(
                name: "salaryTypes");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "packages");
        }
    }
}
