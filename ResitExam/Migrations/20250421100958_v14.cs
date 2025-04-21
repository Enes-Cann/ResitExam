using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class v14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResitExams_Courses_CourseId",
                table: "ResitExams");

            migrationBuilder.DropForeignKey(
                name: "FK_ResitExams_ResitExams_ResitExamObjId",
                table: "ResitExams");

            migrationBuilder.DropIndex(
                name: "IX_ResitExams_CourseId",
                table: "ResitExams");

            migrationBuilder.DropIndex(
                name: "IX_ResitExams_ResitExamObjId",
                table: "ResitExams");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "ResitExams");

            migrationBuilder.DropColumn(
                name: "ResitExamObjId",
                table: "ResitExams");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "ResitExams",
                newName: "ResitGrade");

            migrationBuilder.AddColumn<int>(
                name: "StudentNumber",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ResitExams_ResitExamId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ResitExamId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ResitExamId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "ResitGrade",
                table: "ResitExams",
                newName: "StudentId");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "ResitExams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResitExamObjId",
                table: "ResitExams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResitExams_CourseId",
                table: "ResitExams",
                column: "CourseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResitExams_ResitExamObjId",
                table: "ResitExams",
                column: "ResitExamObjId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResitExams_Courses_CourseId",
                table: "ResitExams",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResitExams_ResitExams_ResitExamObjId",
                table: "ResitExams",
                column: "ResitExamObjId",
                principalTable: "ResitExams",
                principalColumn: "Id");
        }
    }
}
