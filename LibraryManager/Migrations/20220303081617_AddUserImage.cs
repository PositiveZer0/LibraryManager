using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManager.Migrations
{
    public partial class AddUserImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEmailVerified",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserImageId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserImage", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserImageId",
                table: "Users",
                column: "UserImageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserImage_IsDeleted",
                table: "UserImage",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserImage_UserImageId",
                table: "Users",
                column: "UserImageId",
                principalTable: "UserImage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserImage_UserImageId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserImage");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserImageId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserImageId",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "IsEmailVerified",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
