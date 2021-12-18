using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingAPI.Migrations
{
    public partial class RelationbetweenAccountandOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_OwnerId",
                table: "Accounts",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Owners_OwnerId",
                table: "Accounts",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Owners_OwnerId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_OwnerId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Accounts");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Accounts",
                type: "varchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "");
        }
    }
}
