using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eventAppAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "eventTime",
                table: "Events",
                newName: "eventTimeStart");

            migrationBuilder.AddColumn<string>(
                name: "eventTimeFinish",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "eventTimeFinish",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "eventTimeStart",
                table: "Events",
                newName: "eventTime");
        }
    }
}
