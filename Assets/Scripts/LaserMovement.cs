using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public float speed;
    private Vector2 direction;

    void Start()
    {
        int randomDirection = Random.Range(1, 5);

        if (randomDirection == 1)
        {
            direction = Vector2.left;
            transform.position = new Vector3(10f, Random.Range(-4f, 4.1f), 0);
            transform.rotation = Quaternion.identity;
        }
        else if (randomDirection == 2)
        {
            direction = Vector2.right;
            transform.position = new Vector3(-10f, Random.Range(-4f, 4.1f), 0);
            transform.rotation = Quaternion.identity;
        }
        else if (randomDirection == 3)
        {
            direction = Vector2.up;
            transform.position = new Vector3(Random.Range(-8f, 8.1f), -5.9f, 0);
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else
        {
            direction = Vector2.down;
            transform.position = new Vector3(Random.Range(-8f, 8.1f), 5.9f, 0);
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
    }
        
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * direction);
        Vector3 pos = transform.position;

        if (pos.x < -10f || pos.x > 10f || pos.y < -6f || pos.y > 6f)
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
