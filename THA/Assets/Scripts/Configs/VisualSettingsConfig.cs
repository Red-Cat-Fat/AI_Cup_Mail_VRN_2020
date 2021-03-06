﻿using System;
using System.Collections.Generic;
using Game.Controllers;
using UnityEngine;

namespace Game.Configs
{
	[CreateAssetMenu(fileName = "visualSettings", menuName = "VisualSettings")]
	public class VisualSettingsConfig : ScriptableObject
	{
		[Serializable]
		public class VisualPair
		{
			[HideInInspector] public string DebugTitle;
			public UnitType Type;
			public GameObject VisualGameObject;
		}

		[SerializeField]
		private List<VisualPair> _visualSettings = new List<VisualPair>();

		[SerializeField]
		private GameObject _tileGameObject;

		public void OnValidate()
		{

			foreach (var pair in _visualSettings)
			{
				pair.DebugTitle = pair.Type.ToString();
			}
		}

		public GameObject GetVisual(UnitType type)
		{
			foreach (var pair in _visualSettings)
			{
				if (pair.Type == type)
				{
					return pair.VisualGameObject;
				}
			}

			return null;
		}

		public GameObject GetTileGameObject()
		{
			return _tileGameObject;
		}
	}
}
