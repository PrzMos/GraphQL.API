using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQLBooks.API.Data.Migrations
{
    public partial class ChangeAuthorFirstNameProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirtName",
                table: "Authors",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Authors",
                newName: "FirtName");
        }
    }
}
