using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Assets.Scripts.Helpers.GizmosHelper;

public class PathingProvider : MonoBehaviour
{
    public Transform leftPathEnd;
    public Transform rightPathEnd;
    
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
}
