namespace SQLiteEF_LowPower.Models
{
    public class FirmwareDevelopmentModel
    {
        // Unique identifier 
        public Int32 Id { get; set; }

        private string powerManagementFeatures;

        public required string BasicFunctionalityCode { get; set; }
        public string CommunicationProtocols { get; set; }

        public FirmwareDevelopmentModel(string communicationProtocols,
                                        string powerManagementFeatures)
        {
            CommunicationProtocols = communicationProtocols;
            PowerManagementFeatures = powerManagementFeatures;
        }

        public string PowerManagementFeatures { get => powerManagementFeatures; set => powerManagementFeatures = value; }
    }
}
