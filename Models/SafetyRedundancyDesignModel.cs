namespace SQLiteEF_LowPower.Models
{
    public class SafetyRedundancyDesignModel
    {
        


        // Unique identifier 
        public Int32 Id { get; set; }
        public required string SafetyFeatures { get; set; }
        public string RedundancyDesign { get; set; }

        public SafetyRedundancyDesignModel(string redundancyDesign)
        {
            RedundancyDesign = redundancyDesign;
        }
    }
}
