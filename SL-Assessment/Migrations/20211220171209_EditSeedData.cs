using Microsoft.EntityFrameworkCore.Migrations;

namespace SL_Assessment.Migrations
{
    public partial class EditSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrl",
                value: "~/videos/SampleVideo_360x240_1mb.mp4");

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrl",
                value: "~/videos/SampleVideo_360x240_1mb.mp4");

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrl",
                value: "~/videos/SampleVideo_360x240_1mb.mp4");

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrl",
                value: "~/videos/SampleVideo_360x240_1mb.mp4");

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrl",
                value: "~/videos/SampleVideo_360x240_1mb.mp4");

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrl",
                value: "~/videos/SampleVideo_360x240_1mb.mp4");

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrl",
                value: "~/videos/SampleVideo_360x240_1mb.mp4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 1,
                column: "VideoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 2,
                column: "VideoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 3,
                column: "VideoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 4,
                column: "VideoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 5,
                column: "VideoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 6,
                column: "VideoUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 7,
                column: "VideoUrl",
                value: null);
        }
    }
}
