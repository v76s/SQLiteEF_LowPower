using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQLiteEF_LowPower.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChooseComponent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Stm32Model = table.Column<string>(type: "TEXT", nullable: false),
                    Sensors = table.Column<string>(type: "TEXT", nullable: false),
                    CommunicationModules = table.Column<string>(type: "TEXT", nullable: false),
                    PowerManagementComponents = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChooseComponent", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChooseComponent");
        }
    }
}
