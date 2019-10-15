using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogger.Migrations
{
    public partial class M004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_User_UserID",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "UsersList");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UsersList",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 30);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersList",
                table: "UsersList",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_UsersList_UserID",
                table: "Post",
                column: "UserID",
                principalTable: "UsersList",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_UsersList_UserID",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersList",
                table: "UsersList");

            migrationBuilder.RenameTable(
                name: "UsersList",
                newName: "User");

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "User",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_User_UserID",
                table: "Post",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
