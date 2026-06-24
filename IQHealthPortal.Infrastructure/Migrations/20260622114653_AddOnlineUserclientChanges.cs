using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IQHealthPortal.Infrastructure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOnlineUserclientChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            
            migrationBuilder.CreateTable(
    name: "OnlineUsers",
    columns: table => new
    {
        Id = table.Column<string>(
            type: "nvarchar(450)",
            nullable: false
        ),
        UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
        Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
        // كملي باقي الأعمدة عندك
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_OnlineUsers", x => x.Id);
    });
            migrationBuilder.AddColumn<string>(
                name: "NotHashedPassword",
                table: "OnlineUserClients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "Status",
                table: "OnlineUserClients",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V_Type",
                table: "OnlineUserClients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotHashedPassword",
                table: "OnlineUserClients");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "OnlineUserClients");

            migrationBuilder.DropColumn(
                name: "V_Type",
                table: "OnlineUserClients");

            migrationBuilder.AddColumn<bool>(
                name: "Add",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cancel",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Edit",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Export",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Import",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Print",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SpacialCase",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Submit",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Unsubmit",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "View",
                table: "Privileges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "OnlineUsers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
