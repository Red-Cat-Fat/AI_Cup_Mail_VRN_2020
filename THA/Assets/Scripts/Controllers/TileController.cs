﻿using System.Collections;
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

        private int _teamId = -1;
        public int TeamID => _teamId;

		private int _positionX;
        private int _positionY;

        public int PositionX => _positionX;
        public int PositionY => _positionY;

        public UnitController UnitContainer;

        public void SetPosition(int x, int y)
        {
            _positionX = x;
            _positionY = y;
        }

        public void SetType(TileType type)
        {
            _type = type;
        }

        public void SetTeamId(int id, Color colorTeam)
        {
            _teamId = id;
			_changerMaterial.SetDefaultColor(colorTeam);
			_changerMaterial.ResetColor();
        }

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
