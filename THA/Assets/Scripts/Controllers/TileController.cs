using System.Collections;
using System.Collections.Generic;
using Game.Commands;
using Game.Configs;
using UnityEngine;
using NotImplementedException = System.NotImplementedException;

namespace Game.Controllers
{
	public enum TileType
	{
		None,
		Base,
		Forest
	}

	public class TileController : BaseSelectedObject
	{
		public TileType Type => _type;
		[SerializeField]
		private TileType _type;
		
		public override void OnSelected()
		{
			_changerMaterial.SetColor(Color.red);
		}

		public override void OnDeselected()
		{
			_changerMaterial.ResetColor();
		}
	}
}
