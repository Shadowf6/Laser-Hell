using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public GameObject optionsScreen, pauseScreen;
    Button button;

    void Start()
    {
        optionsScreen.SetActive(false);

        button = GetComponent<Button>();
        button.onClick.AddListener(LoadOptions);
    }

    void LoadOptions()
    {
        pauseScreen.SetActive(false);
        optionsScreen.SetActive(true);
    }
}
