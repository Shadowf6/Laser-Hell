using System.IO;
using System.Collections.Generic;
using UnityEngine;

namespace Settings
{
    public class LoadOptions : MonoBehaviour
    {
        static Dictionary<string, int> GetSettings()
        {
            Dictionary<string, int> settings = new Dictionary<string, int>();
            string[] file = File.ReadAllLines(Path.Combine(Application.persistentDataPath, "options.txt"));

            foreach (string line in file)
            {
                string[] pair = line.Split(':');
                settings.Add(pair[0], int.Parse(pair[1]));  
            }

            return settings;
        }

        public static int GetSetting(string setting)
        {
            return GetSettings()[setting];
        }

        public static void UpdateSetting(string setting, int val)
        {
            var prev = GetSettings();
            prev[setting] = val;
            List<string> settingsList = new List<string>();

            foreach (var pair in prev) 
            { 
                settingsList.Add(pair.Key + ":" + pair.Value);       
            }

            string[] newSettings = settingsList.ToArray();
            File.WriteAllLines(Path.Combine(Application.persistentDataPath, "options.txt"), newSettings);
        }

        public static void CreateOptionsFile()
        {
            string[] defaultSettings = new string[] {
                "volume:100",
                "fullscreen:0",
                "skin:0"
            };

            File.WriteAllLines(Path.Combine(Application.persistentDataPath, "options.txt"), defaultSettings);
        }
    }
}
