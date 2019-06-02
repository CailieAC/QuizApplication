using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApplication.Data.Migrations
{
    public partial class AlterQuizTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Quizzes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Quizzes");
        }
    }
}
