using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoonquakeExplorer.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFullMoonquakeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "DepthKilometers",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "EpicenterLatitude",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "EpicenterLongitude",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Magnitude",
                table: "Moonquakes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OccurredAt",
                table: "Moonquakes",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<double>(
                name: "AmplitudeApollo11_12",
                table: "Moonquakes",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AmplitudeApollo14",
                table: "Moonquakes",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AmplitudeApollo15",
                table: "Moonquakes",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AmplitudeApollo16",
                table: "Moonquakes",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo12Lpx",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo12Lpy",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo12Lpz",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo14Lpx",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo14Lpy",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo14Lpz",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo14Spz",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo15Lpx",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo15Lpy",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo15Lpz",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo15Spz",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo16Lpx",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo16Lpy",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo16Lpz",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Apollo16Spz",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClusterNumber",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "Moonquakes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataQualityApollo11_12",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataQualityApollo14",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataQualityApollo15",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataQualityApollo16",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EventType",
                table: "Moonquakes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "Moonquakes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JulianDay",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OriginalClusterNumber",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OriginalEventType",
                table: "Moonquakes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlotAvailabilityApollo11_12",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlotAvailabilityApollo14",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlotAvailabilityApollo15",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlotAvailabilityApollo16",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SignalStartTime",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SignalStartedAt",
                table: "Moonquakes",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SignalStopTime",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SignalStoppedAt",
                table: "Moonquakes",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Traces",
                table: "Moonquakes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Moonquakes",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmplitudeApollo11_12",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "AmplitudeApollo14",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "AmplitudeApollo15",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "AmplitudeApollo16",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo12Lpx",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo12Lpy",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo12Lpz",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo14Lpx",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo14Lpy",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo14Lpz",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo14Spz",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo15Lpx",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo15Lpy",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo15Lpz",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo15Spz",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo16Lpx",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo16Lpy",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo16Lpz",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Apollo16Spz",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "ClusterNumber",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Comments",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "DataQualityApollo11_12",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "DataQualityApollo14",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "DataQualityApollo15",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "DataQualityApollo16",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "EventType",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "JulianDay",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "OriginalClusterNumber",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "OriginalEventType",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "PlotAvailabilityApollo11_12",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "PlotAvailabilityApollo14",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "PlotAvailabilityApollo15",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "PlotAvailabilityApollo16",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "SignalStartTime",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "SignalStartedAt",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "SignalStopTime",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "SignalStoppedAt",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Traces",
                table: "Moonquakes");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Moonquakes");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "OccurredAt",
                table: "Moonquakes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Moonquakes",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "DepthKilometers",
                table: "Moonquakes",
                type: "double precision",
                precision: 10,
                scale: 3,
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "EpicenterLatitude",
                table: "Moonquakes",
                type: "double precision",
                precision: 10,
                scale: 6,
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "EpicenterLongitude",
                table: "Moonquakes",
                type: "double precision",
                precision: 10,
                scale: 6,
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Magnitude",
                table: "Moonquakes",
                type: "double precision",
                precision: 10,
                scale: 3,
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
