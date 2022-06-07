using UnityEngine;

namespace tinyWarzone.Entities
{
    public class ElevatorDoor : BaseDoor
    {
        [ReadOnly] public int Floor;
        [ReadOnly] public Elevator Elevator;
        [LargeHeader ( "References" )]
        public GameObject ButtonObj;
        public GameObject SolidWallObj;
	}
}