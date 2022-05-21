using UnityEngine;

namespace tinyWarzone.Traffic
{
    public class Waypoint : HumanlightsBehaviour
    {
        public float NeededBrakeSpeed = -1;
        public float WaitTime = 0f;
        public float SkipSensorDistance = 2.5f;
        public float NeededDistance = 3f;
        public float DistanceCompensation = 3.5f;
        public float ConsideredAngles = 7.5f;
        public float MaximumAcceleration = 0.3f;
        public float MinimumAcceleration = -0.1f;
	}
}