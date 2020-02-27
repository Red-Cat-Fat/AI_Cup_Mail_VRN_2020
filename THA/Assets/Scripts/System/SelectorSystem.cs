using System.Collections;
using System.Collections.Generic;
using Game.Commands;
using UnityEngine;

namespace Game.System
{
	public class SelectorSystem : MonoBehaviour
	{
		public Camera Camera;
		private ISelectedObject _lastSelectedObject;

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				_lastSelectedObject?.OnDeselected();
				_lastSelectedObject = null;
				var ray = Camera.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(ray, out var hit))
				{
					var seletor = hit.transform.GetComponent<ISelectedObject>();
					if (seletor != null)
					{
						_lastSelectedObject = seletor;
						seletor.OnSelected();
					}
				}
			}
		}
	}
}
