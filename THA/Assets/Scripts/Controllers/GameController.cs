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

        private MapController _map;
        private PlayerController[] _playerControllers;
        
        public int SizeMapX => _gameSettingsConfig.WorldSizeX;
        public int SizeMapY => _gameSettingsConfig.WorldSizeY;

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

            _map = new MapController();
            _map.CreateMap(x, y, _gameSettingsConfig.TileStep, _gameSettingsConfig.VisualSettings.GetTileGameObject(), this.gameObject);

            var countPlayers = _gameSettingsConfig.TeamColors.Length;
			_playerControllers = new PlayerController[countPlayers];
            for (var index = 0; index < countPlayers; index++)
            {
                _playerControllers[index] = new PlayerController(index, _gameSettingsConfig.TeamColors[index]);
				var baseTile = _map.GetFreeBase();
                _playerControllers[index].SetBase(baseTile);
			}
        }
	}
}
