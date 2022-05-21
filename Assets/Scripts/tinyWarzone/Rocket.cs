using Humanlights.Extensions;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class Rocket : BaseEntity
    {
        public AnimationCurve Acceleration;
        public float Speed = 6.5f;
        public float RebalanceTime = 2.5f;
        public float PositionLerp = 2f;
        public float RotationLerp = 0.5f;
        public float CannotExplodeUntil = 3f;
        public EntityRef Explosion;
        public float Lifetime = 10f;
        public GameObject Ignition;
	}
}