using Humanlights.Extensions;
using UnityEngine;

namespace tinyWarzone.Entities
{
    public class CCTV : BaseInteractible
    {
        public Transform CameraHead;
        public EntityRef CameraFeed;
        public float RotationLerp = 1f;
        public float RotateSpeed = 0.2f;
        public Vector2 RotationClamp = new Vector2 ( 45, 35 );
        public Vector2 ZoomingClamp = new Vector2 ( 5, 50 );
        public float ZoomingSpeed = 0.5f;
	}
}