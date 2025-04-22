using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class a32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ResitExams_StudentId",
                table: "ResitExams",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResitExams_Students_StudentId",
                table: "ResitExams",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResitExams_Students_StudentId",
                table: "ResitExams");

            migrationBuilder.DropIndex(
                name: "IX_ResitExams_StudentId",
                table: "ResitExams");
        }
    }
}
