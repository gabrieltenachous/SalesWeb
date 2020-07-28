using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWeb.Migrations
{
    public partial class OtherEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Salesre_Seller_SellerId",
                table: "Salesre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salesre",
                table: "Salesre");

            migrationBuilder.RenameTable(
                name: "Salesre",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_Salesre_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "Salesre");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "Salesre",
                newName: "IX_Salesre_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salesre",
                table: "Salesre",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Salesre_Seller_SellerId",
                table: "Salesre",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
