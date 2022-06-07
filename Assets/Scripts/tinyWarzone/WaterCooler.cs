using Humanlights.Extensions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class WaterCooler : BaseInteractible
    {
        public float TankFuel = 1f;
        public float TankDrainRate = 0.025f;
        [LargeHeader ( "Properties" )]
        public float FullTankScale = 0.9f;
        public float LowTankScale = 0.01f;
        [LargeHeader ( "References" )]
        public Transform WaterObject;
	}
}