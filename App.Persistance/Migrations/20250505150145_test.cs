using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp" },
                values: new object[] { "16f0bdd0-3a11-44c0-8d4f-05a254238d1c", new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5687), "cf23af15-d8cf-4944-8b49-b36445744a7b" });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4913), new DateTime(2025, 6, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4924), new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Moderators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(3687), new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PaymentDate" },
                values: new object[] { new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(3798), new DateTime(2025, 5, 5, 18, 1, 45, 325, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeliveryDate", "ShippingDate" },
                values: new object[] { new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(3926), new DateTime(2025, 5, 10, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(3933), new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TransactionDate" },
                values: new object[] { new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(4062), new DateTime(2025, 5, 5, 18, 1, 45, 325, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "UserCoupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "CreatedAt", "ExpirationDate", "UsedDate" },
                values: new object[] { new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5048), new DateTime(2025, 5, 5, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5044), new DateTime(2025, 6, 4, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5048), new DateTime(2025, 5, 15, 15, 1, 45, 325, DateTimeKind.Utc).AddTicks(5049) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp" },
                values: new object[] { "d9ddbcb8-b28f-48be-ae8b-e17c4ba2988a", new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(9412), "f7544f58-3219-4cc2-87b4-050f9c5c47c6" });

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 451, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(6942), new DateTime(2025, 5, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(6948), new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 451, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "Moderators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderDate" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(2129), new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PaymentDate" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(2484), new DateTime(2025, 4, 10, 0, 58, 35, 450, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Shippings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeliveryDate", "ShippingDate" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(2866), new DateTime(2025, 4, 14, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(2869), new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TransactionDate" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(3326), new DateTime(2025, 4, 10, 0, 58, 35, 450, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "UserCoupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedDate", "CreatedAt", "ExpirationDate", "UsedDate" },
                values: new object[] { new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(7384), new DateTime(2025, 4, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(7382), new DateTime(2025, 5, 9, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(7385), new DateTime(2025, 4, 19, 21, 58, 35, 450, DateTimeKind.Utc).AddTicks(7388) });
        }
    }
}
