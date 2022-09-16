using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardDeckGame.Migrations
{
    public partial class AddedDataAndMoreProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Suit",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CardDecks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "CardDecks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "CardDecks",
                columns: new[] { "CardDeckId", "ImgName", "Name", "TotalCards" },
                values: new object[] { 1, "", "JackOfAllTrades", 52 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "CardDeckId", "ImgName", "Name", "Suit", "Value" },
                values: new object[] { 1, 1, "", "Ace of Hearts", "Hearts", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardDecks",
                keyColumn: "CardDeckId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "CardDecks");

            migrationBuilder.AlterColumn<string>(
                name: "Suit",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CardDecks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
