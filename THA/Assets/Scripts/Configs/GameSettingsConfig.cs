using System.Collections;
using System.Collections.Generic;
using Game.Configs;
using UnityEditor;
using UnityEngine;

namespace Game.Configs
{
	public class GameSettingsData : ScriptableObject
	{
		[Tooltip("World")]
		public float TileStep;
		public int WorldSizeX;
		public int WorldSizeY;
		[Tooltip("Configs")]
		public VisualSettingsConfig VisualSettings;
		public DamageByTypeConfig DamageByType;
	}

	public class GameSettingsConfig : ScriptableSingleton<GameSettingsData>
	{

	}
}
