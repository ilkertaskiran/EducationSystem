using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Education");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Education",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Education");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Education",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
