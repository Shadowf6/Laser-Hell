using System.Collections;
using UnityEngine;

public class LaserSpawn : MonoBehaviour
{
    public GameObject laser;
    private int n = 1;

    void Start()
    {
        StartCoroutine(SpawnLaser());
    }

    IEnumerator SpawnLaser()
    {
        while (n <= 60)
        {
            yield return new WaitForSeconds(3f);

            for (int i = 0; i < 2 * Mathf.CeilToInt(n / 3f); i++)
            {
                Instantiate(laser);
                yield return new WaitForSeconds(0.1f);
            }

            n++;
        }
    }
}
