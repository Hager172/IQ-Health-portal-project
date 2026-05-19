using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IQHealthPortal.Infrastructure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addclientidToprivilagetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Privileges",
                type: "int",
                nullable: true
             );

            migrationBuilder.CreateIndex(
                name: "IX_Privileges_ClientId",
                table: "Privileges",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Privileges_OnlineClients_ClientId",
                table: "Privileges",
                column: "ClientId",
                principalTable: "OnlineClients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Privileges_OnlineClients_ClientId",
                table: "Privileges");

            migrationBuilder.DropIndex(
                name: "IX_Privileges_ClientId",
                table: "Privileges");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Privileges");
        }
    }
}
