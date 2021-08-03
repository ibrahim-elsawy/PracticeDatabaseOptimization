using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeDatabaseOptimization.Migrations
{
    public partial class seeding_first_time : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DataRows",
                columns: new[] { "RowId", "DateTime", "VarCol1", "VarCol2", "VarCol3" },
                values: new object[] { 1, new DateTime(2021, 8, 3, 2, 52, 39, 656, DateTimeKind.Local).AddTicks(8677), "Test1", "Test2", "Test3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DataRows",
                keyColumn: "RowId",
                keyValue: 1);
        }
    }
}
