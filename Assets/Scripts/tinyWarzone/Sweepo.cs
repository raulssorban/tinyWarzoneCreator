using Humanlights.Unity.Sound;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class Sweepo : BaseVehicle
    {
        [LargeHeader ( "Sweepo" )]
        public Animator Animator;
        public Transform BrushLeft;
        public Transform BrushRight;
        public string [] DirtyObjects;
        [Header ( "Sweepo Sound" )]
        public float PitchBeginEnd = 0.1f;
        public float PitchTimeStart = 2.5f;
        public float PitchTimeEnd = 0.75f;
        public float BrushesDelay = 0.3f;
        public SoundPlayer SweepoSound;
        public SoundPlayer BrushesSound;
        public SoundDefinition Sweeping;
        public SoundDefinition LogOn;
        public SoundDefinition LogOff;
	}
}