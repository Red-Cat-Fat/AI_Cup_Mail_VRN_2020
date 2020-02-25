using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Commands
{
	public interface ISelectedObject
	{
		void OnSelected();
		void OnDeselected();
	}
}
