using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marina.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCustomerSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leases_Customer_CustomerId",
                table: "Leases");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Leases",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Leases_CustomerId",
                table: "Leases",
                newName: "IX_Leases_CustomerID");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "Leases",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1_id", 0, "cf10f34b-16c6-41a9-9251-8dee5f117e18", "IdentityUser", "john.doe@example.com", true, false, null, "JOHN.DOE@EXAMPLE.COM", "JOHN.DOE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMwNYnJc214ESi3B9hxvqdWa7+rj2kz+AKvs4co+lYUhHz6ldcWT/jjaGR7ZkmTpnA==", null, false, "d6148509-7ebb-4ed8-95f6-8f1c04b315c8", false, "john.doe@example.com" },
                    { "user2_id", 0, "768a0f30-ab21-478e-aeee-118f424b064a", "IdentityUser", "sara.williams@example.com", true, false, null, "SARA.WILLIAMS@EXAMPLE.COM", "SARA.WILLIAMS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEB7aQQtV+rvIkw4P+uFwALcMYPdhtyL09au9Zth0IZcdT9et5Y6E+0aByO/u/nGdmw==", null, false, "a555672f-0da7-4b89-bc7e-5d5b29804531", false, "sara.williams@example.com" },
                    { "user3_id", 0, "353a061b-7e73-424b-9c71-f73615271df8", "IdentityUser", "ken.wong@example.com", true, false, null, "KEN.WONG@EXAMPLE.COM", "KEN.WONG@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPpd4Upb7UjG4ju/0YgJAchOQvc/ATNFsnYHcZkuRCQpw70gDKqUktZ0FkFEjVdJ7w==", null, false, "5cb95729-f3c3-43a2-82ef-c39e77a2b203", false, "ken.wong@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Leases",
                keyColumn: "ID",
                keyValue: 1,
                column: "CustomerID",
                value: "user1_id");

            migrationBuilder.UpdateData(
                table: "Leases",
                keyColumn: "ID",
                keyValue: 2,
                column: "CustomerID",
                value: "user2_id");

            migrationBuilder.UpdateData(
                table: "Leases",
                keyColumn: "ID",
                keyValue: 3,
                column: "CustomerID",
                value: "user3_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Leases_AspNetUsers_CustomerID",
                table: "Leases",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leases_AspNetUsers_CustomerID",
                table: "Leases");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1_id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2_id");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3_id");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Leases",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Leases_CustomerID",
                table: "Leases",
                newName: "IX_Leases_CustomerId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Leases",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "City", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Phoenix", "John", "Doe", "265-555-1212" },
                    { 2, "Calgary", "Sara", "Williams", "403-555-9585" },
                    { 3, "Kansas City", "Ken", "Wong", "802-555-3214" }
                });

            migrationBuilder.UpdateData(
                table: "Leases",
                keyColumn: "ID",
                keyValue: 1,
                column: "CustomerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Leases",
                keyColumn: "ID",
                keyValue: 2,
                column: "CustomerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Leases",
                keyColumn: "ID",
                keyValue: 3,
                column: "CustomerId",
                value: 3);

            migrationBuilder.AddForeignKey(
                name: "FK_Leases_Customer_CustomerId",
                table: "Leases",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
