using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Money2Go.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Credit",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EnrollmentDate",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Projectdb",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    pic_path = table.Column<string>(nullable: true),
                    vid_path = table.Column<string>(nullable: true),
                    goal = table.Column<int>(nullable: false),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projectdb", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projectdb_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commentdb",
                columns: table => new
                {
                    commentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ownerId = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: true),
                    theComment = table.Column<string>(nullable: true),
                    dateSubmit = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentdb", x => x.commentId);
                    table.ForeignKey(
                        name: "FK_Commentdb_Projectdb_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projectdb",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commentdb_AspNetUsers_ownerId",
                        column: x => x.ownerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tranzactiondb",
                columns: table => new
                {
                    TranzactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    DateT = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tranzactiondb", x => x.TranzactionId);
                    table.ForeignKey(
                        name: "FK_Tranzactiondb_Projectdb_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projectdb",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tranzactiondb_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commentdb_ProjectId",
                table: "Commentdb",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentdb_ownerId",
                table: "Commentdb",
                column: "ownerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projectdb_UserId",
                table: "Projectdb",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactiondb_ProjectId",
                table: "Tranzactiondb",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Tranzactiondb_UserId",
                table: "Tranzactiondb",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentdb");

            migrationBuilder.DropTable(
                name: "Tranzactiondb");

            migrationBuilder.DropTable(
                name: "Projectdb");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EnrollmentDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
