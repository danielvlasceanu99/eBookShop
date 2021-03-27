using Microsoft.EntityFrameworkCore.Migrations;

namespace EBookShop.Migrations
{
    public partial class Modified_models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PreviewId",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Author",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PreviewId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Author");
        }
    }
}
