using System.Collections;
using System.Collections.Generic;
using Game.Controllers;
using UnityEngine;

public class PlayerController
{
    private int _id;
    public int ID => _id;

    private List<UnitController> _units = new List<UnitController>();
    private TileController _base;
    private Color _teamColor;

    public PlayerController(int id, Color teamColor)
    {
        _id = id;
        _teamColor = teamColor;
    }

    public void SetBase(TileController tileController)
    {
        _base = tileController;
        _base.SetTeamId(_id, _teamColor);
    }

    public void AddUnit(UnitController unit)
    {
        _units.Add(unit);
    }
}
