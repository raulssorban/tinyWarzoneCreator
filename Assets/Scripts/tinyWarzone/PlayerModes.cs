using Humanlights.Extensions;
using Humanlights.Tools;
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
            [LargeHeader ( "Idle Realignment" )]
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
        [ReadOnly] public ModeTypes Mode = ModeTypes.ThirdPerson;
        [ReadOnly] public ModeTypes PreviousMode = ModeTypes.ThirdPerson;
        public float TransitionTime = 1.35f;
        public ValueSet ThirdPerson, FirstPerson, Drone, VehicleFirstPerson, VehicleFirstPersonDefocus, VehicleThirdPerson, DollFirstPerson;
        public bool Lock = true;
        [ReadOnly] public float MouseX = 0f;
        [ReadOnly] public float MouseY = 0f;
        [ReadOnly] public int LastMovementValue = 0;
        [ReadOnly] public bool IsRotating;
	}
}