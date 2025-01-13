using UnityEngine;
using Settings;

public class CatSpin : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (LoadOptions.GetSetting("skin") == 1)
        {
            animator.SetFloat("Speed", rb.velocity.magnitude);
        }
    }
}
