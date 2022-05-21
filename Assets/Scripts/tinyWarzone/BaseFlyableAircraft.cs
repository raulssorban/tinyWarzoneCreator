using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class BaseFlyableAircraft : BaseAircraft
    {
        public float FlightDelay = 4f;
        public EntityRef [] SeatRefs;
	}
}