using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HuaMoney.Migrations
{
    /// <inheritdoc />
    public partial class Add_Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO users (Name) VALUES ('User 1'),('User 2'), ('User 3');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
