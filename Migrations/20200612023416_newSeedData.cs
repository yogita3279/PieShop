using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class newSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/applePie.jpg", "https://yblobstorage.blob.core.windows.net/y-container/applePie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/blueBerryCheesecake.jpg", "https://yblobstorage.blob.core.windows.net/y-container/blueBerryCheesecake.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/cheeseCake.jpg", "https://yblobstorage.blob.core.windows.net/y-container/cheeseCake.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/cherryPie.jpg", "https://yblobstorage.blob.core.windows.net/y-container/cherryPie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/christmasapplePie.jpg", "https://yblobstorage.blob.core.windows.net/y-container/christmasapplePie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/cranberryPie.jpg", "https://yblobstorage.blob.core.windows.net/y-container/cranberryPie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/peachPie.jpg", "https://yblobstorage.blob.core.windows.net/y-container/peachPie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/pumpkinPie.jpg", "https://yblobstorage.blob.core.windows.net/y-container/pumpkinPie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/rhubarbPie.jpg", "https://yblobstorage.blob.core.windows.net/y-container/rhubarbPie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/strawberryPie.jpg", "https://yblobstorage.blob.core.windows.net/y-container/strawberryPie.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://yblobstorage.blob.core.windows.net/y-container/strawberryCheeseCake.jpg", "https://yblobstorage.blob.core.windows.net/y-container/strawberryCheeseCake.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11,
                columns: new[] { "ImageUrl", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg" });
        }
    }
}
