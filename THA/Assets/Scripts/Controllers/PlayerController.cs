using System;
using System.Collections;
using System.Collections.Generic;
using Game.Controllers;
using Game.Utilities;
using UnityEngine;

public class PlayerController : IDisposable
{
    private int _id;
    public int ID => _id;

    private List<UnitController> _units = new List<UnitController>();
    private TileController _base;
    private Color _teamColor;
    private int _reserve;
    private int _reserveMinStep;
    private DisposebleEvent<int> CanBuyUnitEvent;

    public PlayerController(int id, Color teamColor, int reserveMinStep)
    {
        _id = id;
        _teamColor = teamColor;
        _reserveMinStep = reserveMinStep;
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

    public void SubscribeCanBuyUnitEvent(DisposebleEvent<int> canBuyUnitEvent)
    {
        CanBuyUnitEvent = canBuyUnitEvent;
    }

    public void AddReserve(int reserve)
    {
        _reserve += reserve;
        if (_reserveMinStep < _reserve)
        {
            CanBuyUnitEvent?.Invoke(_reserve);
        }
    }

    public void Dispose()
    {
        CanBuyUnitEvent.Dispose();
    }
}
