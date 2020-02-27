using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Visualizer
{
	[RequireComponent(typeof(MeshRenderer))]
	public class ChangerMaterial : MonoBehaviour
	{
		private MeshRenderer _meshRenderer;
		private Color _defaultColor;
		
		private void Awake()
		{
			if (_meshRenderer == null)
			{
				_meshRenderer = GetComponent<MeshRenderer>();
			}

			if (_meshRenderer.materials != null && _meshRenderer.materials.Length > 0)
			{
				_defaultColor = _meshRenderer.materials[0].color;
			}
		}

		public void SetColor(Color color)
		{
			foreach (var material in _meshRenderer.materials)
			{
				material.color = color;
			}
		}

        public void SetDefaultColor(Color color)
        {
            _defaultColor = color;
        }

		public void ResetColor()
		{
			SetColor(_defaultColor);
		}
	}
}
