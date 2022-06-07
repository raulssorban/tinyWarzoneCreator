using UnityEngine;

namespace tinyWarzone.Objects
{
    public class Cable : HumanlightsListableBehaviour<Cable>
    {
        public Rigidbody EndPoint;
        public float DragPower = 1f;
        public float DragDistanceMultiply = 2.5f;
        [Header ( "Settings" )]
        public float CableLength = 0.5f;
        public int TotalSegments = 5;
        public float SegmentsPerUnit = 6f;
        public float CableWidth = 0.1f;
        [Header ( "References" )]
        public Material Material;
        [Header ( "Processing" )]
        public int VerletIterations = 1;
        public int SolverIterations = 2;
        [ReadOnly] public int Segments = 0;
        [ReadOnly] public LineRenderer Line;
        [ReadOnly] public CableParticle [] Points;
	}
}