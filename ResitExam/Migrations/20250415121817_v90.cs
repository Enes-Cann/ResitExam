using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class v90 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResitExams_Students_StudentId",
                table: "ResitExams");

            migrationBuilder.DropIndex(
                name: "IX_ResitExams_StudentId",
                table: "ResitExams");

            migrationBuilder.AddColumn<int>(
                name: "FinalGrade",
                table: "Courses",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalGrade",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_ResitExams_StudentId",
                table: "ResitExams",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResitExams_Students_StudentId",
                table: "ResitExams",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
