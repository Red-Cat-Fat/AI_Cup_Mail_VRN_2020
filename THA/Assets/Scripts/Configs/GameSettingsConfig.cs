using System.Collections;
using System.Collections.Generic;
using Game.Configs;
using UnityEditor;
using UnityEngine;

namespace Game.Configs
{
	[CreateAssetMenu(fileName = "StandartSettingsConfig", menuName = "Set Conf")]
	public class GameSettingsConfig : ScriptableObject
	{
		[Tooltip("World")]
		public float TileStep;
		public int WorldSizeX;
		public int WorldSizeY;
        [Tooltip("Teams")]
        public Color[] TeamColors;
		[Tooltip("Configs")]
		public VisualSettingsConfig VisualSettings;
		public DamageByTypeConfig DamageByType;

    }
}
