using Microsoft.EntityFrameworkCore.Migrations;

namespace AddItemsDynamically.Migrations
{
    public partial class orderNameadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsUrgent",
                table: "Order",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsUrgent",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Order");
        }
    }
}
