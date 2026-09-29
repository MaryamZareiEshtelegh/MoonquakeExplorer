using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoonquakeExplorer.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMoonquakeStationRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moonquakes_SeismicStations_RecordingStationId",
                table: "Moonquakes");

            migrationBuilder.DropIndex(
                name: "IX_Moonquakes_RecordingStationId",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "RecordingStationId",
                table: "Moonquakes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RecordingStationId",
                table: "Moonquakes",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
