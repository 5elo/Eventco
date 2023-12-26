using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECUEvents.Migrations
{
    public partial class AddPriceTOEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "ECUEvent_Event",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "ECUEvent_Event");
        }
    }
}
