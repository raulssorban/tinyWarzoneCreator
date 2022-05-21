using UnityEngine;

namespace tinyWarzone.Entities
{
    public class Sweepo : BaseVehicle
    {
        public Animator Animator;
        public Transform BrushLeft;
        public Transform BrushRight;
        public string [] DirtyObjects;
        public float PitchBeginEnd = 0.1f;
        public float PitchTimeStart = 2.5f;
        public float PitchTimeEnd = 0.75f;
        public float BrushesDelay = 0.3f;
	}
}