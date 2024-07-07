using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class AddArtistType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArtistType",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "NA");

            migrationBuilder.Sql("Update Artists Set ArtistType='NA' Where ArtistType is null");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtistType",
                table: "Artists");
        }
    }
}
