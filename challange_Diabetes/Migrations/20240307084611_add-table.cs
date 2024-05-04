using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace challenge_Diabetes.Migrations
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Community",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sharing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Community_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appointment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    classification = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    type = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "measuring_Pressures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diastolic_pressure = table.Column<int>(type: "int", nullable: false),
                    Systolic_pressure = table.Column<int>(type: "int", nullable: false),
                    Heart_rate = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_measuring_Pressures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_measuring_Pressures_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "measuring_Sugars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sugar_reading = table.Column<int>(type: "int", nullable: false),
                    measurement_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_measuring_Sugars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_measuring_Sugars_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "measuring_Weights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    weight = table.Column<int>(type: "int", nullable: false),
                    sport = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_measuring_Weights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_measuring_Weights_AspNetUsers_User_Id",
                        column: x => x.User_Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Observers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    relvant_relation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserDoctor",
                columns: table => new
                {
                    DoctorsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserDoctor", x => new { x.DoctorsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserDoctor_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserDoctor_Doctors_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserFood",
                columns: table => new
                {
                    FoodsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserFood", x => new { x.FoodsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserFood_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserFood_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserObserver",
                columns: table => new
                {
                    ObserversId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserObserver", x => new { x.ObserversId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserObserver_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserObserver_Observers_ObserversId",
                        column: x => x.ObserversId,
                        principalTable: "Observers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserSport",
                columns: table => new
                {
                    SportsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserSport", x => new { x.SportsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserSport_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserSport_sports_SportsId",
                        column: x => x.SportsId,
                        principalTable: "sports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDoctor_UsersId",
                table: "ApplicationUserDoctor",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserFood_UsersId",
                table: "ApplicationUserFood",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserObserver_UsersId",
                table: "ApplicationUserObserver",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserSport_UsersId",
                table: "ApplicationUserSport",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Community_User_Id",
                table: "Community",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_measuring_Pressures_User_Id",
                table: "measuring_Pressures",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_measuring_Sugars_User_Id",
                table: "measuring_Sugars",
                column: "User_Id");

            migrationBuilder.CreateIndex(
                name: "IX_measuring_Weights_User_Id",
                table: "measuring_Weights",
                column: "User_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserDoctor");

            migrationBuilder.DropTable(
                name: "ApplicationUserFood");

            migrationBuilder.DropTable(
                name: "ApplicationUserObserver");

            migrationBuilder.DropTable(
                name: "ApplicationUserSport");

            migrationBuilder.DropTable(
                name: "Community");

            migrationBuilder.DropTable(
                name: "measuring_Pressures");

            migrationBuilder.DropTable(
                name: "measuring_Sugars");

            migrationBuilder.DropTable(
                name: "measuring_Weights");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Observers");

            migrationBuilder.DropTable(
                name: "sports");
        }
    }
}
