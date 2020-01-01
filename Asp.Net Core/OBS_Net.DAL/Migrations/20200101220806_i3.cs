using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OBS_Net.DAL.Migrations
{
    public partial class i3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Lessons_Student_Tbl_Teacher_TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons_Student");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Lessons_Student_TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons_Student");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons_Student");

            migrationBuilder.AddColumn<Guid>(
                name: "TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Lessons_TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Lessons_Tbl_Teacher_TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons",
                column: "TeacherId",
                principalSchema: "Obs",
                principalTable: "Tbl_Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Lessons_Tbl_Teacher_TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Lessons_TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons");

            migrationBuilder.AddColumn<Guid>(
                name: "TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons_Student",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Lessons_Student_TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons_Student",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Lessons_Student_Tbl_Teacher_TeacherId",
                schema: "Obs",
                table: "Tbl_Lessons_Student",
                column: "TeacherId",
                principalSchema: "Obs",
                principalTable: "Tbl_Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
