using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogger.Migrations
{
    public partial class M005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_UsersList_UserID",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Post",
                newName: "BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_UserID",
                table: "Post",
                newName: "IX_Post_BlogId");

            migrationBuilder.CreateTable(
                name: "BlogList",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 30, nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogList", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BlogList_UsersList_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersList",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogList_UserId",
                table: "BlogList",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_BlogList_BlogId",
                table: "Post",
                column: "BlogId",
                principalTable: "BlogList",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_BlogList_BlogId",
                table: "Post");

            migrationBuilder.DropTable(
                name: "BlogList");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Post",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Post_BlogId",
                table: "Post",
                newName: "IX_Post_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_UsersList_UserID",
                table: "Post",
                column: "UserID",
                principalTable: "UsersList",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
