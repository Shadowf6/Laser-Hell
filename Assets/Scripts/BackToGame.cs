using UnityEngine;
using UnityEngine.UI;

public class BackToGame : MonoBehaviour
{
    public GameObject optionsScreen, pauseScreen;
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Back);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            optionsScreen.SetActive(false);
            pauseScreen.SetActive(true);
        }
    }

    void Back()
    {
        optionsScreen.SetActive(false);
        pauseScreen.SetActive(true);
    }
}
