using UnityEngine;
using UnityEngine.UI;

public class Resume : MonoBehaviour
{
    public GameObject pauseScreen;

    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ResumeLevel);
    }

    void ResumeLevel()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }
}
