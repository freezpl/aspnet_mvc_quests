using Microsoft.EntityFrameworkCore.Migrations;

namespace QuestDAL.Migrations
{
    public partial class descript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Companies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Companies",
                maxLength: 255,
                nullable: true);
        }
    }
}
