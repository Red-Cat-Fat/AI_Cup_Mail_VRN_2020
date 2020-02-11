using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Game.Configs;
using UnityEngine;

namespace Game.Controllers
{
	public class GameController : MonoBehaviour
	{
		private GameObject[][] map;

		private void Awake()
		{
			var x = GameSettingsConfig.instance.WorldSizeX;
			var y = GameSettingsConfig.instance.WorldSizeY;
			CreateMap(x, y);
		}

		public void CreateMap(int x, int y)
		{
			var tileStep = GameSettingsConfig.instance.TileStep;
			var tileGameObject = GameSettingsConfig.instance.VisualSettings.GetTileGameObject();
			map = new GameObject[x][];
			for (int i = 0; i < map.Length; i++)
			{
				map[i] = new GameObject[y];
				for (int j = 0; j < map[i].Length; j++)
				{
					map[i][j] = 
						Instantiate(
							tileGameObject, 
							new Vector3(i * tileStep, j * tileStep, 0),
							Quaternion.identity);
				}
			}
		}
	}
}
