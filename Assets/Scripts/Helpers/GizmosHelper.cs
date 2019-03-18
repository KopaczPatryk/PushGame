using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Helpers
{
    public static class GizmosHelper
    {
        public static void DrawWireQuad(Vector3 pos, Vector2 scale)
        {
            Gizmos.DrawLine(pos - (Vector3.forward * scale.y - Vector3.right * scale.x) * 0.5f, pos + (Vector3.forward * scale.y - Vector3.right * scale.x) * 0.5f);

            Gizmos.DrawLine(pos - (-Vector3.forward * scale.y - Vector3.right * scale.x) * 0.5f, pos - (-Vector3.forward * scale.y + Vector3.right * scale.x) * 0.5f);
            Gizmos.DrawLine(pos - (Vector3.forward * scale.y + Vector3.right * scale.x) * 0.5f, pos - (Vector3.forward * scale.y - Vector3.right * scale.x) * 0.5f);

            Gizmos.DrawLine(pos - (Vector3.forward * scale.y - Vector3.right * scale.x) * 0.5f, pos + (Vector3.forward * scale.y + Vector3.right * scale.x) * 0.5f);
            Gizmos.DrawLine(pos - (Vector3.forward * scale.y + Vector3.right * scale.x) * 0.5f, pos + (Vector3.forward * scale.y - Vector3.right * scale.x) * 0.5f);
        }
    }
}
