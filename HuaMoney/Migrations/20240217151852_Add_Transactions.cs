using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HuaMoney.Migrations
{
    /// <inheritdoc />
    public partial class Add_Transactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO accounts (Id, UserId, AccountNumber, Amount, BankId, Currency, Name) VALUES 
                (1, 2, 'ACC-1', 2000.00, 1, 'EUR', 'Account 1'),
                (2, 3, 'ACC-1', 2000.00, 1, 'EUR', 'Account 1'),
                (3, 1, 'ACC-1', 2000.00, 2, 'EUR', 'Account 1'),
                (4, 2, 'ACC-1', 2000.00, 2, 'EUR', 'Account 1'),
                (5, 3, 'ACC-1', 2000.00, 2, 'EUR', 'Account 1'),
                (6, 1, 'ACC-1', 2000.00, 3, 'EUR', 'Account 1'),
                (7, 2, 'ACC-1', 2000.00, 3, 'EUR', 'Account 1'),
                (8, 3, 'ACC-1', 2000.00, 3, 'EUR', 'Account 1'),
                (9, 1, 'ACC-1', 2000.00, 4, 'EUR', 'Account 1'),
                (10, 2, 'ACC-1', 2000.00, 4, 'EUR', 'Account 1'),
                (11, 3, 'ACC-1', 2000.00, 4, 'EUR', 'Account 1'),
                (12, 1, 'ACC-1', 2000.00, 5, 'EUR', 'Account 1'),
                (13, 2, 'ACC-1', 2000.00, 5, 'EUR', 'Account 1'),
                (14, 3, 'ACC-1', 2000.00, 5, 'EUR', 'Account 1'),
                (15, 1, 'ACC-1', 2000.00, 6, 'EUR', 'Account 1'),
                (16, 2, 'ACC-1', 2000.00, 6, 'EUR', 'Account 1'),
                (17, 3, 'ACC-1', 2000.00, 6, 'EUR', 'Account 1'),
                (18, 1, 'ACC-1', 2000.00, 7, 'EUR', 'Account 1'),
                (19, 2, 'ACC-1', 2000.00, 7, 'EUR', 'Account 1'),
                (20, 3, 'ACC-1', 2000.00, 7, 'EUR', 'Account 1'),
                (21, 1, 'ACC-1', 2000.00, 8, 'EUR', 'Account 1'),
                (22, 2, 'ACC-1', 2000.00, 8, 'EUR', 'Account 1'),
                (23, 3, 'ACC-1', 2000.00, 8, 'EUR', 'Account 1'),
                (24, 1, 'ACC-1', 2000.00, 9, 'EUR', 'Account 1'),
                (25, 2, 'ACC-1', 2000.00, 9, 'EUR', 'Account 1')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
