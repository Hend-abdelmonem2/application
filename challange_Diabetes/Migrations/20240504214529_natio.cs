using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace challenge_Diabetes.Migrations
{
    public partial class natio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserMedicine_Medicine_MedicinesId",
                table: "ApplicationUserMedicine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicine",
                table: "Medicine");

            migrationBuilder.RenameTable(
                name: "Medicine",
                newName: "medicines");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medicines",
                table: "medicines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserMedicine_medicines_MedicinesId",
                table: "ApplicationUserMedicine",
                column: "MedicinesId",
                principalTable: "medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserMedicine_medicines_MedicinesId",
                table: "ApplicationUserMedicine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medicines",
                table: "medicines");

            migrationBuilder.RenameTable(
                name: "medicines",
                newName: "Medicine");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicine",
                table: "Medicine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserMedicine_Medicine_MedicinesId",
                table: "ApplicationUserMedicine",
                column: "MedicinesId",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
