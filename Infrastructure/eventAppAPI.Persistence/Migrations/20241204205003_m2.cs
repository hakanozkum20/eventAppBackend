using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eventAppAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Events",
                newName: "BrideName");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Events",
                type: "text",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "BrideSurname",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GroomName",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GroomSurname",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "eventTime",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrideSurname",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "GroomName",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "GroomSurname",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "eventTime",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "BrideName",
                table: "Events",
                newName: "Name");

            migrationBuilder.AlterColumn<long>(
                name: "Phone",
                table: "Events",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
