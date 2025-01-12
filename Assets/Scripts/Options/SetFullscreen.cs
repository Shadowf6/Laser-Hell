using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Settings;

public class SetFullscreen : MonoBehaviour
{
    TextMeshProUGUI text;
    LoadOptions settings;
    Dictionary<string, int> options;
    List<string> val;

    void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        Button button = GetComponent<Button>();
        button.onClick.AddListener(Fullscreen);

        settings = new LoadOptions();
        options = settings.GetSettings();

        val = new List<string>() { "Enter Fullscreen", "Exit Fullscreen" };
        text.text = val[options["fullscreen"]];
    }

    void Fullscreen()
    {
        bool fullscreen = !Screen.fullScreen;
        text.text = val[fullscreen ? 1 : 0];

        options["fullscreen"] = fullscreen ? 1 : 0;
        settings.UpdateSettings(options["volume"], options["fullscreen"]);

        Screen.fullScreen = fullscreen;
    }
}
