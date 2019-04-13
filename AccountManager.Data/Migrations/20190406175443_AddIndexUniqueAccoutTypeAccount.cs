using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountManager.Data.Migrations
{
    public partial class AddIndexUniqueAccoutTypeAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "AccountType",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Account",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AccountType_Codigo",
                table: "AccountType",
                column: "Codigo",
                unique: true,
                filter: "[Codigo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Account_Code",
                table: "Account",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AccountType_Codigo",
                table: "AccountType");

            migrationBuilder.DropIndex(
                name: "IX_Account_Code",
                table: "Account");

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "AccountType",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Account",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
