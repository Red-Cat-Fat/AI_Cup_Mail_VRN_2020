using System.Collections;
using System.Collections.Generic;
using Game.Controllers;
using UnityEngine;

namespace Game.Controllers
{
    public class MapController
    {
        private TileController[][] _map;

        public void CreateMap(int x, int y, float tileStep, GameObject tileGameObject, GameObject parent)
        {
            _map = new TileController[x][];
            for (int i = 0; i < _map.Length; i++)
            {
                _map[i] = new TileController[y];
                for (int j = 0; j < _map[i].Length; j++)
                {
                    var tileObject = Object.Instantiate(
                        tileGameObject,
                        new Vector3(i * tileStep, 0, j * tileStep),
                        Quaternion.identity,
                        parent.transform);

                    var tileController = tileObject.GetComponent<TileController>();
                    if (tileController == null)
                    {
                        Debug.LogError("tileController is null");
                        return;
                    }

                    _map[i][j] = tileController;
                    _map[i][j].name = $"Tile[{i};{j}]";

                    tileController.SetPosition(i, j);

                    if ((i == 0 || i == _map.Length - 1) && (j == 0 || j == _map[i].Length - 1))
                    {
                        tileController.SetType(TileType.Base);
                    }
                }
            }
        }

        public TileController GetFreeBase()
        {
            foreach (var tileLine in _map)
            {
                foreach (var tile in tileLine)
                {
                    if (tile.Type == TileType.Base && tile.TeamID < 0)
                    {
                        return tile;
                    }
                }
            }

            return null;
        }
    }
}
