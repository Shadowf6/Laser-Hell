using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Settings;

public class SetVolume : MonoBehaviour
{
    public TMP_Text volumeText;
    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(ChangeVolume);

        slider.value = LoadOptions.GetSetting("volume");
        volumeText.text = slider.value.ToString();
    }

    void ChangeVolume(float value)
    {
        volumeText.text = ((int)value).ToString();
        LoadOptions.UpdateSetting("volume", (int)value);
    }
}
