using System;
using Abc.Zebus.Util;

namespace Abc.Zebus.Directory.Configuration
{
    public class AppSettingsBusConfiguration : IBusConfiguration
    {
        public AppSettingsBusConfiguration()
        {
            RegistrationTimeout = AppSettings.Get("Bus.Directory.RegistrationTimeout", 30.Seconds());
            StartReplayTimeout = AppSettings.Get("Bus.Persistence.StartReplayTimeout", 30.Seconds());
            IsDirectoryPickedRandomly = AppSettings.Get("Bus.Directory.PickRandom", true);
        }

        public string[] DirectoryServiceEndPoints => new string[0];
        public bool IsPersistent => false;

        public TimeSpan RegistrationTimeout { get; private set; }
        public TimeSpan StartReplayTimeout { get; private set; }
        public bool IsDirectoryPickedRandomly { get; private set; }
    }
}