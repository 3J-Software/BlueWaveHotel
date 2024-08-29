using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueWaveHotel.Entities.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
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
                    PackageName = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packages", x => x.Id);
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
                    price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "professions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
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
                    CustomerId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    fee = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_extras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_extras_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
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
                    FloorId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    FloorId1 = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rooms_floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rooms_floors_FloorId1",
                        column: x => x.FloorId1,
                        principalTable: "floors",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BedTypePackage",
                columns: table => new
                {
                    BedsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    packagesId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedTypePackage", x => new { x.BedsId, x.packagesId });
                    table.ForeignKey(
                        name: "FK_BedTypePackage_bedTypes_BedsId",
                        column: x => x.BedsId,
                        principalTable: "bedTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BedTypePackage_packages_packagesId",
                        column: x => x.packagesId,
                        principalTable: "packages",
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
                    packageId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Purchase = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    BookingStart = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BookingEnd = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CheckIn = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CheckOut = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    customersId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                name: "productCategories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoryName = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productCategories_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id");
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
                    SalaryTypeId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    salary = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ProfessionId = table.Column<string>(type: "varchar(255)", nullable: false)
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
                    SalaryTypeId1 = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personels_professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personels_salaryTypes_SalaryTypeId",
                        column: x => x.SalaryTypeId,
                        principalTable: "salaryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personels_salaryTypes_SalaryTypeId1",
                        column: x => x.SalaryTypeId1,
                        principalTable: "salaryTypes",
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

            migrationBuilder.CreateTable(
                name: "ReservationRoom",
                columns: table => new
                {
                    ReservationId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    roomsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationRoom", x => new { x.ReservationId, x.roomsId });
                    table.ForeignKey(
                        name: "FK_ReservationRoom_reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationRoom_rooms_roomsId",
                        column: x => x.roomsId,
                        principalTable: "rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonelTimeTracking",
                columns: table => new
                {
                    TimeTrackingId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    personelsId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelTimeTracking", x => new { x.TimeTrackingId, x.personelsId });
                    table.ForeignKey(
                        name: "FK_PersonelTimeTracking_personels_personelsId",
                        column: x => x.personelsId,
                        principalTable: "personels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelTimeTracking_timeTrackings_TimeTrackingId",
                        column: x => x.TimeTrackingId,
                        principalTable: "timeTrackings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    professionsId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonelId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfessionId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_shifts_personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "personels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_shifts_professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "professions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_shifts_professions_professionsId",
                        column: x => x.professionsId,
                        principalTable: "professions",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BedTypePackage_packagesId",
                table: "BedTypePackage",
                column: "packagesId");

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
                name: "IX_extras_CustomerId",
                table: "extras",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_packages_PackageName",
                table: "packages",
                column: "PackageName",
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
                name: "IX_personels_ProfessionId",
                table: "personels",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_personels_SalaryTypeId",
                table: "personels",
                column: "SalaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_personels_SalaryTypeId1",
                table: "personels",
                column: "SalaryTypeId1",
                unique: true);

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
                name: "IX_productCategories_ProductId",
                table: "productCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductName",
                table: "products",
                column: "ProductName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_professions_Title",
                table: "professions",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReservationRoom_roomsId",
                table: "ReservationRoom",
                column: "roomsId");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_customersId",
                table: "reservations",
                column: "customersId");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_packageId",
                table: "reservations",
                column: "packageId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_FloorId",
                table: "rooms",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_FloorId1",
                table: "rooms",
                column: "FloorId1");

            migrationBuilder.CreateIndex(
                name: "IX_shifts_Name",
                table: "shifts",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_shifts_PersonelId",
                table: "shifts",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_shifts_ProfessionId",
                table: "shifts",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_shifts_professionsId",
                table: "shifts",
                column: "professionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BedTypePackage");

            migrationBuilder.DropTable(
                name: "BedTypeRoom");

            migrationBuilder.DropTable(
                name: "ExtraProduct");

            migrationBuilder.DropTable(
                name: "PersonelTimeTracking");

            migrationBuilder.DropTable(
                name: "productCategories");

            migrationBuilder.DropTable(
                name: "ReservationRoom");

            migrationBuilder.DropTable(
                name: "shifts");

            migrationBuilder.DropTable(
                name: "bedTypes");

            migrationBuilder.DropTable(
                name: "extras");

            migrationBuilder.DropTable(
                name: "timeTrackings");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "packages");

            migrationBuilder.DropTable(
                name: "floors");

            migrationBuilder.DropTable(
                name: "professions");

            migrationBuilder.DropTable(
                name: "salaryTypes");
        }
    }
}
