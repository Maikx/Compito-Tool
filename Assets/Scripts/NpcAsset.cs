using UnityEngine;

namespace tool
{
    [CreateAssetMenu(fileName = "NewNpcAsset", menuName = "Tool/Npc/Data", order = 0)]
    public class NpcAsset : ScriptableObject
    {
            [Header("General"), Space(10)]
            public string npcName;
            public string npcDescription;
            public enum Role { Knight, Archer, Mage, Zombie }
            public Role role;

            [Header("Statistics"), Space(10)]
            public uint heathPoints;
            public uint armorPoints;
            public uint attackPoints;
            public uint speedPoints;
    }


}
