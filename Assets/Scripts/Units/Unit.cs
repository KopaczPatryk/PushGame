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
        private readonly float demage;
        private readonly float health;

        public Unit(float dmg, float hp)
        {
            demage = dmg;
            health = hp;
        }
    }
}
