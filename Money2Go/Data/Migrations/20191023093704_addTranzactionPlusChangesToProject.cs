using Microsoft.EntityFrameworkCore.Migrations;

namespace Money2Go.Data.Migrations
{
    public partial class addTranzactionPlusChangesToProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tranzactiondb_Projectdb_ProjectId",
                table: "Tranzactiondb");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Tranzactiondb",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tranzactiondb_Projectdb_ProjectId",
                table: "Tranzactiondb",
                column: "ProjectId",
                principalTable: "Projectdb",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tranzactiondb_Projectdb_ProjectId",
                table: "Tranzactiondb");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Tranzactiondb",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Tranzactiondb_Projectdb_ProjectId",
                table: "Tranzactiondb",
                column: "ProjectId",
                principalTable: "Projectdb",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
