namespace SQLiteEF_LowPower.Models
{
    public class PcbLayoutModel
    {
        // Unique identifier 
        public Int32 Id { get; set; }
        public string ComponentPlacement { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public PcbLayoutModel(string componentPlacement, string isolationStrategy, string powerOptimization)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            ComponentPlacement = componentPlacement;
            IsolationStrategy = isolationStrategy;
            PowerOptimization = powerOptimization;
        }

        public string PowerSignalRouting { get; set; }
        public string IsolationStrategy { get; set; }
        public string PowerOptimization { get; set; }
    }
}
