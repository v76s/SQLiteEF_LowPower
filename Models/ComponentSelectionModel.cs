namespace SQLiteEF_LowPower.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class ComponentSelectionModel(string lowPowerComponents)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        // Unique identifier 
        public Int32 Id { get; set; }

        public ComponentSelectionModel(string lowPowerComponents, string connectorsInterfaces) : this(lowPowerComponents)
        {
            ConnectorsInterfaces = connectorsInterfaces;
        }

        public string LowPowerComponents { get; set; } = lowPowerComponents;

        public string ConnectorsInterfaces { get; set; }
    }
}
