namespace SQLiteEF_LowPower.Models
{
    public class PowerManagementDesignModel
    {
        // Unique identifier 
        public Int32 Id { get; set; }
        public required string PowerSavingModes { get; set; }
        public string PowerSwitchingCircuits { get; set; }

        public PowerManagementDesignModel(string powerSwitchingCircuits)
        {
            PowerSwitchingCircuits = powerSwitchingCircuits;
        }
    }
}
