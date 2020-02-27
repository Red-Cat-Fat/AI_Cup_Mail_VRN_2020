using System.Collections;
using System.Collections.Generic;
using Game.Controllers;
using UnityEngine;

namespace Game.Controllers
{
    public class MapController
    {
        private Dictionary<TileController, int> _basesTile = new Dictionary<TileController, int>();

        private GameObject[][] _map;

        public void CreateMap(int x, int y, float tileStep, GameObject tileGameObject, GameObject parent)
        {
            _map = new GameObject[x][];
            for (int i = 0; i < _map.Length; i++)
            {
                _map[i] = new GameObject[y];
                for (int j = 0; j < _map[i].Length; j++)
                {
                    _map[i][j] =
                        Object.Instantiate(
                            tileGameObject,
                            new Vector3(i * tileStep, 0, j * tileStep),
                            Quaternion.identity,
                            parent.transform);
                    _map[i][j].name = $"Tile[{i};{j}]";
                    var tileController = _map[i][j].GetComponent<TileController>();
                    if (tileController == null)
                    {
                        Debug.LogError("tileController is null");
                        return;
                    }

                    tileController.SetPosition(i, j);

                    if ((i == 0 || i == _map.Length - 1) && (j == 0 || j == _map[i].Length - 1))
                    {
                        tileController.SetType(TileType.Base);
                        _basesTile.Add(tileController, -1);
                    }
                }
            }
        }

        public TileController GetFreeBase()
        {
            foreach (var tile in _basesTile.Keys)
            {
                if (_basesTile[tile] < 0)
                {
                    return tile;
                }
            }

            return null;
        }
    }
}
