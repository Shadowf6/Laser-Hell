using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu, options;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if (options.activeSelf == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (Time.timeScale == 0)
                {
                    Time.timeScale = 1;
                    pauseMenu.SetActive(false);
                }
                else
                {
                    Time.timeScale = 0;
                    pauseMenu.SetActive(true);
                }
            }
        }
    }
}
