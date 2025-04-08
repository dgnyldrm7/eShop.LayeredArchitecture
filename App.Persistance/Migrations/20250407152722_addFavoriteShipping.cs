using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class addFavoriteShipping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsShippingFree",
                table: "products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Favorite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorite_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorite_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp" },
                values: new object[] { "e15a6208-39b7-428c-9903-b49dea05d33c", new DateTime(2025, 4, 7, 15, 27, 21, 700, DateTimeKind.Utc).AddTicks(2234), "7d228117-7a91-4690-b102-7c3a2b6e023e" });

            migrationBuilder.InsertData(
                table: "Favorite",
                columns: new[] { "Id", "CreatedAt", "ProductId", "UserId" },
                values: new object[] { 1, new DateTime(2025, 4, 7, 15, 27, 21, 700, DateTimeKind.Utc).AddTicks(2774), 1, "1" });

            migrationBuilder.UpdateData(
                table: "answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 15, 27, 21, 699, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 15, 27, 21, 699, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 7, 15, 27, 21, 700, DateTimeKind.Utc).AddTicks(700), new DateTime(2025, 4, 7, 15, 27, 21, 700, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 4, 7, 15, 27, 21, 699, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2025, 4, 7, 18, 27, 21, 699, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsShippingFree",
                value: false);

            migrationBuilder.UpdateData(
                table: "shippings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "ShippingDate" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 27, 21, 699, DateTimeKind.Utc).AddTicks(8850), new DateTime(2025, 4, 7, 15, 27, 21, 699, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2025, 4, 7, 18, 27, 21, 699, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_ProductId",
                table: "Favorite",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_UserId",
                table: "Favorite",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorite");

            migrationBuilder.DropColumn(
                name: "IsShippingFree",
                table: "products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp" },
                values: new object[] { "cc7f0088-7f2f-4ac1-b060-ca45eabfec01", new DateTime(2025, 4, 7, 14, 27, 11, 45, DateTimeKind.Utc).AddTicks(2034), "d745db4a-93e4-43db-b551-f7218b29afdb" });

            migrationBuilder.UpdateData(
                table: "answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 14, 27, 11, 44, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 14, 27, 11, 44, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 7, 14, 27, 11, 45, DateTimeKind.Utc).AddTicks(238), new DateTime(2025, 4, 7, 14, 27, 11, 45, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 4, 7, 14, 27, 11, 44, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2025, 4, 7, 17, 27, 11, 44, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "shippings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "ShippingDate" },
                values: new object[] { new DateTime(2025, 4, 12, 14, 27, 11, 44, DateTimeKind.Utc).AddTicks(8400), new DateTime(2025, 4, 7, 14, 27, 11, 44, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2025, 4, 7, 17, 27, 11, 44, DateTimeKind.Local).AddTicks(8606));
        }
    }
}
