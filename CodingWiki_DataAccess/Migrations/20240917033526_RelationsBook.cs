using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RelationsBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "BookDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookDetail_BookId",
                table: "BookDetail",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookDetail_Books_BookId",
                table: "BookDetail",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookDetail_Books_BookId",
                table: "BookDetail");

            migrationBuilder.DropIndex(
                name: "IX_BookDetail_BookId",
                table: "BookDetail");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BookDetail");
        }
    }
}
