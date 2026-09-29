using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoonquakeExplorer.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedSeismicStations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SeismicStations",
                columns: new[] { "Id", "IsActive", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), true, -3.0097999999999998, -23.424900000000001, "Apollo 12" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), true, -3.64419, -17.477679999999999, "Apollo 14" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), true, 26.134060000000002, 3.6299100000000002, "Apollo 15" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), true, -8.9758999999999993, 15.4986, "Apollo 16" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SeismicStations",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "SeismicStations",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "SeismicStations",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "SeismicStations",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));
        }
    }
}
