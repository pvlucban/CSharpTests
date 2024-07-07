using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class SetArtistTypeNotNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ArtistType",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "NA",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "NA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ArtistType",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "NA",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "NA");
        }
    }
}
