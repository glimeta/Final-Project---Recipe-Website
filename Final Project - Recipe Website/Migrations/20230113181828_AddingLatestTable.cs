using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project___Recipe_Website.Migrations
{
    public partial class AddingLatestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Recipe");

            migrationBuilder.RenameColumn(
                name: "RecipeID",
                table: "Recipe",
                newName: "RecipeId");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Recipe",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Recipe");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Recipe",
                newName: "RecipeID");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
