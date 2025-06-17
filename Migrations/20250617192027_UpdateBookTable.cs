using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_App_ASP_and_React.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Publishing_date",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Publishing_house",
                table: "Books",
                newName: "Image_path");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Books",
                newName: "File_pdf_path");

            migrationBuilder.AddColumn<string>(
                name: "Audio_path",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Average_rating",
                table: "Books",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Number_review",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Page_count",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Audio_path",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Average_rating",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Number_review",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Page_count",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Image_path",
                table: "Books",
                newName: "Publishing_house");

            migrationBuilder.RenameColumn(
                name: "File_pdf_path",
                table: "Books",
                newName: "Image");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Publishing_date",
                table: "Books",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
