namespace SQLiteEF_LowPower.Models
{
    public class DesignSchematicModel
    {
        // Unique identifier 
        public Int32 Id { get; set; }

        public required string BlockDiagram { get; set; }
        public string CircuitSchematics { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DesignSchematicModel(string circuitSchematics)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            CircuitSchematics = circuitSchematics;
        }

        public string PowerSupplyCircuits { get; set; }
    }
}
