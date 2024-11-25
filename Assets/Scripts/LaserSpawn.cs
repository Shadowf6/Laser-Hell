using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Laser;

public class LaserSpawn : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 60; i++)
        {
            var n = (int)Math.Ceiling((double)i / 3);

            for (int j = 0; j < n; j++)
            {
                randomDirection(); // summonLaser(randomDirection());
            }
        }
    }

    int randomDirection()
    {
        return 0;
    }
}
