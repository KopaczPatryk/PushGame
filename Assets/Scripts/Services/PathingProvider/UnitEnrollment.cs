using System;
using Assets.Scripts;
using UnityEngine;

public class UnitEnrollment
{
    public Unit Unit;
    public float Position;

    internal void MoveUnits()
    {
        Unit.transform.position = new Vector3(Position, 0, 0);
    }
}