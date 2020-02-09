﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Controllers
{
    public enum UnitType{
        Tank,
        Helicopter,
        Antiaircraft
    }
    public class UnitController : MonoBehaviour
    {
        public UnitType Type;
        [SerializeField]
        private UnitType _type;
    }
}