using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Game.Configs
{
    [CreateAssetMenu(fileName = "visualSettings", menuName = "VisualSettings")]
    public class VisualSettingsConfig : ScriptableObject
    {
        [Serializable]
        public class VisualPair
        {
            [HideInInspector]
            public string DebugTitle;
            public Controllers.UnitType Type;
            public GameObject VisualGameObject;
        }

        public List<VisualPair> visualSettings = new List<VisualPair>();

        public void OnValidate()
        {

            foreach (var pair in visualSettings)
            {
                pair.DebugTitle = pair.Type.ToString();
            }
        }

        public GameObject GetVisual(Controllers.UnitType type){
            foreach (var pair in visualSettings)
            {
                if(pair.Type==type){
                    return pair.VisualGameObject;
                }
            }
            return null;
        }
    }
}
