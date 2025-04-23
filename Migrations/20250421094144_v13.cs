using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class v13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResitExamObjId",
                table: "ResitExams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResitExams_ResitExamObjId",
                table: "ResitExams",
                column: "ResitExamObjId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResitExams_ResitExams_ResitExamObjId",
                table: "ResitExams",
                column: "ResitExamObjId",
                principalTable: "ResitExams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResitExams_ResitExams_ResitExamObjId",
                table: "ResitExams");

            migrationBuilder.DropIndex(
                name: "IX_ResitExams_ResitExamObjId",
                table: "ResitExams");

            migrationBuilder.DropColumn(
                name: "ResitExamObjId",
                table: "ResitExams");
        }
    }
}
