namespace SQLiteEF_LowPower.Models
{
    public class DocumentationModel
    {
        // Unique identifier 
        public Int32 Id { get; set; }

        public required string DesignDocumentation { get; set; }
        public string FirmwareDocumentation { get; set; }

        public DocumentationModel(string firmwareDocumentation)
        {
            FirmwareDocumentation = firmwareDocumentation;
        }
    }
}
