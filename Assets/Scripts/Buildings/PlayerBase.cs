using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public float SpawnInterval = 3;
    public Transform SpawnPoint;
    
    private UnitFactory UnitFactory;
    private PathingProvider PathingProvider;

    private System.Random Random;

    private void Start()
    {
        Random = new System.Random();
        ReferenceServices();
        PathingProvider.SignBase(this);
    }

    private void ReferenceServices()
    {
        UnitFactory = FindObjectOfType<UnitFactory>();
        PathingProvider = FindObjectOfType<PathingProvider>();
    }
    
    private float elapsedTime = 0;
    private int currentLane = 0;
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= SpawnInterval)
        {
            Side thisSide = PathingProvider.Side(this);
            if (PathingProvider.CanEnroll(thisSide))
            {
                Unit unit = SpawnRandomUnit(currentLane);
                PathingProvider.EnrollUnit(thisSide, unit);
                currentLane++;
                if (currentLane > 2)
                {
                    currentLane = 0;
                }
                elapsedTime = 0;
            }
        }
    }

    private Unit SpawnRandomUnit(int lane)
    {
        var unit = UnitFactory.SpawnUnit(1 + Random.Next(2), 10);
        Debug.Log($"Spawned unit with specs {unit.ToString()}");
        return unit;
    }

    public Transform GetSpawnPoint()
    {
        return SpawnPoint;
    }
}
