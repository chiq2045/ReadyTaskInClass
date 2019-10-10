using Microsoft.EntityFrameworkCore.Migrations;

namespace ReadyTask.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c82ae0cc-42ab-4144-848f-fd9c92eb8a8f", "AQAAAAEAACcQAAAAEJJoz5jR03DJM5svaiC7VfWLScdyVlfJzblNhV7C9O9fYA3QhuQvGD0tYq7cajtf5g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e29de235-25d8-4bcf-b4f1-d39bf37ae6c7", "AQAAAAEAACcQAAAAEG64M/W0nNBNO5rSfWUikyUVq4jTgitXgYlqxLHlcSesSh3odkEOx0aVmnGFqbXM9A==" });
        }
    }
}
