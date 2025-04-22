using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class a1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Students",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResitExams_Students_StudentId",
                table: "ResitExams");

            migrationBuilder.DropIndex(
                name: "IX_ResitExams_StudentId",
                table: "ResitExams");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Students");
        }
    }
}
