using System.Collections;
using System.Collections.Generic;
using Game.Configs;
using UnityEditor;
using UnityEngine;

namespace Game.Configs
{
	[CreateAssetMenu(fileName = "Total config", menuName = "TotalConfig")]
	public class GameSettingsData : ScriptableObject
	{
		public VisualSettingsConfig VisualSettings;
	}

	public class GameSettingsConfig : ScriptableSingleton<GameSettingsData>
	{

	}
}
