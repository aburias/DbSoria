using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbSoria.Data.Migrations
{
    public partial class AddedCustomerDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StoreId",
                table: "Buyers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Buyers_StoreId",
                table: "Buyers",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buyers_Stores_StoreId",
                table: "Buyers",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buyers_Stores_StoreId",
                table: "Buyers");

            migrationBuilder.DropIndex(
                name: "IX_Buyers_StoreId",
                table: "Buyers");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Buyers");
        }
    }
}
