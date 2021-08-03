using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracticeDatabaseOptimization.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataRows",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VarCol1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarCol2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarCol3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataRows", x => x.RowId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataRows");
        }
    }
}
