namespace SQLiteEF_LowPower.Models
{
    public class PcbPrototypeFabricationModel
    {
        public PcbPrototypeFabricationModel(string designFiles)
        {
            DesignFiles = designFiles;
        }

        // Unique identifier 
        public Int32 Id { get; set; }
        public string DesignFiles { get; set; }
    }
}
