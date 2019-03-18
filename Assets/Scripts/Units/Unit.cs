using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Unit : MonoBehaviour
    {
        public float demage;
        public float health;

        public void Setup(float dmg, float hp)
        {
            demage = dmg;
            health = hp;
        }

        public override string ToString()
        {
            return $"Unit hp: {health}, dmg: {demage}";
        }

        public virtual void Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}
