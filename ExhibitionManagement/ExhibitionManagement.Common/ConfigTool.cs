namespace ExhibitionManagement.Common
{
    public class ConfigTool
    {
        public static string GetDBConnectionString(string connName)  //static系統run起來就會產生在記憶體內了
        {
            return
                System.Configuration.ConfigurationManager.
                    ConnectionStrings[connName].ConnectionString.ToString();
        }

        public static string GetAppsetting(string Key)
        {
            string AppSetting = string.Empty;
            AppSetting = System.Configuration.ConfigurationManager.AppSettings[Key];
            return AppSetting;
        }
    }
}
