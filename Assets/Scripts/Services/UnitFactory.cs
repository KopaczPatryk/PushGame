using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour
{
    public GameObject GenericUnitPrefab;
    internal Unit SpawnUnit(int dmg, int hp)
    {
        var unit = Instantiate(GenericUnitPrefab).GetComponent<Unit>();
        unit.Setup(dmg, hp);
        return unit;
    }
}
