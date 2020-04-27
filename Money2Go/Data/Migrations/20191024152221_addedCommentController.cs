using Microsoft.EntityFrameworkCore.Migrations;

namespace Money2Go.Data.Migrations
{
    public partial class addedCommentController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentdb_Projectdb_ProjectId",
                table: "Commentdb");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentdb_AspNetUsers_ownerId",
                table: "Commentdb");

            migrationBuilder.RenameColumn(
                name: "ownerId",
                table: "Commentdb",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Commentdb",
                newName: "commentId");

            migrationBuilder.RenameIndex(
                name: "IX_Commentdb_ownerId",
                table: "Commentdb",
                newName: "IX_Commentdb_OwnerId");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Commentdb",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentdb_AspNetUsers_OwnerId",
                table: "Commentdb",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentdb_Projectdb_ProjectId",
                table: "Commentdb",
                column: "ProjectId",
                principalTable: "Projectdb",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commentdb_AspNetUsers_OwnerId",
                table: "Commentdb");

            migrationBuilder.DropForeignKey(
                name: "FK_Commentdb_Projectdb_ProjectId",
                table: "Commentdb");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Commentdb",
                newName: "ownerId");

            migrationBuilder.RenameColumn(
                name: "commentId",
                table: "Commentdb",
                newName: "CommentId");

            migrationBuilder.RenameIndex(
                name: "IX_Commentdb_OwnerId",
                table: "Commentdb",
                newName: "IX_Commentdb_ownerId");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Commentdb",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Commentdb_Projectdb_ProjectId",
                table: "Commentdb",
                column: "ProjectId",
                principalTable: "Projectdb",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commentdb_AspNetUsers_ownerId",
                table: "Commentdb",
                column: "ownerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
