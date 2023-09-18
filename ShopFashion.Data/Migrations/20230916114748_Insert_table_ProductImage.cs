using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopFashion.Data.Migrations
{
    public partial class Insert_table_ProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 18, 47, 48, 384, DateTimeKind.Local).AddTicks(2142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 16, 18, 44, 18, 700, DateTimeKind.Local).AddTicks(5286));

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
                value: new DateTime(2023, 9, 16, 18, 47, 48, 398, DateTimeKind.Local).AddTicks(7959));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 16, 18, 44, 18, 700, DateTimeKind.Local).AddTicks(5286),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2023, 9, 16, 18, 47, 48, 384, DateTimeKind.Local).AddTicks(2142));

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
                value: new DateTime(2023, 9, 16, 18, 44, 18, 714, DateTimeKind.Local).AddTicks(4607));
        }
    }
}
