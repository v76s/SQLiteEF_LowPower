namespace SQLiteEF_LowPower.Models
{
    public class FirmwareFinalizationModel
    {
        // Unique identifier 
        public Int32 Id { get; set; }
        public required string FinalFirmware { get; set; }

        public FirmwareFinalizationModel(string finalFirmware)
        {
            FinalFirmware = finalFirmware;
        }

        public override bool Equals(object? obj)
        {
            return obj is FirmwareFinalizationModel model &&
                   FinalFirmware == model.FinalFirmware;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
