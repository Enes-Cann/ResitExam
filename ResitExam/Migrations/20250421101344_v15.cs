using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class v15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ResitExams_ResitExamId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ResitExamId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ResitExamId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "ResitExams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ResitExams_CourseId",
                table: "ResitExams",
                column: "CourseId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ResitExams_Courses_CourseId",
                table: "ResitExams",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResitExams_Courses_CourseId",
                table: "ResitExams");

            migrationBuilder.DropIndex(
                name: "IX_ResitExams_CourseId",
                table: "ResitExams");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "ResitExams");

            migrationBuilder.AddColumn<int>(
                name: "ResitExamId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ResitExamId",
                table: "Courses",
                column: "ResitExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ResitExams_ResitExamId",
                table: "Courses",
                column: "ResitExamId",
                principalTable: "ResitExams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
