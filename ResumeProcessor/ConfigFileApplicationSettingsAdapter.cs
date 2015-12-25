using Model;
using System.Configuration;


namespace ResumeProcessor
{
    internal class ConfigFileApplicationSettingsAdapter : IApplicationSettings
    {
        public string InputReaderLocation
        {
            get { return ConfigurationManager.AppSettings["InputReaderLocation"]; }
        }
    }
}
