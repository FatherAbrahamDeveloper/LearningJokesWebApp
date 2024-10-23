using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningJokesWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Joke");
        }
    }
}
