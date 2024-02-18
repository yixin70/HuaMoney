using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HuaMoney.Migrations
{
    /// <inheritdoc />
    public partial class Currencies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "accounts");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyId",
                table: "transactions",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CurrencyId",
                table: "accounts",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb4_0900_ai_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_0900_ai_ci");

            migrationBuilder.CreateIndex(
                name: "IX_transactions_CurrencyId",
                table: "transactions",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_CurrencyId",
                table: "accounts",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_accounts_Currency_CurrencyId",
                table: "accounts",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_Currency_CurrencyId",
                table: "transactions",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accounts_Currency_CurrencyId",
                table: "accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_transactions_Currency_CurrencyId",
                table: "transactions");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropIndex(
                name: "IX_transactions_CurrencyId",
                table: "transactions");

            migrationBuilder.DropIndex(
                name: "IX_accounts_CurrencyId",
                table: "accounts");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "transactions");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "accounts");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "transactions",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "accounts",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
