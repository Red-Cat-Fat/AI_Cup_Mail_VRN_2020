using Game.Visualizer;
using UnityEngine;

namespace Game.Commands
{
	[RequireComponent(typeof(Rigidbody), typeof(Collider), typeof(ChangerMaterial))]
	public class BaseSelectedObject : MonoBehaviour, ISelectedObject
	{
		protected Collider _collider;
		protected ChangerMaterial _changerMaterial;

		public void Awake()
		{
			if (_collider == null)
			{
				_collider = GetComponent<Collider>();
			}

			if (_changerMaterial == null)
			{
				_changerMaterial = GetComponent<ChangerMaterial>();
			}
		}

		public virtual void OnSelected()
		{
		}

		public virtual void OnDeselected()
		{
			_changerMaterial.ResetColor();
		}
	}
}
