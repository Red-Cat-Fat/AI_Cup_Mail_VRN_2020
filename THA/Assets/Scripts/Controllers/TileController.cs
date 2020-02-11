using System.Collections;
using System.Collections.Generic;
using Game.Configs;
using UnityEngine;

namespace Game.Controllers
{
	public enum TileType
	{
		None,
		Base,
		Forest
	}

	public class TileController : MonoBehaviour
	{
		public TileType Type => _type;
		[SerializeField]
		private TileType _type;
	}
}
