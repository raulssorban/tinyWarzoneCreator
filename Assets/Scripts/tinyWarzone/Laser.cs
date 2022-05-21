using UnityEngine;

namespace tinyWarzone.Weapons
{
    public class Laser : FoldableAttachment
    {
        public Transform Body;
        public GameObject Pointer;
        public Vector3 PointerOffset;
        public LayerMask Mask;
        public float Distance = 5f;
	}
}