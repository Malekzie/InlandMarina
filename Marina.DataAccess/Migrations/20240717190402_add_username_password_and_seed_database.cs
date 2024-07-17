using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marina.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class add_username_password_and_seed_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slips_Docks_DockId",
                table: "Slips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Docks",
                table: "Docks");

            migrationBuilder.RenameTable(
                name: "Docks",
                newName: "Dock");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Customers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dock",
                table: "Dock",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Password", "Username" },
                values: new object[] { "Imasneekyboi", "JoeMama" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Password", "Username" },
                values: new object[] { "Itsyogurl", "SaraNookie" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Password", "Username" },
                values: new object[] { "ChickenRiceNoodles", "NothingKenGoWong" });

            migrationBuilder.AddForeignKey(
                name: "FK_Slips_Dock_DockId",
                table: "Slips",
                column: "DockId",
                principalTable: "Dock",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slips_Dock_DockId",
                table: "Slips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dock",
                table: "Dock");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Dock",
                newName: "Docks");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Docks",
                table: "Docks",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Slips_Docks_DockId",
                table: "Slips",
                column: "DockId",
                principalTable: "Docks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
