using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardDeckGame.Server.Migrations
{
    public partial class AddedHistoryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "History",
                columns: new[] { "HistoryId", "CardId", "Round" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "HistoryId",
                keyValue: 1);
        }
    }
}
