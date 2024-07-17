using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marina.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "City", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Phoenix", "John", "Doe", "265-555-1212" },
                    { 2, "Calgary", "Sara", "Williams", "403-555-9585" },
                    { 3, "Kansas City", "Ken", "Wong", "802-555-3214" }
                });

            migrationBuilder.InsertData(
                table: "Docks",
                columns: new[] { "ID", "ElectricalService", "Name", "WaterService" },
                values: new object[,]
                {
                    { 1, true, "Dock A", true },
                    { 2, false, "Dock B", true },
                    { 3, true, "Dock C", false }
                });

            migrationBuilder.InsertData(
                table: "Slips",
                columns: new[] { "ID", "DockId", "Length", "Width" },
                values: new object[,]
                {
                    { 1, 1, 16, 8 },
                    { 2, 1, 16, 8 },
                    { 3, 1, 16, 8 },
                    { 4, 1, 16, 8 },
                    { 5, 1, 16, 8 },
                    { 6, 1, 16, 8 },
                    { 7, 1, 20, 8 },
                    { 8, 1, 20, 8 },
                    { 9, 1, 20, 8 },
                    { 10, 1, 20, 8 },
                    { 11, 1, 20, 8 },
                    { 12, 1, 22, 8 },
                    { 13, 1, 22, 8 },
                    { 14, 1, 22, 8 },
                    { 15, 1, 22, 8 },
                    { 16, 1, 24, 8 },
                    { 17, 1, 24, 8 },
                    { 18, 1, 24, 8 },
                    { 19, 1, 24, 8 },
                    { 20, 1, 26, 8 },
                    { 21, 1, 26, 8 },
                    { 22, 1, 26, 8 },
                    { 23, 1, 26, 8 },
                    { 24, 1, 26, 8 },
                    { 25, 1, 26, 8 },
                    { 26, 1, 28, 8 },
                    { 27, 1, 28, 8 },
                    { 28, 1, 28, 8 },
                    { 29, 1, 28, 8 },
                    { 30, 1, 28, 8 },
                    { 31, 2, 18, 8 },
                    { 32, 2, 18, 8 },
                    { 33, 2, 18, 8 },
                    { 34, 2, 18, 8 },
                    { 35, 2, 18, 8 },
                    { 36, 2, 18, 8 },
                    { 37, 2, 20, 8 },
                    { 38, 2, 20, 8 },
                    { 39, 2, 20, 8 },
                    { 40, 2, 22, 8 },
                    { 41, 2, 22, 8 },
                    { 42, 2, 22, 8 },
                    { 43, 2, 24, 8 },
                    { 44, 2, 24, 8 },
                    { 45, 2, 24, 8 },
                    { 46, 2, 24, 8 },
                    { 47, 2, 28, 8 },
                    { 48, 2, 28, 8 },
                    { 49, 2, 28, 8 },
                    { 50, 2, 30, 8 },
                    { 51, 2, 30, 8 },
                    { 52, 2, 30, 8 },
                    { 53, 2, 30, 8 },
                    { 54, 2, 30, 8 },
                    { 55, 2, 32, 8 },
                    { 56, 2, 32, 8 },
                    { 57, 2, 32, 8 },
                    { 58, 2, 32, 8 },
                    { 59, 2, 32, 8 },
                    { 60, 2, 32, 8 },
                    { 61, 3, 22, 10 },
                    { 62, 3, 22, 10 },
                    { 63, 3, 22, 10 },
                    { 64, 3, 22, 10 },
                    { 65, 3, 22, 10 },
                    { 66, 3, 22, 10 },
                    { 67, 3, 22, 10 },
                    { 68, 3, 22, 10 },
                    { 69, 3, 22, 10 },
                    { 70, 3, 24, 10 },
                    { 71, 3, 24, 10 },
                    { 72, 3, 24, 10 },
                    { 73, 3, 24, 10 },
                    { 74, 3, 24, 10 },
                    { 75, 3, 24, 10 },
                    { 76, 3, 24, 10 },
                    { 77, 3, 24, 10 },
                    { 78, 3, 28, 12 },
                    { 79, 3, 28, 12 },
                    { 80, 3, 28, 12 },
                    { 81, 3, 28, 12 },
                    { 82, 3, 28, 12 },
                    { 83, 3, 28, 12 },
                    { 84, 3, 28, 12 },
                    { 85, 3, 28, 12 },
                    { 86, 3, 32, 12 },
                    { 87, 3, 32, 12 },
                    { 88, 3, 32, 12 },
                    { 89, 3, 32, 12 },
                    { 90, 3, 32, 12 }
                });

            migrationBuilder.InsertData(
                table: "Leases",
                columns: new[] { "ID", "CustomerId", "SlipId" },
                values: new object[,]
                {
                    { 1, 1, 20 },
                    { 2, 2, 42 },
                    { 3, 3, 88 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Leases",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Leases",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Leases",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Slips",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Docks",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Docks",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Docks",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
