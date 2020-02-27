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
		[Header("World")]
		public float TileStep;
		public int WorldSizeX;
		public int WorldSizeY;
        [Header("Teams")]
        public Color[] TeamColors;

        public int ReservePrice;
        public int StartReserve;
		[Header("Configs")]
		public VisualSettingsConfig VisualSettings;
		public DamageByTypeConfig DamageByType;

    }
}
