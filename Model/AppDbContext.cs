using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Model
{
    public class AppDbContext:DbContext
    {
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //instance of option to execute
        {}

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }




        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //seed categories
        //    modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies" });
        //    modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Cheese cakes" });
        //    modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal pies" });

        //    //seed pies

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 1,
        //        Name = "Apple Pie",
        //        Price = 12.95M,
        //        ShortDescription = "Our famous apple pies!",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 1,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/applePie.jpg",
        //        InStock = true,
        //        IsPieOftheWeek = true,
        //        ThumbnailUrl = "https://yblobstorage.blob.core.windows.net/y-container/applePie.jpg",
        //        AllergyInformation = ""
        //    });

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 2,
        //        Name = "Blueberry Cheese Cake",
        //        Price = 18.95M,
        //        ShortDescription = "You'll love it!",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 2,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/blueBerryCheesecake.jpg",
        //        InStock = true,
        //        IsPieOftheWeek = false,
        //        ThumbnailUrl =
        //            "https://yblobstorage.blob.core.windows.net/y-container/blueBerryCheesecake.jpg",
        //        AllergyInformation = ""
        //    });

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 3,
        //        Name = "Cheese Cake",
        //        Price = 18.95M,
        //        ShortDescription = "Plain cheese cake. Plain pleasure.",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 2,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/cheeseCake.jpg",
        //        InStock = true,
        //        IsPieOftheWeek = false,
        //        ThumbnailUrl = "https://yblobstorage.blob.core.windows.net/y-container/cheeseCake.jpg",
        //        AllergyInformation = ""
        //    });

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 4,
        //        Name = "Cherry Pie",
        //        Price = 15.95M,
        //        ShortDescription = "A summer classic!",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 1,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/cherryPie.jpg",
        //        InStock = true,
        //        IsPieOftheWeek = false,
        //        ThumbnailUrl = "https://yblobstorage.blob.core.windows.net/y-container/cherryPie.jpg",
        //        AllergyInformation = ""
        //    });

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 5,
        //        Name = "Christmas Apple Pie",
        //        Price = 13.95M,
        //        ShortDescription = "Happy holidays with this pie!",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 3,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/christmasapplePie.jpg",
        //        InStock = true,
        //        IsPieOftheWeek = false,
        //        ThumbnailUrl =
        //            "https://yblobstorage.blob.core.windows.net/y-container/christmasapplePie.jpg",
        //        AllergyInformation = ""
        //    });

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 6,
        //        Name = "Cranberry Pie",
        //        Price = 17.95M,
        //        ShortDescription = "A Christmas favorite",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 3,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/cranberryPie.jpg",
        //        InStock = true,
        //        IsPieOftheWeek = false,
        //        ThumbnailUrl = "https://yblobstorage.blob.core.windows.net/y-container/cranberryPie.jpg",
        //        AllergyInformation = ""
        //    });

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 7,
        //        Name = "Peach Pie",
        //        Price = 15.95M,
        //        ShortDescription = "Sweet as peach",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 1,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/peachPie.jpg",
        //        InStock = false,
        //        IsPieOftheWeek = false,
        //        ThumbnailUrl = "https://yblobstorage.blob.core.windows.net/y-container/peachPie.jpg",
        //        AllergyInformation = ""
        //    });

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 8,
        //        Name = "Pumpkin Pie",
        //        Price = 12.95M,
        //        ShortDescription = "Our Halloween favorite",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 3,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/pumpkinPie.jpg",
        //        InStock = true,
        //        IsPieOftheWeek = true,
        //        ThumbnailUrl = "https://yblobstorage.blob.core.windows.net/y-container/pumpkinPie.jpg",
        //        AllergyInformation = ""
        //    });


        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 9,
        //        Name = "Rhubarb Pie",
        //        Price = 15.95M,
        //        ShortDescription = "My God, so sweet!",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 1,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/rhubarbPie.jpg",
        //        InStock = true,
        //        IsPieOftheWeek = true,
        //        ThumbnailUrl = "https://yblobstorage.blob.core.windows.net/y-container/rhubarbPie.jpg",
        //        AllergyInformation = ""
        //    });

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 10,
        //        Name = "Strawberry Pie",
        //        Price = 15.95M,
        //        ShortDescription = "Our delicious strawberry pie!",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 1,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/strawberryPie.jpg",
        //        InStock = true,
        //        IsPieOftheWeek = false,
        //        ThumbnailUrl = "https://yblobstorage.blob.core.windows.net/y-container/strawberryPie.jpg",
        //        AllergyInformation = ""
        //    });

        //    modelBuilder.Entity<Pie>().HasData(new Pie
        //    {
        //        PieId = 11,
        //        Name = "Strawberry Cheese Cake",
        //        Price = 18.95M,
        //        ShortDescription = "You'll love it!",
        //        LongDescription =
        //            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
        //        CategoryId = 2,
        //        ImageUrl = "https://yblobstorage.blob.core.windows.net/y-container/strawberryCheeseCake.jpg",
        //        InStock = false,
        //        IsPieOftheWeek = false,
        //        ThumbnailUrl =
        //            "https://yblobstorage.blob.core.windows.net/y-container/strawberryCheeseCake.jpg",
        //        AllergyInformation = ""
        //    });
        //}

    }
}
