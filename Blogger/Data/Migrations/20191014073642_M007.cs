using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogger.Migrations
{
    public partial class M007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "UsersList",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RolesList",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolesList", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersList_RoleId",
                table: "UsersList",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersList_RolesList_RoleId",
                table: "UsersList",
                column: "RoleId",
                principalTable: "RolesList",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersList_RolesList_RoleId",
                table: "UsersList");

            migrationBuilder.DropTable(
                name: "RolesList");

            migrationBuilder.DropIndex(
                name: "IX_UsersList_RoleId",
                table: "UsersList");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "UsersList");
        }
    }
}
