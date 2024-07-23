namespace SQLiteEF_LowPower.Models
{

    public class FinalPrototypeFabricationModel
    {
        // Unique identifier 
        public Int32 Id { get; set; }
        public string FabricationName { get; set; }

        public string UpdatedDesignFiles { get; set; }  

        public FinalPrototypeFabricationModel(string updatedDesignFiles)
        {
            UpdatedDesignFiles = updatedDesignFiles;
        }
    }
}
