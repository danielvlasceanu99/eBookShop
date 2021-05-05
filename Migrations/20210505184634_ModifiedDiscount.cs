using Microsoft.EntityFrameworkCore.Migrations;

namespace EBookShop.Migrations
{
    public partial class ModifiedDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_DiscountId",
                table: "Book",
                column: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Discount_DiscountId",
                table: "Book",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Discount_DiscountId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Discount_Book_BookId",
                table: "Discount");

            migrationBuilder.DropIndex(
                name: "IX_Discount_BookId",
                table: "Discount");

            migrationBuilder.DropIndex(
                name: "IX_Book_DiscountId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Discount");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Book");

            migrationBuilder.CreateIndex(
                name: "IX_Book_DiscountID",
                table: "Book",
                column: "DiscountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Discount_DiscountID",
                table: "Book",
                column: "DiscountID",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
