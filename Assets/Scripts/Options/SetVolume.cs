using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Settings;

public class SetVolume : MonoBehaviour
{

    public TMP_Text volumeText;
    LoadOptions settings;
    Dictionary<string, int> options;
    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(ChangeVolume);

        settings = new LoadOptions();
        options = settings.GetSettings();

        slider.value = options["volume"];
        volumeText.text = slider.value.ToString();
    }

    void ChangeVolume(float value)
    {
        volumeText.text = ((int)value).ToString();
        settings.UpdateSettings((int)value, options["fullscreen"]);
    }
}
