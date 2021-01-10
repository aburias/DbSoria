using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DbSoria.Data.Migrations
{
    public partial class AddedCategoryDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BannerId",
                table: "ProductCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_BannerId",
                table: "ProductCategories",
                column: "BannerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategories_Files_BannerId",
                table: "ProductCategories",
                column: "BannerId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategories_Files_BannerId",
                table: "ProductCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductCategories_BannerId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "BannerId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ProductCategories");
        }
    }
}
