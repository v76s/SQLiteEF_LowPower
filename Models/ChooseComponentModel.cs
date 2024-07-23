namespace SQLiteEF_LowPower.Models
{
    public class ChooseComponentsModel
    {
        // Unique identifier 
        public Int32 Id { get; set; } 
        public string Stm32Model { get; set; }

        public ChooseComponentsModel(string stm32Model, string communicationModules)
        {
            Stm32Model = stm32Model;
            CommunicationModules = communicationModules;
        }

        public string[] Sensors { get; set; }

        public ChooseComponentsModel(string[] sensors) => Sensors = sensors;

        private string powerManagementComponents;

        public string GetPowerManagementComponents()
        {
            return powerManagementComponents;
        }

        public void SetPowerManagementComponents(string value)
        {
            powerManagementComponents = value;
        }

        public string CommunicationModules { get; set; }
        public string PowerManagementComponents { get; internal set; }
    }
}
