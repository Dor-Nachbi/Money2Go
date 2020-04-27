using Microsoft.EntityFrameworkCore.Migrations;

namespace Money2Go.Data.Migrations
{
    public partial class CriticalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "commentId",
                table: "Commentdb",
                newName: "CommentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Commentdb",
                newName: "commentId");
        }
    }
}
