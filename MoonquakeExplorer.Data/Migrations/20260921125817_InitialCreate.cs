using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoonquakeExplorer.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moonquakes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Category = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Magnitude = table.Column<double>(type: "double precision", nullable: false),
                    DepthKilometers = table.Column<double>(type: "double precision", nullable: false),
                    EpicenterLatitude = table.Column<double>(type: "double precision", nullable: false),
                    EpicenterLongitude = table.Column<double>(type: "double precision", nullable: false),
                    OccurredAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    RecordingStationId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moonquakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeismicStations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeismicStations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moonquakes");

            migrationBuilder.DropTable(
                name: "SeismicStations");
        }
    }
}
