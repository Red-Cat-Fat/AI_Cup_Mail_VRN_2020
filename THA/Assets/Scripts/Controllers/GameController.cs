using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Game.Configs;
using UnityEngine;

namespace Game.Controllers
{
	public class GameController : MonoBehaviour
	{
		public static GameController Instance;
		public static VisualSettingsConfig VisualSettingsConfig => Instance?._gameSettingsConfig.VisualSettings;
		[SerializeField]
		private GameSettingsConfig _gameSettingsConfig;
		private GameObject[][] map;

		private void Awake()
		{
			if (Instance == null)
			{
				Instance = this;
			}
			else
			{
				return;
			}
			var x = _gameSettingsConfig.WorldSizeX;
			var y = _gameSettingsConfig.WorldSizeY;
			CreateMap(x, y);
		}

		public void CreateMap(int x, int y)
		{
			var tileStep = _gameSettingsConfig.TileStep;
			var tileGameObject = _gameSettingsConfig.VisualSettings.GetTileGameObject();
			map = new GameObject[x][];
			for (int i = 0; i < map.Length; i++)
			{
				map[i] = new GameObject[y];
				for (int j = 0; j < map[i].Length; j++)
				{
					map[i][j] = 
						Instantiate(
							tileGameObject, 
							new Vector3(i * tileStep, 0, j * tileStep),
							Quaternion.identity);
				}
			}
		}
	}
}
