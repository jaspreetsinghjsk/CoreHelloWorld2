using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreHelloWorld2.Migrations
{
    public partial class bookimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookImage_BookImageId",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookImage",
                table: "BookImage");

            migrationBuilder.AddColumn<string>(
                name: "ImageContentType",
                table: "BookImage",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookImages",
                table: "BookImage",
                column: "BookImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookImages_BookImageId",
                table: "Book",
                column: "BookImageId",
                principalTable: "BookImage",
                principalColumn: "BookImageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "BookImage",
                newName: "BookImages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookImages_BookImageId",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookImages",
                table: "BookImages");

            migrationBuilder.DropColumn(
                name: "ImageContentType",
                table: "BookImages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookImage",
                table: "BookImages",
                column: "BookImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookImage_BookImageId",
                table: "Book",
                column: "BookImageId",
                principalTable: "BookImages",
                principalColumn: "BookImageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "BookImages",
                newName: "BookImage");
        }
    }
}
