using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class v122 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "StudentNumber",
                table: "Students",
                newName: "ResitExamId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ResitExamId",
                table: "Students",
                column: "ResitExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ResitExams_ResitExamId",
                table: "Students",
                column: "ResitExamId",
                principalTable: "ResitExams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_ResitExams_ResitExamId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ResitExamId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "ResitExamId",
                table: "Students",
                newName: "StudentNumber");

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
    }
}
