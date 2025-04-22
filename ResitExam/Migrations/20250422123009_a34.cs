using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class a34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResitExamObjId",
                table: "Announcements",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_ResitExamObjId",
                table: "Announcements",
                column: "ResitExamObjId");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_ResitExams_ResitExamObjId",
                table: "Announcements",
                column: "ResitExamObjId",
                principalTable: "ResitExams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_ResitExams_ResitExamObjId",
                table: "Announcements");

            migrationBuilder.DropIndex(
                name: "IX_Announcements_ResitExamObjId",
                table: "Announcements");

            migrationBuilder.DropColumn(
                name: "ResitExamObjId",
                table: "Announcements");
        }
    }
}
