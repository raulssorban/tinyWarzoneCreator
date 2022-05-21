using UnityEngine;

namespace tinyWarzone.Objects
{
    public class Cable : HumanlightsListableBehaviour<Cable>
    {
        public Rigidbody EndPoint;
        public float DragPower = 1f;
        public float DragDistanceMultiply = 2.5f;
        public float CableLength = 0.5f;
        public int TotalSegments = 5;
        public float SegmentsPerUnit = 6f;
        public float CableWidth = 0.1f;
        public Material Material;
        public int VerletIterations = 1;
        public int SolverIterations = 2;
	}
}