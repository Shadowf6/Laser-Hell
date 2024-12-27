using UnityEngine;

public class HomingLaser : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private GameObject player;
    int randomDirection;

    void Start()
    {
        randomDirection = Random.Range(1, 5);
        player = GameObject.Find("Player");

        float x = player.transform.position.x;
        float y = player.transform.position.y;

        if (randomDirection == 1)
        {
            direction = Vector2.left;
            transform.position = new Vector3(10f, y, 0);
        }
        else if (randomDirection == 2)
        {
            direction = Vector2.right;
            transform.position = new Vector3(-10f, y, 0);
        }
        else if (randomDirection == 3)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            direction = Vector2.right;
            transform.position = new Vector3(x, -5.9f, 0);
        }
        else if (randomDirection == 4)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
            direction = Vector2.left;
            transform.position = new Vector3(x, 5.9f, 0);
        }
    }

    void Update()
    {
        if (randomDirection == 3 || randomDirection == 4)
        {
            transform.Translate(direction * speed * 0.75f * Time.deltaTime);
        }
        else
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }

        Vector3 pos = transform.position;

        if (pos.x < -10f || pos.x > 10f || pos.y < -6f || pos.y > 6f)
        {
            Destroy(gameObject, 0.1f);
        }
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
