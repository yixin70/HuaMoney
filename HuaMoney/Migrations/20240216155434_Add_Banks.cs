using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HuaMoney.Migrations
{
    /// <inheritdoc />
    public partial class Add_Banks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO banks (Country, Name)" +
                                " VALUES ('ES', 'Banco Bilbao Vizcaya Argentaria, S.A'), ('ES', 'Banco de Sabadell, S.A.'), ('ES', 'Santander'), ('ES', 'CaixaBank')" +
                                " , ('GB', 'Revolut Ltd'), ('ES', 'N26 Bank AG'), ('CN', '上海银行'), ('CN', '微信支付'), ('CN', '支付宝')");
            migrationBuilder.Sql("INSERT INTO banks (Country, Name)" +
                                " VALUES ('ES', 'Banco Bilbao Vizcaya Argentaria, S.A'), ('ES', 'Banco de Sabadell, S.A.'), ('ES', 'Santander'), ('ES', 'CaixaBank')" +
                                " , ('GB', 'Revolut Ltd'), ('ES', 'N26 Bank AG'), ('CN', '上海银行'), ('CN', '微信支付'), ('CN', '支付宝')");
            migrationBuilder.Sql("INSERT INTO users (Name)\nVALUES \n('User 1'),\n('User 2'),\n('User 3');");
            migrationBuilder.Sql("INSERT INTO accounts (UserId, AccountNumber, Amount, BankId, Currency, Name)\n\nSELECT\n    u.Id,\n    CONCAT('ACC-', u.Id),\n    2000.00, -- Example amount\n    b.Id,\n    'EUR', -- Example currency\n    CONCAT('Account ', u.Id)\nFROM\n    users u\n        CROSS JOIN banks b;");
            migrationBuilder.Sql(@"
INSERT INTO huamoney.accounts (Id, UserId, AccountNumber, Amount, BankId, Currency, Name) VALUES 
                (0, 1, 'ACC-1', 2000.00, 1, 'EUR', 'Account 1'),
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
            migrationBuilder.Sql(@"DELETE FROM banks");
        }
    }
}
