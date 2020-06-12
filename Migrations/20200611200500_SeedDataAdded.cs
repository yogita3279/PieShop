using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, null, "Fruit pies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 2, null, "Cheese cakes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 3, null, "Seasonal pies" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageUrl", "InStock", "IsPieOftheWeek", "LongDescription", "Name", "Price", "ShortDescription", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, "", 1, "https://yblobstorage.blob.core.windows.net/y-container/applePie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Apple Pie", 12.95m, "Our famous apple pies!", "https://yblobstorage.blob.core.windows.net/y-container/applePie.jpg" },
                    { 4, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Cherry Pie", 15.95m, "A summer classic!", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg" },
                    { 7, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", false, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Peach Pie", 15.95m, "Sweet as peach", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg" },
                    { 9, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Rhubarb Pie", 15.95m, "My God, so sweet!", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg" },
                    { 10, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Pie", 15.95m, "Our delicious strawberry pie!", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg" },
                    { 2, "", 2, "https://yblobstorage.blob.core.windows.net/y-container/blueBerryCheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Blueberry Cheese Cake", 18.95m, "You'll love it!", "https://yblobstorage.blob.core.windows.net/y-container/blueBerryCheesecake.jpg" },
                    { 3, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Cheese Cake", 18.95m, "Plain cheese cake. Plain pleasure.", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" },
                    { 11, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", false, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Cheese Cake", 18.95m, "You'll love it!", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg" },
                    { 5, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Christmas Apple Pie", 13.95m, "Happy holidays with this pie!", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg" },
                    { 6, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Cranberry Pie", 17.95m, "A Christmas favorite", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg" },
                    { 8, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Pumpkin Pie", 12.95m, "Our Halloween favorite", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
