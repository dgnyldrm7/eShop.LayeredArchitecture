using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class addFavoriteShippingAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_AspNetUsers_UserId",
                table: "Favorite");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_products_ProductId",
                table: "Favorite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorite",
                table: "Favorite");

            migrationBuilder.RenameTable(
                name: "Favorite",
                newName: "favorites");

            migrationBuilder.RenameIndex(
                name: "IX_Favorite_UserId",
                table: "favorites",
                newName: "IX_favorites_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorite_ProductId",
                table: "favorites",
                newName: "IX_favorites_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_favorites",
                table: "favorites",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp" },
                values: new object[] { "8a9e0c5a-0b2e-4499-b706-5c1771a2de03", new DateTime(2025, 4, 7, 15, 29, 33, 326, DateTimeKind.Utc).AddTicks(283), "296ae950-f1ea-4244-81fa-68a9df95e3c3" });

            migrationBuilder.UpdateData(
                table: "answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 15, 29, 33, 325, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 15, 29, 33, 325, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 7, 15, 29, 33, 325, DateTimeKind.Utc).AddTicks(8552), new DateTime(2025, 4, 7, 15, 29, 33, 325, DateTimeKind.Utc).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "favorites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 15, 29, 33, 326, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 4, 7, 15, 29, 33, 325, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2025, 4, 7, 18, 29, 33, 325, DateTimeKind.Local).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "shippings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "ShippingDate" },
                values: new object[] { new DateTime(2025, 4, 12, 15, 29, 33, 325, DateTimeKind.Utc).AddTicks(6661), new DateTime(2025, 4, 7, 15, 29, 33, 325, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2025, 4, 7, 18, 29, 33, 325, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.AddForeignKey(
                name: "FK_favorites_AspNetUsers_UserId",
                table: "favorites",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_favorites_products_ProductId",
                table: "favorites",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_favorites_AspNetUsers_UserId",
                table: "favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_favorites_products_ProductId",
                table: "favorites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_favorites",
                table: "favorites");

            migrationBuilder.RenameTable(
                name: "favorites",
                newName: "Favorite");

            migrationBuilder.RenameIndex(
                name: "IX_favorites_UserId",
                table: "Favorite",
                newName: "IX_Favorite_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_favorites_ProductId",
                table: "Favorite",
                newName: "IX_Favorite_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorite",
                table: "Favorite",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp" },
                values: new object[] { "e15a6208-39b7-428c-9903-b49dea05d33c", new DateTime(2025, 4, 7, 15, 27, 21, 700, DateTimeKind.Utc).AddTicks(2234), "7d228117-7a91-4690-b102-7c3a2b6e023e" });

            migrationBuilder.UpdateData(
                table: "Favorite",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 15, 27, 21, 700, DateTimeKind.Utc).AddTicks(2774));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_AspNetUsers_UserId",
                table: "Favorite",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_products_ProductId",
                table: "Favorite",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
