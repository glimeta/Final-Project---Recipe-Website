using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project___Recipe_Website.Migrations
{
    public partial class AddingNewRecipeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Recipe",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Recipe",
                newName: "RecipeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Recipe",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "RecipeID",
                table: "Recipe",
                newName: "RecipeId");
        }
    }
}
