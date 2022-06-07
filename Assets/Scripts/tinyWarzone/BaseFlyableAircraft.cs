using Humanlights.Tools;
using Humanlights.Unity.Sound;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class BaseFlyableAircraft : BaseAircraft
    {
        public float FlightDelay = 4f;
        [LargeHeader ( "Seats" )]
        public EntityRef [] SeatRefs;
        [LargeHeader ( "Sounds" )]
        public SoundPlayer Engine;
        public SoundPlayer Loop;
        public SoundDefinition StartDef;
        public SoundDefinition MidDef;
        public SoundDefinition StopDef;
	}
}