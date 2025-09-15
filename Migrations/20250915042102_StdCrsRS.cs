using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class StdCrsRS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_Course_ID",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_stud_ID",
                table: "Stud_Course");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "Stud_Course",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "stud_ID",
                table: "Stud_Course",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Course_Course_ID",
                table: "Stud_Course",
                newName: "IX_Stud_Course_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "Grade",
                table: "Stud_Course",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_StudentId",
                table: "Stud_Course",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_StudentId",
                table: "Stud_Course");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Stud_Course",
                newName: "Course_ID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Stud_Course",
                newName: "stud_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Stud_Course_CourseId",
                table: "Stud_Course",
                newName: "IX_Stud_Course_Course_ID");

            migrationBuilder.AlterColumn<string>(
                name: "Grade",
                table: "Stud_Course",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_Course_ID",
                table: "Stud_Course",
                column: "Course_ID",
                principalTable: "Course",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_stud_ID",
                table: "Stud_Course",
                column: "stud_ID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
