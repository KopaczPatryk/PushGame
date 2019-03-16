using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float SpawnInterval = 1;

    private float elapsedTime = 0;
    private int currentLane = 0;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= SpawnInterval)
        {
            SpawnRandomUnit(currentLane);
            currentLane++;
            if (currentLane > 2)
            {
                currentLane = 0;
            }
        }
    }

    private void SpawnRandomUnit(int lane)
    {
        throw new NotImplementedException();
    }
}
