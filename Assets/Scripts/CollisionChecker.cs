using UnityEngine;

public class LaserCollision : MonoBehaviour
{
    public GameObject loseScreen;
    AudioSource hit;
    int hits = 0;

    void Start()
    {
        hit = GetComponent<AudioSource>();
    }
    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("Projectile"))
        {
            hits++;
            hit.Play();

        }

        if (hits == 3)
        {
            Time.timeScale = 0;
            loseScreen.SetActive(true);
        }
    }
}
