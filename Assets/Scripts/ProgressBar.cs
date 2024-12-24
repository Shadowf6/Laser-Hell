using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressBar : MonoBehaviour
{
    public float countdown;
    public TextMeshProUGUI winText;
    public TMP_Text percentText;
    Image progressBar;
    float timeLeft;

    void Start()
    {
        progressBar = GetComponent<Image>();
        timeLeft = countdown;

        progressBar.fillAmount = 0;
        percentText.text = "0%";
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, 1 - (timeLeft / countdown), Time.deltaTime * 60f);
            percentText.text = (float)Math.Round(((1 - (timeLeft / countdown)) * 100), 1) + "%";
        } else
        {
            progressBar.fillAmount = 1;
            winText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
