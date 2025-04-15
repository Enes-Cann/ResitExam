using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class v92 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasResitExam",
                table: "Courses",
                newName: "HasResitExamButton");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HasResitExamButton",
                table: "Courses",
                newName: "HasResitExam");
        }
    }
}
