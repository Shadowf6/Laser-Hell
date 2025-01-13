using System.IO;
using UnityEngine;
using Settings;

public class OnStart : MonoBehaviour
{
    void Start()
    {
        if (!File.Exists(Path.Combine(Application.persistentDataPath, "options.txt")))
        {
            LoadOptions.CreateOptionsFile();
        }

        if (LoadOptions.GetSetting("fullscreen") == 1) Screen.fullScreen = true;
    }
}
