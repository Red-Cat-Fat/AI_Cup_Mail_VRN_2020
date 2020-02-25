using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.System
{
	public class SelectorSystem : MonoBehaviour
	{
		public Camera Camera;

		void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				var ray = Camera.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(ray, out var hit))
				{
					Transform objectHit = hit.transform;
					Debug.Log(objectHit.name);
				}
			}
		}
	}
}
