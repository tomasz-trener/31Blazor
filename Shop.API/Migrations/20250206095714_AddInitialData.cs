using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 712.02198175900708, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Wooden Chair" },
                    { 2, "5", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 108.33194080895369, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Metal Car" },
                    { 3, "2", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 450.51247725100842, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Wooden Fish" },
                    { 4, "7", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 483.65832712857906, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Concrete Bacon" },
                    { 5, "6", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 105.67317661301847, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Rubber Keyboard" },
                    { 6, "6", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 219.86036763380298, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Cotton Computer" },
                    { 7, "0", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 887.11072524502435, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Cotton Keyboard" },
                    { 8, "1", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 407.31691880306084, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Steel Gloves" },
                    { 9, "9", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 183.82778770002901, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Rubber Bike" },
                    { 10, "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 469.50192925403917, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Soft Gloves" },
                    { 11, "6", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 820.76055319083878, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Rubber Computer" },
                    { 12, "1", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 573.0781596941307, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Fresh Car" },
                    { 13, "9", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 233.44095520090357, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Wooden Soap" },
                    { 14, "0", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 682.18336528967291, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Steel Pizza" },
                    { 15, "4", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 366.26114951924478, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Frozen Pants" },
                    { 16, "2", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 948.07432503768916, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Fresh Bike" },
                    { 17, "9", "The Football Is Good For Training And Recreational Purposes", 941.35902986040298, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awesome Fresh Sausages" },
                    { 18, "8", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 358.18816927689511, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Soft Fish" },
                    { 19, "8", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 530.97037143538262, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Granite Cheese" },
                    { 20, "3", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 995.99367572180631, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Granite Towels" },
                    { 21, "5", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 865.87467934883887, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Frozen Mouse" },
                    { 22, "5", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 616.28500518355759, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Frozen Towels" },
                    { 23, "4", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 730.40153903625981, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Refined Frozen Shoes" },
                    { 24, "8", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 955.83694629642969, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awesome Cotton Gloves" },
                    { 25, "4", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 722.63245574507516, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Rubber Bike" },
                    { 26, "8", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 180.15533711395943, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade Metal Towels" },
                    { 27, "8", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 208.20247592274214, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Cotton Salad" },
                    { 28, "8", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 100.68470620814931, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Steel Chicken" },
                    { 29, "7", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 601.11759625892967, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Concrete Table" },
                    { 30, "8", "The Football Is Good For Training And Recreational Purposes", 98.71499023899203, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Wooden Soap" },
                    { 31, "6", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3.8473698542673929, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Frozen Pizza" },
                    { 32, "5", "The Football Is Good For Training And Recreational Purposes", 702.7774551775201, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Fresh Tuna" },
                    { 33, "5", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 745.46564987649469, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sleek Steel Sausages" },
                    { 34, "5", "The Football Is Good For Training And Recreational Purposes", 977.75319658534283, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Concrete Towels" },
                    { 35, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 228.99487219331547, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Wooden Ball" },
                    { 36, "6", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 944.72583342936161, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Steel Computer" },
                    { 37, "9", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 434.29935833453169, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Wooden Pizza" },
                    { 38, "3", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 173.85951581078558, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbranded Plastic Towels" },
                    { 39, "4", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 332.26655719953897, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Small Fresh Tuna" },
                    { 40, "1", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 536.83817275559443, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted Fresh Soap" },
                    { 41, "7", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 798.0160448839963, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rustic Fresh Bacon" },
                    { 42, "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 360.89255706867789, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Practical Frozen Pizza" },
                    { 43, "7", "The Football Is Good For Training And Recreational Purposes", 6.3028863595346385, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Intelligent Cotton Towels" },
                    { 44, "6", "The Football Is Good For Training And Recreational Purposes", 475.49989463645028, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Metal Shoes" },
                    { 45, "7", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 921.19773658420775, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licensed Concrete Sausages" },
                    { 46, "8", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 932.54995290122463, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Generic Metal Sausages" },
                    { 47, "7", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 890.0015941467143, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ergonomic Soft Hat" },
                    { 48, "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 802.97858016750706, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Incredible Metal Table" },
                    { 49, "0", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 36.07306743509745, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasty Wooden Hat" },
                    { 50, "7", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 828.79833626691175, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorgeous Plastic Pants" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
