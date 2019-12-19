using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS_Net.DAL.Migrations
{
    public partial class first2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "Obs",
                table: "Tbl_Students",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "Obs",
                table: "Tbl_Students");
        }
    }
}
