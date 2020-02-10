using System.Collections;
using System.Collections.Generic;
using Game.Configs;
using UnityEditor.VersionControl;
using UnityEngine;

namespace Game.Controllers
{
	public enum UnitType
	{
		Tank,
		Helicopter,
		Antiaircraft
	}

	public class UnitController : MonoBehaviour
	{
		public UnitType Type => _type;

		[SerializeField] private UnitType _type;

		public VisualSettingsConfig VisualSettings;

		private void Awake()
		{
			var visual = GameSettingsConfig.instance.VisualSettings.GetVisual(_type);
			if (visual != null)
			{
				Instantiate(visual, transform.position, Quaternion.identity, transform);
			}
		}
	}
}
