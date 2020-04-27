using Microsoft.EntityFrameworkCore.Migrations;

namespace Money2Go.Data.Migrations
{
    public partial class rudeCommentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RudeComment",
                table: "Commentdb",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RudeComment",
                table: "Commentdb");
        }
    }
}
