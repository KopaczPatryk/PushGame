using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSoldier : Unit, IUnit
{
    public BasicSoldier(float dmg, float hp) : base(dmg, hp) { }

    public void Attack()
    {
        throw new System.NotImplementedException();
    }
}
