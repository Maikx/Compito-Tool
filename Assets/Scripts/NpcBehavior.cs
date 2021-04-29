using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tool
{
    public class NpcBehavior : MonoBehaviour
    {
        [Header("General"), Space(10)]
        public string npcName;
        public string npcDescription;

        [Header("Statistics"), Space(10)]
        public uint heathPoints;
        public uint armorPoints;
        public uint attackPoints;
        public uint speedPoints;
    }
}
