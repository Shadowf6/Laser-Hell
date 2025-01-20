using UnityEngine;
using Settings;

public class CatSpin : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        if (LoadOptions.GetSetting("skin") == 1)
        {
            animator.SetBool("IsCat", true);
        } else
        {
            animator.SetBool("IsCat", false);
        }
    }
}
