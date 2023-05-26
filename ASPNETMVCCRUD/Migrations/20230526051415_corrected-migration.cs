using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNETMVCCRUD.Migrations
{
    /// <inheritdoc />
    public partial class correctedmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Emmployees",
                table: "Emmployees");

            migrationBuilder.RenameTable(
                name: "Emmployees",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Emmployees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emmployees",
                table: "Emmployees",
                column: "Id");
        }
    }
}
