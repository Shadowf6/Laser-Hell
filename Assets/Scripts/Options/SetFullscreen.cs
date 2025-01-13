using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Settings;

public class SetFullscreen : MonoBehaviour
{
    TextMeshProUGUI text;
    List<string> val;

    void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        Button button = GetComponent<Button>();
        button.onClick.AddListener(Fullscreen);

        val = new List<string>() { "Enter Fullscreen", "Exit Fullscreen" };
        text.text = LoadOptions.GetSetting("fullscreen").ToString();
    }

    void Fullscreen()
    {
        bool fullscreen = !Screen.fullScreen;
        text.text = val[fullscreen ? 1 : 0];

        LoadOptions.UpdateSetting("fullscreen", fullscreen ? 1 : 0);
        Screen.fullScreen = fullscreen;
    }
}
