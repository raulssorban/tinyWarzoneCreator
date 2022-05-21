using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace tinyWarzone.Entities
{
    public class CameraFeed : BaseEntity
    {
        public Camera Camera;
        public int Depth = 0;
        public float FieldOfView = 50f;
        public float ZoomLerp = 10f;
	}
}