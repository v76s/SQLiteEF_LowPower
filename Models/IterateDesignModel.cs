namespace SQLiteEF_LowPower.Models
{
    public class IterateDesignModel
    {
        // Unique identifier 
        public Int32 Id { get; set; }

        private string testingResults;

        public IterateDesignModel(string testingResults)
        {
            TestingResults = testingResults;
        }

        public string TestingResults { get => testingResults; set => testingResults = value; }
    }
}
