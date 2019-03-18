using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using static Assets.Scripts.Helpers.GizmosHelper;
using Assets.Scripts;

public class PathingProvider : MonoBehaviour
{
    public Transform leftPathEnd;
    public Transform rightPathEnd;
    
    public PlayerBase LeftBase;
    public PlayerBase RightBase;

    private Vector3 midpoint;

    private List<Side> sides = new List<Side>();

    private void Start()
    {
        midpoint = leftPathEnd.position + rightPathEnd.position;
    }
    private void Update()
    {
        if (sides.Count == 2)
        {
            foreach (Side side in sides)
            {
                foreach (UnitEnrollment enrollment in side.UnitQueue)
                {
                    
                    enrollment.Position -= (Math.Sign(enrollment.Position) * Time.deltaTime);
                    enrollment.MoveUnits();
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(leftPathEnd.position, rightPathEnd.position);

        Vector3 midpoint = leftPathEnd.position + rightPathEnd.position;

        Gizmos.color = Color.green;
        Gizmos.DrawLine(midpoint - Vector3.forward / 3, midpoint + Vector3.forward / 3);
        for (int i = 0; i < 3; i++)
        {
            DrawWireQuad(midpoint - Vector3.left * i + Vector3.right * 0.5f, new Vector2(0.8f, 0.8f));
        }
    }

    public bool CanEnroll(Side thisSide)
    {
        return true;
    }

    internal void EnrollUnit(Side side, Unit unit)
    {
        UnitEnrollment enrollment = new UnitEnrollment { Unit = unit, Position = side.Base.SpawnPoint.position.x };
        side.UnitQueue.Add(enrollment);
        unit.transform.position = new Vector3(enrollment.Position, 0, 0);
    }

    public void SignBase(PlayerBase @base)
    {
        sides.Add(new Side(@base.name, @base));
    }
    public Side Side(PlayerBase playerBase)
    {
        return sides.Find(s => s.Base == playerBase);
    }
}
