using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManager.Migrations
{
    public partial class AddMoreSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "BookImageId", "CreatedOn", "DeletedOn", "Description", "Genre", "IsDeleted", "ModifiedOn", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, "J. K. Rowling", null, new DateTime(2022, 3, 3, 21, 5, 53, 525, DateTimeKind.Local).AddTicks(8566), null, "The second instalment of boy wizard Harry Potter's adventures at Hogwarts School of Witchcraft and Wizardry, based on the novel by JK Rowling. A mysterious elf tells Harry to expect trouble during his second year at Hogwarts, but nothing can prepare him for trees that fight back, flying cars, spiders that talk and deadly warnings written in blood on the walls of the school.", "Fantasy Fiction", false, null, 10, "Harry Potter and the Chamber of Secrets" },
                    { 2, "James Clear", null, new DateTime(2022, 3, 3, 21, 5, 53, 528, DateTimeKind.Local).AddTicks(1818), null, "An atomic habit is a regular practice or routine that is not only small and easy to do but is also the source of incredible power; a component of the system of compound growth. Bad habits repeat themselves again and again not because you don't want to change, but because you have the wrong system for change.", "Self improvement", false, null, 5, "Atomic Habits" },
                    { 3, "Mario Puzo", null, new DateTime(2022, 3, 3, 21, 5, 53, 528, DateTimeKind.Local).AddTicks(1894), null, "The Godfather is a crime novel written by Mario Puzo, originally published in 1969 by G. P. Putnam's Sons. It details the story of a fictitious Sicilian Mafia family based in New York City and headed by Don Vito Corleone, who became synonymous with the Italian Mafia.", "Thriller", false, null, 5, "The Godfather" },
                    { 4, "Robert Kiyosaki", null, new DateTime(2022, 3, 3, 21, 5, 53, 528, DateTimeKind.Local).AddTicks(1901), null, "Rich Dad Poor Dad is about Robert Kiyosaki (author) and his two dads—his real father (poor dad) and the father of his best friend (rich dad)—and the ways in which both men shaped his thoughts about money and investing. The book explodes the myth that you do not need to earn a high income to become rich.", "Personal finance", false, null, 100, "Rich Dad Poor Dad" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "DeletedOn", "Email", "IsDeleted", "IsLoggedIn", "ModifiedOn", "Name", "Password", "Role", "Surname", "UserImageId" },
                values: new object[,]
                {
                    { "0d415448-33a9-4e8b-9038-b3fabb27ee8a", new DateTime(2022, 3, 3, 21, 5, 53, 529, DateTimeKind.Local).AddTicks(2025), null, "admin@admin.com", false, false, null, "Admin", "$MYHASH$V1$10000$WnjGq+UwNAO7PC8CGkd7EirIZEvU7sz7EXqY1jEbp296+r2o", "Admin", "Admin", null },
                    { "417bbb60-6858-4928-962d-dd7b812a8b6b", new DateTime(2022, 3, 3, 21, 5, 53, 536, DateTimeKind.Local).AddTicks(8752), null, "student@student.com", false, false, null, "Student", "$MYHASH$V1$10000$165K0giMmoZIhbudf6LMINT2wUT8JzJy+tX++4xywas5VVJw", "Student", "Student", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "0d415448-33a9-4e8b-9038-b3fabb27ee8a");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "417bbb60-6858-4928-962d-dd7b812a8b6b");
        }
    }
}
