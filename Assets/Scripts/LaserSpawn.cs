using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LaserSpawn : MonoBehaviour
{
    public GameObject laser;
    public float laserDelay;
    private int n = 1;

    void Start()
    {
        StartCoroutine(SpawnLaser());
    }

    IEnumerator SpawnLaser()
    {
        while (n <= 20)
        {
            yield return new WaitForSeconds(3f);
            StartCoroutine(Lasers(n));

            n++;
        }
    }

    IEnumerator Lasers(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Instantiate(laser);
            yield return new WaitForSeconds(laserDelay);
        }
    }
}
