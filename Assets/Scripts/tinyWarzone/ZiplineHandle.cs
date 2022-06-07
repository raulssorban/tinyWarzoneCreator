using Humanlights.Unity.Sound;
using tinyWarzone.Entities.Components;
using tinyWarzone.Trigger;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class ZiplineHandle : BaseEntity
    {
        public EntityRef Seat;
        [Header ( "Settings" )]
        public float Speed;
        public float AccelerationSpeed;
        public float DecelerationSpeed;
        public float Lerp;
        [Header ( "Sound" )]
        public SoundPlayer SoundPlayer;
        public SoundDefinition MountDef;
        public SoundDefinition DismountDef;
        public SoundDefinition LoopDef;
        public SoundDefinition LoopAccelerationDef;
        public SoundDefinition LoopDecelerationDef;
	}
}