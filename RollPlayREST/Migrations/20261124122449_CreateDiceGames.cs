using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RollPlayREST.Migrations
{
    /// <inheritdoc />
    public partial class CreateDiceGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiceGameId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiceGameId",
                table: "Dices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DiceGame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiceGame", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_DiceGameId",
                table: "Users",
                column: "DiceGameId");

            migrationBuilder.CreateIndex(
                name: "IX_Dices_DiceGameId",
                table: "Dices",
                column: "DiceGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dices_DiceGame_DiceGameId",
                table: "Dices",
                column: "DiceGameId",
                principalTable: "DiceGame",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_DiceGame_DiceGameId",
                table: "Users",
                column: "DiceGameId",
                principalTable: "DiceGame",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dices_DiceGame_DiceGameId",
                table: "Dices");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_DiceGame_DiceGameId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "DiceGame");

            migrationBuilder.DropIndex(
                name: "IX_Users_DiceGameId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Dices_DiceGameId",
                table: "Dices");

            migrationBuilder.DropColumn(
                name: "DiceGameId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DiceGameId",
                table: "Dices");
        }
    }
}
