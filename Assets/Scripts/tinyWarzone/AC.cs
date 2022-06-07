using Humanlights.Unity.Sound;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class AC : BaseEntity
    {
        [LargeHeader ( "References" )]
        public ParticleSystem AirBlowSystem;
        public SoundPlayer SoundPlayer;
        public SoundDefinition AcOnDef;
	}
}