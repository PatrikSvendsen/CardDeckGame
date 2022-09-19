using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardDeckGame.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardDecks",
                columns: table => new
                {
                    CardDeckId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalCards = table.Column<int>(type: "int", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDecks", x => x.CardDeckId);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardDeckId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_CardDecks_CardDeckId",
                        column: x => x.CardDeckId,
                        principalTable: "CardDecks",
                        principalColumn: "CardDeckId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    HistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Round = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.HistoryId);
                    table.ForeignKey(
                        name: "FK_History_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "CardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CardDecks",
                columns: new[] { "CardDeckId", "ImgName", "Name", "TotalCards" },
                values: new object[] { 1, "", "JackOfAllTrades", 52 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardDeckId", "ImgName", "Name", "Suit" },
                values: new object[,]
                {
                    { 1, 1, "", "Ace of Hearts", "Hearts" },
                    { 2, 1, "", "Two", "Hearts" },
                    { 3, 1, "", "Three", "Hearts" },
                    { 4, 1, "", "Four", "Hearts" },
                    { 5, 1, "", "Five", "Hearts" },
                    { 6, 1, "", "Six", "Hearts" },
                    { 7, 1, "", "Seven", "Hearts" },
                    { 8, 1, "", "Eight", "Hearts" },
                    { 9, 1, "", "Nine", "Hearts" },
                    { 10, 1, "", "Ten", "Hearts" },
                    { 11, 1, "", "Jack", "Hearts" },
                    { 12, 1, "", "Queen", "Hearts" },
                    { 13, 1, "", "King", "Hearts" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardDeckId",
                table: "Cards",
                column: "CardDeckId");

            migrationBuilder.CreateIndex(
                name: "IX_History_CardId",
                table: "History",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "CardDecks");
        }
    }
}
