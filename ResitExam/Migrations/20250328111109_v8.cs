using Microsoft.EntityFrameworkCore.Migrations;



#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_ResitExams_Courses_CourseId",
                table: "ResitExams");

            migrationBuilder.DropIndex(
                name: "IX_ResitExams_CourseId",
                table: "ResitExams");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IsResitExamActive",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "ResitExamIsActive",
                table: "Students",
                newName: "WillTakeTheExam");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "ResitExams",
                newName: "Grade");

            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "Courses",
                newName: "ResitExamId");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Courses",
                newName: "CourseCode");

            migrationBuilder.AddColumn<bool>(
                name: "CanTakeTheExam",
                table: "Students",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ResitExamId",
                table: "Courses",
                column: "ResitExamId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");

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

            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ResitExamId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CanTakeTheExam",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "WillTakeTheExam",
                table: "Students",
                newName: "ResitExamIsActive");

            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "ResitExams",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "ResitExamId",
                table: "Courses",
                newName: "Grade");

            migrationBuilder.RenameColumn(
                name: "CourseCode",
                table: "Courses",
                newName: "Code");

            migrationBuilder.AddColumn<bool>(
                name: "IsResitExamActive",
                table: "Courses",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResitExams_CourseId",
                table: "ResitExams",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId",
                table: "Courses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResitExams_Courses_CourseId",
                table: "ResitExams",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
