using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_App_ASP_and_React.Migrations
{
    /// <inheritdoc />
    public partial class ChangePublishingDateColumnType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Publishing_House",
                table: "Books",
                newName: "Publishing_house");

            migrationBuilder.RenameColumn(
                name: "Publishing_Date",
                table: "Books",
                newName: "Publishing_date");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Publishing_date",
                table: "Books",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Publishing_house",
                table: "Books",
                newName: "Publishing_House");

            migrationBuilder.RenameColumn(
                name: "Publishing_date",
                table: "Books",
                newName: "Publishing_Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Publishing_Date",
                table: "Books",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
