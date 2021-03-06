using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.MaintenanceMode.Client 
{
    /// <summary>
    /// MaintenanceMode client settings.
    /// </summary>
    public class MaintenanceModeServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
