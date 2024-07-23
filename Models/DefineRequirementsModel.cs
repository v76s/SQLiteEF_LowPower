namespace SQLiteEF_LowPower.Models
{
    public class DefineRequirementsModel
    {
        // Unique identifier 
        public Int32 Id { get; set; }

        public string FunctionalRequirements { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DefineRequirementsModel(string functionalRequirements)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            FunctionalRequirements = functionalRequirements;
        }

        public string PowerRequirements { get; set; }
    }
}
