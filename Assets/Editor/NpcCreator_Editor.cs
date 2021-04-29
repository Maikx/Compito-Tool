using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace tool
{
    public class NpcCreator_Editor : EditorWindow
    {
        static NpcAsset archerAsset;
        static NpcAsset knightAsset;
        static NpcAsset mageAsset;
        static NpcAsset zombieAsset;
        static NpcAsset[] assets 
        {
            get
            {
                var List = new NpcAsset[4];
                List[0] = archerAsset;
                List[1] = knightAsset;
                List[2] = mageAsset;
                List[3] = zombieAsset;
                return List;
            }
        }
        static NpcCreator_Editor window;

        /// <summary>
        /// This is used to create the tools window.
        /// </summary>
        [MenuItem("Tools/Npc/Create")]
        public static void OpenWindow()
        {
            window = (NpcCreator_Editor)EditorWindow.GetWindow(typeof(NpcCreator_Editor));
            window.Show();
        }

        /// <summary>
        /// This is used to assign the asset in the window.
        /// </summary>
        public void OnGUI()
        {
            archerAsset = EditorGUILayout.ObjectField(archerAsset, typeof(NpcAsset), true) as NpcAsset;
            knightAsset = EditorGUILayout.ObjectField(knightAsset, typeof(NpcAsset), true) as NpcAsset;
            mageAsset = EditorGUILayout.ObjectField(mageAsset, typeof(NpcAsset), true) as NpcAsset;
            zombieAsset = EditorGUILayout.ObjectField(zombieAsset, typeof(NpcAsset), true) as NpcAsset;
            if (GUILayout.Button("CreateNpc"))
            {
                foreach(var item in assets)
                {
                    GameObject currentModel = null;
                    if (item != null)
                    {
                        //This switch sets the prefab and gives the given statistics to its script.
                        switch (item.role)
                        {
                            case NpcAsset.Role.Archer:
                                currentModel = Resources.Load("Npc_Archer") as GameObject;
                                currentModel.GetComponent<NpcBehavior>().npcName = item.npcName;
                                currentModel.GetComponent<NpcBehavior>().npcDescription = item.npcDescription;
                                currentModel.GetComponent<NpcBehavior>().heathPoints = item.heathPoints;
                                currentModel.GetComponent<NpcBehavior>().armorPoints = item.armorPoints;
                                currentModel.GetComponent<NpcBehavior>().attackPoints = item.attackPoints;
                                currentModel.GetComponent<NpcBehavior>().speedPoints = item.speedPoints;
                                break;
                            case NpcAsset.Role.Zombie:
                                currentModel = Resources.Load("Npc_Zombie") as GameObject;
                                currentModel.GetComponent<NpcBehavior>().npcName = item.npcName;
                                currentModel.GetComponent<NpcBehavior>().npcDescription = item.npcDescription;
                                currentModel.GetComponent<NpcBehavior>().heathPoints = item.heathPoints;
                                currentModel.GetComponent<NpcBehavior>().armorPoints = item.armorPoints;
                                currentModel.GetComponent<NpcBehavior>().attackPoints = item.attackPoints;
                                currentModel.GetComponent<NpcBehavior>().speedPoints = item.speedPoints;
                                break;
                            case NpcAsset.Role.Knight:
                                currentModel = Resources.Load("Npc_Knight") as GameObject;
                                currentModel.GetComponent<NpcBehavior>().npcName = item.npcName;
                                currentModel.GetComponent<NpcBehavior>().npcDescription = item.npcDescription;
                                currentModel.GetComponent<NpcBehavior>().heathPoints = item.heathPoints;
                                currentModel.GetComponent<NpcBehavior>().armorPoints = item.armorPoints;
                                currentModel.GetComponent<NpcBehavior>().attackPoints = item.attackPoints;
                                currentModel.GetComponent<NpcBehavior>().speedPoints = item.speedPoints;
                                break;
                            case NpcAsset.Role.Mage:
                                currentModel = Resources.Load("Npc_Mage") as GameObject;
                                currentModel.GetComponent<NpcBehavior>().npcName = item.npcName;
                                currentModel.GetComponent<NpcBehavior>().npcDescription = item.npcDescription;
                                currentModel.GetComponent<NpcBehavior>().heathPoints = item.heathPoints;
                                currentModel.GetComponent<NpcBehavior>().armorPoints = item.armorPoints;
                                currentModel.GetComponent<NpcBehavior>().attackPoints = item.attackPoints;
                                currentModel.GetComponent<NpcBehavior>().speedPoints = item.speedPoints;
                                break;
                        }
                    }
                    //This instantiates the prefab
                    if(currentModel != null)
                        Instantiate(currentModel, new Vector3(0, 0, 0), Quaternion.identity);
                }
            }
        }
    }
}
