using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class _1toMRS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_Ins_ID",
                table: "Department");

            migrationBuilder.AddColumn<int>(
                name: "HeadID",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Department_HeadID",
                table: "Department",
                column: "HeadID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_HeadID",
                table: "Department",
                column: "HeadID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_HeadID",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_HeadID",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "HeadID",
                table: "Department");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Ins_ID",
                table: "Department",
                column: "Ins_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department",
                column: "Ins_ID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
