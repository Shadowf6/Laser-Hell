using UnityEngine;
using TMPro;

public class LaserCollision : MonoBehaviour
{
    public TextMeshProUGUI loseText;
    private int hits = 0;

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("Projectile"))
        {
            hits++;
        }

        if (hits == 3)
        {
            loseText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
