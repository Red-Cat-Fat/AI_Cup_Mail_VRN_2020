using System.Collections;
using System.Collections.Generic;
using Game.Configs;
using UnityEditor;
using UnityEngine;

namespace Game.Configs
{
	public class GameSettingsData : ScriptableObject
	{
		public VisualSettingsConfig VisualSettings;
		public DamageByTypeConfig DamageByType;
	}

	public class GameSettingsConfig : ScriptableSingleton<GameSettingsData>
	{

	}
}
