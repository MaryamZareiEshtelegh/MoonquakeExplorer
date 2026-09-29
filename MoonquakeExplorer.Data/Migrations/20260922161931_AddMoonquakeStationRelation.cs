using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoonquakeExplorer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMoonquakeStationRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Moonquakes_RecordingStationId",
                table: "Moonquakes",
                column: "RecordingStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moonquakes_SeismicStations_RecordingStationId",
                table: "Moonquakes",
                column: "RecordingStationId",
                principalTable: "SeismicStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moonquakes_SeismicStations_RecordingStationId",
                table: "Moonquakes");

            migrationBuilder.DropIndex(
                name: "IX_Moonquakes_RecordingStationId",
                table: "Moonquakes");
        }
    }
}
