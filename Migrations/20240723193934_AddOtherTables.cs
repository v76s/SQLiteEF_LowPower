using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SQLiteEF_LowPower.Migrations
{
    /// <inheritdoc />
    public partial class AddOtherTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComponentSelection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LowPowerComponents = table.Column<string>(type: "TEXT", nullable: false),
                    ConnectorsInterfaces = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentSelection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefineRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FunctionalRequirements = table.Column<string>(type: "TEXT", nullable: false),
                    PowerRequirements = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefineRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesignSchematic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlockDiagram = table.Column<string>(type: "TEXT", nullable: false),
                    CircuitSchematics = table.Column<string>(type: "TEXT", nullable: false),
                    PowerSupplyCircuits = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignSchematic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documentation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DesignDocumentation = table.Column<string>(type: "TEXT", nullable: false),
                    FirmwareDocumentation = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinalPrototypeFabrication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FabricationName = table.Column<string>(type: "TEXT", nullable: false),
                    UpdatedDesignFiles = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalPrototypeFabrication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirmwareDevelopment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BasicFunctionalityCode = table.Column<string>(type: "TEXT", nullable: false),
                    CommunicationProtocols = table.Column<string>(type: "TEXT", nullable: false),
                    PowerManagementFeatures = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmwareDevelopment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirmwareFinalization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FinalFirmware = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmwareFinalization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IterateDesign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TestingResults = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IterateDesign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PcbLayout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ComponentPlacement = table.Column<string>(type: "TEXT", nullable: false),
                    PowerSignalRouting = table.Column<string>(type: "TEXT", nullable: false),
                    IsolationStrategy = table.Column<string>(type: "TEXT", nullable: false),
                    PowerOptimization = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcbLayout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PcbPrototypeFabrication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DesignFiles = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcbPrototypeFabrication", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerManagementDesign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PowerSavingModes = table.Column<string>(type: "TEXT", nullable: false),
                    PowerSwitchingCircuits = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerManagementDesign", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SafetyRedundancyDesign",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SafetyFeatures = table.Column<string>(type: "TEXT", nullable: false),
                    RedundancyDesign = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafetyRedundancyDesign", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentSelection");

            migrationBuilder.DropTable(
                name: "DefineRequirements");

            migrationBuilder.DropTable(
                name: "DesignSchematic");

            migrationBuilder.DropTable(
                name: "Documentation");

            migrationBuilder.DropTable(
                name: "FinalPrototypeFabrication");

            migrationBuilder.DropTable(
                name: "FirmwareDevelopment");

            migrationBuilder.DropTable(
                name: "FirmwareFinalization");

            migrationBuilder.DropTable(
                name: "IterateDesign");

            migrationBuilder.DropTable(
                name: "PcbLayout");

            migrationBuilder.DropTable(
                name: "PcbPrototypeFabrication");

            migrationBuilder.DropTable(
                name: "PowerManagementDesign");

            migrationBuilder.DropTable(
                name: "SafetyRedundancyDesign");
        }
    }
}
