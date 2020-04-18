using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -1, "Todd Phillips", new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crime , Drama , Thriller", "Joker", "https://www.kinopoisk.ru/images/film_big/1048334.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -2, "David Leitch", new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Action , Adventure", "Fast & Furious Presents: Hobbs & Shaw", "https://m.media-amazon.com/images/I/A1nD1zDE9pL._SS500_.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -3, "Jon Favreau", new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adventure , Animation , Drama , Family , Musical", "The Lion King", "https://images-na.ssl-images-amazon.com/images/I/91kXw97IUBL._AC_SL1500_.jpg" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Author", "CreatedAt", "Genre", "Name", "Poster" },
                values: new object[] { -4, "Joachim Rønning", new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adventure , Family , Fantasy", "Maleficent: Mistress of Evil", "https://st.kp.yandex.net/images/film_iphone/iphone360_916498.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
