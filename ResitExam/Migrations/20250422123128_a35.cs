using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResitExam.Migrations
{
    /// <inheritdoc />
    public partial class a35 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_ResitExams_ResitExamObjId",
                table: "Announcements");

            migrationBuilder.AlterColumn<int>(
                name: "ResitExamObjId",
                table: "Announcements",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_ResitExams_ResitExamObjId",
                table: "Announcements",
                column: "ResitExamObjId",
                principalTable: "ResitExams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Announcements_ResitExams_ResitExamObjId",
                table: "Announcements");

            migrationBuilder.AlterColumn<int>(
                name: "ResitExamObjId",
                table: "Announcements",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Announcements_ResitExams_ResitExamObjId",
                table: "Announcements",
                column: "ResitExamObjId",
                principalTable: "ResitExams",
                principalColumn: "Id");
        }
    }
}
