using Microsoft.EntityFrameworkCore.Migrations;

namespace SL_Assessment.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoBriefs",
                columns: new[] { "Id", "Description", "ImageUrl", "Title", "VideoUrl" },
                values: new object[,]
                {
                    { 1, "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.", "~/images/0001.png", "How to control your facial expressions", null },
                    { 2, "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.", "~/images/0008.png", "How to control your facial expressions", null },
                    { 3, "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.", "~/images/0002.png", "How to control your facial expressions", null },
                    { 4, "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.", "~/images/0007.png", "How to control your facial expressions", null },
                    { 5, "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.", "~/images/0008.png", "How to control your facial expressions", null },
                    { 6, "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.", "~/images/0001.png", "How to control your facial expressions", null },
                    { 7, "LFar far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.there live the blind texts.", "~/images/0002.png", "How to control your facial expressions", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VideoBriefs",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
