using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace challenge_Diabetes.Migrations
{
    public partial class userId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User_Id",
                table: "Medicine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User_Id",
                table: "Medicine");
        }
    }
}
