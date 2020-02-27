using System.Collections;
using System.Collections.Generic;
using Game.Configs;
using Game.Visualizer;
using UnityEditor.VersionControl;
using UnityEngine;

namespace Game.Controllers
{
	public enum UnitType
	{
		Tank,
		Helicopter,
		Antiaircraft
	}

    [RequireComponent(typeof(ChangerMaterial))]
	public class UnitController : MonoBehaviour
	{
		public UnitType Type => _type;
        private int _id = 0;
        private ChangerMaterial _changerMaterial;
        [SerializeField] private UnitType _type;

        private void Awake()
        {
            var visual = GameController.VisualSettingsConfig?.GetVisual(_type);
            if (visual != null)
            {
                var visualGameObject = Instantiate(visual, transform.position, Quaternion.identity, transform);
                if (visualGameObject != null)
                {
                    _changerMaterial = visualGameObject.GetComponentInChildren<ChangerMaterial>();
                    if (_changerMaterial == null)
                    {
                        Debug.LogError("_changerMaterial on unit is null");
                    }
                }
            }
        }

        public void SetTeam(int id, Color colorTeam)
        {
            _id = id;
            _changerMaterial?.SetDefaultColor(colorTeam);
            _changerMaterial?.ResetColor();
        }
    }
}
