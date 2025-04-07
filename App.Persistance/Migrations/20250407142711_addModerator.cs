using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class addModerator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "moderators",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Hasan" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "moderators",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "SecurityStamp" },
                values: new object[] { "3ed6510a-d37b-413c-a717-452fd0a4084c", new DateTime(2025, 4, 7, 14, 23, 10, 577, DateTimeKind.Utc).AddTicks(719), "9e94feed-0dfd-489a-893e-53cf847cceab" });

            migrationBuilder.UpdateData(
                table: "answers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 14, 23, 10, 576, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 7, 14, 23, 10, 576, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "coupons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 5, 7, 14, 23, 10, 576, DateTimeKind.Utc).AddTicks(8229), new DateTime(2025, 4, 7, 14, 23, 10, 576, DateTimeKind.Utc).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 4, 7, 14, 23, 10, 576, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "payments",
                keyColumn: "Id",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2025, 4, 7, 17, 23, 10, 576, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "shippings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryDate", "ShippingDate" },
                values: new object[] { new DateTime(2025, 4, 12, 14, 23, 10, 576, DateTimeKind.Utc).AddTicks(5545), new DateTime(2025, 4, 7, 14, 23, 10, 576, DateTimeKind.Utc).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionDate",
                value: new DateTime(2025, 4, 7, 17, 23, 10, 576, DateTimeKind.Local).AddTicks(5881));
        }
    }
}
