namespace StoreManagerPlace_App.Entities.Security
{
    using System.Configuration;

    public class Credential
    {
        public static string ConnectStr =>
            ConfigurationManager.ConnectionStrings["StoreManagerPlace_App.Properties.Settings.SMP_DBConnectionString"]
            .ConnectionString;
    }
}
