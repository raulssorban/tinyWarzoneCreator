using UnityEngine;

namespace tinyWarzone
{
    public class Rotor : HumanlightsBehaviour
    {
        public float Lerp = 0.25f;
        public float Speed;
        public float CurrentSpeed;
        [Space]
        public bool RotateX;
        public bool RotateY = true;
        public bool RotateZ;
        public float RegenerateSpeedAfterSeconds;
        public bool UseRandomSpeed = true;
        public float MinRandomSpeed = 0f;
        public float MaxRandomSpeed = 15.0f;
        private Humanlights.Tools.Timer Generator;
	}
}