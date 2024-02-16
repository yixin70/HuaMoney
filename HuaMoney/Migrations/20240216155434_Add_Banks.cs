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

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM banks");
        }
    }
}
