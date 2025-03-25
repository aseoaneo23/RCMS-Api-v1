using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RCMS.Infrastructure.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class addEnglishVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Category",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Category",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Category",
                newName: "Descripcion");
        }
    }
}
