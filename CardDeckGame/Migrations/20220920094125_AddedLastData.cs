using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardDeckGame.Server.Migrations
{
    public partial class AddedLastData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1,
                column: "ImgName",
                value: "/images/hearts/ace.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2,
                column: "ImgName",
                value: "/images/hearts/2.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3,
                column: "ImgName",
                value: "/images/hearts/3.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 4,
                column: "ImgName",
                value: "/images/hearts/4.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 5,
                column: "ImgName",
                value: "/images/hearts/5.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 6,
                column: "ImgName",
                value: "/images/hearts/6.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 7,
                column: "ImgName",
                value: "/images/hearts/7.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 8,
                column: "ImgName",
                value: "/images/hearts/8.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 9,
                column: "ImgName",
                value: "/images/hearts/9.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 10,
                column: "ImgName",
                value: "/images/hearts/10.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 11,
                column: "ImgName",
                value: "/images/hearts/jack.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 12,
                column: "ImgName",
                value: "/images/hearts/queen.png");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 13,
                column: "ImgName",
                value: "/images/hearts/king.png");

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardDeckId", "ImgName", "Name", "Suit" },
                values: new object[,]
                {
                    { 14, 1, "/images/clubs/ace.png", "Ace of Clubs", "Clubs" },
                    { 15, 1, "/images/clubs/2.png", "Two", "Clubs" },
                    { 16, 1, "/images/clubs/3.png", "Three", "Clubs" },
                    { 17, 1, "/images/clubs/4.png", "Four", "Clubs" },
                    { 18, 1, "/images/clubs/5.png", "Five", "Clubs" },
                    { 19, 1, "/images/clubs/6.png", "Six", "Clubs" },
                    { 20, 1, "/images/clubs/7.png", "Seven", "Clubs" },
                    { 21, 1, "/images/clubs/8.png", "Eight", "Clubs" },
                    { 22, 1, "/images/clubs/9.png", "Nine", "Clubs" },
                    { 23, 1, "/images/clubs/10.png", "Ten", "Clubs" },
                    { 24, 1, "/images/clubs/jack.png", "Jack", "Clubs" },
                    { 25, 1, "/images/clubs/queen.png", "Queen", "Clubs" },
                    { 26, 1, "/images/clubs/king.png", "King", "Clubs" },
                    { 27, 1, "/images/spades/ace.png", "Ace of Spades", "Spades" },
                    { 28, 1, "/images/spades/2.png", "Two", "Spades" },
                    { 29, 1, "/images/spades/3.png", "Three", "Spades" },
                    { 30, 1, "/images/spades/4.png", "Four", "Spades" },
                    { 31, 1, "/images/spades/5.png", "Five", "Spades" },
                    { 32, 1, "/images/spades/6.png", "Six", "Spades" },
                    { 33, 1, "/images/spades/7.png", "Seven", "Spades" },
                    { 34, 1, "/images/spades/8.png", "Eight", "Spades" },
                    { 35, 1, "/images/spades/9.png", "Nine", "Spades" },
                    { 36, 1, "/images/spades/10.png", "Ten", "Spades" },
                    { 37, 1, "/images/spades/jack.png", "Jack", "Spades" },
                    { 38, 1, "/images/spades/queen.png", "Queen", "Spades" },
                    { 39, 1, "/images/spades/king.png", "King", "Spades" },
                    { 40, 1, "/images/diamonds/ace.png", "Ace of Diamonds", "Diamonds" },
                    { 41, 1, "/images/diamonds/2.png", "Two", "Diamonds" },
                    { 42, 1, "/images/diamonds/3.png", "Three", "Diamonds" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardDeckId", "ImgName", "Name", "Suit" },
                values: new object[,]
                {
                    { 43, 1, "/images/diamonds/4.png", "Four", "Diamonds" },
                    { 44, 1, "/images/diamonds/5.png", "Five", "Diamonds" },
                    { 45, 1, "/images/diamonds/6.png", "Six", "Diamonds" },
                    { 46, 1, "/images/diamonds/7.png", "Seven", "Diamonds" },
                    { 47, 1, "/images/diamonds/8.png", "Eight", "Diamonds" },
                    { 48, 1, "/images/diamonds/9.png", "Nine", "Diamonds" },
                    { 49, 1, "/images/diamonds/10.png", "Ten", "Diamonds" },
                    { 50, 1, "/images/diamonds/jack.png", "Jack", "Diamonds" },
                    { 51, 1, "/images/diamonds/queen.png", "Queen", "Diamonds" },
                    { 52, 1, "/images/diamonds/king.png", "King", "Diamonds" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 52);

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 3,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 4,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 5,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 6,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 7,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 8,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 9,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 10,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 11,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 12,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 13,
                column: "ImgName",
                value: "");
        }
    }
}
