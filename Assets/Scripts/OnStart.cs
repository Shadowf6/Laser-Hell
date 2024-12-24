using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Settings;

public class OnStart : MonoBehaviour
{
    void Start()
    {
        var settings = new LoadOptions();
        
        if (!File.Exists(Path.Combine(Application.persistentDataPath, "options.txt")))
        {
            settings.CreateOptionsFile();
        }

        var options = settings.GetSettings();

        if (options["fullscreen"] == 1) Screen.fullScreen = true;
    }
}
