using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManager.Migrations
{
    public partial class store1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Stores");

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Stores",
                nullable: false,
                defaultValue: 0);
        }
    }
}
