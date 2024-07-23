using Microsoft.EntityFrameworkCore;
using SQLiteEF_LowPower.Models;

namespace SQLiteEF_LowPower.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ChooseComponentsModel> ChooseComponent => Set<ChooseComponentsModel>();
        public DbSet<ComponentSelectionModel> ComponentSelection => Set<ComponentSelectionModel>();
        public DbSet<DefineRequirementsModel> DefineRequirements => Set<DefineRequirementsModel>();
        public DbSet<DesignSchematicModel> DesignSchematic => Set<DesignSchematicModel>();
        public DbSet<DocumentationModel> Documentation => Set<DocumentationModel>();
        public DbSet<FinalPrototypeFabricationModel> FinalPrototypeFabrication => Set<FinalPrototypeFabricationModel>();
        public DbSet<FirmwareDevelopmentModel> FirmwareDevelopment => Set<FirmwareDevelopmentModel>();
        public DbSet<FirmwareFinalizationModel> FirmwareFinalization => Set<FirmwareFinalizationModel>();
        public DbSet<IterateDesignModel> IterateDesign => Set<IterateDesignModel>();
        public DbSet<PcbLayoutModel> PcbLayout => Set<PcbLayoutModel>();
        public DbSet<PcbPrototypeFabricationModel> PcbPrototypeFabrication => Set<PcbPrototypeFabricationModel>();
        public DbSet<PowerManagementDesignModel> PowerManagementDesign => Set<PowerManagementDesignModel>();
        public DbSet<SafetyRedundancyDesignModel> SafetyRedundancyDesign => Set<SafetyRedundancyDesignModel>();
    }
}
