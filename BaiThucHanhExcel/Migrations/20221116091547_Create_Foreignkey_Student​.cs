using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaiThucHanhExcel.Migrations
{
    public partial class Create_Foreignkey_Student​ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacultyID",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FaculytyID",
                table: "Student",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_FaculytyID",
                table: "Student",
                column: "FaculytyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Faculty_FaculytyID",
                table: "Student",
                column: "FaculytyID",
                principalTable: "Faculty",
                principalColumn: "FacultyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Faculty_FaculytyID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_FaculytyID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FacultyID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FaculytyID",
                table: "Student");
        }
    }
}
