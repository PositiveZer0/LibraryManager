using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManager.Migrations
{
    public partial class AddBookImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookImageId",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookImage",
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
                    table.PrimaryKey("PK_BookImage", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookImageId",
                table: "Books",
                column: "BookImageId");

            migrationBuilder.CreateIndex(
                name: "IX_BookImage_IsDeleted",
                table: "BookImage",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookImage_BookImageId",
                table: "Books",
                column: "BookImageId",
                principalTable: "BookImage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookImage_BookImageId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookImage");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookImageId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookImageId",
                table: "Books");
        }
    }
}
