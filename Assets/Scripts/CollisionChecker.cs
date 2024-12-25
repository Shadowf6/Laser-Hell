using UnityEngine;
using TMPro;

public class LaserCollision : MonoBehaviour
{
    public GameObject loseScreen;
    private int hits = 0;

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("Projectile")) hits++;

        if (hits == 3)
        {
            Time.timeScale = 0;
            loseScreen.SetActive(true);
        }
    }
}
