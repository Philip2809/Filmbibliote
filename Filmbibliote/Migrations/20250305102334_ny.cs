using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Filmbibliote.Migrations
{
    /// <inheritdoc />
    public partial class ny : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Filmer",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Filmer_UserID",
                table: "Filmer",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmer_AspNetUsers_UserID",
                table: "Filmer",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmer_AspNetUsers_UserID",
                table: "Filmer");

            migrationBuilder.DropIndex(
                name: "IX_Filmer_UserID",
                table: "Filmer");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Filmer");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
