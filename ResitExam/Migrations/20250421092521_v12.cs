using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class v12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResitExamObjId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ResitExamObjId",
                table: "Students",
                column: "ResitExamObjId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ResitExams_ResitExamObjId",
                table: "Students",
                column: "ResitExamObjId",
                principalTable: "ResitExams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_ResitExams_ResitExamObjId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ResitExamObjId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ResitExamObjId",
                table: "Students");
        }
    }
}
