using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class AddInstructorIdToCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Instructors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResitGrade",
                table: "ResitExams");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Instructor");
        }
    }
}
