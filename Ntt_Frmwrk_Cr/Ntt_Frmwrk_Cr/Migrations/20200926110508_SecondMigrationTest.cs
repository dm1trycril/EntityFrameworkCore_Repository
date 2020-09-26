using Microsoft.EntityFrameworkCore.Migrations;

namespace Ntt_Frmwrk_Cr.Migrations
{
    public partial class SecondMigrationTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Users");
        }
    }
}
