using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopFashion.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 16, 20, 30, 731, DateTimeKind.Local).AddTicks(5368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 19, 16, 12, 39, 835, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 9, 19, 16, 20, 30, 744, DateTimeKind.Local).AddTicks(7204));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 16, 12, 39, 835, DateTimeKind.Local).AddTicks(4846),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 19, 16, 20, 30, 731, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 9, 19, 16, 12, 39, 849, DateTimeKind.Local).AddTicks(9642));
        }
    }
}
