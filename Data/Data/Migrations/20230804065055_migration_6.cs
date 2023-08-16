using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class migration_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderUser_Users_UsersId1",
                table: "OrderUser");

            migrationBuilder.RenameColumn(
                name: "UsersId1",
                table: "OrderUser",
                newName: "UsersIdId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderUser_UsersId1",
                table: "OrderUser",
                newName: "IX_OrderUser_UsersIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUser_Users_UsersIdId",
                table: "OrderUser",
                column: "UsersIdId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderUser_Users_UsersIdId",
                table: "OrderUser");

            migrationBuilder.RenameColumn(
                name: "UsersIdId",
                table: "OrderUser",
                newName: "UsersId1");

            migrationBuilder.RenameIndex(
                name: "IX_OrderUser_UsersIdId",
                table: "OrderUser",
                newName: "IX_OrderUser_UsersId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUser_Users_UsersId1",
                table: "OrderUser",
                column: "UsersId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
