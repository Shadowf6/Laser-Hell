using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadOptions);
    }

    void LoadOptions()
    {
        // load options scene (keep current scene loaded)
    }
}
