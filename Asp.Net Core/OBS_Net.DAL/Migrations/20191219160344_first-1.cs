using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS_Net.DAL.Migrations
{
    public partial class first1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Obs");

            migrationBuilder.CreateTable(
                name: "Tbl_Lessons",
                schema: "Obs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Lessons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Students",
                schema: "Obs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NameSurname = table.Column<string>(maxLength: 150, nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    StudentNu = table.Column<string>(nullable: true),
                    RegisterDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Teacher",
                schema: "Obs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NameSurname = table.Column<string>(maxLength: 150, nullable: false),
                    Tag = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Lessons_Student",
                schema: "Obs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StudentId = table.Column<Guid>(nullable: true),
                    LessonId = table.Column<Guid>(nullable: true),
                    TeacherId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Lessons_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Lessons_Student_Tbl_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalSchema: "Obs",
                        principalTable: "Tbl_Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Lessons_Student_Tbl_Students_StudentId",
                        column: x => x.StudentId,
                        principalSchema: "Obs",
                        principalTable: "Tbl_Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Lessons_Student_Tbl_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalSchema: "Obs",
                        principalTable: "Tbl_Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Lessons_Student_LessonId",
                schema: "Obs",
                table: "Tbl_Lessons_Student",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Lessons_Student_StudentId",
                schema: "Obs",
                table: "Tbl_Lessons_Student",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Lessons_Student_TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons_Student",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Lessons_Student",
                schema: "Obs");

            migrationBuilder.DropTable(
                name: "Tbl_Lessons",
                schema: "Obs");

            migrationBuilder.DropTable(
                name: "Tbl_Students",
                schema: "Obs");

            migrationBuilder.DropTable(
                name: "Tbl_Teacher",
                schema: "Obs");
        }
    }
}
