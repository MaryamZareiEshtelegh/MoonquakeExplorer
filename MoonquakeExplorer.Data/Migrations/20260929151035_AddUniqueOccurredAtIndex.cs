using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoonquakeExplorer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueOccurredAtIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Moonquakes_OccurredAt",
                table: "Moonquakes",
                column: "OccurredAt",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Moonquakes_OccurredAt",
                table: "Moonquakes");
        }
    }
}
