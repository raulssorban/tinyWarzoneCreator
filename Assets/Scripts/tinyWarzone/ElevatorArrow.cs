using UnityEngine;

namespace tinyWarzone.Entities.Components
{
    public class ElevatorArrow : BaseEntityComponent<Elevator>
    {
        public GameObject ArrowObj;
        public Vector2 UpDirection, DownDirection;
	}
}