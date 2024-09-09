using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebAPI.NET6.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailToContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contacts");
        }
    }
}
