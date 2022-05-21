using Humanlights.Extensions;
using System.Collections;
using UnityEngine;

namespace tinyWarzone.Player
{
    public class PlayerModes : PlayerComponent
    {
        [System.Serializable]
        public class ValueSet
        {
            public float RightOffset;
            public float Distance;
            public float Height;
            public bool ShowBody;
            public float Y_Rotation = 15f;
            public float LookForwardIdleTime = -1f;
            public float RealignmentLerp = 1.5f;
            public Transform RealignmentTarget;
        }
        public enum ModeTypes
        {
            ThirdPerson,
            FirstPerson,
            Drone,
            VehicleFirstPerson,
            VehicleFirstPersonDefocus,
            VehicleThirdPerson,
            Doll
        }
        public float TransitionTime = 1.35f;
        public ValueSet ThirdPerson, FirstPerson, Drone, VehicleFirstPerson, VehicleFirstPersonDefocus, VehicleThirdPerson, DollFirstPerson;
        public bool Lock = true;
	}
}