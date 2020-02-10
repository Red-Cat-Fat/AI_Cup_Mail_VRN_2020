using System;
using System.Collections.Generic;
using System.Linq;
using Game.Controllers;
using UnityEngine;

namespace Game.Configs
{
	[CreateAssetMenu(fileName = "NewDamageByTypeConfig", menuName = "DamageByTypeConfig")]
	public class DamageByTypeConfig : ScriptableObject
	{
		[Serializable]
		public class RelationType
		{
			public UnitType AttackType;
			public UnitType DefenderType;
			public float AttackModifier;

			private void OnValidate()
			{
				if (AttackModifier < 0)
				{
					AttackModifier = 0;
				}
			}
		}

		[SerializeField]
		private List<RelationType> _attacklRelationTypes = new List<RelationType>();

		public float GetDamageByModifier(float damage, UnitType AttackType, UnitType defenderType)
		{
			var attackList = _attacklRelationTypes.Where(x => x.AttackType == AttackType);
			foreach (var relationType in attackList)
			{
				if (relationType.DefenderType == defenderType)
				{
					return damage * relationType.AttackModifier;
				}
			}
			return damage;
		}
	}
}
